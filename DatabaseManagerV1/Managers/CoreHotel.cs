using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using DatabaseManagerV1.Helpers;
using System.Windows;
using DatabaseManagerV1.Structures;

namespace DatabaseManagerV1.Managers
{
	public class CoreHotel : ManagersTemplate
	{
		private MySqlConnection connection = new MySqlConnection(Pool.ConnectionStrings.Core_Hotel);

		public override object? RequestQuery(string query, bool returns = false)
		{
			object? result = null;
			try
			{
				if (MySqlServiceHelper.IsMySqlRunning() == false)
				{
					throw new Exception("Service is stopped or not existing");
				}
				connection.Close();
				connection.Open();
				MySqlCommand command = new MySqlCommand(query, connection);
				command.ExecuteNonQuery();
				if (returns || query.Contains("select", StringComparison.InvariantCultureIgnoreCase))
				{
					MySqlDataReader reader = command.ExecuteReader();
					DataTable dataTable = new DataTable();
					dataTable.Load(reader);
					reader.Close();
					result = dataTable;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				connection.Close();
			}
			return result;
		}
		public override string ToString()
		{
			return base.ToString() + "\nDatabase\t:My Sql";
		}
	}
}
