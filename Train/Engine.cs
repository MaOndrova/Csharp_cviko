using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    class Engine {
        String type;

        public Engine(string type) {
            this.type = type;
        }

        public string Type { get => type; set => type = value; }

        public override string ToString() {
            return "Typ enginu: " + type;
        }
    }
}
