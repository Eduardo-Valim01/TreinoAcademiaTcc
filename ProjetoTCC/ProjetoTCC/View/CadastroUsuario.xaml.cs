using Microsoft.Maui.Controls;
using ProjetoTCC.Model;
using System;

namespace ProjetoTCC.View
{
    public partial class CadastroUsuario : ContentPage
    {
        public CadastroUsuario()
        {
            InitializeComponent();

            // Popula os Pickers com os valores dos enums
            SexoPicker.ItemsSource = Enum.GetValues(typeof(Sexo));
            TipoUsuarioPicker.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            if (!int.TryParse(IDEntry.Text, out var id))
            {
                // Tratar erro de ID inválido
                DisplayAlert("Erro", "ID inválido", "OK");
                return;
            }

            var nome = NomeEntry.Text;
            var sexo = (Sexo)SexoPicker.SelectedItem;
            var dataNasc = DataNascimentoPicker.Date;
            var email = EmailEntry.Text;
            var senha = SenhaEntry.Text;
            var tipoUsuario = (TipoUsuario)TipoUsuarioPicker.SelectedItem;

            var usuario = new Usuario
            {
                Id = id,
                Nome = nome,
                Sexo = sexo,
                DataNasc = dataNasc,
                Email = email,
                Senha = senha,
                TipoUsuario = tipoUsuario
            };

            // Implementar a lógica de cadastro aqui
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Implementar a lógica de cancelamento aqui
            IDEntry.Text = string.Empty;
            NomeEntry.Text = string.Empty;
            SexoPicker.SelectedIndex = -1;
            DataNascimentoPicker.Date = DateTime.Now;
            EmailEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;
            TipoUsuarioPicker.SelectedIndex = -1;
        }
    }
}