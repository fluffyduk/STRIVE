namespace STRIVE.Trains.WithInventory.Arms;

public partial class UpperPress : ContentPage
{
	public UpperPress()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "�� ��������� � ������� ����� ��������� ���� �����, ����� ��������� �������� � ����������. �� �������� ����� � �������, �������� ��� ������ ������������ ������, ����� �������� �������� �� ��������. ���������� 3-4 ������� �� 6-15 ����������. ��������� 70-90 ������ ����� ���������.", "OK");
	}
	async void Warning(object sender, EventArgs e)
	{
		DisplayAlert("��������������", "����������� ���������� ���������� � ���������� ������, ����� �������� ����� ������!", "OK");
	}
}