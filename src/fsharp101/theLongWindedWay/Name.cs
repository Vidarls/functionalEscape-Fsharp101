using System;

namespace theLongWindedWay
{
    public class Name : IEquatable<Name>
    {
        private readonly string _lastName;
        private readonly string _firstName;

        public string LastName
        {
            get { return _lastName; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public Name(string lastName, string firstName)
        {
            _lastName = lastName;
            _firstName = firstName;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public bool Equals(Name other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_lastName, other._lastName) && string.Equals(_firstName, other._firstName);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Name) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_lastName.GetHashCode()*397) ^ _firstName.GetHashCode();
            }
        }

        public static bool operator ==(Name left, Name right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Name left, Name right)
        {
            return !Equals(left, right);
        }
    }
}
