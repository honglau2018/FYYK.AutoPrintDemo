using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;


namespace FYYK.Util
{
    public class DevGridControlHelper
    {
        #region DynamicGenerateColumns 动态生成GridView的Columns
        /// <summary>
            /// 动态生成GridView的Columns
            /// </summary>
            /// <param name="gv"></param>
            /// <param name="dt"></param>
            /// <returns></returns>
        public static void DynamicGenerateColumns(DevExpress.XtraGrid.Views.Grid.GridView gridView,
                                                      List<FYYK.Model.GridControlHeader> gridControlHeaders  )
        {
            // 把GridView的自动产生列设置为false,否则会出现重复列
            //gridView.AutoGenerateColumns = false;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.Columns.Clear();

            if (gridControlHeaders == null || gridControlHeaders.Count <= 0)
                return ;
            foreach (var item in gridControlHeaders)
            {
                var col = new DevExpress.XtraGrid.Columns.GridColumn();
                if (string.Equals("True", item.CheckBox))
                {
                    //pDatatable.Columns.Add("选择",System.Type.GetType("System.Boolean"));
                    col.Width = 30;
                    col.OptionsColumn.ShowCaption = false;
                    col.ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                }
                string strVisible = string.IsNullOrEmpty(item.Visible) ? "False" : item.Visible;
                col.Caption = item.Caption.Trim();
                col.FieldName = item.FieldName.Trim();
                col.Visible = string.Equals(strVisible, "True") ? true : false;
                col.VisibleIndex = item.VisibleIndex;
                col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                gridView.Columns.Add(col);
            }
            //return gridView;
        }
        #endregion

        #region  GridViewColumnAutoWidth 设置GridView的最合适列宽
        /// <summary>
        /// GridViewColumnAutoWidth 设置GridView的最合适列宽
        /// </summary>
        /// <param name="gridView1"></param>
        public static void GridViewColumnAutoWidth(GridView gridView)
        {
            gridView.OptionsView.ColumnAutoWidth = false;
            for (int I = 0; I < gridView.Columns.Count; I++)
            {
                gridView.BestFitColumns();
                gridView.Columns[I].BestFit();//自动列宽
            }
        }
        #endregion

        #region InitializationGridControl 初始化GridControl数据集表头
        /// <summary>
        /// InitializationGridControl 初始化GridControl数据集表头
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="gridControlHeaders"></param>
        public static void InitializationGridControlHeader(DevExpress.XtraGrid.GridControl grid, 
                                                           List<FYYK.Model.GridControlHeader> gridControlHeaders)
        {
            /*
             gridView1.OptionsView.ColumnAutoWidth = false;
             for (int I = 0; I < gridView1.Columns.Count; I++)
            {
                this.gridView1.BestFitColumns();
                this.gridView1.Columns[I].BestFit();//自动列宽
            }*/
            try
            {
                if (gridControlHeaders == null || gridControlHeaders.Count <= 0)
                    return;
                var gdv = new DevExpress.XtraGrid.Views.Grid.GridView();
                gdv.OptionsView.ShowGroupPanel = false;
                //gdv.BestFitColumns();
                //gdv.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
                //gdv.OptionsView.ColumnAutoWidth = false;
                foreach (var item in gridControlHeaders)
                {
                    var col = new DevExpress.XtraGrid.Columns.GridColumn();
                    //columEdit
                    if (string.Equals("True", item.CheckBox))
                    {
                        //pDatatable.Columns.Add("选择",System.Type.GetType("System.Boolean"));
                        col.Width = 30;
                        col.OptionsColumn.ShowCaption = false;
                        col.ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
                        

                    }
                    string strVisible = string.IsNullOrEmpty(item.Visible) ? "False" : item.Visible;
                    col.Caption = item.Caption.Trim();
                    col.FieldName = item.FieldName.Trim();
                    col.Visible = string.Equals(strVisible, "True") ? true : false;
                    col.VisibleIndex = item.VisibleIndex;
                    //col.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
                    //col.BestFit();
                    gdv.Columns.Add(col);
                }
                grid.MainView = gdv;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }
        #endregion

        #region DridControlRowAlternateColor   隔行 奇偶行变色
        /// <summary>
        /// DridControlRowAlternateColor 隔行 奇偶行变色
        /// </summary>
        /// <param name="gridView"></param>
        public static void DridControlRowAlternateColor(DevExpress.XtraGrid.Views.Grid.GridView gridView                                        )
        {
            gridView.Appearance.EvenRow.BackColor = Color.FromArgb(150, 237, 243, 254);
            gridView.Appearance.OddRow.BackColor = Color.FromArgb(150, 199, 237, 204);
            gridView.OptionsView.EnableAppearanceEvenRow = true;
            gridView.OptionsView.EnableAppearanceOddRow = true;
        }
        #endregion

        #region GridViewRowStyle   改变行的效果
        /// <summary>
        /// GridViewRowStyle
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void GridViewRowStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView, 
                                        DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            DevExpress.Utils.AppearanceDefault appNotPass1 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Salmon, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            DevExpress.Utils.AppearanceDefault appNotPass2 = new DevExpress.Utils.AppearanceDefault(Color.Black, Color.Yellow, Color.Empty, Color.SeaShell, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

            System.Data.DataRow dr = gridView.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                if (dr["sex"].ToString() == "女" && dr["birthday1"].ToString().Trim() == "55")
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass2);
                else if (dr["sex"].ToString() == "男" && dr["birthday1"].ToString().Trim() == "60")
                    DevExpress.Utils.AppearanceHelper.Apply(e.Appearance, appNotPass1);
            }
        }
        #endregion

