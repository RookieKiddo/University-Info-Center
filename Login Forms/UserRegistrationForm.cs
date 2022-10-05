using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace University_Info_Center
{
    public partial class UserRegistrationForm : Form
    {

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Are You Sure To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (D == DialogResult.Yes)
            {
                this.Dispose(); // Closes Registration Form//
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            //checking if all fields are complete or not//
            if (txtFName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtFName.Focus();
            }
            else if (txtLName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtLName.Focus();
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtEmail.Focus();
            }
            else if (txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPassword.Focus();
            }
            else if (txtRPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill All Required Fields", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRPassword.Focus();
            }
            else if(!rdbtnAdmin.Checked && !rdbtnCon.Checked)
            {
                MessageBox.Show("Please Select Authrization Rights", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //Admin Authoraization Requirment.//
                AdminAuthorization AD = new AdminAuthorization();
                AD.ShowDialog();

                //Creating New Account//
                if (AD.PasswordChecker == true)
                {
                    if (txtPassword.Text.Equals(txtRPassword.Text))
                    {
                        //Insert Data into the database
                        try
                        {
                            if (rdbtnCon.Checked)
                            {
                                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                                MySqlCommand cmd = null;
                                string cmdString = "";
                                conn.Open();

                                cmdString = "INSERT INTO `login` (`FirstName`, `LastName`, `Email`, `Username`, `Password`) VALUES ('" + txtFName.Text + "','" + txtLName.Text + "','" + txtEmail.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "')";

                                cmd = new MySqlCommand(cmdString, conn);
                                cmd.ExecuteNonQuery();

                                conn.Close();

                                MessageBox.Show("New Contributor Account Created Successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //-------------------------//
                            }
                            else if (rdbtnAdmin.Checked)
                            {
                                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                                MySqlCommand cmd = null;
                                string cmdString = "";
                                conn.Open();

                                cmdString = "INSERT INTO `mainadmin` (`FirstName`, `LastName`, `Email`, `Username`, `Password`) VALUES ('" + txtFName.Text + "','" + txtLName.Text + "','" + txtEmail.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "')";

                                cmd = new MySqlCommand(cmdString, conn);
                                cmd.ExecuteNonQuery();

                                conn.Close();

                                MessageBox.Show("New Administrator Account Created Successfully", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //-------------------------//
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(""+ex);
                        }
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Password Doesn't Match", "Retype Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //If Password Doesn't Match with retype password.//
                        txtRPassword.Text = null;
                        txtRPassword.Focus();
                    }
                }
            }
        }

        //Show or Hide Password//
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtRPassword.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRPassword.UseSystemPasswordChar = true;
            }
        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
