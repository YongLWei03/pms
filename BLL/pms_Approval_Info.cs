using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Approval_Info ��ժҪ˵����
	/// </summary>
	public class pms_Approval_Info
	{
		private readonly TSM.DAL.pms_Approval_Info dal=new TSM.DAL.pms_Approval_Info();
		public pms_Approval_Info()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ApprovalInfoID)
		{
			return dal.Exists(ApprovalInfoID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Approval_Info model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Approval_Info model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ApprovalInfoID)
		{
			
			dal.Delete(ApprovalInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Approval_Info GetModel(int ApprovalInfoID)
		{
			
			return dal.GetModel(ApprovalInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Approval_Info GetModelByCache(int ApprovalInfoID)
		{
			
			string CacheKey = "pms_Approval_InfoModel-" + ApprovalInfoID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ApprovalInfoID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Approval_Info)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Approval_Info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Approval_Info> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Approval_Info> modelList = new List<TSM.Model.pms_Approval_Info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Approval_Info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Approval_Info();
					if(dt.Rows[n]["ApprovalInfoID"].ToString()!="")
					{
						model.ApprovalInfoID=int.Parse(dt.Rows[n]["ApprovalInfoID"].ToString());
					}
					if(dt.Rows[n]["QuotationInfoID"].ToString()!="")
					{
						model.QuotationInfoID=int.Parse(dt.Rows[n]["QuotationInfoID"].ToString());
					}
					if(dt.Rows[n]["UserInfoID"].ToString()!="")
					{
						model.UserInfoID=int.Parse(dt.Rows[n]["UserInfoID"].ToString());
					}
					if(dt.Rows[n]["QuotationRate"].ToString()!="")
					{
						model.QuotationRate=int.Parse(dt.Rows[n]["QuotationRate"].ToString());
					}
					if(dt.Rows[n]["TransportRate"].ToString()!="")
					{
						model.TransportRate=int.Parse(dt.Rows[n]["TransportRate"].ToString());
					}
					if(dt.Rows[n]["TestingRate"].ToString()!="")
					{
						model.TestingRate=int.Parse(dt.Rows[n]["TestingRate"].ToString());
					}
					if(dt.Rows[n]["PackingRate"].ToString()!="")
					{
						model.PackingRate=int.Parse(dt.Rows[n]["PackingRate"].ToString());
					}
					if(dt.Rows[n]["KnifeRate"].ToString()!="")
					{
						model.KnifeRate=int.Parse(dt.Rows[n]["KnifeRate"].ToString());
					}
					if(dt.Rows[n]["ToolRate"].ToString()!="")
					{
						model.ToolRate=int.Parse(dt.Rows[n]["ToolRate"].ToString());
					}
					if(dt.Rows[n]["ApprovalDate"].ToString()!="")
					{
						model.ApprovalDate=DateTime.Parse(dt.Rows[n]["ApprovalDate"].ToString());
					}
					model.Remarks=dt.Rows[n]["Remarks"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			return dal.GetList(PageSize,PageIndex,strWhere);
		}

		#endregion  ��Ա����
	}
}

