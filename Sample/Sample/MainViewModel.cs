using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace Sample
{
  public class MainViewModel : ObservableObject
  {
    public MainViewModel()
    {
      this.MyCommand = new Command(Go);
    }

    public ICommand MyCommand { get; set; }

    private void Go(object obj)
    {
      Application.Current.MainPage.DisplayAlert("Alert", "Button was clicked!", "Cancel");
    }
  }
}
