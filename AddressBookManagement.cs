using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AddressBookProblem_LINQ_DAY35
{
    public class AddressBookManagement
    {

        /// <summary>
        /// UC4- Updating existing contact details.
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public DataTable UpdatedContactDetails(DataTable dataTable)
        {
            var recordData = dataTable.AsEnumerable().Where(a => a.Field<string>("FirstName").Equals("Apoorva")).FirstOrDefault();
            recordData["state"] = "Kerala";
            Console.WriteLine("***********UpdatedData***************");
            Console.WriteLine("FirstName:- " + recordData.Field<string>("firstName"));
            Console.WriteLine("lastName:- " + recordData.Field<string>("lastName"));
            Console.WriteLine("Address:- " + recordData.Field<string>("address"));
            Console.WriteLine("City:- " + recordData.Field<string>("city"));
            Console.WriteLine("State:- " + recordData.Field<string>("state"));
            Console.WriteLine("zip:- " + Convert.ToInt32(recordData.Field<int>("zip")));
            Console.WriteLine("phoneNumber:- " + Convert.ToDouble(recordData.Field<Double>("phoneNumber")));
            Console.WriteLine("eMail:- " + recordData.Field<string>("eMail"));
            Console.WriteLine("***************");

            return dataTable;
        }


        // <summary>
        /// Deletings the contact from table. UC4
        /// </summary>
        /// <param name="datatable">The datatable.</param>
        /// <returns></returns>
        public DataTable DeletingContactFromTable(DataTable datatable)
        {
            //getting all the data except the data to be deleted
            //saving them in new data table by copytodatatable method
            //returning the new data table
            DataTable dataTableupdated = datatable.AsEnumerable().Except(datatable.AsEnumerable().Where(r => r.Field<string>("firstName") == "Kamalakar" && r.Field<string>("lastName") == "Singh")).CopyToDataTable();
            foreach (var data in dataTableupdated.AsEnumerable())
            {
                Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
                Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
                Console.WriteLine("Address:- " + data.Field<string>("address"));
                Console.WriteLine("City:- " + data.Field<string>("city"));
                Console.WriteLine("State:- " + data.Field<string>("state"));
                Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
                Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
                Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
                Console.WriteLine("***************");
            }
            return dataTableupdated;
        }

    }
}
