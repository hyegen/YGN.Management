using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YGN.Management.OrderFicheMaker
{
    public partial class OrderFicheMakerForm : DevExpress.XtraEditors.XtraForm
    {
        public OrderFicheMakerForm()
        {
            InitializeComponent();
        }

        private void OrderFicheMaker_Load(object sender, EventArgs e)
        {
            reportDesigner1.OpenReport(new OrderFicheXtraReport());
        }
    }
}