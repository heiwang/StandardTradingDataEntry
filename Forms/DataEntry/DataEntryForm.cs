using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StandardTradingDataEntry.DTOs;
using StandardTradingDataEntry.Utility;

namespace StandardTradingDataEntry.Forms.DataEntry
{
    public partial class DataEntryForm : Form
    {
        private IProductItem _selectedItem;
        private ICompanyInfo _selectedCompany;
        private Button _selectedCompanyButton;
        private Button _selectedItemButton;
        private Dictionary<string, IList<IProductOrderInfo>> orders;
        private IList<IProductOrderInfo> currentOrders;

        private ICompanyInfo SelectedCompany
        {
            get { return this._selectedCompany; }
            set
            {
                this.OnSwitchingCompany(_selectedCompany, value);
                this._selectedCompany = value;
            }
        }
        
        private Button SelectedCompanyButton
        {
            get { return this._selectedCompanyButton;}
            set
            {
                if (this._selectedCompanyButton != null)
                {
                    ResetSelectedButton(this._selectedCompanyButton);
                }

                this._selectedCompanyButton = value;
                SetSelectedButton(this._selectedCompanyButton);
            }
        }

        private Button SelectedItemButton
        {
            get { return this._selectedItemButton;}
            set
            {
                if (this._selectedItemButton != null)
                {
                    ResetSelectedButton(this._selectedItemButton);
                }

                this._selectedItemButton = value;
                SetSelectedButton(this._selectedItemButton);
            }
        }

        private void SetSelectedButton(Button button)
        {
            button.FlatAppearance.BorderColor = Color.DarkOrange;
            button.FlatAppearance.BorderSize = 3;
        }

        private void ResetSelectedButton(Button button)
        {
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.BorderSize = 1;
        }

        public DataEntryForm()
        {
            InitializeComponent();
            IEnumerable<IProductItem> items = InitializeDummyItems();
            IEnumerable<ICompanyInfo> companies = InitializeCompanyItems();
            InitializeListItems(items);
            InitializeCompanyFlowPanel(this.companyFlowLayoutPanel1, companies.OrderBy(x => x.Order));
            orders = new Dictionary<string, IList<IProductOrderInfo>>();
            this.AcceptButton = OKbutton;
            errorProvider1.SetIconAlignment(this.OKbutton, ErrorIconAlignment.BottomLeft);
            errorProvider1.SetIconPadding(this.OKbutton, 2);
        }

        private void InitializeListItems(IEnumerable<IProductItem> items)
        {
            InitializeFlowPanel(commonFlowLayout, items.Where<IProductItem>(x => x.Significance >= 0.8));
            InitializeFlowPanel(eggsLayoutPanel1, items.Where<IProductItem>(x => x.Category == ProductCategory.PRODUCT_EGGS));
            InitializeFlowPanel(mushroomLayoutPanel, items.Where<IProductItem>(x => x.Category == ProductCategory.PRODUCT_MUSHROOMS));
            InitializeFlowPanel(beansproutLayoutPanel, items.Where<IProductItem>(x => x.Category == ProductCategory.PRODUCT_BEANSPROUT));
            InitializeFlowPanel(noodleLayoutPanel, items.Where<IProductItem>(x => x.Category == ProductCategory.PRODUCT_NOODLES));
            InitializeFlowPanel(othersLayoutPanel, items.Where<IProductItem>(x => x.Category == ProductCategory.PRODUCT_MISC));
            InitializeFlowPanel(veggieLayoutPanel, items.Where<IProductItem>(x => x.Category == ProductCategory.PRODUCT_VEGETABLE));
            InitializeFlowPanel(allFlowLayoutPanel, items);
        }

