using System;
using System.Collections.Generic;
using System.Text;

namespace constructors_jakob_cook
{
    class game
    {

        public string title, genre;


        public game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}
