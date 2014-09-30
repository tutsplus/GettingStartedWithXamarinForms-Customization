using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Customization
{
    public partial class StyledLabelPage : ContentPage
    {
        public StyledLabelPage()
        {
            InitializeComponent();
            BindingContext = new SampleStyles {
                FirstStyle = StyleType.Italic,
                SecondStyle = StyleType.Bold,
                ThirdStyle = StyleType.BoldItalic
            };
        }
    }
}
