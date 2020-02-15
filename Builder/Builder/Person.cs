namespace Builder
{
    public class Person
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public int Phone { get; private set; }
        public static Builder<Person> Builder => new Builder<Person>();

        private Person()
        {

        }
    }
}