using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Quotation_Details ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Quotation_Details
	{
		public pms_Quotation_Details()
		{}
		#region Model
		private int _quotationdetailsid;
		private int _quotationinfoid;
		private int _machinepriceid;
		private decimal _workinghour;
		/// <summary>
		/// 
		/// </summary>
		public int QuotationDetailsID
		{
			set{ _quotationdetailsid=value;}
			get{return _quotationdetailsid;}
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
		public int MachinePriceID
		{
			set{ _machinepriceid=value;}
			get{return _machinepriceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal WorkingHour
		{
			set{ _workinghour=value;}
			get{return _workinghour;}
		}
		#endregion Model

	}
}

