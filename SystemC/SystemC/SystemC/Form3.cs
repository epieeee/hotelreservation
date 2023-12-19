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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Pending.Checked = true;
            string conn = "Data Source=NIGHTCRAWLER\\SQLEXPRESS;Initial Catalog=datares;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "Select * From Reservation5";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            clearF();
            dgvStock.DataSource = table;
            con.Close();
        }
        public void clearF()
        {
            tbnum1.Clear();
            tbmonthin.Clear();
            tbdayIn.Clear();
            tbmonthsout.Clear();
            tbdayOut.Clear();
            tbfname.Clear();
            tbposition.Clear();
            tbprice.Clear();
            tbmode.Clear();


        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbnum1.Text = dgvStock[0, e.RowIndex].Value.ToString();
            tbrooms.Text = dgvStock[1, e.RowIndex].Value.ToString();
            tbmonthin.Text = dgvStock[2, e.RowIndex].Value.ToString();
            tbdayIn.Text = dgvStock[3, e.RowIndex].Value.ToString();
            tbmonthsout.Text = dgvStock[4, e.RowIndex].Value.ToString();
            tbdayOut.Text = dgvStock[5, e.RowIndex].Value.ToString();
            tbfname.Text = dgvStock[6, e.RowIndex].Value.ToString();
            tbposition.Text = dgvStock[7, e.RowIndex].Value.ToString();
            tbprice.Text = dgvStock[8, e.RowIndex].Value.ToString();
            tbmode.Text = dgvStock[9, e.RowIndex].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(tbprice.Text);
            int num2 = Convert.ToInt32(tbdayIn.Text);
            int num3 = Convert.ToInt32(tbdayOut.Text);
            int num4 = Convert.ToInt32(tbnum1.Text);

            SqlConnection con = new SqlConnection("Data Source=NIGHTCRAWLER\\SQLEXPRESS;Initial Catalog=datares;Integrated Security=True");
            con.Open();
            string query = "UPDATE Reservation5 SET Room  = '" + tbrooms.Text +
                              "',  Inmonths    ='" + tbmonthin.Text +

                                 "', Indays      ='" +
                     num2 +
                      "',  Outmonths    ='" + tbmonthsout.Text +
                                 "', Outdays      ='" +
                     num3 +
                                  "', Fname      ='" +
                      tbfname.Text +
                                   "', Lname      ='" +
                     tbposition.Text +
                       "', Price     ='" + num1 +
                             "', TypePayment     = '" + tbmode.Text +


                      "'WHERE Num = '" + num4 + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated!");
            clearF();
            Form3_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Pending.Checked)
            {
                tbposition.Text = "Pending";

            }
            else
            {
                tbposition.Text = "Confirmed";
            }
        }

        private void Pending_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbmonthOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmonthOut.Text == "january")
            {
                tbmonthsout.Text = "january";
            }
            if (cmbmonthOut.Text == "febuary")
            {
                tbmonthsout.Text = "febuary";
            }
            if (cmbmonthOut.Text == "march")
            {
                tbmonthsout.Text = "march";
            }
            if (cmbmonthOut.Text == "april")
            {
                tbmonthsout.Text = "april";
            }
            if (cmbmonthOut.Text == "may")
            {
                tbmonthsout.Text = "may";
            }
            if (cmbmonthOut.Text == "june")
            {
                tbmonthsout.Text = "june";
            }
            if (cmbmonthOut.Text == "july")
            {
                tbmonthsout.Text = "july";
            }
            if (cmbmonthOut.Text == "august")
            {
                tbmonthsout.Text = "august";
            }
            if (cmbmonthOut.Text == "september")
            {
                tbmonthsout.Text = "september";
            }
            if (cmbmonthOut.Text == "october")
            {

                tbmonthsout.Text = "october";
            }
            if (cmbmonthOut.Text == "november")
            {
                tbmonthsout.Text = "november";
            }
            if (cmbmonthOut.Text == "december")
            {
                tbmonthsout.Text = "december";
            }

        }

        private void cmbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmonth.Text == "january")
            {
                tbmonthin.Text = "january";
            }
            if (cmbmonth.Text == "febuary")
            {
                tbmonthin.Text = "febuary";
            }
            if (cmbmonth.Text == "march")
            {
                tbmonthin.Text = "march";
            }
            if (cmbmonth.Text == "april")
            {
                tbmonthin.Text = "april";
            }
            if (cmbmonth.Text == "may")
            {
                tbmonthin.Text = "may";
            }
            if (cmbmonth.Text == "june")
            {
                tbmonthin.Text = "june";
            }
            if (cmbmonth.Text == "july")
            {
                tbmonthin.Text = "july";
            }
            if (cmbmonth.Text == "august")
            {
                tbmonthin.Text = "august";
            }
            if (cmbmonth.Text == "september")
            {
                tbmonthin.Text = "september";
            }
            if (cmbmonth.Text == "october")
            {

                tbmonthin.Text = "october";
            }
            if (cmbmonth.Text == "november")
            {
                tbmonthin.Text = "november";
            }
            if (cmbmonth.Text == "december")
            {
                tbmonthin.Text = "december";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var res = MessageBox.Show("Are you sure you want to delete this record? ",
            "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string num = tbnum1.Text;

                string conn = "Data Source=NIGHTCRAWLER\\SQLEXPRESS;Initial Catalog=datares;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                con.Open();


                string query = "Delete from Reservation5 where Num = " + num + " ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted!");
                clearF();
                Form3_Load(sender, e);
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdbConfirm.Checked)
            {
                tbposition.Text = "Confirmed";
            }
        }
    }
}
