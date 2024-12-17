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
            this.QuestionHere = new System.Windows.Forms.Label();
            this.rad_A = new System.Windows.Forms.RadioButton();
            this.rad_B = new System.Windows.Forms.RadioButton();
            this.rad_C = new System.Windows.Forms.RadioButton();
            this.rad_D = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // QuestionHere
            // 
            this.QuestionHere.BackColor = System.Drawing.Color.Transparent;
            this.QuestionHere.Font = new System.Drawing.Font("Sitka Small", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionHere.Location = new System.Drawing.Point(11, 7);
            this.QuestionHere.Name = "QuestionHere";
            this.QuestionHere.Size = new System.Drawing.Size(528, 93);
            this.QuestionHere.TabIndex = 1;
            this.QuestionHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rad_A
            // 
            this.rad_A.AutoSize = true;
            this.rad_A.BackColor = System.Drawing.Color.Transparent;
            this.rad_A.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_A.Location = new System.Drawing.Point(11, 130);
            this.rad_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_A.Name = "rad_A";
            this.rad_A.Size = new System.Drawing.Size(17, 16);
            this.rad_A.TabIndex = 2;
            this.rad_A.TabStop = true;
            this.rad_A.UseVisualStyleBackColor = false;
            // 
            // rad_B
            // 
            this.rad_B.AutoSize = true;
            this.rad_B.BackColor = System.Drawing.Color.Transparent;
            this.rad_B.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_B.Location = new System.Drawing.Point(8, 191);
            this.rad_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_B.Name = "rad_B";
            this.rad_B.Size = new System.Drawing.Size(17, 16);
            this.rad_B.TabIndex = 3;
            this.rad_B.TabStop = true;
            this.rad_B.UseVisualStyleBackColor = false;
            // 
            // rad_C
            // 
            this.rad_C.AutoSize = true;
            this.rad_C.BackColor = System.Drawing.Color.Transparent;
            this.rad_C.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_C.Location = new System.Drawing.Point(9, 250);
            this.rad_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_C.Name = "rad_C";
            this.rad_C.Size = new System.Drawing.Size(17, 16);
            this.rad_C.TabIndex = 4;
            this.rad_C.TabStop = true;
            this.rad_C.UseVisualStyleBackColor = false;
            // 
            // rad_D
            // 
            this.rad_D.AutoSize = true;
            this.rad_D.BackColor = System.Drawing.Color.Transparent;
            this.rad_D.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_D.Location = new System.Drawing.Point(8, 308);
            this.rad_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rad_D.Name = "rad_D";
            this.rad_D.Size = new System.Drawing.Size(17, 16);
            this.rad_D.TabIndex = 5;
            this.rad_D.TabStop = true;
            this.rad_D.UseVisualStyleBackColor = false;
            // 
            // QuestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 387);
            this.Controls.Add(this.rad_D);
            this.Controls.Add(this.rad_C);
            this.Controls.Add(this.rad_B);
            this.Controls.Add(this.rad_A);
            this.Controls.Add(this.QuestionHere);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionUser";
            this.Text = "QuestionUser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.QuestionUser_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label QuestionHere;
        private System.Windows.Forms.RadioButton rad_A;
        private System.Windows.Forms.RadioButton rad_B;
        private System.Windows.Forms.RadioButton rad_C;
        private System.Windows.Forms.RadioButton rad_D;
    }
}