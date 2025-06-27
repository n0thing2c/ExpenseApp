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
    public partial class ucPickFileType : UserControl
    {
        string us;
        string ses;
        public event Action <string> NewFile;
        public event Action<string> PickFile;
        public EventHandler ExitClicked;
        public ucPickFileType(string user,string session)
        {
            InitializeComponent();
            us = user;
            ses= session;
        }

        private void FMFilePick_Click(object sender, EventArgs e)
        {
            if (ses == "New")
                NewFile?.Invoke("FM");
            else if(ses=="Pick")
                PickFile?.Invoke("FM");
        }

        private void MDFilePick_Click(object sender, EventArgs e)
        {
            if (ses == "New")
                NewFile?.Invoke("MD");
            else if (ses == "Pick")
                PickFile?.Invoke("MD");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
