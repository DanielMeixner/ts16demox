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

        private string myUrl;

        public MainPage()
		{
			InitializeComponent();
		}

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }


        //private async Task<Quote> GetQuoteFromServerAsync()
        //{
        //    HttpClient client = new HttpClient();
        //    var json = await client.GetStringAsync(myUrl);

        //    Quote q = JsonConvert.DeserializeObject<Quote>(json);

        //    return q;
        //}


    }

    public class Quote
    {
        public string QuoteText { get; set; }
        public string Author { get; set; }
    }


}
