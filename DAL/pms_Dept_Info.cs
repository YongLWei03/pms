using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Dept_Info��
	/// </summary>
	public class pms_Dept_Info
	{
		public pms_Dept_Info()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DeptInfoID", "pms_Dept_Info"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int DeptInfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Dept_Info");
			strSql.Append(" where DeptInfoID=@DeptInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptInfoID", SqlDbType.Int,4)};
			parameters[0].Value = DeptInfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Dept_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Dept_Info(");
			strSql.Append("DeptName)");
			strSql.Append(" values (");
			strSql.Append("@DeptName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptName", SqlDbType.VarChar,64)};
			parameters[0].Value = model.DeptName;

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
		public void Update(TSM.Model.pms_Dept_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Dept_Info set ");
			strSql.Append("DeptName=@DeptName");
			strSql.Append(" where DeptInfoID=@DeptInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptInfoID", SqlDbType.Int,4),
					new SqlParameter("@DeptName", SqlDbType.VarChar,64)};
			parameters[0].Value = model.DeptInfoID;
			parameters[1].Value = model.DeptName;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int DeptInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Dept_Info ");
			strSql.Append(" where DeptInfoID=@DeptInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptInfoID", SqlDbType.Int,4)};
			parameters[0].Value = DeptInfoID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Dept_Info GetModel(int DeptInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DeptInfoID,DeptName from pms_Dept_Info ");
			strSql.Append(" where DeptInfoID=@DeptInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptInfoID", SqlDbType.Int,4)};
			parameters[0].Value = DeptInfoID;

			TSM.Model.pms_Dept_Info model=new TSM.Model.pms_Dept_Info();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["DeptInfoID"].ToString()!="")
				{
					model.DeptInfoID=int.Parse(ds.Tables[0].Rows[0]["DeptInfoID"].ToString());
				}
				model.DeptName=ds.Tables[0].Rows[0]["DeptName"].ToString();
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
			strSql.Append("select DeptInfoID,DeptName ");
			strSql.Append(" FROM pms_Dept_Info ");
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
			strSql.Append(" DeptInfoID,DeptName ");
			strSql.Append(" FROM pms_Dept_Info ");
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
			parameters[0].Value = "pms_Dept_Info";
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

