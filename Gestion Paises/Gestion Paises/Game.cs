using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paises
{
    internal class Game
    {
        Pais pais;
        public void SelectDifficul()
        {
            bool flag = true;

            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Selecciona el nivel de desarrollo de tu país");
                Console.WriteLine("1. Subdesarrolado");
                Console.WriteLine("2. En Desarrollo");
                Console.WriteLine("3. Desarrollado\n");

                Console.ForegroundColor = ConsoleColor.White;
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        {
                            pais = new SubDesarrollado("SubDesarrollado", 100, 500, 40, 40, 40, 6, 120, 400); 
                            flag = false;
                            break;
                        }
                    case 2:
                        {
                            pais = new PaisDesarrollo("SubDesarrollado", 150, 600, 60, 60, 60, 5, 180, 300);
                            flag = false;
                            break;
                        }
                    case 3:
                        {
                            pais = new Desarrollado("SubDesarrollado", 200, 700, 80, 80, 80, 4, 240, 200);
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion Invalida");
                            break;
                        }
                }
            }

            MenuGame();
        }

        void MenuGame()
        {
            bool flag = true;

            while (flag)
            {
                FinDelJuego();
                Console.WriteLine("Selecciona una opcion:");
                Console.WriteLine("1. Ver las estadisticas del país");
                Console.WriteLine("2. Modificar Impuestos");
                Console.WriteLine("3. Pasar al siguiente turno");

                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        {
                            ViewStats();
                            break;
                        }
                    case 2:
                        {
                            ChangeTaxes();
                            break;
                        }
                    case 3:
                        {
                            PassTurn();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion invalida");
                            break;
                        }
                }
            }
        }
        
        void ViewStats()
        {
            Console.WriteLine($"Población: {pais.poblacion}");
            Console.WriteLine($"Impuestos: {pais.impuestos}");
            Console.WriteLine($"Dinero: {pais.dinero}");
            Console.WriteLine($"Gastos de Salud: {pais.salud}");
            Console.WriteLine($"Gastos de Educación: {pais.educacion}");
            Console.WriteLine($"Gastos deSeguridad: {pais.seguridad}");
            Console.WriteLine($"Felicidad: {pais.felicidad}");
            Console.WriteLine($"Gastos Total: {pais.gastos}");
        }

        void PassTurn()
        {
            pais.Healt(0);
            pais.Education(0);
            pais.Security(0);
            pais.CalculateFactor();
        }

        void ChangeTaxes()
        {
            if (pais is SubDesarrollado)
            {
                GetSubDesarrollado();
            }
            else if (pais is PaisDesarrollo)
            {
                GetDesarrollo();
            }
            else if (pais is Desarrollado)
            {
                GetDesarrollado();
            }
            pais.CalculateFactor();
        }

        void Reset()
        {
            pais = null;
            SelectDifficul();
        }

        private SubDesarrollado GetSubDesarrollado()
        {
            Console.WriteLine($"Ingresa los nuevos impuestos, impuestos actual {pais.impuestos}");
            pais.impuestos = float.Parse(Console.ReadLine());
            Console.WriteLine($"Introduce el gasto para la Salud, gasto actual {pais.salud}");
            float gastoSalud = float.Parse(Console.ReadLine());
            pais.Healt(gastoSalud);
            Console.WriteLine($"Introduce el gasto para la Educacion, gasto actual {pais.educacion}");
            float gastoEducacion = float.Parse(Console.ReadLine());
            pais.Education(gastoEducacion);
            Console.WriteLine($"Introduce el gasto para la Seguridad, gasto actual {pais.seguridad}");
            float gastoSeguridad = float.Parse(Console.ReadLine());
            pais.Security(gastoSeguridad);
            return new SubDesarrollado("SubDesarrollado", pais.poblacion, pais.dinero, gastoSalud, gastoEducacion, gastoSeguridad, pais.felicidad, pais.gastos, pais.impuestos);
        }

        private PaisDesarrollo GetDesarrollo()
        {
            Console.WriteLine($"Ingresa los nuevos impuestos, impuestos actual {pais.impuestos}");
            pais.impuestos = float.Parse(Console.ReadLine());
            Console.WriteLine($"Introduce el gasto para la Salud, gasto actual {pais.salud}");
            float gastoSalud = float.Parse(Console.ReadLine());
            pais.Healt(gastoSalud);
            Console.WriteLine($"Introduce el gasto para la Educacion, gasto actual {pais.educacion}");
            float gastoEducacion = float.Parse(Console.ReadLine());
            pais.Education(gastoEducacion);
            Console.WriteLine($"Introduce el gasto para la Seguridad, gasto actual {pais.seguridad}");
            float gastoSeguridad = float.Parse(Console.ReadLine());
            pais.Security(gastoSeguridad);
            return new PaisDesarrollo("Desarrollo", pais.poblacion, pais.dinero, gastoSalud, gastoEducacion, gastoSeguridad, pais.felicidad, pais.gastos, pais.impuestos);
        }

        private Desarrollado GetDesarrollado()
        {
            Console.WriteLine($"Ingresa los nuevos impuestos, impuestos actual {pais.impuestos}");
            pais.impuestos = float.Parse(Console.ReadLine());
            Console.WriteLine($"Introduce el gasto para la Salud, gasto actual {pais.salud}");
            float gastoSalud = float.Parse(Console.ReadLine());
            pais.Healt(gastoSalud);
            Console.WriteLine($"Introduce el gasto para la Educacion, gasto actual {pais.educacion}");
            float gastoEducacion = float.Parse(Console.ReadLine());
            pais.Education(gastoEducacion);
            Console.WriteLine($"Introduce el gasto para la Seguridad, gasto actual {pais.seguridad}");
            float gastoSeguridad = float.Parse(Console.ReadLine());
            pais.Security(gastoSeguridad);
            return new Desarrollado("Desarrollado", pais.poblacion, pais.dinero, gastoSalud, gastoEducacion, gastoSeguridad, pais.felicidad, pais.gastos, pais.impuestos);
        }

        void FinDelJuego()
        {
            if (pais.felicidad <= 0 || pais.dinero < 0)
            {
                Console.WriteLine("¡Has perdido el juego!");
                Console.WriteLine("¿Deseas reiniciar o salir? (reiniciar/salir)");
                string respuesta = Console.ReadLine().ToLower();

                switch (respuesta)
                {
                    case "reiniciar":
                        Console.WriteLine("Reiniciando el juego...");
                        Reset();
                        break;
                    case "salir":
                        Console.WriteLine("Saliendo del juego...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Respuesta no válida.");
                        break;
                }
            }
            else if (pais.felicidad >= 10)
            {
                Console.WriteLine("¡Has Ganado el juego!");
                Console.WriteLine("¿Deseas reiniciar o salir? (reiniciar/salir)");
                string respuesta = Console.ReadLine().ToLower();

                switch (respuesta)
                {
                    case "reiniciar":
                        Console.WriteLine("Reiniciando el juego...");
                        Reset();
                        break;
                    case "salir":
                        Console.WriteLine("Saliendo del juego...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Respuesta no válida.");
                        break;
                }
            }
        }
    }
}
