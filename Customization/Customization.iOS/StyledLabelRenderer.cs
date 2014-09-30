using Customization;
using Customization.iOS;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(StyledLabel), typeof(StyledLabelRenderer))]

namespace Customization.iOS
{
    public class StyledLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var styledLabel = (StyledLabel)Element;

            switch (styledLabel.Style)
            {
                case StyleType.Bold:
                    Control.Font = UIFont.BoldSystemFontOfSize( 16.0f );
                    break;
                case StyleType.Italic:
                    Control.Font = UIFont.ItalicSystemFontOfSize( 16.0f );
                    break;
                case StyleType.BoldItalic:
                    Control.Font = UIFont.FromName("Helvetica-BoldOblique", 16.0f);
                    break;
            }
        }
    }
}
