using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS2
{
    public class Est1
    {
        public int id {  get; set; }
        public int carnet { get; set; }
        public string nombre { get; set; }

        public string apelli { get; set; }

        public int acum { get; set; }

        public int exam { get; set; }

        public int final { get; set; }

        public Est1() { }

        public Est1(int carnet, string nombre, string apelli, int acum, int exam, int final, int id)
        {
            this.id = id;
            this.carnet = carnet;
            this.nombre = nombre;
            this.apelli = apelli;
            this.acum = acum;
            this.exam = exam;
            this.final = final;
            this.id = id;
        }
    }
}
