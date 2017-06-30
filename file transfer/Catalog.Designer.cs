namespace file_transfer
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            this.findButton = new MetroFramework.Controls.MetroButton();
            this.diskButton2 = new MetroFramework.Controls.MetroButton();
            this.diskButton1 = new MetroFramework.Controls.MetroButton();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.diskButton3 = new MetroFramework.Controls.MetroButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            // 
            // 
            // 
            this.textBox.CustomButton.Image = null;
            this.textBox.CustomButton.Location = new System.Drawing.Point(398, 1);
            this.textBox.CustomButton.Name = "";
            this.textBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox.CustomButton.TabIndex = 1;
            this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox.CustomButton.UseSelectable = true;
            this.textBox.CustomButton.Visible = false;
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(23, 74);
            this.textBox.MaxLength = 32767;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(420, 23);
            this.textBox.TabIndex = 0;
            this.textBox.UseSelectable = true;
            this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(472, 74);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseSelectable = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // diskButton2
            // 
            this.diskButton2.Location = new System.Drawing.Point(200, 113);
            this.diskButton2.Name = "diskButton2";
            this.diskButton2.Size = new System.Drawing.Size(75, 23);
            this.diskButton2.TabIndex = 2;
            this.diskButton2.Text = "Disk2";
            this.diskButton2.UseSelectable = true;
            this.diskButton2.Click += new System.EventHandler(this.diskButton2_Click);
            // 
            // diskButton1
            // 
            this.diskButton1.Location = new System.Drawing.Point(23, 113);
            this.diskButton1.Name = "diskButton1";
            this.diskButton1.Size = new System.Drawing.Size(75, 23);
            this.diskButton1.TabIndex = 3;
            this.diskButton1.Text = "Disk1";
            this.diskButton1.UseSelectable = true;
            this.diskButton1.Click += new System.EventHandler(this.diskButton1_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(472, 113);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // diskButton3
            // 
            this.diskButton3.Location = new System.Drawing.Point(368, 113);
            this.diskButton3.Name = "diskButton3";
            this.diskButton3.Size = new System.Drawing.Size(75, 23);
            this.diskButton3.TabIndex = 5;
            this.diskButton3.Text = "Disk3";
            this.diskButton3.UseSelectable = true;
            this.diskButton3.Click += new System.EventHandler(this.diskButton3_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(23, 161);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(524, 368);
            this.listBox.TabIndex = 6;
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 550);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.diskButton3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.diskButton1);
            this.Controls.Add(this.diskButton2);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalog";
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBox;
        private MetroFramework.Controls.MetroButton findButton;
        private MetroFramework.Controls.MetroButton diskButton2;
        private MetroFramework.Controls.MetroButton diskButton1;
        private MetroFramework.Controls.MetroButton backButton;
        private MetroFramework.Controls.MetroButton diskButton3;
        private System.Windows.Forms.ListBox listBox;
    }
}