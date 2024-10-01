namespace ProjetoTCC.View;

public partial class Login : ContentPage
{


    public Login()
    {
        InitializeComponent();
    }
    private void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CadastroUsuario());
    }

    private async void btnConfirmar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;


        // Verifica se o email e a senha foram preenchidos
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
        {
            await DisplayAlert("Aten��o", "Por favor, preencha todos os campos.", "Fechar");
            return;
        }

        // Obt�m o usu�rio do banco de dados
        var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email, senha);

        // Verifica se o usu�rio existe
        if (usuario == null)
        {
            await DisplayAlert("Aten��o", "Email ou senha inv�lidos", "Fechar");
            return;
        }

        // Verifica o tipo de usu�rio e navega para a tela apropriada
        if (usuario.TipoUsuario == Model.TipoUsuario.Professor)
        {
            // Navega para a tela de inclus�o de treino
            await Navigation.PushAsync(new IncluirTreino());
        }
        else if (usuario.TipoUsuario == Model.TipoUsuario.Aluno)
        {
            // Navega para a tela do aluno (substitua pelo nome da sua tela)
            await Navigation.PushAsync(new EscolhaSemanaALuno());
        }
    }

    private void btnAluno_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EscolhaSemanaALuno());

    }

    private void btnProfessor_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListaAlunos());
       //COMITTTTTTTT

    }
}


