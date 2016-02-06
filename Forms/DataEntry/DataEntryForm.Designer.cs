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
            this.orderListView = new System.Windows.Forms.ListView();
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.como.SuspendLayout();
            this.common.SuspendLayout();
            this.eggs.SuspendLayout();
            this.mushrooms.SuspendLayout();
            this.beansprout.SuspendLayout();
            this.vegetables.SuspendLayout();
            this.noodles.SuspendLayout();
            this.others.SuspendLayout();
            this.all.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Price,
            this.Quantity,
            this.SubTotal});
            this.orderListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListView.GridLines = true;
            this.orderListView.Location = new System.Drawing.Point(19, 56);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(684, 393);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            this.orderListView.SelectedIndexChanged += new System.EventHandler(this.orderListView_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 6;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(870, 567);
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
            this.button2.Location = new System.Drawing.Point(961, 567);
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
            this.button3.Location = new System.Drawing.Point(1052, 567);
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
            this.button4.Location = new System.Drawing.Point(1052, 658);
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
            this.button5.Location = new System.Drawing.Point(961, 658);
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
            this.button6.Location = new System.Drawing.Point(870, 658);
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
            this.button7.Location = new System.Drawing.Point(1052, 749);
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
            this.button8.Location = new System.Drawing.Point(961, 749);
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
            this.button9.Location = new System.Drawing.Point(870, 749);
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
            this.OKbutton.Location = new System.Drawing.Point(1143, 658);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(93, 267);
            this.OKbutton.TabIndex = 12;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = false;
            this.OKbutton.Click += new System.EventHandler(this.AddOrder);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button11.FlatAppearance.BorderSize = 6;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button11.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(870, 840);
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
            this.button12.Location = new System.Drawing.Point(1143, 567);
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
            this.button13.Location = new System.Drawing.Point(1052, 840);
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
            this.QuantityBox.Location = new System.Drawing.Point(870, 469);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(366, 81);
            this.QuantityBox.TabIndex = 14;
            this.QuantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1117, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
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
            this.como.Location = new System.Drawing.Point(19, 469);
            this.como.Name = "como";
            this.como.SelectedIndex = 0;
            this.como.Size = new System.Drawing.Size(798, 456);
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
            this.common.Size = new System.Drawing.Size(790, 363);
            this.common.TabIndex = 0;
            this.common.Text = "常用";
            this.common.UseVisualStyleBackColor = true;
            // 
            // commonFlowLayout
            // 
            this.commonFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.commonFlowLayout.Name = "commonFlowLayout";
            this.commonFlowLayout.Size = new System.Drawing.Size(784, 357);
            this.commonFlowLayout.TabIndex = 0;
            // 
            // eggs
            // 
            this.eggs.Controls.Add(this.eggsLayoutPanel1);
            this.eggs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggs.Location = new System.Drawing.Point(4, 89);
            this.eggs.Name = "eggs";
            this.eggs.Padding = new System.Windows.Forms.Padding(3);
            this.eggs.Size = new System.Drawing.Size(790, 363);
            this.eggs.TabIndex = 1;
            this.eggs.Text = "雞蛋";
            this.eggs.UseVisualStyleBackColor = true;
            // 
            // eggsLayoutPanel1
            // 
            this.eggsLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eggsLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.eggsLayoutPanel1.Name = "eggsLayoutPanel1";
            this.eggsLayoutPanel1.Size = new System.Drawing.Size(784, 357);
            this.eggsLayoutPanel1.TabIndex = 1;
            // 
            // mushrooms
            // 
            this.mushrooms.Controls.Add(this.mushroomLayoutPanel);
            this.mushrooms.Location = new System.Drawing.Point(4, 89);
            this.mushrooms.Name = "mushrooms";
            this.mushrooms.Size = new System.Drawing.Size(790, 363);
            this.mushrooms.TabIndex = 2;
            this.mushrooms.Text = "蘑菇";
            this.mushrooms.UseVisualStyleBackColor = true;
            // 
            // mushroomLayoutPanel
            // 
            this.mushroomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mushroomLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mushroomLayoutPanel.Name = "mushroomLayoutPanel";
            this.mushroomLayoutPanel.Size = new System.Drawing.Size(790, 363);
            this.mushroomLayoutPanel.TabIndex = 1;
            // 
            // beansprout
            // 
            this.beansprout.Controls.Add(this.beansproutLayoutPanel);
            this.beansprout.Location = new System.Drawing.Point(4, 89);
            this.beansprout.Name = "beansprout";
            this.beansprout.Size = new System.Drawing.Size(790, 363);
            this.beansprout.TabIndex = 5;
            this.beansprout.Text = "芽/豆";
            this.beansprout.UseVisualStyleBackColor = true;
            // 
            // beansproutLayoutPanel
            // 
            this.beansproutLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beansproutLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.beansproutLayoutPanel.Name = "beansproutLayoutPanel";
            this.beansproutLayoutPanel.Size = new System.Drawing.Size(790, 363);
            this.beansproutLayoutPanel.TabIndex = 1;
            // 
            // vegetables
            // 
            this.vegetables.Controls.Add(this.veggieLayoutPanel);
            this.vegetables.Location = new System.Drawing.Point(4, 89);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(790, 363);
            this.vegetables.TabIndex = 3;
            this.vegetables.Text = "蔬菜";
            this.vegetables.UseVisualStyleBackColor = true;
            // 
            // veggieLayoutPanel
            // 
            this.veggieLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.veggieLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.veggieLayoutPanel.Name = "veggieLayoutPanel";
            this.veggieLayoutPanel.Size = new System.Drawing.Size(790, 363);
            this.veggieLayoutPanel.TabIndex = 1;
            // 
            // noodles
            // 
            this.noodles.Controls.Add(this.noodleLayoutPanel);
            this.noodles.Location = new System.Drawing.Point(4, 89);
            this.noodles.Name = "noodles";
            this.noodles.Size = new System.Drawing.Size(790, 363);
            this.noodles.TabIndex = 4;
            this.noodles.Text = "麵";
            this.noodles.UseVisualStyleBackColor = true;
            // 
            // noodleLayoutPanel
            // 
            this.noodleLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noodleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.noodleLayoutPanel.Name = "noodleLayoutPanel";
            this.noodleLayoutPanel.Size = new System.Drawing.Size(790, 363);
            this.noodleLayoutPanel.TabIndex = 1;
            // 
            // others
            // 
            this.others.Controls.Add(this.othersLayoutPanel);
            this.others.Location = new System.Drawing.Point(4, 89);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(790, 363);
            this.others.TabIndex = 6;
            this.others.Text = "其他";
            this.others.UseVisualStyleBackColor = true;
            // 
            // othersLayoutPanel
            // 
            this.othersLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.othersLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.othersLayoutPanel.Name = "othersLayoutPanel";
            this.othersLayoutPanel.Size = new System.Drawing.Size(790, 363);
            this.othersLayoutPanel.TabIndex = 1;
            // 
            // all
            // 
            this.all.Controls.Add(this.allFlowLayoutPanel);
            this.all.Location = new System.Drawing.Point(4, 89);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(790, 363);
            this.all.TabIndex = 7;
            this.all.Text = "全部";
            this.all.UseVisualStyleBackColor = true;
            // 
            // allFlowLayoutPanel
            // 
            this.allFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.allFlowLayoutPanel.Name = "allFlowLayoutPanel";
            this.allFlowLayoutPanel.Size = new System.Drawing.Size(790, 363);
            this.allFlowLayoutPanel.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 44);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(1076, 151);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(93, 33);
            this.SelectedItemLabel.TabIndex = 19;
            this.SelectedItemLabel.Text = "label3";
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "SubTotal";
            this.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubTotal.Width = 220;
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1254, 936);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.como);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.DataEntryForm_Load);
            this.como.ResumeLayout(false);
            this.common.ResumeLayout(false);
            this.eggs.ResumeLayout(false);
            this.mushrooms.ResumeLayout(false);
            this.beansprout.ResumeLayout(false);
            this.vegetables.ResumeLayout(false);
            this.noodles.ResumeLayout(false);
            this.others.ResumeLayout(false);
            this.all.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader SubTotal;
    }
}