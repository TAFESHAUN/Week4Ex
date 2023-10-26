namespace Week4.Controls;

public partial class Form : ContentView
{
	public Form()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var input = otherPageEntry.Text;
        App.Current.MainPage.DisplayAlert("You clicked the button", $"Your input is {input}", "OK");
    }
}