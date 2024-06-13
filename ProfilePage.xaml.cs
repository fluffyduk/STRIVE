using STRIVE.Profile;
using System.Diagnostics;

namespace STRIVE;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

	async void InfoClick(object sender, EventArgs args)
	{
		await Navigation.PushAsync(new UserInfoPage());
	}
	async void SettingsClick(object sender, EventArgs args)
	{
		await Navigation.PushAsync(new SettingsPage());
	}
	async void AboutClick(object sender, EventArgs args)
	{
		await Navigation.PushAsync(new AboutPage());
	}
}