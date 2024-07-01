namespace EvaluacionRengifo.Views;


public partial class VentanaMain : ContentPage
{
	public VentanaMain()
	{
		InitializeComponent();
	}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await joke.RelRotateTo(360, 1000);
        }
    }