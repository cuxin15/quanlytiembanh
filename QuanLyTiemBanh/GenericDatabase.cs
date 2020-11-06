using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyTiemBanh
{
	class GenericDatabase
	{
		string connect_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\truon\source\repos\quanlytiembanh2\QuanLyTiemBanh\Database1.mdf;Integrated Security=True";
		SqlConnection connection;
		public GenericDatabase()
		{
			connection = new SqlConnection(connect_string);
		}

		public object QuerySQL(string sql)
		{
			SqlCommand command = new SqlCommand(sql, this.connection);
			connection.Open();
			object output = command.ExecuteScalar();
			connection.Close();
			return output;
		}

		public int NonQuerySQL(string sql)
		{
			SqlCommand command = new SqlCommand(sql, this.connection);
			connection.Open();
			int output = command.ExecuteNonQuery();
			connection.Close();
			return output;
		}

		public DataTable LoadTable(string sql)
		{
			DataTable output = new DataTable();
			SqlDataAdapter adap = new SqlDataAdapter(sql, connection);
			adap.Fill(output);
			return output;
		}
	}
}
