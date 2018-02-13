using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TriggersExample
{
    public class EmailValidoTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.Text.IndexOf("@") >= 0)
            {
                sender.TextColor = Color.LightGreen;
            }
            else
            {
                sender.TextColor = Color.Red;
            }
        }
    }
}
