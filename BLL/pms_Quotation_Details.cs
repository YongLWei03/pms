using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Quotation_Details ��ժҪ˵����
	/// </summary>
	public class pms_Quotation_Details
	{
		private readonly TSM.DAL.pms_Quotation_Details dal=new TSM.DAL.pms_Quotation_Details();
		public pms_Quotation_Details()
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
		public bool Exists(int QuotationDetailsID)
		{
			return dal.Exists(QuotationDetailsID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Quotation_Details model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Quotation_Details model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int QuotationDetailsID)
		{
			
			dal.Delete(QuotationDetailsID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Quotation_Details GetModel(int QuotationDetailsID)
		{
			
			return dal.GetModel(QuotationDetailsID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Quotation_Details GetModelByCache(int QuotationDetailsID)
		{
			
			string CacheKey = "pms_Quotation_DetailsModel-" + QuotationDetailsID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(QuotationDetailsID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Quotation_Details)objModel;
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
		public List<TSM.Model.pms_Quotation_Details> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Quotation_Details> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Quotation_Details> modelList = new List<TSM.Model.pms_Quotation_Details>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Quotation_Details model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Quotation_Details();
					if(dt.Rows[n]["QuotationDetailsID"].ToString()!="")
					{
						model.QuotationDetailsID=int.Parse(dt.Rows[n]["QuotationDetailsID"].ToString());
					}
					if(dt.Rows[n]["QuotationInfoID"].ToString()!="")
					{
						model.QuotationInfoID=int.Parse(dt.Rows[n]["QuotationInfoID"].ToString());
					}
					if(dt.Rows[n]["MachinePriceID"].ToString()!="")
					{
						model.MachinePriceID=int.Parse(dt.Rows[n]["MachinePriceID"].ToString());
					}
					if(dt.Rows[n]["WorkingHour"].ToString()!="")
					{
						model.WorkingHour=int.Parse(dt.Rows[n]["WorkingHour"].ToString());
					}
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

