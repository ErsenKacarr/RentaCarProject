﻿namespace RentACar.DAL
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public List<RentACar> RentACars { get; set; }
    }
}
