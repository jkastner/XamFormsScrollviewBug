using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamFormsScrollviewBug
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageWithBug1 : ContentPage
	{
		public PageWithBug1 ()
		{
			InitializeComponent ();
		}
	}
}