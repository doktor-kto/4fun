using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosterServer
{
    [Serializable]
    class Advert
    {
        public string roomNumber;
        public string price;
        public string name;
        public string desc;
        public string district;
        public string subway_station;
        public string street;
        public string house;
        public string square;
        public string floor;
        public string floorNumber;
        public string phone;        
        public string e_mail;
        public string person;
        public string date;

        public Advert( string roomNumber,
                       string price,
                       string name,
                       string desc,
                       string district,
                       string subway_station,
                       string street,
                       string house,
                       string square,
                       string floor,
                       string floorNumber,
                       string phone,
                       string e_mail,
                       string person, 
                       string date )
        {
            this.roomNumber = roomNumber;
            this.price = price;
            this.name = name;
            this.desc = desc;
            this.district = district;
            this.subway_station = subway_station;
            this.street = street;
            this.house = house;
            this.square = square;
            this.floor = floor;
            this.floorNumber = floorNumber;
            this.phone = phone;
            this.e_mail = e_mail;
            this.person = person;
            this.date = date;
        }
    }
}