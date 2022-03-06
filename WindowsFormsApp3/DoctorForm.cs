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

namespace WindowsFormsApp3
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\OneDrive\Belgeler\HospitalManagementSystemdb.mdf;Integrated Security=True;Connect Timeout=30");
        public DoctorForm()
        {
            InitializeComponent();
        }
    void populate()
        {
            Con.Open();
            string query = "select * from DoctorTable";
            SqlDataAdapter ad = new SqlDataAdapter(query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            DoctorNote.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocID.Text == "" || DoctorName.Text == "" || DoctorExp.Text == "" || DocPass.Text == "")
                MessageBox.Show("Please Fill All Parts");
            else
            {
                Con.Open();
                string query = "insert into DoctorTable values(" + DocID.Text + ",'" + DoctorName.Text + "'," + DoctorExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor information seccessfully Added.");
                Con.Close();
                populate();
            }
        }

        private void DoctorNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
