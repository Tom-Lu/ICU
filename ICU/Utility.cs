using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TomLu.ICU
{
    class Utility
    {
        private delegate void DelegateFunction();

        public static void FocusControl(UserControl parentControl, Control control, string Keys = "")
        {
            new Thread(new ThreadStart(delegate()
            {
                Thread.Sleep(100);
                parentControl.Invoke(new DelegateFunction(delegate()
                {
                    control.Focus();
                    if (!Keys.Equals(""))
                    {
                        SendKeys.Send(Keys);
                    }
                }));
            })).Start();
        }

        public static void BindDataSource(Control control, string property, object targetObject, string targetProperty)
        {
            control.DataBindings.Add(property, targetObject, targetProperty, false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
