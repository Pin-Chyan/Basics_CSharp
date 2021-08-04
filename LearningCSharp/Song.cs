using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        // static attribute about the class
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        // objects can call songCount like this
        public int getSongCount()
        {
            return songCount;
        }
    }
}
