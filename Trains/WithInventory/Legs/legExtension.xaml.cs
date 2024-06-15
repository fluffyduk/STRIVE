namespace STRIVE.Trains.WithInventory.Legs;

public partial class legExtension : ContentPage
{
	public legExtension()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("ѕримечание", "- »збегайте полной блокировки коленного сустава в конечной фазе движени€, чтобы не нагружать излишне суставы и предотвратить повреждение менисков.\r\n- ѕоддерживайте медленный темп движени€, особенно в негативной фазе, чтобы обеспечить равномерную работу мышц.\r\n", "OK");
	}
}