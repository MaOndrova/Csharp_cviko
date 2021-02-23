using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class EconomyWagon : PersonalWagon {
        public EconomyWagon(int chairs) : base(chairs) {

        }

        public override string ToString() {
            return this.GetType().Name + " Pocet sedadel " + NumberOfChairs ;
        }
    }
}
