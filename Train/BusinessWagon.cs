using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
      class BusinessWagon : PersonalWagon{
        Person stevard;
        public BusinessWagon(Person stev, int chairs) : base(chairs) {
            this.stevard = stev;
        }

        public override string ToString() {
            return this.GetType().Name + " Stevard: " + stevard.FirstName + " " + stevard.LastName + " pocet sedadel: " + NumberOfChairs;
        }
    }
}
