namespace STRIVE.Trains.WithInventory.Legs;

public partial class razgibNog : ContentPage
{
	public razgibNog()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "��� ����� ���������� ����� �������, ����� ����� ���� ��������� 3-4 ������� �� 15-18 ���. ������� ������� ��� �� ���� ��������� ��������� ����, ��-�� �������� ��������� ������������� ���������� ��������.", "OK");
	}
}