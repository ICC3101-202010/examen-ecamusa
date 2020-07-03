using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Medico:Persona
    {
        public string pmedico;
        public void addmedic(string nombre, string nacion, string sueldo, int edad, string pmedico)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
            this.nacion = nacion;
            this.edad = edad;
            this.pmedico = pmedico;
        }
    }
}
