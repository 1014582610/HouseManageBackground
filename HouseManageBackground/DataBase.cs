using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;　

namespace HouseManageBackground
{
    public class DataBase
    {
        private SqlConnection connection;
        public static string connstr = Properties.Settings.Default.fcglConnectionString;

        public DataBase()
        {

        }

        public void Open()
        {
            if (connection == null || !connection.State.Equals("open"))
            {
                connection = new SqlConnection(connstr);
                connection.Open();
                //MessageBox.Show("open");
            }

        }

        public void Close()
        {
            if (connection != null)
            {
                connection.Close();
                //MessageBox.Show("close");
            }
            
        }

        public int Insert_Row(string SQLstring)
        {
            int count;
            this.Open();
            SqlCommand cmd = new SqlCommand(SQLstring,this.connection);
            count = cmd.ExecuteNonQuery();
            this.Close();
            return count;
        }

        public int Update_Row(string SQLstring)
        {
            int count;
            this.Open();
            SqlCommand cmd = new SqlCommand(SQLstring,this.connection);
            count = cmd.ExecuteNonQuery();
            this.Close();
            return count;
        }

        public int Find_PK(string SQLstring)
        {
            int id;
            this.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SQLstring, this.connection);
            adapter.Fill(dt);
            id =  (int)dt.Rows[0]["person_id"];
            this.Close();
            return id;
        }

        public int Find_PK_ByName(string name)
        {
            int id;
            this.Open();
            DataTable dt = new DataTable();
            string SQLstring = "select * from person where names like '%"+name+"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(SQLstring, this.connection);
            adapter.Fill(dt);
            id = (int)dt.Rows[0][0];
            this.Close();
            return id;
        }

        public void Fill_Table_ByName(string name, DataTable datatable)
        {
            //DataTable resulttable = new DataTable();

            List<int> idlist = new List<int>();
            this.Open();
            DataTable dt = new DataTable();
            string SQLstring = "select * from person where names like '%" + name + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(SQLstring,this.connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                //idlist.Add((int)dt.Rows[i][0]);
                int tempid = (int)dt.Rows[i]["person_id"];
                DataTable temptable = new DataTable();
                string str = "select * from agent where person_id = '" + tempid +"'";
                SqlCommand tempcmd = new SqlCommand(str,this.connection);
                adapter.SelectCommand = tempcmd;
                adapter.Fill(temptable);
                if (temptable.Rows.Count > 0)
                {
                    DataRow row = temptable.Rows[0];
                    //MessageBox.Show(row["person_id"].ToString());
                    datatable.Rows.Add(row.ItemArray);
                }
                    
            }
            this.Close();
            //datatable = resulttable;
        }

        public void Fill_Table(string SQLstring, DataTable dt)
        {
            this.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQLstring, this.connection);
            adapter.Fill(dt);
            this.Close();
        }

        public void Fill_Table(string SQLstring, DataTable dt, params SqlParameter[] parameters)
        {
            this.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(SQLstring, this.connection);
            if (parameters.Length > 0)
            {
                adapter.SelectCommand.Parameters.AddRange(parameters);
            }
            adapter.Fill(dt);
            this.Close();
        }

        public void Delete_Row(string SQLstring, DataTable dt, params SqlParameter[] parameters)
        {
            this.Open();
            SqlTransaction tran = this.connection.BeginTransaction();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand();
            adapter.DeleteCommand.Connection = this.connection;
            adapter.DeleteCommand.CommandText = SQLstring;
            if (parameters.Length > 0)
            {
                adapter.DeleteCommand.Parameters.AddRange(parameters);
            }
            adapter.DeleteCommand.Transaction = tran;
            adapter.Update(dt);
            //执行回滚
            tran.Commit();
            this.Close();
        }
    }
}