        private void InitializeFlowPanel(FlowLayoutPanel panel, IEnumerable<IProductItem> items)
        {
            foreach (IProductItem item in items)
            {
                Button button = new Button();
                button.Text = item.NickName;
                button.BackgroundImage = item.Image;
                button.FlatStyle = FlatStyle.Flat;
                button.ImageAlign = ContentAlignment.MiddleCenter;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Width = button.Height = 120;
                button.Click += new EventHandler((object e, EventArgs e1) =>
                                                    {
                                                        _selectedItem = item;
                                                        SelectedItemButton = button;
                                                    });
                panel.Controls.Add(button);
                panel.AutoScroll = true;
            }

        }

        private void InitializeCompanyFlowPanel(FlowLayoutPanel panel, IEnumerable<ICompanyInfo> companies)
        {
            foreach (ICompanyInfo company in companies)
            {
                Button button = new Button();
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.GhostWhite;
                button.Text = company.NickName;
                button.Width = 270;
                button.Height = 60;
                button.Font = new Font(button.Font.FontFamily, 20);
                button.Margin = new Padding(5);
                button.Click += new EventHandler((object e, EventArgs e1) =>
                {
                    SelectedCompany = company;
                    SelectedCompanyButton = button;
                });
                panel.Controls.Add(button);
                panel.MouseEnter += new EventHandler((object e, EventArgs e1) => { panel.Focus();  });
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.AutoScroll = true;
            }

        }

        private IEnumerable<ICompanyInfo> InitializeCompanyItems()
        {
            List<ICompanyInfo> companies = new List<ICompanyInfo>();

            for (int i = 0; i < 180; i++)
            {
                CompanyInfo info = new CompanyInfo();
                info.EnglishName = "ABCDEF";
                info.Id = i;
                info.NickName = "TestCompany" + i;
                info.Order = 180 - i;

                companies.Add(info);
            }

            return companies;
        }

        private List<IProductItem> InitializeDummyItems()
        {

            List<IProductItem> items = new List<IProductItem>();
            Random randomGen = new Random();
            for (int i = 0; i < 25; i++)
            {
                IProductItem item = new ProductItem();
                item.Category = (ProductCategory)randomGen.Next(1, 7);
                item.NickName = "Test" + i;
                item.Price = 4.50 + i;
                item.ProductId = i;
                item.Significance = randomGen.NextDouble();

                switch (i % 4)
                {
                    case 0:
                        item.Image = Image.FromFile("D:\\StandardTrading\\StandardTradingDataEntry\\resources\\BeanSprout.png");
                        break;
                    case 1:
                        item.Image = Image.FromFile("D:\\StandardTrading\\StandardTradingDataEntry\\resources\\WhiteEgg.png");
                        break;
                    case 2:
                        item.Image = Image.FromFile("D:\\StandardTrading\\StandardTradingDataEntry\\resources\\BrownEgg.png");
                        break;
                    case 3:
                        item.Image = Image.FromFile("D:\\StandardTrading\\StandardTradingDataEntry\\resources\\WhiteMushroom.png");
                        break;
                }

                items.Add(item);
            }
            return items;
        }
        #region calculator
        private void button1_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox("0");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.AppendToQuantityTextBox(".");
        }

        #endregion

        private void AppendToQuantityTextBox(string val)
        {
            QuantityBox.Text = QuantityBox.Text + val;
            SetFocusToTextBox();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (QuantityBox.TextLength > 0)
            {
                QuantityBox.Text = QuantityBox.Text.Remove(QuantityBox.TextLength - 1);
                SetFocusToTextBox();
            }
        }

        private void OnSwitchingCompany(ICompanyInfo originalCompany, ICompanyInfo newCompany)
        {
            SharedUtility.ThrowIfNull(newCompany, "newCompany");

            if (_selectedCompany == null) return;
            
            // store orders for original company
            string key = GetOrderKey(dateTimePicker1.Value, originalCompany);
            
            orders[key] = currentOrders;
            currentOrders = null;

            // Clear the list view
            orderListView.Items.Clear();

            // retrieve orders for new company
            key = GetOrderKey(dateTimePicker1.Value, newCompany);
            if (orders.ContainsKey(key) && orders[key] != null)
            {
               foreach(ProductOrderInfo orderInfo in orders[key])
               {
                   orderListView.Items.Add(this.GetListViewItem(orderInfo.ProductItem, orderInfo.Quantity));
               }

               currentOrders = orders[key];
            }
        }

