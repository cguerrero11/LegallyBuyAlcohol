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

            int age = today.Year - birthday.Year;

            string years;

            if (age >= 21)
            {
                year.Text = "You can already buy alcohol!";
            }
            else {
                age = (age * -1) + 21;

                years = age.ToString();
                year.Text = "You can buy alcohol in " + years +" year(s).";
            }
        }
    }
}
