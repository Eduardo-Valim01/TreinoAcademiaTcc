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

    private void btnConfirmar_Clicked(object sender, EventArgs e)
    {
        
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


