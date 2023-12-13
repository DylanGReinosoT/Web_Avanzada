using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int opcion;

                do
                {
                    Console.WriteLine("Menú:");
                    Console.WriteLine("1. EJERCICIO 1");
                    Console.WriteLine("2. EJERCICIO 2");
                    Console.WriteLine("3. EJERCICIO 3");
                    Console.WriteLine("4. EJERCICIO 4");
                    Console.WriteLine("5. EJERCICIO 5");
                    Console.WriteLine("0. Salir");
                    Console.Write("Ingrese el número de la opción deseada: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("\n");    
                                Console.WriteLine("Variables y Operadores en C#");
                                int numero1 = 20;
                                int numero2 = 10;
                                int resultado;

                                Console.WriteLine("Suma de numero:");
                                Console.WriteLine("Numero 1:" + numero1);
                                Console.WriteLine("Numero 2:" + numero2);

                                resultado = numero1 + numero2;

                                Console.WriteLine("El resultado de la suma es: " + resultado);
                                Console.WriteLine("Presiona Enter para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                                
                            break;
                            case 2:
                            Console.WriteLine("\n");
                                Console.WriteLine("Estructuras de Control en C#");
                                int edad = 20;

                                Console.WriteLine("Tu edad es de " + edad + " años");

                                if (edad>=18)
                                {
                                Console.WriteLine("Eres mayor de edad");
                                }
                                  else
                                      {
                                           Console.WriteLine("No eres mayor de edad");
                                  }
                                Console.WriteLine("Presiona Enter para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            break;
                            case 3:
                            Console.WriteLine("\n");
                            Console.WriteLine("Programación Orientada a Objetos - Clases y Objetos");
                                Estudiante estudiante1 = new Estudiante("Juan Perez", 20, 15);
           
                       
                                Console.WriteLine("Información del estudiante:");
                                Console.WriteLine("Nombre: " + estudiante1.Nombre);
                                Console.WriteLine("Edad: " + estudiante1.Edad);
                                Console.WriteLine("Calificación: " + estudiante1.Calificacion);

                                Console.WriteLine("Presiona Enter para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            break;
                            case 4:
                            Console.WriteLine("\n");
                            Console.WriteLine(" Programación Orientada a Objetos - Métodos");

                                Estudiante estudiante = new Estudiante("Juan Perez", 20, 15);
                                estudiante.MostrarInformacion();
                                Console.WriteLine("Presiona Enter para continuar...");
                                Console.ReadLine();
                                Console.Clear();

                            break;
                            case 5:
                            Console.WriteLine("\n");
                            Console.WriteLine("Programación Orientada a Objetos - Herencia");

                                EstudianteGraduado graduado1 = new EstudianteGraduado("Juan Perez", 20, 15,"Ingeniero en Telecomunicanes");
                                graduado1.MostrarInformacion();
                            Console.WriteLine("Presiona Enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                            case 0:
                                Console.WriteLine("Saliendo del programa...");
                                Console.ReadLine();
                            break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingresa un número válido.");
                    }

                    Console.WriteLine(); // Salto de línea para separar las iteraciones del menú
                } while (opcion != 0);


        
        }
    }
}
