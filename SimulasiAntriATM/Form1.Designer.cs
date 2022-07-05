namespace SimulasiAntriATM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumJumlahPengunjung = new System.Windows.Forms.NumericUpDown();
            this.CmbATM = new System.Windows.Forms.ComboBox();
            this.BtnAcak = new System.Windows.Forms.Button();
            this.TxtKeterangan = new System.Windows.Forms.TextBox();
            this.DGTabelData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IWK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RangeUmur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sendiri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JenisTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MengantriUlang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumIWKBatasBawah = new System.Windows.Forms.NumericUpDown();
            this.NumIWKBatasAtas = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumLPBatasAtas = new System.Windows.Forms.NumericUpDown();
            this.NumLPBatasBawah = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumJumlahPengunjung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTabelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIWKBatasBawah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIWKBatasAtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLPBatasAtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLPBatasBawah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah Pengunjung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATM yang Digunakan";
            // 
            // NumJumlahPengunjung
            // 
            this.NumJumlahPengunjung.Location = new System.Drawing.Point(158, 7);
            this.NumJumlahPengunjung.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumJumlahPengunjung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumJumlahPengunjung.Name = "NumJumlahPengunjung";
            this.NumJumlahPengunjung.Size = new System.Drawing.Size(120, 20);
            this.NumJumlahPengunjung.TabIndex = 2;
            this.NumJumlahPengunjung.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbATM
            // 
            this.CmbATM.FormattingEnabled = true;
            this.CmbATM.Items.AddRange(new object[] {
            "BRI",
            "BCA"});
            this.CmbATM.Location = new System.Drawing.Point(158, 34);
            this.CmbATM.Name = "CmbATM";
            this.CmbATM.Size = new System.Drawing.Size(120, 21);
            this.CmbATM.TabIndex = 3;
            // 
            // BtnAcak
            // 
            this.BtnAcak.Location = new System.Drawing.Point(558, 7);
            this.BtnAcak.Name = "BtnAcak";
            this.BtnAcak.Size = new System.Drawing.Size(120, 48);
            this.BtnAcak.TabIndex = 4;
            this.BtnAcak.Text = "Acak";
            this.BtnAcak.UseVisualStyleBackColor = true;
            this.BtnAcak.Click += new System.EventHandler(this.BtnAcak_Click);
            // 
            // TxtKeterangan
            // 
            this.TxtKeterangan.Location = new System.Drawing.Point(684, 30);
            this.TxtKeterangan.Multiline = true;
            this.TxtKeterangan.Name = "TxtKeterangan";
            this.TxtKeterangan.ReadOnly = true;
            this.TxtKeterangan.Size = new System.Drawing.Size(265, 441);
            this.TxtKeterangan.TabIndex = 5;
            // 
            // DGTabelData
            // 
            this.DGTabelData.AllowUserToAddRows = false;
            this.DGTabelData.AllowUserToDeleteRows = false;
            this.DGTabelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTabelData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.IWK,
            this.WK,
            this.WA,
            this.WMP,
            this.LP,
            this.WSP,
            this.JenisKelamin,
            this.RangeUmur,
            this.Sendiri,
            this.JenisTransaksi,
            this.MengantriUlang});
            this.DGTabelData.Location = new System.Drawing.Point(12, 61);
            this.DGTabelData.Name = "DGTabelData";
            this.DGTabelData.ReadOnly = true;
            this.DGTabelData.Size = new System.Drawing.Size(666, 410);
            this.DGTabelData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Keterangan";
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // IWK
            // 
            this.IWK.HeaderText = "Interval Waktu Kedatangan";
            this.IWK.Name = "IWK";
            this.IWK.ReadOnly = true;
            // 
            // WK
            // 
            this.WK.HeaderText = "Waktu Kedatangan";
            this.WK.Name = "WK";
            this.WK.ReadOnly = true;
            // 
            // WA
            // 
            this.WA.HeaderText = "Waktu Antri";
            this.WA.Name = "WA";
            this.WA.ReadOnly = true;
            // 
            // WMP
            // 
            this.WMP.HeaderText = "Waktu Menunggu Proses";
            this.WMP.Name = "WMP";
            this.WMP.ReadOnly = true;
            // 
            // LP
            // 
            this.LP.HeaderText = "Lama Proses";
            this.LP.Name = "LP";
            this.LP.ReadOnly = true;
            // 
            // WSP
            // 
            this.WSP.HeaderText = "Waktu Selesai Proses";
            this.WSP.Name = "WSP";
            this.WSP.ReadOnly = true;
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.HeaderText = "Jenis Kelamin";
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.ReadOnly = true;
            // 
            // RangeUmur
            // 
            this.RangeUmur.HeaderText = "Range Umur";
            this.RangeUmur.Name = "RangeUmur";
            this.RangeUmur.ReadOnly = true;
            // 
            // Sendiri
            // 
            this.Sendiri.HeaderText = "Sendiri";
            this.Sendiri.Name = "Sendiri";
            this.Sendiri.ReadOnly = true;
            // 
            // JenisTransaksi
            // 
            this.JenisTransaksi.HeaderText = "Jenis Transaksi";
            this.JenisTransaksi.Name = "JenisTransaksi";
            this.JenisTransaksi.ReadOnly = true;
            // 
            // MengantriUlang
            // 
            this.MengantriUlang.HeaderText = "Mengantri Ulang";
            this.MengantriUlang.Name = "MengantriUlang";
            this.MengantriUlang.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Batas Acak IWK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Batas Acak LP";
            // 
            // NumIWKBatasBawah
            // 
            this.NumIWKBatasBawah.Location = new System.Drawing.Point(398, 7);
            this.NumIWKBatasBawah.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumIWKBatasBawah.Name = "NumIWKBatasBawah";
            this.NumIWKBatasBawah.Size = new System.Drawing.Size(50, 20);
            this.NumIWKBatasBawah.TabIndex = 10;
            // 
            // NumIWKBatasAtas
            // 
            this.NumIWKBatasAtas.Location = new System.Drawing.Point(500, 7);
            this.NumIWKBatasAtas.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumIWKBatasAtas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumIWKBatasAtas.Name = "NumIWKBatasAtas";
            this.NumIWKBatasAtas.Size = new System.Drawing.Size(50, 20);
            this.NumIWKBatasAtas.TabIndex = 11;
            this.NumIWKBatasAtas.Value = new decimal(new int[] {
            292,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "sampai";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "sampai";
            // 
            // NumLPBatasAtas
            // 
            this.NumLPBatasAtas.Location = new System.Drawing.Point(500, 35);
            this.NumLPBatasAtas.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumLPBatasAtas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumLPBatasAtas.Name = "NumLPBatasAtas";
            this.NumLPBatasAtas.Size = new System.Drawing.Size(50, 20);
            this.NumLPBatasAtas.TabIndex = 14;
            this.NumLPBatasAtas.Value = new decimal(new int[] {
            197,
            0,
            0,
            0});
            // 
            // NumLPBatasBawah
            // 
            this.NumLPBatasBawah.Location = new System.Drawing.Point(398, 35);
            this.NumLPBatasBawah.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumLPBatasBawah.Name = "NumLPBatasBawah";
            this.NumLPBatasBawah.Size = new System.Drawing.Size(50, 20);
            this.NumLPBatasBawah.TabIndex = 13;
            this.NumLPBatasBawah.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 483);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumLPBatasAtas);
            this.Controls.Add(this.NumLPBatasBawah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NumIWKBatasAtas);
            this.Controls.Add(this.NumIWKBatasBawah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGTabelData);
            this.Controls.Add(this.TxtKeterangan);
            this.Controls.Add(this.BtnAcak);
            this.Controls.Add(this.CmbATM);
            this.Controls.Add(this.NumJumlahPengunjung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulasi Antrian ATM";
            ((System.ComponentModel.ISupportInitialize)(this.NumJumlahPengunjung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTabelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIWKBatasBawah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIWKBatasAtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLPBatasAtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLPBatasBawah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumJumlahPengunjung;
        private System.Windows.Forms.ComboBox CmbATM;
        private System.Windows.Forms.Button BtnAcak;
        private System.Windows.Forms.TextBox TxtKeterangan;
        private System.Windows.Forms.DataGridView DGTabelData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn IWK;
        private System.Windows.Forms.DataGridViewTextBoxColumn WK;
        private System.Windows.Forms.DataGridViewTextBoxColumn WA;
        private System.Windows.Forms.DataGridViewTextBoxColumn WMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LP;
        private System.Windows.Forms.DataGridViewTextBoxColumn WSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RangeUmur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sendiri;
        private System.Windows.Forms.DataGridViewTextBoxColumn JenisTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MengantriUlang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumIWKBatasBawah;
        private System.Windows.Forms.NumericUpDown NumIWKBatasAtas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumLPBatasAtas;
        private System.Windows.Forms.NumericUpDown NumLPBatasBawah;
    }
}

