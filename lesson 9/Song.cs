using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9
{
    class Song
    {
        private string name;
        private string author;
        private Song prev;
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public Song(string name, Song prev, string author)
        {
            this.name = name;
            this.author = author;
            this.prev = null;
        }
        public string Title()
        {
            return name + " " + author;
        }
        public bool Equals(Song e)
        {
            bool answer = (e != null) && (name.Equals(((Song)e).name)) && (author.Equals(((Song)e).author));
            return answer;
        }

    }
}

