using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Entrenador:Persona
    {
        public string ptactica;
        public void addentrenador(string nombre, string nacion, string sueldo , int edad,string ptactica ) 
        {
            this.nombre = nombre;
            this.nacion = nacion;
            this.edad = edad;
            this.sueldo = sueldo;
            this.ptactica = ptactica;
        }


    }
}
