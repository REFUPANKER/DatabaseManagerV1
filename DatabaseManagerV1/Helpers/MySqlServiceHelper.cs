using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseManagerV1.Helpers
{
	public class MySqlServiceHelper
	{
		/// <summary>
		/// if service not exists,also returns false
		/// </summary>
		/// <param name="check"></param>
		/// <returns></returns>
		public static bool IsMySqlRunning(bool check = false)
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
					Arguments = "/c sc query mysql80"
				};
				Process p1 = new Process();
				p1.StartInfo = pinf;
				p1.Start();
				string output = p1.StandardOutput.ReadToEnd();

				if (output.StartsWith("[SC]"))
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
				if (check)
				{
					if (result)
					{
						if (MessageBox.Show("Mysql80 is runing\nWant to stop service ?", "Service Status", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
						{
							StopMySqlService();
						}
					}
					else
					{
						if (MessageBox.Show("Mysql80 not runing\nWant to start service ?", "Service Status", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
						{
							StartMySqlService();
						}
					}	
				}
			}
			catch (Exception e) { MessageBox.Show(e.Message); }
			return result;
		}

		public static void StartMySqlService()
		{
			Process.Start(new ProcessStartInfo()
			{
				FileName = "cmd",
				UseShellExecute = true,
				Verb = "runas",
				CreateNoWindow = true,
				Arguments = "/c sc start mysql80"
			});
		}

		public static void StopMySqlService()
		{
			Process.Start(new ProcessStartInfo()
			{
				FileName = "cmd",
				UseShellExecute = true,
				Verb = "runas",
				CreateNoWindow = true,
				Arguments = "/c sc stop mysql80"
			});
		}
	}
}
