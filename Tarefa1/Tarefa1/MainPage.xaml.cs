using Microsoft.Maui.Controls;

namespace Tarefa1;


public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicou {count} vez(es)";
        else
            CounterBtn.Text = $"Clicou {count} vez(es)";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private async void OnNextLevelClicked(object sender, EventArgs e)
    {
        if (count >= 10)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }

 
}
