namespace RxjhServer
{
	public class GiftcodeClass
	{
		private string _GiftCode;

		private int _Type;

		public string GiftCode
		{
			get
			{
				return _GiftCode;
			}
			set
			{
				_GiftCode = value;
			}
		}

		public int Type
		{
			get
			{
				return _Type;
			}
			set
			{
				_Type = value;
			}
		}
	}
}
