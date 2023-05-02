using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SongPlayist

{

    class Song

    {

        private string _name;

        public string Name

        {

            get { return _name; }

            set { _name = value; }

        }

        private string _artist;

        public string Artist

        {

            get { return _artist; }

            set { _artist = value; }

        }

        private string _songType;

        public string SongType

        {

            get { return _songType; }

            set { _songType = value; }

        }

        private double _rating;

        public double Rating

        {

            get { return _rating; }

            set { _rating = value; }

        }

        private int _noOfDownloads;

        private int NoOfDownloads

        {

            get { return _noOfDownloads; }

            set { _noOfDownloads = value; }

        }

        private DateTime _dateDownloaded;

        public DateTime DateDownloaded

        {

            get { return _dateDownloaded; }

            set { _dateDownloaded = value; }

        }

        public Song()

        {

        }

        public Song(string _name, string _artist, string _songType,

          double _rating, int _noOfDownloads, DateTime _dateDownloaded)

        {

            Name = _name;

            Artist = _artist;

            SongType = _songType;

            Rating = _rating;

            NoOfDownloads = _noOfDownloads;

            DateDownloaded = _dateDownloaded;

        }

        public override string ToString()

        {

            return string.Format("\t{0} \t{1} \t{2} \t{3} \t{4} \t{5}",

              Name, Artist, SongType, Rating, NoOfDownloads,

              DateDownloaded.ToString("dd-MM-yyyy", null));

        }

    }

}



