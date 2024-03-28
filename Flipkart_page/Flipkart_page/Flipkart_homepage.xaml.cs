using Flipkart_page.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flipkart_page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flipkart_homepage : ContentPage
    {
        public Flipkart_homepage()
        {
            InitializeComponent();
            BindingContext = new FlipkartViewModel();
                 
        }      
    }
}