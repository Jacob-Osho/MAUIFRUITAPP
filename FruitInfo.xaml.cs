using FruitApp.Models;

namespace FruitApp;

public partial class FruitInfo : ContentPage
{
    public FruitInfo(FruitModel model)
    {
        InitializeComponent();
        imgFruit.Source = model.ImagePath;
        lblName.Text = model.Name;
        lblFruitSentense.Text = model.Sentense;
    }
    public FruitInfo()
	{
		InitializeComponent();
	}
}