using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcApplication2.Models
{
    public class Person
    {

        public string personName { get; set; }
        public DateTime? birthDate { get; set; }
        public string personGender { get; set; }
        public List<Gender> lstGender;
        public void fillGenderList()
        {
            lstGender = new List<Gender>();
            lstGender.Add(new Gender { Name = "Male", ID = 1 });
            lstGender.Add(new Gender { Name = "Female", ID = 2 });

        }

    }
    public class Gender
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }  
}