using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Detailed_Charge��
	/// </summary>
	public class pms_Detailed_Charge
	{
		public pms_Detailed_Charge()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DetailedChargeID", "pms_Detailed_Charge"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int DetailedChargeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Detailed_Charge");
			strSql.Append(" where DetailedChargeID=@DetailedChargeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DetailedChargeID", SqlDbType.Int,4)};
			parameters[0].Value = DetailedChargeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Detailed_Charge model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Detailed_Charge(");
			strSql.Append("QuotationInfoID,DeviceType,DeviceDescript,InternalCost,InternalPrice)");
			strSql.Append(" values (");
			strSql.Append("@QuotationInfoID,@DeviceType,@DeviceDescript,@InternalCost,@InternalPrice)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4),
					new SqlParameter("@DeviceType", SqlDbType.VarChar,64),
					new SqlParameter("@DeviceDescript", SqlDbType.VarChar,64),
					new SqlParameter("@InternalCost", SqlDbType.Int,4),
					new SqlParameter("@InternalPrice", SqlDbType.Int,4)};
			parameters[0].Value = model.QuotationInfoID;
			parameters[1].Value = model.DeviceType;
			parameters[2].Value = model.DeviceDescript;
			parameters[3].Value = model.InternalCost;
			parameters[4].Value = model.InternalPrice;

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
		public void Update(TSM.Model.pms_Detailed_Charge model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Detailed_Charge set ");
			strSql.Append("QuotationInfoID=@QuotationInfoID,");
			strSql.Append("DeviceType=@DeviceType,");
			strSql.Append("DeviceDescript=@DeviceDescript,");
			strSql.Append("InternalCost=@InternalCost,");
			strSql.Append("InternalPrice=@InternalPrice");
			strSql.Append(" where DetailedChargeID=@DetailedChargeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DetailedChargeID", SqlDbType.Int,4),
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4),
					new SqlParameter("@DeviceType", SqlDbType.VarChar,64),
					new SqlParameter("@DeviceDescript", SqlDbType.VarChar,64),
					new SqlParameter("@InternalCost", SqlDbType.Int,4),
					new SqlParameter("@InternalPrice", SqlDbType.Int,4)};
			parameters[0].Value = model.DetailedChargeID;
			parameters[1].Value = model.QuotationInfoID;
			parameters[2].Value = model.DeviceType;
			parameters[3].Value = model.DeviceDescript;
			parameters[4].Value = model.InternalCost;
			parameters[5].Value = model.InternalPrice;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int DetailedChargeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Detailed_Charge ");
			strSql.Append(" where DetailedChargeID=@DetailedChargeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DetailedChargeID", SqlDbType.Int,4)};
			parameters[0].Value = DetailedChargeID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Detailed_Charge GetModel(int DetailedChargeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DetailedChargeID,QuotationInfoID,DeviceType,DeviceDescript,InternalCost,InternalPrice from pms_Detailed_Charge ");
			strSql.Append(" where DetailedChargeID=@DetailedChargeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DetailedChargeID", SqlDbType.Int,4)};
			parameters[0].Value = DetailedChargeID;

			TSM.Model.pms_Detailed_Charge model=new TSM.Model.pms_Detailed_Charge();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["DetailedChargeID"].ToString()!="")
				{
					model.DetailedChargeID=int.Parse(ds.Tables[0].Rows[0]["DetailedChargeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString()!="")
				{
					model.QuotationInfoID=int.Parse(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString());
				}
				model.DeviceType=ds.Tables[0].Rows[0]["DeviceType"].ToString();
				model.DeviceDescript=ds.Tables[0].Rows[0]["DeviceDescript"].ToString();
				if(ds.Tables[0].Rows[0]["InternalCost"].ToString()!="")
				{
					model.InternalCost=int.Parse(ds.Tables[0].Rows[0]["InternalCost"].ToString());
				}
				if(ds.Tables[0].Rows[0]["InternalPrice"].ToString()!="")
				{
					model.InternalPrice=int.Parse(ds.Tables[0].Rows[0]["InternalPrice"].ToString());
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
			strSql.Append("select DetailedChargeID,QuotationInfoID,DeviceType,DeviceDescript,InternalCost,InternalPrice ");
			strSql.Append(" FROM pms_Detailed_Charge ");
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
			strSql.Append(" DetailedChargeID,QuotationInfoID,DeviceType,DeviceDescript,InternalCost,InternalPrice ");
			strSql.Append(" FROM pms_Detailed_Charge ");
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
			parameters[0].Value = "pms_Detailed_Charge";
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

