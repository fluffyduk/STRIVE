using Plugin.Maui.Calendar.Models;

namespace STRIVE;

public partial class CalendarPage : ContentPage
{
	public EventCollection Events { get; set; }
	public CalendarPage()
	{
		InitializeComponent();
		addEvent.WidthRequest = DeviceDisplay.Current.MainDisplayInfo.Width/2;
		Events = new EventCollection();
		BindingContext = this;
	}

	async void OnButtonClicked(object sender, EventArgs args)
	{
		if (!cal.SelectedDate.HasValue)
		{
			await DisplayAlert("Предупреждение", "Чтобы назначить событие, выберите дату!", "ОK");
		}
		else
		{
			var ev = await DisplayPromptAsync("Назначить событие", "Введите событие", "Подтвердить", "Отмена");
			Events.Add(
				new DateTime(cal.SelectedDate.Value.Year, cal.SelectedDate.Value.Month, cal.SelectedDate.Value.Day,
				DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
				, new List<EventModel> { new EventModel { Name = ev } }
				);
		}
	}
}

internal class EventModel
{
    public string Name { get; set; }
}