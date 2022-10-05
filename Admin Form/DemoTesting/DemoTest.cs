using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace University_Info_Center.Admin_Form.DemoTesting
{
    public partial class DemoTest : Form
    {
        public DemoTest()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MYSQL Connection 
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root; password=admin;database=project");

            MySqlCommand cmd = null;
            string dbUserName = "";
            string dbPassword = "";
            string UserName = "";
            string Password = "";
            conn.Open();

            // To Get Username//
            dbUserName = "select username from project.login where username='" + txtUsername.Text + "'";

            cmd = new MySqlCommand(dbUserName, conn);
            cmd.ExecuteNonQuery();
            var getUserName = cmd.ExecuteReader();
            if(getUserName.HasRows)
            {
                getUserName.Read();
                UserName = getUserName.GetString(0);
            }
            getUserName.Close();
            //-----------//

            // To Get Password //
            dbPassword = "select password from project.login where username='" + txtUsername.Text + "'";
            cmd = new MySqlCommand(dbPassword, conn);
            cmd.ExecuteNonQuery();
            var getPassword = cmd.ExecuteReader();
            if (getPassword.HasRows)
            {
                getPassword.Read();
                Password = getPassword.GetString(0);
            }
            getPassword.Close();

            conn.Close();
            //-----------------------------//

            lblUserName.Text = UserName;
            lblPassword.Text = Password;
        }
    }
}
