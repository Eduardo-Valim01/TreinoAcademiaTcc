using ProjetoTCC.View;
using ProjetoTCC.Data;
using ProjetoTCC.Model;


namespace ProjetoTCC;

public partial class App : Application
{
    //Injeção de depedencia

    static SQLiteData _bancoDados;
    
    public static SQLiteData BancoDados
    {
        get
        {
            if (_bancoDados == null)
            {
                _bancoDados =
                    new SQLiteData(DependencyService
                    .Get<ISQliteBD>()
                    .SQLiteLocalPath("Dados.db3"));
            }
            return _bancoDados;
        }
    }

    public static Usuario Usuario { get; set; }

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage (new Login());
    }

}

