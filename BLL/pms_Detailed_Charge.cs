using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Detailed_Charge ��ժҪ˵����
	/// </summary>
	public class pms_Detailed_Charge
	{
		private readonly TSM.DAL.pms_Detailed_Charge dal=new TSM.DAL.pms_Detailed_Charge();
		public pms_Detailed_Charge()
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
		public bool Exists(int DetailedChargeID)
		{
			return dal.Exists(DetailedChargeID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Detailed_Charge model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Detailed_Charge model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int DetailedChargeID)
		{
			
			dal.Delete(DetailedChargeID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Detailed_Charge GetModel(int DetailedChargeID)
		{
			
			return dal.GetModel(DetailedChargeID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Detailed_Charge GetModelByCache(int DetailedChargeID)
		{
			
			string CacheKey = "pms_Detailed_ChargeModel-" + DetailedChargeID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DetailedChargeID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Detailed_Charge)objModel;
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
		public List<TSM.Model.pms_Detailed_Charge> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Detailed_Charge> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Detailed_Charge> modelList = new List<TSM.Model.pms_Detailed_Charge>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Detailed_Charge model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Detailed_Charge();
					if(dt.Rows[n]["DetailedChargeID"].ToString()!="")
					{
						model.DetailedChargeID=int.Parse(dt.Rows[n]["DetailedChargeID"].ToString());
					}
					if(dt.Rows[n]["QuotationInfoID"].ToString()!="")
					{
						model.QuotationInfoID=int.Parse(dt.Rows[n]["QuotationInfoID"].ToString());
					}
					model.DeviceType=dt.Rows[n]["DeviceType"].ToString();
					model.DeviceDescript=dt.Rows[n]["DeviceDescript"].ToString();
					if(dt.Rows[n]["InternalCost"].ToString()!="")
					{
						model.InternalCost=int.Parse(dt.Rows[n]["InternalCost"].ToString());
					}
					if(dt.Rows[n]["InternalPrice"].ToString()!="")
					{
						model.InternalPrice=int.Parse(dt.Rows[n]["InternalPrice"].ToString());
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
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

