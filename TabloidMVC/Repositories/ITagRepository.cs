using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ITagRepository
    {
        List<Tag> GetAllTags();
        public Tag GetTagById(int id);
        public void AddTag(Tag tag);
        public void DeleteTag(int id);
        public void UpdateTag(Tag tag);
       


    }
}