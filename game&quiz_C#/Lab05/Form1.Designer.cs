namespace Lab05
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
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btBai3 = new System.Windows.Forms.Button();
            this.btBai2MR = new System.Windows.Forms.Button();
            this.btBai2 = new System.Windows.Forms.Button();
            this.btnBai1MR = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBai1
            // 
            this.btnBai1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai1.Location = new System.Drawing.Point(78, 124);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(132, 50);
            this.btnBai1.TabIndex = 0;
            this.btnBai1.Text = "Bài 1";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // 
            // btBai3
            // 
            this.btBai3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai3.Location = new System.Drawing.Point(78, 317);
            this.btBai3.Name = "btBai3";
            this.btBai3.Size = new System.Drawing.Size(132, 50);
            this.btBai3.TabIndex = 1;
            this.btBai3.Text = "Bài 3";
            this.btBai3.UseVisualStyleBackColor = true;
            this.btBai3.Click += new System.EventHandler(this.btBai3_Click);
            // 
            // btBai2MR
            // 
            this.btBai2MR.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai2MR.Location = new System.Drawing.Point(249, 223);
            this.btBai2MR.Name = "btBai2MR";
            this.btBai2MR.Size = new System.Drawing.Size(235, 50);
            this.btBai2MR.TabIndex = 2;
            this.btBai2MR.Text = "Bài 2 Mở Rộng";
            this.btBai2MR.UseVisualStyleBackColor = true;
            this.btBai2MR.Click += new System.EventHandler(this.btBai2MR_Click);
            // 
            // btBai2
            // 
            this.btBai2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBai2.Location = new System.Drawing.Point(78, 223);
            this.btBai2.Name = "btBai2";
            this.btBai2.Size = new System.Drawing.Size(132, 50);
            this.btBai2.TabIndex = 3;
            this.btBai2.Text = "Bài 2";
            this.btBai2.UseVisualStyleBackColor = true;
            this.btBai2.Click += new System.EventHandler(this.btBai2_Click);
            // 
            // btnBai1MR
            // 
            this.btnBai1MR.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai1MR.Location = new System.Drawing.Point(249, 124);
            this.btnBai1MR.Name = "btnBai1MR";
            this.btnBai1MR.Size = new System.Drawing.Size(235, 50);
            this.btnBai1MR.TabIndex = 4;
            this.btnBai1MR.Text = "Bài 1 Mở Rộng";
            this.btnBai1MR.UseVisualStyleBackColor = true;
            this.btnBai1MR.Click += new System.EventHandler(this.btnBai1MR_Click);
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.Red;
            this.lbMenu.Location = new System.Drawing.Point(164, 34);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(142, 55);
            this.lbMenu.TabIndex = 5;
            this.lbMenu.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btnBai1MR);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btBai2);
            this.Controls.Add(this.btBai2MR);
            this.Controls.Add(this.btBai3);
            this.Controls.Add(this.btnBai1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btBai3;
        private System.Windows.Forms.Button btBai2MR;
        private System.Windows.Forms.Button btBai2;
        private System.Windows.Forms.Button btnBai1MR;
        private System.Windows.Forms.Label lbMenu;
    }
}

