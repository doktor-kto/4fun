using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosterServer
{
    class Advert
    {
        public int roomNumber;
        public int price;
        public string name;
        public string desc;
        public string district;
        public string subway_station;
        public string street;
        public string house;
        public string square;
        public int floor;
        public int floorNumber;
        public string phone;        
        public string e_mail;

        public Advert( int roomNumber,
                       int price,
                       string name,
                       string desc,
                       string district,
                       string subway_station,
                       string street,
                       string house,
                       string square,
                       int floor,
                       int floorNumber,
                       string phone,
                       string e_mail )
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
        }
    }
}