using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Product_Type ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Product_Type
	{
		public pms_Product_Type()
		{}
		#region Model
		private int _producttypeid;
		private string _producttype;
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
		public string ProductType
		{
			set{ _producttype=value;}
			get{return _producttype;}
		}
		#endregion Model

	}
}

