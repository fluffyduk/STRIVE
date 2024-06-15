using STRIVE.Trains.WithInventory.Yoga;

namespace STRIVE.Trains.WithInventory;

public partial class YogaTrainWith : ContentPage
{
	public YogaTrainWith()
	{
		InitializeComponent();
	}

	async void Chair(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ChairPose());
	}

	async void Mountain(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MountainPose());
	}

	async void Star(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new StarPose());
	}

	async void Tree(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TreePose());
	}

	async void Warrior(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new WarriorPose());
	}
}