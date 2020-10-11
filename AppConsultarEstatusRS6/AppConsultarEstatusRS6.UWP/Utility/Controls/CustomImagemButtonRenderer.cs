using AppConsultarEstatusRS6.UWP.Utility.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ImageButton), typeof(CustomImagemButtonRenderer))]
namespace AppConsultarEstatusRS6.UWP.Utility.Controls
{
    public class CustomImagemButtonRenderer : ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageButton> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {

                var style = Windows.UI.Xaml.Application.Current.Resources["ImageButtonStyle"] as Windows.UI.Xaml.Style;
                Control.Style = style;
            }
        }
    }
}
