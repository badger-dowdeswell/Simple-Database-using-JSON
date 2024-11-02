//
// SIMPLE DATABASE MANAGEMENT EXAMPLE
// ==================================
// Studio 2 projects often need a simple
// database to persist data such as customer
// and product information.
//
// This project demonstrates how to build a
// custom class to manage each database table
// in a way similiar to a SQL client might
// access a database. However, the tables are
// stored as separate Java Script Object
// Notation (JSON) format text files.  
//
// JSON is an open standard file format that
// uses human-readable text to store information
// as data objects consisting of attribute–value
// pairs and arrays. You can read more about the
// JSON standard on Wikipedia:
// https://en.wikipedia.org/wiki/JSON
//
// Revision History
// ================
// 02.11.2024 BRD Original version.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Database {
    public partial class FormMain : Form {

        //
        // Constructor
        // ===========
        public FormMain() {
            InitializeComponent();
        }

        //
        // FormMain_Load
        // =============
        private void FormMain_Load(object sender, EventArgs e) {

        }
    }
}