        #region  BestFitColumns 设置GridView的最合适列宽
        /// <summary>
        /// 设置GridView的最合适列宽
        /// </summary>
        /// <param name="gridView1"></param>
        public static void BestFitColumns(GridView gridView)
        {
            gridView.BeginUpdate();
            gridView.BestFitMaxRowCount = 1000;
            gridView.OptionsView.ColumnAutoWidth = false;
            int iWidth = 0;
            foreach (GridColumn pGridColumn in gridView.Columns)
            {
                if (pGridColumn.Visible == false) continue;

                pGridColumn.OptionsColumn.FixedWidth = false;
                pGridColumn.OptionsColumn.AllowSize = true;
                pGridColumn.BestFit();

                iWidth += pGridColumn.Width;
            }
            if (gridView.GridControl != null)
            {
                if (iWidth < gridView.GridControl.Width)
                {
                    gridView.OptionsView.ColumnAutoWidth = true;
                    gridView.BestFitColumns();
                }
            }
            gridView.EndUpdate();
        }
        #endregion 

        #region  SetGridViewOptions 设置GridView的基本属性，去掉右键弹出菜单，不能拖动列等属性
        /// <summary>
        /// 设置GridView的基本属性，去掉右键弹出菜单，不能拖动列等属性
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        public static void SetGridViewOptions(GridView gridView)
        {
            gridView.OptionsView.EnableAppearanceOddRow = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsCustomization.AllowColumnMoving = false;
            gridView.OptionsCustomization.AllowGroup = false;
            gridView.OptionsCustomization.AllowFilter = false;
            gridView.OptionsCustomization.AllowSort = false;
            gridView.OptionsMenu.EnableColumnMenu = false;
            gridView.OptionsMenu.EnableFooterMenu = false;
            gridView.OptionsMenu.EnableGroupPanelMenu = false;
            gridView.OptionsView.ShowGroupPanel = false;//不显示分组
            gridView.OptionsView.EnableAppearanceEvenRow = true;
        }
        #endregion 

        #region  SetGridViewColumnVisible 根据列名设置列隐藏
        /// <summary>
        /// 根据列名设置列隐藏
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        /// <param name="columnName">列名</param>
        public static void SetGridViewColumnVisible(GridView gridView, string columnName)
        {
            SetGridViewColumnVisible(gridView, columnName, false);
        }
        #endregion 

        #region  SetGridViewColumnVisible 根据列名设置列是否隐藏
        /// <summary>
        /// 根据列名设置列是否隐藏
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        /// <param name="columnName">列名</param>
        /// <param name="isVisible">列是否隐藏</param>
        public static void SetGridViewColumnVisible(GridView gridView, string columnName, bool isVisible)
        {
            gridView.Columns[columnName].Visible = isVisible;
        }
        #endregion 

