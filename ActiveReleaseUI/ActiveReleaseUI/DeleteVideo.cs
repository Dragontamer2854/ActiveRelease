using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveReleaseUI
{
    public partial class DeleteVideo : Form
    {
        ObjectiveMenu menuForm = new ObjectiveMenu();
        public DeleteVideo()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
