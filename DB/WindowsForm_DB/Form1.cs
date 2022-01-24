using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = AdventureWorks2017; Data Source = USER\\SQLEXPRESS"))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Production.Product ", cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LBResult.Items.Add(reader[0]+ " " + reader[1]);
                        }
                    }    
                }
            }

        }
        
    }
}
