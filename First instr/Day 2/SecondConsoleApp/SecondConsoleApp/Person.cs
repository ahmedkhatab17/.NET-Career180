using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondConsoleApp
{
    public class Person: BaseEntity, IPerson
    { 
        public string Name { get; set; }
        public DateTime BOD { get; set; }
        public string Address { get; set; }

        public void Create()
        {
            this.Name = "Mark";
            this.BOD = DateTime.Now;
            this.Id = 1;
            this.Address = "Address";
            this.CreationDate = DateTime.Now;
        }

        public void Delete()
        {
            //throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
        public void NEWMethod()
        {
            Vehicle vehicle = new Vehicle("2");
             
        }

      
    }
}
