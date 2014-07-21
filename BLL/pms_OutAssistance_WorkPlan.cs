using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using TSM.Model;
namespace TSM.BLL
{
	/// <summary>
	/// ҵ���߼���pms_OutAssistance_WorkPlan ��ժҪ˵����
	/// </summary>
	public class pms_OutAssistance_WorkPlan
	{
		private readonly TSM.DAL.pms_OutAssistance_WorkPlan dal=new TSM.DAL.pms_OutAssistance_WorkPlan();
		public pms_OutAssistance_WorkPlan()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int WorkPlanID)
		{
			return dal.Exists(WorkPlanID);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(TSM.Model.pms_OutAssistance_WorkPlan model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(TSM.Model.pms_OutAssistance_WorkPlan model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int WorkPlanID)
		{
			
			dal.Delete(WorkPlanID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public TSM.Model.pms_OutAssistance_WorkPlan GetModel(int WorkPlanID)
		{
			
			return dal.GetModel(WorkPlanID);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public TSM.Model.pms_OutAssistance_WorkPlan GetModelByCache(int WorkPlanID)
		{
			
			string CacheKey = "pms_OutAssistance_WorkPlanModel-" + WorkPlanID;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(WorkPlanID);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (TSM.Model.pms_OutAssistance_WorkPlan)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_OutAssistance_WorkPlan> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<TSM.Model.pms_OutAssistance_WorkPlan> DataTableToList(DataTable dt)
		{
			List<TSM.Model.pms_OutAssistance_WorkPlan> modelList = new List<TSM.Model.pms_OutAssistance_WorkPlan>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				TSM.Model.pms_OutAssistance_WorkPlan model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new TSM.Model.pms_OutAssistance_WorkPlan();
					if(dt.Rows[n]["WorkPlanID"].ToString()!="")
					{
						model.WorkPlanID=int.Parse(dt.Rows[n]["WorkPlanID"].ToString());
					}
					model.PlanMonth=dt.Rows[n]["PlanMonth"].ToString();
					if(dt.Rows[n]["WorkTypeID"].ToString()!="")
					{
						model.WorkTypeID=int.Parse(dt.Rows[n]["WorkTypeID"].ToString());
					}
					if(dt.Rows[n]["WorkContentID"].ToString()!="")
					{
						model.WorkContentID=int.Parse(dt.Rows[n]["WorkContentID"].ToString());
					}
					model.WorkPlan=dt.Rows[n]["WorkPlan"].ToString();
					if(dt.Rows[n]["PlanTime"].ToString()!="")
					{
						model.PlanTime=DateTime.Parse(dt.Rows[n]["PlanTime"].ToString());
					}
					if(dt.Rows[n]["PlannerID"].ToString()!="")
					{
						model.PlannerID=int.Parse(dt.Rows[n]["PlannerID"].ToString());
					}
					model.Report=dt.Rows[n]["Report"].ToString();
					if(dt.Rows[n]["ReportTime"].ToString()!="")
					{
						model.ReportTime=DateTime.Parse(dt.Rows[n]["ReportTime"].ToString());
					}
					if(dt.Rows[n]["ReporterID"].ToString()!="")
					{
						model.ReporterID=int.Parse(dt.Rows[n]["ReporterID"].ToString());
					}
					model.Completion=dt.Rows[n]["Completion"].ToString();
					model.Result=dt.Rows[n]["Result"].ToString();
					if(dt.Rows[n]["WorkHour"].ToString()!="")
					{
						model.WorkHour=int.Parse(dt.Rows[n]["WorkHour"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			return dal.GetList(PageSize,PageIndex,strWhere);
		}

		#endregion  ��Ա����
	}
}

