using SchoolManagementSystem;

static void Main (string[] args)
{

    Person person = new Person();
    person.Name = "Ceyda";
    person.SurName = "Türkdoğan";
    person.BirthDate = new DateTime(1995, 1, 21);

    person.DisplayInfo();

}