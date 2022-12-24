using static Android.Renderscripts.ScriptGroup;

namespace Maui;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (result.IsEnabled) result.Text += ((Button)sender).Text;
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        if (result.IsEnabled) result.Text = "";
    }

    private void Access_Clicked(object sender, EventArgs e)
    {
        if (result.IsEnabled)
        {
            if (result.Text == "1234")
            {
                result.Text = "ACCESS!";
                result.IsEnabled = false;
            }
            else
            {
                result.Text = "";
            }
        }
    }
}

