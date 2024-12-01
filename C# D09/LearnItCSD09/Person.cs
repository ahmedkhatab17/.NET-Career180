using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnItCSD09
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            var right=obj as Person;
            return this.Id==right.Id && this.Name==right.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

        public static bool operator ==(Person? left, Person? right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }
    }
    ////////////////////////////////////////////////
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
