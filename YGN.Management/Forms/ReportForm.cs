using DevExpress.XtraEditors;
using Entities;
using System.Linq;

namespace YGN.Management.Forms
{
    public partial class ReportForm : XtraForm
    {
        #region members
       
        #endregion

        #region constructor
        public ReportForm()
        {
           
            InitializeComponent();
        }
        #endregion

        #region method_of_reports

        private void reportDailyPurchase()
        {
            //var da = dbcontext.TRANSACTIONS.Sum(x => x.AMOUNT);
            //   var daily= from t in dbcontext.TRANSACTIONS
        }
        
        #endregion

    }
}