namespace XIIRPL2_27_Ticketing.MasterForm
{
    partial class FrmMasterJadwalPenerbangan
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
            btnSimpan = new Button();
            button1 = new Button();
            txtMaskapai = new ComboBox();
            txtKodePenerbangan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtHargaPerTicket = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            txtTanggalWaktuKeberangkatan = new DateTimePicker();
            label9 = new Label();
            txtDurasiPenerbangan = new TextBox();
            label10 = new Label();
            txtKe = new ComboBox();
            txtDari = new ComboBox();
            txtWaktuKeberangkatan = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTicket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(652, 426);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 33;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(560, 426);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(162, 364);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(219, 23);
            txtMaskapai.TabIndex = 30;
            // 
            // txtKodePenerbangan
            // 
            txtKodePenerbangan.Location = new Point(162, 261);
            txtKodePenerbangan.Name = "txtKodePenerbangan";
            txtKodePenerbangan.Size = new Size(219, 23);
            txtKodePenerbangan.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 265);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 25;
            label7.Text = "Tanggal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 367);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 24;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 333);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 23;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 301);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 22;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 265);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 21;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 56);
            label2.Name = "label2";
            label2.Size = new Size(256, 15);
            label2.TabIndex = 20;
            label2.Text = "Semua jadwal penerbangan akan muncul disini";
            // 
            // txtHargaPerTicket
            // 
            txtHargaPerTicket.Location = new Point(539, 364);
            txtHargaPerTicket.Name = "txtHargaPerTicket";
            txtHargaPerTicket.Size = new Size(200, 23);
            txtHargaPerTicket.TabIndex = 19;
            txtHargaPerTicket.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 16);
            label1.Name = "label1";
            label1.Size = new Size(336, 32);
            label1.TabIndex = 18;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnEdit, BtnDelete });
            dataGridView1.Location = new Point(51, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(699, 150);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // txtTanggalWaktuKeberangkatan
            // 
            txtTanggalWaktuKeberangkatan.Location = new Point(539, 261);
            txtTanggalWaktuKeberangkatan.Name = "txtTanggalWaktuKeberangkatan";
            txtTanggalWaktuKeberangkatan.Size = new Size(200, 23);
            txtTanggalWaktuKeberangkatan.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 333);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 36;
            label9.Text = "Durasi Penerbangan";
            label9.Click += label9_Click;
            // 
            // txtDurasiPenerbangan
            // 
            txtDurasiPenerbangan.Location = new Point(539, 330);
            txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            txtDurasiPenerbangan.Size = new Size(200, 23);
            txtDurasiPenerbangan.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(411, 367);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 38;
            label10.Text = "Harga per Ticket";
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(162, 330);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(219, 23);
            txtKe.TabIndex = 39;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(162, 298);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(219, 23);
            txtDari.TabIndex = 40;
            // 
            // txtWaktuKeberangkatan
            // 
            txtWaktuKeberangkatan.Location = new Point(539, 298);
            txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            txtWaktuKeberangkatan.Size = new Size(200, 23);
            txtWaktuKeberangkatan.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 301);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 42;
            label8.Text = "Waktu Keberangkatan";
            // 
            // FrmMasterJadwalPenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(label8);
            Controls.Add(txtWaktuKeberangkatan);
            Controls.Add(txtDari);
            Controls.Add(txtKe);
            Controls.Add(label10);
            Controls.Add(txtDurasiPenerbangan);
            Controls.Add(label9);
            Controls.Add(txtTanggalWaktuKeberangkatan);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtMaskapai);
            Controls.Add(txtKodePenerbangan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHargaPerTicket);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterJadwalPenerbangan";
            Text = "FrmMasterJadwalPenerbangan";
            Load += FrmMasterJadwalPenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)txtHargaPerTicket).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private Button button1;
        private ComboBox txtMaskapai;
        private TextBox txtKodePenerbangan;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown txtHargaPerTicket;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker txtTanggalWaktuKeberangkatan;
        private Label label9;
        private TextBox txtDurasiPenerbangan;
        private Label label10;
        private ComboBox txtKe;
        private ComboBox txtDari;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn BtnDelete;
        private TextBox txtWaktuKeberangkatan;
        private Label label8;
    }
}