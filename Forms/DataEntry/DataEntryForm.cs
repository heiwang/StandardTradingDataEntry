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

namespace StandardTradingDataEntry.Forms.DataEntry
{
    public partial class DataEntryForm : Form
    {
        private IProductItem _selectedItem;

        public DataEntryForm()
        {
            InitializeComponent();
            IEnumerable<IProductItem> items = InitializeDummyItems();
            InitializeListItems(items);
            this.AcceptButton = OKbutton;
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
                                                        SelectedItemLabel.Text = item.NickName;
                                                    });
                panel.Controls.Add(button);
                panel.AutoScroll = true;
            }

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

        private void AddOrder(object sender, EventArgs e)
        {
            double quantity = 0.0;
            
            if (_selectedItem == null)
            {
                label1.Text = "Please Select An Item First";
            }
            else if (!Double.TryParse(QuantityBox.Text, out quantity))
            {
                label1.Text = "Cannot parse text as double";
            }
            else
            {
                label1.Text = quantity.ToString();
                QuantityBox.Text = String.Empty;
                ListViewItem orderRow = new ListViewItem(_selectedItem.NickName);
                orderRow.SubItems.Add(_selectedItem.Price.ToString("C2"));
                orderRow.SubItems.Add(quantity.ToString("F2"));
                double subtotal = _selectedItem.Price*quantity;
                orderRow.SubItems.Add(subtotal.ToString("C2"));
                orderListView.Items.Add(orderRow);

            }

           

            SetFocusToTextBox();
        }

        private void SetFocusToTextBox()
        {
            QuantityBox.Focus();
            QuantityBox.SelectionStart = QuantityBox.Text.Length;
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
