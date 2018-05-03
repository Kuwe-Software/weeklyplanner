using System;
using System.Diagnostics;
using weeklyplanner.Services;
using weeklyplanner.Views;
using Xamarin.Forms;

namespace weeklyplanner
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }
		static PlannerDatabase database;
		public static PlannerDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new PlannerDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("WkPlanner.db3"));
				}
				return database;
			}
		}
		public int ResumeAtItemId { get; set; }
		protected override void OnStart ()
		{
			//Debug.WriteLine("OnStart");

			//// always re-set when the app starts
			//// users expect this (usually)
			////			Properties ["ResumeAtTodoId"] = "";
			//if (Properties.ContainsKey("ResumeAtItemId"))
			//{
			//	var rati = Properties["ResumeAtItemId"].ToString();
			//	Debug.WriteLine("   rati=" + rati);
			//	if (!String.IsNullOrEmpty(rati))
			//	{
			//		Debug.WriteLine("   rati=" + rati);
			//		ResumeAtItemId = int.Parse(rati);

			//		if (ResumeAtItemId >= 0)
			//		{
			//			var itemPage = new ItemDetailPage();
			//			itemPage.BindingContext = Database.GetItemAsync(ResumeAtItemId);
			//			 MainPage.Navigation.PushAsync(itemPage, false); // no animation
			//		}
			//	}
			//}
		}

		protected override void OnSleep ()
		{
			//Debug.WriteLine("OnSleep saving ResumeAtItemId = " + ResumeAtItemId);
			//// the app should keep updating this value, to
			//// keep the "state" in case of a sleep/resume
			//Properties["ResumeAtItemId"] = ResumeAtItemId;
		}

		protected override void OnResume ()
		{
			//Debug.WriteLine("OnResume");
			//if (Properties.ContainsKey("ResumeAtItemId"))
			//{
			//	var rati = Properties["ResumeAtItemId"].ToString();
			//	Debug.WriteLine("   rati=" + rati);
			//	if (!String.IsNullOrEmpty(rati))
			//	{
			//		Debug.WriteLine("   rati=" + rati);
			//		ResumeAtItemId = int.Parse(rati);

			//		if (ResumeAtItemId >= 0)
			//		{
			//			var itemPage = new ItemDetailPage();
			//			itemPage.BindingContext = Database.GetItemAsync(ResumeAtItemId);
			//			MainPage.Navigation.PushAsync(itemPage, false); // no animation
			//		}
			//	}
			//}
		}
	}
}
