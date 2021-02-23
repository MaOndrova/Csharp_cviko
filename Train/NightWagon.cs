using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class NightWagon : PersonalWagon, IWagon{
        int numberOfBeds = 0;
        private Bed[] beds;

        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
        internal Bed[] Beds { get => beds; set => beds = value; }

        public NightWagon(int numberOfBeds, int chairs) : base(chairs) {
            this.NumberOfBeds = numberOfBeds;
            this.Beds = new Bed[NumberOfBeds];

            int j = 0;
            foreach (var item in Beds) {
                this.Beds[j] = new Bed(false);
                j++;
            }
        }

        public override string ToString() {
            return this.GetType().Name + " pocet lehatek " + NumberOfBeds;
        }

    }
}
