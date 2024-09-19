using Microsoft.Maui.Controls;

namespace ProjetoTCC.View
{
    public partial class IncluirTreino : ContentPage
    {
        public event Action<Treino> TreinoAdicionado;

        public IncluirTreino()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            var treino = new Treino
            {
                FotoAparelho = FotoAparelhoEntry.Text,
                NumeroSeries = NumeroSeriesEntry.Text,
                Repeticoes = RepeticoesEntry.Text
            };

            TreinoAdicionado?.Invoke(treino);
            await Navigation.PopAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

    public class Treino
    {
        public string FotoAparelho { get; set; }
        public string NumeroSeries { get; set; }
        public string Repeticoes { get; set; }
    }
}