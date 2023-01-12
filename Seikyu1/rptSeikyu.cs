using GrapeCity.ActiveReports.Document;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports;
using System;
using System.Drawing;



namespace Seikyu
{
    public class rptSeikyu : GrapeCity.ActiveReports.SectionReport
    {
        public rptSeikyu()
        {
            InitializeComponent();
        }

        private long m_RecCnt;
        private long m_Pages;
        private Detail Detail;
        private Shape shpDetailBack;
        private TextBox txtSlipNo;
        private TextBox txtDate;
        private TextBox txtNumber;
        private TextBox txtUnitPrice;
        private TextBox txtCategory;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private PageHeader PageHeader;
        private Shape shpTitle;
        private Label lblTitle;
        private Label lblBillNo;
        private TextBox txtBillNo;
        private TextBox txtCustomerName;
        private Label lblHonorific;
        private TextBox txtBillTotal;
        private Label lblThanks_2;
        private Label lblBillTotal_Yen;
        private Picture imgCrown;
        private TextBox txtYear;
        private Label lblYear;
        private TextBox txtMonth;
        private Label lblMonth;
        private TextBox txtDay;
        private Label lblDay;
        private Label lblDeadline;
        private Label lblCompanyName;
        private Label lblHQ;
        private Label lblAddress_HQ;
        private Label lblTEL_HQ;
        private Label lblFAX_HQ;
        private Label lblZipCode_HQ;
        private Label lblURL_HQ;
        private Label lblThanks_1;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Label lblBillTotal;
        private Shape shpBillTotal;
        private Line linCustomerName;
        private Label lblPreInvoice;
        private Label lblPreIncome;
        private Label lblCarryOver;
        private Label lblTotal;
        private Label lblExcise;
        private TextBox txtPreInvoice;
        private TextBox txtPreIncome;
        private TextBox txtCarryOver;
        private TextBox txtTotal;
        private TextBox txtExcise;
        private Shape shpSummary;
        private PageFooter PageFooter;
        private Shape Shape30;
        private Label Label40;
        private Label Label44;
        private Label Label41;
        private Label Label42;
        private Label Label43;
        private Label Label45;
        private Label Label46;
        private Label Label47;
        private Label Label48;
        private Label Label49;
        private GroupHeader ghColumnCaption;
        private CrossSectionLine cslLine2;
        private Label Label30;
        private Label Label34;
        private Label Label35;
        private Label Label36;
        private Label Label31;
        private Label Label32;
        private Label Label33;
        private CrossSectionLine cslLine4;
        private CrossSectionLine cslLine1;
        private CrossSectionLine cslLine3;
        private CrossSectionLine cslLine6;
        private CrossSectionLine cslLine5;
        private CrossSectionBox csbDetails;
        private GroupFooter gfColumnCaption;

        private int iRow;
        //private int iCnt;	// çsî‘çÜ

        private void Detail_Format(object sender, System.EventArgs eArgs)
        {
            // çsî‘çÜÇÉCÉìÉNÉäÉÅÉìÉgÇµÇ‹Ç∑ÅB
            iRow++;

            // ÇPçsÇ≤Ç∆Ç…îwåiêFÇêÿÇËë÷Ç¶Ç‹Ç∑ÅB
            if ((iRow % 2) == 1)
            {
                this.shpDetailBack.BackColor = Color.White; // îíêF
            }
            else
            {
                this.shpDetailBack.BackColor = Color.LightYellow;   // â©êF
            }
        }

        private void rptSeikyu_DataInitialize(object sender, System.EventArgs eArgs)
        {
            // âøäiÇï\é¶Ç∑ÇÈÇΩÇﬂÇÃÉAÉìÉoÉEÉìÉhÉtÉBÅ[ÉãÉhÇçÏê¨ÇµÇ‹Ç∑ÅB
            this.Fields.Add("Price");
        }

        private void rptSeikyu_FetchData(object sender, GrapeCity.ActiveReports.SectionReport.FetchEventArgs eArgs)
        {
            // ÉAÉìÉoÉEÉìÉhÉtÉBÅ[ÉãÉhÇÃílÇê›íËÇµÇ‹Ç∑ÅB
            this.Fields["Price"].Value = Convert.ToInt32((this.Fields["Number"].Value))
                                        * Convert.ToInt32((this.Fields["UnitPrice"].Value));
        }

        private void PageHeader_BeforePrint(object sender, System.EventArgs eArgs)
        {
            // èWåvílÇéQè∆ÇµÇƒÅAï ÇÃ Field ÉRÉìÉgÉçÅ[ÉãÇ…ílÇê›íËÇµÇ‹Ç∑ÅB
            txtExcise.Value = (object)((double)txtTotal.Value * 0.05);  // è¡îÔê≈äz
            txtBillTotal.Value = (object)((double)this.txtTotal.Value * 1.05 + (double)this.txtCarryOver.Value);    // êøãÅäzçáåv
        }

