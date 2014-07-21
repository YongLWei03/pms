using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Machine_Price ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Machine_Price
	{
		public pms_Machine_Price()
		{}
		#region Model
		private int _machinepriceid;
		private string _devicetype;
		private string _devicedescript;
		private int _internalcost;
		private int _internalprice;
		/// <summary>
		/// 
		/// </summary>
		public int MachinePriceID
		{
			set{ _machinepriceid=value;}
			get{return _machinepriceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceType
		{
			set{ _devicetype=value;}
			get{return _devicetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceDescript
		{
			set{ _devicedescript=value;}
			get{return _devicedescript;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int InternalCost
		{
			set{ _internalcost=value;}
			get{return _internalcost;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int InternalPrice
		{
			set{ _internalprice=value;}
			get{return _internalprice;}
		}
		#endregion Model

	}
}

