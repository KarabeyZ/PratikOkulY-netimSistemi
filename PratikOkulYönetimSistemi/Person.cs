using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikOkulYönetimSistemi
{
    public class Person
    {
        string name;
        string surname;
        string birthDate;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
        public void Student()
        {
            Console.WriteLine($"Öğrencinin ismi: {name}, Öğrencinin Soyismi: {surname}, Öğrencinin doğum tarihi: {birthDate}");
        }
        public void Teacher()
        {
            Console.WriteLine($"Öğretmenin ismi: {name}, Öğretmenin Soyismi: {surname}, Öğretmenin doğum tarihi: {birthDate}");
        }
    }
}
