using Domain.Entity;

namespace Domain.Builder;

public class PersonBuilder
{
    private Person person;
    private PersonBuilder()
    {
        person = new Person();
    }
    public static PersonBuilder Builder()
    {
        return new PersonBuilder();
    }

    public PersonBuilder WithName(string name)
    {
        person.Name = name;
        return this;
    }
    public PersonBuilder WithAge(int age)
    {
        person.Age = age;
        return this;
    }

    public Person Build()
    {
        return person;
    }
}