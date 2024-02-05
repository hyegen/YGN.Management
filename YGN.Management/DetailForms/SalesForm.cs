using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGN.Management.Forms;

namespace YGN.Management.DetailForms
{
    public partial class SalesForm : XtraForm
    {
        #region members

        #endregion

        #region constructor
        public SalesForm()
        {
            InitializeComponent();
        }
        #endregion

        #region events
        private void itemsButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }
        private void clientsButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
        }
        #endregion

        #region methods

        #endregion


    }
}