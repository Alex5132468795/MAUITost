
namespace MauiApp20;

public partial class MainPage : ContentPage
{
    int number = 0;
    Random random = new Random();
    List<Button> buttons = new List<Button>();
    public MainPage()
    {

        InitializeComponent();

        //---------------------------------
        for (int i = 0; i < 4; i++)
        {
            Button q = new Button();
            q.Text = "You Sure?";
            buttons.Add(q);
        }
        int bufer = random.Next(buttons.Count);
        buttons[bufer].Clicked += Winner;
        buttons[bufer].CommandParameter = "W";
        for (int i = 0; i < buttons.Count; i++)
        {
            if (buttons[i].CommandParameter.ToString() != "W")
            {
                buttons[i].Clicked += Again;
            }
        }
        //-----------------------------------
    }
    public async void Winner(object sender, EventArgs e)
    {
        bool w = false;
        w = (bool)await this.ShowPopupAsync(new NewPage1());
    }
    public void Again(object sender, EventArgs e)
    {

        Toast t = new Toast() { Text = "Try again!", Duration = ToastDuration.Short, TextSize = 14 };
        number++;
    }
    /*private void OnCounterClicked(object sender, EventArgs e)
	{
		CancellationToken c = new CancellationToken();
		Snackbar s = new Snackbar();
		SnackbarOptions SsnackbarOptions = new SnackbarOptions()
		{
			BackgroundColor = Color.FromRgb(255, 0, 0),
            TextColor = Color.FromRgb(255, 255, 0)
        };
		s = (Snackbar)Snackbar.Make("OWO", async () => await DisplayAlert("Welcom", "be-bei see you", "Okey"), "UWU", TimeSpan.FromSeconds(10),SsnackbarOptions);
		Snackbar q = new Snackbar();
        SnackbarOptions QsnackbarOptions = new SnackbarOptions()
        {
            BackgroundColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 255)
        };
        q = (Snackbar)Snackbar.Make("Quit", async () => await DisplayAlert("Welcom xenos", "Contingation see you", "Accept"), "Sure", TimeSpan.FromSeconds(10), QsnackbarOptions);
        Snackbar es = new Snackbar();
        SnackbarOptions EssnackbarOptions = new SnackbarOptions()
        {
            BackgroundColor = Color.FromRgb(10, 10, 10),
            TextColor = Color.FromRgb(0, 0, 255)
        };
        es = (Snackbar)Snackbar.Make("Help", async () => await DisplayAlert("Buy Skyrim", "Buy Skyrim", "Buy"), "Yes", TimeSpan.FromSeconds(10), EssnackbarOptions);
		switch (number)
		{
			case 0:
				s.Show();
				number++;
				break;
			case 1:
				q.Show();
				number++;
				break;
			case 2:
				es.Show();
				number = 0;
				break;
		}
	}*/
}

