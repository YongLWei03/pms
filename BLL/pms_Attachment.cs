using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Attachment ��ժҪ˵����
	/// </summary>
	public class pms_Attachment
	{
		private readonly TSM.DAL.pms_Attachment dal=new TSM.DAL.pms_Attachment();
		public pms_Attachment()
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
		public bool Exists(int AttachmentID)
		{
			return dal.Exists(AttachmentID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Attachment model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Attachment model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int AttachmentID)
		{
			
			dal.Delete(AttachmentID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Attachment GetModel(int AttachmentID)
		{
			
			return dal.GetModel(AttachmentID);
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public TSM.Model.pms_Attachment GetModel1(int ProductInfoID)
        {

            return dal.GetModel1(ProductInfoID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public TSM.Model.pms_Attachment GetModel2(int ProductInfoID)
        {

            return dal.GetModel2(ProductInfoID);
        }

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Attachment GetModelByCache(int AttachmentID)
		{
			
			string CacheKey = "pms_AttachmentModel-" + AttachmentID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(AttachmentID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Attachment)objModel;
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
		public List<TSM.Model.pms_Attachment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Attachment> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Attachment> modelList = new List<TSM.Model.pms_Attachment>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Attachment model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Attachment();
					if(dt.Rows[n]["AttachmentID"].ToString()!="")
					{
						model.AttachmentID=int.Parse(dt.Rows[n]["AttachmentID"].ToString());
					}
					if(dt.Rows[n]["ProductInfoID"].ToString()!="")
					{
						model.ProductInfoID=int.Parse(dt.Rows[n]["ProductInfoID"].ToString());
					}
					if(dt.Rows[n]["UploadUid"].ToString()!="")
					{
						model.UploadUid=int.Parse(dt.Rows[n]["UploadUid"].ToString());
					}
					model.AttachmentName=dt.Rows[n]["AttachmentName"].ToString();
					model.AttachmentAddr=dt.Rows[n]["AttachmentAddr"].ToString();
					model.UploadPermission=dt.Rows[n]["UploadPermission"].ToString();
					if(dt.Rows[n]["UploadTime"].ToString()!="")
					{
						model.UploadTime=DateTime.Parse(dt.Rows[n]["UploadTime"].ToString());
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

