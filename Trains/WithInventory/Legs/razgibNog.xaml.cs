namespace STRIVE.Trains.WithInventory.Legs;

public partial class razgibNog : ContentPage
{
	public razgibNog()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("Примечание", "Вес нужно выставлять таким образом, чтобы можно было выполнить 3-4 подхода по 15-18 раз. Слишком большой вес не даст полностью выпрямить ногу, из-за неполной амплитуды эффективность упражнения снизится.", "OK");
	}
}