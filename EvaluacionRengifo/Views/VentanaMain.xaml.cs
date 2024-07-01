namespace EvaluacionRengifo.Views;


public partial class VentanaMain : ContentPage
{
	public VentanaMain()
	{
		InitializeComponent();
        Consumidor cons = new Consumidor();

    }
    

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await joke.RelRotateTo(360, 1000);
        }


    public void showJoke(Label _chiste, Button _action)
    {

        this.joke.Text="teste";

    }
}