        #region  SetGridViewColumnEdit 根据列名设置列不可编辑
        /// <summary>
        /// 根据列名设置列不可编辑
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        /// <param name="columnName">列名</param>
        public static void SetGridViewColumnEdit(GridView gridView, string columnName)
        {
            SetGridViewColumnEdit(gridView, columnName, false);
        }
        #endregion 

        #region  SetGridViewColumnEdit 设置所有列不可编辑
        /// <summary>
        /// 设置所有列不可编辑
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        public static void SetGridViewColumnEdit(GridView gridView)
        {
            if (gridView != null)
                if (gridView.Columns != null)
                    foreach (GridColumn item in gridView.Columns)
                        item.OptionsColumn.AllowEdit = false;
        }
        #endregion 

        #region  SetGridViewColumnEdit 根据列名设置列是否可编辑
        /// <summary>
        /// 根据列名设置列是否可编辑
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        /// <param name="columnName">列名</param>
        /// <param name="isEdit">列是否可以编辑</param>
        public static void SetGridViewColumnEdit(GridView gridView, string columnName, bool isEdit)
        {
            gridView.Columns[columnName].OptionsColumn.AllowEdit = isEdit;
        }
        #endregion 

        #region  SetGridViewColumnLookUpEdit 根据列名构建Grid中下拉列表
        /// <summary>
        /// 根据列名构建Grid中下拉列表
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        /// <param name="ColumnName">列名</param>
        /// <param name="dataSC">下拉列表数据源</param>
        /// <param name="DisplayMember">显示数据</param>
        /// <param name="ValueMember">实际需要的数据</param>
        /// <param name="SCrows">数据行数</param>
        /// <param name="nullText">选择空显示内容</param>
        public static RepositoryItemLookUpEdit SetGridViewColumnLookUpEdit(GridView gridView, string ColumnName, object dataSC, string DisplayMember, string ValueMember, int SCrows, string nullText = "")
        {
            try
            {
                RepositoryItemLookUpEdit repositoryItemLookUpEdit1 = new RepositoryItemLookUpEdit();
                #region 下拉列表设置
                repositoryItemLookUpEdit1.AutoHeight = false;
                //    repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
                repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(DisplayMember, DisplayMember)});
                repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
                repositoryItemLookUpEdit1.PopupFormMinSize = new System.Drawing.Size(22, 0);
                repositoryItemLookUpEdit1.ShowFooter = false;
                repositoryItemLookUpEdit1.NullText = nullText;
                repositoryItemLookUpEdit1.ShowHeader = false;
                repositoryItemLookUpEdit1.DataSource = dataSC;
                repositoryItemLookUpEdit1.DisplayMember = DisplayMember;
                repositoryItemLookUpEdit1.ValueMember = ValueMember;
                if (SCrows < 7)
                    repositoryItemLookUpEdit1.DropDownRows = SCrows;
                #endregion
                if (!string.IsNullOrEmpty(ColumnName))
                    gridView.Columns[ColumnName].ColumnEdit = repositoryItemLookUpEdit1;
                return repositoryItemLookUpEdit1;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            return null;
        }
        #endregion 

        #region  SetGridViewColumnLinkBtn 根据列名和控件，构建linkButton
        /// <summary>
        /// 根据列名和控件，构建linkButton
        /// </summary>
        /// <param name="gridView">表格控件</param>
        /// <param name="ColumnName">列</param>
        /// <returns></returns>
        public static RepositoryItemHyperLinkEdit SetGridViewColumnLinkBtn(GridView gridView, string ColumnName)
        {
            try
            {
                RepositoryItemHyperLinkEdit repositoryItemLookUpEdit1 = new RepositoryItemHyperLinkEdit();
                repositoryItemLookUpEdit1.AutoHeight = false;
                repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
                if (!string.IsNullOrEmpty(ColumnName))
                    gridView.Columns[ColumnName].ColumnEdit = repositoryItemLookUpEdit1;
                return repositoryItemLookUpEdit1;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }
        #endregion 

        #region  SerGirdViewLoookUpEditSc 根据列名更新数据源
        /// <summary>
        /// 根据列名更新数据源
        /// </summary>
        /// <param name="gridView">Grid控件</param>
        /// <param name="ColumnName">列名</param>
        /// <param name="dataSC">下拉列表数据源</param>
        /// <param name="SCrows">数据行数</param>
        public static void SerGirdViewLoookUpEditSc(GridView gridView, string ColumnName, object dataSC, int SCrows)
        {
            if (gridView.Columns[ColumnName].ColumnEdit is RepositoryItemLookUpEdit)
            {
                ((RepositoryItemLookUpEdit)gridView.Columns[ColumnName].ColumnEdit).DataSource = dataSC;
                if (SCrows < 7)
                    ((RepositoryItemLookUpEdit)gridView.Columns[ColumnName].ColumnEdit).DropDownRows = SCrows;
            }
        }
        #endregion 

        #region  AddGridViewColumns 向GridView添加列
        /// <summary>
        /// 向GridView添加列
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="nameAndFieldDic">显示名称与绑定字段字典</param>
        public static void AddGridViewColumns(GridView gridView, Dictionary<string, string> nameAndFieldDic)
        {
            foreach (var item in nameAndFieldDic)
            {
                GridColumn gc = new GridColumn();
                gc.Caption = item.Key;
                gc.FieldName = item.Value;
                gc.Name = "gridColumn" + item;
                gc.Visible = true;
                //gc.VisibleIndex = _visibleIndex++;
                gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                gc.OptionsColumn.AllowMove = false;
                gc.OptionsColumn.AllowEdit = false;
                gridView.Columns.Add(gc);
            }
        }
        #endregion 

        #region  AddGridViewColumns 向GridView添加列
        /// <summary>
        /// AddGridViewColumns 向GridView添加列
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="nameAndFieldDic">列名数组</param>
        public static void AddGridViewColumns(GridView gridView, string[] columnNames)
        {
            foreach (var item in columnNames)
            {
                GridColumn gc = new GridColumn();
                gc.Caption = item;
                gc.FieldName = item;
                gc.Name = "gridColumn" + item;
                gc.Visible = true;
                //gc.VisibleIndex = _visibleIndex++;
                gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                gc.OptionsColumn.AllowMove = false;
                gc.OptionsColumn.AllowEdit = false;
                gridView.Columns.Add(gc);
            }
        }
        #endregion 

        #region  SetGridViewColumnHAlignment 根据列名设置列的标题和单元的水平对齐方式
        /// <summary>
        ///SetGridViewColumnHAlignment 根据列名设置列的标题和单元的水平对齐方式
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="columnName"></param>
        /// <param name="cellHorzAlignment">列单元水平对齐方式</param>
        /// <param name="headerHorzAlignment">列标题水平对齐方式</param>
        public static void SetGridViewColumnHAlignment(GridView gridView, string columnName, HorzAlignment cellHorzAlignment, HorzAlignment headerHorzAlignment)
        {
            gridView.Columns[columnName].AppearanceCell.TextOptions.HAlignment = cellHorzAlignment;
            gridView.Columns[columnName].AppearanceHeader.TextOptions.HAlignment = headerHorzAlignment;
        }
        #endregion 

        #region  SetGridViewHAlignment 设置所有列的标题和单元的水平对齐方式
        /// <summary>
        /// SetGridViewHAlignment 设置所有列的标题和单元的水平对齐方式
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="cellHorzAlignment">列单元水平对齐方式</param>
        /// <param name="headerHorzAlignment">列标题水平对齐方式</param>
        public static void SetGridViewHAlignment(GridView gridView, HorzAlignment cellHorzAlignment, HorzAlignment headerHorzAlignment)
        {
            if (gridView != null)
            {
                if (gridView.Columns != null)
                {
                    foreach (GridColumn item in gridView.Columns)
                    {
                        item.AppearanceCell.TextOptions.HAlignment = cellHorzAlignment;
                        item.AppearanceHeader.TextOptions.HAlignment = headerHorzAlignment;
                    }
                }
            }

        }
        #endregion 
    }
}


