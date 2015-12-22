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
    public partial class PayForm : Form
    {
        public bool succeed;
        List<CartItem> items;
        List<PayItem> pays;
        List<PositionItem> positions;
        List<CheckBox> payBox;
        List<CheckBox> positionBox;
        public PayForm(List<CartItem> selectedItem)
        {
            InitializeComponent();
            this.succeed = false;
            this.items = new List<CartItem>();
            this.pays = new List<PayItem>();
            this.positions = new List<PositionItem>();
            foreach (CartItem item in selectedItem)
            {
                this.items.Add(item);
            }
        }

        private void PayForm_Load(object sender, EventArgs e)
        {
            //load data
            DBConnector connector = new DBConnector();
            string sql;
            OdbcDataReader reader;
            sql = "SELECT * FROM user-trade WHERE ";
            reader = connector.Select(sql);
            while(reader.Read())
            {
                string cardid = reader.GetString(-1);
                bool quickpay = reader.GetInt32(-1) == 1 ? true : false;
                PayItem pay = new PayItem(cardid, quickpay);
                this.pays.Add(pay);
            }
            connector.Close();
            sql = "SELECT * FROM user-position WHERE ";
            reader = connector.Select(sql);
            while(reader.Read())
            {
                string postcode = reader.GetString(-1);
                string description = reader.GetString(-1);
                PositionItem position = new PositionItem(postcode, description);
                this.positions.Add(position);
            }
            //fill panel
            int pixely;
            foreach (CartItem item in this.items)
            {
                itemPanel.Controls.Add(item);
            }
            pixely = 0;
            int id;
            id = 0;
            payBox = new List<CheckBox>();
            foreach (PayItem pay in this.pays)
            {
                id++;
                Panel panel = new Panel();
                CheckBox checkbox = new CheckBox();
                TextBox textbox = new TextBox();
                panel.Location = new Point(0, pixely);
                panel.Size = new Size(560, 25);
                panel.Name = "PayPanel" + id.ToString();
                checkbox.Location = new Point(0, 1);
                checkbox.Checked =  false;
                checkbox.Text = "";
                checkbox.Size = new Size(22, 22);
                checkbox.Name = "PayCheckBox" + id.ToString();
                textbox.Location = new Point(24, 0);
                textbox.ReadOnly = true;
                textbox.Text = pay.cardno;
                textbox.Size = new Size(536, 22);
                textbox.Name = "PayTextBox" + id.ToString();
                this.payPpanel.Controls.Add(panel);
                checkbox.CheckedChanged += new EventHandler(this.MyChechBox_Click);
                panel.Controls.Add(checkbox);
                panel.Controls.Add(textbox);
                pixely += 25;
                payBox.Add(checkbox);
            }
            id = 0;
            positionBox = new List<CheckBox>();
            foreach (PositionItem position in this.positions)
            {
                id++;
                Panel panel = new Panel();
                CheckBox checkbox = new CheckBox();
                TextBox textbox = new TextBox();
                panel.Location = new Point(0, pixely);
                panel.Size = new Size(560, 25);
                panel.Name = "PositionPanel" + id.ToString();
                checkbox.Location = new Point(0, 1);
                checkbox.Checked =  false;
                checkbox.Text = "";
                checkbox.Size = new Size(22, 22);
                checkbox.Name = "PositionCheckBox" + id.ToString();
                textbox.Location = new Point(24, 0);
                textbox.ReadOnly = true;
                textbox.Text = position.description + "(" + position.postcode + ")";
                textbox.Size = new Size(536, 22);
                textbox.Name = "PositionTextBox" + id.ToString();
                this.payPpanel.Controls.Add(panel);
                checkbox.CheckedChanged += new EventHandler(this.MyChechBox_Click);
                panel.Controls.Add(checkbox);
                panel.Controls.Add(textbox);
                pixely += 25;
                payBox.Add(checkbox);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.succeed = true;
            DBConnector connector = new DBConnector();
            string sql;
            foreach (CartItem item in this.items)
            {
                //Delete cart
                sql = "DELETE...";
                connector.Delete(sql);
                //mark for sold out
            }
            connector.Close();
            this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { "订单生成成功！" });
            this.Close();
        }

        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyChechBox_Click(object sender, System.EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Name.ElementAt(1) == 'a')
            {
                //PayCheckBox
                foreach (CheckBox paycheckbox in payBox)
                {
                    if (paycheckbox.Name != checkbox.Name)
                        paycheckbox.Checked = false;
                }
            }
            else
            {
                foreach (CheckBox positioncheckbox in positionBox)
                {
                    if (positioncheckbox.Name != checkbox.Name)
                        positioncheckbox.Checked = false;
                }
            }
        }
    }

    public partial class PayItem
    {
        public string cardno;
        public bool quickpay;
        public PayItem(string cardno, bool quickpay)
        {
            this.cardno = cardno;
            this.quickpay = quickpay;
        }

    }

    public partial class PositionItem
    {
        public string postcode;
        public string description;
        public PositionItem(string postcode, string description)
        {
            this.postcode = postcode;
            this.description = description;
        }
    }
}
