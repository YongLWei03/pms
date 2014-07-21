﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FineUI;

namespace EmptyProjectNet20
{
    public partial class pms_Customer_Info : System.Web.UI.Page
    {
        private TSM.BLL.pms_Company_Info m_bllpms_Company_Info = new TSM.BLL.pms_Company_Info();

        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {


            btnNew.OnClientClick = Window1.GetShowReference("~/pms_Customer_Info_new.aspx", "添加新顾客");

            //// 默认的排序列和排序方向
            //Grid1.SortColumnIndex = 0;
            //Grid1.SortDirection = "DESC";

            // 每页记录数
            Grid1.PageSize = 25;

            //// 点击删除按钮时，至少选中一项
            //ResolveDeleteGridItem(btnDeleteSelected, Grid1);

            BindGrid();
        }

        private void BindGrid()
        {
            DataSet ds;
            string searchText = ttbSearchMessage.Text.Trim();
            string strWhere = "";
            if (!String.IsNullOrEmpty(searchText))
            {
                strWhere = "CompanyName like '%" + searchText + "%'";
            }

            ds = m_bllpms_Company_Info.GetList(strWhere);
            // 在查询添加之后，排序和分页之前获取总记录数
            // Grid1总共有多少条记录
            Grid1.RecordCount = ds.Tables[0].Rows.Count;

            ds = m_bllpms_Company_Info.GetList(Grid1.PageSize, Grid1.PageIndex + 1, strWhere);


            Grid1.DataSource = ds.Tables[0];
            Grid1.DataBind();
        }

        #endregion

        #region Events

        protected void ttbSearchMessage_Trigger2Click(object sender, EventArgs e)
        {
            ttbSearchMessage.ShowTrigger1 = true;
            BindGrid();
        }

        protected void ttbSearchMessage_Trigger1Click(object sender, EventArgs e)
        {
            ttbSearchMessage.Text = String.Empty;
            ttbSearchMessage.ShowTrigger1 = false;
            BindGrid();
        }

        protected void Grid1_PreDataBound(object sender, EventArgs e)
        {
            // 数据绑定之前，进行权限检查
            //CheckPowerEditWithWindowField(Grid1, "editField");
            //CheckPowerDeleteWithLinkButtonField(Grid1, "deleteField");
        }


        protected void Grid1_Sort(object sender, GridSortEventArgs e)
        {
            Grid1.SortColumnIndex = e.ColumnIndex;
            BindGrid();
        }

        protected void Grid1_PageIndexChange(object sender, GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        //protected void btnDeleteSelected_Click(object sender, EventArgs e)
        //{
        //    // 在操作之前进行权限检查
        //    if (!CheckPowerDelete())
        //    {
        //        CheckPowerFailWithAlert();
        //        return;
        //    }

        //    // 从每个选中的行中获取ID（在Grid1中定义的DataKeyNames）
        //    List<int> ids = GetSelectedDataKeyIDs(Grid1);

        //    // 执行数据库操作
        //    new Delete().From<XJobTitle>()
        //         .Where(XJobTitle.IdColumn).In(ids)
        //         .Execute();

        //    //// 清空当前选中的项
        //    //Grid1.SelectedRowIndexArray = null;

        //    // 重新绑定表格
        //    BindGrid();
        //}

        protected void Grid1_RowCommand(object sender, GridCommandEventArgs e)
        {
            int id = Convert.ToInt32(Grid1.DataKeys[e.RowIndex][0]);

            if (e.CommandName == "Delete")
            {

                try
                {

                    m_bllpms_Company_Info.Delete(id);
                    BindGrid();


                }
                catch (Exception ex)
                {
                    Alert.ShowInTop(ex.ToString());
                    return;
                }


            }
        }

        protected void Window1_Close(object sender, EventArgs e)
        {
            BindGrid();
        }

        #endregion
    }
}