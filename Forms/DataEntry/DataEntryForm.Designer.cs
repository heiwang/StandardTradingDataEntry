namespace StandardTradingDataEntry.Forms.DataEntry
{
    partial class DataEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderListView = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.como = new System.Windows.Forms.TabControl();
            this.common = new System.Windows.Forms.TabPage();
            this.commonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.eggs = new System.Windows.Forms.TabPage();
            this.eggsLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mushrooms = new System.Windows.Forms.TabPage();
            this.mushroomLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.beansprout = new System.Windows.Forms.TabPage();
            this.beansproutLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vegetables = new System.Windows.Forms.TabPage();
            this.veggieLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.noodles = new System.Windows.Forms.TabPage();
            this.noodleLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.others = new System.Windows.Forms.TabPage();
            this.othersLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.all = new System.Windows.Forms.TabPage();
            this.allFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FastFwdBtn = new System.Windows.Forms.Button();
            this.FwdBtn = new System.Windows.Forms.Button();
            this.RewindBtn = new System.Windows.Forms.Button();
            this.FastRewindBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyGroup = new System.Windows.Forms.GroupBox();
            this.companyFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.como.SuspendLayout();
            this.common.SuspendLayout();
            this.eggs.SuspendLayout();
            this.mushrooms.SuspendLayout();
            this.beansprout.SuspendLayout();
            this.vegetables.SuspendLayout();
            this.noodles.SuspendLayout();
            this.others.SuspendLayout();
            this.all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.CompanyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Price,
            this.Quantity,
            this.Subtotal});
            this.orderListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListView.GridLines = true;
            this.orderListView.Location = new System.Drawing.Point(344, 27);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(501, 456);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 165;
            // 
            // Price
            // 
            this.Price.Text = "Unit Price";
            this.Price.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Qty";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 80;
            // 
            // Subtotal
            // 
            this.Subtotal.Text = "SubTotal";
            this.Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Subtotal.Width = 132;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 6;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(876, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 6;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(967, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 85);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 6;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1058, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 85);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 6;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1058, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 85);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 6;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(967, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 85);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 6;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(876, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 85);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 6;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1058, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 85);
            this.button7.TabIndex = 9;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 6;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(967, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 85);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.BorderSize = 6;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(876, 307);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 85);
            this.button9.TabIndex = 7;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.BackColor = System.Drawing.SystemColors.Control;
            this.OKbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OKbutton.FlatAppearance.BorderSize = 6;
            this.OKbutton.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.OKbutton.ForeColor = System.Drawing.Color.OliveDrab;
            this.OKbutton.Location = new System.Drawing.Point(1149, 216);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(93, 267);
            this.OKbutton.TabIndex = 12;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.OnClick_OK);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.BorderSize = 6;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(876, 398);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(176, 85);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button12.FlatAppearance.BorderSize = 6;
            this.button12.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.button12.ForeColor = System.Drawing.Color.Maroon;
            this.button12.Location = new System.Drawing.Point(1149, 125);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(93, 85);
            this.button12.TabIndex = 10;
            this.button12.Text = "DEL";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.Control;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatAppearance.BorderSize = 6;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button13.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(1058, 398);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 85);
            this.button13.TabIndex = 13;
            this.button13.Text = ".";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // QuantityBox
            // 
            this.QuantityBox.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBox.Location = new System.Drawing.Point(876, 27);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(366, 81);
            this.QuantityBox.TabIndex = 14;
            this.QuantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // como
            // 
            this.como.Controls.Add(this.common);
            this.como.Controls.Add(this.eggs);
            this.como.Controls.Add(this.mushrooms);
            this.como.Controls.Add(this.beansprout);
            this.como.Controls.Add(this.vegetables);
            this.como.Controls.Add(this.noodles);
            this.como.Controls.Add(this.others);
            this.como.Controls.Add(this.all);
            this.como.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.como.ItemSize = new System.Drawing.Size(90, 85);
            this.como.Location = new System.Drawing.Point(344, 537);
            this.como.Name = "como";
            this.como.SelectedIndex = 0;
            this.como.Size = new System.Drawing.Size(898, 390);
            this.como.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.como.TabIndex = 16;
            // 
            // common
            // 
            this.common.Controls.Add(this.commonFlowLayout);
            this.common.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.common.Location = new System.Drawing.Point(4, 89);
            this.common.Name = "common";
            this.common.Padding = new System.Windows.Forms.Padding(3);
            this.common.Size = new System.Drawing.Size(890, 297);
            this.common.TabIndex = 0;
            this.common.Text = "常用";
            this.common.UseVisualStyleBackColor = true;
            // 
            // commonFlowLayout
            // 
            this.commonFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.commonFlowLayout.Name = "commonFlowLayout";
            this.commonFlowLayout.Size = new System.Drawing.Size(884, 291);
            this.commonFlowLayout.TabIndex = 0;
            // 
            // eggs
            // 
            this.eggs.Controls.Add(this.eggsLayoutPanel1);
            this.eggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggs.Location = new System.Drawing.Point(4, 89);
            this.eggs.Name = "eggs";
            this.eggs.Padding = new System.Windows.Forms.Padding(3);
            this.eggs.Size = new System.Drawing.Size(890, 297);
            this.eggs.TabIndex = 1;
            this.eggs.Text = "雞蛋";
            this.eggs.UseVisualStyleBackColor = true;
            // 
            // eggsLayoutPanel1
            // 
            this.eggsLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eggsLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.eggsLayoutPanel1.Name = "eggsLayoutPanel1";
            this.eggsLayoutPanel1.Size = new System.Drawing.Size(884, 291);
            this.eggsLayoutPanel1.TabIndex = 1;
            // 
            // mushrooms
            // 
            this.mushrooms.Controls.Add(this.mushroomLayoutPanel);
            this.mushrooms.Location = new System.Drawing.Point(4, 89);
            this.mushrooms.Name = "mushrooms";
            this.mushrooms.Size = new System.Drawing.Size(890, 297);
            this.mushrooms.TabIndex = 2;
            this.mushrooms.Text = "蘑菇";
            this.mushrooms.UseVisualStyleBackColor = true;
            // 
            // mushroomLayoutPanel
            // 
            this.mushroomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mushroomLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mushroomLayoutPanel.Name = "mushroomLayoutPanel";
            this.mushroomLayoutPanel.Size = new System.Drawing.Size(890, 297);
            this.mushroomLayoutPanel.TabIndex = 1;
            // 
            // beansprout
            // 
            this.beansprout.Controls.Add(this.beansproutLayoutPanel);
            this.beansprout.Location = new System.Drawing.Point(4, 89);
            this.beansprout.Name = "beansprout";
            this.beansprout.Size = new System.Drawing.Size(890, 297);
            this.beansprout.TabIndex = 5;
            this.beansprout.Text = "芽/豆";
            this.beansprout.UseVisualStyleBackColor = true;
            // 
            // beansproutLayoutPanel
            // 
            this.beansproutLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beansproutLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.beansproutLayoutPanel.Name = "beansproutLayoutPanel";
            this.beansproutLayoutPanel.Size = new System.Drawing.Size(890, 297);
            this.beansproutLayoutPanel.TabIndex = 1;
            // 
            // vegetables
            // 
            this.vegetables.Controls.Add(this.veggieLayoutPanel);
            this.vegetables.Location = new System.Drawing.Point(4, 89);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(890, 297);
            this.vegetables.TabIndex = 3;
            this.vegetables.Text = "蔬菜";
            this.vegetables.UseVisualStyleBackColor = true;
            // 
            // veggieLayoutPanel
            // 
            this.veggieLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.veggieLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.veggieLayoutPanel.Name = "veggieLayoutPanel";
            this.veggieLayoutPanel.Size = new System.Drawing.Size(890, 297);
            this.veggieLayoutPanel.TabIndex = 1;
            // 
            // noodles
            // 
            this.noodles.Controls.Add(this.noodleLayoutPanel);
            this.noodles.Location = new System.Drawing.Point(4, 89);
            this.noodles.Name = "noodles";
            this.noodles.Size = new System.Drawing.Size(890, 297);
            this.noodles.TabIndex = 4;
            this.noodles.Text = "麵";
            this.noodles.UseVisualStyleBackColor = true;
            // 
            // noodleLayoutPanel
            // 
            this.noodleLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noodleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.noodleLayoutPanel.Name = "noodleLayoutPanel";
            this.noodleLayoutPanel.Size = new System.Drawing.Size(890, 297);
            this.noodleLayoutPanel.TabIndex = 1;
            // 
            // others
            // 
            this.others.Controls.Add(this.othersLayoutPanel);
            this.others.Location = new System.Drawing.Point(4, 89);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(890, 297);
            this.others.TabIndex = 6;
            this.others.Text = "其他";
            this.others.UseVisualStyleBackColor = true;
            // 
            // othersLayoutPanel
            // 
            this.othersLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.othersLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.othersLayoutPanel.Name = "othersLayoutPanel";
            this.othersLayoutPanel.Size = new System.Drawing.Size(890, 297);
            this.othersLayoutPanel.TabIndex = 1;
            // 
            // all
            // 
            this.all.Controls.Add(this.allFlowLayoutPanel);
            this.all.Location = new System.Drawing.Point(4, 89);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(890, 297);
            this.all.TabIndex = 7;
            this.all.Text = "全部";
            this.all.UseVisualStyleBackColor = true;
            // 
            // allFlowLayoutPanel
            // 
            this.allFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.allFlowLayoutPanel.Name = "allFlowLayoutPanel";
            this.allFlowLayoutPanel.Size = new System.Drawing.Size(890, 297);
            this.allFlowLayoutPanel.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FastFwdBtn
            // 
            this.FastFwdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FastFwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FastFwdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastFwdBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.errorProvider1.SetIconAlignment(this.FastFwdBtn, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.FastFwdBtn.Location = new System.Drawing.Point(240, 764);
            this.FastFwdBtn.Name = "FastFwdBtn";
            this.FastFwdBtn.Size = new System.Drawing.Size(65, 65);
            this.FastFwdBtn.TabIndex = 31;
            this.FastFwdBtn.Text = ">>";
            this.FastFwdBtn.UseVisualStyleBackColor = true;
            this.FastFwdBtn.Click += new System.EventHandler(this.FastFwdBtn_Click);
            // 
            // FwdBtn
            // 
            this.FwdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FwdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FwdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FwdBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.errorProvider1.SetIconAlignment(this.FwdBtn, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.FwdBtn.Location = new System.Drawing.Point(169, 764);
            this.FwdBtn.Name = "FwdBtn";
            this.FwdBtn.Size = new System.Drawing.Size(65, 65);
            this.FwdBtn.TabIndex = 30;
            this.FwdBtn.Text = ">";
            this.FwdBtn.UseVisualStyleBackColor = true;
            this.FwdBtn.Click += new System.EventHandler(this.FwdBtn_Click);
            // 
            // RewindBtn
            // 
            this.RewindBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RewindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RewindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewindBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.errorProvider1.SetIconAlignment(this.RewindBtn, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.RewindBtn.Location = new System.Drawing.Point(77, 764);
            this.RewindBtn.Name = "RewindBtn";
            this.RewindBtn.Size = new System.Drawing.Size(65, 65);
            this.RewindBtn.TabIndex = 29;
            this.RewindBtn.Text = "<";
            this.RewindBtn.UseVisualStyleBackColor = true;
            this.RewindBtn.Click += new System.EventHandler(this.RewindBtn_Click);
            // 
            // FastRewindBtn
            // 
            this.FastRewindBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FastRewindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FastRewindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastRewindBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.errorProvider1.SetIconAlignment(this.FastRewindBtn, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.FastRewindBtn.Location = new System.Drawing.Point(6, 764);
            this.FastRewindBtn.Name = "FastRewindBtn";
            this.FastRewindBtn.Size = new System.Drawing.Size(65, 65);
            this.FastRewindBtn.TabIndex = 28;
            this.FastRewindBtn.Text = "<<";
            this.FastRewindBtn.UseVisualStyleBackColor = true;
            this.FastRewindBtn.Click += new System.EventHandler(this.FastRewindBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Company: ";
            // 
            // CompanyGroup
            // 
            this.CompanyGroup.Controls.Add(this.companyFlowLayoutPanel1);
            this.CompanyGroup.Controls.Add(this.FastFwdBtn);
            this.CompanyGroup.Controls.Add(this.FwdBtn);
            this.CompanyGroup.Controls.Add(this.RewindBtn);
            this.CompanyGroup.Controls.Add(this.FastRewindBtn);
            this.CompanyGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyGroup.Location = new System.Drawing.Point(18, 89);
            this.CompanyGroup.Name = "CompanyGroup";
            this.CompanyGroup.Size = new System.Drawing.Size(311, 831);
            this.CompanyGroup.TabIndex = 27;
            this.CompanyGroup.TabStop = false;
            this.CompanyGroup.Text = "Company";
            // 
            // companyFlowLayoutPanel1
            // 
            this.companyFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.companyFlowLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.companyFlowLayoutPanel1.Name = "companyFlowLayoutPanel1";
            this.companyFlowLayoutPanel1.Size = new System.Drawing.Size(305, 718);
            this.companyFlowLayoutPanel1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 44);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1254, 936);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CompanyGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.como);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderListView);
            this.Name = "DataEntryForm";
            this.Text = "DataEntryForm";
            this.como.ResumeLayout(false);
            this.common.ResumeLayout(false);
            this.eggs.ResumeLayout(false);
            this.mushrooms.ResumeLayout(false);
            this.beansprout.ResumeLayout(false);
            this.vegetables.ResumeLayout(false);
            this.noodles.ResumeLayout(false);
            this.others.ResumeLayout(false);
            this.all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.CompanyGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox QuantityBox;
        private System.Windows.Forms.TabControl como;
        private System.Windows.Forms.TabPage common;
        private System.Windows.Forms.TabPage eggs;
        private System.Windows.Forms.TabPage mushrooms;
        private System.Windows.Forms.TabPage vegetables;
        private System.Windows.Forms.TabPage noodles;
        private System.Windows.Forms.TabPage beansprout;
        private System.Windows.Forms.TabPage others;
        private System.Windows.Forms.TabPage all;
        private System.Windows.Forms.FlowLayoutPanel commonFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel eggsLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel mushroomLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel beansproutLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel veggieLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel noodleLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel othersLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel allFlowLayoutPanel;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CompanyGroup;
        private System.Windows.Forms.FlowLayoutPanel companyFlowLayoutPanel1;
        private System.Windows.Forms.Button FastFwdBtn;
        private System.Windows.Forms.Button FwdBtn;
        private System.Windows.Forms.Button RewindBtn;
        private System.Windows.Forms.Button FastRewindBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}