        private void OnClick_OK(object sender, EventArgs e)
        {
            double quantity = 0.0;
            
            if (_selectedItem == null)
            {
                errorProvider1.SetError(this.OKbutton, "Please Select An Item First");
            }
            else if (!Double.TryParse(QuantityBox.Text, out quantity))
            {
                errorProvider1.SetError(this.OKbutton, "Cannot parse text as double");
            }
            else
            {
                errorProvider1.SetError(this.OKbutton, String.Empty);
                QuantityBox.Text = String.Empty;
                orderListView.Items.Add(this.GetListViewItem(_selectedItem, quantity));
                IProductOrderInfo order = GetProductOrder(dateTimePicker1.Value, SelectedCompany, _selectedItem, quantity);

                if (currentOrders == null)
                {
                    currentOrders = new List<IProductOrderInfo>();
                }

                currentOrders.Add(order);
               
            }

            SetFocusToTextBox();
        }

        private string GetOrderKey(DateTime date, ICompanyInfo company)
        {
            SharedUtility.ThrowIfNull(date, "date");
            SharedUtility.ThrowIfNull(company, "company");
            return date.ToShortDateString() + company.NickName + company.Id;
        }
        private ListViewItem GetListViewItem(IProductItem _selectedItem, double quantity)
        {
            ListViewItem orderRow = new ListViewItem(_selectedItem.NickName);
            orderRow.SubItems.Add(_selectedItem.Price.ToString("C2"));
            orderRow.SubItems.Add(quantity.ToString());
            double subtotal = _selectedItem.Price * quantity;
            orderRow.SubItems.Add(subtotal.ToString("C2"));
            return orderRow;
        }

        private IProductOrderInfo GetProductOrder(DateTime date, ICompanyInfo company, IProductItem item, double quantity)
        {
            SharedUtility.ThrowIfNull(date, "date");
            SharedUtility.ThrowIfNull(company, "company");
            SharedUtility.ThrowIfNull(item, "item");

            ProductOrderInfo order = new ProductOrderInfo();
            order.OrderDate = date;
            order.ProductItem = item;
            order.Quantity = quantity;
            order.Company = company;
            return order;
        }


        private void SetFocusToTextBox()
        {
            QuantityBox.Focus();
            QuantityBox.SelectionStart = QuantityBox.Text.Length;
        }

        private void FastRewindBtn_Click(object sender, EventArgs e)
        {
            this.companyFlowLayoutPanel1.AutoScrollPosition = new Point(0, companyFlowLayoutPanel1.VerticalScroll.Minimum);
        }

        private void FastFwdBtn_Click(object sender, EventArgs e)
        {
            this.companyFlowLayoutPanel1.AutoScrollPosition = new Point(0, companyFlowLayoutPanel1.VerticalScroll.Maximum);
        }

        private void RewindBtn_Click(object sender, EventArgs e)
        {
            // Find the bigger of the two scroll positions
            int pos = Math.Max(companyFlowLayoutPanel1.VerticalScroll.Minimum, companyFlowLayoutPanel1.VerticalScroll.Value - companyFlowLayoutPanel1.Height + 65);
            this.companyFlowLayoutPanel1.AutoScrollPosition = new Point(0, pos);
        }

        private void FwdBtn_Click(object sender, EventArgs e)
        {
            // Find the smaller of the two scroll positions
            int pos = Math.Min(companyFlowLayoutPanel1.VerticalScroll.Maximum, companyFlowLayoutPanel1.VerticalScroll.Value + companyFlowLayoutPanel1.Height - 65);
            this.companyFlowLayoutPanel1.AutoScrollPosition = new Point(0, pos);
        }

    }
}
