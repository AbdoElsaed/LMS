using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS_2
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=APDO-PC;Initial Catalog=LMS;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LOGIN where Username='" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                App ss = new App();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }
            
        }
    }
}
