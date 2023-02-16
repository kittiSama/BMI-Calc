using System.Drawing;

namespace MauiApp2;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


	private void Button_Clicked(object sender, EventArgs e)
	{
		double val = weight.Value / Math.Pow(height.Value / 100, 2);
        answer.Text = val.ToString();
		if (val < 18.5) answer.BackgroundColor = Colors.LightBlue;
		else if(val < 25) answer.BackgroundColor = Colors.LightGreen;
		else if(val < 30) answer.BackgroundColor = Colors.IndianRed;
        else if (val < 40) answer.BackgroundColor = Colors.Red;
        else answer.BackgroundColor = Colors.DarkRed;

    }
}

