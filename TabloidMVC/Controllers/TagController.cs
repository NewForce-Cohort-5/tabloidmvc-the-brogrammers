using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using TabloidMVC.Models;
using TabloidMVC.Models.ViewModels;
using TabloidMVC.Repositories;

namespace TabloidMVC.Controllers
{
    //only allows admin to access 
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

        // GET: TagController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TagController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tag tag)
        {
            try
            {
                _tagRepository.AddTag(tag);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(tag);
            }
        }

        // GET: Tags/Delete/5
        public ActionResult Delete(int id)
        {
            Tag tag = _tagRepository.GetTagById(id);

            return View(tag);
        }

        // POST: TagController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Tag tag)
        {
            try
            {
                _tagRepository.DeleteTag(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(tag);
            }
        }

        //GET: Tags/Edit
        public ActionResult Edit(int id)
        {
          
            Tag tag = _tagRepository.GetTagById(id);
            return View(tag);
        }

        //Post: Tags/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Tag tag)
        {
            try
            {
                _tagRepository.UpdateTag(tag);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(tag);
            }
        }




    }
}