using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Permission_Info ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Permission_Info
	{
		public pms_Permission_Info()
		{}
		#region Model
		private int _permissioninfoid;
		private string _permission;
		/// <summary>
		/// 
		/// </summary>
		public int PermissionInfoID
		{
			set{ _permissioninfoid=value;}
			get{return _permissioninfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Permission
		{
			set{ _permission=value;}
			get{return _permission;}
		}
		#endregion Model

	}
}

