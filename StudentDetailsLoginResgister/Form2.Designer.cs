﻿namespace StudentDetailsLoginResgister
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lpassword = new System.Windows.Forms.Label();
            this.lusername = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbtnregister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Form";
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.Location = new System.Drawing.Point(6, 310);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(157, 33);
            this.lpassword.TabIndex = 35;
            this.lpassword.Text = "Password:";
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.Font = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusername.Location = new System.Drawing.Point(6, 185);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(166, 33);
            this.lusername.TabIndex = 34;
            this.lusername.Text = "Username:";
            // 
            // tbusername
            // 
            this.tbusername.Font = new System.Drawing.Font("Courier New", 14F);
            this.tbusername.Location = new System.Drawing.Point(12, 235);
            this.tbusername.Multiline = true;
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(485, 42);
            this.tbusername.TabIndex = 36;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Courier New", 14F);
            this.tbpassword.Location = new System.Drawing.Point(12, 359);
            this.tbpassword.Multiline = true;
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(485, 42);
            this.tbpassword.TabIndex = 37;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnlogin.FlatAppearance.BorderSize = 2;
            this.btnlogin.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(161, 578);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(178, 66);
            this.btnlogin.TabIndex = 40;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbtnregister
            // 
            this.lbtnregister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbtnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbtnregister.Location = new System.Drawing.Point(397, 405);
            this.lbtnregister.Name = "lbtnregister";
            this.lbtnregister.Size = new System.Drawing.Size(100, 40);
            this.lbtnregister.TabIndex = 43;
            this.lbtnregister.Text = "Register";
            this.lbtnregister.UseVisualStyleBackColor = false;
            this.lbtnregister.Click += new System.EventHandler(this.lbtnregister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Don\'t Have an Account?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(509, 723);
            this.Controls.Add(this.lbtnregister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.lusername);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.Label lusername;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button lbtnregister;
        private System.Windows.Forms.Label label2;
    }
}