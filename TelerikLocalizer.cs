using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Telerik.Blazor.Services;

namespace TelerikGrid
{
	public class TelerikLocalizer : ITelerikStringLocalizer
	{
		private static readonly Dictionary<string, ResourceSet> Lang = new Dictionary<string, ResourceSet>();

		public TelerikLocalizer()
		{
			ResourceManager res = new ResourceManager("TelerikGrid.Resources.Telerik", typeof(TelerikLocalizer).Assembly); 
			Lang.Add("en", Telerik.Blazor.Resources.Messages.ResourceManager.GetResourceSet(new CultureInfo("en"), true, true));
			Lang.Add("sv", res.GetResourceSet(new CultureInfo("sv"), true, false));
		}

		public String this[String name] { get => Lang[CultureInfo.CurrentCulture.TwoLetterISOLanguageName].GetString(name); }
	}
}
