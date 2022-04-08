using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ML;
namespace BL
{
    public class Usuario
    {
        public static ML.Result AddSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioAdd";

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter[] collection = new SqlParameter[12];

                    collection[0] = new SqlParameter("@UserName", SqlDbType.VarChar);
                    collection[0].Value = usuario.UserName;

                    collection[1] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[1].Value = usuario.Nombre;

                    collection[2] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[2].Value = usuario.ApellidoPaterno;

                    collection[3] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    collection[3].Value = usuario.ApellidoMaterno;

                    collection[4] = new SqlParameter("@Email", SqlDbType.VarChar);
                    collection[4].Value = usuario.Email;

                    collection[5] = new SqlParameter("@Sexo", SqlDbType.Char);
                    collection[5].Value = usuario.Sexo;

                    collection[6] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                    collection[6].Value = usuario.Telefono;

                    collection[7] = new SqlParameter("@Celular", SqlDbType.VarChar);
                    collection[7].Value = usuario.Celular;

                    collection[8] = new SqlParameter("@FechaNacimiento", SqlDbType.VarChar);
                    collection[8].Value = usuario.FechaNacimiento;

                    collection[9] = new SqlParameter("@Password", SqlDbType.VarChar);
                    collection[9].Value = usuario.Password;

                    collection[10] = new SqlParameter("@Curp", SqlDbType.VarChar);
                    collection[10].Value = usuario.CURP;

                    collection[11] = new SqlParameter("@IdRol", SqlDbType.Int);
                    collection[11].Value = usuario.Rol.IdRol;


                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result UpdateSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioUpdate";

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter[] collection = new SqlParameter[13];

                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;

                    collection[1] = new SqlParameter("@UserName", SqlDbType.VarChar);
                    collection[1].Value = usuario.UserName;

                    collection[2] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[2].Value = usuario.Nombre;

                    collection[3] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[3].Value = usuario.ApellidoPaterno;

                    collection[4] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
                    collection[4].Value = usuario.ApellidoMaterno;

                    collection[5] = new SqlParameter("@Email", SqlDbType.VarChar);
                    collection[5].Value = usuario.Email;

                    collection[6] = new SqlParameter("@Sexo", SqlDbType.Char);
                    collection[6].Value = usuario.Sexo;

                    collection[7] = new SqlParameter("@Telefono", SqlDbType.VarChar);
                    collection[7].Value = usuario.Telefono;

                    collection[8] = new SqlParameter("@Celular", SqlDbType.VarChar);
                    collection[8].Value = usuario.Celular;

                    collection[9] = new SqlParameter("@FechaNacimiento", SqlDbType.VarChar);
                    collection[9].Value = usuario.FechaNacimiento;

                    collection[10] = new SqlParameter("@Password", SqlDbType.VarChar);
                    collection[10].Value = usuario.Password;

                    collection[11] = new SqlParameter("@Curp", SqlDbType.VarChar);
                    collection[11].Value = usuario.CURP;

                    collection[12] = new SqlParameter("@IdRol", SqlDbType.Int);
                    collection[12].Value = usuario.Rol.IdRol;

                    cmd.Parameters.AddRange(collection);

                    cmd.Connection.Open();

                    int RowsAffected = cmd.ExecuteNonQuery();

                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result DeleteSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioDelete";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = context;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter[] collection = new SqlParameter[1];
                    collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                    collection[0].Value = usuario.IdUsuario;
                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }

            return result;
        }

        public static ML.Result Get()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "SELECT * FROM [Usuario]";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;

                        DataTable tableUsuario = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.UserName = row[1].ToString();
                                usuario.Nombre = row[2].ToString();
                                usuario.ApellidoPaterno = row[3].ToString();
                                usuario.ApellidoMaterno = row[4].ToString();
                                usuario.Email = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento = row[9].ToString();
                                usuario.Password = row[10].ToString();
                                usuario.CURP = row[11].ToString();
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = int.Parse(row[12].ToString());

                                result.Objects.Add(usuario);

                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllSP()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioGetAll";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable tableUsuario = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.UserName = row[1].ToString();
                                usuario.Nombre = row[2].ToString();
                                usuario.ApellidoPaterno = row[3].ToString();
                                usuario.ApellidoMaterno = row[4].ToString();
                                usuario.Email = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento = row[9].ToString();
                                usuario.Password = row[10].ToString();
                                usuario.CURP = row[11].ToString();
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = int.Parse(row[12].ToString());

                                result.Objects.Add(usuario);

                            }
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdSP(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnection()))
                {
                    string query = "UsuarioGetById";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
                        collection[0].Value = IdUsuario;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        DataTable tablaUsuario = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        da.Fill(tablaUsuario);

                        if (tablaUsuario.Rows.Count > 0)
                        {
                            DataRow row = tablaUsuario.Rows[0];

                            ML.Usuario usuario = new ML.Usuario();
                            usuario.IdUsuario = int.Parse(row[0].ToString());
                            usuario.UserName = row[1].ToString();
                            usuario.Nombre = row[2].ToString();
                            usuario.ApellidoPaterno = row[3].ToString();
                            usuario.ApellidoMaterno = row[4].ToString();
                            usuario.Email = row[5].ToString();
                            usuario.Sexo = row[6].ToString();
                            usuario.Telefono = row[7].ToString();
                            usuario.Celular = row[8].ToString();
                            usuario.FechaNacimiento = row[9].ToString();
                            usuario.Password = row[10].ToString();
                            usuario.CURP = row[11].ToString();
                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = int.Parse(row[12].ToString());

                            result.Object = usuario;
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

    }

}