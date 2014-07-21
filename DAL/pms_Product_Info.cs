using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Product_Info��
	/// </summary>
	public class pms_Product_Info
	{
		public pms_Product_Info()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ProductInfoID", "pms_Product_Info"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ProductInfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Product_Info");
			strSql.Append(" where ProductInfoID=@ProductInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4)};
			parameters[0].Value = ProductInfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Product_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Product_Info(");
			strSql.Append("ProductBatchID,CustomerRequireID,ProductTypeID,ProductStrucID,ProductMaterID,ProductIndustID,ProductInfoName,ProductPhotoNum,ProductStandard,ProductWeight,OrderQuantity,ContourSize,Remarks)");
			strSql.Append(" values (");
			strSql.Append("@ProductBatchID,@CustomerRequireID,@ProductTypeID,@ProductStrucID,@ProductMaterID,@ProductIndustID,@ProductInfoName,@ProductPhotoNum,@ProductStandard,@ProductWeight,@OrderQuantity,@ContourSize,@Remarks)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductBatchID", SqlDbType.Int,4),
					new SqlParameter("@CustomerRequireID", SqlDbType.Int,4),
					new SqlParameter("@ProductTypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductStrucID", SqlDbType.Int,4),
					new SqlParameter("@ProductMaterID", SqlDbType.Int,4),
					new SqlParameter("@ProductIndustID", SqlDbType.Int,4),
					new SqlParameter("@ProductInfoName", SqlDbType.VarChar,64),
					new SqlParameter("@ProductPhotoNum", SqlDbType.VarChar,64),
					new SqlParameter("@ProductStandard", SqlDbType.VarChar,64),
					new SqlParameter("@ProductWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OrderQuantity", SqlDbType.VarChar,64),
					new SqlParameter("@ContourSize", SqlDbType.VarChar,144),
					new SqlParameter("@Remarks", SqlDbType.Text)};
			parameters[0].Value = model.ProductBatchID;
			parameters[1].Value = model.CustomerRequireID;
			parameters[2].Value = model.ProductTypeID;
			parameters[3].Value = model.ProductStrucID;
			parameters[4].Value = model.ProductMaterID;
			parameters[5].Value = model.ProductIndustID;
			parameters[6].Value = model.ProductInfoName;
			parameters[7].Value = model.ProductPhotoNum;
			parameters[8].Value = model.ProductStandard;
			parameters[9].Value = model.ProductWeight;
			parameters[10].Value = model.OrderQuantity;
			parameters[11].Value = model.ContourSize;
			parameters[12].Value = model.Remarks;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_Product_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Product_Info set ");
			strSql.Append("ProductBatchID=@ProductBatchID,");
			strSql.Append("CustomerRequireID=@CustomerRequireID,");
			strSql.Append("ProductTypeID=@ProductTypeID,");
			strSql.Append("ProductStrucID=@ProductStrucID,");
			strSql.Append("ProductMaterID=@ProductMaterID,");
			strSql.Append("ProductIndustID=@ProductIndustID,");
			strSql.Append("ProductInfoName=@ProductInfoName,");
			strSql.Append("ProductPhotoNum=@ProductPhotoNum,");
			strSql.Append("ProductStandard=@ProductStandard,");
			strSql.Append("ProductWeight=@ProductWeight,");
			strSql.Append("OrderQuantity=@OrderQuantity,");
			strSql.Append("ContourSize=@ContourSize,");
			strSql.Append("Remarks=@Remarks");
			strSql.Append(" where ProductInfoID=@ProductInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4),
					new SqlParameter("@ProductBatchID", SqlDbType.Int,4),
					new SqlParameter("@CustomerRequireID", SqlDbType.Int,4),
					new SqlParameter("@ProductTypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductStrucID", SqlDbType.Int,4),
					new SqlParameter("@ProductMaterID", SqlDbType.Int,4),
					new SqlParameter("@ProductIndustID", SqlDbType.Int,4),
					new SqlParameter("@ProductInfoName", SqlDbType.VarChar,64),
					new SqlParameter("@ProductPhotoNum", SqlDbType.VarChar,64),
					new SqlParameter("@ProductStandard", SqlDbType.VarChar,64),
					new SqlParameter("@ProductWeight", SqlDbType.Decimal,9),
					new SqlParameter("@OrderQuantity", SqlDbType.VarChar,64),
					new SqlParameter("@ContourSize", SqlDbType.VarChar,144),
					new SqlParameter("@Remarks", SqlDbType.Text)};
			parameters[0].Value = model.ProductInfoID;
			parameters[1].Value = model.ProductBatchID;
			parameters[2].Value = model.CustomerRequireID;
			parameters[3].Value = model.ProductTypeID;
			parameters[4].Value = model.ProductStrucID;
			parameters[5].Value = model.ProductMaterID;
			parameters[6].Value = model.ProductIndustID;
			parameters[7].Value = model.ProductInfoName;
			parameters[8].Value = model.ProductPhotoNum;
			parameters[9].Value = model.ProductStandard;
			parameters[10].Value = model.ProductWeight;
			parameters[11].Value = model.OrderQuantity;
			parameters[12].Value = model.ContourSize;
			parameters[13].Value = model.Remarks;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ProductInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Product_Info ");
			strSql.Append(" where ProductInfoID=@ProductInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4)};
			parameters[0].Value = ProductInfoID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Product_Info GetModel(int ProductInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProductInfoID,ProductBatchID,CustomerRequireID,ProductTypeID,ProductStrucID,ProductMaterID,ProductIndustID,ProductInfoName,ProductPhotoNum,ProductStandard,ProductWeight,OrderQuantity,ContourSize,Remarks from pms_Product_Info ");
			strSql.Append(" where ProductInfoID=@ProductInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4)};
			parameters[0].Value = ProductInfoID;

			TSM.Model.pms_Product_Info model=new TSM.Model.pms_Product_Info();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ProductInfoID"].ToString()!="")
				{
					model.ProductInfoID=int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductBatchID"].ToString()!="")
				{
					model.ProductBatchID=int.Parse(ds.Tables[0].Rows[0]["ProductBatchID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CustomerRequireID"].ToString()!="")
				{
					model.CustomerRequireID=int.Parse(ds.Tables[0].Rows[0]["CustomerRequireID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductTypeID"].ToString()!="")
				{
					model.ProductTypeID=int.Parse(ds.Tables[0].Rows[0]["ProductTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductStrucID"].ToString()!="")
				{
					model.ProductStrucID=int.Parse(ds.Tables[0].Rows[0]["ProductStrucID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductMaterID"].ToString()!="")
				{
					model.ProductMaterID=int.Parse(ds.Tables[0].Rows[0]["ProductMaterID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductIndustID"].ToString()!="")
				{
					model.ProductIndustID=int.Parse(ds.Tables[0].Rows[0]["ProductIndustID"].ToString());
				}
				model.ProductInfoName=ds.Tables[0].Rows[0]["ProductInfoName"].ToString();
				model.ProductPhotoNum=ds.Tables[0].Rows[0]["ProductPhotoNum"].ToString();
				model.ProductStandard=ds.Tables[0].Rows[0]["ProductStandard"].ToString();
				if(ds.Tables[0].Rows[0]["ProductWeight"].ToString()!="")
				{
					model.ProductWeight=decimal.Parse(ds.Tables[0].Rows[0]["ProductWeight"].ToString());
				}
				model.OrderQuantity=ds.Tables[0].Rows[0]["OrderQuantity"].ToString();
				model.ContourSize=ds.Tables[0].Rows[0]["ContourSize"].ToString();
				model.Remarks=ds.Tables[0].Rows[0]["Remarks"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public TSM.Model.pms_Product_Info GetViewModel(int ProductInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  * from view_pms_Product_Info ");
            strSql.Append(" where ProductInfoID=@ProductInfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4)};
            parameters[0].Value = ProductInfoID;

            TSM.Model.pms_Product_Info model = new TSM.Model.pms_Product_Info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ProductInfoID"].ToString() != "")
                {
                    model.ProductInfoID = int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ProductBatchID"].ToString() != "")
                {
                    model.ProductBatchID = int.Parse(ds.Tables[0].Rows[0]["ProductBatchID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["��������"].ToString() != "")
                {
                    model.�������� = ds.Tables[0].Rows[0]["��������"].ToString();
                }
                model.��Ʒ���� = ds.Tables[0].Rows[0]["��Ʒ����"].ToString();
                model.�˿����� = ds.Tables[0].Rows[0]["�˿�����"].ToString();
                model.�˿����� = ds.Tables[0].Rows[0]["�˿�����"].ToString();
                model.�˿�Ҫ�� = ds.Tables[0].Rows[0]["�˿�Ҫ��"].ToString();
                model.��Ʒ�ṹ = ds.Tables[0].Rows[0]["��Ʒ�ṹ"].ToString();
                model.��Ʒ���� = ds.Tables[0].Rows[0]["��Ʒ����"].ToString();
                model.������ҵ = ds.Tables[0].Rows[0]["������ҵ"].ToString();
                model.ͼ�� = ds.Tables[0].Rows[0]["ͼ��"].ToString();
                model.�淶 = ds.Tables[0].Rows[0]["�淶"].ToString();
                model.���� = ds.Tables[0].Rows[0]["����"].ToString();
                model.���� = ds.Tables[0].Rows[0]["����"].ToString();
                model.������ = ds.Tables[0].Rows[0]["������"].ToString();
                model.��ע = ds.Tables[0].Rows[0]["��ע"].ToString();
                model.�������� = ds.Tables[0].Rows[0]["��������"].ToString();
                model.������ַ = ds.Tables[0].Rows[0]["������ַ"].ToString();
                model.�ϴ��ڵ� = ds.Tables[0].Rows[0]["�ϴ��ڵ�"].ToString();
                model.�ϴ�ʱ�� = ds.Tables[0].Rows[0]["�ϴ�ʱ��"].ToString();
                model.�ϴ��� = ds.Tables[0].Rows[0]["�ϴ���"].ToString();
                model.������ϵ�� = ds.Tables[0].Rows[0]["������ϵ��"].ToString();
                model.������ϵ�绰 = ds.Tables[0].Rows[0]["������ϵ�绰"].ToString();
                model.������ϵ���� = ds.Tables[0].Rows[0]["������ϵ����"].ToString();
                model.������ϵ�� = ds.Tables[0].Rows[0]["������ϵ��"].ToString();
                model.������ϵ�绰 = ds.Tables[0].Rows[0]["������ϵ�绰"].ToString();
                model.������ϵ���� = ds.Tables[0].Rows[0]["������ϵ����"].ToString();
                model.ApprovalStatus = ds.Tables[0].Rows[0]["ApprovalStatus"].ToString();
                model.QuotationInfoID = int.Parse(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString());
                model.���տͻ� = ds.Tables[0].Rows[0]["���տͻ�"].ToString();
                model.������ = ds.Tables[0].Rows[0]["������"].ToString();
                model.�������� = ds.Tables[0].Rows[0]["��������"].ToString();
                model.Ӫ��Ա���� = ds.Tables[0].Rows[0]["Ӫ��Ա����"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM view_pms_Product_Info_Final ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ProductInfoID,ProductBatchID,CustomerRequireID,ProductTypeID,ProductStrucID,ProductMaterID,ProductIndustID,ProductInfoName,ProductPhotoNum,ProductStandard,ProductWeight,OrderQuantity,ContourSize,Remarks ");
			strSql.Append(" FROM pms_Product_Info ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
            parameters[0].Value = "view_pms_Product_Info_Final";
            parameters[1].Value = "ProductInfoID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}

		#endregion  ��Ա����
	}
}

