namespace STRIVE.Trains.WithInventory.Arms;

public partial class BicepsOnKnee : ContentPage
{
	public BicepsOnKnee()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "����� �� ��������� ������ � ������ ���������� � ��������� �����. ���������� 3-4 ������� �� 8�12 ����������. ��������� ����� ��������� �� ����� �� ���� �����. � �������, ��� ������� ������ �� ����� ������, � �� ��� ��������! ��������������� ����� �������������, ������������� � ���.", "OK");
	}
	protected async override void OnAppearing()
	{
		base.OnAppearing();
		await Task.Delay(100);
		gif.IsAnimationPlaying = true;
	}

}