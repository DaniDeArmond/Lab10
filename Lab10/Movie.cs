using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string title;
        private string category;


        private Movie() { }
        public Movie(string Title1, string Category1)
        {
            Title = Title1;
            Category = Category1;
        }

        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        public string Category
        {
            set
            {
                category = value;
            }
            get
            {
                return category;
            }
        }

    }
}
