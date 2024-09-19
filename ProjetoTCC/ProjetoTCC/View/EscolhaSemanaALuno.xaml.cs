namespace ProjetoTCC.View;

public partial class EscolhaSemanaALuno : ContentPage
{
	public EscolhaSemanaALuno()
	{
		InitializeComponent();
	}

    private void btnSegunda_Clicked(object sender, EventArgs e)
    {
         Navigation.PushAsync(new TreinoAluno());
    }

    private void btnTerca_Clicked(object sender, EventArgs e)
    {

    }

    private void btnQuarta_Clicked(object sender, EventArgs e)
    {

    }

    private void btnQuinta_Clicked(object sender, EventArgs e)
    {

    }

    private void btnSexta_Clicked(object sender, EventArgs e)
    {

    }
}