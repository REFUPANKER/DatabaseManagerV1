using DatabaseManagerV1.Helpers;
using System.Diagnostics.CodeAnalysis;

namespace DatabaseManagerV1.Templates
{
	public class ManagersTemplate
	{
		public virtual object? RequestQuery(string query, bool returns = false) { return null; }
		[AllowNull]
		public virtual string ServiceName { get; }
		public bool CheckService(bool AskForStartStop)
		{
			return GeneralServiceHelper.IsServiceRunning(this.ServiceName, AskForStartStop);
		}
		public override string ToString()
		{
			return "Name\t\t:" + this.GetType().Name + "\nTotal Methods\t:" + (this.GetType().GetMethods().Length - 4);
		}
	}
}
