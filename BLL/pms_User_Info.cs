using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_User_Info ��ժҪ˵����
	/// </summary>
	public class pms_User_Info
	{
		private readonly TSM.DAL.pms_User_Info dal=new TSM.DAL.pms_User_Info();
		public pms_User_Info()
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
		public bool Exists(int UserInfoID)
		{
			return dal.Exists(UserInfoID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_User_Info model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_User_Info model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int UserInfoID)
		{
			
			dal.Delete(UserInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_User_Info GetModel(int UserInfoID)
		{
			
			return dal.GetModel(UserInfoID);
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public TSM.Model.pms_User_Info GetModel(string sUserName, string sPassword)
        {

            return dal.GetModel(sUserName,sPassword);
        }

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_User_Info GetModelByCache(int UserInfoID)
		{
			
			string CacheKey = "pms_User_InfoModel-" + UserInfoID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UserInfoID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_User_Info)objModel;
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
		public List<TSM.Model.pms_User_Info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_User_Info> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_User_Info> modelList = new List<TSM.Model.pms_User_Info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_User_Info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_User_Info();
					if(dt.Rows[n]["UserInfoID"].ToString()!="")
					{
						model.UserInfoID=int.Parse(dt.Rows[n]["UserInfoID"].ToString());
					}
					model.UserName=dt.Rows[n]["UserName"].ToString();
					model.Pwd=dt.Rows[n]["Pwd"].ToString();
					if(dt.Rows[n]["CompanyInfoID"].ToString()!="")
					{
						model.CompanyInfoID=int.Parse(dt.Rows[n]["CompanyInfoID"].ToString());
					}
					if(dt.Rows[n]["DeptInfoID"].ToString()!="")
					{
						model.DeptInfoID=int.Parse(dt.Rows[n]["DeptInfoID"].ToString());
					}
					if(dt.Rows[n]["PermissionInfoID"].ToString()!="")
					{
						model.PermissionInfoID=int.Parse(dt.Rows[n]["PermissionInfoID"].ToString());
					}
					model.UserTel=dt.Rows[n]["UserTel"].ToString();
					model.UserPhone=dt.Rows[n]["UserPhone"].ToString();
					model.UserMail=dt.Rows[n]["UserMail"].ToString();
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

        /// <summary>
        /// �����û��������ȡ�û���Ϣ(��¼ʱ)
        /// </summary>
        public DataSet GetUserLogin(string sUserName, string sPassword)
        {
            return dal.GetUserLogin(sUserName,sPassword);
        }

		#endregion  ��Ա����
	}
}

