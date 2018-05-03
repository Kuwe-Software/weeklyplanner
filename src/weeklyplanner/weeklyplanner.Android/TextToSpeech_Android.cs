using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using Java.Lang;
using weeklyplanner.Droid;
using weeklyplanner.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech_Android))]
namespace weeklyplanner.Droid
{
	public class TextToSpeech_Android : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
	{
		TextToSpeech speaker;
		string toSpeak;

		public IntPtr Handle => throw new NotImplementedException();

		public void Speak(string text)
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				toSpeak = text;
				if (speaker == null)
					speaker = new TextToSpeech(MainActivity.Instance, this);
				else
				{
					speaker.Speak(toSpeak, QueueMode.Flush, null, null);
				}
			}
		}

		#region IOnInitListener implementation
		public void OnInit(OperationResult status)
		{
			if (status.Equals(OperationResult.Success))
			{
				speaker.Speak(toSpeak, QueueMode.Flush, null, null);
			}
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}


		#endregion
	}
}