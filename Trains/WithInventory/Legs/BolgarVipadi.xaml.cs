namespace STRIVE.Trains.WithInventory.Legs;

public partial class BolgarVipadi : ContentPage
{
	public BolgarVipadi()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "���� ����� ���������� ������ �������� � ����������� � ���� �������� ��� ������. �� ��� ������ ������������ ����������� ������� ������� ��� ��������������� ����. ����� ������� ��������� ������, ������� �����, ������ ��������� ��������� ����������, ����� ������������ ��������� ����������� ��� ����� ������������� ��������. ", "OK");
	}
}