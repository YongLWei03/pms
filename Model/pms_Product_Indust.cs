using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Product_Indust ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Product_Indust
	{
		public pms_Product_Indust()
		{}
		#region Model
		private int _productindustid;
		private string _productindust;
		/// <summary>
		/// 
		/// </summary>
		public int ProductIndustID
		{
			set{ _productindustid=value;}
			get{return _productindustid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductIndust
		{
			set{ _productindust=value;}
			get{return _productindust;}
		}
		#endregion Model

	}
}

