namespace PhanMemQuanLyKhachSan
{
    partial class frmCapNhatThongTinNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panThongTinNhanVien = new System.Windows.Forms.Panel();
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemTTNV = new System.Windows.Forms.TextBox();
            this.btnXoaTTNV = new System.Windows.Forms.Button();
            this.btnThemTTNV = new System.Windows.Forms.Button();
            this.btnBackTTNV = new System.Windows.Forms.Button();
            this.btnLuuTTNV = new System.Windows.Forms.Button();
            this.btnTimKiemTTNV = new System.Windows.Forms.Button();
            this.btnHuyCapNhatLoaiPhong = new System.Windows.Forms.Button();
            this.panThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panThongTinNhanVien
            // 
            this.panThongTinNhanVien.BackColor = System.Drawing.Color.SlateGray;
            this.panThongTinNhanVien.Controls.Add(this.dgvThongTinNhanVien);
            this.panThongTinNhanVien.Location = new System.Drawing.Point(85, 244);
            this.panThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panThongTinNhanVien.Name = "panThongTinNhanVien";
            this.panThongTinNhanVien.Size = new System.Drawing.Size(1464, 638);
            this.panThongTinNhanVien.TabIndex = 18;
            // 
            // dgvThongTinNhanVien
            // 
            this.dgvThongTinNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinNhanVien.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvThongTinNhanVien.ColumnHeadersHeight = 40;
            this.dgvThongTinNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.TenVV});
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(31, 21);
            this.dgvThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.ReadOnly = true;
            this.dgvThongTinNhanVien.RowHeadersVisible = false;
            this.dgvThongTinNhanVien.RowHeadersWidth = 51;
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(1411, 598);
            this.dgvThongTinNhanVien.TabIndex = 0;
            this.dgvThongTinNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TenVV
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.TenVV.DefaultCellStyle = dataGridViewCellStyle15;
            this.TenVV.FillWeight = 120F;
            this.TenVV.HeaderText = "Tên Nhân Viên";
            this.TenVV.MinimumWidth = 6;
            this.TenVV.Name = "TenVV";
            this.TenVV.ReadOnly = true;
            // 
            // txtTimKiemTTNV
            // 
            this.txtTimKiemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTTNV.Location = new System.Drawing.Point(504, 27);
            this.txtTimKiemTTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemTTNV.Multiline = true;
            this.txtTimKiemTTNV.Name = "txtTimKiemTTNV";
            this.txtTimKiemTTNV.Size = new System.Drawing.Size(560, 45);
            this.txtTimKiemTTNV.TabIndex = 11;
            // 
            // btnXoaTTNV
            // 
            this.btnXoaTTNV.BackColor = System.Drawing.Color.Gray;
            this.btnXoaTTNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTTNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTTNV.Location = new System.Drawing.Point(716, 143);
            this.btnXoaTTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaTTNV.Name = "btnXoaTTNV";
            this.btnXoaTTNV.Size = new System.Drawing.Size(101, 48);
            this.btnXoaTTNV.TabIndex = 17;
            this.btnXoaTTNV.Text = "Xóa";
            this.btnXoaTTNV.UseVisualStyleBackColor = false;
            this.btnXoaTTNV.Click += new System.EventHandler(this.btnXoaTTNV_Click);
            // 
            // btnThemTTNV
            // 
            this.btnThemTTNV.BackColor = System.Drawing.Color.Gray;
            this.btnThemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTTNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTTNV.Location = new System.Drawing.Point(521, 144);
            this.btnThemTTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemTTNV.Name = "btnThemTTNV";
            this.btnThemTTNV.Size = new System.Drawing.Size(116, 48);
            this.btnThemTTNV.TabIndex = 16;
            this.btnThemTTNV.Text = "Thêm";
            this.btnThemTTNV.UseVisualStyleBackColor = false;
            this.btnThemTTNV.Click += new System.EventHandler(this.btnThemTTNV_Click);
            // 
            // btnBackTTNV
            // 
            this.btnBackTTNV.BackColor = System.Drawing.Color.Gray;
            this.btnBackTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTTNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTTNV.Location = new System.Drawing.Point(16, 15);
            this.btnBackTTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackTTNV.Name = "btnBackTTNV";
            this.btnBackTTNV.Size = new System.Drawing.Size(112, 48);
            this.btnBackTTNV.TabIndex = 15;
            this.btnBackTTNV.Text = "Trở lại";
            this.btnBackTTNV.UseVisualStyleBackColor = false;
            this.btnBackTTNV.Click += new System.EventHandler(this.BtnBackTTNV_Click);
            // 
            // btnLuuTTNV
            // 
            this.btnLuuTTNV.BackColor = System.Drawing.Color.Gray;
            this.btnLuuTTNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTTNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLuuTTNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuTTNV.Location = new System.Drawing.Point(934, 144);
            this.btnLuuTTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuTTNV.Name = "btnLuuTTNV";
            this.btnLuuTTNV.Size = new System.Drawing.Size(107, 48);
            this.btnLuuTTNV.TabIndex = 13;
            this.btnLuuTTNV.Text = "Lưu";
            this.btnLuuTTNV.UseVisualStyleBackColor = false;
            this.btnLuuTTNV.Click += new System.EventHandler(this.btnLuuTTNV_Click);
            // 
            // btnTimKiemTTNV
            // 
            this.btnTimKiemTTNV.BackColor = System.Drawing.Color.Gray;
            this.btnTimKiemTTNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiemTTNV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTTNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiemTTNV.Location = new System.Drawing.Point(1073, 27);
            this.btnTimKiemTTNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiemTTNV.Name = "btnTimKiemTTNV";
            this.btnTimKiemTTNV.Size = new System.Drawing.Size(169, 46);
            this.btnTimKiemTTNV.TabIndex = 10;
            this.btnTimKiemTTNV.Text = "Tìm Kiếm";
            this.btnTimKiemTTNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiemTTNV.UseVisualStyleBackColor = false;
            this.btnTimKiemTTNV.Click += new System.EventHandler(this.btnTimKiemTTNV_Click);
            // 
            // btnHuyCapNhatLoaiPhong
            // 
            this.btnHuyCapNhatLoaiPhong.BackColor = System.Drawing.Color.Gray;
            this.btnHuyCapNhatLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyCapNhatLoaiPhong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyCapNhatLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyCapNhatLoaiPhong.Location = new System.Drawing.Point(1115, 142);
            this.btnHuyCapNhatLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuyCapNhatLoaiPhong.Name = "btnHuyCapNhatLoaiPhong";
            this.btnHuyCapNhatLoaiPhong.Size = new System.Drawing.Size(113, 49);
            this.btnHuyCapNhatLoaiPhong.TabIndex = 19;
            this.btnHuyCapNhatLoaiPhong.Text = "Hủy";
            this.btnHuyCapNhatLoaiPhong.UseVisualStyleBackColor = false;
            this.btnHuyCapNhatLoaiPhong.Click += new System.EventHandler(this.btnHuyCapNhatLoaiPhong_Click);
            // 
            // frmCapNhatThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1643, 913);
            this.Controls.Add(this.btnHuyCapNhatLoaiPhong);
            this.Controls.Add(this.btnThemTTNV);
            this.Controls.Add(this.panThongTinNhanVien);
            this.Controls.Add(this.btnXoaTTNV);
            this.Controls.Add(this.btnBackTTNV);
            this.Controls.Add(this.btnLuuTTNV);
            this.Controls.Add(this.txtTimKiemTTNV);
            this.Controls.Add(this.btnTimKiemTTNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCapNhatThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.frmCapNhatThongTinNhanVien_Load);
            this.panThongTinNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panThongTinNhanVien;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
        private System.Windows.Forms.Button btnXoaTTNV;
        private System.Windows.Forms.Button btnThemTTNV;
        private System.Windows.Forms.Button btnBackTTNV;
        private System.Windows.Forms.Button btnLuuTTNV;
        private System.Windows.Forms.TextBox txtTimKiemTTNV;
        private System.Windows.Forms.Button btnTimKiemTTNV;
        private System.Windows.Forms.Button btnHuyCapNhatLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVV;
    }
}