﻿using System;
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



        /// <summary>
        /// UC6 - Retrievings the contact details by state or city.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public void RetrievingContactDetailsByStateOrCity(DataTable dataTable)
        {
            //lambda syntax for getting data for particular city
            var recordDataCity = dataTable.AsEnumerable().Where(r => r.Field<string>("city") == "Mumbai");
            //lambda syntax for getting data for particular state
            var recordDataState = dataTable.AsEnumerable().Where(r => r.Field<string>("state") == "Maharashtra");
            foreach (var data in recordDataState)
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

        }


        /// <summary>
        /// UC7 - Getting the count after grouping by city and state.
        /// </summary>
        /// <param name="datatable">The datatable.</param>
        public void GetCountByCityAndState(DataTable datatable)
        {
            //getting count for particular state or city
            var recordData = datatable.AsEnumerable().Where(r => r.Field<string>("city") == "Mumbai" && r.Field<string>("state") == "Maharashtra").Count();
            //grouping data by city and state
            var recordedData = from data in datatable.AsEnumerable()
                               group data by new { city = data.Field<string>("city"), state = data.Field<string>("state") } into g
                               select new { city = g.Key, count = g.Count() };
            //displaying data for particular city or state
            Console.WriteLine(recordData);
            //displaying total grouped data
            foreach (var data in recordedData.AsEnumerable())
            {
                Console.WriteLine("city:- " + data.city.city);
                Console.WriteLine("state:- " + data.city.state);
                Console.WriteLine("Count:- " + data.count);
                Console.WriteLine("*******************");

            }

        }


    }
}
