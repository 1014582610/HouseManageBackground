using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace HouseManageBackground
{
    public partial class NewerRegistion : Form
    {
        public NewerRegistion()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name = this.tb_name.Text;
            string password = this.tb_password.Text;
            string email = this.tb_email.Text.Trim();
            string phone = this.tb_phone.Text;
            string profession = this.tb_profession.Text;
            DateTime date1 = this.tb_register_date.Value;
            DateTime date2 = this.tb_valid_date.Value;
            int num = 0;
            //正则判断
            string pattern = @"[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})";
            if (!Regex.IsMatch(email, pattern))
            {
                this.tb_email.Focus();
                return;
            }
            //插入person
            string str = "insert into person(password,email,names,phone) values('" + password + "','" + email + "','" + name + "','" + phone + "')";
            DataBase db = new DataBase();
            db.Insert_Row(str);
            //插入agent
            string str1 = "select * from person where email = '"+email+"'";
            int person_id = db.Find_PK(str1);
            //MessageBox.Show(person_id.ToString());
            string str2 = "insert into agent values('" + person_id + "', '" + profession + "','" + date1 + "','" + date2 + "','" + num + "')";
            db.Insert_Row(str2);
            this.Close();
        }
    }
}
