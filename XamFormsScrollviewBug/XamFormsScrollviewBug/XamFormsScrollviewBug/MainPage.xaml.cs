using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamFormsScrollviewBug
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      
    }

    private void MainPage_OnAppearing(object sender, EventArgs e)
    {
      for (int x = 0; x < 115; x++)
      {
        NumberGrid.Children.Add(new Label()
        {
          Text = x.ToString(),
        });
      }

    }
  }
}
