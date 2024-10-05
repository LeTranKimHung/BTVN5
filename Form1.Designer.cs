namespace BTVN5
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
            this.dgvsv = new System.Windows.Forms.DataGridView();
            this.dgvmssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvhoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpttsv = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.lbldtb = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmssv = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            this.grpttsv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsv
            // 
            this.dgvsv.AllowUserToAddRows = false;
            this.dgvsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmssv,
            this.dgvhoten,
            this.dgvkhoa,
            this.dgvdtb});
            this.dgvsv.Location = new System.Drawing.Point(289, 67);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 51;
            this.dgvsv.RowTemplate.Height = 24;
            this.dgvsv.Size = new System.Drawing.Size(508, 313);
            this.dgvsv.TabIndex = 0;
            this.dgvsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsv_CellClick);
            // 
            // dgvmssv
            // 
            this.dgvmssv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvmssv.HeaderText = "MSSV";
            this.dgvmssv.MinimumWidth = 6;
            this.dgvmssv.Name = "dgvmssv";
            this.dgvmssv.Width = 74;
            // 
            // dgvhoten
            // 
            this.dgvhoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvhoten.HeaderText = "Họ Tên";
            this.dgvhoten.MinimumWidth = 6;
            this.dgvhoten.Name = "dgvhoten";
            this.dgvhoten.Width = 81;
            // 
            // dgvkhoa
            // 
            this.dgvkhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvkhoa.HeaderText = "Khoa";
            this.dgvkhoa.MinimumWidth = 6;
            this.dgvkhoa.Name = "dgvkhoa";
            this.dgvkhoa.Width = 67;
            // 
            // dgvdtb
            // 
            this.dgvdtb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvdtb.HeaderText = "ĐTB";
            this.dgvdtb.MinimumWidth = 6;
            this.dgvdtb.Name = "dgvdtb";
            this.dgvdtb.Width = 63;
            // 
            // grpttsv
            // 
            this.grpttsv.Controls.Add(this.comboBox1);
            this.grpttsv.Controls.Add(this.txtdtb);
            this.grpttsv.Controls.Add(this.txthoten);
            this.grpttsv.Controls.Add(this.txtmssv);
            this.grpttsv.Controls.Add(this.lbldtb);
            this.grpttsv.Controls.Add(this.lblkhoa);
            this.grpttsv.Controls.Add(this.lblhoten);
            this.grpttsv.Controls.Add(this.lblmssv);
            this.grpttsv.Location = new System.Drawing.Point(1, 67);
            this.grpttsv.Name = "grpttsv";
            this.grpttsv.Size = new System.Drawing.Size(282, 291);
            this.grpttsv.TabIndex = 1;
            this.grpttsv.TabStop = false;
            this.grpttsv.Text = "Thông Tin Sinh Viên";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(76, 242);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(200, 22);
            this.txtdtb.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(76, 106);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(200, 22);
            this.txthoten.TabIndex = 5;
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(76, 45);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(200, 22);
            this.txtmssv.TabIndex = 4;
            // 
            // lbldtb
            // 
            this.lbldtb.AutoSize = true;
            this.lbldtb.Location = new System.Drawing.Point(26, 248);
            this.lbldtb.Name = "lbldtb";
            this.lbldtb.Size = new System.Drawing.Size(34, 16);
            this.lbldtb.TabIndex = 3;
            this.lbldtb.Text = "ĐTB";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(26, 176);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 2;
            this.lblkhoa.Text = "Khoa";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(26, 112);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ Tên";
            // 
            // lblmssv
            // 
            this.lblmssv.AutoSize = true;
            this.lblmssv.Location = new System.Drawing.Point(26, 51);
            this.lblmssv.Name = "lblmssv";
            this.lblmssv.Size = new System.Drawing.Size(45, 16);
            this.lblmssv.TabIndex = 0;
            this.lblmssv.Text = "MSSV";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(4, 379);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(113, 379);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(208, 379);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(694, 415);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.grpttsv);
            this.Controls.Add(this.dgvsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            this.grpttsv.ResumeLayout(false);
            this.grpttsv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsv;
        private System.Windows.Forms.GroupBox grpttsv;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmssv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Label lbldtb;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvhoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdtb;
    }
}

