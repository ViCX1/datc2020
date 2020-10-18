using System;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace L04
{
    class Program
    {
        private static CloudTableClient tableClient;
        public static CloudTable studentsTable;
        static void Main(string[] args)
        {
            Task.Run(async () => { await Initialize(); })
            .GetAwaiter()
            .GetResult();
        }

        static async Task Initialize()
        {
            string storageConnectionString =  "DefaultEndpointsProtocol=https;"
            + "AccountName=;"
            + "AccountKey=;"
            + "EndpointSuffix=core.windows.net";

            var Account = CloudStorageAccount.Parse(storageConnectionString);
            tableClient = Account.CreateCloudTableClient();

            studentsTable = tableClient.GetTableReference("studenti");

            await studentsTable.CreateIfNotExistsAsync();

            await AddNewStudent();
            //await EditStudent();
            //await GetAllStudents();
        }



        private static async Task GetAllStudents()
        {
            Console.WriteLine("Universitate\tCNP\tNume\tEmail\tNr\tAn");
            TableQuery<StudentEntity> query = new TableQuery<StudentEntity>();

            TableContinuationToken token = null;
        }
    }

}
