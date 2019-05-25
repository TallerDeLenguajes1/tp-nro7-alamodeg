using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    //ENUMERACIONES
    public enum Cargo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador };
    public enum EstadoCivil { Soltero, Casado };
    public enum Genero { Masculino, Femenino };
   
    //CLASE Y CONSTRUCTOR EMPLEADO//
    public class Empleado
    {
        public string Nombre;
        public string Apellido;
        public DateTime FechaNacimiento;
        public DateTime FechaIngreso;
        public Cargo cargo;
        public EstadoCivil estadoCivil;
        public Genero genero;
        public float Sueldo;

        public Empleado(string _nombre, string _apellido, DateTime _fechaNacimiento, DateTime _fechaIngreso, float _sueldo, Cargo _cargo, EstadoCivil _estadoCivil, Genero _genero)
        {
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.FechaNacimiento = _fechaNacimiento;
            this.FechaIngreso = _fechaIngreso;
            this.Sueldo = _sueldo;
            this.cargo = _cargo;
            this.FechaNacimiento = _fechaNacimiento;
            this.FechaIngreso = _fechaIngreso;
        }
    }
}
