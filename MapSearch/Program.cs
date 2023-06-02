using System;
using System.IO;

namespace MapSearch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\sania\RiderProjects\MapSearch\MapSearch\ukraine_poi.csv";
            string[] places = File.ReadAllLines(path);
            float latitudeMax = float.Parse(places[0].Split(';')[0]);
            float latitudeMin = float.Parse(places[0].Split(';')[0]);
            float longitudeMax = float.Parse(places[0].Split(';')[1]);
            float longitudeMin = float.Parse(places[0].Split(';')[1]);
            foreach (var place in places)
            {
                var data = place.Split(';');
                if(data[0] != "")
                {
                    var latitude = float.Parse(data[0]);
                    var longitude = float.Parse(data[1]);
                    if (latitude > latitudeMax) latitudeMax = latitude;
                    if (latitude < latitudeMin) latitudeMin = latitude;
                    if (longitude > longitudeMax) longitudeMax = longitude;
                    if (longitude < longitudeMin) longitudeMin = longitude;
                }
            }
            Console.WriteLine(latitudeMax+" "+latitudeMin+" "+longitudeMax+" "+longitudeMin);
        }
    }
}