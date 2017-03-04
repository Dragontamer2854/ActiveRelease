namespace ActiveReleaseUI
{
    partial class ObjectiveMenu
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Purple;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Gold;
            this.AddButton.Location = new System.Drawing.Point(54, 83);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(868, 112);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Purple;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.Gold;
            this.DeleteButton.Location = new System.Drawing.Point(54, 239);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(868, 112);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Purple;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.Gold;
            this.SearchButton.Location = new System.Drawing.Point(54, 398);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(868, 112);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ObjectiveMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ObjectiveMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BackButton;
    }
}

