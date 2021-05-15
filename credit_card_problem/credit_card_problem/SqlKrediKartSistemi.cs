using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public class SqlKrediKartSistemi : DBKrediKartiSistemi
    {
        public override void Baglan()
        {
            Console.Write("Sql'e Baglan");
        }

        public override void Sorgula()
        {
            Console.Write("T-SQL");
        }
    }
}
