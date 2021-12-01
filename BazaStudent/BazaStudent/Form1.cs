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

namespace BazaStudent
{
    public partial class Form1 : Form
    {
        static String pov = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PRO2021\ŠtudentNet.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sql = new SqlConnection(pov);
        String ukaz = "";
        SqlCommand u = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void predmetbtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Rez:";
            ukaz = "Select oc.ocena from Ocene oc inner join Predmet pr on oc.idPredmeta=pr.idPredmeta where pr.ImePredmeta = '"+predmettxt.Text+"'";
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            sql.Open();
            SqlDataReader reader = u.ExecuteReader();
            while (reader.Read())
            {
                label1.Text += Environment.NewLine + (reader["ocena"]);
            }
            reader.Close();
            sql.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vsipredmetibtn_Click(object sender, EventArgs e)
        {
            label1.Text ="Rez:";
            ukaz = "Select * from Predmet";
            u.Connection = sql;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;

            sql.Open();
            SqlDataReader reader = u.ExecuteReader();
            while (reader.Read())
            {
                label1.Text+=Environment.NewLine+(reader["ImePredmeta"]);
            }
            reader.Close();
            sql.Close();
        }
    }
}
