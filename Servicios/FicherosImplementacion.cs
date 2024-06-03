using EduRecuperacionC.Controladores;
using EduRecuperacionC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EduRecuperacionC.Servicios
{
    /// <summary>
    /// clase de que se encarga de implementar fichero interfaz
    /// </summary>
    internal class FicherosImplementacion : FicherosInterfaz
    {
        public void escribirFichero(string mensaje)
        {
            // poner en null porque debe tener un valor, se declara fuera del try ya que dentro no lo cogeria el finally.
            StreamWriter st = null;

            try
            {
                st = new StreamWriter(Program.rutaFicheroLog, true);
                st.WriteLine(mensaje);


            }
            catch (IOException io)
            {
                Console.WriteLine("Ha ocurrido un error en ficheros, intentelo más tarde. error(1001)" + io.Message);
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }
        }



        public void escribirAlumnos()
        {

            StreamWriter st = null;

            try
            {

                st = new StreamWriter(Program.rutaFicheroAlumno, true);
                foreach (AlumnoDto alumno in Program.listaAlumnos)
                {

                    st.WriteLine(alumno.ToString(';'));


                }
            }
            catch (IOException io)
            {

                // llamar al metodo escribir fichero para escribir en ficheroLog si hay algun error
                escribirFichero("ha ocurrido un error, intentelo más tarde" + io.Message);

                Console.WriteLine("Ha ocurrido un error en ficheros, intentelo más tarde. error(1001)" + io.Message);
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }


        }

        public void cargaIncial()
        {
            string rutaFichero = Program.rutaFicheroAlumno;
            StreamReader sr = new StreamReader(rutaFichero);
            string lineas;
            try
            {

                while((lineas = sr.ReadLine()) != null)
                {
                    string[] campos = lineas.Split(";");

                    AlumnoDto alumno = new AlumnoDto();
                    alumno.DNI1 = campos[0];
                    alumno.NombreAlumno = campos[1];

                    Program.listaAlumnos.Add(alumno);
                }

                
            }
            catch (IOException e)
            {
                escribirFichero("ERROR: " + e.Message);
            } 
        }




    }
}
