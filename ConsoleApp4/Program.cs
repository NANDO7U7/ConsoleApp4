using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents;
            Arraylist registro = new Arraylist();
            string nombre;
            int edad;
            int contador = 0;
            Console.WriteLine("Ingrese wl numero de estudiantes ");
            numberStudents = int.Parse(Console.ReadLine());

            while (contador < numberStudents)
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());

                Students students = new Students(){Nombre = nombre, Edad = edad };
                registro.Add(students);

                contador++;
                {
                    foreach (Students st in registro)
                }
                Console.Write(students.getdata());
            }

        }
    }
    public class Students
    {
        private string _nombre;
        private string _edad;

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Edad
        {
            get => _edad;
            set => _edad = value;
        }
        public static getdata()
        {
            return " Nombre: " + _nombre + " edad: " + _edad;
        
             }
         }
    }

