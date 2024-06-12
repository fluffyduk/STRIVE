using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace STRIVE;

public class TypeOfButton
{
	public ICommand AddCommand { get; set; }
	public string Type { get; set;}


	public TypeOfButton()
	{
		AddCommand = new Command((obj) =>
		{
			Type = obj.ToString();
		});
	}
}

public partial class Trainings : ContentPage
{
	public Trainings()
	{
		BindingContext = new TypeOfButton();
		InitializeComponent();
	}

	async void OnImageButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ChoosePage((TypeOfButton)BindingContext));
	}


}