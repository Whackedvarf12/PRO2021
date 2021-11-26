using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Povezan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p=@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sql = new SqlConnection(p);
            String ukaz = "select * from employees where country=@Country";
            SqlCommand u = new SqlCommand();
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@Country", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            sql.Open();
            SqlDataReader reader = u.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["FirstName"]+" "+reader["LastName"]);
            }
            reader.Close();
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String p = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sql = new SqlConnection(p);
            String ukaz = "select count(*) from employees";
            SqlCommand u = new SqlCommand();
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@Country", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            sql.Open();
            SqlDataReader reader = u.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]);
            }
            reader.Close();
            sql.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String p = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sql = new SqlConnection(p);
            String ukaz = "update Employees set Country = 'NZ' where Country = 'USA'";
            SqlCommand u = new SqlCommand();
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@Country", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            sql.Open();
            int i=u.ExecuteNonQuery();
            listBox1.Items.Add(i);
            sql.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String p = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sql = new SqlConnection(p);
            String ukaz = "Select t.TerritoryDescription, r.RegionDescription from Region as r inner join Territories as t on r.RegionID=t.RegionID order by r.RegionDescription";
            SqlCommand u = new SqlCommand();
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@Country", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            sql.Open();
            SqlDataReader reader = u.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0]+" "+reader[1]);
            }
            reader.Close();
            sql.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String p = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\PRO2021\northwnd.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection sql = new SqlConnection(p);
            String ukaz = "UPDATE Region SET RegionDescription='East' WHERE RegionDescription='Vzhod'";
            SqlCommand u = new SqlCommand();
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@Country", SqlDbType.NChar);
            u.Parameters.Add(par);
            par.Value = textBox1.Text;

            sql.Open();
            int i = u.ExecuteNonQuery();
            listBox1.Items.Add(i);
            sql.Close();
        }
    }
}
