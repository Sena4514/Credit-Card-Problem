using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public class KrediKartiFactory
    {
        public enum enKrediKarti
        {
            enMasterCard,
            enVisa,
            enAmericanExpress
        } 

        public IKrediKarti getKrediKarti(enKrediKarti krediKartNo)
        {
            switch (krediKartNo)
            {
                case enKrediKarti.enMasterCard:
                    return new MasterCard();
                case enKrediKarti.enVisa:
                    return new Visa();
                case enKrediKarti.enAmericanExpress:
                    return new AmericanExpress();
                default:
                    return null;
            }
        }
     
}
}
