using Plugin.Maui.Calendar.Models;

namespace STRIVE;

public partial class CalendarPage : ContentPage
{
	public EventCollection Events { get; set; }

	public CalendarPage()
	{
		InitializeComponent();
		Events = new EventCollection
		{
			[DateTime.Now] = new List<EventModel>
			{
				new EventModel { Name = "Cool event1", Description = "This is Cool event1's description!" },
				new EventModel { Name = "Cool event2", Description = "This is Cool event2's description!" }
			},
			[DateTime.Now.AddDays(5)] = new List<EventModel>
			{
				new EventModel { Name = "Cool event3", Description = "This is Cool event3's description!" },
				new EventModel { Name = "Cool event4", Description = "This is Cool event4's description!" }
			},
			[DateTime.Now.AddDays(-3)] = new List<EventModel>
			{
				new EventModel { Name = "Cool event5", Description = "This is Cool event5's description!" }
			},
			[new DateTime(2020, 3, 16)] = new List<EventModel>
			{
				new EventModel { Name = "Cool event6", Description = "This is Cool event6's description!" }
			}
		};
		BindingContext = this;
	}
}

internal class EventModel
{
    public string Name { get; set; }
    public string Description { get; set; }
}