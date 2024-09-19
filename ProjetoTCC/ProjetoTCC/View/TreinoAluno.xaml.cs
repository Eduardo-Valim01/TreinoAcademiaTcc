using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ProjetoTCC.View
{
    public partial class TreinoAluno : ContentPage
    {
        private ObservableCollection<Treino> treinos;

        public TreinoAluno()
        {
            InitializeComponent();

            treinos = new ObservableCollection<Treino>
            {
                // Dados de exemplo
                new Treino { FotoAparelho = "peito2.jpg", NumeroSeries = "3 s�ries", Repeticoes = "15 repeti��es" },
                new Treino { FotoAparelho = "peito.jpg", NumeroSeries = "4 s�ries", Repeticoes = "10 repeti��es" },
                new Treino { FotoAparelho = "peito3.jpg", NumeroSeries = "4 s�ries", Repeticoes = "10 repeti��es" },
                //new Treino { FotoAparelho = "peito.jpg", NumeroSeries = "4 s�ries", Repeticoes = "10 repeti��es" }

            };

            TreinosCollectionView.ItemsSource = treinos;

            // Configurar o bot�o para adicionar treino
            AddTreinoButton.Clicked += async (s, e) =>
            {
                var incluirTreinoPage = new IncluirTreino();
                incluirTreinoPage.TreinoAdicionado += treino =>
                {
                    treinos.Add(treino);
                };
                await Navigation.PushAsync(incluirTreinoPage);
            };
        }
    }
}