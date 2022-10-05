using System;
using System.Windows.Forms;
using University_Info_Center.Admin_Form;
using MySql.Data.MySqlClient;
using University_Info_Center.User_Form;

namespace University_Info_Center
{
    public partial class UserForm : Form
    {
        public static string Username;
        public static bool AdminUserType = false; // For UserType used in Dashboard//
        public static bool ContUserType = false; // For UserType used in Dashboard//
        public bool AdminFormClick = false; //Used To Open Admin Form//

        public UserForm()
        {           
            InitializeComponent();
        }


        //Exit Application//
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Are You Sure To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (D == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //LoginIn//
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminAuthorization adminauthorize = new AdminAuthorization();
            try
            {
                //MYSQL Connection 
                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                string querryUserName = "";
                string dbUserName = "";
                string dbPassword = "";
                string UserName = "";
                string Password = "";
                string user = "";
                conn.Open();

                dbUserName = "select username from login where username='" + txtUsername.Text + "'";
                querryUserName = "select concat(FirstName, ' ', LastName) as Name from login where username='" + txtUsername.Text + "'";
                cmd = new MySqlCommand(dbUserName, conn);
                cmd.ExecuteNonQuery();

                // To Get Username//
                var getUserName = cmd.ExecuteReader();
                if (getUserName.HasRows)
                {
                    getUserName.Read();
                    UserName = getUserName.GetString(0);
                }
                getUserName.Close();

                // To Get The First and Last Name of User//
                cmd2 = new MySqlCommand(querryUserName, conn);
                cmd2.ExecuteNonQuery();
                var getUser = cmd2.ExecuteReader();
                if (getUser.HasRows)
                {
                    getUser.Read();
                    user = getUser.GetString(0);
                }
                getUser.Close();
                //-----------//

                // To Get Password //
                dbPassword = "select password from login where username='" + txtUsername.Text + "'";
                cmd = new MySqlCommand(dbPassword, conn);
                cmd.ExecuteNonQuery();
                var getPassword = cmd.ExecuteReader();
                if (getPassword.HasRows)
                {
                    getPassword.Read();
                    Password = getPassword.GetString(0);
                }
                getPassword.Close();
                //----------//

                conn.Close();
                //-----------------------------//

                //MYSQL Connection 
                MySqlConnection conn1 = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                MySqlCommand cmd1 = null;
                MySqlCommand cmd3 = null;
                string querryUserName1 = "";
                string dbUserName1 = "";
                string dbPassword1 = "";
                string UserName1 = "";
                string Password1 = "";
                string user1 = "";
                conn1.Open();

                dbUserName1 = "select username from mainadmin where username='" + txtUsername.Text + "'";
                querryUserName1 = "select concat(FirstName, ' ', LastName) as Name from mainadmin where username='" + txtUsername.Text + "'";
                
                // To Get Username//
                cmd1 = new MySqlCommand(dbUserName1, conn1);
                cmd1.ExecuteNonQuery();

                var getUserName1 = cmd1.ExecuteReader();
                if (getUserName1.HasRows)
                {
                    getUserName1.Read();
                    UserName1 = getUserName1.GetString(0);
                }
                getUserName1.Close();

                // To Get The First and Last Name of User//
                cmd3 = new MySqlCommand(querryUserName1, conn1);
                cmd3.ExecuteNonQuery();
                var getUser1 = cmd3.ExecuteReader();
                if (getUser1.HasRows)
                {
                    getUser1.Read();
                    user1 = getUser1.GetString(0);
                }
                getUser1.Close();
                //-----------//

                // To Get Password //
                dbPassword1 = "select password from mainadmin where username='" + txtUsername.Text + "'";
                cmd1 = new MySqlCommand(dbPassword1, conn1);
                cmd1.ExecuteNonQuery();
                var getPassword1 = cmd1.ExecuteReader();
                if (getPassword1.HasRows)
                {
                    getPassword1.Read();
                    Password1 = getPassword1.GetString(0);
                }
                getPassword1.Close();
                //----------//

                conn1.Close();
                //-----------------------------//


                //Cheking Whether the username and password matches//
                if (adminauthorize.uUser == txtUsername.Text && adminauthorize.uPass == txtPassword.Text)
                {
                    Username = "Backdoor Admin";
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else if(UserName == txtUsername.Text && Password == txtPassword.Text)
                {
                    Username = user;
                    ContUserType = true;
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else if (UserName1 == txtUsername.Text && Password1 == txtPassword.Text)
                {
                    Username = user1;
                    AdminUserType = true;
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password", "Incorrect User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
         }
        //-----------------------------------------------------------//

        //To Use Enter Button//
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        //To Use Enter Button//
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        //To Open Registration Form.//
        private void lnklblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm UF = new UserRegistrationForm();
            UF.ShowDialog();
        }

        //When Mouse is Clicking The Show Password Button Then The Password Will Be Visible//
        private void btnVisiblePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lnklblNormalUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserFormMain user = new UserFormMain();
            this.Hide();
            user.Show();
        }

        //When The Mouse Leaves The Click of Show Password Button Then The Password Will Hide Again//
        private void btnVisiblePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

    }
}
