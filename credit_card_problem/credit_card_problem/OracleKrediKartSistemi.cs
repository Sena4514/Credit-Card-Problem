using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public class OracleKrediKartSistemi : DBKrediKartiSistemi
    {
        public override void Baglan()
        {
            Console.Write("Oracle'a Baglan");
        }

        public override void Sorgula()
        {
            Console.Write("PL-SQL");
        }
    }
}
