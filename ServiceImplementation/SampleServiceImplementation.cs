using System;
using Service.Contract;
using DataAccess;

namespace ServiceImplementation
{



    /// <summary>
    /// A very simplistic service implementation to simulate some database I/O calls 
    /// just writes some dummy data to 3 Tables 
    /// 
    /// </summary>
    public class SampleServiceImplementation : IMigrationService
    {
        public string MigrateSingleClient(string clientCode)
        {
              PopulateTables(clientCode);
            return ("client: " + clientCode + " done");

        }


        public void PopulateTables(string clientCode)
        {

            //lets  add some duff rows to the database table to simulate some db I/O


            for (int i = 0; i < 100; i++)
            {
                PopulateTable1(clientCode);
            }


            for (int i = 0; i < 100; i++)
            {
                PopulateTable2(clientCode);
            }

            for (int i = 0; i < 300; i++)
            {
                PopulateTable3(clientCode);
            }
        }


        //add some random rows to table1
        public void PopulateTable1(string clientCode)
        {
            using (var context = new MigrationDbEntities())
            {

                var table = new Table1();

                table.col2 = RandomString(20) + clientCode;
                table.col2 = RandomString(20) + clientCode;
                table.col3 = RandomString(20) + clientCode;
                table.col4 = RandomString(20);
                table.col5 = RandomString(20);
                table.col6 = RandomString(20);
                table.col7 = RandomString(20);
                table.col8 = RandomString(20);
                table.col9 = RandomString(20);
                table.col10 = RandomString(20);
                table.col11 = RandomString(20);
                table.col12 = DateTime.Now;

                context.AddToTable1(table);
                context.SaveChanges();
            }
        }

        //add some random rows to table2
        public void PopulateTable2(string clientCode)
        {
            using (var context = new MigrationDbEntities())
            {

                var table = new Table2();

                table.ACN = RandomString(8);
                table.AddressLine1 = RandomString(50);
                table.AddressLine2 = RandomString(50);
                table.City = "Sydney";
                table.ManagedBy = 5;
                table.Name = "Name " + clientCode;
                table.Phone = "1234567";
                table.Postcode = 2031;
                table.Reserves = 1000;
                table.State = "NSW";
                table.Type = "c";
                table.Website = "www.myob.com";

                context.AddToTable2(table);
                context.SaveChanges();
            }
        }

        //add some random rows to table3
        public void PopulateTable3(string clientCode)
        {
            using (var context = new MigrationDbEntities())
            {


                Random rnd = new Random();


                var table = new Table3();

                table.Desc  = "Row for client " + clientCode;
                table.Col1 = rnd.Next(1, 100000);
                table.Col2 = rnd.Next(1, 100000);
                table.Col3 = rnd.Next(1, 100000);
                table.Col4 = rnd.Next(1, 100000);
                table.Col5 = rnd.Next(1, 100000);
                table.Col6 = rnd.Next(1, 100000);
                table.Col7 = rnd.Next(1, 100000);
                table.Col8 = rnd.Next(1, 100000);
                table.Col9 = rnd.Next(1, 100000);
                table.Col10 = rnd.Next(1, 100000);
                table.Col11 = rnd.Next(1, 100000);
                table.Col12 = rnd.Next(1, 100000);
                table.Col13 = rnd.Next(1, 100000);
                table.Col14 = rnd.Next(1, 100000);
                table.Col15 = DateTime.Now;

                context.AddToTable3(table);
                context.SaveChanges();
            }
        }


        private readonly Random _rng = new Random();
        private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string RandomString(int size)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = _chars[_rng.Next(_chars.Length)];
            }
            return new string(buffer);
        }

    }

}
