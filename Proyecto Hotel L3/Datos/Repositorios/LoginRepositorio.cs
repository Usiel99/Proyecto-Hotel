using Dapper;
using Datos.Interfaces;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private string CadenaConexion;

        public LoginRepositorio(string _CadenaConexion)
        {
            CadenaConexion = _CadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
        public async Task<bool> ValidarUsuario(Login login)
        {
            bool valido = false;
            try
            {
                using MySqlConnection _Conexion = Conexion();
                await _Conexion.OpenAsync();
                string sql = "SELECT 1 From usuario WHERE CodigoUsuario = @CodigoUsuario AND Contrasena = @Contrasena;";
                valido = await _Conexion.ExecuteScalarAsync<bool>(sql, login);
            }
            catch (Exception)
            {  
            }
            return valido;
        }
    }
}
