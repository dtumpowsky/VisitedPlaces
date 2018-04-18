using System.Collections.Generic;
using System;

namespace VisitedPlaces.Models
{
    public class Place
    {
        private string _city;
        private string _country;
        private string _image;
        private int _id;
        private static List<Place> _instances = new List<Place> {};

        public Place(string City, string Country, string Image)
        {
            _city = City;
            _country = Country;
            _image = Image;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public void SetCity(string newCity)
        {
            _city = newCity;
        }
        public string GetCity()
        {
            return _city;
        }

        public void SetCountry(string newCountry)
        {
            _country = newCountry;
        }
        public string GetCountry()
        {
            return _country;
        }

        public void SetImage(string newImage)
        {

            _image = newImage;
        }
        public string GetImage()
        {
            return _image;
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public int GetId()
        {
            return _id;
        }
        public static Place Find(int searchId)
        {
            return _instances[searchId-1];
        }


    }
}
