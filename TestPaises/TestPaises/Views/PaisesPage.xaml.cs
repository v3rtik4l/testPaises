using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestPaises.Views
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaisesPage : ContentPage
	{
		public PaisesPage ()
		{
			InitializeComponent ();
		}
	}
}