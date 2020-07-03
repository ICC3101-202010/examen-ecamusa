using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Equipo
    {
        string nombre;
        public List<Persona> equipo = new List<Persona>();
        public void Createequipo(string nombre , List<Persona> equipo)
        {
            this.nombre = nombre;
            this.equipo = equipo;
        }
        public void infoplayers()
        {
            for(int i=0; i<15;i++)
            {
                Console.WriteLine(equipo[i].getinfo());
            }
        }
        public void infoentrenador()
        {
            Console.WriteLine(equipo[15].getinfo());
        }
        public void infomedico()
        {
            Console.WriteLine(equipo[16].getinfo());
        }
        public string getname()
        {
            return nombre;
        }
    }
}
