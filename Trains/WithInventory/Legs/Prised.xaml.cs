namespace STRIVE.Trains.WithInventory.Legs;

public partial class Prised : ContentPage
{
	public Prised()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("ѕримечание", "Ќачинайте с легких весов и постепенно наращивайте нагрузку. Ёто поможет достичь прогресса и почувствовать себ€ увереннее и энергичнее.", "OK");
	}
	async void Warning(object sender, EventArgs e)
	{
		DisplayAlert("ѕредупреждение", "Ёто упражнение нежелательно дл€ людей с проблемами опорно-двигательного аппарата или травмами коленных и тазобедренных суставов.", "OK");
	}
}