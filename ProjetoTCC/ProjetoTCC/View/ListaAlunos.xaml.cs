using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace ProjetoTCC.View
{
    public partial class ListaAlunos : ContentPage
    {
        // Exemplo de dados de alunos
        public ObservableCollection<Aluno> alunos;

        public ListaAlunos()
        {
            InitializeComponent();

            // Inicializar a lista de alunos (exemplo)
            alunos = new ObservableCollection<Aluno>
            {
                new Aluno { Nome = "João da Silva", Email = "joao.silva@example.com" },
                new Aluno { Nome = "Maria Oliveira", Email = "maria.oliveira@example.com" },
                new Aluno { Nome = "Vitor Marciano", Email = "vitor.oliveira@example.com" },
                new Aluno { Nome = "Eduardo Valim", Email = "eduardo.oliveira@example.com" },
                new Aluno { Nome = "Rafael Reis", Email = "rafael.oliveira@example.com" },
                new Aluno { Nome = "Addryelly Siqueira ", Email = "addryelly.oliveira@example.com" },
                new Aluno { Nome = "Andrey Siqueira", Email = "anfrey.oliveira@example.com" },
                new Aluno { Nome = "Isabela Valim", Email = "isabela.oliveira@example.com" },
                new Aluno { Nome = "José Oliveira", Email = "jose.oliveira@example.com" },
                new Aluno { Nome = "Marcos Oliveira", Email = "marcos.oliveira@example.com" },
                // Adicione mais alunos conforme necessário
            };

            // Definir a fonte de dados para a ListView
            AlunosListView.ItemsSource = alunos;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Filtrar a lista de alunos com base no texto da busca
            var searchText = e.NewTextValue?.ToLower() ?? string.Empty;
            AlunosListView.ItemsSource = string.IsNullOrWhiteSpace(searchText)
                ? alunos
                : alunos.Where(a => a.Nome.ToLower().Contains(searchText)).ToList();
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            // Lógica adicional para quando o botão de pesquisa é pressionado, se necessário
        }

        private void OnAlunoTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null && e.Item is Aluno aluno)
            {
                // Lógica para quando um aluno é selecionado
                DisplayAlert("Aluno Selecionado", $"Nome: {aluno.Nome}\nEmail: {aluno.Email}", "OK");
            }
        }

        private void btnSelecionarAluno_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncluirTreino());
        }
    }

    // Exemplo de modelo de aluno
    public class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
