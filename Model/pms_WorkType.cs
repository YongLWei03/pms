using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_WorkType ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_WorkType
	{
		public pms_WorkType()
		{}
		#region Model
		private int _worktypeid;
		private string _worktype;
		/// <summary>
		/// 
		/// </summary>
		public int WorkTypeID
		{
			set{ _worktypeid=value;}
			get{return _worktypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkType
		{
			set{ _worktype=value;}
			get{return _worktype;}
		}
		#endregion Model

	}
}

