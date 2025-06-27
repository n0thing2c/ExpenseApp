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
    public partial class ChangeInfoForm : Form
    {
        public ChangeInfoForm()
        {
            InitializeComponent();
        }

        private void ChangeInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account currentAcc = Account.ModifyAcc(txtNewUserName.Text, txtNewPass.Text);
        }
    }
}
