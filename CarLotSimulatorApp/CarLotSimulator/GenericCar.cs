using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class GenericCar
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }
        public GenericCar() { }


    }
}
