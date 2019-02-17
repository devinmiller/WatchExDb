using System;
using System.Collections.Generic;
using System.Text;

namespace Wex.Context.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string RedditId { get; set; }


        public string Author { get; set; }

        public uint CreatedUtc { get; set; }

        public string Domain { get; set; }


        public bool IsMeta { get; set; }

        public bool IsSelf { get; set; }

        public bool IsVideo { get; set; }


        public string LinkFlairText { get; set; }

        public string LinkFlairType { get; set; }


        public bool Pinned { get; set; }

        public bool Stickied { get; set; }


        public string Title { get; set; }

        public string Name { get; set; }

        public string Permalink { get; set; }

        public string Url { get; set; }

        public string SelfText { get; set; }


        public virtual Preview Preview { get; set; }
    }
}
