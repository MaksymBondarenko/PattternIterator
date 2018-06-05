using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Social
{
   public class Human
    {
        public int Age { get; set; }
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isCollegia { get; set; }

        public Human(int Age, int Id, string firstName, string lastName, bool isCollegia)
        {
            this.Age = Age;
            this.Id = Id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.isCollegia = isCollegia;
        }

        public bool IsCollegia()
        {
            return this.isCollegia;
        }

        public override string ToString()
        {
            string Collegia = isCollegia ? "isCollegia" : "";
            return $"{Id} || {firstName}  {lastName}  {Age} - {Collegia}";
        }
    }
}

