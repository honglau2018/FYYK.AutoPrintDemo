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
            this.gridControl1.Dock = DockStyle.Fill;
            GridViewColumnsAddVisible();
        }
        #endregion

        #region UI Event
        

        #region bbtnSearch_ItemClick 查询
        /// <summary>
        /// bbtnSearch_ItemClick  查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnSystemSet_ItemClick 系统置配
        /// <summary>
        /// bbtnSystemSet_ItemClick 系统置配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnSystemSet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnUserSet_ItemClick 用户置配
        /// <summary>
        /// bbtnUserSet_ItemClick 用户置配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnUserSet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnSelectAll_ItemClick 全选
        /// <summary>
        ///  bbtnSelectAll_ItemClick 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnUnSelectAll_ItemClick 全不选
        /// <summary>
        /// bbtnUnSelectAll_ItemClick 全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnUnSelectAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnPrint_ItemClick 打印
        /// <summary>
        /// bbtnPrint_ItemClick 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnPrintDesign_ItemClick 打印设计
        /// <summary>
        /// bbtnPrintDesign_ItemClick 打印设计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnPrintDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region bbtnToExcel_ItemClick 导出ToExcel
        /// <summary>
        /// bbtnToExcel_ItemClick 导出ToExcel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbtnToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }
            
        #endregion



        #endregion

        #region Private Function

        #region GridViewColumnsAddVisible
        /// <summary>
        /// GridViewColumnsAddVisible
        /// </summary>
        private void GridViewColumnsAddVisible()
        {
            string filePath = string.Format(@"{0}\GridViewHeaderJson\{1}.txt", System.Windows.Forms.Application.StartupPath, "Main_DT_JSON");
            string jsonString = System.IO.File.ReadAllText(filePath);
            Newtonsoft.Json.Linq.JArray jAarray = Newtonsoft.Json.Linq.JArray.Parse(jsonString) as Newtonsoft.Json.Linq.JArray;
            List<FYYK.Model.GridControlHeader> listDataGridViewHeader = jAarray.ToObject<List<FYYK.Model.GridControlHeader>>();
            FYYK.Util.GridControlHelper.InitializationGridControlHeader(this.gridControl1, listDataGridViewHeader);
        }
        #endregion

        #endregion


    }
}
 