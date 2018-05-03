using System;
using System.Collections.Generic;
using System.Text;

namespace weeklyplanner.Services
{
	public interface ITextToSpeech
	{
		void Speak(string text);
	}
}
