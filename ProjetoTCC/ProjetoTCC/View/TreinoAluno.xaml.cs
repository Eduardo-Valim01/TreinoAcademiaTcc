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
                new Treino { FotoAparelho = "peito2.jpg", NumeroSeries = "3 séries", Repeticoes = "15 repetições" },
                new Treino { FotoAparelho = "peito.jpg", NumeroSeries = "4 séries", Repeticoes = "10 repetições" },
                new Treino { FotoAparelho = "peito3.jpg", NumeroSeries = "4 séries", Repeticoes = "10 repetições" },
                //new Treino { FotoAparelho = "peito.jpg", NumeroSeries = "4 séries", Repeticoes = "10 repetições" }

            };

            TreinosCollectionView.ItemsSource = treinos;

            // Configurar o botão para adicionar treino
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