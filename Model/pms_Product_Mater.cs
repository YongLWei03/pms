using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Product_Mater ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Product_Mater
	{
		public pms_Product_Mater()
		{}
		#region Model
		private int _productmaterid;
		private string _productmater;
		/// <summary>
		/// 
		/// </summary>
		public int ProductMaterID
		{
			set{ _productmaterid=value;}
			get{return _productmaterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductMater
		{
			set{ _productmater=value;}
			get{return _productmater;}
		}
		#endregion Model

	}
}

