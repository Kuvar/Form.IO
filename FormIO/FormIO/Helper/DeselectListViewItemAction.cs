using Xamarin.Forms;

namespace FormIO
{
    public class DeselectListViewItemAction : TriggerAction<ListView>
    {
        protected override void Invoke(ListView sender)
        {
            sender.SelectedItem = null;
        }
    }
}
