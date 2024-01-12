using System;
namespace DatabaseManagerV1.Pool
{
	public static class ConnectionStrings
	{
		public static string Core_CodeSharingApp { get => $"server={Environment.MachineName};database=Test1;Trusted_Connection=True;"; }
		public static string Core_Hotel { get => $"server=localhost;uid=root;password=12345;database=t4sch"; }
	}
}
