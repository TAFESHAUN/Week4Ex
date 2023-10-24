namespace Week4.Pages;
public partial class OtherPage : ContentPage
{
	public OtherPage()
	{
		InitializeComponent();

		//string input = otherPageEntry.Text;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var input = otherPageEntry.Text;

		DisplayAlert("You clicked the button", $"Your input is {input}", "OK");
    }
}