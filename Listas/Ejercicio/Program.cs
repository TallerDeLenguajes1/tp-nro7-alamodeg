using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> ListaEmpleados = new List<Empleado>();
            string aux_nombre;
            string aux_apellido;
            DateTime aux_fechaNacimiento;
            DateTime aux_fechaIngreso;
            Cargo aux_cargo;
            EstadoCivil aux_estadoCivil;
            Genero aux_genero;
            float aux_sueldo;


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ingrese nombre");
                aux_nombre = Console.ReadLine();
                Empleado Empleado1 = new Empleado(aux_nombre,);
                ListaEmpleados.Add(Empleado1);
            }

           /*Console.Write("escriba apellido ");
            Empleado1.Apellido = Console.ReadLine();
            Console.Write(Empleado1.Apellido);

            Console.ReadKey();*/
            }
    }
}

