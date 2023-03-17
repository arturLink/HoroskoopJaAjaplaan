using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HoroskoopJaAjaplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horoskop : ContentPage
    {
        DatePicker dtpicker;
        StackLayout st;
        public Horoskop()
        {
            st = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Gray,
            };
            Content = st;

            dtpicker = new DatePicker()
            {
                Format = "dd-MM-yyyy",
                BackgroundColor = Color.White,
                TextColor = Color.Black
            };
            dtpicker.DateSelected += Dtpicker_DateSelected;
            st.Children.Add(dtpicker);
            
        }

        private void Dtpicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var month = e.NewDate.Month;
            var day = e.NewDate.Month;
            string[] zodiacSigns = {"Kaljukits", "Veevalaja", "Kalad", "Jäär", "Sõnn", "Kaksikud",
                            "Vähk", "Lõvi", "Neitsi", "Kaalud", "Skorpion", "Ambur"};
            int[] cutoffDays = { 20, 19, 20, 20, 21, 21, 22, 23, 23, 23, 22, 21 };
            int index = (day <= cutoffDays[month - 1]) ? month - 1 : (month + 10) % 12;

        }
    }
}