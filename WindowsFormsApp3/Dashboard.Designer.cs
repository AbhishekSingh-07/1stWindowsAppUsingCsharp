namespace Project2
{
    partial class Dashboard
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
            this.btnaddprod = new System.Windows.Forms.Button();
            this.btnaddcat = new System.Windows.Forms.Button();
            this.btnaddcus = new System.Windows.Forms.Button();
            this.btnaddord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddprod
            // 
            this.btnaddprod.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddprod.ForeColor = System.Drawing.Color.Black;
            this.btnaddprod.Location = new System.Drawing.Point(12, 168);
            this.btnaddprod.Name = "btnaddprod";
            this.btnaddprod.Size = new System.Drawing.Size(150, 121);
            this.btnaddprod.TabIndex = 0;
            this.btnaddprod.Text = "ADD PRODUCT";
            this.btnaddprod.UseVisualStyleBackColor = false;
            this.btnaddprod.Click += new System.EventHandler(this.btnaddprod_Click);
            // 
            // btnaddcat
            // 
            this.btnaddcat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddcat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcat.ForeColor = System.Drawing.Color.Black;
            this.btnaddcat.Location = new System.Drawing.Point(207, 168);
            this.btnaddcat.Name = "btnaddcat";
            this.btnaddcat.Size = new System.Drawing.Size(150, 121);
            this.btnaddcat.TabIndex = 1;
            this.btnaddcat.Text = "ADD Cattegories";
            this.btnaddcat.UseVisualStyleBackColor = false;
            this.btnaddcat.Click += new System.EventHandler(this.btnaddcat_Click);
            // 
            // btnaddcus
            // 
            this.btnaddcus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddcus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcus.ForeColor = System.Drawing.Color.Black;
            this.btnaddcus.Location = new System.Drawing.Point(397, 168);
            this.btnaddcus.Name = "btnaddcus";
            this.btnaddcus.Size = new System.Drawing.Size(150, 121);
            this.btnaddcus.TabIndex = 2;
            this.btnaddcus.Text = "ADD Customers";
            this.btnaddcus.UseVisualStyleBackColor = false;
            this.btnaddcus.Click += new System.EventHandler(this.btnaddcus_Click);
            // 
            // btnaddord
            // 
            this.btnaddord.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddord.ForeColor = System.Drawing.Color.Black;
            this.btnaddord.Location = new System.Drawing.Point(581, 168);
            this.btnaddord.Name = "btnaddord";
            this.btnaddord.Size = new System.Drawing.Size(150, 121);
            this.btnaddord.TabIndex = 3;
            this.btnaddord.Text = "ADD Orders";
            this.btnaddord.UseVisualStyleBackColor = false;
            this.btnaddord.Click += new System.EventHandler(this.btnaddord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(288, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddord);
            this.Controls.Add(this.btnaddcus);
            this.Controls.Add(this.btnaddcat);
            this.Controls.Add(this.btnaddprod);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddprod;
        private System.Windows.Forms.Button btnaddcat;
        private System.Windows.Forms.Button btnaddcus;
        private System.Windows.Forms.Button btnaddord;
        private System.Windows.Forms.Label label1;
    }
}