using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Info_Center.Admin_Form
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            Dashboard dashboard = new Dashboard();
            showControl(dashboard);
            ControlDisable();
        }

        public void ControlDisable()
        {
            if (UserForm.ContUserType == true)
            {
                btnUserInfo.Enabled = false;
                UserForm.ContUserType = false;
            }
        }

        public void showControl(Control control)
        {
            ContentPannel.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            ContentPannel.Controls.Add(control);
        
        }

        private void btnField_Click(object sender, EventArgs e)
        {
            Field field = new Field();
            showControl(field);
        }

        private void btnUniInfo_Click(object sender, EventArgs e)
        {
            UniversityInfo universityInfo = new UniversityInfo();
            showControl(universityInfo);
        }

        private void btnInsertUni_Click(object sender, EventArgs e)
        {
            InsertUniField uniField = new InsertUniField();
            showControl(uniField);
        }

        private void btnUpdateUni_Click(object sender, EventArgs e)
        {
            UpdateUniField updateUniField = new UpdateUniField();
            showControl(updateUniField);
        }

        private void btnDeleteUni_Click(object sender, EventArgs e)
        {
            DeleteUniField deleteUni = new DeleteUniField();
            showControl(deleteUni);
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            showControl(userInfo);
        }

        private void d_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Are You Sure To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (D == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            showControl(dashboard);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Are You Sure You Want To Log Out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (D == DialogResult.Yes)
            {
                this.Dispose();
                UserForm userForm = new UserForm();
                userForm.Show();
            }
        }

        private void btnSemester_Click(object sender, EventArgs e)
        {
            Semester semester = new Semester();
            showControl(semester);
        }
    }
}
