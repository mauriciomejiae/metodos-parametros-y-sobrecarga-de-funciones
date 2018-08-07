using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Metodos, parametros y sobrecarga de funciones

namespace metodos__parametros_y_sobrecarga_de_funciones
{
    class Program
    {
        static void Main(string[] args)
        {

            mimetodo("Juan");
            mimetodo("Jose");
            mimetodo("Juana");
            mimetodo("Jaime");
            mimetodo();
            mimetodo("Carlos", "40", "Ing Sistemas");
            Console.ReadLine();
        }

        static void mimetodo()
        {
            Console.WriteLine("Hola, Anonimo , ¿Como estas?");
        }

        static void mimetodo(string nombre)
        {
            Console.WriteLine("Hola, " + nombre + " , ¿Como estas?");
        }

        static void mimetodo(string nombre, string edad, string carrera)
        {
            Console.WriteLine("Hola, " + nombre + " , ¿Como estas?. Su edad es " + edad + "estudias " + carrera + "");
        }
    }
}

