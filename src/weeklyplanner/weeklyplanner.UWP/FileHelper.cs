using System.IO;
using Xamarin.Forms;
using weeklyplanner.UWP;
using Windows.Storage;
using weeklyplanner.Services;

[assembly: Dependency(typeof(FileHelper))]
namespace weeklyplanner.UWP
{
	public class FileHelper : IFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
			return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
		}
	}
}
