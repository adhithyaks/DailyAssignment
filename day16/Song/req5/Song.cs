using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req5
{
    internal class Song
    {
        private string _name;
        private string _artist;
        private string _songType;
        private DateTime dateDownloaded;
        private double rating;
        private int noOfDownloads;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }

        }
        public DateTime DateDownloaded
        {
            get { return dateDownloaded; }
            set { dateDownloaded = value; }

        }
        public double Rating
        {
            get { return rating; }
            set { }
        }
        public int NoOfDownloads
        {
            get { return noOfDownloads; }
            set { noOfDownloads = value; }
        }
        public Song(string name, string artist, string songType ,
            double Rating, int NoOfDownloads, DateTime DateDownloaded)
        {
            Name = name;
            Artist = artist;
            SongType = songType;
            Rating = rating;
            NoOfDownloads = noOfDownloads;
            DateDownloaded = dateDownloaded;



        }



        public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string, int> sd1 = new SortedDictionary<string, int>();
            foreach (var item in list)
            {
                if (sd1.ContainsKey(item.SongType))
                    sd1[item.SongType]++;
                else
                    sd1.Add(item.SongType, 1);
            }
            return sd1;
        }
    }
}





