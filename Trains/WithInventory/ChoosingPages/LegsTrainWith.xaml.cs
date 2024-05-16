using STRIVE.Cards.LegsWith;

namespace STRIVE.Trains.WithInventory;

public partial class LegsTrainWith : ContentPage
{
	public LegsTrainWith()
	{
		InitializeComponent();
	}

	async void OnImageButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BarbellSquat());
	}
}