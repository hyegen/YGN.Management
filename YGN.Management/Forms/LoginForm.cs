using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using YGN.BusinessLayer.Concrete;
using YGN.DataAccesLayer.Concrete.EntityFramework;
using YGN.Management.Forms;

namespace YGN.Management
{
    public partial class MainView : XtraForm
    {
        #region members
        UserManager userManager = new UserManager(new EfUserDal());
        #endregion

        #region constructor
        public MainView()
        {
            InitializeComponent();

        }
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

        #region events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void passwordTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        #endregion

        private void Login()
        {
            bool checkInfo = userManager.Login(UserName, Password);
            if (checkInfo)
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
                XtraMessageBox.Show("Giriş Başarısız..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
