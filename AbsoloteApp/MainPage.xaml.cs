using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AbsoloteApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            /*AbsoluteLayout.SetLayoutBounds(player, 
                                           new Rectangle 
                                           (1, 2, 
                                                  AbsoluteLayout.AutoSize, 
                                                  AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutBounds(computer,
                                           new Rectangle
                                           (3, 4,
                                                  AbsoluteLayout.AutoSize,
                                                  AbsoluteLayout.AutoSize));

            AbsoluteLayout.SetLayoutBounds(counter,
                                           new Rectangle
                                           (7, 8,
                                                  AbsoluteLayout.AutoSize,
                                                  AbsoluteLayout.AutoSize));
                                                  */

        }
    }
}
