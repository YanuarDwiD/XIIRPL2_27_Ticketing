namespace XIIRPL2_27_Ticketing.MasterForm
{
    partial class FrmMasterKodePromo
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
            txtPresentaseDiskon = new NumericUpDown();
            btnSimpan = new Button();
            button1 = new Button();
            txtDeksripsi = new TextBox();
            txtKodePromo = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtBerlakuSampai = new DateTimePicker();
            txtMaksimumDiskon = new NumericUpDown();
            label6 = new Label();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).BeginInit();
            SuspendLayout();
            // 
            // txtPresentaseDiskon
            // 
            txtPresentaseDiskon.Location = new Point(162, 348);
            txtPresentaseDiskon.Name = "txtPresentaseDiskon";
            txtPresentaseDiskon.Size = new Size(220, 23);
            txtPresentaseDiskon.TabIndex = 47;
            txtPresentaseDiskon.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(604, 406);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 46;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(505, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 45;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDeksripsi
            // 
            txtDeksripsi.Location = new Point(484, 271);
            txtDeksripsi.Multiline = true;
            txtDeksripsi.Name = "txtDeksripsi";
            txtDeksripsi.Size = new Size(210, 100);
            txtDeksripsi.TabIndex = 44;
            txtDeksripsi.TextChanged += textBox4_TextChanged;
            // 
            // txtKodePromo
            // 
            txtKodePromo.Location = new Point(163, 276);
            txtKodePromo.Name = "txtKodePromo";
            txtKodePromo.Size = new Size(219, 23);
            txtKodePromo.TabIndex = 42;
            txtKodePromo.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 279);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 41;
            label8.Text = "Deskripsi";
            label8.Click += label8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 350);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 40;
            label5.Text = "Presentase Diskon";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 313);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 39;
            label4.Text = "Berlaku Sampai";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 279);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 38;
            label3.Text = "Kode Promo";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 70);
            label2.Name = "label2";
            label2.Size = new Size(291, 15);
            label2.TabIndex = 37;
            label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 30);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 36;
            label1.Text = "Master Kode Promo";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(51, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 150);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtBerlakuSampai
            // 
            txtBerlakuSampai.Location = new Point(162, 313);
            txtBerlakuSampai.Name = "txtBerlakuSampai";
            txtBerlakuSampai.Size = new Size(220, 23);
            txtBerlakuSampai.TabIndex = 48;
            // 
            // txtMaksimumDiskon
            // 
            txtMaksimumDiskon.Location = new Point(163, 384);
            txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            txtMaksimumDiskon.Size = new Size(220, 23);
            txtMaksimumDiskon.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 387);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 49;
            label6.Text = "Maksimum Diskon";
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
            // FrmMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMaksimumDiskon);
            Controls.Add(label6);
            Controls.Add(txtBerlakuSampai);
            Controls.Add(txtPresentaseDiskon);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeksripsi);
            Controls.Add(txtKodePromo);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmMasterKodePromo";
            Text = "FrmMasterKodePromo";
            Load += FrmMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)txtPresentaseDiskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimumDiskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown txtPresentaseDiskon;
        private Button btnSimpan;
        private Button button1;
        private TextBox txtDeksripsi;
        private TextBox txtKodePromo;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker txtBerlakuSampai;
        private NumericUpDown txtMaksimumDiskon;
        private Label label6;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}