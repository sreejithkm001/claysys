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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-D1ENE1B4\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True");

        
        private void text_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = text_user.Text;
            user_password = text_pass.Text;
            try
            {
                String query = "SELECT * FROM Login_new WHERE username='" + text_user.Text + "' AND password ='" + text_pass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = text_user.Text;
                    user_password = text_pass.Text;
                    //next page
                    Menuform ss = new Menuform();
                    ss.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid details");
                    text_user.Clear();
                    text_pass.Clear();

                    //to focus username
                    text_user.Focus();
                }

            }
            catch
            {
                MessageBox.Show("please check your username and password");
            }
            finally
            {
                conn.Close();
            }




        }

        private void button_exit_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
