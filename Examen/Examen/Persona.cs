using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Persona:IPersona
    {
        public string nombre, sueldo, nacion;
        public int edad;
        public Persona() 
        {

        }

        public string getname()
        {
            return this.nombre;
        }
        public int getage()
        {
            return this.edad;
        }
        public string getnation()
        {
            return this.nacion;
        }
        public string getsueldo()
        {
            return this.sueldo;
        }
        public string getinfo()
        {
            return "nombre:" + nombre+" nacion: "+nacion+" sueldo: "+sueldo+" edad: "+edad;
        }

    }
}
