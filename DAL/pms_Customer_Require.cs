using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Customer_Require��
	/// </summary>
	public class pms_Customer_Require
	{
		public pms_Customer_Require()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CustomerRequireID", "pms_Customer_Require"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int CustomerRequireID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Customer_Require");
			strSql.Append(" where CustomerRequireID=@CustomerRequireID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerRequireID", SqlDbType.Int,4)};
			parameters[0].Value = CustomerRequireID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Customer_Require model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Customer_Require(");
			strSql.Append("CustomerRequire)");
			strSql.Append(" values (");
			strSql.Append("@CustomerRequire)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerRequire", SqlDbType.VarChar,64)};
			parameters[0].Value = model.CustomerRequire;

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
		public void Update(TSM.Model.pms_Customer_Require model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Customer_Require set ");
			strSql.Append("CustomerRequire=@CustomerRequire");
			strSql.Append(" where CustomerRequireID=@CustomerRequireID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerRequireID", SqlDbType.Int,4),
					new SqlParameter("@CustomerRequire", SqlDbType.VarChar,64)};
			parameters[0].Value = model.CustomerRequireID;
			parameters[1].Value = model.CustomerRequire;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int CustomerRequireID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Customer_Require ");
			strSql.Append(" where CustomerRequireID=@CustomerRequireID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerRequireID", SqlDbType.Int,4)};
			parameters[0].Value = CustomerRequireID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Customer_Require GetModel(int CustomerRequireID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CustomerRequireID,CustomerRequire from pms_Customer_Require ");
			strSql.Append(" where CustomerRequireID=@CustomerRequireID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CustomerRequireID", SqlDbType.Int,4)};
			parameters[0].Value = CustomerRequireID;

			TSM.Model.pms_Customer_Require model=new TSM.Model.pms_Customer_Require();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["CustomerRequireID"].ToString()!="")
				{
					model.CustomerRequireID=int.Parse(ds.Tables[0].Rows[0]["CustomerRequireID"].ToString());
				}
				model.CustomerRequire=ds.Tables[0].Rows[0]["CustomerRequire"].ToString();
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
			strSql.Append("select CustomerRequireID,CustomerRequire ");
			strSql.Append(" FROM pms_Customer_Require ");
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
			strSql.Append(" CustomerRequireID,CustomerRequire ");
			strSql.Append(" FROM pms_Customer_Require ");
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
			parameters[0].Value = "pms_Customer_Require";
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

