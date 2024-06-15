namespace STRIVE.Trains.WithInventory.Arms;

public partial class UpperPress : ContentPage
{
	public UpperPress()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("Примечание", "Не касайтесь в верхней точке гантелями друг друга, чтобы сохранить нагрузку и равновесие. Не отводите локти в стороны, особенно при строго вертикальной спинке, чтобы избежать нагрузки на поясницу. Выполняйте 3-4 подхода по 6-15 повторений. Отдыхайте 70-90 секунд между подходами.", "OK");
	}
	async void Warning(object sender, EventArgs e)
	{
		DisplayAlert("Предупреждение", "Отработайте правильную траекторию с маленькими весами, чтобы избежать риска травмы!", "OK");
	}
}