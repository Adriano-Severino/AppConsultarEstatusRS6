using AppConsultarEstatusRS6.UWP.Utility.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace AppConsultarEstatusRS6.UWP.Utility.Controls
{
    public class CustomEntryRenderer : EntryRenderer
    {
       

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = null;
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}