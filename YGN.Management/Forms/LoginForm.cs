using DevExpress.XtraEditors;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YGN.Management.Forms;

namespace YGN.Management
{
    public partial class MainView : XtraForm
    {
        #region members
        EntityModelContainer dbcontext;
        #endregion

        #region properties

        public string UserName
        {
            get { return userNameTextEdit.Text; }
            set
            {
                userNameTextEdit.Text = value;
            }
        }
        public string Password
        {
            get { return passwordTextEdit.Text; }
            set
            {
                passwordTextEdit.Text = value;
            }
        }

        #endregion

        #region constructor
        public MainView()
        {
            InitializeComponent();
            dbcontext = new EntityModelContainer();
        }
        #endregion

        #region events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkUSer())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Giriş Başarısız..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region methods
        private bool checkUSer()
        {
            var check = from u in dbcontext.USER
                        where u.USERNAME == UserName && u.PASSWORD == Password
                        select u;

            return check.Any();
        }
        #endregion

    }
}
