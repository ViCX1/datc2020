using System.Collections.Generic;

namespace web_api
{
    public class StudentRepo
    {
        public static List<Student> Students = new List<Student>() 
        {
            new Student() {Id = 1 , Name = "Daescu", Prenume ="Victor", Facultate="AC",Specializare="IS",an =4},
            new Student() {Id = 2 , Name = "Popescu", Prenume ="Ion", Facultate="AC",Specializare="IS",an =3},
            new Student() {Id = 3 , Name = "Catut", Prenume ="Robert", Facultate="AC",Specializare="IS",an =4},
            new Student() {Id = 4 , Name = "Nume_4", Prenume ="prenume_4", Facultate="AC",Specializare="IS",an =1},
        };

        
    }
}