using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Detailed_Charge ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Detailed_Charge
	{
		public pms_Detailed_Charge()
		{}
		#region Model
		private int _detailedchargeid;
		private int _quotationinfoid;
		private string _devicetype;
		private string _devicedescript;
		private int _internalcost;
		private int _internalprice;
		/// <summary>
		/// 
		/// </summary>
		public int DetailedChargeID
		{
			set{ _detailedchargeid=value;}
			get{return _detailedchargeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int QuotationInfoID
		{
			set{ _quotationinfoid=value;}
			get{return _quotationinfoid;}
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

