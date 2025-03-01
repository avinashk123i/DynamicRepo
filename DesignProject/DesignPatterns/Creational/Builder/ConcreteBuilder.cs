namespace DesignProject.Builder
{
    public class ConcreteBuilder : Ibuilder
    {
        Builder person = new Builder();
        public Ibuilder PersonWithAddress(string address)
        {
            person.Address = address; 
            return this;
        }

        public Ibuilder PersonWithAge(int age)
        {
            person.Age = age;
            return this;
        }

        public Ibuilder PersonWithId(int Id)
        {
            person.Id = Id; 
            return this;
        }

        public Builder Build()
        {
            return person;
        }
    }
}
