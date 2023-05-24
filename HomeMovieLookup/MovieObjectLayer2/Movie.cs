using System;

namespace MovieObjectLayer
{
    public class Movie
    {
        public string ImdbID { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }
        public string Genre { get; set; }
        public string PlotFileName { get; set; }
        public Uri PosterFileName { get; set; }
    }
}
