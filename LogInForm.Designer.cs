
namespace NavchPrakt_28_LINQtoSQL
{
    partial class LogInForm
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
            this.buttonUserLogIn = new System.Windows.Forms.Button();
            this.buttonAdmailLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUserLogIn
            // 
            this.buttonUserLogIn.Location = new System.Drawing.Point(12, 147);
            this.buttonUserLogIn.Name = "buttonUserLogIn";
            this.buttonUserLogIn.Size = new System.Drawing.Size(126, 30);
            this.buttonUserLogIn.TabIndex = 0;
            this.buttonUserLogIn.Text = "User";
            this.buttonUserLogIn.UseVisualStyleBackColor = true;
            this.buttonUserLogIn.Click += new System.EventHandler(this.buttonUserLogIn_Click);
            // 
            // buttonAdmailLogIn
            // 
            this.buttonAdmailLogIn.Location = new System.Drawing.Point(153, 147);
            this.buttonAdmailLogIn.Name = "buttonAdmailLogIn";
            this.buttonAdmailLogIn.Size = new System.Drawing.Size(124, 30);
            this.buttonAdmailLogIn.TabIndex = 1;
            this.buttonAdmailLogIn.Text = "Admin";
            this.buttonAdmailLogIn.UseVisualStyleBackColor = true;
            this.buttonAdmailLogIn.Click += new System.EventHandler(this.buttonAdmailLogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log In like";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(298, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdmailLogIn);
            this.Controls.Add(this.buttonUserLogIn);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonUserLogIn;
        private System.Windows.Forms.Button buttonAdmailLogIn;
        private System.Windows.Forms.Label label1;
    }
}