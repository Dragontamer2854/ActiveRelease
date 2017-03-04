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
    public partial class ObjectiveMenu : Form
    {
        DeleteVideo delForm = new DeleteVideo();
        AddVideo addForm = new AddVideo();
        SearchVideo searchForm = new SearchVideo();
        public ObjectiveMenu()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addForm.ShowDialog();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            delForm.ShowDialog();
            this.Close();
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchForm.ShowDialog();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }
    }
}
