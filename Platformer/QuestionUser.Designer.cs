namespace Platformer
{
    partial class QuestionUser
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
            this.QuestionBackground = new System.Windows.Forms.PictureBox();
            this.QuestionHere = new System.Windows.Forms.Label();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_D = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionBackground
            // 
            this.QuestionBackground.Image = global::Platformer.Properties.Resources.background_11;
            this.QuestionBackground.Location = new System.Drawing.Point(0, 0);
            this.QuestionBackground.Name = "QuestionBackground";
            this.QuestionBackground.Size = new System.Drawing.Size(640, 540);
            this.QuestionBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuestionBackground.TabIndex = 0;
            this.QuestionBackground.TabStop = false;
            // 
            // QuestionHere
            // 
            this.QuestionHere.BackColor = System.Drawing.Color.Transparent;
            this.QuestionHere.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionHere.Location = new System.Drawing.Point(12, 9);
            this.QuestionHere.Name = "QuestionHere";
            this.QuestionHere.Size = new System.Drawing.Size(594, 116);
            this.QuestionHere.TabIndex = 1;
            this.QuestionHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.BackColor = System.Drawing.Color.Transparent;
            this.rad_A.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_A.Location = new System.Drawing.Point(12, 163);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(170, 33);
            this.rad_A.TabIndex = 2;
            this.rad_A.TabStop = true;
            this.rad_A.Text = "radioButton1";
            this.rad_A.UseVisualStyleBackColor = false;
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.BackColor = System.Drawing.Color.Transparent;
            this.rad_B.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_B.Location = new System.Drawing.Point(9, 239);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(172, 33);
            this.rad_B.TabIndex = 3;
            this.rad_B.TabStop = true;
            this.rad_B.Text = "radioButton2";
            this.rad_B.UseVisualStyleBackColor = false;
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.BackColor = System.Drawing.Color.Transparent;
            this.rad_C.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_C.Location = new System.Drawing.Point(10, 312);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(172, 33);
            this.rad_C.TabIndex = 4;
            this.rad_C.TabStop = true;
            this.rad_C.Text = "radioButton3";
            this.rad_C.UseVisualStyleBackColor = false;
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.BackColor = System.Drawing.Color.Transparent;
            this.rad_D.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_D.Location = new System.Drawing.Point(9, 385);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(173, 33);
            this.rad_D.TabIndex = 5;
            this.rad_D.TabStop = true;
            this.rad_D.Text = "radioButton4";
            this.rad_D.UseVisualStyleBackColor = false;
            // 
            // QuestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 484);
            this.Controls.Add(this.rad_D);
            this.Controls.Add(this.rad_C);
            this.Controls.Add(this.rad_B);
            this.Controls.Add(this.rad_A);
            this.Controls.Add(this.QuestionHere);
            this.Controls.Add(this.QuestionBackground);
            this.Name = "QuestionUser";
            this.Text = "QuestionUser";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QuestionBackground;
        private System.Windows.Forms.Label QuestionHere;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_D;
    }
}