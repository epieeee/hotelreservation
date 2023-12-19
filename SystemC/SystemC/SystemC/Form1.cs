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

namespace SystemC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sendtext = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbuser.Text != "Admin" && tbpass.Text != "Cherry")
            {
                string user = tbuser.Text;
                string pass = tbpass.Text;
                string conn = "Data Source=NIGHTCRAWLER\\SQLEXPRESS;Initial Catalog=datares;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select * From account Where firstname = @firstname and pass = @pass", con);
                cmd.Parameters.AddWithValue("@firstname", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Welcome To my System " + tbuser.Text);
                    sendtext = tbuser.Text;

                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account!");



                }
                con.Open();
            }
            else if (tbuser.Text == "Admin" && tbpass.Text == "Cherry")
            {
                MessageBox.Show("Welcome Mrs." + tbuser.Text);
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
