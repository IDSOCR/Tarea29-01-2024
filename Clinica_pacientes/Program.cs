using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_pacientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamano = 2;
            String[] nombre = new String[tamano];
            int[] edad = new int[tamano];
            string[] cita = new string[tamano];
            int opcion = 0;

            menu();

            void inicializar()

            {
                nombre = Enumerable.Repeat("", tamano).ToArray<string>();
                cita = Enumerable.Repeat("", tamano).ToArray<string>();
                edad = Enumerable.Repeat(0, tamano).ToArray<int>();



                Console.WriteLine("Los arreglos han sido iniciados");
                Console.ReadKey();
                Console.Clear();
            }

            void Agregar()

            {
                
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < tamano; i++)
                {
                    Console.WriteLine("Ingrese el nombre:"); nombre[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad:"); edad[i] = int.Parse(Console.ReadLine());
                }



            }

            void Reporte()

            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("     Nombre                 Edad             Próxima Cita");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("--------------             -----             -----");


                for (int i = 0; i < tamano; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{nombre[i]}{edad[i]} {cita[i]}");
                }


            }

            void consulta()
            {
                bool encontrado = false;
                Console.WriteLine("Digite el nombre a buscar");
                string nomb = Console.ReadLine();
                for (int i = 0; i < tamano; i++)
                {
                    if (nomb.Equals(nombre[i]))
                    {
                        Console.WriteLine($"La edad de {nomb} es {edad[i]}");
                        encontrado = true;
                    }

                }

                if (encontrado == false)
                {
                    Console.WriteLine($"El paciente {nomb} no existe");
                }
            }


            void AsignarCitas()
            {
                bool encontrado = false;
                Console.WriteLine("Digite el nombre del paciente para asignar una cita");
                string nomb = Console.ReadLine();
                for (int i = 0; i < tamano; i++)
                {
                    if (nomb.Equals(nombre[i]))
                    {
                        Console.WriteLine("Ingrese la fecha de la próxima cita:"); cita[i] = Console.ReadLine();



                        encontrado = true;
                    }

                }

                if (encontrado == false)
                {
                    Console.WriteLine($"El paciente {nomb} no existe");
                }
            }


            void menu()
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***************** CONSULTORIO MEDICO IDSO *****************");
                    Console.WriteLine(" ");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1- Inicializar arreglos");
                    Console.WriteLine("2- Ingresar paciente");
                    Console.WriteLine("3- Consultar paciente");
                    Console.WriteLine("4- Reporte");
                    Console.WriteLine("5- Asignar citas");
                    Console.WriteLine("6- Salir");
                    Console.WriteLine(" ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite una opcion");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)

                    {
                        case 1: inicializar(); break;
                        case 2: Agregar(); break;
                        case 3: consulta(); break;
                        case 4: Reporte(); break;
                        case 5: AsignarCitas(); break;
                        default:
                            break;

                    }

                } while (opcion != 6);

            }





        }

    }
}