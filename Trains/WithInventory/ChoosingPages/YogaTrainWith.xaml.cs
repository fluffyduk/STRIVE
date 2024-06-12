using STRIVE.Cards.LegsWith;
using STRIVE.Trains.WithInventory.Yoga;

namespace STRIVE.Trains.WithInventory;

public partial class YogaTrainWith : ContentPage
{
	public YogaTrainWith()
	{
		InitializeComponent();
	}

    async void TreePose(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TreePose());
    }

    async void ChairPose(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChairPose());
    }

    async void MountainPose(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MountainPose());
    }

    async void StarPose(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StarPose());
    }

    async void WarriorPose(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WarriorPose());
    }
}