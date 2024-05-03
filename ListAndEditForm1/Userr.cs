using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListAndEditForm1.CourseNScore;

namespace ListAndEditForm1
{
    internal class Userr
    {
        MY_DB mydb = new MY_DB();

        

        public bool insertUser(int Id, string fname, string lname, string username, string password, MemoryStream fig)
        {
            SqlCommand command = new SqlCommand("INSERT INTO loginhuman (id, fname, lname, uname, pwd, fig)" + "VALUES (@id, @fn, @ln, @user, @pass,@fig)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fig", SqlDbType.Image).Value = fig.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool InsertUser(int Id, string fname, string lname, string username, string password, MemoryStream fig)
        {
            SqlCommand command = new SqlCommand("INSERT INTO loginhuman (id, fname, lname, uname, pwd, fig)" + "VALUES (@id, @fn, @ln, @user, @pass,@fig)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fig", SqlDbType.Image).Value = fig.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public DataTable getUser(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getUser1(string command)
        {
            SqlCommand cmd = new SqlCommand(command, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        
    }
}
