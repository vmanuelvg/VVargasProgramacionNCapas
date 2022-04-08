using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 1;
            while (opc != 0)
            {
                Console.WriteLine("------!!!Elije una opcion¡¡¡------" +
                    "\n1.- Agregar Usuario" +
                    "\n2.- Agregar Aseguradora");

                opc=int.Parse(Console.ReadLine());
                if(opc == 1)
                {
                    Console.WriteLine("------!!!Que desea hacer¡¡¡------" +
                    "\n0.- Salir" +
                    "\n1.- Insertar" +
                    "\n2.- Actualizar" +
                    "\n3.- Eliminar" +
                    "\n4.- Mostrar");
                    opc = int.Parse(Console.ReadLine());
                    ML.Usuario usuario = new ML.Usuario();
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("Adios");
                            break;
                        case 1:
                            PL.Usuario.Add(usuario);
                            Console.ReadKey();
                            break;
                        case 2:
                            PL.Usuario.Update(usuario);
                            break;
                        case 3:
                            PL.Usuario.Delete(usuario);
                            break;
                        case 4:
                            PL.Usuario.Mostrar();
                            break;
                        default:
                            Console.WriteLine("Elige otra opcion\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("------!!!Que desea hacer¡¡¡------" +
                    "\n0.- Salir" +
                    "\n1.- Insertar" +
                    "\n2.- Actualizar" +
                    "\n3.- Eliminar" +
                    "\n4.- Mostrar");
                    opc = int.Parse(Console.ReadLine());
                    ML.Aseguradora aseguradora = new ML.Aseguradora();
                    switch (opc)
                    {
                        case 0:
                            Console.WriteLine("Adios");
                            break;
                        case 1:
                            PL.Aseguradora.Add(aseguradora);
                            Console.ReadKey();
                            break;
                        case 2:
                            PL.Aseguradora.Update(aseguradora);
                            break;
                        case 3:
                            PL.Aseguradora.Delete(aseguradora);
                            break;
                        case 4:
                            PL.Aseguradora.Mostrar();
                            break;
                        default:
                            Console.WriteLine("Elige otra opcion\n");
                            break;
                    }
                }

                
            }
        }
    }
}