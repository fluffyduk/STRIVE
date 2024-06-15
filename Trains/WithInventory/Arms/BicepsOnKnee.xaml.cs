namespace STRIVE.Trains.WithInventory.Arms;

public partial class BicepsOnKnee : ContentPage
{
	public BicepsOnKnee()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("Примечание", "Важно не допускать рывков и делать упражнение в медленном темпе. Выполняйте 3-4 подхода по 8–12 повторений. Отдохните между подходами от одной до двух минут. И помните, что мускулы растут во время отдыха, а не при прокачке! Восстановленные мышцы увеличиваются, переутомлённые – нет.", "OK");
	}
	protected async override void OnAppearing()
	{
		base.OnAppearing();
		await Task.Delay(100);
		gif.IsAnimationPlaying = true;
	}

}