using System;

namespace Portal264.Blazor.Domain
{
    public class Place : IEquatable<Place>
    {
        public string Name { get; private set; }

        public string Address { get; private set; }

        public float Latitude { get; private set; }

        public float Longitude { get; private set; }

        public Place(string name, String address, float latitude, float longitude)
        {
            Name = name;
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool Equals(Place other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return string.Equals(Name, other.Name)
                && string.Equals(Address, other.Address)
                && Equals(Latitude, other.Latitude)
                && Equals(Longitude, other.Longitude);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Place)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Address != null ? Address.GetHashCode() : 0);
            }
        }
    }
}
