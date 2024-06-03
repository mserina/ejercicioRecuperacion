using EduRecuperacionC.Controladores;
using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{

    /// <summary>
    /// Clase que implementa la operativa interfaz
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAlta()
        {

            string respuesta;
            do
            {
                AlumnoDto alumno = new AlumnoDto();

                alumno.IdAlumno = generarId();
                Console.WriteLine("Introduzca su nombre");
                alumno.NombreAlumno = Console.ReadLine();
                Console.WriteLine("Introduzca su primer apellido");
                alumno.Apellido1Alumno = Console.ReadLine();
                Console.WriteLine("Introduzca su segundo apellido");
                alumno.Apellido2Alumno = Console.ReadLine();
                Console.WriteLine("Introduzca su DNI");
                alumno.DNI1 = Console.ReadLine();
                Console.WriteLine("Introduzca su direccion");
                alumno.Direccion = Console.ReadLine();
                Console.WriteLine("Introduzca su telefono");
                alumno.Telefono = Console.ReadLine();
                Console.WriteLine("Introduzca su email");
                alumno.Email = Console.ReadLine();

                Program.listaAlumnos.Add(alumno);

                Console.WriteLine("¿Quieres agregar un nuevo alumno?: s/n");
                respuesta = Console.ReadLine();

            } while (respuesta.Equals("s"));



        }


        public void borrarAlumno()
        {

            Console.WriteLine("Introduzca el dni del alumno a borrar");
            string dniABorrar = Console.ReadLine();
            bool borrar = false;
            string respuesta;

            do
            {
                AlumnoDto aux = new AlumnoDto();
                foreach (AlumnoDto alumno in Program.listaAlumnos)
                {
                    if (dniABorrar.Equals(alumno.DNI1))
                    {
                        aux = alumno;
                        borrar = true;
                        break;
                    }


                }
                if (borrar == true)
                {
                    Program.listaAlumnos.Remove(aux);
                }
                else
                {
                    Console.WriteLine("El DNI introducido no corresponde con ninguno");

                }

                Console.WriteLine("¿Quieres seguir borrando otro alumno?: s/n ");
                respuesta = Console.ReadLine();

            } while (respuesta.Equals("s"));


        }

        public void mostrarAlumnos()
        {
            foreach (AlumnoDto alumno in Program.listaAlumnos)
            {

                Console.WriteLine(alumno.ToString());

            }
        }




        /// <summary>
        /// metodo que se encarga de autogenerar un id
        /// </summary>
        /// <returns></returns>
        private long generarId()
        {
            long nuevoId;
            int tamanioLista = Program.listaAlumnos.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaAlumnos[tamanioLista - 1].IdAlumno + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}
