using System.Diagnostics.CodeAnalysis;

namespace ContainsMethodExample
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? objectOne, Student? objectTwo)
        {
            if (objectOne == null || objectTwo == null) return false;

            if (objectOne.Id == objectTwo.Id && objectOne.Name.ToLower() == objectTwo.Name.ToLower() && objectOne.Age == objectTwo.Age)
                return true;

            return false;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
