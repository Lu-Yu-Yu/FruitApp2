namespace FruitApp2;

public partial class Page2 : ContentPage
{
	public Page2(string uName)
	{
		InitializeComponent();
        lblUserName.Text =uName;
	}

    //private void TapGestureRecognizer_Tappe(object sender, EventArgs e)
    //{
    //    Navigation.PopModalAsync();
    //}
}