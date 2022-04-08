using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{

    public class Usuario
    {
        public static void Add(ML.Usuario usuario)
        {
            Console.WriteLine("\nIngrese el nombre del usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese su Email");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese su Sexo H/M");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el Telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el numero celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento AAAA/MM/DD");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();

            usuario.Rol = new ML.Rol();
            Console.WriteLine("Numero de Rol");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.AddSP(usuario);
            if (result.Correct)
            {
                Console.WriteLine("\nSe ha registrado el usuario\n");
            }
            else
            {
                Console.WriteLine("\nNo se ha podido registrar el usuario" + result.ErrorMessage);
            }

        }

        public static void Update(ML.Usuario usuario)
        {
            Console.WriteLine("\nIngresa el Id del usuario que deseas actualizar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el nombre del usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingrese su Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingrese su Email");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingrese su Sexo H/M");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese el Telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el numero celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento AAAA/MM/DD");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Password");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("CURP");
            usuario.CURP = Console.ReadLine();

            usuario.Rol = new ML.Rol();
            Console.WriteLine("Numero de Rol");
            usuario.Rol.IdRol = int.Parse(Console.ReadLine());


            ML.Result result = BL.Usuario.UpdateSP(usuario);
            if (result.Correct)
            {
                Console.WriteLine("\nSe ha actualiza el usuario\n");
            }
            else
            {
                Console.WriteLine("\nNo se ha actualizado el usuario " + result.ErrorMessage + "\n");
            }
        }

        public static void Delete(ML.Usuario usuario)
        {
                Console.WriteLine("\nQue usuario deseas eliminar");
                usuario.IdUsuario = int.Parse(Console.ReadLine());

                ML.Result result = BL.Usuario.DeleteSP(usuario);
                if (result.Correct)
                {
                    Console.WriteLine("Se ha borrado el usuario\n");
                }
                else
                {
                    Console.WriteLine("No se ha borrado el usuario" + result.ErrorMessage);
                }
             
        }

        public static void Mostrar()
        {
            Console.WriteLine("\nQue metodo deseas utilizar" +
                "\n1.- Get" +
                "\n2.- Get All" +
                "\n3.- Get By Id");
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (opc == 1)
            {
                ML.Result result = BL.Usuario.Get();
                if (result.Correct)
                {
                    foreach (ML.Usuario usuario in result.Objects)
                    {
                        Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                        Console.WriteLine("UserName: " + usuario.UserName);
                        Console.WriteLine("Nombre: " + usuario.Nombre);
                        Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                        Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                        Console.WriteLine("Email: " + usuario.Email);
                        Console.WriteLine("Sexo: " + usuario.Sexo);
                        Console.WriteLine("Telefono: " + usuario.Telefono);
                        Console.WriteLine("Celular: " + usuario.Celular);
                        Console.WriteLine("Fecha Nacimiento: " + usuario.FechaNacimiento);
                        Console.WriteLine("Password: " + usuario.Password);
                        Console.WriteLine("CURP: " + usuario.CURP);
                        Console.WriteLine("Rol: " + usuario.Rol.IdRol);
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
                ML.Result result = BL.Usuario.GetAllSP();
                if (result.Correct)
                {
                    foreach (ML.Usuario usuario in result.Objects)
                    {
                        Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                        Console.WriteLine("UserName: " + usuario.UserName);
                        Console.WriteLine("Nombre: " + usuario.Nombre);
                        Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                        Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                        Console.WriteLine("Email: " + usuario.Email);
                        Console.WriteLine("Sexo: " + usuario.Sexo);
                        Console.WriteLine("Telefono: " + usuario.Telefono);
                        Console.WriteLine("Celular: " + usuario.Celular);
                        Console.WriteLine("Fecha Nacimiento: " + usuario.FechaNacimiento);
                        Console.WriteLine("Password: " + usuario.Password);
                        Console.WriteLine("CURP: " + usuario.CURP);
                        Console.WriteLine("Rol: " + usuario.Rol.IdRol);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ocurrio un error al realizar la consulta " + result.ErrorMessage);
                }
            }
            else if (opc == 3)
            {
                Console.WriteLine("Ingrese el Id de Usuario a consultar");
                ML.Result result = BL.Usuario.GetByIdSP(int.Parse(Console.ReadLine()));

                ML.Usuario usuario = ((ML.Usuario)result.Object);

                Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                Console.WriteLine("UserName: " + usuario.UserName);
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Sexo: " + usuario.Sexo);
                Console.WriteLine("Telefono: " + usuario.Telefono);
                Console.WriteLine("Celular: " + usuario.Celular);
                Console.WriteLine("Fecha Nacimiento: " + usuario.FechaNacimiento);
                Console.WriteLine("Password: " + usuario.Password);
                Console.WriteLine("CURP: " + usuario.CURP);
                Console.WriteLine("Rol: " + usuario.Rol.IdRol);
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