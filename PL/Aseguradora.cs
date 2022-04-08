using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void Add(ML.Aseguradora aseguradora)
        {

            Console.WriteLine("\nIngrese el nombre");
            aseguradora.Nombre = Console.ReadLine();

            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("Id de usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());


            ML.Result result = BL.Aseguradora.AddSP(aseguradora);
            if (result.Correct)
            {
                Console.WriteLine("\nSe ha registrado la aseguradora\n");
            }
            else
            {
                Console.WriteLine("\nNo se ha podido registrar la aseguradora" + result.ErrorMessage);
            }

        }

        public static void Update(ML.Aseguradora aseguradora)
        {
            Console.WriteLine("\nIngresa el Id del aseguradora que deseas actualizar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre");
            aseguradora.Nombre = Console.ReadLine();

            aseguradora.Usuario = new ML.Usuario();
            Console.WriteLine("Id de usuario");
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result1 = BL.Aseguradora.UpdateSP(aseguradora);
            if (result1.Correct)
            {
                Console.WriteLine("\nSe ha actualiza la aseguradora\n");
            }
            else
            {
                Console.WriteLine("\nNo se ha actualizado la aseguradora " + result1.ErrorMessage + "\n");
            }
        }

        public static void Delete(ML.Aseguradora aseguradora)
        {
            Console.WriteLine("\nQue aseguradora deseas eliminar");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            ML.Result result2 = BL.Aseguradora.DeleteSP(aseguradora);
            if (result2.Correct)
            {
                Console.WriteLine("Se ha borrado la aseguradora\n");
            }
            else
            {
                Console.WriteLine("No se ha borrado la aseguradora" + result2.ErrorMessage);
            }

        }

        public static void Mostrar()
        {
            Console.WriteLine("\nQue metodo deseas utilizar" +
                "\n1.- Get All" +
                "\n2.- Get By Id");
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (opc == 1)
            {
                ML.Result result = BL.Aseguradora.GetAllSP();
                if (result.Correct)
                {
                    foreach (ML.Aseguradora aseguradora in result.Objects)
                    {
                        Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                        Console.WriteLine("Nombre: " + aseguradora.Nombre);
                        Console.WriteLine("Fecha de creacion: " + aseguradora.FechaCreacion);
                        Console.WriteLine("Fecha de modificacion: " + aseguradora.FechaModificacion);
                        Console.WriteLine("Id Usuario: " + aseguradora.Usuario.IdUsuario);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al realizar la consulta " + result.ErrorMessage);
                }
            }
            else if (opc == 2)
            {
                Console.WriteLine("Ingrese el Id de la aseguradora a consultar");
                ML.Result result = BL.Aseguradora.GetByIdSP(int.Parse(Console.ReadLine()));

                ML.Aseguradora aseguradora = ((ML.Aseguradora)result.Object);

                Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                Console.WriteLine("Nombre: " + aseguradora.Nombre);
                Console.WriteLine("Fecha de creacion: " + aseguradora.FechaCreacion);
                Console.WriteLine("Fecha de modificacion: " + aseguradora.FechaModificacion);
                Console.WriteLine("Rol: " + aseguradora.Usuario.IdUsuario);
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nError\n");
            }

        }
    }
}
