namespace QuanLyTuyenSinh.PresentationLayer
{
    partial class Tracuudiem
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
            this.btnTracuu = new System.Windows.Forms.Button();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSBD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // btnTracuu
            // 
            this.btnTracuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTracuu.BackgroundImage = global::QuanLyTuyenSinh.Properties.Resources._431;
            this.btnTracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracuu.ForeColor = System.Drawing.Color.Teal;
            this.btnTracuu.Location = new System.Drawing.Point(549, 6);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(75, 41);
            this.btnTracuu.TabIndex = 1;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = false;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(91, 21);
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(160, 20);
            this.txbHoten.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(309, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SBD:";
            // 
            // txbSBD
            // 
            this.txbSBD.Location = new System.Drawing.Point(370, 18);
            this.txbSBD.Name = "txbSBD";
            this.txbSBD.Size = new System.Drawing.Size(160, 20);
            this.txbSBD.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 253);
            this.dataGridView1.TabIndex = 5;
            // 
            // Tracuudiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTuyenSinh.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(722, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbSBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbHoten);
            this.Controls.Add(this.btnTracuu);
            this.Controls.Add(this.label1);
            this.Name = "Tracuudiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU ĐIỂM";
            this.Load += new System.EventHandler(this.Tracuudiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSBD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}