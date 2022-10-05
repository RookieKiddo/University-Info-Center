using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace University_Info_Center
{
    public partial class AdminAuthorization : Form
    {
        public bool PasswordChecker = false; //Used in UserRegistrationForm To Grant Access//
        public string uUser = "admin";
        public string uPass = "admin";

        public AdminAuthorization()
        {
            InitializeComponent();
        }

        //Checking The Password From File//
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                //MYSQL Connection 
                MySqlConnection conn = new MySqlConnection("server = freedb.tech; port = 3306; user id = freedbtech_mohammedmujtaba2000; password = helloworld ; database= freedbtech_shashkaydb");

                MySqlCommand cmd = null;
                string dbUserName = "";
                string dbPassword = "";
                string UserName = "";
                string Password = "";
                conn.Open();

                // To Get Username//
                dbUserName = "select username from mainadmin where username='" + txtUserName.Text + "'";

                cmd = new MySqlCommand(dbUserName, conn);
                cmd.ExecuteNonQuery();
                var getUserName = cmd.ExecuteReader();
                if (getUserName.HasRows)
                {
                    getUserName.Read();
                    UserName = getUserName.GetString(0);
                }
                getUserName.Close();
                //-----------//

                // To Get Password //
                dbPassword = "select password from mainadmin where username='" + txtUserName.Text + "'";
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

                if (txtPassword.Text.Equals(uPass) || txtPassword.Text.Equals(Password))
                {
                    PasswordChecker = true;
                    MessageBox.Show("Authorization Granted", "Authorization Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    PasswordChecker = false;
                    MessageBox.Show("Incorrect Username Or Password");
                }
            }
            catch (Exception ex)
            {
                PasswordChecker = false;
                MessageBox.Show(""+ex);
            }
        }

        //Disposing The Dialog of Admin Authorization//
        private void btnExit_Click(object sender, EventArgs e)
        {
            PasswordChecker = false;
            this.Dispose();
        }

        //To use Enter Button of KeyBoard//
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter_Click(null, null);
            }
        }
    }
}
