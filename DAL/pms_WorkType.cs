using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_WorkType��
	/// </summary>
	public class pms_WorkType
	{
		public pms_WorkType()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("WorkTypeID", "pms_WorkType"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int WorkTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_WorkType");
			strSql.Append(" where WorkTypeID=@WorkTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4)};
			parameters[0].Value = WorkTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_WorkType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_WorkType(");
			strSql.Append("WorkType)");
			strSql.Append(" values (");
			strSql.Append("@WorkType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkType", SqlDbType.VarChar,20)};
			parameters[0].Value = model.WorkType;

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
		public void Update(TSM.Model.pms_WorkType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_WorkType set ");
			strSql.Append("WorkType=@WorkType");
			strSql.Append(" where WorkTypeID=@WorkTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4),
					new SqlParameter("@WorkType", SqlDbType.VarChar,20)};
			parameters[0].Value = model.WorkTypeID;
			parameters[1].Value = model.WorkType;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int WorkTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_WorkType ");
			strSql.Append(" where WorkTypeID=@WorkTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4)};
			parameters[0].Value = WorkTypeID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_WorkType GetModel(int WorkTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 WorkTypeID,WorkType from pms_WorkType ");
			strSql.Append(" where WorkTypeID=@WorkTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4)};
			parameters[0].Value = WorkTypeID;

			TSM.Model.pms_WorkType model=new TSM.Model.pms_WorkType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["WorkTypeID"].ToString()!="")
				{
					model.WorkTypeID=int.Parse(ds.Tables[0].Rows[0]["WorkTypeID"].ToString());
				}
				model.WorkType=ds.Tables[0].Rows[0]["WorkType"].ToString();
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
			strSql.Append("select WorkTypeID,WorkType ");
			strSql.Append(" FROM pms_WorkType ");
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
			strSql.Append(" WorkTypeID,WorkType ");
			strSql.Append(" FROM pms_WorkType ");
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
			parameters[0].Value = "pms_WorkType";
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

