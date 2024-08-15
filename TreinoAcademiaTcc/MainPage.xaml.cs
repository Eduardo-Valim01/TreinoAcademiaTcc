namespace TreinoAcademiaTcc
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLabelClicked(object sender, EventArgs e)
        {
           try
            {


            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

        }
    }

}
