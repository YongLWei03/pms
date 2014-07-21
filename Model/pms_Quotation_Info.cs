using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Quotation_Info ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Quotation_Info
	{
		public pms_Quotation_Info()
		{}
		#region Model
		private int _quotationinfoid;
		private int _productinfoid;
        private int _UserInfoID;
		private int _quotationdepart;
		private decimal _knifecharges;
		private decimal _toolcharges;
		private decimal _quotationprice;
		private string _approvalstatus;
		private DateTime _quotationtime;
		private decimal? _sprayingcharges;
		private decimal? _packingcharges;
		private decimal? _testingcharges;
		private decimal? _transportcharges;
        private decimal? _cost;
        private decimal? _charge;
        private int _ApprovalInfoID;
        private int _approvorID;
        private int _KnifeRate;
        private int _PackingRate;
        private int _QuotationRate;
        private int _TestingRate;
        private int _ToolRate;
        private int _TransportRate;
        private string _Remarks;
        private string _SprayingDescrib;
        private string _PackingDescrib;
        private string _TestingDescrib;
        private string _TransportDescrib;
        private string _ChargeDescrib;
        private string _KinfeDescrib;
        private string _ToolsDescrib;
        private decimal _���߷���;
        private string _������Ϣ;
        private decimal _��װ����;
        private string _��װ��Ϣ;
        private decimal _������;
        private string _�����Ϣ;
        private decimal _�������;
        private string _�˷���Ϣ;
        private decimal _��Ϳ����;
        private string _��Ϳ��Ϣ;
        private decimal _��װ����;
        private string _��װ��Ϣ;
        private decimal _�ӹ�����;
        private string _�ӹ���Ϣ;
        private string _����״̬;
        private decimal _����;
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
		public int ProductInfoID
		{
			set{ _productinfoid=value;}
			get{return _productinfoid;}
		}
        /// <summary>
        /// 
        /// </summary>
        public int UserInfoID
        {
            set { _UserInfoID = value; }
            get { return _UserInfoID; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int QuotationDepart
		{
			set{ _quotationdepart=value;}
			get{return _quotationdepart;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal KnifeCharges
		{
			set{ _knifecharges=value;}
			get{return _knifecharges;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ToolCharges
		{
			set{ _toolcharges=value;}
			get{return _toolcharges;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal QuotationPrice
		{
			set{ _quotationprice=value;}
			get{return _quotationprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ApprovalStatus
		{
			set{ _approvalstatus=value;}
			get{return _approvalstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime QuotationTime
		{
			set{ _quotationtime=value;}
			get{return _quotationtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SprayingCharges
		{
			set{ _sprayingcharges=value;}
			get{return _sprayingcharges;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PackingCharges
		{
			set{ _packingcharges=value;}
			get{return _packingcharges;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TestingCharges
		{
			set{ _testingcharges=value;}
			get{return _testingcharges;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TransportCharges
		{
			set{ _transportcharges=value;}
			get{return _transportcharges;}
		}
        /// <summary>
        /// 
        /// </summary>
        public decimal? Charge
        {
            set { _charge = value; }
            get { return _charge; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Cost
        {
            set { _cost = value; }
            get { return _cost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ApprovalInfoID
        {
            set { _ApprovalInfoID = value; }
            get { return _ApprovalInfoID; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int approvorID
        {
            set { _approvorID = value; }
            get { return _approvorID; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int KnifeRate
        {
            set { _KnifeRate = value; }
            get { return _KnifeRate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PackingRate
        {
            set { _PackingRate = value; }
            get { return _PackingRate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int QuotationRate
        {
            set { _QuotationRate = value; }
            get { return _QuotationRate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TestingRate
        {
            set { _TestingRate = value; }
            get { return _TestingRate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ToolRate
        {
            set { _ToolRate = value; }
            get { return _ToolRate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TransportRate
        {
            set { _TransportRate = value; }
            get { return _TransportRate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks
        {
            set { _Remarks = value; }
            get { return _Remarks; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string SprayingDescrib
        {
            set { _SprayingDescrib = value; }
            get { return _SprayingDescrib; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PackingDescrib
        {
            set { _PackingDescrib = value; }
            get { return _PackingDescrib; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TestingDescrib
        {
            set { _TestingDescrib = value; }
            get { return _TestingDescrib; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TransportDescrib
        {
            set { _TransportDescrib = value; }
            get { return _TransportDescrib; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string KinfeDescrib
        {
            set { _KinfeDescrib = value; }
            get { return _KinfeDescrib; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ToolsDescrib
        {
            set { _ToolsDescrib = value; }
            get { return _ToolsDescrib; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChargeDescrib
        {
            set { _ChargeDescrib = value; }
            get { return _ChargeDescrib; }
        }

        /// <summary>
        /// 
        /// </summary>
        public decimal ���߷���
        {
            set { _���߷��� = value; }
            get { return _���߷���; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������Ϣ
        {
            set { _������Ϣ = value; }
            get { return _������Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ��װ����
        {
            set { _��װ���� = value; }
            get { return _��װ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��װ��Ϣ
        {
            set { _��װ��Ϣ = value; }
            get { return _��װ��Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ��װ����
        {
            set { _��װ���� = value; }
            get { return _��װ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��װ��Ϣ
        {
            set { _��װ��Ϣ = value; }
            get { return _��װ��Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ������
        {
            set { _������ = value; }
            get { return _������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �����Ϣ
        {
            set { _�����Ϣ = value; }
            get { return _�����Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal �������
        {
            set { _������� = value; }
            get { return _�������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �˷���Ϣ
        {
            set { _�˷���Ϣ = value; }
            get { return _�˷���Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ��Ϳ����
        {
            set { _��Ϳ���� = value; }
            get { return _��Ϳ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��Ϳ��Ϣ
        {
            set { _��Ϳ��Ϣ = value; }
            get { return _��Ϳ��Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal �ӹ�����
        {
            set { _�ӹ����� = value; }
            get { return _�ӹ�����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �ӹ���Ϣ
        {
            set { _�ӹ���Ϣ = value; }
            get { return _�ӹ���Ϣ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ����״̬
        {
            set { _����״̬ = value; }
            get { return _����״̬; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ����
        {
            set { _���� = value; }
            get { return _����; }
        }

		#endregion Model

	}
}

