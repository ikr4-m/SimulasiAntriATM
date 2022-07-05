using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulasiAntriATM
{
    public class AlatBantu
    {
        public static int KeMenit(object data)
        {
            return (int)Math.Floor(decimal.Parse(data.ToString()) / 60);
        }

        public static string BangkitkanVariabelAcak(Dictionary<string, int> data, string bank, double angkaAcak)
        {
            // Eliminasi data yang kosong dan bukan banknya
            var dataBaru = data
                .Where(x => x.Key.Split(';')[1] == bank && x.Value > 0)
                .ToDictionary(x => x.Key, x => x.Value);
            int jumlahData = dataBaru.ToArray().Select(x => x.Value).Aggregate(0, (acc, x) => acc + x);

            // Ambil nama variabel
            var namaVar = new List<string>();
            foreach (var i in dataBaru) namaVar.Add(i.Key);

            // Bangkitkan frekuensi kumulatif
            var frekuensiKumulatif = new List<double>();
            foreach (var i in namaVar)
            {
                int nilai = dataBaru[i];
                int index = frekuensiKumulatif.Count - 1;
                double val = ((double)nilai / jumlahData) + (frekuensiKumulatif.Count == 0 ? 0 : frekuensiKumulatif[index]);
                frekuensiKumulatif.Add(val);
            }

            // Cari data dengan cara metode LIFO
            int ifrekuensi = 0;
            for (int i = 0; i < frekuensiKumulatif.Count; i++)
            {
                if (angkaAcak <= frekuensiKumulatif[i])
                {
                    ifrekuensi = i;
                    break;
                }
            }

            return namaVar[ifrekuensi].Split(';')[0];
        }
    }
}
