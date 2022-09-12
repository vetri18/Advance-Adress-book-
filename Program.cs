using System.Data;

namespace AddressBookProblem_LINQ_DAY35
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Problem for LINQ");

            //Creating DataTable for addressbook problem UC1
            DataTable addressBookTable = new DataTable();


            //adding columns into address book table UC2
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "firstName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lastName";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "address";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "city";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "state";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "zip";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "phoneNumber";
            addressBookTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "eMail";
            addressBookTable.Columns.Add(column);

            // Make the first name and mobile no column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[2];
            PrimaryKeyColumns[0] = addressBookTable.Columns["firstName"];
            PrimaryKeyColumns[1] = addressBookTable.Columns["phoneNumber"];
            addressBookTable.PrimaryKey = PrimaryKeyColumns;



            //Inserting data into columns into datatable UC3
           addressBookTable.Rows.Add("Tamil", "velan", "Madurai", "andipatty", "Tamilnadu", 642345, 984563789, "tamilvelan24");
            addressBookTable.Rows.Add("Anish", "Paster", "Ambal Nagar", "hosur", "Tamilnadu", 123456, 8976543212, "anishmsav123");
            addressBookTable.Rows.Add("Anil", "Kumar", "alanganallur", "electroniccity", "banglore", 125445, 8787878787, "a.kumar23");
            addressBookTable.Rows.Add("chandru", "kalamath", "gadag", "gadag", "banglore", 123456, 9595959595, "chandrukalamath43");
            addressBookTable.Rows.Add("Praveen", "Kumar", "rohini", "Delhi", "Delhi", 435121, 7897897898, "praveen.kumar");
            addressBookTable.Rows.Add("Aparna", "Sri", "Andipatty", "Madurai", "Tamilnadu", 125445, 980000067, "aparnasr34");



            AddressBookManagement addressBookManagement = new AddressBookManagement();
            //UC4
            //addressBookTable = addressBookManagement.UpdatedContactDetails(addressBookTable);
            ////var book = addressBookTable.AsEnumerable().Select(r => r.Field<string>("state"));
            //Console.WriteLine("*******************Total data*****************");
            //foreach (var data in addressBookTable.AsEnumerable())
            //{
            //    Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
            //    Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
            //    Console.WriteLine("Address:- " + data.Field<string>("address"));
            //    Console.WriteLine("City:- " + data.Field<string>("city"));
            //    Console.WriteLine("State:- " + data.Field<string>("state"));
            //    Console.WriteLine("zip:- " + Convert.ToInt32(data.Field<int>("zip")));
            //    Console.WriteLine("phoneNumber:- " + Convert.ToDouble(data.Field<Double>("phoneNumber")));
            //    Console.WriteLine("eMail:- " + data.Field<string>("eMail"));
            //    Console.WriteLine("***************");



            //}

            //UC5- deleting contacts from address book table.
            //addressBookTable = addressBookManagement.DeletingContactFromTable(addressBookTable);


            //UC6
            //addressBookManagement.RetrievingContactDetailsByStateOrCity(addressBookTable);


            //UC7
            addressBookManagement.GetCountByCityAndState(addressBookTable);


        }

    }
}
