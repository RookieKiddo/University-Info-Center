using System;
using System.Windows.Forms;
using University_Info_Center.User_Form;

namespace University_Info_Center
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserFormMain user = new UserFormMain();
            this.Hide();
            user.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            this.Hide();
            user.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Are You Sure To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (D == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
