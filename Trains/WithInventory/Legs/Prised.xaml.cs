namespace STRIVE.Trains.WithInventory.Legs;

public partial class Prised : ContentPage
{
	public Prised()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "��������� � ������ ����� � ���������� ����������� ��������. ��� ������� ������� ��������� � ������������� ���� ��������� � ����������.", "OK");
	}
	async void Warning(object sender, EventArgs e)
	{
		DisplayAlert("��������������", "��� ���������� ������������ ��� ����� � ���������� ������-������������� �������� ��� �������� �������� � ������������� ��������.", "OK");
	}
}