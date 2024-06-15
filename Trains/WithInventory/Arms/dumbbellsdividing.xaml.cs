namespace STRIVE.Trains.WithInventory.Arms;

public partial class dumbbellsdividing : ContentPage
{
	public dumbbellsdividing()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("Примечание", "Не поднимайте вес за счёт рук!\r\nОсновное движение в упражнении необходимо выполнять за счёт мышц груди — руки лишь поддерживают вес. Не выгибайте спину. Держите локти слегка согнутыми.\r\n", "OK");
	}
}