namespace Builder
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int? Phone { get; set; }
        public static Builder<Person> Builder => new Builder<Person>();

        private Person()
        {
        }
    }
}