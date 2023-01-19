using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Seikyu
{
    /// <summary>
    /// Form1 の概要の説明です。
    /// </summary>
    public class frmSeikyu : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbCustomers;
        internal GrapeCity.ActiveReports.Viewer.Win.Viewer Viewer1;
        internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
        internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
        internal System.Data.OleDb.OleDbConnection OleDbConnection1;
        internal System.Data.DataSet DataSet11;
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public frmSeikyu()
        {
            //
            // Windows フォーム デザイナ サポートに必要です。
            //
            InitializeComponent();

            //
            // TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
            //
        }

        /// <summary>
        /// 使用されているリソースに後処理を実行します。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeikyu));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.Viewer1 = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.DataSet11 = new System.Data.DataSet();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.cmbCustomers);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(792, 40);
            this.Panel1.TabIndex = 2;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(345, 6);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 24);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "閉じる";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "請求先：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Location = new System.Drawing.Point(80, 8);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(224, 20);
            this.cmbCustomers.TabIndex = 0;
            this.cmbCustomers.Text = "（選択してください）";
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // Viewer1
            // 
            this.Viewer1.BackColor = System.Drawing.SystemColors.Control;
            this.Viewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Viewer1.Document = new GrapeCity.ActiveReports.Document.SectionDocument("ARNet Document");
            this.Viewer1.Location = new System.Drawing.Point(0, 40);
            this.Viewer1.Name = "Viewer1";
            this.Viewer1.ReportViewer.CurrentPage = 0;
            this.Viewer1.ReportViewer.MultiplePageCols = 3;
            this.Viewer1.ReportViewer.MultiplePageRows = 2;
            this.Viewer1.ReportViewer.ViewType = GrapeCity.Viewer.Common.Model.ViewType.SinglePage;
            this.Viewer1.Size = new System.Drawing.Size(792, 526);
            this.Viewer1.TabIndex = 3;
            this.Viewer1.TableOfContents.Text = "見出し一覧";
            this.Viewer1.TableOfContents.Width = 200;
            this.Viewer1.TabTitleLength = 35;
            this.Viewer1.Toolbar.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            // 
            // OleDbDataAdapter1
            // 
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Bill", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Bill.CustomerID", "Bill.CustomerID"),
                        new System.Data.Common.DataColumnMapping("Products", "Products"),
                        new System.Data.Common.DataColumnMapping("Number", "Number"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Price", "Price"),
                        new System.Data.Common.DataColumnMapping("Bill.BillNo", "Bill.BillNo"),
                        new System.Data.Common.DataColumnMapping("Remarks", "Remarks"),
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("SlipNo", "SlipNo"),
                        new System.Data.Common.DataColumnMapping("Category", "Category"),
                        new System.Data.Common.DataColumnMapping("BillCondition.BillNo", "BillCondition.BillNo"),
                        new System.Data.Common.DataColumnMapping("PreInvoice", "PreInvoice"),
                        new System.Data.Common.DataColumnMapping("PreIncome", "PreIncome"),
                        new System.Data.Common.DataColumnMapping("CarryOver", "CarryOver"),
                        new System.Data.Common.DataColumnMapping("NowConsume", "NowConsume"),
                        new System.Data.Common.DataColumnMapping("NowTax", "NowTax"),
                        new System.Data.Common.DataColumnMapping("NowInvoice", "NowInvoice"),
                        new System.Data.Common.DataColumnMapping("EndDate", "EndDate"),
                        new System.Data.Common.DataColumnMapping("Customers.CustomerID", "Customers.CustomerID"),
                        new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName")})});
            // 
            // OleDbSelectCommand1
            // 
            this.OleDbSelectCommand1.CommandText = "SELECT * FROM Bill, BillCondition, Customers where Bill.BillNo = BillCondition.Bi" +
                "llNo and Bill.CustomerID = Customers.CustomerID";
            this.OleDbSelectCommand1.Connection = this.OleDbConnection1;
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = resources.GetString("OleDbConnection1.ConnectionString");
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet1";
            this.DataSet11.Locale = new System.Globalization.CultureInfo("ja-JP");
            this.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.Viewer1);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "請求書形式のレポート　サンプル";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // データベースからコンボボックスに顧客を設定します。
            this.OleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Password=\"\";" +
                "User ID=Admin;Data Source=" + @"C:\Data\BILL.MDB";

            this.OleDbConnection1.Open();
            System.Data.OleDb.OleDbCommand cm = this.OleDbConnection1.CreateCommand();
            cm.CommandText = "SELECT * FROM Customers";
            System.Data.OleDb.OleDbDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbCustomers.Items.Add(dr["CustomerID"].ToString() + ":" + dr["CustomerName"].ToString());
            }
            dr.Close();
            this.OleDbConnection1.Close();

        }

        private void cmbCustomers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                // カーソルを変更します。
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                // コンボボックスで選択された顧客IDを取得します。
                string str;
                str = cmbCustomers.Text;
                str = str.Substring(0, str.IndexOf(":"));

                // SQL文を作成します。
                string strSQL;
                strSQL = "SELECT Bill.*, BillCondition.*, Customers.CustomerName ";
                strSQL = strSQL + "FROM Customers INNER JOIN (Bill INNER JOIN BillCondition ON Bill.BillNo = BillCondition.BillNo) ON Customers.CustomerID = Bill.CustomerID ";
                strSQL = strSQL + "WHERE Bill.CustomerID = " + str;

                OleDbDataAdapter1.SelectCommand.CommandText = strSQL;

                // 表示データの取得
                this.DataSet11.Clear();
                this.OleDbConnection1.Open();
                this.OleDbDataAdapter1.Fill(this.DataSet11);
                this.OleDbConnection1.Close();
                rptSeikyu rpt = new rptSeikyu();
                rpt.DataSource = this.DataSet11.Tables[0];

                Viewer1.Document = rpt.Document;
                rpt.Run();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                // カーソルを変更します。
                this.Cursor = Cursors.Default;
                Application.DoEvents();
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
