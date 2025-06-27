using Login.Operation.UserLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Page
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            user_label.Visible = false;
            pass_label.Visible = false;
        }

        private void Show_Username_Button_Click(object sender, EventArgs e)
        {
            Account a = Account.GetCurrentAcc();
            pass_label.Text = a.getPassword();
            pass_label.Visible = !pass_label.Visible;
        }

        private void Show_Pass_Button_Click(object sender, EventArgs e)
        {
            Account a = Account.GetCurrentAcc();
            user_label.Text = a.getUserName();
            user_label.Visible = !user_label.Visible;
        }

        private void user_label_Click(object sender, EventArgs e)
        {

        }

        private void pass_label_Click(object sender, EventArgs e)
        {
                    
        }

        private void Return_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ChangeInfoForm().Show();
        }
    }
}
