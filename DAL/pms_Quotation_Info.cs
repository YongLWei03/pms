using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//�����������
namespace TSM.DAL
{
	/// <summary>
	/// ���ݷ�����pms_Quotation_Info��
	/// </summary>
	public class pms_Quotation_Info
	{
		public pms_Quotation_Info()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("QuotationInfoID", "pms_Quotation_Info"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int QuotationInfoID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from pms_Quotation_Info");
			strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4)};
			parameters[0].Value = QuotationInfoID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(TSM.Model.pms_Quotation_Info model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into pms_Quotation_Info(");
            strSql.Append("ProductInfoID,QuotationDepart,UserInfoID,KnifeCharges,ToolCharges,QuotationPrice,ApprovalStatus,QuotationTime,SprayingCharges,PackingCharges,TestingCharges,TransportCharges,");
            strSql.Append("SprayingDescrib,PackingDescrib,TestingDescrib,TransportDescrib,ChargeDescrib,KinfeDescrib,ToolsDescrib)");
            strSql.Append(" values (");
			strSql.Append("@ProductInfoID,@QuotationDepart,@UserInfoID,@KnifeCharges,@ToolCharges,@QuotationPrice,@ApprovalStatus,@QuotationTime,@SprayingCharges,@PackingCharges,@TestingCharges,@TransportCharges,");
            strSql.Append("@SprayingDescrib,@PackingDescrib,@TestingDescrib,@TransportDescrib,@ChargeDescrib,@KinfeDescrib,@ToolsDescrib)");
            strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4),
					new SqlParameter("@QuotationDepart", SqlDbType.Int,4),
                    new SqlParameter("@UserInfoID", SqlDbType.Int,4),
					new SqlParameter("@KnifeCharges", SqlDbType.Decimal,9),
					new SqlParameter("@ToolCharges", SqlDbType.Decimal,9),
					new SqlParameter("@QuotationPrice", SqlDbType.Decimal,9),
					new SqlParameter("@ApprovalStatus", SqlDbType.VarChar,64),
					new SqlParameter("@QuotationTime", SqlDbType.DateTime),
					new SqlParameter("@SprayingCharges", SqlDbType.Decimal,9),
					new SqlParameter("@PackingCharges", SqlDbType.Decimal,9),
					new SqlParameter("@TestingCharges", SqlDbType.Decimal,9),
					new SqlParameter("@TransportCharges", SqlDbType.Decimal,9),
                    new SqlParameter("@SprayingDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@PackingDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@TestingDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@TransportDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@ChargeDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@KinfeDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@ToolsDescrib", SqlDbType.NVarChar,64)
                                        };
			parameters[0].Value = model.ProductInfoID;
			parameters[1].Value = model.QuotationDepart;
            parameters[2].Value = model.UserInfoID;
			parameters[3].Value = model.KnifeCharges;
			parameters[4].Value = model.ToolCharges;
			parameters[5].Value = model.QuotationPrice;
			parameters[6].Value = model.ApprovalStatus;
			parameters[7].Value = model.QuotationTime;
			parameters[8].Value = model.SprayingCharges;
			parameters[9].Value = model.PackingCharges;
			parameters[10].Value = model.TestingCharges;
			parameters[11].Value = model.TransportCharges;
            parameters[12].Value = model.SprayingDescrib;
            parameters[13].Value = model.PackingDescrib;
            parameters[14].Value = model.TestingDescrib;
            parameters[15].Value = model.TransportDescrib;
            parameters[16].Value = model.ChargeDescrib;
            parameters[17].Value = model.KinfeDescrib;
            parameters[18].Value = model.ToolsDescrib;

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
		public void Update(TSM.Model.pms_Quotation_Info model)
		{
            
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update pms_Quotation_Info set ");
			strSql.Append("ProductInfoID=@ProductInfoID,");
			strSql.Append("QuotationDepart=@QuotationDepart,");
			strSql.Append("KnifeCharges=@KnifeCharges,");
			strSql.Append("ToolCharges=@ToolCharges,");
			strSql.Append("QuotationPrice=@QuotationPrice,");
			strSql.Append("ApprovalStatus=@ApprovalStatus,");
			strSql.Append("QuotationTime=@QuotationTime,");
			strSql.Append("SprayingCharges=@SprayingCharges,");
			strSql.Append("PackingCharges=@PackingCharges,");
			strSql.Append("TestingCharges=@TestingCharges,");
			strSql.Append("TransportCharges=@TransportCharges,");
            strSql.Append("SprayingDescrib=@SprayingDescrib,");
            strSql.Append("PackingDescrib=@PackingDescrib,");
            strSql.Append("TestingDescrib=@TestingDescrib,");
            strSql.Append("TransportDescrib=@TransportDescrib,");
            strSql.Append("ChargeDescrib=@ChargeDescrib,");
            strSql.Append("KinfeDescrib=@KinfeDescrib,");
            strSql.Append("ToolsDescrib=@ToolsDescrib,");
            strSql.Append("UserInfoID=@UserInfoID");

			strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4),
					new SqlParameter("@ProductInfoID", SqlDbType.Int,4),
					new SqlParameter("@QuotationDepart", SqlDbType.Int,4),
					new SqlParameter("@KnifeCharges", SqlDbType.Decimal,9),
					new SqlParameter("@ToolCharges", SqlDbType.Decimal,9),
					new SqlParameter("@QuotationPrice", SqlDbType.Decimal,9),
					new SqlParameter("@ApprovalStatus", SqlDbType.VarChar,64),
					new SqlParameter("@QuotationTime", SqlDbType.DateTime),
					new SqlParameter("@SprayingCharges", SqlDbType.Decimal,9),
					new SqlParameter("@PackingCharges", SqlDbType.Decimal,9),
					new SqlParameter("@TestingCharges", SqlDbType.Decimal,9),
					new SqlParameter("@TransportCharges", SqlDbType.Decimal,9),
                    new SqlParameter("@UserInfoID", SqlDbType.Int,4),
                    new SqlParameter("@SprayingDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@PackingDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@TestingDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@TransportDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@ChargeDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@KinfeDescrib", SqlDbType.NVarChar,64),
                    new SqlParameter("@ToolsDescrib", SqlDbType.NVarChar,64)
                                        };
			parameters[0].Value = model.QuotationInfoID;
			parameters[1].Value = model.ProductInfoID;
			parameters[2].Value = model.QuotationDepart;
			parameters[3].Value = model.KnifeCharges;
			parameters[4].Value = model.ToolCharges;
			parameters[5].Value = model.QuotationPrice;
			parameters[6].Value = model.ApprovalStatus;
			parameters[7].Value = model.QuotationTime;
			parameters[8].Value = model.SprayingCharges;
			parameters[9].Value = model.PackingCharges;
			parameters[10].Value = model.TestingCharges;
			parameters[11].Value = model.TransportCharges;
            parameters[12].Value = model.UserInfoID;
            parameters[13].Value = model.SprayingDescrib;
            parameters[14].Value = model.PackingDescrib;
            parameters[15].Value = model.TestingDescrib;
            parameters[16].Value = model.TransportDescrib;
            parameters[17].Value = model.ChargeDescrib;
            parameters[18].Value = model.KinfeDescrib;
            parameters[19].Value = model.ToolsDescrib;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

        /// <summary>
        /// ����������־��¼
        /// </summary>
        public void UpdateStatus(TSM.Model.pms_Quotation_Info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update pms_Quotation_Info set ");
            strSql.Append("ApprovalStatus=@ApprovalStatus");
            strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@QuotationInfoID", SqlDbType.Int,4),
					new SqlParameter("@ApprovalStatus", SqlDbType.VarChar,64)};
            parameters[0].Value = model.QuotationInfoID;
            parameters[1].Value = model.ApprovalStatus;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int QuotationInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from pms_Quotation_Info ");
			strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4)};
			parameters[0].Value = QuotationInfoID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_Quotation_Info GetModel(int QuotationInfoID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select *  from view_pms_Quotation_Info ");
            strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
			SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4)};
			parameters[0].Value = QuotationInfoID;

			TSM.Model.pms_Quotation_Info model=new TSM.Model.pms_Quotation_Info();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString()!="")
				{
					model.QuotationInfoID=int.Parse(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductInfoID"].ToString()!="")
				{
					model.ProductInfoID=int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
				}
                if (ds.Tables[0].Rows[0]["QuotationDepart"].ToString() != "")
                {
                    model.QuotationDepart = int.Parse(ds.Tables[0].Rows[0]["QuotationDepart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
                }
				if(ds.Tables[0].Rows[0]["KnifeCharges"].ToString()!="")
				{
					model.KnifeCharges=decimal.Parse(ds.Tables[0].Rows[0]["KnifeCharges"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ToolCharges"].ToString()!="")
				{
					model.ToolCharges=decimal.Parse(ds.Tables[0].Rows[0]["ToolCharges"].ToString());
				}
				if(ds.Tables[0].Rows[0]["QuotationPrice"].ToString()!="")
				{
					model.QuotationPrice=decimal.Parse(ds.Tables[0].Rows[0]["QuotationPrice"].ToString());
				}
				model.ApprovalStatus=ds.Tables[0].Rows[0]["ApprovalStatus"].ToString();
				if(ds.Tables[0].Rows[0]["QuotationTime"].ToString()!="")
				{
					model.QuotationTime=DateTime.Parse(ds.Tables[0].Rows[0]["QuotationTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SprayingCharges"].ToString()!="")
				{
					model.SprayingCharges=decimal.Parse(ds.Tables[0].Rows[0]["SprayingCharges"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PackingCharges"].ToString()!="")
				{
					model.PackingCharges=decimal.Parse(ds.Tables[0].Rows[0]["PackingCharges"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TestingCharges"].ToString()!="")
				{
					model.TestingCharges=decimal.Parse(ds.Tables[0].Rows[0]["TestingCharges"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TransportCharges"].ToString()!="")
				{
					model.TransportCharges=decimal.Parse(ds.Tables[0].Rows[0]["TransportCharges"].ToString());
				}
                if (ds.Tables[0].Rows[0]["Charge"].ToString() != "")
                {
                    model.Charge = decimal.Parse(ds.Tables[0].Rows[0]["Charge"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Cost"].ToString() != "")
                {
                    model.Cost = decimal.Parse(ds.Tables[0].Rows[0]["Cost"].ToString());
                }
                model.TransportDescrib = ds.Tables[0].Rows[0]["TransportDescrib"].ToString();
                model.PackingDescrib = ds.Tables[0].Rows[0]["PackingDescrib"].ToString();
                model.SprayingDescrib = ds.Tables[0].Rows[0]["SprayingDescrib"].ToString();
                model.TestingDescrib = ds.Tables[0].Rows[0]["TestingDescrib"].ToString();
                model.ChargeDescrib = ds.Tables[0].Rows[0]["ChargeDescrib"].ToString();
                model.KinfeDescrib = ds.Tables[0].Rows[0]["KinfeDescrib"].ToString();
                model.ToolsDescrib = ds.Tables[0].Rows[0]["ToolsDescrib"].ToString();
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
        public TSM.Model.pms_Quotation_Info GetModel2(int QuotationInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  from view_pms_Product_Info_Final ");
            strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4)};
            parameters[0].Value = QuotationInfoID;

            TSM.Model.pms_Quotation_Info model = new TSM.Model.pms_Quotation_Info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["QuotationInfoID"].ToString() != "")
                {
                    model.QuotationInfoID = int.Parse(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ProductInfoID"].ToString() != "")
                {
                    model.ProductInfoID = int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["���߷���"].ToString() != "")
                {
                    model.���߷��� = decimal.Parse(ds.Tables[0].Rows[0]["���߷���"].ToString());
                }
                if (ds.Tables[0].Rows[0]["��װ����"].ToString() != "")
                {
                    model.��װ���� = decimal.Parse(ds.Tables[0].Rows[0]["��װ����"].ToString());
                }
                model.����״̬ = ds.Tables[0].Rows[0]["����״̬"].ToString();
                if (ds.Tables[0].Rows[0]["��װ����"].ToString() != "")
                {
                    model.��װ���� = decimal.Parse(ds.Tables[0].Rows[0]["��װ����"].ToString());
                }
                if (ds.Tables[0].Rows[0]["������"].ToString() != "")
                {
                    model.������ = decimal.Parse(ds.Tables[0].Rows[0]["������"].ToString());
                }
                if (ds.Tables[0].Rows[0]["�������"].ToString() != "")
                {
                    model.������� = decimal.Parse(ds.Tables[0].Rows[0]["�������"].ToString());
                }
                if (ds.Tables[0].Rows[0]["�ӹ�����"].ToString() != "")
                {
                    model.�ӹ����� = decimal.Parse(ds.Tables[0].Rows[0]["�ӹ�����"].ToString());
                }
                if (ds.Tables[0].Rows[0]["��Ϳ����"].ToString() != "")
                {
                    model.��Ϳ���� = decimal.Parse(ds.Tables[0].Rows[0]["��Ϳ����"].ToString());
                }
                model.�˷���Ϣ = ds.Tables[0].Rows[0]["�˷���Ϣ"].ToString();
                model.��װ��Ϣ = ds.Tables[0].Rows[0]["��װ��Ϣ"].ToString();
                model.��Ϳ��Ϣ = ds.Tables[0].Rows[0]["��Ϳ��Ϣ"].ToString();
                model.�����Ϣ = ds.Tables[0].Rows[0]["�����Ϣ"].ToString();
                model.�ӹ���Ϣ = ds.Tables[0].Rows[0]["�ӹ���Ϣ"].ToString();
                model.������Ϣ = ds.Tables[0].Rows[0]["������Ϣ"].ToString();
                model.��װ��Ϣ = ds.Tables[0].Rows[0]["��װ��Ϣ"].ToString();
                model.���� = Convert.ToDecimal(ds.Tables[0].Rows[0]["����"]);
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
        public TSM.Model.pms_Quotation_Info GetModel3(int QuotationInfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  from view_pms_Quotation_Info3 ");
            strSql.Append(" where QuotationInfoID=@QuotationInfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@QuotationInfoID", SqlDbType.Int,4)};
            parameters[0].Value = QuotationInfoID;

            TSM.Model.pms_Quotation_Info model = new TSM.Model.pms_Quotation_Info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["QuotationInfoID"].ToString() != "")
                {
                    model.QuotationInfoID = int.Parse(ds.Tables[0].Rows[0]["QuotationInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ProductInfoID"].ToString() != "")
                {
                    model.ProductInfoID = int.Parse(ds.Tables[0].Rows[0]["ProductInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["QuotationDepart"].ToString() != "")
                {
                    model.QuotationDepart = int.Parse(ds.Tables[0].Rows[0]["QuotationDepart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserInfoID"].ToString() != "")
                {
                    model.UserInfoID = int.Parse(ds.Tables[0].Rows[0]["UserInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["KnifeCharges"].ToString() != "")
                {
                    model.KnifeCharges = decimal.Parse(ds.Tables[0].Rows[0]["KnifeCharges"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ToolCharges"].ToString() != "")
                {
                    model.ToolCharges = decimal.Parse(ds.Tables[0].Rows[0]["ToolCharges"].ToString());
                }
                model.ApprovalStatus = ds.Tables[0].Rows[0]["ApprovalStatus"].ToString();
                if (ds.Tables[0].Rows[0]["QuotationTime"].ToString() != "")
                {
                    model.QuotationTime = DateTime.Parse(ds.Tables[0].Rows[0]["QuotationTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PackingCharges"].ToString() != "")
                {
                    model.PackingCharges = decimal.Parse(ds.Tables[0].Rows[0]["PackingCharges"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TestingCharges"].ToString() != "")
                {
                    model.TestingCharges = decimal.Parse(ds.Tables[0].Rows[0]["TestingCharges"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TransportCharges"].ToString() != "")
                {
                    model.TransportCharges = decimal.Parse(ds.Tables[0].Rows[0]["TransportCharges"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Charge"].ToString() != "")
                {
                    model.Charge = decimal.Parse(ds.Tables[0].Rows[0]["Charge"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Remarks"].ToString() != "")
                {
                    model.Remarks = ds.Tables[0].Rows[0]["Remarks"].ToString();
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
			strSql.Append("select QuotationInfoID,ProductInfoID,QuotationDepart,KnifeCharges,ToolCharges,QuotationPrice,ApprovalStatus,QuotationTime,SprayingCharges,PackingCharges,TestingCharges,TransportCharges ");
			strSql.Append(" FROM pms_Quotation_Info ");
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
            strSql.Append(" QuotationInfoID,ProductInfoID,QuotationDepart,KnifeCharges,ToolCharges,QuotationPrice,ApprovalStatus,QuotationTime,SprayingCharges,PackingCharges,TestingCharges,TransportCharges,UserInfoID ");
			strSql.Append(" FROM pms_Quotation_Info ");
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
			parameters[0].Value = "pms_Quotation_Info";
			parameters[1].Value = "ID";
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

