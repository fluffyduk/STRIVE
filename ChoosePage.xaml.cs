using STRIVE.Trains.WithInventory;

namespace STRIVE;

public partial class ChoosePage : ContentPage
{
	string typeforchoice = "";

	public ChoosePage()
	{
		InitializeComponent();
	}

	public ChoosePage(TypeOfButton type)
	{
		typeforchoice = type.Type;
		InitializeComponent();
	}

	async void OnImageButtonWithClicked(object sender, EventArgs e)
	{
		switch (typeforchoice)
		{
			case "Ass":
				await Navigation.PushAsync(new AssTrainWith());
				break;
			case "Arms":
				await Navigation.PushAsync(new ArmsTrainWith());
				break;
			case "Yoga":
				await Navigation.PushAsync(new YogaTrainWith());
				break;
			case "Abs":
				await Navigation.PushAsync(new AbsTrainWith());
				break;
			case "Legs":
				await Navigation.PushAsync(new LegsTrainWith());
				break;
			case "Cardio":
				await Navigation.PushAsync(new CardioTrainWith());
				break;
		}
	}
	async void OnImageButtonWithoutClicked(object sender, EventArgs e)
	{
		//switch (typeforchoice)
		//{
		//	case "Ass":
		//		await Navigation.PushAsync();
		//		break;
		//}
	}

	async void OnImageButtonMachClicked(object sender, EventArgs e)
	{
		//switch (typeforchoice)
		//{
		//	case "Ass":
		//		await Navigation.PushAsync();
		//		break;
		//}
	}
}