namespace theLongWindedWay
{
    public class Name
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
    }
}
