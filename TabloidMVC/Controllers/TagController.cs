using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Security.Claims;
using TabloidMVC.Models;
using TabloidMVC.Models.ViewModels;
using TabloidMVC.Repositories;

namespace TabloidMVC.Controllers
{
    [Authorize]
    public class TagController : Controller
    {
        private readonly ITagRepository _tagRepository;


        public TagController(ITagRepository TagRepository)
        {
            _tagRepository = TagRepository;
        }

        public IActionResult Index()
        {
            List<Tag> tags = _tagRepository.GetAllTags();
            return View(tags);
        }
    }
}