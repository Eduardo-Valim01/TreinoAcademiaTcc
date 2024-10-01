using Microsoft.Maui.Controls;
using ProjetoTCC.Model;
using System;

namespace ProjetoTCC.View
{
    public partial class CadastroUsuario : ContentPage
    {
        Usuario _usuario;

        public CadastroUsuario()
        {
            InitializeComponent();
            _usuario = new Usuario();

            this.BindingContext = _usuario;

            // Popula os Pickers com os valores dos enums
            SexoPicker.ItemsSource = Enum.GetValues(typeof(Sexo));
            TipoUsuarioPicker.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(_usuario.Email) &&
                string.IsNullOrWhiteSpace(_usuario.Senha))
            {
                await DisplayAlert("Atenção", "Prencha todas informações", "Fechar");
                return;
            }

            var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

            if (cadastro > 0)
            {
                await Navigation.PopAsync();
            }
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Implementar a lógica de cancelamento aqui
            
            NomeEntry.Text = string.Empty;
            SexoPicker.SelectedIndex = -1;
            DataNascimentoPicker.Date = DateTime.Now;
            EmailEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;
            TipoUsuarioPicker.SelectedIndex = -1;
        }
    }
}