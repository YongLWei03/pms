using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_Product_Info ��ժҪ˵����
	/// </summary>
	public class pms_Product_Info
	{
		private readonly TSM.DAL.pms_Product_Info dal=new TSM.DAL.pms_Product_Info();
		public pms_Product_Info()
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
		public bool Exists(int ProductInfoID)
		{
			return dal.Exists(ProductInfoID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_Product_Info model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Product_Info model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ProductInfoID)
		{
			
			dal.Delete(ProductInfoID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Product_Info GetModel(int ProductInfoID)
		{
			
			return dal.GetModel(ProductInfoID);
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public TSM.Model.pms_Product_Info GetViewModel(int ProductInfoID)
        {

            return dal.GetViewModel(ProductInfoID);
        }

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_Product_Info GetModelByCache(int ProductInfoID)
		{
			
			string CacheKey = "pms_Product_InfoModel-" + ProductInfoID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ProductInfoID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_Product_Info)objModel;
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
		public List<TSM.Model.pms_Product_Info> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_Product_Info> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_Product_Info> modelList = new List<TSM.Model.pms_Product_Info>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_Product_Info model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_Product_Info();
					if(dt.Rows[n]["ProductInfoID"].ToString()!="")
					{
						model.ProductInfoID=int.Parse(dt.Rows[n]["ProductInfoID"].ToString());
					}
					if(dt.Rows[n]["ProductBatchID"].ToString()!="")
					{
						model.ProductBatchID=int.Parse(dt.Rows[n]["ProductBatchID"].ToString());
					}
					if(dt.Rows[n]["CustomerRequireID"].ToString()!="")
					{
						model.CustomerRequireID=int.Parse(dt.Rows[n]["CustomerRequireID"].ToString());
					}
					if(dt.Rows[n]["ProductTypeID"].ToString()!="")
					{
						model.ProductTypeID=int.Parse(dt.Rows[n]["ProductTypeID"].ToString());
					}
					if(dt.Rows[n]["ProductStrucID"].ToString()!="")
					{
						model.ProductStrucID=int.Parse(dt.Rows[n]["ProductStrucID"].ToString());
					}
					if(dt.Rows[n]["ProductMaterID"].ToString()!="")
					{
						model.ProductMaterID=int.Parse(dt.Rows[n]["ProductMaterID"].ToString());
					}
					if(dt.Rows[n]["ProductIndustID"].ToString()!="")
					{
						model.ProductIndustID=int.Parse(dt.Rows[n]["ProductIndustID"].ToString());
					}
					model.ProductInfoName=dt.Rows[n]["ProductInfoName"].ToString();
					model.ProductPhotoNum=dt.Rows[n]["ProductPhotoNum"].ToString();
					model.ProductStandard=dt.Rows[n]["ProductStandard"].ToString();
					if(dt.Rows[n]["ProductWeight"].ToString()!="")
					{
						model.ProductWeight=decimal.Parse(dt.Rows[n]["ProductWeight"].ToString());
					}
					model.OrderQuantity=dt.Rows[n]["OrderQuantity"].ToString();
					model.ContourSize=dt.Rows[n]["ContourSize"].ToString();
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

