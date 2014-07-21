using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Product_Struc��
	/// </summary>
	public class pms_Product_Struc
	{
		public pms_Product_Struc()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ProductStrucID", "pms_Product_Struc"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ProductStrucID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Product_Struc");
			strSql.Append(" where ProductStrucID=@ProductStrucID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductStrucID", SqlDbType.Int,4)};
			parameters[0].Value = ProductStrucID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Product_Struc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Product_Struc(");
			strSql.Append("ProductStruc)");
			strSql.Append(" values (");
			strSql.Append("@ProductStruc)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductStruc", SqlDbType.VarChar,64)};
			parameters[0].Value = model.ProductStruc;

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
		public void Update(TSM.Model.pms_Product_Struc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Product_Struc set ");
			strSql.Append("ProductStruc=@ProductStruc");
			strSql.Append(" where ProductStrucID=@ProductStrucID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductStrucID", SqlDbType.Int,4),
					new SqlParameter("@ProductStruc", SqlDbType.VarChar,64)};
			parameters[0].Value = model.ProductStrucID;
			parameters[1].Value = model.ProductStruc;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ProductStrucID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Product_Struc ");
			strSql.Append(" where ProductStrucID=@ProductStrucID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductStrucID", SqlDbType.Int,4)};
			parameters[0].Value = ProductStrucID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Product_Struc GetModel(int ProductStrucID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProductStrucID,ProductStruc from pms_Product_Struc ");
			strSql.Append(" where ProductStrucID=@ProductStrucID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductStrucID", SqlDbType.Int,4)};
			parameters[0].Value = ProductStrucID;

			TSM.Model.pms_Product_Struc model=new TSM.Model.pms_Product_Struc();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ProductStrucID"].ToString()!="")
				{
					model.ProductStrucID=int.Parse(ds.Tables[0].Rows[0]["ProductStrucID"].ToString());
				}
				model.ProductStruc=ds.Tables[0].Rows[0]["ProductStruc"].ToString();
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
			strSql.Append("select ProductStrucID,ProductStruc ");
			strSql.Append(" FROM pms_Product_Struc ");
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
			strSql.Append(" ProductStrucID,ProductStruc ");
			strSql.Append(" FROM pms_Product_Struc ");
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
			parameters[0].Value = "pms_Product_Struc";
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

