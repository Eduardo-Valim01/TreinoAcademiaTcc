using ProjetoTCC.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _conexaoBD;

        public UsuarioData(SQLiteAsyncConnection conexaoBD)
        {
            _conexaoBD = conexaoBD;
        }

        public Task<List<Usuario>> ListaUsuarios()
        {
            var lista = _conexaoBD
                .Table<Usuario>()
                .ToListAsync();
            return lista;
        }

        //public Task<Usuario> ObtemUsuario(string email, string senha) {
     }
}
