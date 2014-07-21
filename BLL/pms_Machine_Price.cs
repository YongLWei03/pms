using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Machine_Price ��ժҪ˵����
	/// </summary>
	public class pms_Machine_Price
	{
		private readonly TSM.DAL.pms_Machine_Price dal=new TSM.DAL.pms_Machine_Price();
		public pms_Machine_Price()
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
		public bool Exists(int MachinePriceID)
		{
			return dal.Exists(MachinePriceID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Machine_Price model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Machine_Price model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int MachinePriceID)
		{
			
			dal.Delete(MachinePriceID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Machine_Price GetModel(int MachinePriceID)
		{
			
			return dal.GetModel(MachinePriceID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Machine_Price GetModelByCache(int MachinePriceID)
		{
			
			string CacheKey = "pms_Machine_PriceModel-" + MachinePriceID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(MachinePriceID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Machine_Price)objModel;
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
		public List<TSM.Model.pms_Machine_Price> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Machine_Price> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Machine_Price> modelList = new List<TSM.Model.pms_Machine_Price>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Machine_Price model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Machine_Price();
					if(dt.Rows[n]["MachinePriceID"].ToString()!="")
					{
						model.MachinePriceID=int.Parse(dt.Rows[n]["MachinePriceID"].ToString());
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
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			return dal.GetList(PageSize,PageIndex,strWhere);
		}

		#endregion  ��Ա����
	}
}

