using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
namespace Registrationform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D1ENE1B4\SQLEXPRESS;Initial Catalog=Youtube;Integrated Security=True");

        public int StudentID;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Studentrecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentrecord();
        }

        private void GetStudentrecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from Registration", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            Studentrecord.DataSource = dt;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Regex mob = new Regex("^[1-9]{10}");
            Regex pswrd = new Regex("/^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/");
            bool ispswrdvalid = pswrd.IsMatch(txtPassword.Text);
            bool isvalid = mob.IsMatch(txtMobile.Text);

            if (!isvalid)
            {
                MessageBox.Show("please enter valid mobile number");

            }
            else
            {
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Registration VALUES(@Name1,@Fathername,@RollNo,@Address,@Mobile,@Gender,@Password,@Confirmpassword)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name1", txtStudentname.Text);
                    cmd.Parameters.AddWithValue("@Fathername", txtFathersname.Text);
                    cmd.Parameters.AddWithValue("@RollNo", txtRollno.Text);
                    cmd.Parameters.AddWithValue("@Address", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Confirmpassword", txtConfirmpassword.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully saved");
                    GetStudentrecord();
                    Resetformcontrols();
                }



            }


        }

        private bool IsValid()
        {
            if (txtStudentname.Text == string.Empty)
            {
                MessageBox.Show("student name is required");
                return false;
            }
            if (txtFathersname.Text == string.Empty)
            {
                MessageBox.Show("father name is required");
                return false;
            }
            if (txtRollno.Text == string.Empty)
            {
                MessageBox.Show("RollNo is required");
                return false;
            }
            if (txtemail.Text == string.Empty)
            {
                MessageBox.Show("E-Mail is required");
                return false;
            }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(txtemail.Text, emailPattern))
            {
                MessageBox.Show("Invalid email address");
                return false;
            }
            if (txtMobile.Text == string.Empty)
            {
                MessageBox.Show("MobileNo is required");
                return false;
            }
            if (comboBox1.Text == string.Empty)
            {
                MessageBox.Show("Gender required");
                return false;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Password is required");
                return false;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long&contain at least one uppercase letter, one lowercase letter, and one digit");
                return false;
            }

            bool containsUpperCase = false;
            bool containsLowerCase = false;
            bool containsDigit = false;
            foreach (char c in txtPassword.Text)
            {
                if (char.IsUpper(c))
                {
                    containsUpperCase = true;
                }
                else if (char.IsLower(c))
                {
                    containsLowerCase = true;
                }
                else if (char.IsDigit(c))
                {
                    containsDigit = true;
                }
            }

            if (!containsUpperCase || !containsLowerCase || !containsDigit)
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, and one digit");
                return false;
            }
            if (txtConfirmpassword.Text != txtPassword.Text)
            {


                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "ERROR";
                MessageBox.Show("Re-enter password");
                return false;
            }

            return true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resetformcontrols();

        }

        private void Resetformcontrols()
        {
            StudentID = 0;
            txtStudentname.Clear();
            txtFathersname.Clear();
            txtemail.Clear();
            txtMobile.Clear();
            txtRollno.Clear();
            comboBox1.SelectedIndex = -1;
            txtPassword.Clear();
            txtConfirmpassword.Clear();
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void Studentrecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(Studentrecord.SelectedRows[0].Cells[0].Value);
            txtStudentname.Text = Studentrecord.SelectedRows[0].Cells[1].Value.ToString();
            txtFathersname.Text = Studentrecord.SelectedRows[0].Cells[2].Value.ToString();
            txtRollno.Text = Studentrecord.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = Studentrecord.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile.Text = Studentrecord.SelectedRows[0].Cells[5].Value.ToString();
            comboBox1.Text = Studentrecord.SelectedRows[0].Cells[6].Value.ToString();
            txtPassword.Text = Studentrecord.SelectedRows[0].Cells[7].Value.ToString();
            txtConfirmpassword.Text = Studentrecord.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // if (StudentID > 0)
            //{
                if (IsValid())
                {
                    SqlCommand cmd = new SqlCommand("UPDATE  Registration SET Name=@Name,Fathername=@Fathername,RollNo=@RollNo,[E-Mail]=@Address,Mobile=@Mobile,Gender=@Gender,Password=@Password,Confirmpassword=@Confirmpassword WHERE StudentID=@ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtStudentname.Text);
                    cmd.Parameters.AddWithValue("@Fathername", txtFathersname.Text);
                    cmd.Parameters.AddWithValue("@RollNo", txtRollno.Text);
                    cmd.Parameters.AddWithValue("@Address", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Confirmpassword", txtConfirmpassword.Text);
                    cmd.Parameters.AddWithValue("@ID", this.StudentID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("successfully updated");
                    GetStudentrecord();
                    Resetformcontrols();
                }
          //  }
           // else
          //  {
          //      MessageBox.Show("please select a field to update");
          //  }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE from  Registration  WHERE StudentID=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully deleted");
                GetStudentrecord();
                Resetformcontrols();
            }
            else
            {
                MessageBox.Show("please select a field to delete");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
