using System.Windows;
using Customization;
using Customization.WinPhone;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(StyledLabel), typeof(StyledLabelRenderer))]

namespace Customization.WinPhone
{
    public class StyledLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged( ElementChangedEventArgs<Label> e ) {
            base.OnElementChanged( e );

            var styledLabel = (StyledLabel) Element;

            switch ( styledLabel.Style ) {
                case StyleType.Bold:
                    Control.FontWeight = FontWeights.Bold;
                    break;
                case StyleType.Italic:
                    Control.FontStyle = FontStyles.Italic;
                    break;
                case StyleType.BoldItalic:
                    Control.FontStyle = FontStyles.Italic;
                    Control.FontWeight = FontWeights.Bold;
                    break;
            }
        }
    }
}
