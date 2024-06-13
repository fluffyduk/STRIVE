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
		height = await DisplayPromptAsync("������� ���� ����", "����:", "�����������", "��������");
		Preferences.Set("height", height);
		heightVisual.Text = height;
	}

	async void WeightClick(object sender, EventArgs args)
	{
		weight = await DisplayPromptAsync("������� ���� ���", "���:", "�����������", "��������");
		Preferences.Set("weight", weight);
		weightVisual.Text = weight;
	}

	async void WishClick(object sender, EventArgs args)
	{
		wishWeight = await DisplayPromptAsync("������� ���� �������� ���", "�������� ���:", "�����������", "��������");
		Preferences.Set("wishWeight", wishWeight);
		wishWeightVisual.Text = wishWeight;
	}
}