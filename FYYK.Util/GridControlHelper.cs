using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYYK.Util
{
    public class GridControlHelper
    {
        #region InitializationGridControl 初始化GridControl数据集表头
        /// <summary>
        /// InitializationGridControl 初始化GridControl数据集表头
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="gridControlHeaders"></param>
        public static void InitializationGridControlHeader(DevExpress.XtraGrid.GridControl grid, 
                                                           List<FYYK.Model.GridControlHeader> gridControlHeaders)
        {
            try
            {
                if (gridControlHeaders == null || gridControlHeaders.Count <= 0)
                    return;
                var gdv = new DevExpress.XtraGrid.Views.Grid.GridView();//
                gdv.OptionsView.ShowGroupPanel = false;

                foreach (var item in gridControlHeaders)
                {
                    var col = new DevExpress.XtraGrid.Columns.GridColumn();
                    string strVisible = string.IsNullOrEmpty(item.Visible) ? "False" : item.Visible;
                    col.Caption = item.Caption;
                    col.FieldName = item.FieldName;
                    col.Visible = string.Equals(strVisible, "True") ? true : false;
                    col.VisibleIndex = item.VisibleIndex;
                    gdv.Columns.Add(col);
                }
                grid.MainView = gdv;//将gdv设置为MainView
                //grid.Datasource = list; //加载数据
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
        #endregion
    }
}
