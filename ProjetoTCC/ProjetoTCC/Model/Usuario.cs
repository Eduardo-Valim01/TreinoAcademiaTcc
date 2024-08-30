using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTCC.Model
{
    public enum Sexo
    {
        Masculino,
        Feminino,
        Outro
    }

    public enum TipoUsuario
    {
        Aluno,
        Professor
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}