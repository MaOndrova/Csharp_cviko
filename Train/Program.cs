using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Program {
        static void Main(string[] args) {
            Person per = new Person("Lenka", "Vodickova");
            Person perLok = new Person("Michal", "Nevrly");
            Engine en = new Engine("diesel");
            Locomotive l1 = new Locomotive(perLok, en);

            NightWagon n1 = new NightWagon(50, 34);
            EconomyWagon e1 = new EconomyWagon(47);
            BusinessWagon b1 = new BusinessWagon(per, 45);
            BusinessWagon b2 = new BusinessWagon(per, 45);
            Hooper h1 = new Hooper(56);
            Hooper h2 = new Hooper(66);

            Train t1 = new Train(l1, new List<IWagon> { n1, b1, e1, b2, h1});
            t1.ConnectWagon(h2);
            t1.ConnectWagon(h1);

            t1.ReserveChair(1, 45);
            t1.ReserveChair(1, 46); //Sedadlo neexistuje
            t1.ReserveChair(1, 45); //Jiz rezervovane sedadlo
            t1.ReserveChair(7, 56); //Takovy vagon neni
            t1.ReserveChair(4, 56); //Vagon nema sedadla

            t1.ListReservedChairs();
        
            Engine en2 = new Engine("parni");
            Locomotive l2 = new Locomotive(perLok, en2);
            NightWagon n2 = new NightWagon(50, 34);
            EconomyWagon e2 = new EconomyWagon(47);
            BusinessWagon b3 = new BusinessWagon(per, 45);
            BusinessWagon b4 = new BusinessWagon(per, 45);
            Hooper h3 = new Hooper(56);
            Train t2 = new Train(l2, new List<IWagon> { n2, e2, b3, b4, h3 });
            t2.ConnectWagon(new EconomyWagon(65));
            t2.DisconnectWagon(e2);
            t2.ConnectWagon(n2); //Pripojeni pateho sesteho vozu
        }
    }
}
