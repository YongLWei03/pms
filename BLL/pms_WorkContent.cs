using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_WorkContent ��ժҪ˵����
	/// </summary>
	public class pms_WorkContent
	{
		private readonly TSM.DAL.pms_WorkContent dal=new TSM.DAL.pms_WorkContent();
		public pms_WorkContent()
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
		public bool Exists(int WorkContentID)
		{
			return dal.Exists(WorkContentID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_WorkContent model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_WorkContent model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int WorkContentID)
		{
			
			dal.Delete(WorkContentID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_WorkContent GetModel(int WorkContentID)
		{
			
			return dal.GetModel(WorkContentID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_WorkContent GetModelByCache(int WorkContentID)
		{
			
			string CacheKey = "pms_WorkContentModel-" + WorkContentID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(WorkContentID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_WorkContent)objModel;
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
		public List<TSM.Model.pms_WorkContent> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_WorkContent> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_WorkContent> modelList = new List<TSM.Model.pms_WorkContent>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_WorkContent model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_WorkContent();
					if(dt.Rows[n]["WorkContentID"].ToString()!="")
					{
						model.WorkContentID=int.Parse(dt.Rows[n]["WorkContentID"].ToString());
					}
					model.WorkContent=dt.Rows[n]["WorkContent"].ToString();
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

