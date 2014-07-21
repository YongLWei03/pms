using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Dept_Info ��ժҪ˵����
	/// </summary>
	public class pms_Dept_Info
	{
		private readonly TSM.DAL.pms_Dept_Info dal=new TSM.DAL.pms_Dept_Info();
		public pms_Dept_Info()
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
		public bool Exists(int DeptInfoID)
		{
			return dal.Exists(DeptInfoID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Dept_Info model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Dept_Info model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int DeptInfoID)
		{
			
			dal.Delete(DeptInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Dept_Info GetModel(int DeptInfoID)
		{
			
			return dal.GetModel(DeptInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Dept_Info GetModelByCache(int DeptInfoID)
		{
			
			string CacheKey = "pms_Dept_InfoModel-" + DeptInfoID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(DeptInfoID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Dept_Info)objModel;
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
		public List<TSM.Model.pms_Dept_Info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Dept_Info> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Dept_Info> modelList = new List<TSM.Model.pms_Dept_Info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Dept_Info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Dept_Info();
					if(dt.Rows[n]["DeptInfoID"].ToString()!="")
					{
						model.DeptInfoID=int.Parse(dt.Rows[n]["DeptInfoID"].ToString());
					}
					model.DeptName=dt.Rows[n]["DeptName"].ToString();
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

