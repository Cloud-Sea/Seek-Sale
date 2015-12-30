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
            sql = "SELECT * FROM Paytb WHERE Paytb.payid in (SELECT payid FROM UserPayment WHERE userid=" + UserInfo.instance.userid + ");";
            reader = connector.Select(sql);
            while(reader.Read())
            {
                int payid = reader.GetInt32(0);
                string cardid = reader.GetString(1);
                bool quickpay = reader.GetInt32(2) == 1 ? true : false;
                PayItem pay = new PayItem(payid, cardid, quickpay);
                this.pays.Add(pay);
            }
            sql = "SELECT * FROM Positiontb WHERE Positiontb.positionid in (SELECT positionid FROM UserPos WHERE userid=" + UserInfo.instance.userid + ");";
            reader = connector.Select(sql);
            while(reader.Read())
            {
                int positionid = reader.GetInt32(0);
                string postcode = reader.GetString(1);
                string description = reader.GetString(2);
                PositionItem position = new PositionItem(positionid, postcode, description);
                this.positions.Add(position);
            }
            connector.Close();
            //fill panel
            int pixely;
            foreach (CartItem item in this.items)
            {
                itemPanel.Controls.Add(item);
            }
            pixely = 0;
            payBox = new List<CheckBox>();
            foreach (PayItem pay in this.pays)
            {
                Panel panel = new Panel();
                CheckBox checkbox = new CheckBox();
                TextBox textbox = new TextBox();
                panel.Location = new Point(0, pixely);
                panel.Size = new Size(560, 25);
                panel.Name = "PayPanel" + pay.payid.ToString();
                checkbox.Location = new Point(0, 1);
                checkbox.Checked =  false;
                checkbox.Text = "";
                checkbox.Size = new Size(22, 22);
                checkbox.Name = pay.payid.ToString();
                textbox.Location = new Point(24, 0);
                textbox.ReadOnly = true;
                textbox.Text = pay.cardno;
                textbox.Size = new Size(536, 22);
                textbox.Name = "PayTextBox" + pay.payid.ToString();
                this.payPanel.Controls.Add(panel);
                checkbox.CheckedChanged += new EventHandler(this.MyChechBox_Click);
                panel.Controls.Add(checkbox);
                panel.Controls.Add(textbox);
                pixely += 25;
                payBox.Add(checkbox);
            }
            pixely = 0;
            positionBox = new List<CheckBox>();
            foreach (PositionItem position in this.positions)
            {
                Panel panel = new Panel();
                CheckBox checkbox = new CheckBox();
                TextBox textbox = new TextBox();
                panel.Location = new Point(0, pixely);
                panel.Size = new Size(560, 25);
                panel.Name = "PositionPanel" + position.positionid.ToString();
                checkbox.Location = new Point(0, 1);
                checkbox.Checked =  false;
                checkbox.Text = " ";
                checkbox.Size = new Size(22, 22);
                checkbox.Name = position.positionid.ToString();
                textbox.Location = new Point(24, 0);
                textbox.ReadOnly = true;
                textbox.Text = position.description + "(" + position.postcode + ")";
                textbox.Size = new Size(536, 22);
                textbox.Name = "PositionTextBox" + position.positionid.ToString();
                this.positionPanel.Controls.Add(panel);
                checkbox.CheckedChanged += new EventHandler(this.MyChechBox_Click);
                panel.Controls.Add(checkbox);
                panel.Controls.Add(textbox);
                pixely += 25;
                positionBox.Add(checkbox);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.succeed = true;
            DBConnector connector = new DBConnector();
            string sql;
            int payid = 0;
            int positionid = 0;
            bool pay_checked = false, position_checked = false;
            foreach (CheckBox checkbox in payBox)
            {
                if (checkbox.Checked)
                {
                    pay_checked = true;
                    payid = Int32.Parse(checkbox.Name);
                    break;
                }
            }
            foreach (CheckBox checkbox in positionBox)
            {
                if (checkbox.Checked)
                {
                    position_checked = true;
                    positionid = Int32.Parse(checkbox.Name);
                    break;
                }
            }
            if (!pay_checked)
            {
                MessageBox.Show("请选择支付方式");
                return;
            }
            else if (!position_checked)
            {
                MessageBox.Show("请选择交易地点");
                return;
            }
            foreach (CartItem item in this.items)
            {
                //Delete cart
                sql = "DELETE FROM CartItem WHERE userid = " + UserInfo.instance.userid + 
                    " AND itemid = " + item.itemid + ";";
                connector.Delete(sql);
                //mark for sold out
                sql = "UPDATE Itemtb SET available = 0 WHERE itemid = " + item.itemid + ";";
                connector.Update(sql);
                //generate a trade record
                sql = "INSERT INTO OrderRecord (positionid, buyerid, itemid, payid) VALUES ("
                    + positionid.ToString() + ", "
                    + UserInfo.instance.userid.ToString() + ", "
                    + item.itemid.ToString() + ","
                    + payid.ToString() + ");";
                connector.Insert(sql);
            }
            connector.Close();
            MainForm.mainForm.mainSearchForm.refresh();
            MainForm.mainForm.orderForm.refresh();
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
            if (checkbox.Text == "")
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
        public int payid;
        public string cardno;
        public bool quickpay;
        public PayItem(int payid, string cardno, bool quickpay)
        {
            this.payid = payid;
            this.cardno = cardno;
            this.quickpay = quickpay;
        }

    }

    public partial class PositionItem
    {
        public int positionid;
        public string postcode;
        public string description;
        public PositionItem(int positionid, string postcode, string description)
        {
            this.positionid = positionid;
            this.postcode = postcode;
            this.description = description;
        }
    }
}
