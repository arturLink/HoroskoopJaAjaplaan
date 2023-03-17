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
            st.Children.Add(dtpicker);
            
        }
    }
}