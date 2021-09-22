
namespace Encrypt_Decrypt_folder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(39, 122);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(25, 23);
            this.btn_find.TabIndex = 0;
            this.btn_find.Text = "...";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(116, 151);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(137, 52);
            this.btn_encrypt.TabIndex = 1;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(318, 151);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(137, 52);
            this.btn_decrypt.TabIndex = 2;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(84, 122);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(399, 23);
            this.txt_find.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome. Let\'s Start to Encrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(561, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.btn_find);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Protect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label1;
    }
}

