using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using FastReport.Utils;
using FastReport.Design;

namespace FYYK.AutoPrintDemo
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        #region Form OnLoad
        /// <summary>
        /// frmMain
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// frmMain_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.gridControlMainData.Dock = DockStyle.Fill;
            this.gridControlDetailsData.Dock = DockStyle.Fill;
            this.gridViewMainData.IndicatorWidth = 40;
            this.gridViewDetailsData.IndicatorWidth = 40;
            this.dateEditStartDate.Text = FYYK.Util.CommonHelper.InitializationDate(-1);
            this.dateEditEndDate.Text = FYYK.Util.CommonHelper.InitializationDate(0);
            GridViewColumnsAddVisible(this.gridControlMainData, this.gridViewMainData, "Main_DT_JSON");
            GridViewColumnsAddVisible(this.gridControlDetailsData, this.gridViewDetailsData, "Details_DT_JSON");
            GetMainData();

        }
        #endregion

        #region UI Event

        #region bbtnSearch_ItemClick 
        /// <summary>
        /// bbtnSearch_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetMainData();
        }
        #endregion

        #region bbtnSelectAll_ItemClick
        /// <summary>
        ///  bbtnSelectAll_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnUnSelectAll_ItemClick
        /// <summary>
        /// bbtnUnSelectAll_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnUnSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnPrint_ItemClick
        /// <summary>
        /// bbtnPrint_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FastReports(false);
        }
        #endregion

        #region bbtnPrintDesign_ItemClick
        /// <summary>
        /// bbtnPrintDesign_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnPrintDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FastReports(true);
        }
        #endregion

        #region bbtnToExcel_ItemClick
        /// <summary>
        /// bbtnToExcel_ItemClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region gridViewMainData_CustomDrawRowIndicator
        /// <summary>
        /// gridViewMainData_CustomDrawRowIndicator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewMainData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Info.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();//显示行号}
            else
                e.Info.DisplayText = this.gridViewMainData.RowCount.ToString();//显示总数
        }
        #endregion

        #region gridViewDetailsData_CustomDrawRowIndicator
        /// <summary>
        /// gridViewDetailsData_CustomDrawRowIndicator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewDetailsData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        #endregion

        #endregion

        #region Private Function

        #region GridViewColumnsAddVisible
        /// <summary>
        /// GridViewColumnsAddVisible
        /// </summary>
        private void GridViewColumnsAddVisible(DevExpress.XtraGrid.GridControl gridControl,
            DevExpress.XtraGrid.Views.Grid.GridView gridView,
            string gridControlHead)
        {
            string filePath = string.Format(@"{0}\GridViewHeaderJson\{1}.txt", System.Windows.Forms.Application.StartupPath, gridControlHead);
            string jsonString = System.IO.File.ReadAllText(filePath);
            Newtonsoft.Json.Linq.JArray jAarray = Newtonsoft.Json.Linq.JArray.Parse(jsonString) as Newtonsoft.Json.Linq.JArray;
            List<FYYK.Model.GridControlHeader> listDataGridViewHeader = jAarray.ToObject<List<FYYK.Model.GridControlHeader>>();
            FYYK.Util.DevGridControlHelper.DynamicGenerateColumns(gridView, listDataGridViewHeader);
        }
        #endregion

        #region GetMainData
        /// <summary>
        /// GetMainData
        /// </summary>
        private void GetMainData()
        {
            string startDate = this.dateEditStartDate.Text;
            string endDate = this.dateEditEndDate.Text;
            string logogram = this.textEditLogogram.Text;
            string billCode = this.textEditLogogram.Text;
            string strSql = "BEGIN \r"
                          + "    SELECT top 20 0 AS Opt,a.djbh as BillCode,a.rq AS Datas,b.danwbh as BusinessCode,b.dwmch as BusinessName,a.ywy as SalesManName  \r"
                          + "    FROM pf_ckhz a (NOLOCK) JOIN mchk b (NOLOCK) on a.dwbh =b.dwbh \r"
                          + "    WHERE a.rq>=@StartDate AND a.rq<=@EndDate \r"
                          + "      AND ( b.dwmch like @Logogram  OR  \r"
                          + "            b.zjm like @Logogram  )  \r"
                          + "      AND a.djbh like @BillCode \r"
                          + "    ORDER BY a.djbh \r"
                          + "END \r";
            System.Data.SqlClient.SqlParameter[] sqlParameter = {new System.Data.SqlClient.SqlParameter("@StartDate", startDate),
                                                                 new System.Data.SqlClient.SqlParameter("@EndDate", endDate),
                                                                 new System.Data.SqlClient.SqlParameter("@Logogram",string.Format("%{0}%",logogram)),
                                                                 new System.Data.SqlClient.SqlParameter("@BillCode", string.Format("{0}%",billCode))};
            this.gridControlMainData.DataSource = FYYK.DBUtility.SqlDbHelper.ExecuteDataTable(CommandType.Text, strSql, sqlParameter);
            FYYK.Util.DevGridControlHelper.GridViewColumnAutoWidth(this.gridViewMainData);
            if(this.gridViewMainData.RowCount>0)
                GetDetailsData();
        }
        #endregion

        #region GetDetailsData
        /// <summary>
        /// GetDetailsData
        /// </summary>
        private void GetDetailsData()
        {
            int selectRow = gridViewMainData.GetSelectedRows()[0]; //行号
            string billCode = this.gridViewMainData.GetRowCellValue(selectRow, "BillCode").ToString();
            string strSql = "BEGIN \r"
                          + "    SELECT top 20 0 AS Opt,a.djbh as BillCode,a.dj_sn AS BillSn,b.spbh as GoodsCode,b.spmch as GoodsName,b.shpgg as GoodsSpec,  \r"
                          + "           a.shl as Quantity,a.hshj AS TaxPrice,a.hsje as TaxAmt, a.pihao as BatchCode,a.baozhiqi as ProduceDate,a.sxrq as ValDate, \r"
                          + "           b.shpchd as Place,b.shengccj as Manufacturer,b.pizhwh as ApprovalNo,b.jixing as Formula  \r"
                          + "    FROM pf_ckmx a (NOLOCK) JOIN spkfk b (NOLOCK) on a.spid =b.spid \r"
                          + "    WHERE  a.djbh = @BillCode \r"
                          + "    ORDER BY a.djbh \r"
                          + "END \r";
            System.Data.SqlClient.SqlParameter[] sqlParameter = {new System.Data.SqlClient.SqlParameter("@StartDate", string.Empty),
                                                                 new System.Data.SqlClient.SqlParameter("@EndDate", string.Empty),
                                                                 new System.Data.SqlClient.SqlParameter("@Logogram",string.Empty),
                                                                 new System.Data.SqlClient.SqlParameter("@BillCode", billCode)};
            System.Data.DataTable dt = FYYK.DBUtility.SqlDbHelper.ExecuteDataTable(CommandType.Text, strSql, sqlParameter);
            this.gridControlDetailsData.DataSource = dt;
            FYYK.Util.DevGridControlHelper.GridViewColumnAutoWidth(this.gridViewDetailsData);
        }

        #endregion

        #region gridViewMainData_RowCellClick
        /// <summary>
        /// gridViewMainData_RowCellClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewMainData_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //编辑状态 右键，否则左键
            GetDetailsData();
        }
        #endregion


        #region ToDataTable
        /// <summary>
        /// ToDataTable
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        private DataTable ToDataTable(DataRow rows)
        {
            if (rows == null) return null;
            DataTable tmp = rows.Table.Clone();
            tmp.Rows.Add(rows.ItemArray);
            return tmp;
        }
        #endregion

        #region FastReports
        /// <summary>
        /// FastReports
        /// </summary>
        /// <param name="isDesign"></param>
        private void FastReports(bool isDesign)
        {
            System.Data.DataSet printDataDs = new System.Data.DataSet();
            try
            {
                int[] rownumber = this.gridViewMainData.GetSelectedRows();
                DataRow row = this.gridViewMainData.GetDataRow(rownumber[0]);
                System.Data.DataTable mainData = ToDataTable(row);
                System.Data.DataTable detailsData = ((DataView)this.gridViewDetailsData.DataSource).ToTable();
                if (mainData != null && mainData.Rows.Count > 0)
                {
                    mainData.TableName = "mainData";
                    printDataDs.Tables.Add(mainData.Copy());
                }
                if (detailsData != null && detailsData.Rows.Count > 0)
                {
                    detailsData.TableName = "detailsData";
                    printDataDs.Tables.Add(detailsData.Copy());
                }
                FastReport.Report report = new FastReport.Report();
                Res.LocaleFolder = AppDomain.CurrentDomain.BaseDirectory + "FastReports\\Localization";
                Res.LoadLocale(Res.LocaleFolder + @"\Chinese (Simplified).frl");
                string FDataTables = "FDataTables";
                string filename = @"FastReports\Reports\fx_001.frx";
                report.Load(filename);

                using (Designer designer = new Designer())
                {
                    designer.SetModified(this, "EditData");  
                    int i = 0;
                    foreach (DataTable dt in printDataDs.Tables)
                    {
                        FDataTables = "FDataTables" + i.ToString();
                        printDataDs.Tables[i].TableName = FDataTables;
                        report.RegisterData(printDataDs.Tables[i], FDataTables);  
                        report.GetDataSource(FDataTables).Enabled = true;  
                        i = i + 1;
                    }
                    Res.LocaleFolder = AppDomain.CurrentDomain.BaseDirectory + "FastReports\\Localization";
                    Res.LoadLocale(Res.LocaleFolder + @"\Chinese (Simplified).frl");
                    if (isDesign)
                        report.Design(); 
                    else
                    {
                        report.SetParameterValue("time", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                        report.Prepare();
                        report.ShowPrepared();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #endregion

    }
}
