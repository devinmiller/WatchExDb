using System;
using System.Collections.Generic;
using System.Text;

namespace Wex.Context.Models
{
    public class Preview
    {
        public int Id { get; set; }

        public bool Enabled { get; set; }

        public Image Source { get; set; }

        public List<Image> Resolutions { get; set; }
    }
}
