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

namespace Ayubo_Travels
{
    public partial class Login : Form
    {
        private object txtPas;

        public Login()
        {
            InitializeComponent();
        }

        //establishing the connection
        SqlConnection Conn = new SqlConnection("Data Source = DESKTOP - VQES27D; Initial Catalog = Ayubo_Drive; Integrated Security = True");
        //establishing the sqlcommand
        SqlCommand cmd = new SqlCommand();
        //sql DataAdapter
        SqlDataAdapter SDa = new SqlDataAdapter();



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, you want to Exit???",
            "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String uname = txtUName.Text;
            String password = txtUPass.Text;

            try
            {
                String queLog = "SELECT * FROM LoginTbl WHERE UserName= '" + txtUName.Text + "' AND Password= '" + txtUPass.Text + "'";

                Conn.Open();
                SqlDataAdapter SDa = new SqlDataAdapter();
                DataTable Dt = new DataTable();
                SDa.Fill(Dt);

                if (Dt.Rows.Count > 0)
                {
                    uname = txtUName.Text;
                    password = txtUPass.Text;

                    MainForm mainform = new MainForm();
                    mainform.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login Details!!", "LOGINS INVALID!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUName.Clear();
                    txtUPass.Clear();
                    txtUName.Focus();
                }
            }
          }
    }
}
            
            
          

    

            
            

