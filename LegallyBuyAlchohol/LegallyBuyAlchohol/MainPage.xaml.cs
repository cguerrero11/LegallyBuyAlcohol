using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LegallyBuyAlchohol
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Get_years(object sender, System.EventArgs e)
        {
            var birthday = BirthDate.Date;
            var today = DateTime.Now;
            var yearsold = birthday.Subtract(today);

            year.Text += yearsold; 
        }
    }
}
