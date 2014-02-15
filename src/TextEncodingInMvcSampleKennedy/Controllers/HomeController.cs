using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextEncodingInMvcSampleKennedy.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Helpers()
		{
			return View();
		}

		// The CMS section shows a common use-case for @Html.Raw().

		[HttpGet]
		public ActionResult Cms()
		{
			if (Session["cmsdata"] == null)
			{
				Session["cmsdata"] = "This is a <strong>cms</strong> page!";
			}

			string cmsData = (string) Session["cmsdata"];
			return View((object)cmsData);
		}

		[ValidateInput(false)]
		[HttpPost]
		public ActionResult Cms(string pageContent)
		{
			Session["cmsdata"] = pageContent;
			return Redirect("~/home/cms");
		}

		[HttpGet]
		public ActionResult Forum()
		{
			string commentText = (string) Session["forumdata"];
			return View((object)commentText);
		}

		[ValidateInput(false)]
		[HttpPost]
		public ActionResult Forum(string commentText)
		{
			SaveForumPost(commentText);
			return Redirect("~/home/forum");
		}

		private object SaveForumPost(string commentText)
		{
			return Session["forumdata"] = commentText;
		}


		[HttpGet]
		public ActionResult UnsafeForum()
		{
			string commentText = (string)Session["unsafeforumdata"];
			return View((object)commentText);
		}

		[ValidateInput(false)]
		[HttpPost]
		public ActionResult UnsafeForum(string commentText)
		{
			Session["unsafeforumdata"] = commentText;
			return Redirect("~/home/unsafeforum?return=true");
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
