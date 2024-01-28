using DevExpress.XtraEditors;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Management.SelectionForms;
using static Entities.Extensions.Extensions;

namespace YGN.Management.DetailForms
{
    public partial class PurchasingForm : XtraForm
    {
        #region members

        private Client_View _currClient;

        #endregion

        #region properties

        public Client_View CurrClient
        {
            get { return _currClient; }
            set
            {
                if (_currClient != null)
                {
                    _currClient = value;
                    newClientButtonEdit.Text = _currClient.FirmDescription;
                }
            }
        }

        #endregion

        #region constructor
        public PurchasingForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void newClientButtonEdit_Click(object sender, EventArgs e)
        {
            ClientSelectionForm clientSelectionForm = new ClientSelectionForm();
            clientSelectionForm.ShowDialog();
        }

        #endregion

        #region private methods

        #endregion
    }
}