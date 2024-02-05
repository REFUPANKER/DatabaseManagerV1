using DatabaseManagerV1.Templates;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace DatabaseManagerV1.Managers
{
	public class CoreCodeSharingApp : ManagersTemplate
	{
		public override string ServiceName => "MSSQLSERVER";
		SqlConnection con = new SqlConnection(Pool.ConnectionStrings.Core_CodeSharingApp);

		public override object? RequestQuery(string query, bool returns = false)
		{
			object? result = null;
			try
			{
				if (!CheckService(false)) { return null; }
				query = query.Replace("\"", "'");
				con.Close();
				con.Open();
				SqlCommand c1 = new SqlCommand(query, con);
				c1.ExecuteNonQuery();
				if (returns || query.ToLower().StartsWith("select", StringComparison.InvariantCultureIgnoreCase))
				{
					SqlDataReader reader = c1.ExecuteReader();
					DataTable dataTable = new DataTable();
					dataTable.Load(reader);
					result = dataTable;
					reader.Close();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				con.Close();
			}
			return result;
		}
		public override string ToString()
		{
			return base.ToString() + "\nDatabase\t:MS SQL SERVER";
		}
	}
}
