namespace Classes
{
    class Customer
    {
        //Field
        //public string FirstName;

        //Property
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
