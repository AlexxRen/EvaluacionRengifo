using EvaluacionRengifo.Views;

namespace EvaluacionRengifo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VentanaMain ();
        }
    }
}
