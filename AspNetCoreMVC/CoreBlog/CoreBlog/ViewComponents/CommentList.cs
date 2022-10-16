using CoreBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreBlog.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					UserName="İBRAHİM"
				},
				new UserComment
				{
					ID=2,
					UserName="SİNAN"
				},
				new UserComment
				{
					ID=3,
					UserName="MERVE"
				}
			};

            return View(commentvalues);
		}
	}
}
