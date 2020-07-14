namespace QuanLyTuyenSinh.PresentationLayer
{
    partial class Tracuunganh
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
            this.dgvtracuu = new System.Windows.Forms.DataGridView();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTennganh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtracuu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtracuu
            // 
            this.dgvtracuu.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvtracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtracuu.Location = new System.Drawing.Point(9, 116);
            this.dgvtracuu.Name = "dgvtracuu";
            this.dgvtracuu.Size = new System.Drawing.Size(446, 253);
            this.dgvtracuu.TabIndex = 11;
            this.dgvtracuu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnTracuu
            // 
            this.btnTracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracuu.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTracuu.Location = new System.Drawing.Point(277, 38);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(75, 41);
            this.btnTracuu.TabIndex = 7;
            this.btnTracuu.Text = "Tra cứu";
            this.btnTracuu.UseVisualStyleBackColor = true;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên ngành: ";
            // 
            // cmbTennganh
            // 
            this.cmbTennganh.FormattingEnabled = true;
            this.cmbTennganh.Location = new System.Drawing.Point(90, 50);
            this.cmbTennganh.Name = "cmbTennganh";
            this.cmbTennganh.Size = new System.Drawing.Size(161, 21);
            this.cmbTennganh.TabIndex = 14;
            // 
            // Tracuunganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyTuyenSinh.Properties.Resources.H0;
            this.ClientSize = new System.Drawing.Size(463, 381);
            this.Controls.Add(this.cmbTennganh);
            this.Controls.Add(this.dgvtracuu);
            this.Controls.Add(this.btnTracuu);
            this.Controls.Add(this.label1);
            this.Name = "Tracuunganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu Ngành";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtracuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtracuu;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTennganh;
    }
}