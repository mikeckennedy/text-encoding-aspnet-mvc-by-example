using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace TextEncodingInMvcSampleKennedy.Infrastructure
{
	public static class OurHtmlHelper
	{
		public static string LinkWithImageBad(
			string imageUrl, string linkUrl)
		{
			return string.Format(
				"<a href='{0}'><img src='{1}' /></a>",
				linkUrl, 
				imageUrl);
		}

		public static MvcHtmlString LinkWithImage(
			string imageUrl, string linkUrl)
		{
			string html = string.Format(
				"<a href='{0}'><img src='{1}' /></a>", 
				linkUrl, 
				imageUrl);

			return new MvcHtmlString(html);
		}
	}
}