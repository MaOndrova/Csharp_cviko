using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Hooper : IWagon {
        double loadingCapacity;
        public Train train;

        public Hooper(double loadingCapacity) {
            this.loadingCapacity = loadingCapacity;
        }

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

        public override string ToString() {
            return this.GetType().Name + " kapacita naplnena na:  " + loadingCapacity;
        }


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
    }
}
