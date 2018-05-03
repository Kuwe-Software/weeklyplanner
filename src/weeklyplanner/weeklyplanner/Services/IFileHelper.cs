using System;
using System.Collections.Generic;
using System.Text;

namespace weeklyplanner.Services
{
	public interface IFileHelper
	{
		string GetLocalFilePath(string filename);
	}
}
