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
            { "Laki-laki", 45 },
            { "Perempuan", 55 }
        };

        public static Dictionary<string, int> RangeUmur = new Dictionary<string, int>()
        {
            { "Remaja", 26 },
            { "Dewasa", 65 },
            { "Lansia", 9 }
        };

        public static Dictionary<string, int> Sendiri = new Dictionary<string, int>()
        {
            { "Ya", 90 },
            { "Tidak", 10 }
        };

        public static Dictionary<string, int> JenisTransaksi = new Dictionary<string, int>()
        {
            { "Tarik", 61 },
            { "Transfer", 32 },
            { "Cek Saldo", 6 },
            { "Setor", 1 }
        };

        public static Dictionary<string, int> MengantriUlang = new Dictionary<string, int>()
        {
            { "Ya", 8 },
            { "Tidak", 92 }
        };

        public static Dictionary<string, int> Bank = new Dictionary<string, int>()
        {
            { "BRI", 59 },
            { "BCA", 41 }
        };
    }
}
