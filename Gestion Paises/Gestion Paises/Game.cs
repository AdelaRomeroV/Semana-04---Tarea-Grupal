using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Paises
{
    internal class Game
    {
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
                            GetSubdesarrollado();
                            flag = false;
                            break;
                        }
                    case 2:
                        {
                            GetDesarrollo();
                            flag = false;
                            break;
                        }
                    case 3:
                        {
                            GetDesarrollado();
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

        }

        void PassTurn()
        {

        }

        void ChangeTaxes()
        {

        }

        void Reset()
        {

        }
        
        void GetSubdesarrollado()
        {

        }

        void GetDesarrollo()
        {

        }

        void GetDesarrollado()
        {

        }

        void FinDelJuego()
        {

        }
    }
}
