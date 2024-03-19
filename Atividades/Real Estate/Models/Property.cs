using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Estate.Models
{
    public class Property
    {
        public int PropertyId { get; }
        public string PropertyName { get; set; }
        public string PropertyAddress { get; set; }
        public float PropertyValue { get; set; }
        public int PropertyRooms { get; set; }
        public Type PropertyType { get; set; }
        public Locale PropertyLocale { get; set; }
        public DealType PropertyDealType { get; set; }
        public List<string> ImagePaths = new List<string>();

        public Property(int ID, string Name, string Address, float Value, int Rooms, Type Type, Locale Locale, DealType DealType)
        {
            PropertyId = ID;
            PropertyName = Name;
            PropertyAddress = Address;
            PropertyValue = Value;
            PropertyRooms = Rooms;
            PropertyType = Type;
            PropertyLocale = Locale;
            PropertyDealType = DealType;
        }
    }
}