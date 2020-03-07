using ForumSystem.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumSystem.Data.Models
{
    public class Comment : BaseDeletableModel<int>
    {
        public int PostId { get; set; }

        public Post Post { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }


    }
}
