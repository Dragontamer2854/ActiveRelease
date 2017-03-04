namespace ActiveReleaseUI
{
    partial class AddVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVideo));
            this.submitButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
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
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.Purple;
            this.browseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.Gold;
            this.browseButton.Location = new System.Drawing.Point(326, 427);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(233, 34);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 433);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 22);
            this.textBox1.TabIndex = 8;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(9, 49);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(550, 290);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 53);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add Video";
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
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(608, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(330, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Generic Body Part";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(608, 227);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(330, 24);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.Text = "Specific Body Part";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(608, 315);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(330, 24);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.Text = "Procedure";
            // 
            // AddVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.submitButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddVideo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

