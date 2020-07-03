using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Jugador:Persona
    {
        public string pataque, pdefensa, numero, puesto;
        public Jugador()
        {

        }
        public void addplayer(string nombre, string nacion, string sueldo, int edad,string pataque, string pdefensa, string numero ,string puesto)
        {
            this.nombre = nombre;
            this.nacion = nacion;
            this.sueldo = sueldo;
            this.edad = edad;
            this.pataque = pataque;
            this.pdefensa = pdefensa;
            this.numero = numero;
            this.puesto = puesto;
        }
        public string info()
        {
            return "nombre: " + nombre + " nacionalidad: " + nacion + " numero: " + numero;
        }



    }
}
