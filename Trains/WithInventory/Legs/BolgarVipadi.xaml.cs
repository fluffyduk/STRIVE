namespace STRIVE.Trains.WithInventory.Legs;

public partial class BolgarVipadi : ContentPage
{
	public BolgarVipadi()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("Примечание", "Чаще всего болгарские выпады делаются с отягощением в виде гантелей или штанги. Но для начала настоятельно рекомендуем освоить технику без дополнительного веса. Перед работой разомните колени, суставы стопы, можете выполнить несколько приседаний, чтобы активировать бедренную мускулатуру для более продуктивного тренинга. ", "OK");
	}
}