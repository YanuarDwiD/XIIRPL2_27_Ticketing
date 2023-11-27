namespace XIIRPL2_27_Ticketing.MasterForm
{
    partial class FrmMasterbandara
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
            label10 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            txtNegara = new ComboBox();
            txtNama = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtJumlahTerminal = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            txtAlamat = new TextBox();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(411, 254);
            label10.Name = "label10";
            label10.Size = new Size(93, 15);
            label10.TabIndex = 59;
            label10.Text = "Jumlah Terminal";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(644, 399);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 54;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(551, 399);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 53;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(162, 357);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(219, 23);
            txtNegara.TabIndex = 52;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(162, 254);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(219, 23);
            txtNama.TabIndex = 51;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 291);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 49;
            label7.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 360);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 48;
            label6.Text = "Negara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 326);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 47;
            label5.Text = "Kota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 294);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 46;
            label4.Text = "Kode IATA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 258);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 45;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 49);
            label2.Name = "label2";
            label2.Size = new Size(269, 15);
            label2.TabIndex = 44;
            label2.Tag = "";
            label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // txtJumlahTerminal
            // 
            txtJumlahTerminal.Location = new Point(519, 254);
            txtJumlahTerminal.Name = "txtJumlahTerminal";
            txtJumlahTerminal.Size = new Size(200, 23);
            txtJumlahTerminal.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 42;
            label1.Text = "Master Bandara";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(51, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(699, 150);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(162, 291);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(219, 23);
            txtKodeIATA.TabIndex = 60;
            txtKodeIATA.TextChanged += txtKodeIATA_TextChanged;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(162, 323);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(219, 23);
            txtKota.TabIndex = 61;
            txtKota.TextChanged += txtKota_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(519, 294);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(200, 81);
            txtAlamat.TabIndex = 62;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterbandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAlamat);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(label10);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtNegara);
            Controls.Add(txtNama);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtJumlahTerminal);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterbandara";
            Text = "FrmMasterbandara";
            Load += FrmMasterbandara_Load;
            ((System.ComponentModel.ISupportInitialize)txtJumlahTerminal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Button btnSimpan;
        private Button button1;
        private ComboBox txtNegara;
        private TextBox txtNama;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown txtJumlahTerminal;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private TextBox txtAlamat;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}