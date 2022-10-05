using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace University_Info_Center.Admin_Form
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            ShowUserInfo();
            CountFields();
            CountUniversity();
            CountAdmin();
            CountContributor();
        }

        public void ShowUserInfo()
        {            
            lblUser.Text = UserForm.Username;
            lblLoginTime.Text = DateTime.Now.ToString();

            if(UserForm.AdminUserType == true)
            {
                lblUserType.Text = "Administator";
            }
            else if (UserForm.ContUserType == true)
            {
                lblUserType.Text = "Contributor";
            }
        }

        private void CountFields()
        {
            try
            {
                //MYSQL Connection 
                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                MySqlCommand cmd = null;
                string Querry = "";
                string FieldCount = "";
                conn.Open();

                // To Get Username//
                Querry = "select count(FeildID) from field;";

                cmd = new MySqlCommand(Querry, conn);
                cmd.ExecuteNonQuery();
                var getFieldCount = cmd.ExecuteReader();
                if (getFieldCount.HasRows)
                {
                    getFieldCount.Read();
                    FieldCount = getFieldCount.GetString(0);
                }
                getFieldCount.Close();
                conn.Close();
                //-----------//
                lblFieldCount.Text = FieldCount;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
        }

        private void CountUniversity()
        {
            try
            {
                //MYSQL Connection 
                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                MySqlCommand cmd = null;
                string Querry = "";
                string UniversityCount = "";
                conn.Open();

                // To Get Username//
                Querry = "select count(UNI_ID) from universitymaininfo;";

                cmd = new MySqlCommand(Querry, conn);
                cmd.ExecuteNonQuery();
                var getUniCount = cmd.ExecuteReader();
                if (getUniCount.HasRows)
                {
                    getUniCount.Read();
                    UniversityCount = getUniCount.GetString(0);
                }
                getUniCount.Close();
                conn.Close();
                //-----------//
                lblUniCount.Text = UniversityCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void CountAdmin()
        {
            try
            {
                //MYSQL Connection 
                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                MySqlCommand cmd = null;
                string Querry = "";
                string AdminCount = "";
                conn.Open();

                // To Get Username//
                Querry = "select count(RegID) from mainadmin;";

                cmd = new MySqlCommand(Querry, conn);
                cmd.ExecuteNonQuery();
                var getAdminCount = cmd.ExecuteReader();
                if (getAdminCount.HasRows)
                {
                    getAdminCount.Read();
                    AdminCount = getAdminCount.GetString(0);
                }
                getAdminCount.Close();
                conn.Close();
                //-----------//
                lblAdminCount.Text = AdminCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void CountContributor()
        {
            try
            {
                //MYSQL Connection 
                MySqlConnection conn = new MySqlConnection("server = CONNETION_NAME; port = PORT_NUMBER; user id = USER_ID; password = PASSWORD ; database= DATABASE_NAME");

                MySqlCommand cmd = null;
                string Querry = "";
                string ContributorCount = "";
                conn.Open();

                // To Get Username//
                Querry = "select count(RegID) from login;";

                cmd = new MySqlCommand(Querry, conn);
                cmd.ExecuteNonQuery();
                var getContributorCount = cmd.ExecuteReader();
                if (getContributorCount.HasRows)
                {
                    getContributorCount.Read();
                    ContributorCount = getContributorCount.GetString(0);
                }
                getContributorCount.Close();
                conn.Close();
                //-----------//
                lblContributorCount.Text = ContributorCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}
