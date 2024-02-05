using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace DatabaseManagerV1.Helpers
{
	public static class GeneralServiceHelper
	{
		/// <summary>
		/// Checks current status of specified service
		/// sends stop or start requests by parameter <![CDATA[AskForStartStop]]>
		/// </summary>
		/// <param name="AskForStartStop"></param>
		/// <returns><see cref="bool"/><br></br> 
		/// result reasons
		/// <list type="number">
		/// <item>true(service running)</item>
		/// <item>false(service not exists or stopped)</item>
		/// </list>
		/// </returns>
		public static bool IsServiceRunning(string ServiceName, bool AskForStartStop = false)
		{
			bool result = false;
			try
			{
				ProcessStartInfo pinf = new ProcessStartInfo()
				{
					FileName = "cmd",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true,
					Verb = "runas",
					Arguments = $"/c sc query {ServiceName}"
				};
				Process p1 = new Process();
				p1.StartInfo = pinf;
				p1.Start();
				string output = p1.StandardOutput.ReadToEnd();
				if (output.StartsWith("[SC]", StringComparison.InvariantCultureIgnoreCase))
				{
					throw new Exception("Service not existing");
				}
				else
				{
					output = output.Split("\n")[3].Replace(" ", "").Substring("state:0".Length);
					output = output.Substring(0, output.Length - 1);
					switch (output)
					{
						case "STOPPED":
						case "STOP_PENDING":
							result = false;
							break;
						case "RUNNING":
						case "START_PENDING":
							result = true;
							break;
					}
				}
				if (AskForStartStop)
				{
					if (result)
					{
						if (MessageBox.Show($"{ServiceName} is runing\nWant to stop service ?", "Service Status", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
						{
							StopService(ServiceName);
						}
					}
					else
					{
						if (MessageBox.Show($"{ServiceName} not runing\nWant to start service ?", "Service Status", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						{
							StartService(ServiceName);
						}
					}
				}
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
			return result;
		}

		private static void StartService(string ServiceName)
		{
			Process.Start(new ProcessStartInfo()
			{
				FileName = "cmd",
				UseShellExecute = true,
				Verb = "runas",
				CreateNoWindow = true,
				Arguments = $"/c sc start {ServiceName}"
			});
		}

		private static void StopService(string ServiceName)
		{
			Process.Start(new ProcessStartInfo()
			{
				FileName = "cmd",
				UseShellExecute = true,
				Verb = "runas",
				CreateNoWindow = true,
				Arguments = $"/c sc stop {ServiceName}"
			});
		}

	}
}
