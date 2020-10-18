using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Movie_Reader
{
    class Movie
    {
        public Movie()
        {
            Genre = "";
            Title = "";
            Length = "";
            Director = "";
            Rating = 0;
            ImagePath = "";
        }

        public Movie(string genre, string title, string year, string length, string director, int rating, string imagePath)
        {
            Genre = genre;
            Title = title;
            Year = year;
            Length = length;
            Director = director;
            Rating = rating;
            ImagePath = imagePath;
        }

        public string Genre { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Length { get; set; }
        public string Director { get; set; }
        public int Rating { get; set; }
        public string ImagePath { get; set; }
    }
}
