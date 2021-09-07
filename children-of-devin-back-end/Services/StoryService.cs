using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using children_of_devin_back_end.Data;
using children_of_devin_back_end.Data.Models;
using children_of_devin_back_end.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace children_of_devin_back_end.Services
{
    public class StoryService : BaseService<Story>
    {
        public StoryService(ApplicationDbContext db) 
            : base(db)
        {

        }

        protected override IQueryable<Story> GetAllInternal()
        {
            return base.GetAllInternal().Include(s => s.Author);
        }

        public async Task ApproveAsync(string id)
        {
            var story = _db.Stories.Attach(new Story() {Id = id, Status = StoryStatus.Approved});

            story.Property(x => x.Status).IsModified = true;
            await this._db.SaveChangesAsync();
        }
    }
}
