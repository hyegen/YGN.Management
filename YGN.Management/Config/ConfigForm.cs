using Commons;
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

namespace YGN.Management.Config
{
    public partial class ConfigForm : DevExpress.XtraEditors.XtraForm
    {
        public event Action TryConnection;
        public event Action SaveAndNext;
        public ConnectionInfo DataSource
        {
            get { return (ConnectionInfo)configurationBindingSource.DataSource; }
            set { configurationBindingSource.DataSource = value; }
        }
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void saveAndNextSimpleButton_Click(object sender, EventArgs e)
        {
            if (SaveAndNext != null)
                SaveAndNext();
        }

        private void tryConnectionSimpleButton_Click(object sender, EventArgs e)
        {
            if (TryConnection != null)
                TryConnection();
        }
    }
}