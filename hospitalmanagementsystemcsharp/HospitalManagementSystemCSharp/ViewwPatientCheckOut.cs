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

namespace HospitalManagementSystemCSharp
{
    public partial class ViewwPatientCheckOut : Form
    {
        public ViewwPatientCheckOut()
        {
            InitializeComponent();
        }

        private void ViewwPatientCheckOut_Load(object sender, EventArgs e)
        {
            
            this.checkoutTableAdapter.Fill(this.hospitalDataSet3.checkout);
            using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-GA3S5NJ;Initial Catalog=Hospital.MDF;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM checkout";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-GA3S5NJ;Initial Catalog=Hospital.MDF;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM checkout where id='"+textBox1.Text +"'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
