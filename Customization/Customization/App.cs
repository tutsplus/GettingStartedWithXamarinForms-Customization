using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Customization
{
    public class App
    {
        public static Page GetMainPage() {
            var iLabel = new StyledLabel
            {
                TextColor = Color.Black,
                Text = "I want to be italicized!",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Style = StyleType.Italic
            };
            var bLabel = new StyledLabel
            {
                Text = "I want to be bold!",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Style = StyleType.Bold
            };
            var bothLabel = new StyledLabel
            {
                Text = "I want to be italicized and bold!",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Style = StyleType.BoldItalic
            };
            return new ContentPage
            {
                BackgroundColor = Color.White,
                Content = new StackLayout
                {
                    Padding = 100,
                    Spacing = 100,
                    Children = { iLabel, bLabel, bothLabel }
                }
            };
        }
    }
}
