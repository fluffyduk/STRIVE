namespace STRIVE.Trains.WithInventory.Legs;

public partial class legExtension : ContentPage
{
	public legExtension()
	{
		InitializeComponent();
	}

	async void Note(object sender, EventArgs e)
	{
		DisplayAlert("����������", "- ��������� ������ ���������� ��������� ������� � �������� ���� ��������, ����� �� ��������� ������� ������� � ������������� ����������� ��������.\r\n- ������������� ��������� ���� ��������, �������� � ���������� ����, ����� ���������� ����������� ������ ����.\r\n", "OK");
	}
}