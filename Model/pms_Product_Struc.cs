using System;
namespace TSM.Model
{
	/// <summary>
	/// ʵ����pms_Product_Struc ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class pms_Product_Struc
	{
		public pms_Product_Struc()
		{}
		#region Model
		private int _productstrucid;
		private string _productstruc;
		/// <summary>
		/// 
		/// </summary>
		public int ProductStrucID
		{
			set{ _productstrucid=value;}
			get{return _productstrucid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductStruc
		{
			set{ _productstruc=value;}
			get{return _productstruc;}
		}
		#endregion Model

	}
}

