namespace Platformer
{
    partial class Menu
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
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.GreenGuy = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.SubjectChoice = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Name
            // 
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(145, 158);
            this.cmb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(176, 24);
            this.cmb_Name.TabIndex = 1;
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(145, 226);
            this.cmb_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(153, 24);
            this.cmb_Subject.TabIndex = 2;
            this.cmb_Subject.Click += new System.EventHandler(this.SubjectSelection);
            // 
            // GreenGuy
            // 
            this.GreenGuy.AutoSize = true;
            this.GreenGuy.BackColor = System.Drawing.Color.Transparent;
            this.GreenGuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenGuy.Location = new System.Drawing.Point(90, 57);
            this.GreenGuy.Name = "GreenGuy";
            this.GreenGuy.Size = new System.Drawing.Size(262, 54);
            this.GreenGuy.TabIndex = 3;
            this.GreenGuy.Text = "Green Guy";
            this.GreenGuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(60, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 24);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectChoice
            // 
            this.SubjectChoice.AutoSize = true;
            this.SubjectChoice.BackColor = System.Drawing.Color.Transparent;
            this.SubjectChoice.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectChoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubjectChoice.Location = new System.Drawing.Point(60, 223);
            this.SubjectChoice.Name = "SubjectChoice";
            this.SubjectChoice.Size = new System.Drawing.Size(73, 24);
            this.SubjectChoice.TabIndex = 5;
            this.SubjectChoice.Text = "Subject";
            this.SubjectChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.LightGreen;
            this.startbutton.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(145, 314);
            this.startbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(108, 44);
            this.startbutton.TabIndex = 6;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.PressStart);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Platformer.Properties.Resources.chill_guy;
            this.pictureBox1.Location = new System.Drawing.Point(371, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 387);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.SubjectChoice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.GreenGuy);
            this.Controls.Add(this.cmb_Subject);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.Label GreenGuy;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label SubjectChoice;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}