        #region ActiveReports Designer generated code

        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSeikyu));
            this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
            this.shpDetailBack = new GrapeCity.ActiveReports.SectionReportModel.Shape();
            this.txtSlipNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtNumber = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtCategory = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
            this.shpTitle = new GrapeCity.ActiveReports.SectionReportModel.Shape();
            this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblBillNo = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtBillNo = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtCustomerName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblHonorific = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtBillTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblThanks_2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblBillTotal_Yen = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.imgCrown = new GrapeCity.ActiveReports.SectionReportModel.Picture();
            this.txtYear = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblYear = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtMonth = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblMonth = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtDay = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblDay = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblDeadline = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblCompanyName = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblHQ = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblAddress_HQ = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTEL_HQ = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblFAX_HQ = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblZipCode_HQ = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblURL_HQ = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblThanks_1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblCustomerID = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtCustomerID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.lblBillTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.shpBillTotal = new GrapeCity.ActiveReports.SectionReportModel.Shape();
            this.linCustomerName = new GrapeCity.ActiveReports.SectionReportModel.Line();
            this.lblPreInvoice = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblPreIncome = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblCarryOver = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.lblExcise = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.txtPreInvoice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtPreIncome = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtCarryOver = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.txtExcise = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
            this.shpSummary = new GrapeCity.ActiveReports.SectionReportModel.Shape();
            this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
            this.Shape30 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
            this.Label40 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label44 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label41 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label42 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label43 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label45 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label46 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label47 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label48 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label49 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.ghColumnCaption = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
            this.cslLine2 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.Label30 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label34 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label35 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label36 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label31 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label32 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.Label33 = new GrapeCity.ActiveReports.SectionReportModel.Label();
            this.cslLine4 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.cslLine1 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.cslLine3 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.cslLine6 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.cslLine5 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
            this.csbDetails = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox();
            this.gfColumnCaption = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
            ((System.ComponentModel.ISupportInitialize)(this.txtSlipNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHonorific)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThanks_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillTotal_Yen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDeadline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCompanyName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress_HQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTEL_HQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFAX_HQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZipCode_HQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblURL_HQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThanks_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPreInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPreIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCarryOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExcise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarryOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.CanGrow = false;
            this.Detail.ColumnSpacing = 0F;
            this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.shpDetailBack,
            this.txtSlipNo,
            this.txtDate,
            this.txtNumber,
            this.txtUnitPrice,
            this.txtCategory,
            this.txtProductName,
            this.txtPrice});
            this.Detail.Height = 0.2F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.RepeatToFill = true;
            // 
            // shpDetailBack
            // 
            this.shpDetailBack.Height = 0.198F;
            this.shpDetailBack.Left = 0F;
            this.shpDetailBack.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Transparent;
            this.shpDetailBack.Name = "shpDetailBack";
            this.shpDetailBack.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(0F);
            this.shpDetailBack.Top = 0F;
            this.shpDetailBack.Width = 5.96F;
            // 
            // txtSlipNo
            // 
            this.txtSlipNo.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtSlipNo.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtSlipNo.CanGrow = false;
            this.txtSlipNo.DataField = "SlipNo";
            this.txtSlipNo.Height = 0.198F;
            this.txtSlipNo.Left = 0.687F;
            this.txtSlipNo.Name = "txtSlipNo";
            this.txtSlipNo.Style = "vertical-align: middle; font-size: 9pt; text-align: center";
            this.txtSlipNo.Text = "SlipNo";
            this.txtSlipNo.Top = 0F;
            this.txtSlipNo.Width = 0.625F;
            // 
            // txtDate
            // 
            this.txtDate.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtDate.CanGrow = false;
            this.txtDate.DataField = "Date";
            this.txtDate.Height = 0.198F;
            this.txtDate.Left = 0.005F;
            this.txtDate.Name = "txtDate";
            this.txtDate.OutputFormat = resources.GetString("txtDate.OutputFormat");
            this.txtDate.Style = "font-size: 9pt; text-align: center; vertical-align: middle";
            this.txtDate.Text = "Date";
            this.txtDate.Top = 0F;
            this.txtDate.Width = 0.682F;
            // 
            // txtNumber
            // 
            this.txtNumber.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtNumber.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtNumber.CanGrow = false;
            this.txtNumber.DataField = "Number";
            this.txtNumber.Height = 0.198F;
            this.txtNumber.Left = 4.312F;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.OutputFormat = resources.GetString("txtNumber.OutputFormat");
            this.txtNumber.Style = "text-align: right; font-size: 9pt; vertical-align: middle";
            this.txtNumber.Text = "Number";
            this.txtNumber.Top = 0F;
            this.txtNumber.Width = 0.75F;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtUnitPrice.CanGrow = false;
            this.txtUnitPrice.DataField = "UnitPrice";
            this.txtUnitPrice.Height = 0.198F;
            this.txtUnitPrice.Left = 3.687F;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.OutputFormat = resources.GetString("txtUnitPrice.OutputFormat");
            this.txtUnitPrice.Style = "text-align: right; font-size: 9pt; vertical-align: middle";
            this.txtUnitPrice.Text = "UnitPrice";
            this.txtUnitPrice.Top = 0F;
            this.txtUnitPrice.Width = 0.625F;
            // 
            // txtCategory
            // 
            this.txtCategory.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCategory.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtCategory.CanGrow = false;
            this.txtCategory.DataField = "Category";
            this.txtCategory.Height = 0.198F;
            this.txtCategory.Left = 1.312F;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Style = "vertical-align: middle; font-size: 9pt; text-align: right";
            this.txtCategory.Text = "Category";
            this.txtCategory.Top = 0F;
            this.txtCategory.Width = 0.375F;
            // 
            // txtProductName
            // 
            this.txtProductName.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtProductName.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtProductName.CanGrow = false;
            this.txtProductName.DataField = "Products";
            this.txtProductName.Height = 0.198F;
            this.txtProductName.Left = 1.687F;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Style = "vertical-align: middle; font-size: 9pt";
            this.txtProductName.Text = "ProductName";
            this.txtProductName.Top = 0F;
            this.txtProductName.Width = 2F;
            // 
            // txtPrice
            // 
            this.txtPrice.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtPrice.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtPrice.CanGrow = false;
            this.txtPrice.DataField = "Price";
            this.txtPrice.Height = 0.197F;
            this.txtPrice.Left = 5.062F;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.OutputFormat = resources.GetString("txtPrice.OutputFormat");
            this.txtPrice.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
            this.txtPrice.Text = "Price";
            this.txtPrice.Top = 0F;
            this.txtPrice.Width = 0.89F;
            // 
            // PageHeader
            // 
            this.PageHeader.CanGrow = false;
            this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.shpTitle,
            this.lblTitle,
            this.lblBillNo,
            this.txtBillNo,
            this.txtCustomerName,
            this.lblHonorific,
            this.txtBillTotal,
            this.lblThanks_2,
            this.lblBillTotal_Yen,
            this.imgCrown,
            this.txtYear,
            this.lblYear,
            this.txtMonth,
            this.lblMonth,
            this.txtDay,
            this.lblDay,
            this.lblDeadline,
            this.lblCompanyName,
            this.lblHQ,
            this.lblAddress_HQ,
            this.lblTEL_HQ,
            this.lblFAX_HQ,
            this.lblZipCode_HQ,
            this.lblURL_HQ,
            this.lblThanks_1,
            this.lblCustomerID,
            this.txtCustomerID,
            this.lblBillTotal,
            this.shpBillTotal,
            this.linCustomerName,
            this.lblPreInvoice,
            this.lblPreIncome,
            this.lblCarryOver,
            this.lblTotal,
            this.lblExcise,
            this.txtPreInvoice,
            this.txtPreIncome,
            this.txtCarryOver,
            this.txtTotal,
            this.txtExcise,
            this.shpSummary});
            this.PageHeader.Height = 2.961806F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.BeforePrint += new System.EventHandler(this.PageHeader_BeforePrint);
            // 
            // shpTitle
            // 
            this.shpTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.shpTitle.Height = 0.40625F;
            this.shpTitle.Left = 1.6F;
            this.shpTitle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.shpTitle.Name = "shpTitle";
            this.shpTitle.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(20F);
            this.shpTitle.Style = GrapeCity.ActiveReports.SectionReportModel.ShapeType.RoundRect;
            this.shpTitle.Top = 0F;
            this.shpTitle.Width = 2.8F;
            // 
            // lblTitle
            // 
            this.lblTitle.Height = 0.375F;
            this.lblTitle.HyperLink = null;
            this.lblTitle.Left = 1.7F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new GrapeCity.ActiveReports.PaddingEx(10, 0, 10, 0);
            this.lblTitle.Style = "font-size: 18pt; font-weight: bold; color: White; vertical-align: middle; text-al" +
                "ign: justify; text-justify: distribute-all-lines";
            this.lblTitle.Text = "å‰êøãÅñæç◊èë";
            this.lblTitle.Top = 0.02083333F;
            this.lblTitle.Width = 2.6F;
            // 
            // lblBillNo
            // 
            this.lblBillNo.Height = 0.1727349F;
            this.lblBillNo.HyperLink = null;
            this.lblBillNo.Left = 4.733F;
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Style = "font-size: 8.5pt; color: Blue; vertical-align: middle";
            this.lblBillNo.Text = "No:";
            this.lblBillNo.Top = 0.213F;
            this.lblBillNo.Width = 0.2570567F;
            // 
            // txtBillNo
            // 
            this.txtBillNo.DataField = "BillCondition.BillNo";
            this.txtBillNo.Height = 0.173F;
            this.txtBillNo.Left = 4.99F;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Style = "vertical-align: middle; text-align: center";
            this.txtBillNo.Text = "BillNo";
            this.txtBillNo.Top = 0.213F;
            this.txtBillNo.Width = 0.7708333F;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.DataField = "CustomerName";
            this.txtCustomerName.Height = 0.25F;
            this.txtCustomerName.Left = 0.1354167F;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Style = "text-align: center; font-weight: bold; font-size: 12pt; vertical-align: middle";
            this.txtCustomerName.Text = "Name";
            this.txtCustomerName.Top = 1F;
            this.txtCustomerName.Width = 2.375F;
            // 
            // lblHonorific
            // 
            this.lblHonorific.Height = 0.25F;
            this.lblHonorific.HyperLink = null;
            this.lblHonorific.Left = 2.5F;
            this.lblHonorific.Name = "lblHonorific";
            this.lblHonorific.Style = "ddo-char-set: 128; font-weight: bold; font-size: 11.5pt; font-family: ÇlÇr ÇoÉSÉVÉbÉN; v" +
                "ertical-align: middle";
            this.lblHonorific.Text = "ól";
            this.lblHonorific.Top = 1F;
            this.lblHonorific.Width = 0.375F;
            // 
            // txtBillTotal
            // 
            this.txtBillTotal.Height = 0.25F;
            this.txtBillTotal.Left = 4.949F;
            this.txtBillTotal.Name = "txtBillTotal";
            this.txtBillTotal.OutputFormat = resources.GetString("txtBillTotal.OutputFormat");
            this.txtBillTotal.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
            this.txtBillTotal.Style = "text-align: right; font-size: 9pt; vertical-align: middle";
            this.txtBillTotal.Text = "BillTotal";
            this.txtBillTotal.Top = 2.448F;
            this.txtBillTotal.Width = 0.75F;
            // 
            // lblThanks_2
            // 
            this.lblThanks_2.Height = 0.206F;
            this.lblThanks_2.HyperLink = null;
            this.lblThanks_2.Left = 0.135F;
            this.lblThanks_2.Name = "lblThanks_2";
            this.lblThanks_2.Style = "font-size: 8.5pt; vertical-align: middle";
            this.lblThanks_2.Text = "â∫ãLÇÃí ÇËÇ≤êøãÅê\Çµè„Ç∞Ç‹Ç∑ÅB";
            this.lblThanks_2.Top = 1.969F;
            this.lblThanks_2.Width = 2.03F;
            // 
            // lblBillTotal_Yen
            // 
            this.lblBillTotal_Yen.Height = 0.25F;
            this.lblBillTotal_Yen.HyperLink = null;
            this.lblBillTotal_Yen.Left = 5.699F;
            this.lblBillTotal_Yen.Name = "lblBillTotal_Yen";
            this.lblBillTotal_Yen.Style = "vertical-align: middle";
            this.lblBillTotal_Yen.Text = "â~ ";
            this.lblBillTotal_Yen.Top = 2.448F;
            this.lblBillTotal_Yen.Width = 0.2291665F;
            // 
            // imgCrown
            // 
            this.imgCrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgCrown.Height = 0.8629507F;
            this.imgCrown.HyperLink = null;
            this.imgCrown.Image = ((System.Drawing.Image)(resources.GetObject("imgCrown.Image")));
            this.imgCrown.ImageBytes = ((System.Byte[])(resources.GetObject("imgCrown.ImageBytes")));
            this.imgCrown.Left = 4.949F;
            this.imgCrown.LineColor = System.Drawing.Color.Black;
            this.imgCrown.LineWeight = 1F;
            this.imgCrown.Name = "imgCrown";
            this.imgCrown.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
            this.imgCrown.Top = 0.506F;
            this.imgCrown.Width = 0.8941028F;
            // 
            // txtYear
            // 
            this.txtYear.DataField = "EndDate";
            this.txtYear.Height = 0.1875F;
            this.txtYear.Left = 0.135F;
            this.txtYear.Name = "txtYear";
            this.txtYear.OutputFormat = resources.GetString("txtYear.OutputFormat");
            this.txtYear.Style = "vertical-align: middle; text-align: center";
            this.txtYear.Text = "2003";
            this.txtYear.Top = 1.509F;
            this.txtYear.Width = 0.4F;
            // 
            // lblYear
            // 
            this.lblYear.Height = 0.1875F;
            this.lblYear.HyperLink = null;
            this.lblYear.Left = 0.535F;
            this.lblYear.Name = "lblYear";
            this.lblYear.Style = "vertical-align: middle; text-align: center";
            this.lblYear.Text = "îN";
            this.lblYear.Top = 1.509F;
            this.lblYear.Width = 0.208F;
            // 
            // txtMonth
            // 
            this.txtMonth.DataField = "EndDate";
            this.txtMonth.Height = 0.1875F;
            this.txtMonth.Left = 0.743F;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.OutputFormat = resources.GetString("txtMonth.OutputFormat");
            this.txtMonth.Style = "text-align: center; vertical-align: middle";
            this.txtMonth.Text = "9";
            this.txtMonth.Top = 1.509F;
            this.txtMonth.Width = 0.25F;
            // 
            // lblMonth
            // 
            this.lblMonth.Height = 0.1875F;
            this.lblMonth.HyperLink = null;
            this.lblMonth.Left = 0.993F;
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Style = "ddo-char-set: 128; font-family: ÇlÇr Çoñæí©; vertical-align: middle";
            this.lblMonth.Text = "åé";
            this.lblMonth.Top = 1.509F;
            this.lblMonth.Width = 0.2080001F;
            // 
            // txtDay
            // 
            this.txtDay.DataField = "EndDate";
            this.txtDay.Height = 0.1875F;
            this.txtDay.Left = 1.201F;
            this.txtDay.Name = "txtDay";
            this.txtDay.OutputFormat = resources.GetString("txtDay.OutputFormat");
            this.txtDay.Style = "text-align: center; vertical-align: middle";
            this.txtDay.Text = "30";
            this.txtDay.Top = 1.509F;
            this.txtDay.Width = 0.25F;
            // 
            // lblDay
            // 
            this.lblDay.Height = 0.188F;
            this.lblDay.HyperLink = null;
            this.lblDay.Left = 1.451F;
            this.lblDay.Name = "lblDay";
            this.lblDay.Style = "vertical-align: middle; text-align: center";
            this.lblDay.Text = "ì˙";
            this.lblDay.Top = 1.509F;
            this.lblDay.Width = 0.188F;
            // 
            // lblDeadline
            // 
            this.lblDeadline.Height = 0.1875F;
            this.lblDeadline.HyperLink = null;
            this.lblDeadline.Left = 1.639F;
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Style = "vertical-align: middle";
            this.lblDeadline.Text = "í˜êÿï™";
            this.lblDeadline.Top = 1.509F;
            this.lblDeadline.Width = 0.5260003F;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Height = 0.25F;
            this.lblCompanyName.HyperLink = null;
            this.lblCompanyName.Left = 2.99F;
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Style = "font-size: 12pt; vertical-align: middle";
            this.lblCompanyName.Text = "ìåì˙ñ{ìåãûè§é–äîéÆâÔé–";
            this.lblCompanyName.Top = 1.119F;
            this.lblCompanyName.Width = 1.959F;
            // 
            // lblHQ
            // 
            this.lblHQ.Height = 0.1968504F;
            this.lblHQ.HyperLink = null;
            this.lblHQ.Left = 2.99F;
            this.lblHQ.Name = "lblHQ";
            this.lblHQ.Style = "font-size: 9pt; vertical-align: middle";
            this.lblHQ.Text = "ñ{é–";
            this.lblHQ.Top = 1.369F;
            this.lblHQ.Width = 0.3839998F;
            // 
            // lblAddress_HQ
            // 
            this.lblAddress_HQ.Height = 0.1968504F;
            this.lblAddress_HQ.HyperLink = null;
            this.lblAddress_HQ.Left = 4.096F;
            this.lblAddress_HQ.Name = "lblAddress_HQ";
            this.lblAddress_HQ.Style = "font-size: 9pt; vertical-align: middle";
            this.lblAddress_HQ.Text = "êÂë‰ésêÚãÊéáéR3-1-4";
            this.lblAddress_HQ.Top = 1.369F;
            this.lblAddress_HQ.Width = 1.443569F;
            // 
            // lblTEL_HQ
            // 
            this.lblTEL_HQ.Height = 0.1968504F;
            this.lblTEL_HQ.HyperLink = null;
            this.lblTEL_HQ.Left = 3.374F;
            this.lblTEL_HQ.Name = "lblTEL_HQ";
            this.lblTEL_HQ.Style = "font-size: 9pt; vertical-align: middle";
            this.lblTEL_HQ.Text = "TELÅF022-777-8211";
            this.lblTEL_HQ.Top = 1.566F;
            this.lblTEL_HQ.Width = 1.574803F;
            // 
            // lblFAX_HQ
            // 
            this.lblFAX_HQ.Height = 0.206F;
            this.lblFAX_HQ.HyperLink = null;
            this.lblFAX_HQ.Left = 3.374F;
            this.lblFAX_HQ.Name = "lblFAX_HQ";
            this.lblFAX_HQ.Style = "font-size: 9pt; vertical-align: middle";
            this.lblFAX_HQ.Text = "FAXÅF022-777-8231";
            this.lblFAX_HQ.Top = 1.763F;
            this.lblFAX_HQ.Width = 1.574803F;
            // 
            // lblZipCode_HQ
            // 
            this.lblZipCode_HQ.Height = 0.1968504F;
            this.lblZipCode_HQ.HyperLink = null;
            this.lblZipCode_HQ.Left = 3.374F;
            this.lblZipCode_HQ.Name = "lblZipCode_HQ";
            this.lblZipCode_HQ.Style = "font-size: 9pt; vertical-align: middle";
            this.lblZipCode_HQ.Text = "Åß981-3205";
            this.lblZipCode_HQ.Top = 1.369F;
            this.lblZipCode_HQ.Width = 0.7220001F;
            // 
            // lblURL_HQ
            // 
            this.lblURL_HQ.Height = 0.206F;
            this.lblURL_HQ.HyperLink = "";
            this.lblURL_HQ.Left = 3.374F;
            this.lblURL_HQ.Name = "lblURL_HQ";
            this.lblURL_HQ.Style = "font-size: 9pt; vertical-align: middle";
            this.lblURL_HQ.Text = "http://www.grapecity.com";
            this.lblURL_HQ.Top = 1.969F;
            this.lblURL_HQ.Width = 1.574803F;
            // 
            // lblThanks_1
            // 
            this.lblThanks_1.Height = 0.206F;
            this.lblThanks_1.HyperLink = null;
            this.lblThanks_1.Left = 0.135F;
            this.lblThanks_1.Name = "lblThanks_1";
            this.lblThanks_1.Style = "font-size: 8.5pt; vertical-align: middle";
            this.lblThanks_1.Text = "ñàìxÇ≤óòópÇ†ÇËÇ™Ç∆Ç§Ç≤Ç¥Ç¢Ç‹Ç∑ÅB";
            this.lblThanks_1.Top = 1.763F;
            this.lblThanks_1.Width = 2.03F;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Height = 0.1966639F;
            this.lblCustomerID.HyperLink = null;
            this.lblCustomerID.Left = 0.135F;
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Style = "vertical-align: middle";
            this.lblCustomerID.Text = "Ç®ãqólÉRÅ[ÉhÅF";
            this.lblCustomerID.Top = 1.312F;
            this.lblCustomerID.Width = 0.9842521F;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataField = "CustomerID";
            this.txtCustomerID.Height = 0.1968504F;
            this.txtCustomerID.Left = 1.115F;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Style = "vertical-align: middle";
            this.txtCustomerID.Text = "txtCustomerID";
            this.txtCustomerID.Top = 1.312F;
            this.txtCustomerID.Width = 1.049869F;
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblBillTotal.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.lblBillTotal.Height = 0.1980002F;
            this.lblBillTotal.HyperLink = null;
            this.lblBillTotal.Left = 4.949F;
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Style = "color: #FFFFFF; text-align: center; font-weight: bold; font-size: 9pt; vertical-a" +
                "lign: middle; background-color: LightSkyBlue";
            this.lblBillTotal.Text = "ç°âÒÇ≤êøãÅäz";
            this.lblBillTotal.Top = 2.25F;
            this.lblBillTotal.Width = 0.979F;
            // 
            // shpBillTotal
            // 
            this.shpBillTotal.Height = 0.462F;
            this.shpBillTotal.Left = 4.942F;
            this.shpBillTotal.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.shpBillTotal.LineWeight = 2F;
            this.shpBillTotal.Name = "shpBillTotal";
            this.shpBillTotal.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.999999F);
            this.shpBillTotal.Style = GrapeCity.ActiveReports.SectionReportModel.ShapeType.RoundRect;
            this.shpBillTotal.Top = 2.243F;
            this.shpBillTotal.Width = 0.997F;
            // 
            // linCustomerName
            // 
            this.linCustomerName.Height = 0F;
            this.linCustomerName.Left = 0.135F;
            this.linCustomerName.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linCustomerName.LineWeight = 1F;
            this.linCustomerName.Name = "linCustomerName";
            this.linCustomerName.Top = 1.25F;
            this.linCustomerName.Width = 2.74F;
            this.linCustomerName.X1 = 0.135F;
            this.linCustomerName.X2 = 2.875F;
            this.linCustomerName.Y1 = 1.25F;
            this.linCustomerName.Y2 = 1.25F;
            // 
            // lblPreInvoice
            // 
            this.lblPreInvoice.Height = 0.1875F;
            this.lblPreInvoice.HyperLink = null;
            this.lblPreInvoice.Left = 0.021F;
            this.lblPreInvoice.Name = "lblPreInvoice";
            this.lblPreInvoice.Style = "ddo-char-set: 128; text-align: center; font-size: 9pt; font-family: ÇlÇr ÇoÉSÉVÉbÉN; ver" +
                "tical-align: middle; background-color: #C0FFFF";
            this.lblPreInvoice.Text = "ëOâÒÇ≤êøãÅäz";
            this.lblPreInvoice.Top = 2.25F;
            this.lblPreInvoice.Width = 0.937F;
            // 
            // lblPreIncome
            // 
            this.lblPreIncome.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.lblPreIncome.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.lblPreIncome.Height = 0.1875F;
            this.lblPreIncome.HyperLink = null;
            this.lblPreIncome.Left = 0.958F;
            this.lblPreIncome.Name = "lblPreIncome";
            this.lblPreIncome.Style = "ddo-char-set: 128; text-align: center; font-size: 9pt; font-family: ÇlÇr ÇoÉSÉVÉbÉN; ver" +
                "tical-align: middle; background-color: #C0FFFF";
            this.lblPreIncome.Text = "Ç≤ì¸ã‡äz";
            this.lblPreIncome.Top = 2.25F;
            this.lblPreIncome.Width = 0.875F;
            // 
            // lblCarryOver
            // 
            this.lblCarryOver.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.lblCarryOver.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.lblCarryOver.Height = 0.1875F;
            this.lblCarryOver.HyperLink = null;
            this.lblCarryOver.Left = 1.833F;
            this.lblCarryOver.Name = "lblCarryOver";
            this.lblCarryOver.Style = "ddo-char-set: 128; text-align: center; font-size: 9pt; font-family: ÇlÇr ÇoÉSÉVÉbÉN; ver" +
                "tical-align: middle; background-color: #C0FFFF";
            this.lblCarryOver.Text = "åJâzÇµécçÇäz";
            this.lblCarryOver.Top = 2.25F;
            this.lblCarryOver.Width = 1F;
            // 
            // lblTotal
            // 
            this.lblTotal.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.lblTotal.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.lblTotal.Height = 0.1875F;
            this.lblTotal.HyperLink = null;
            this.lblTotal.Left = 2.833F;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Style = "ddo-char-set: 128; text-align: center; font-size: 9pt; font-family: ÇlÇr ÇoÉSÉVÉbÉN; ver" +
                "tical-align: middle; background-color: #C0FFFF";
            this.lblTotal.Text = "ç°âÒÇ®îÉè„äz";
            this.lblTotal.Top = 2.25F;
            this.lblTotal.Width = 1F;
            // 
            // lblExcise
            // 
            this.lblExcise.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.lblExcise.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.lblExcise.Height = 0.1875F;
            this.lblExcise.HyperLink = null;
            this.lblExcise.Left = 3.833F;
            this.lblExcise.Name = "lblExcise";
            this.lblExcise.Style = "ddo-char-set: 128; text-align: center; font-size: 9pt; font-family: ÇlÇr ÇoÉSÉVÉbÉN; ver" +
                "tical-align: middle; background-color: #C0FFFF";
            this.lblExcise.Text = "ç°âÒè¡îÔê≈";
            this.lblExcise.Top = 2.25F;
            this.lblExcise.Width = 1F;
            // 
            // txtPreInvoice
            // 
            this.txtPreInvoice.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtPreInvoice.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtPreInvoice.DataField = "PreInvoice";
            this.txtPreInvoice.Height = 0.25F;
            this.txtPreInvoice.Left = 0.021F;
            this.txtPreInvoice.Name = "txtPreInvoice";
            this.txtPreInvoice.OutputFormat = resources.GetString("txtPreInvoice.OutputFormat");
            this.txtPreInvoice.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 3, 0);
            this.txtPreInvoice.Style = "ddo-char-set: 128; text-align: right; font-size: 9pt; font-family: ÇlÇr ÉSÉVÉbÉN; verti" +
                "cal-align: middle";
            this.txtPreInvoice.Text = "PreInvoice";
            this.txtPreInvoice.Top = 2.448F;
            this.txtPreInvoice.Width = 0.937F;
            // 
            // txtPreIncome
            // 
            this.txtPreIncome.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtPreIncome.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtPreIncome.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtPreIncome.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtPreIncome.DataField = "PreIncome";
            this.txtPreIncome.Height = 0.25F;
            this.txtPreIncome.Left = 0.958F;
            this.txtPreIncome.Name = "txtPreIncome";
            this.txtPreIncome.OutputFormat = resources.GetString("txtPreIncome.OutputFormat");
            this.txtPreIncome.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 3, 0);
            this.txtPreIncome.Style = "ddo-char-set: 128; text-align: right; font-size: 9pt; font-family: ÇlÇr ÉSÉVÉbÉN; verti" +
                "cal-align: middle";
            this.txtPreIncome.Text = "PreIncome";
            this.txtPreIncome.Top = 2.448F;
            this.txtPreIncome.Width = 0.875F;
            // 
            // txtCarryOver
            // 
            this.txtCarryOver.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtCarryOver.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtCarryOver.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtCarryOver.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtCarryOver.DataField = "CarryOver";
            this.txtCarryOver.Height = 0.25F;
            this.txtCarryOver.Left = 1.833F;
            this.txtCarryOver.Name = "txtCarryOver";
            this.txtCarryOver.OutputFormat = resources.GetString("txtCarryOver.OutputFormat");
            this.txtCarryOver.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 3, 0);
            this.txtCarryOver.Style = "ddo-char-set: 128; text-align: right; font-size: 9pt; font-family: ÇlÇr ÉSÉVÉbÉN; verti" +
                "cal-align: middle";
            this.txtCarryOver.Text = "CarryOver";
            this.txtCarryOver.Top = 2.448F;
            this.txtCarryOver.Width = 1F;
            // 
            // txtTotal
            // 
            this.txtTotal.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtTotal.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtTotal.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtTotal.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtTotal.DataField = "Price";
            this.txtTotal.Height = 0.25F;
            this.txtTotal.Left = 2.833F;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat");
            this.txtTotal.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 3, 0);
            this.txtTotal.Style = "ddo-char-set: 128; text-align: right; font-size: 9pt; font-family: ÇlÇr ÉSÉVÉbÉN; verti" +
                "cal-align: middle";
            this.txtTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
            this.txtTotal.Text = "Total";
            this.txtTotal.Top = 2.448F;
            this.txtTotal.Width = 1F;
            // 
            // txtExcise
            // 
            this.txtExcise.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtExcise.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtExcise.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(209)))));
            this.txtExcise.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
            this.txtExcise.Height = 0.25F;
            this.txtExcise.Left = 3.833F;
            this.txtExcise.Name = "txtExcise";
            this.txtExcise.OutputFormat = resources.GetString("txtExcise.OutputFormat");
            this.txtExcise.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 3, 0);
            this.txtExcise.Style = "ddo-char-set: 128; text-align: right; font-size: 9pt; font-family: ÇlÇr ÉSÉVÉbÉN; verti" +
                "cal-align: middle";
            this.txtExcise.Text = "Excise";
            this.txtExcise.Top = 2.448F;
            this.txtExcise.Width = 1F;
            // 
            // shpSummary
            // 
            this.shpSummary.Height = 0.462F;
            this.shpSummary.Left = 0.015F;
            this.shpSummary.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.shpSummary.LineWeight = 2F;
            this.shpSummary.Name = "shpSummary";
            this.shpSummary.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.999999F);
            this.shpSummary.Style = GrapeCity.ActiveReports.SectionReportModel.ShapeType.RoundRect;
            this.shpSummary.Top = 2.243F;
            this.shpSummary.Width = 4.825F;
            // 
            // PageFooter
            // 
            this.PageFooter.CanGrow = false;
            this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.Shape30,
            this.Label40,
            this.Label44,
            this.Label41,
            this.Label42,
            this.Label43,
            this.Label45,
            this.Label46,
            this.Label47,
            this.Label48,
            this.Label49});
            this.PageFooter.Height = 0.6979167F;
            this.PageFooter.Name = "PageFooter";
            // 
            // Shape30
            // 
            this.Shape30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.Shape30.Height = 0.4593177F;
            this.Shape30.Left = 3.847F;
            this.Shape30.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Shape30.Name = "Shape30";
            this.Shape30.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.999999F);
            this.Shape30.Style = GrapeCity.ActiveReports.SectionReportModel.ShapeType.RoundRect;
            this.Shape30.Top = 0.131F;
            this.Shape30.Width = 2.099738F;
            // 
            // Label40
            // 
            this.Label40.Height = 0.125F;
            this.Label40.HyperLink = null;
            this.Label40.Left = 0.0625F;
            this.Label40.Name = "Label40";
            this.Label40.Style = "font-size: 7pt; color: Blue";
            this.Label40.Text = "11  îÑ   è„";
            this.Label40.Top = 0.1354167F;
            this.Label40.Width = 0.75F;
            // 
            // Label44
            // 
            this.Label44.Height = 0.125F;
            this.Label44.HyperLink = null;
            this.Label44.Left = 1.115485F;
            this.Label44.Name = "Label44";
            this.Label44.Style = "font-size: 7pt; color: Blue";
            this.Label44.Text = "31  åªã‡ì¸ã‡";
            this.Label44.Top = 0.1312336F;
            this.Label44.Width = 0.75F;
            // 
            // Label41
            // 
            this.Label41.Height = 0.125F;
            this.Label41.HyperLink = null;
            this.Label41.Left = 0.0625F;
            this.Label41.Name = "Label41";
            this.Label41.Style = "font-size: 7pt; color: Blue";
            this.Label41.Text = "12  îÑè„ï‘ïi";
            this.Label41.Top = 0.2604167F;
            this.Label41.Width = 0.75F;
            // 
            // Label42
            // 
            this.Label42.Height = 0.125F;
            this.Label42.HyperLink = null;
            this.Label42.Left = 0.0625F;
            this.Label42.Name = "Label42";
            this.Label42.Style = "font-size: 7pt; color: Blue";
            this.Label42.Text = "13  îÑè„ílà¯";
            this.Label42.Top = 0.3854167F;
            this.Label42.Width = 0.75F;
            // 
            // Label43
            // 
            this.Label43.Height = 0.125F;
            this.Label43.HyperLink = null;
            this.Label43.Left = 0.0625F;
            this.Label43.Name = "Label43";
            this.Label43.Style = "font-size: 7pt; color: Blue";
            this.Label43.Text = "14  ÇªÇÃëºîÑè„";
            this.Label43.Top = 0.5104167F;
            this.Label43.Width = 0.75F;
            // 
            // Label45
            // 
            this.Label45.Height = 0.125F;
            this.Label45.HyperLink = null;
            this.Label45.Left = 1.115485F;
            this.Label45.Name = "Label45";
            this.Label45.Style = "font-size: 7pt; color: Blue";
            this.Label45.Text = "32  è¨êÿéËì¸ã‡";
            this.Label45.Top = 0.2624672F;
            this.Label45.Width = 0.75F;
            // 
            // Label46
            // 
            this.Label46.Height = 0.125F;
            this.Label46.HyperLink = null;
            this.Label46.Left = 1.115F;
            this.Label46.Name = "Label46";
            this.Label46.Style = "font-size: 7pt; color: Blue";
            this.Label46.Text = "33  êUçûì¸ã‡";
            this.Label46.Top = 0.385F;
            this.Label46.Width = 0.75F;
            // 
            // Label47
            // 
            this.Label47.Height = 0.125F;
            this.Label47.HyperLink = null;
            this.Label47.Left = 1.115F;
            this.Label47.Name = "Label47";
            this.Label47.Style = "font-size: 7pt; color: Blue";
            this.Label47.Text = "38  ÇªÇÃëºì¸ã‡";
            this.Label47.Top = 0.51F;
            this.Label47.Width = 0.75F;
            // 
            // Label48
            // 
            this.Label48.Height = 0.1968504F;
            this.Label48.HyperLink = null;
            this.Label48.Left = 3.94F;
            this.Label48.Name = "Label48";
            this.Label48.Style = "color: Blue; font-size: 9pt";
            this.Label48.Text = "Ç®êUçûÇ›êÊ";
            this.Label48.Top = 0.191F;
            this.Label48.Width = 1.049869F;
            // 
            // Label49
            // 
            this.Label49.Height = 0.131F;
            this.Label49.HyperLink = null;
            this.Label49.Left = 3.94F;
            this.Label49.Name = "Label49";
            this.Label49.Style = "color: Blue; font-size: 9pt";
            this.Label49.Text = "ÉCÉ`É}Éãã‚çsñ{ìX ïÅí  5125332";
            this.Label49.Top = 0.379F;
            this.Label49.Width = 1.903F;
            // 
            // ghColumnCaption
            // 
            this.ghColumnCaption.CanGrow = false;
            this.ghColumnCaption.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
            this.cslLine2,
            this.Label30,
            this.Label34,
            this.Label35,
            this.Label36,
            this.Label31,
            this.Label32,
            this.Label33,
            this.cslLine4,
            this.cslLine1,
            this.cslLine3,
            this.cslLine6,
            this.cslLine5,
            this.csbDetails});
            this.ghColumnCaption.Height = 0.1888889F;
            this.ghColumnCaption.KeepTogether = true;
            this.ghColumnCaption.Name = "ghColumnCaption";
            this.ghColumnCaption.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
            // 
            // cslLine2
            // 
            this.cslLine2.End = ((System.Drawing.PointF)(resources.GetObject("cslLine2.End")));
            this.cslLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cslLine2.LineWeight = 1F;
            this.cslLine2.Name = "cslLine2";
            this.cslLine2.Start = ((System.Drawing.PointF)(resources.GetObject("cslLine2.Start")));
            this.cslLine2.Top = 0F;
            // 
            // Label30
            // 
            this.Label30.Height = 0.19F;
            this.Label30.HyperLink = null;
            this.Label30.Left = 0F;
            this.Label30.Name = "Label30";
            this.Label30.Padding = new GrapeCity.ActiveReports.PaddingEx(10, 0, 10, 0);
            this.Label30.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-align: justify; text-justify: distribute-all-lines";
            this.Label30.Text = "ì˙ït";
            this.Label30.Top = 0F;
            this.Label30.Width = 0.687F;
            // 
            // Label34
            // 
            this.Label34.Height = 0.19F;
            this.Label34.HyperLink = null;
            this.Label34.Left = 4.312F;
            this.Label34.Name = "Label34";
            this.Label34.Padding = new GrapeCity.ActiveReports.PaddingEx(12, 0, 12, 0);
            this.Label34.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-align: justify; text-justify: distribute-all-lines";
            this.Label34.Text = "êîó ";
            this.Label34.Top = 0F;
            this.Label34.Width = 0.75F;
            // 
            // Label35
            // 
            this.Label35.Height = 0.19F;
            this.Label35.HyperLink = null;
            this.Label35.Left = 3.687F;
            this.Label35.Name = "Label35";
            this.Label35.Padding = new GrapeCity.ActiveReports.PaddingEx(8, 0, 8, 0);
            this.Label35.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-align: justify; text-justify: distribute-all-lines";
            this.Label35.Text = "íPâø";
            this.Label35.Top = 0F;
            this.Label35.Width = 0.625F;
            // 
            // Label36
            // 
            this.Label36.Height = 0.19F;
            this.Label36.HyperLink = null;
            this.Label36.Left = 5.062F;
            this.Label36.Name = "Label36";
            this.Label36.Padding = new GrapeCity.ActiveReports.PaddingEx(17, 0, 17, 0);
            this.Label36.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-align: justify; text-justify: distribute-all-lines";
            this.Label36.Text = "ã‡äz";
            this.Label36.Top = 0F;
            this.Label36.Width = 0.9F;
            // 
            // Label31
            // 
            this.Label31.Height = 0.19F;
            this.Label31.HyperLink = null;
            this.Label31.Left = 0.687F;
            this.Label31.Name = "Label31";
            this.Label31.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
            this.Label31.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-align: justify; text-justify: distribute-all-lines";
            this.Label31.Text = "ì`ï[No";
            this.Label31.Top = 0F;
            this.Label31.Width = 0.625F;
            // 
            // Label32
            // 
            this.Label32.Height = 0.19F;
            this.Label32.HyperLink = null;
            this.Label32.Left = 1.312F;
            this.Label32.Name = "Label32";
            this.Label32.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
            this.Label32.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-align: justify; text-justify: distribute-all-lines";
            this.Label32.Text = "ãÊï™";
            this.Label32.Top = 0F;
            this.Label32.Width = 0.375F;
            // 
            // Label33
            // 
            this.Label33.Height = 0.19F;
            this.Label33.HyperLink = null;
            this.Label33.Left = 1.687F;
            this.Label33.Name = "Label33";
            this.Label33.Padding = new GrapeCity.ActiveReports.PaddingEx(25, 0, 25, 0);
            this.Label33.Style = "background-color: LightSkyBlue; font-weight: bold; color: White; font-size: 9pt; " +
                "vertical-align: middle; text-justify: distribute-all-lines; text-align: justify";
            this.Label33.Text = "êªïiñº";
            this.Label33.Top = 0F;
            this.Label33.Width = 2F;
            // 
            // cslLine4
            // 
            this.cslLine4.End = ((System.Drawing.PointF)(resources.GetObject("cslLine4.End")));
            this.cslLine4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cslLine4.LineWeight = 1F;
            this.cslLine4.Name = "cslLine4";
            this.cslLine4.Start = ((System.Drawing.PointF)(resources.GetObject("cslLine4.Start")));
            this.cslLine4.Top = 0F;
            // 
            // cslLine1
            // 
            this.cslLine1.End = ((System.Drawing.PointF)(resources.GetObject("cslLine1.End")));
            this.cslLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cslLine1.LineWeight = 1F;
            this.cslLine1.Name = "cslLine1";
            this.cslLine1.Start = ((System.Drawing.PointF)(resources.GetObject("cslLine1.Start")));
            this.cslLine1.Top = 0F;
            // 
            // cslLine3
            // 
            this.cslLine3.End = ((System.Drawing.PointF)(resources.GetObject("cslLine3.End")));
            this.cslLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cslLine3.LineWeight = 1F;
            this.cslLine3.Name = "cslLine3";
            this.cslLine3.Start = ((System.Drawing.PointF)(resources.GetObject("cslLine3.Start")));
            this.cslLine3.Top = 0F;
            // 
            // cslLine6
            // 
            this.cslLine6.End = ((System.Drawing.PointF)(resources.GetObject("cslLine6.End")));
            this.cslLine6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cslLine6.LineWeight = 1F;
            this.cslLine6.Name = "cslLine6";
            this.cslLine6.Start = ((System.Drawing.PointF)(resources.GetObject("cslLine6.Start")));
            this.cslLine6.Top = 0F;
            // 
            // cslLine5
            // 
            this.cslLine5.End = ((System.Drawing.PointF)(resources.GetObject("cslLine5.End")));
            this.cslLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cslLine5.LineWeight = 1F;
            this.cslLine5.Name = "cslLine5";
            this.cslLine5.Start = ((System.Drawing.PointF)(resources.GetObject("cslLine5.Start")));
            this.cslLine5.Top = 0F;
            // 
            // csbDetails
            // 
            this.csbDetails.End = ((System.Drawing.PointF)(resources.GetObject("csbDetails.End")));
            this.csbDetails.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.csbDetails.LineWeight = 1F;
            this.csbDetails.Name = "csbDetails";
            this.csbDetails.Start = ((System.Drawing.PointF)(resources.GetObject("csbDetails.Start")));
            this.csbDetails.Top = 0F;
            // 
            // gfColumnCaption
            // 
            this.gfColumnCaption.Height = 0.009722223F;
            this.gfColumnCaption.Name = "gfColumnCaption";
            // 
            // rptSeikyu
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 6F;
            this.Script = "public void ActiveReport_ReportEnd()\n{\n\n}";
            this.Sections.Add(this.PageHeader);
            this.Sections.Add(this.ghColumnCaption);
            this.Sections.Add(this.Detail);
            this.Sections.Add(this.gfColumnCaption);
            this.Sections.Add(this.PageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" +
                        "t-size: 10pt; vertical-align: top; font-family: \"ÇlÇr Çoñæí©\"; ddo-char-set: 128", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 12pt; font-weight: bold; ddo-char-set: 128", "å©èoÇµ1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; ddo-char-set: 128", "å©èoÇµ2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 12pt; font-weight: bold; font-style: italic; ddo-char-set: 128", "å©èoÇµ3", "Normal"));
            this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.rptSeikyu_FetchData);
            this.DataInitialize += new System.EventHandler(this.rptSeikyu_DataInitialize);
            ((System.ComponentModel.ISupportInitialize)(this.txtSlipNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHonorific)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThanks_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillTotal_Yen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCrown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDeadline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCompanyName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress_HQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTEL_HQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFAX_HQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZipCode_HQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblURL_HQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblThanks_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBillTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPreInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPreIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCarryOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblExcise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarryOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

    }
}
