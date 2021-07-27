using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
	/// <summary>
	/// https://docs.microsoft.com/en-us/aspnet/core/blazor/globalization-localization?view=aspnetcore-5.0&pivots=server
	/// </summary>
	[Route("[controller]/[action]")]
	public class CultureController : Controller
	{
		public IActionResult Set(string culture, string redirectUri)
		{
			if (culture != null)
			{
				HttpContext.Response.Cookies.Append(
					CookieRequestCultureProvider.DefaultCookieName,
					CookieRequestCultureProvider.MakeCookieValue(
						new RequestCulture(culture, culture)));
			}

			return LocalRedirect(redirectUri);
		}
	}
}