﻿using System;
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
    public partial class AddVideo : Form
    {
        ObjectiveMenu menuForm = new ObjectiveMenu();
        public AddVideo()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            Console.Write(result);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
