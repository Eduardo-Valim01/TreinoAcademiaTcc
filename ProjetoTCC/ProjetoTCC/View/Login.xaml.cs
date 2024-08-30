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
}


