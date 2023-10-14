namespace BuilderExample;
public class PersonBuilder
{
    private Person person = new Person();

    public PersonBuilder SetName(string name)
    {
        person.Name = name;
        return this;
    }

    public PersonBuilder SetAge(int age)
    {
        person.Age = age;
        return this;
    }

    public PersonBuilder SetAddress(string address)
    {
        person.Address = address;
        return this;
    }

    public PersonBuilder SetEmail(string email)
    {
        person.Email = email;
        return this;
    }

    public Person Build()
    {
        return person;
    }
}
