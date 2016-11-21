namespace ASampleProject
{
    partial class Form1
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.mcgeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(177, 247);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(95, 29);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Refresh List";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(12, 12);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(159, 264);
            this.namesListBox.TabIndex = 1;
            // 
            // mcgeButton
            // 
            this.mcgeButton.Location = new System.Drawing.Point(187, 12);
            this.mcgeButton.Name = "mcgeButton";
            this.mcgeButton.Size = new System.Drawing.Size(75, 23);
            this.mcgeButton.TabIndex = 2;
            this.mcgeButton.Text = "my button";
            this.mcgeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.mcgeButton);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.refreshButton);
            this.Name = "Form1";
            this.Text = "Displaying Names in File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Button mcgeButton;
    }
}

