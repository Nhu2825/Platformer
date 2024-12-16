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
            this.MenuBackground = new System.Windows.Forms.PictureBox();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Subject = new System.Windows.Forms.ComboBox();
            this.GreenGuy = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.SubjectChoice = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBackground
            // 
            this.MenuBackground.Image = global::Platformer.Properties.Resources._1006406251;
            this.MenuBackground.Location = new System.Drawing.Point(0, 0);
            this.MenuBackground.Name = "MenuBackground";
            this.MenuBackground.Size = new System.Drawing.Size(727, 540);
            this.MenuBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBackground.TabIndex = 0;
            this.MenuBackground.TabStop = false;
            // 
            // cmb_Name
            // 
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(163, 198);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(198, 28);
            this.cmb_Name.TabIndex = 1;
            // 
            // cmb_Subject
            // 
            this.cmb_Subject.FormattingEnabled = true;
            this.cmb_Subject.Location = new System.Drawing.Point(163, 283);
            this.cmb_Subject.Name = "cmb_Subject";
            this.cmb_Subject.Size = new System.Drawing.Size(172, 28);
            this.cmb_Subject.TabIndex = 2;
            this.cmb_Subject.Click += new System.EventHandler(this.SubjectSelection);
            // 
            // GreenGuy
            // 
            this.GreenGuy.AutoSize = true;
            this.GreenGuy.BackColor = System.Drawing.Color.PowderBlue;
            this.GreenGuy.Font = new System.Drawing.Font("Script MT Bold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenGuy.Location = new System.Drawing.Point(101, 71);
            this.GreenGuy.Name = "GreenGuy";
            this.GreenGuy.Size = new System.Drawing.Size(260, 67);
            this.GreenGuy.TabIndex = 3;
            this.GreenGuy.Text = "Green Guy";
            this.GreenGuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(68, 198);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(71, 29);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectChoice
            // 
            this.SubjectChoice.AutoSize = true;
            this.SubjectChoice.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectChoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubjectChoice.Location = new System.Drawing.Point(68, 279);
            this.SubjectChoice.Name = "SubjectChoice";
            this.SubjectChoice.Size = new System.Drawing.Size(86, 29);
            this.SubjectChoice.TabIndex = 5;
            this.SubjectChoice.Text = "Subject";
            this.SubjectChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.LightGreen;
            this.startbutton.Font = new System.Drawing.Font("Sitka Display", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(163, 393);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(121, 55);
            this.startbutton.TabIndex = 6;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.PressStart);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 484);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.SubjectChoice);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.GreenGuy);
            this.Controls.Add(this.cmb_Subject);
            this.Controls.Add(this.cmb_Name);
            this.Controls.Add(this.MenuBackground);
            this.Name.Text = "Name";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuBackground;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.ComboBox cmb_Subject;
        private System.Windows.Forms.Label GreenGuy;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label SubjectChoice;
        private System.Windows.Forms.Button startbutton;
    }
}