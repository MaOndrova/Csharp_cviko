using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Locomotive {
        Person driver;
        Engine engine;

        internal Person Driver { get => driver; set => driver = value; }
        internal Engine Engine { get => engine; set => engine = value; }

        public Locomotive() {
        }

        public Locomotive(Person driver, Engine engine) {
            this.driver = driver;
            this.engine = engine;
        }

        public override string ToString() {
            return "Ridic lokomotivy: " + Driver.FirstName + " " + Driver.LastName ;
        }
    }
}
