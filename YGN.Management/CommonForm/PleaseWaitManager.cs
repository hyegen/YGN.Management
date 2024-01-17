using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGN.Management.CommonForm
{
    public class PleaseWaitManager<TSplash> : IDisposable where TSplash : WaitForm
    {
        public PleaseWaitManager()
        {
            Show();
        }

        public void Show()
        {
            foreach (var openForm in Application.OpenForms)
                if (openForm is TSplash)
                    return;

            SplashScreenManager.ShowForm(typeof(TSplash));
        }

        public void Dispose()
        {
            SplashScreenManager.CloseForm(false);
            Cursor.Current = Cursors.Default;
        }
    }
}
