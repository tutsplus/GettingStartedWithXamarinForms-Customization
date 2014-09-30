using System;
using Xamarin.Forms;

namespace Customization
{
    public enum StyleType {
        None,
        Italic,
        Bold,
        BoldItalic
    }

    public class StyledLabel : Label {
        public static readonly BindableProperty StyleProperty = BindableProperty.Create<StyledLabel, StyleType>( p => p.Style, StyleType.None );

        public StyleType Style {
            get { return (StyleType)base.GetValue( StyleProperty ); }
            set { base.SetValue(StyleProperty, value);}
        }
    }
}
