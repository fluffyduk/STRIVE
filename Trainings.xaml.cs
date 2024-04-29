using System.Diagnostics;

namespace STRIVE;

public partial class Trainings : ContentPage
{
	public Trainings()
	{
		InitializeComponent();
	}

	void OnImageButtonClicked(object sender, EventArgs e)
	{
		Debug.Write("clicked!");
	}
}