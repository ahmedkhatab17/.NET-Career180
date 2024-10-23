using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class BaseEntity : ICategory
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int CompId { get; set; }
        public DateTime CreationDate { get; set; }
        public int StatusId { get; set; }

        public void Eat()
        {
           //write logic
        }

        public void End()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
