using DatabaseManagerV1.Helpers;
using DatabaseManagerV1.Structures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace DatabaseManagerV1.Managers
{
	public class CoreCodeSharingApp : ManagersTemplate
	{
		SqlConnection con = new SqlConnection(Pool.ConnectionStrings.Core_CodeSharingApp);
		public GeneralServiceHelper serviceHelper = new GeneralServiceHelper("MSSQLSERVER");
		public override object? RequestQuery(string query, bool returns = false)
		{
			object? result = null;
			try
			{
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
			return base.ToString()+"\nDatabase\t:MS SQL SERVER";
		}
	}
}
