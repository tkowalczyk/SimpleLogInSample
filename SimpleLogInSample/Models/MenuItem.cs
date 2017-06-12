using System;

namespace SimpleLogInSample
{
	public class MenuItem : BaseModel
	{
		public string Icon { get; set; }
		public MenuType MenuType { get; set; }

		public MenuItem ()
		{
			MenuType = MenuType.Home;
		}
	}
}