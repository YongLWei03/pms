using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_WorkContent ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_WorkContent
	{
		public pms_WorkContent()
		{}
		#region Model
		private int _workcontentid;
		private string _workcontent;
		/// <summary>
		/// 
		/// </summary>
		public int WorkContentID
		{
			set{ _workcontentid=value;}
			get{return _workcontentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkContent
		{
			set{ _workcontent=value;}
			get{return _workcontent;}
		}
		#endregion Model

	}
}

