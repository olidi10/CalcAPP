using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //call the OnSelectNumber Method/Function
        void OnSelectNumber(object sender, EventArgs args)
        {
            Button Clicked = (Button)sender;

        }
        //call the  OnSlectOperator Method/Function
        void OnSelectOperator(object sender, EventArgs args)
        {
            Button Cliked = (Button)sender;
        }
        //call the OnClear Method/Function
        void OnClear(object sender, EventArgs args)
        {
            Button Click = (Button)sender;
        }
        // call the  OnCalculate Method/Functiom
        void OnCalculate(object sender, EventArgs args)
        {
            Button Cliked = (Button)sender;
        }
    }
}
