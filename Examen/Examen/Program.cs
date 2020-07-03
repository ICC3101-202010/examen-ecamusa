using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, nacion, sueldo, puesto, pataque, pdefensa, numero, ptactica, pmedico, nombrequipo;
            int edad;
            Console.WriteLine("1)liga");
            Console.WriteLine("2)seleccion");
            string z = "";
            int i = 0;
            z = Console.ReadLine();
            if (z == "1")
            {
                Console.Clear();
                Equipo equipo = new Equipo();
                Console.WriteLine("ingrese nombre del equipo:");
                nombrequipo = Console.ReadLine();
                while (i != 15)
                {
                    Console.Clear();
                    Jugador jugador = new Jugador();
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese nacionalidad:");
                    nacion = Console.ReadLine();
                    Console.WriteLine("ingrese puesto:");
                    puesto = Console.ReadLine();
                    Console.WriteLine("ingrese puntos de ataque:");
                    pataque = Console.ReadLine();
                    Console.WriteLine("ingrese puntos de defensa:");
                    pdefensa = Console.ReadLine();
                    Console.WriteLine("ingrese numero:");
                    numero = Console.ReadLine();
                    Console.WriteLine("ingrese sueldo:");
                    sueldo = Console.ReadLine();
                    Console.WriteLine("ingrese edad:");
                    try
                    {
                        edad = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input incorrecto por favor ingrese un numero");
                        edad = Convert.ToInt32(Console.ReadLine());
                    }
                    jugador.addplayer(nombre, nacion, sueldo, edad, pataque, pdefensa, numero, puesto);
                    equipo.equipo.Add(jugador);
                    i += 1;

                }

                Console.WriteLine("ingrese nombre del entrenador:");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese nacionalidad entrenador:");
                nacion = Console.ReadLine();
                Console.WriteLine("ingrese edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese sueldo:");
                sueldo = Console.ReadLine();
                Console.WriteLine("ingrese puntos de tactica");
                ptactica = Console.ReadLine();
                Entrenador entrenador = new Entrenador();
                entrenador.addentrenador(nombre, nacion,sueldo,edad,ptactica);
                equipo.equipo.Add(entrenador);
                
                Console.WriteLine("ingrese nombre del medico:");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese nacionalidad medico:");
                nacion = Console.ReadLine();
                Console.WriteLine("ingrese edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese sueldo:");
                sueldo = Console.ReadLine();
                Console.WriteLine("ingrese puntos de medico:");
                pmedico = Console.ReadLine();
                Medico medico = new Medico();
                medico.addmedic(nombre, nacion, sueldo, edad, pmedico);
                equipo.equipo.Add(medico);
                equipo.Createequipo(nombrequipo,equipo.equipo);
                string h = "";
                Console.Clear();
                while (h != "5")
                {
                    Console.WriteLine("1) ver jugadores del equipo");
                    Console.WriteLine("2) ver entrenador del equipo");
                    Console.WriteLine("3) ver medico del equipo");
                    Console.WriteLine("4) ver nombre equipo");
                    Console.WriteLine("5) salir");
                    h = Console.ReadLine();

                    if (h == "1")
                    {
                        Console.Clear();
                        equipo.infoplayers();
                        System.Threading.Thread.Sleep(5000);
                    }
                    if (h == "2")
                    {
                        Console.Clear();
                        equipo.infoentrenador();
                        System.Threading.Thread.Sleep(5000);

                    }
                    if (h == "3")
                    {
                        Console.Clear();
                        equipo.infomedico();
                        System.Threading.Thread.Sleep(5000);
                    }
                    if (h == "4")
                    {
                        Console.Clear();
                        Console.WriteLine(equipo.getname());
                    }
                }
                




            }
            if (z == "2")
            {
                Console.Clear();
                Equipo equipo = new Equipo();
                Console.WriteLine("ingrese nombre de la seleccion:");
                nombrequipo = Console.ReadLine();
                while (i != 15)
                {
                    Console.Clear();
                    Jugador jugador = new Jugador();
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine("ingrese nacionalidad:");
                    nacion = Console.ReadLine();
                    if (nacion == nombrequipo)
                    {
                        Console.WriteLine("ingrese puesto:");
                        puesto = Console.ReadLine();
                        Console.WriteLine("ingrese puntos de ataque:");
                        pataque = Console.ReadLine();
                        Console.WriteLine("ingrese puntos de defensa:");
                        pdefensa = Console.ReadLine();
                        Console.WriteLine("ingrese numero:");
                        numero = Console.ReadLine();
                        Console.WriteLine("ingrese sueldo:");
                        sueldo = Console.ReadLine();
                        Console.WriteLine("ingrese edad:");
                        edad = Convert.ToInt32(Console.ReadLine());
                        jugador.addplayer(nombre, nacion, sueldo, edad, pataque, pdefensa, numero, puesto);
                        equipo.equipo.Add(jugador);
                        i += 1;
                    }
                    else
                    {
                        Console.WriteLine("ingrese un input valido");
                        System.Threading.Thread.Sleep(5000);


                    }


                }
                Console.WriteLine("ingrese nombre del entrenador:");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese nacionalidad entrenador:");
                nacion = Console.ReadLine();
                Console.WriteLine("ingrese edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese sueldo:");
                sueldo = Console.ReadLine();
                Console.WriteLine("ingrese puntos de tactica");
                ptactica = Console.ReadLine();
                Entrenador entrenador = new Entrenador();
                entrenador.addentrenador(nombre, nacion, sueldo, edad, ptactica);
                equipo.equipo.Add(entrenador);

                Console.WriteLine("ingrese nombre del medico:");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese nacionalidad medico:");
                nacion = Console.ReadLine();
                Console.WriteLine("ingrese edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese sueldo:");
                sueldo = Console.ReadLine();
                Console.WriteLine("ingrese puntos de medico:");
                pmedico = Console.ReadLine();
                Medico medico = new Medico();
                medico.addmedic(nombre, nacion, sueldo, edad, pmedico);
                equipo.equipo.Add(medico);
                equipo.Createequipo(nombrequipo, equipo.equipo);
                string h = "";
                Console.Clear();
                while (h != "5")
                {
                    Console.WriteLine("1) ver jugadores del equipo");
                    Console.WriteLine("2) ver entrenador del equipo");
                    Console.WriteLine("3) ver medico del equipo");
                    Console.WriteLine("4) ver nombre equipo");
                    Console.WriteLine("5) salir");
                    h = Console.ReadLine();

                    if (h == "1")
                    {
                        Console.Clear();
                        equipo.infoplayers();
                        System.Threading.Thread.Sleep(5000);
                    }
                    if (h == "2")
                    {
                        Console.Clear();
                        equipo.infoentrenador();
                        System.Threading.Thread.Sleep(5000);

                    }
                    if (h == "3")
                    {
                        Console.Clear();
                        equipo.infomedico();
                        System.Threading.Thread.Sleep(5000);
                    }
                    if (h == "4")
                    {
                        Console.Clear();
                        Console.WriteLine(equipo.getname());
                        System.Threading.Thread.Sleep(5000);

                    }
                }
            }

        }
    }
}
