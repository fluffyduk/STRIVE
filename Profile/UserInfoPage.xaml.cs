using System.Diagnostics;
using System.Windows.Input;

namespace STRIVE.Profile;

public partial class UserInfoPage : ContentPage
{
	string height = "SEX";
	string weight;
	string wishWeight;

	public UserInfoPage()
	{
		InitializeComponent();
	}

	async void HeightClick(object sender, EventArgs args)
	{
		height = await DisplayPromptAsync("Введите свой рост", "Рост:", "Подтвердить", "Отменить");
		Preferences.Set("height", height);
		heightVisual.Text = height;
	}

	async void WeightClick(object sender, EventArgs args)
	{
		weight = await DisplayPromptAsync("Введите свой вес", "Вес:", "Подтвердить", "Отменить");
		Preferences.Set("weight", weight);
		weightVisual.Text = weight;
	}

	async void WishClick(object sender, EventArgs args)
	{
		wishWeight = await DisplayPromptAsync("Введите свой желаемый вес", "Желаемый вес:", "Подтвердить", "Отменить");
		Preferences.Set("wishWeight", wishWeight);
		wishWeightVisual.Text = wishWeight;
	}
}