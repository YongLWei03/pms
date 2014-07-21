using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Product_Info ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Product_Info
	{
		public pms_Product_Info()
		{}
		#region Model
		private int _productinfoid;
		private int _productbatchid;
		private int _customerrequireid;
		private int _producttypeid;
		private int? _productstrucid;
		private int? _productmaterid;
		private int? _productindustid;
		private string _productinfoname;
		private string _productphotonum;
		private string _productstandard;
		private decimal _productweight;
		private string _orderquantity;
		private string _contoursize;
		private string _remarks;
        private string _��������;
        private string _��Ʒ����;
        private string _�˿�����;
        private string _�˿�����;
        private string _�˿�Ҫ��;
        private string _��Ʒ�ṹ;
        private string _��Ʒ����;
        private string _������ҵ;
        private string _ͼ��;
        private string _�淶;
        private string _����;
        private string _����;
        private string _������;
        private string _��ע;
        private string _��������;
        private string _������ַ;
        private string _�ϴ��ڵ�;
        private string _�ϴ�ʱ��;
        private string _�ϴ���;
        private string _������ϵ��;
        private string _������ϵ�绰;
        private string _������ϵ����;
        private string _������ϵ��;
        private string _������ϵ�绰;
        private string _������ϵ����;
        private string _ApprovalStatus;
        private int _QuotationInfoID;
        private string _���տͻ�;
        private string _������;
        private string _��������;
        private string _Ӫ��Ա����;
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
		public int ProductBatchID
		{
			set{ _productbatchid=value;}
			get{return _productbatchid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CustomerRequireID
		{
			set{ _customerrequireid=value;}
			get{return _customerrequireid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ProductTypeID
		{
			set{ _producttypeid=value;}
			get{return _producttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductStrucID
		{
			set{ _productstrucid=value;}
			get{return _productstrucid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductMaterID
		{
			set{ _productmaterid=value;}
			get{return _productmaterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ProductIndustID
		{
			set{ _productindustid=value;}
			get{return _productindustid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductInfoName
		{
			set{ _productinfoname=value;}
			get{return _productinfoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductPhotoNum
		{
			set{ _productphotonum=value;}
			get{return _productphotonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductStandard
		{
			set{ _productstandard=value;}
			get{return _productstandard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ProductWeight
		{
			set{ _productweight=value;}
			get{return _productweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderQuantity
		{
			set{ _orderquantity=value;}
			get{return _orderquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContourSize
		{
			set{ _contoursize=value;}
			get{return _contoursize;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string ��������
        {
            set { _�������� = value; }
            get { return _��������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��Ʒ����
        {
            set { _��Ʒ���� = value; }
            get { return _��Ʒ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �˿�����
        {
            set { _�˿����� = value; }
            get { return _�˿�����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �˿�����
        {
            set { _�˿����� = value; }
            get { return _�˿�����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �˿�Ҫ��
        {
            set { _�˿�Ҫ�� = value; }
            get { return _�˿�Ҫ��; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��Ʒ�ṹ
        {
            set { _��Ʒ�ṹ = value; }
            get { return _��Ʒ�ṹ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��Ʒ����
        {
            set { _��Ʒ���� = value; }
            get { return _��Ʒ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ҵ
        {
            set { _������ҵ = value; }
            get { return _������ҵ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ͼ��
        {
            set { _ͼ�� = value; }
            get { return _ͼ��; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �淶
        {
            set { _�淶 = value; }
            get { return _�淶; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ����
        {
            set { _���� = value; }
            get { return _����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ����
        {
            set { _���� = value; }
            get { return _����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������
        {
            set { _������ = value; }
            get { return _������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��ע
        {
            set { _��ע = value; }
            get { return _��ע; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��������
        {
            set { _�������� = value; }
            get { return _��������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ַ
        {
            set { _������ַ = value; }
            get { return _������ַ; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �ϴ��ڵ�
        {
            set { _�ϴ��ڵ� = value; }
            get { return _�ϴ��ڵ�; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �ϴ�ʱ��
        {
            set { _�ϴ�ʱ�� = value; }
            get { return _�ϴ�ʱ��; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string �ϴ���
        {
            set { _�ϴ��� = value; }
            get { return _�ϴ���; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ϵ��
        {
            set { _������ϵ�� = value; }
            get { return _������ϵ��; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ϵ�绰
        {
            set { _������ϵ�绰 = value; }
            get { return _������ϵ�绰; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ϵ����
        {
            set { _������ϵ���� = value; }
            get { return _������ϵ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ϵ��
        {
            set { _������ϵ�� = value; }
            get { return _������ϵ��; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ϵ�绰
        {
            set { _������ϵ�绰 = value; }
            get { return _������ϵ�绰; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������ϵ����
        {
            set { _������ϵ���� = value; }
            get { return _������ϵ����; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ApprovalStatus
        {
            set { _ApprovalStatus = value; }
            get { return _ApprovalStatus; }
        } 
        /// <summary>
        /// 
        /// </summary>
        public int QuotationInfoID
        {
            set { _QuotationInfoID = value; }
            get { return _QuotationInfoID; }
        } 
        /// <summary>
        /// 
        /// </summary>
        public string ���տͻ�
        {
            set { _���տͻ� = value; }
            get { return _���տͻ�; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ������
        {
            set { _������ = value; }
            get { return _������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ��������
        {
            set { _�������� = value; }
            get { return _��������; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ӫ��Ա����
        {
            set { _Ӫ��Ա���� = value; }
            get { return _Ӫ��Ա����; }
        }

		#endregion Model

	}
}

