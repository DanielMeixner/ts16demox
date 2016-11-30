using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ts16mobile
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            ObservableCollection<string> myItems = new ObservableCollection<string>();
            myItems.Add("one");
            myItems.Add("two");
            myItems.Add("three");
            MyListView.ItemsSource = myItems;
        }
    }
}
