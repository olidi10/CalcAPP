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
        Label displayLabel;
        Button backspaceButton;
       
        public MainPage()
        
        
        {
            InitializeComponent();
            
            // Create a vertical stack for the entire keypad.
            StackLayout mainStack = new StackLayout
            
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                
            };
            // First row is the Label.
            displayLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.End
            

            };
            mainStack.Children.Add(displayLabel);
            // Second row is the backspace Button.
            backspaceButton = new Button
            {
                Text = "\u21E6",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                IsEnabled = false
                
            };
            backspaceButton.Clicked += OnBackspaceButtonClicked;
            mainStack.Children.Add(backspaceButton);
            // Now do the 10 number keys.
            StackLayout rowStack = null;
            for (int num = 1; num <= 10; num++)
            {
                if ((num - 1) % 3 == 0)
                {
                    
                rowStack = new StackLayout
 {
     Orientation = StackOrientation.Horizontal
 };
                    mainStack.Children.Add(rowStack);
                }
                Button digitButton = new Button
                {
                    Text = (num % 10).ToString(),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                    StyleId = (num % 10).ToString()
                };
                digitButton.Clicked += OnDigitButtonClicked;
                // For the zero button, expand to fill horizontally.
                if (num == 10)
                {
                    digitButton.HorizontalOptions = LayoutOptions.FillAndExpand;
                }
                rowStack.Children.Add(digitButton);
            }
            this.Content = mainStack;
        }
        void OnDigitButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            displayLabel.Text += (string)button.StyleId;
            backspaceButton.IsEnabled = true;
        }
        void OnBackspaceButtonClicked(object sender, EventArgs args)
        {
            string text = displayLabel.Text;
            displayLabel.Text = text.Substring(0, text.Length - 1);
            backspaceButton.IsEnabled = displayLabel.Text.Length > 0;
        }
        ///////////////////////////////////////////////////////////////
        //    //call the OnSelectNumber Method/Function
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
