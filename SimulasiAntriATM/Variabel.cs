using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasiAntriATM
{
    public class Variabel
    {
        public static Dictionary<string, int> JenisKelamin = new Dictionary<string, int>()
        {
            { "Laki-laki;BCA", 20 },
            { "Perempuan;BCA", 21 },
            { "Laki-laki;BRI", 25 },
            { "Perempuan;BRI", 34 }
        };

        public static Dictionary<string, int> RangeUmur = new Dictionary<string, int>()
        {
            { "Remaja;BCA", 10 },
            { "Dewasa;BCA", 31 },
            { "Lansia;BCA", 0 },
            { "Remaja;BRI", 16 },
            { "Dewasa;BRI", 34 },
            { "Lansia;BRI", 9 }
        };

        public static Dictionary<string, int> Sendiri = new Dictionary<string, int>()
        {
            { "Ya;BCA", 38 },
            { "Tidak;BCA", 3 },
            { "Ya;BRI", 52 },
            { "Tidak;BRI", 7 }
        };

        public static Dictionary<string, int> JenisTransaksi = new Dictionary<string, int>()
        {
            { "Tarik;BCA", 21 },
            { "Transfer;BCA", 17 },
            { "Cek Saldo;BCA", 2 },
            { "Setor;BCA", 1 },
            { "Tarik;BRI", 40 },
            { "Transfer;BRI", 15 },
            { "Cek Saldo;BRI", 4 },
            { "Setor;BRI", 0 }
        };

        public static Dictionary<string, int> MengantriUlang = new Dictionary<string, int>()
        {
            { "Ya;BCA", 2 },
            { "Tidak;BCA", 39 },
            { "Ya;BRI", 6 },
            { "Tidak;BRI", 53 }
        };
    }
}
