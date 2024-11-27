//
// dbCustomer DATABASE TABLE FOR CUSTOMERS
// =======================================
// This is a class that manages the customer
// table for the database. It is adapted from
// the basic database class and has a customised
// Data class that provides access to the fields
// in the customer table.
//
// Revision History
// ================
// 02.11.2024 BRD Original version.
// 13.11.2024 BRD Added Query function.
// 20.11.2024 BRD Added function to create the
//                database folder and table
//                folders automatically if they
//                do not exist.
//
using System;

namespace db {
    // Specify the name of the subdirectory that will
    // store the data by setting the tableName variable.
    // None of the other code needs to change when
    // you make a new table class in this way.
    // 
    internal class dbCustomer { 
        private string tableName = "customer";
        public Data data = new Data();
        private dbLib db;         

        //
        // Constructor
        // ===========
        public dbCustomer() {
            // this links the functions in the
            // database library to the Data
            // object that manages the data.
            db = new dbLib(tableName, data); 
        }

        //
        // Read
        // ====
        // Reads the specified record from the database table and unpacks the data in the
        // record if it is found. If the record is not found, all the database entries are
        // automatically set blank so a new record can be created by the program later
        // if necessary.
        //
        public Boolean Read(string ID) { 
            data =  db.Read(ID); 
            return (db.LastError == "");
        }        

        //
        // Update
        // ======
        // This function updates an existing record or creates a new one.
        // Before calling this function, the calling form needs to update
        // each of the data fields.
        // 
        public Boolean Update(string ID) {
            return db.Update(ID);
        }           

        //
        // Query
        // =====
        // Returns a string array containing the IDs of all
        // the records in the table.
        // 
        public string[] Query() { 
            return db.Query();
        }       
    }  
    
    //
    // Data
    // ====
    // This is the internal class that provides access to each named fields
    // stored in the JSON file. Other forms can access these fields by using
    // the method this class provides like this:
    //
    //     textBoxAddress.Text = customer.data.CustomerAddress; 
    // 
    // To add a new field to the table, create a new attribute with the correct
    // get and set methods to manage the new field. Declare the field at the
    // top of this class. The Read() and Update() methods will then automatically
    // process this new field. No changes should be required to the Read() or
    // Update() methods.
    // 
    internal class Data {       

        private string customerID;
        private string customerName;
        private string customerAddress;        
        private string password;         

        public string CustomerID {
            get {return customerID; }
            set {customerID = value; }
        }

        public string CustomerName {
            get {return customerName; }
            set {customerName = value; }
        }

        public string CustomerAddress {
            get {return customerAddress; }
            set {customerAddress = value; }
        }

        public string Password {
            get {return password; }
            set {password = value; }
        }
    }    
}