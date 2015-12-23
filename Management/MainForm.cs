using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class MainForm : Form
    {
        UserManageForm userManageForm;
        ItemTypeManageForm itemTypeManageForm;
        ItemManageForm itemManageForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //userTabPage included userManageForm
            TabPage userTabPage = new TabPage("用户管理");
            userTabPage.Name = "UserTabPage";
            this.ManageTab.TabPages.Add(userTabPage);
            userManageForm = new UserManageForm();
            userManageForm.TopLevel = false;
            userManageForm.Parent = userTabPage;
            userManageForm.ControlBox = false;
            userManageForm.Dock = System.Windows.Forms.DockStyle.Fill;
            userManageForm.Show();
            //itemTypeTabPage included itemTypeManageForm
            TabPage itemTypeTabPage = new TabPage("商品类别管理");
            itemTypeTabPage.Name = "ItemTypeTabPage";
            this.ManageTab.TabPages.Add(itemTypeTabPage);
            itemTypeManageForm = new ItemTypeManageForm();
            itemTypeManageForm.TopLevel = false;
            itemTypeManageForm.Parent = itemTypeTabPage;
            itemTypeManageForm.ControlBox = false;
            itemTypeManageForm.Dock = System.Windows.Forms.DockStyle.Fill;
            itemTypeManageForm.Show();
            //userTabPage included userManageForm
            TabPage itemTabPage = new TabPage("商品管理");
            itemTabPage.Name = "UserTabPage";
            this.ManageTab.TabPages.Add(itemTabPage);
            itemManageForm = new ItemManageForm();
            itemManageForm.TopLevel = false;
            itemManageForm.Parent = itemTabPage;
            itemManageForm.ControlBox = false;
            itemManageForm.Dock = System.Windows.Forms.DockStyle.Fill;
            itemManageForm.Show();
            //select to userTabPage
            this.ManageTab.SelectedTab = userTabPage;
        }

        private void userStrip_Click(object sender, EventArgs e)
        {
            UserInfoForm userInfoForm = new UserInfoForm();
            userInfoForm.ShowDialog();
        }

        private void itemStrip_Click(object sender, EventArgs e)
        {
            SearchItemForm searchItemForm = new SearchItemForm();
            searchItemForm.ShowDialog();
        }

        private void addStrip_Click(object sender, EventArgs e)
        {
            if (ManageTab.SelectedIndex == 0)
            {
                NewUserForm userform = new NewUserForm();
                userform.ShowDialog();
                userManageForm.refresh();
            }
            else if (ManageTab.SelectedIndex == 1)
            {
                NewItemTypeForm typeform = new NewItemTypeForm();
                typeform.ShowDialog();
                itemTypeManageForm.refresh();
            }
            else
            {
                NewItemForm itemform = new NewItemForm();
                itemform.ShowDialog();
                itemManageForm.refresh();
            }
        }
    }
}
