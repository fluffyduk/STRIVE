namespace STRIVE.Trains.WithInventory.Arms;

public partial class dumbbellsdividing : ContentPage
{
	public dumbbellsdividing()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "�� ���������� ��� �� ���� ���!\r\n�������� �������� � ���������� ���������� ��������� �� ���� ���� ����� � ���� ���� ������������ ���. �� ��������� �����. ������� ����� ������ ���������.\r\n", "OK");
	}
}