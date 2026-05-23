using MauiAppHotell.Models;

namespace MauiAppHotell


{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>

        {
            new Quarto()

            { 
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.00,
            },

             new Quarto()

             {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 95.00,
                ValorDiariaCrianca = 40.00,
            },

             new Quarto()

            {
                Descricao = "Suíte Standard",
                ValorDiariaAdulto = 60.00,
                ValorDiariaCrianca = 30.00,
            },

             new Quarto()

            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 65.00,
                ValorDiariaCrianca = 20.00,
            },
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
            MainPage = new AppShell();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}