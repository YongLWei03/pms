using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Attachment��
	/// </summary>
	public class pms_Attachment
	{
		public pms_Attachment()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AttachmentID", "pms_Attachment"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int AttachmentID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Attachment");
			strSql.Append(" where AttachmentID=@AttachmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AttachmentID", SqlDbType.Int,4)};
			parameters[0].Value = AttachmentID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Attachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Attachment(");
			strSql.Append("ProductInfoID,UploadUid,AttachmentName,AttachmentAddr,UploadPermission,UploadTime)");
			strSql.Append(" values (");
			strSql.Append("@ProductInfoID,@UploadUid,@AttachmentName,@AttachmentAddr,@UploadPermission,@UploadTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4),
					new SqlParameter("@UploadUid", SqlDbType.Int,4),
					new SqlParameter("@AttachmentName", SqlDbType.VarChar,64),
					new SqlParameter("@AttachmentAddr", SqlDbType.VarChar,64),
					new SqlParameter("@UploadPermission", SqlDbType.VarChar,64),
					new SqlParameter("@UploadTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ProductInfoID;
			parameters[1].Value = model.UploadUid;
			parameters[2].Value = model.AttachmentName;
			parameters[3].Value = model.AttachmentAddr;
			parameters[4].Value = model.UploadPermission;
			parameters[5].Value = model.UploadTime;

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
		public void Update(TSM.Model.pms_Attachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Attachment set ");
			strSql.Append("ProductInfoID=@ProductInfoID,");
			strSql.Append("UploadUid=@UploadUid,");
			strSql.Append("AttachmentName=@AttachmentName,");
			strSql.Append("AttachmentAddr=@AttachmentAddr,");
			strSql.Append("UploadPermission=@UploadPermission,");
			strSql.Append("UploadTime=@UploadTime");
			strSql.Append(" where AttachmentID=@AttachmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AttachmentID", SqlDbType.Int,4),
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4),
					new SqlParameter("@UploadUid", SqlDbType.Int,4),
					new SqlParameter("@AttachmentName", SqlDbType.VarChar,64),
					new SqlParameter("@AttachmentAddr", SqlDbType.VarChar,64),
					new SqlParameter("@UploadPermission", SqlDbType.VarChar,64),
					new SqlParameter("@UploadTime", SqlDbType.DateTime)};
			parameters[0].Value = model.AttachmentID;
			parameters[1].Value = model.ProductInfoID;
			parameters[2].Value = model.UploadUid;
			parameters[3].Value = model.AttachmentName;
			parameters[4].Value = model.AttachmentAddr;
			parameters[5].Value = model.UploadPermission;
			parameters[6].Value = model.UploadTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int AttachmentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Attachment ");
			strSql.Append(" where AttachmentID=@AttachmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AttachmentID", SqlDbType.Int,4)};
			parameters[0].Value = AttachmentID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Attachment GetModel(int AttachmentID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AttachmentID,ProductInfoID,UploadUid,AttachmentName,AttachmentAddr,UploadPermission,UploadTime from pms_Attachment ");
			strSql.Append(" where AttachmentID=@AttachmentID ");
			SqlParameter[] parameters = {
					new SqlParameter("@AttachmentID", SqlDbType.Int,4)};
			parameters[0].Value = AttachmentID;

			TSM.Model.pms_Attachment model=new TSM.Model.pms_Attachment();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["AttachmentID"].ToString()!="")
				{
					model.AttachmentID=int.Parse(ds.Tables[0].Rows[0]["AttachmentID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductInfoID"].ToString()!="")
				{
					model.ProductInfoID=int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UploadUid"].ToString()!="")
				{
					model.UploadUid=int.Parse(ds.Tables[0].Rows[0]["UploadUid"].ToString());
				}
				model.AttachmentName=ds.Tables[0].Rows[0]["AttachmentName"].ToString();
				model.AttachmentAddr=ds.Tables[0].Rows[0]["AttachmentAddr"].ToString();
				model.UploadPermission=ds.Tables[0].Rows[0]["UploadPermission"].ToString();
				if(ds.Tables[0].Rows[0]["UploadTime"].ToString()!="")
				{
					model.UploadTime=DateTime.Parse(ds.Tables[0].Rows[0]["UploadTime"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// �õ�һ������ʵ��,ͨ��ProductInfoID,ȡӪ��Ա�ϴ�����
        /// </summary>
        public TSM.Model.pms_Attachment GetModel1(int ProductInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 AttachmentID,ProductInfoID,UploadUid,AttachmentName,AttachmentAddr,UploadPermission,UploadTime from pms_Attachment ");
            strSql.Append(" where UploadPermission='Ӫ��Ա' and ProductInfoID=@ProductInfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4)};
            parameters[0].Value = ProductInfoID;

            TSM.Model.pms_Attachment model = new TSM.Model.pms_Attachment();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["AttachmentID"].ToString() != "")
                {
                    model.AttachmentID = int.Parse(ds.Tables[0].Rows[0]["AttachmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ProductInfoID"].ToString() != "")
                {
                    model.ProductInfoID = int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UploadUid"].ToString() != "")
                {
                    model.UploadUid = int.Parse(ds.Tables[0].Rows[0]["UploadUid"].ToString());
                }
                model.AttachmentName = ds.Tables[0].Rows[0]["AttachmentName"].ToString();
                model.AttachmentAddr = ds.Tables[0].Rows[0]["AttachmentAddr"].ToString();
                model.UploadPermission = ds.Tables[0].Rows[0]["UploadPermission"].ToString();
                if (ds.Tables[0].Rows[0]["UploadTime"].ToString() != "")
                {
                    model.UploadTime = DateTime.Parse(ds.Tables[0].Rows[0]["UploadTime"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// �õ�һ������ʵ��,ͨ��ProductInfoID,ȡ����Ա�ϴ�����
        /// </summary>
        public TSM.Model.pms_Attachment GetModel2(int ProductInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 AttachmentID,ProductInfoID,UploadUid,AttachmentName,AttachmentAddr,UploadPermission,UploadTime from pms_Attachment ");
            strSql.Append(" where UploadPermission='����Ա' and ProductInfoID=@ProductInfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4)};
            parameters[0].Value = ProductInfoID;

            TSM.Model.pms_Attachment model = new TSM.Model.pms_Attachment();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["AttachmentID"].ToString() != "")
                {
                    model.AttachmentID = int.Parse(ds.Tables[0].Rows[0]["AttachmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ProductInfoID"].ToString() != "")
                {
                    model.ProductInfoID = int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UploadUid"].ToString() != "")
                {
                    model.UploadUid = int.Parse(ds.Tables[0].Rows[0]["UploadUid"].ToString());
                }
                model.AttachmentName = ds.Tables[0].Rows[0]["AttachmentName"].ToString();
                model.AttachmentAddr = ds.Tables[0].Rows[0]["AttachmentAddr"].ToString();
                model.UploadPermission = ds.Tables[0].Rows[0]["UploadPermission"].ToString();
                if (ds.Tables[0].Rows[0]["UploadTime"].ToString() != "")
                {
                    model.UploadTime = DateTime.Parse(ds.Tables[0].Rows[0]["UploadTime"].ToString());
                }
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
			strSql.Append("select AttachmentID,ProductInfoID,UploadUid,AttachmentName,AttachmentAddr,UploadPermission,UploadTime ");
			strSql.Append(" FROM pms_Attachment ");
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
			strSql.Append(" AttachmentID,ProductInfoID,UploadUid,AttachmentName,AttachmentAddr,UploadPermission,UploadTime ");
			strSql.Append(" FROM pms_Attachment ");
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
			parameters[0].Value = "pms_Attachment";
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

