namespace StandardTradingDataEntry
{
    partial class StandardTradingRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public StandardTradingRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.productTableAdapter1 = new StandardTradingDataEntry.StandardTradingDbDataSet1TableAdapters.ProductTableAdapter();
            this.EditCompanyButton = this.Factory.CreateRibbonButton();
            this.EditProductButton = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.EditCompanyButton);
            this.group1.Items.Add(this.EditProductButton);
            this.group1.Items.Add(this.button1);
            this.group1.Label = "Metadata";
            this.group1.Name = "group1";
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // EditCompanyButton
            // 
            this.EditCompanyButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.EditCompanyButton.Image = global::StandardTradingDataEntry.Properties.Resources.AddCompany;
            this.EditCompanyButton.Label = "Add/Remove Company";
            this.EditCompanyButton.Name = "EditCompanyButton";
            this.EditCompanyButton.ScreenTip = "Click this to add, remove, or update company details";
            this.EditCompanyButton.ShowImage = true;
            this.EditCompanyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EditCompanyButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.EditProductButton.Image = global::StandardTradingDataEntry.Properties.Resources.AddProduct;
            this.EditProductButton.Label = "Add/Remove Products";
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.ShowImage = true;
            this.EditProductButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.EditProductButton_Click);
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::StandardTradingDataEntry.Properties.Resources.ChangePrice;
            this.button1.Label = "Update Product Pricing";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            // 
            // StandardTradingRibbon
            // 
            this.Name = "StandardTradingRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EditCompanyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton EditProductButton;
        private StandardTradingDbDataSet1TableAdapters.ProductTableAdapter productTableAdapter1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal StandardTradingRibbon Ribbon1
        {
            get { return this.GetRibbon<StandardTradingRibbon>(); }
        }
    }
}
