namespace ActiveReleaseUI
{
    partial class SearchVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchVideo));
            this.listView1 = new System.Windows.Forms.ListView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 346);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(551, 195);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(9, 49);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(550, 290);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(608, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "Generic Body Part";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(608, 227);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(330, 24);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "Specific Body Part";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(608, 315);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(330, 24);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.Text = "Procedure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 53);
            this.label4.TabIndex = 11;
            this.label4.Text = "Video Search";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Purple;
            this.submitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Gold;
            this.submitButton.Location = new System.Drawing.Point(615, 410);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(313, 54);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Search";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Purple;
            this.BackButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Gold;
            this.BackButton.Location = new System.Drawing.Point(9, 6);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 35);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listView1);
            this.Name = "SearchVideo";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button BackButton;
    }
}