using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Product_Type��
	/// </summary>
	public class pms_Product_Type
	{
		public pms_Product_Type()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ProductTypeID", "pms_Product_Type"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ProductTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Product_Type");
			strSql.Append(" where ProductTypeID=@ProductTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductTypeID", SqlDbType.Int,4)};
			parameters[0].Value = ProductTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Product_Type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Product_Type(");
			strSql.Append("ProductType)");
			strSql.Append(" values (");
			strSql.Append("@ProductType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductType", SqlDbType.VarChar,64)};
			parameters[0].Value = model.ProductType;

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
		public void Update(TSM.Model.pms_Product_Type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Product_Type set ");
			strSql.Append("ProductType=@ProductType");
			strSql.Append(" where ProductTypeID=@ProductTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductTypeID", SqlDbType.Int,4),
					new SqlParameter("@ProductType", SqlDbType.VarChar,64)};
			parameters[0].Value = model.ProductTypeID;
			parameters[1].Value = model.ProductType;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ProductTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Product_Type ");
			strSql.Append(" where ProductTypeID=@ProductTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductTypeID", SqlDbType.Int,4)};
			parameters[0].Value = ProductTypeID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Product_Type GetModel(int ProductTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProductTypeID,ProductType from pms_Product_Type ");
			strSql.Append(" where ProductTypeID=@ProductTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductTypeID", SqlDbType.Int,4)};
			parameters[0].Value = ProductTypeID;

			TSM.Model.pms_Product_Type model=new TSM.Model.pms_Product_Type();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ProductTypeID"].ToString()!="")
				{
					model.ProductTypeID=int.Parse(ds.Tables[0].Rows[0]["ProductTypeID"].ToString());
				}
				model.ProductType=ds.Tables[0].Rows[0]["ProductType"].ToString();
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
			strSql.Append("select ProductTypeID,ProductType ");
			strSql.Append(" FROM pms_Product_Type ");
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
			strSql.Append(" ProductTypeID,ProductType ");
			strSql.Append(" FROM pms_Product_Type ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
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
			parameters[0].Value = "pms_Product_Type";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

