using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Seek_Sale
{
    public partial class MainForm : Form
    {
        public static MainForm mainForm; 
        public MainSearchForm mainSearchForm;
        public CartForm cartForm;
        public MainPublishForm mainPublishForm;
        public MainModifyForm mainModifyForm;
        public OrderForm orderForm;
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Forced login
            this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "请登陆后操作" });
            LoginForm loginform = new LoginForm();
            loginform.ShowDialog();
            //userTabPage included userManageForm
            TabPage searchTabPage = new TabPage("查找商品");
            searchTabPage.Name = "SearchTabPage";
            this.mainTabControl.TabPages.Add(searchTabPage);
            mainSearchForm = new MainSearchForm();
            mainSearchForm.TopLevel = false;
            mainSearchForm.Parent = searchTabPage;
            mainSearchForm.ControlBox = false;
            mainSearchForm.Dock = System.Windows.Forms.DockStyle.Fill;
            mainSearchForm.Show();
            //cartForm
            TabPage cartTabPage = new TabPage("我的购物车");
            cartTabPage.Name = "CartTabPage";
            this.mainTabControl.TabPages.Add(cartTabPage);
            cartForm = new CartForm(UserInfo.instance.userid);
            cartForm.TopLevel = false;
            cartForm.Parent = cartTabPage;
            cartForm.ControlBox = false;
            cartForm.Dock = System.Windows.Forms.DockStyle.Fill;
            cartForm.Show();
            //itemTypeTabPage included itemTypeManageForm
            TabPage publishTabPage = new TabPage("发布新商品");
            publishTabPage.Name = "PublishTabPage";
            this.mainTabControl.TabPages.Add(publishTabPage);
            mainPublishForm = new MainPublishForm();
            mainPublishForm.TopLevel = false;
            mainPublishForm.Parent = publishTabPage;
            mainPublishForm.ControlBox = false;
            mainPublishForm.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPublishForm.Show();
            //userTabPage included userManageForm
            TabPage modifyTabPage = new TabPage("修改资料");
            modifyTabPage.Name = "ModifyTabPage";
            this.mainTabControl.TabPages.Add(modifyTabPage);
            mainModifyForm = new MainModifyForm();
            mainModifyForm.TopLevel = false;
            mainModifyForm.Parent = modifyTabPage;
            mainModifyForm.ControlBox = false;
            mainModifyForm.Dock = System.Windows.Forms.DockStyle.Fill;
            mainModifyForm.Show();
            //orderTabPage included orderForm
            TabPage orderTabPage = new TabPage("查看订单");
            orderTabPage.Name = "OrderTabPage";
            this.mainTabControl.TabPages.Add(orderTabPage);
            orderForm = new OrderForm();
            orderForm.TopLevel = false;
            orderForm.Parent = orderTabPage;
            orderForm.ControlBox = false;
            orderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            orderForm.Show();
            //select to userTabPage
            this.mainTabControl.SelectedTab = searchTabPage;
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();
            string sql = "SELECT * FROM CartItem WHERE userid = " + UserInfo.instance.userid + ";";
            OdbcDataReader reader = connector.Select(sql);
            bool isempty = true;
            if(reader.Read())
                isempty = false;
            connector.Close();
            if(mainTabControl.SelectedIndex == 1 && isempty)
            {
                MessageBox.Show("购物车为空！");
                mainTabControl.SelectedIndex = 0;
            }
        }

    }
}
