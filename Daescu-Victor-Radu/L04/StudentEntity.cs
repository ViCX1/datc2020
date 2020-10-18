using Microsoft.WindowsAzure.Storage.Table;

namespace Models
{
    public class StudentEntity : TableEntity
    {
        public StudentEntity(string university, string cnp)
        {
            this.PartitionKey = university;
            this.RowKey = cnp;
        }

        public StudentEntity(){}

        public string Firstname {get; set;}

        public string Lastname {get; set;}

        public string Email {get; set;}

        public string Phonenumber {get; set;}

        public int Year {get; set;}

        public string Faculta {get; set;}
    }
}