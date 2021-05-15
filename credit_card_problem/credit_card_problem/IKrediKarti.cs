using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public interface IKrediKarti
    {
        string KartSahibi { get; set; }
        DateTime SonKullanmaTarihi { get; set; }
        int KartNumarasi { get; set; }
        void Kullan();
    }
}
