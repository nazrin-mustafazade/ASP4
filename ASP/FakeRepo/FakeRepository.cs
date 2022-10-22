using ASP.Entities;

namespace ASP.FakeRepo
{
    public class FakeRepository
    {
        public static List<Person> People { get; set; } =new List<Person>
            {
                new Person
                {
                    Id=3,
                    Name="Leyla",
                    Surname="Mammadova",
                    Age=23
                }

};
    }
}
