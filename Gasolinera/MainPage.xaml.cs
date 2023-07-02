namespace Gasolinera;
///<Summary>
///<Createddate>1/07/2023</Createddate>
///<company>INDEL</company>
///<lastmodificationdate>1/07/2023</lastmodificationdate>
///<lastmodifierautor>Erika Chávez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// Al dar clic nos dara el preio al cobrar convirtiendo los galones a litros
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(Galones.Text))
		{
			double galon, litro;

			galon = Convert.ToDouble(Galones.Text);

			litro = galon * 3.78 / 1;
			precio.Text = litro.ToString("n2");
		} 
		else
		{
			DisplayAlert("ERROR", "Introduzca el dato requerido", "Ok");
		}
    }
}

