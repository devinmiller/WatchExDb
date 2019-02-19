using System;
using System.Collections.Generic;
using System.Text;

namespace Wex.Context.Models
{
    public enum ImageType
    {
        Source,
        Resolution
    }

    public class Image
    {
        public int Id { get; set; }

        public ImageType ImageType { get; set; }

        public string Url { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
