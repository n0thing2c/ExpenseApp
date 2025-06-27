namespace Login.Page
{
    partial class ChangeInfoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Return_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Pass";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(191, 106);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(390, 22);
            this.txtNewUserName.TabIndex = 4;
            this.txtNewUserName.TextChanged += new System.EventHandler(this.txtNewUserName_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(191, 216);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(390, 22);
            this.txtNewPass.TabIndex = 5;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Return_button
            // 
            this.Return_button.Location = new System.Drawing.Point(215, 359);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(75, 23);
            this.Return_button.TabIndex = 7;
            this.Return_button.Text = "Return";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // ChangeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Return_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeInfoForm";
            this.Text = "ChangeInfoForm";
            this.Load += new System.EventHandler(this.ChangeInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Return_button;
    }
}