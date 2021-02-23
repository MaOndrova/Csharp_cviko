using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Train {
        Locomotive locomotive;
        List<IWagon> wagons = new List<IWagon>(5);
        public Train() {

        }

        public Train(Locomotive locomotive) {
            this.Locomotive = locomotive;
        }

        public Train(Locomotive locomotive, List<IWagon> wagonsX) {
            this.Locomotive = locomotive;
            foreach (IWagon wagon in wagonsX) {
                wagon.ConnectWagon(this);
            }
        }

        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<IWagon> Wagons { get => wagons; set => wagons = value; }

        public void ConnectWagon(IWagon wagon) {
            wagon.ConnectWagon(this);
        }

        public void DisconnectWagon(IWagon wagon) {
            wagon.DisconnectWagon(this);
        }

        public void ReserveChair(int number, int chair) {

            if (number <= (wagons.Count - 1)) {
                if (wagons[number] is PersonalWagon) {
                    if (chair <= ((PersonalWagon)wagons[number]).NumberOfChairs) {
                        if (((PersonalWagon)wagons[number]).Sits[chair - 1].Reserved == false) {
                            ((PersonalWagon)wagons[number]).Sits[chair - 1].Reserved = true;
                            Console.WriteLine("Rezervace sedadla " + chair + " ve vagonu " + wagons[number].GetType().Name);
                        }
                        else {
                            Console.WriteLine("Sedadlo " + chair.ToString() + " je jiz rezervovane");
                        }
                    }
                    else {
                        Console.WriteLine("sedadlo " + chair.ToString() + " neexistuje");
                    }
                }
                else {
                    Console.WriteLine("Vagon nema sedadla");
                }
            }
            else {
                Console.WriteLine("Takovy vagon neni");
            }

        }

        public void ListReservedChairs() {
            int i = 1;
            foreach (IWagon item in wagons) {
                if (item is PersonalWagon) {
                    Console.WriteLine(item.GetType().Name + " cislo " + i);
                    i++;
                    foreach (Chair sed in ((PersonalWagon)item).Sits) {
                        if (sed.Reserved == true) {
                            Console.WriteLine(" sedadlo cislo: " + sed.Number);
                        }
                    }
                }
            }
        }

        public override string ToString() {
            string s = "";
            foreach (var item in wagons) {
                s += item.ToString() + "\n";
            }
            return s + locomotive.ToString();
        }
    }
}
