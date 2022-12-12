using static Android.Graphics.ImageDecoder;

namespace GaloEstrellaPruebaP2;


public partial class GERecarga : ContentPage
{
	public GERecarga()
	{
		InitializeComponent();
        var SeleccioneOperador = new List<string>();
        SeleccioneOperador.Add("Claro");
        SeleccioneOperador.Add("Movistar");
        SeleccioneOperador.Add("Tuenti");
        SeleccioneOperador.Add("Maxiplus");


        Picker picker = new Picker { Title = "Seleccione operador " };
        picker.ItemsSource = SeleccioneOperador;
    }

	private void LearnMore_Clicked(object sender, EventArgs e)
	{

	}
}