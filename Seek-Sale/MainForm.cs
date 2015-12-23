using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seek_Sale
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //userTabPage included userManageForm
            TabPage searchTabPage = new TabPage("查找商品");
            searchTabPage.Name = "SearchTabPage";
            this.mainTabControl.TabPages.Add(searchTabPage);
            MainSearchForm mainSearchForm = new MainSearchForm();
            mainSearchForm.TopLevel = false;
            mainSearchForm.Parent = searchTabPage;
            mainSearchForm.ControlBox = false;
            mainSearchForm.Dock = System.Windows.Forms.DockStyle.Fill;
            mainSearchForm.Show();
            //cartForm
            TabPage cartTabPage = new TabPage("我的购物车");
            cartTabPage.Name = "CartTabPage";
            this.mainTabControl.TabPages.Add(cartTabPage);
            CartForm cartForm = new CartForm(UserInfo.instance.userid);
            cartForm.TopLevel = false;
            cartForm.Parent = cartTabPage;
            cartForm.ControlBox = false;
            cartForm.Dock = System.Windows.Forms.DockStyle.Fill;
            cartForm.Show();
            //itemTypeTabPage included itemTypeManageForm
            TabPage publishTabPage = new TabPage("发布新商品");
            publishTabPage.Name = "PublishTabPage";
            this.mainTabControl.TabPages.Add(publishTabPage);
            MainPublishForm mainPublishForm = new MainPublishForm();
            mainPublishForm.TopLevel = false;
            mainPublishForm.Parent = publishTabPage;
            mainPublishForm.ControlBox = false;
            mainPublishForm.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPublishForm.Show();
            //userTabPage included userManageForm
            TabPage modifyTabPage = new TabPage("修改资料");
            modifyTabPage.Name = "ModifyTabPage";
            this.mainTabControl.TabPages.Add(modifyTabPage);
            MainModifyForm mainModifyForm = new MainModifyForm();
            mainModifyForm.TopLevel = false;
            mainModifyForm.Parent = modifyTabPage;
            mainModifyForm.ControlBox = false;
            mainModifyForm.Dock = System.Windows.Forms.DockStyle.Fill;
            mainModifyForm.Show();
            //select to userTabPage
            this.mainTabControl.SelectedTab = searchTabPage;
            //Forced login
            this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "请登陆后操作" });
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
