using ClassMetotDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo.Concrete
{
    public class Costumer : IPerson
    {
        public int Id { get; set; }
        public int NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
    }
}
