using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimulasiAntriATM
{
    public partial class Form1 : Form
    {
        private Stopwatch _timer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void BersihkanData()
        {
            DGTabelData.Rows.Clear();
            _timer.Reset();
        }

        private bool IsianTidakValid()
        {
            bool ret = false;
            if (CmbATM.Text == "") ret = true;
            if (NumIWKBatasBawah.Value >= NumIWKBatasAtas.Value) ret = true;
            if (NumLPBatasBawah.Value >= NumLPBatasAtas.Value) ret = true;

            if (ret)
                MessageBox.Show("Isian tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return ret;
        }

        private void IsiKeterangan()
        {
            var caster = DGTabelData.Rows.Cast<DataGridViewRow>();
            int panjang = (int)NumJumlahPengunjung.Value;
            int wspFinal = (int)DGTabelData.Rows[panjang - 1].Cells["WSP"].Value;
            double avgWaktuAntri = (double)DGTabelData.Rows.Cast<DataGridViewRow>().Sum(x => (int)x.Cells["WA"].Value) / panjang;
            double avgIWK = (double)caster.Sum(x => (int)x.Cells["IWK"].Value) / panjang;

            string jenisKelaminTerbanyak = caster.GroupBy(x => x.Cells["JenisKelamin"].Value.ToString())
                .OrderByDescending(x => x.Count())
                .Select(x => $"{x.Key} ({x.Count()} orang)")
                .First();
            string umurTerbanyak = caster.GroupBy(x => x.Cells["RangeUmur"].Value.ToString())
                .OrderByDescending(x => x.Count())
                .Select(x => $"{x.Key} ({x.Count()} orang)")
                .First();
            string jenisTransaksiTerbanyak = caster.GroupBy(x => x.Cells["JenisTransaksi"].Value.ToString())
                .OrderByDescending(x => x.Count())
                .Select(x => $"{x.Key} ({x.Count()} orang)")
                .First();

            TxtKeterangan.Text = $"- Waktu yang dibutuhkan untuk melayani {panjang} orang adalah {AlatBantu.KeMenit(wspFinal)} menit ({wspFinal} detik)." + Environment.NewLine +
                $"- Rata-rata interval waktu kedatangan adalah {avgIWK:0.##} detik" + Environment.NewLine +
                $"- Rata-rata waktu antri adalah {avgWaktuAntri:0.##} detik" + Environment.NewLine +
                $"- Diperkirakan kebanyakan orang yang mengantri adalah berjenis kelamin {jenisKelaminTerbanyak}, umur {umurTerbanyak}, dan jenis transaksi yaitu {jenisTransaksiTerbanyak}." + Environment.NewLine +
                $"- Lama yang digunakan untuk menghitung simulasi ini adalah {_timer.ElapsedMilliseconds} ms";
        }

        private void BtnAcak_Click(object sender, EventArgs e)
        {
            if (IsianTidakValid()) return;

            BersihkanData();
            _timer.Start();
            var random = new Random();
            
            for (int i = 0; i < NumJumlahPengunjung.Value; i++)
            {
                // Bangkitkan waktu mengantri
                int randIWK = random.Next((int)NumIWKBatasBawah.Value, (int)NumIWKBatasAtas.Value);
                int randLP = random.Next((int)NumLPBatasBawah.Value, (int)NumLPBatasAtas.Value);

                DGTabelData.Rows.Add();
                DGTabelData.Rows[i].Cells["No"].Value = i + 1;
                DGTabelData.Rows[i].Cells["LP"].Value = randLP;

                if (i == 0)
                {
                    DGTabelData.Rows[i].Cells["IWK"].Value = 0;
                    DGTabelData.Rows[i].Cells["WK"].Value = 0;
                    DGTabelData.Rows[i].Cells["WA"].Value = 0;
                    DGTabelData.Rows[i].Cells["WMP"].Value = 0;
                }
                else
                {
                    int wspLama = (int)DGTabelData.Rows[i - 1].Cells["WSP"].Value;
                    int wk = (int)DGTabelData.Rows[i - 1].Cells["WK"].Value + randIWK;
                    int wmpBaru = wspLama > wk ? wspLama : wk;

                    DGTabelData.Rows[i].Cells["WMP"].Value = wspLama > wk ? wspLama : wk;
                    DGTabelData.Rows[i].Cells["IWK"].Value = randIWK;
                    DGTabelData.Rows[i].Cells["WK"].Value = wk;
                    DGTabelData.Rows[i].Cells["WA"].Value = wmpBaru - wk;
                }

                DGTabelData.Rows[i].Cells["WSP"].Value = randLP + (int)DGTabelData.Rows[i].Cells["WMP"].Value;

                // Bangkitkan angka random untuk variabel penunjang
                string bank = CmbATM.Text;
                DGTabelData.Rows[i].Cells["JenisKelamin"].Value = AlatBantu.BangkitkanVariabelAcak(Variabel.JenisKelamin, bank, random.NextDouble());
                DGTabelData.Rows[i].Cells["RangeUmur"].Value = AlatBantu.BangkitkanVariabelAcak(Variabel.RangeUmur, bank, random.NextDouble());
                DGTabelData.Rows[i].Cells["Sendiri"].Value = AlatBantu.BangkitkanVariabelAcak(Variabel.Sendiri, bank, random.NextDouble());
                DGTabelData.Rows[i].Cells["JenisTransaksi"].Value = AlatBantu.BangkitkanVariabelAcak(Variabel.JenisTransaksi, bank, random.NextDouble());
                DGTabelData.Rows[i].Cells["MengantriUlang"].Value = AlatBantu.BangkitkanVariabelAcak(Variabel.MengantriUlang, bank, random.NextDouble());
            }

            _timer.Stop();
            IsiKeterangan();
        }
    }
}
