namespace DesignProject.Builder
{
    public class ConcreteBuilder : Ibuilder
    {
        Builder person = new Builder();
        public Builder PersonWithAddress(string address)
        {
            person.Address = address; return person;
        }

        public Builder PersonWithAge(int age)
        {
            person.Age = age; return person;
        }

        public Builder PersonWithId(int Id)
        {
            person.Id = Id; return person;
        }

        public Builder Build()
        {
            return person;
        }
    }
}
