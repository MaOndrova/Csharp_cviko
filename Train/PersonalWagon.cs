using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
   abstract class PersonalWagon : IWagon {
        List<Door> doors = new List<Door>();
        List<Chair> sits = new List<Chair>();
        int numberOfChairs;
        public Train train;

        public PersonalWagon(int numberOfChairs) {
            this.NumberOfChairs = numberOfChairs;
            for (int i = 1; i <= numberOfChairs; i++) {
                Sits.Add(new Chair(i,true,false));
            }
        }
        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Chair> Sits { get => sits; set => sits = value; }

        public void ConnectWagon(Train train) {
            if (this.train == null) {
                if (train.Wagons.Count >= 5 && train.Locomotive.Engine.Type == "parni") {
                    Console.WriteLine("Nelze pripojit " + this.GetType().Name + ", protoze parni lokomotiva muze mit pouze pet vagonu");
                }
                else {
                    train.Wagons.Add(this);
                    Console.WriteLine(this.GetType().Name + " pripojen k lokomotive");
                    this.train = train;
                }
            }
            else {
                Console.WriteLine("Tento vagon je jiz pripojen k vlaku");
            }
        }
        public void DisconnectWagon(Train train) {
            bool isConnect = false;
            foreach (var wagon in train.Wagons) {
                if (train.Wagons.Contains(this)) isConnect = true;
            }

            if (isConnect == true) {
                this.train = null;
                train.Wagons.Remove(this);
                Console.WriteLine(this.GetType().Name + " odpojen");
            }
            else {
                Console.WriteLine("Vagon neni soucasti trainu");
            }
        }
        public override string ToString() {
            return base.ToString();
        }

    }
}
