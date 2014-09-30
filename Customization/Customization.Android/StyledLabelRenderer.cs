using Android.Graphics;
using Customization;
using Customization.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(StyledLabel), typeof(StyledLabelRenderer))]

namespace Customization.Droid
{
    public class StyledLabelRenderer : LabelRenderer {
        protected override void OnElementChanged( ElementChangedEventArgs<Label> e ) {
            base.OnElementChanged( e );

            var styledLabel = (StyledLabel)Element;

            switch (styledLabel.Style)
            {
                case StyleType.Bold:
                    Control.SetTypeface(null, TypefaceStyle.Bold);
                    break;
                case StyleType.Italic:
                    Control.SetTypeface(null, TypefaceStyle.Italic);
                    break;
                case StyleType.BoldItalic:
                    Control.SetTypeface(null, TypefaceStyle.BoldItalic);
                    break;
            }

        }
    }
}