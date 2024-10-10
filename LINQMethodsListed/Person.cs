namespace LINQMethodsListed
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public class Person
    {
        public string? FirstName { get; set; }
        public String? LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public String? Occupation { get; set; }
        public Gender Gender { get; set; }
    }
}
