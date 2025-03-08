namespace Tarefa1;

public partial class SecondPage : ContentPage
{
    int count = 1;
    bool isRunning = false;

    public SecondPage()
    {
        InitializeComponent();
        StartCountDown(); 
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterBtn.Text = $"Clicou {count} vez(es)";
        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (!isRunning) 
        {
            StartCountDown();
        }
    }

    // Método para reduzir o contador a cada segundo
    private async void StartCountDown()
    {
        isRunning = true;

        
        while (count > -20)
        {
            await Task.Delay(1000); 

           
            count--;

            
            Device.BeginInvokeOnMainThread(() =>
            {
                CounterBtn.Text = count.ToString(); 
            });
        }

        isRunning = false; 
    }

    private async void OnNextLevelClicked(object sender, EventArgs e)
    {
        if (count >= 10) 
        {
            await Navigation.PushAsync(new WinPage());
        }
    }
}
