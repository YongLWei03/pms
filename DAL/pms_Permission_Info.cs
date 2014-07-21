using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Permission_Info��
	/// </summary>
	public class pms_Permission_Info
	{
		public pms_Permission_Info()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PermissionInfoID", "pms_Permission_Info"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int PermissionInfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Permission_Info");
			strSql.Append(" where PermissionInfoID=@PermissionInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionInfoID", SqlDbType.Int,4)};
			parameters[0].Value = PermissionInfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Permission_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Permission_Info(");
			strSql.Append("Permission)");
			strSql.Append(" values (");
			strSql.Append("@Permission)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Permission", SqlDbType.VarChar,64)};
			parameters[0].Value = model.Permission;

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
		public void Update(TSM.Model.pms_Permission_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Permission_Info set ");
			strSql.Append("Permission=@Permission");
			strSql.Append(" where PermissionInfoID=@PermissionInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionInfoID", SqlDbType.Int,4),
					new SqlParameter("@Permission", SqlDbType.VarChar,64)};
			parameters[0].Value = model.PermissionInfoID;
			parameters[1].Value = model.Permission;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int PermissionInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Permission_Info ");
			strSql.Append(" where PermissionInfoID=@PermissionInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionInfoID", SqlDbType.Int,4)};
			parameters[0].Value = PermissionInfoID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Permission_Info GetModel(int PermissionInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PermissionInfoID,Permission from pms_Permission_Info ");
			strSql.Append(" where PermissionInfoID=@PermissionInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PermissionInfoID", SqlDbType.Int,4)};
			parameters[0].Value = PermissionInfoID;

			TSM.Model.pms_Permission_Info model=new TSM.Model.pms_Permission_Info();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["PermissionInfoID"].ToString()!="")
				{
					model.PermissionInfoID=int.Parse(ds.Tables[0].Rows[0]["PermissionInfoID"].ToString());
				}
				model.Permission=ds.Tables[0].Rows[0]["Permission"].ToString();
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
			strSql.Append("select PermissionInfoID,Permission ");
			strSql.Append(" FROM pms_Permission_Info ");
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
			strSql.Append(" PermissionInfoID,Permission ");
			strSql.Append(" FROM pms_Permission_Info ");
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
			parameters[0].Value = "pms_Permission_Info";
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

