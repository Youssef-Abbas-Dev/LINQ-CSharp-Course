namespace SetOperationsExample
{
    public class Student
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required byte Age { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
