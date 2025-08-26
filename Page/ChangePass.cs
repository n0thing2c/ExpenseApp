using Login.Operation.UserLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Account a = Account.GetCurrentAcc();
            username_label.Text = a.getUserName();
        }
        bool clicked = false;
        private void textBox3_Click(object sender, EventArgs e)
        {
            clicked = true;
            current_pass_box.Text = string.Empty;
            current_pass_box.PasswordChar = '•';
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            clicked = true;
            new_pass_box.Text = string.Empty;
            new_pass_box.PasswordChar = '•';
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            clicked = true;
            confirm_pass_box.Text = string.Empty;
            confirm_pass_box.PasswordChar = '•';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void closeEye_Click(object sender, EventArgs e)
        {
            new_pass_box.PasswordChar = '\0'; 
            closeEye.Visible = false;         
            openEye.Visible = true;           
        }

        private void openEye_Click(object sender, EventArgs e)
        {
            new_pass_box.PasswordChar = '•';  
            openEye.Visible = false;          
            closeEye.Visible = true;          
        }

        private void open_eye_confirm_Click(object sender, EventArgs e)
        {
            confirm_pass_box.PasswordChar = '\0';
            close_eye_confirm.Visible = false;
            open_eye_confirm.Visible = true;
        }

        private void close_eye_confirm_Click(object sender, EventArgs e)
        {
            confirm_pass_box.PasswordChar = '•';
            open_eye_confirm.Visible = false;
            close_eye_confirm.Visible = true;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Account acc = Account.GetCurrentAcc();
            
            if(!clicked)
            {
                MessageBox.Show("Please fill all the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(current_pass_box.Text) ||
               string.IsNullOrEmpty(new_pass_box.Text) ||
               string.IsNullOrEmpty(confirm_pass_box.Text))
            {
                MessageBox.Show("Please fill all the information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
            if (current_pass_box.Text != acc.getPassword())
            {
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (new_pass_box.Text != confirm_pass_box.Text)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account.ModifyAcc(acc.getUserName(), new_pass_box.Text);

            string repoPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string path = Path.Combine(repoPath, "Operation", "UserLog", "userPass.txt");

            List<string> lines = new List<string>(File.ReadAllLines(path));
            string oldLine = acc.getUserName() + ":" + acc.getPassword();
            string newLine = acc.getUserName() + ":" + new_pass_box.Text;

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(acc.getUserName() + ":"))
                {
                    lines[i] = newLine;
                    break;
                }
            }

            File.WriteAllLines(path, lines);

            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
