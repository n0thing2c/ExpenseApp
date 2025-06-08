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
    public partial class MenuForm : Form
    {
        string user;
        public MenuForm(string username)
        {
            user= username;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            new NewFileForm(user).Show();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            new PickFileForm(user).Show();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
