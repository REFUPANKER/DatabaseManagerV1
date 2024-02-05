using DatabaseManagerV1.Templates;
using MySqlConnector;
using System;
using System.Data;
using System.Windows;

namespace DatabaseManagerV1.Managers
{
	public class CoreHotel : ManagersTemplate
	{
		public override string ServiceName { get => "MySql80"; }
		private MySqlConnection connection = new MySqlConnection(Pool.ConnectionStrings.Core_Hotel);

		public override object? RequestQuery(string query, bool returns = false)
		{
			object? result = null;
			try
			{
				if (!CheckService(false)) { return null; }
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
