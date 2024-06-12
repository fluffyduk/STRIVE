using STRIVE.Trains.WithInventory.Arms;

namespace STRIVE;

public partial class ArmsTrainWith : ContentPage
{
	public ArmsTrainWith()
	{
		InitializeComponent();
	}

	async void DumbbellsDiv(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new dumbbellsdividing());
	}
	async void UpperPress(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new UpperPress());
	}
	async void BicepsOnKnee(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BicepsOnKnee());
	}
	async void TricepsStretch(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TricepsStretching());
	}

}