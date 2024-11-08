﻿//
// MAINTAIN CUSTOMER INFORMATION
// =============================
// This form is used to manage the creation
// of new customers in the Customer database
// table. It also allows the information for
// each customer to be changed and updated
// later.
//
// Revision History
// ================
// 02.11.2024 BRD Original version.
//
using System;
using System.Windows.Forms;

namespace Simple_Database {
    public partial class FormCustomer : Form {

        Form FormParent;

        // Trick to stop the dialogue boxes showing 
        // repeatedly when trying to create a new
        // customer. Look in the other functions to
        // see when and how it is used.
        Boolean creating = false;

        string customerID = "";
        
        // Create the database object to handle the reading
        // and updating of customer data.
        dbCustomer customer = new dbCustomer();

        dbProduct product = new dbProduct(); 

        //
        // Constructor
        // ===========
        public FormCustomer(Form FormParent) {
            InitializeComponent();

            // The parent of this form is FormMain. A reference
            // to it was passed in via this Constructor. Save it
            // so we know where to go back to when we close
            // this form.
            this.FormParent = FormParent;            
        }

        //
        // FormCustomer_Load
        // =================
        private void FormCustomer_Load(object sender, EventArgs e) {            
        }
       
        //
        // textBoxCustomerID_Enter
        // =======================
        private void textBoxCustomerID_Enter(object sender, EventArgs e) {
            textBoxCustomerName.Text = "";
            textBoxAddress.Text = "";
            textBoxPassword.Text = "";
        }
                
        //
        // textBoxCustomerID_TextChanged
        // =============================
        private void textBoxCustomerID_TextChanged(object sender, EventArgs e) {
            customerID = textBoxCustomerID.Text.Trim();
            customer.data.CustomerID = customerID;            
        }

        //
        // textBoxCustomerID_Leave
        // =======================
        private void textBoxCustomerID_Leave(object sender, EventArgs e) {
            DialogResult result;

            if (!creating) {
                customerID = textBoxCustomerID.Text.Trim();
                if (customerID != "") {
                    if (customer.Read(customerID)) {
                        textBoxCustomerName.Text = customer.data.CustomerName;
                        textBoxAddress.Text = customer.data.CustomerAddress; 
                        textBoxPassword.Text = customer.data.Password;
                    } else {
                        result = MessageBox.Show("Click Yes to create a new customer",                          
                                                 "Customer does not exist",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes) {
                            creating = true;
                            textBoxCustomerName.Focus();
                        } else {
                            textBoxCustomerID.Text = "";
                            textBoxCustomerID.Focus();
                        }
                    }
                }
            }
        }

        //
        // textBoxCustomerName_TextChanged
        // ===============================
        private void textBoxCustomerName_TextChanged(object sender, EventArgs e) {
            customer.data.CustomerName = textBoxCustomerName.Text.Trim();
        }

        //
        // textBoxAddress_TextChanged
        // ==========================
        private void textBoxAddress_TextChanged(object sender, EventArgs e) {
            customer.data.CustomerAddress = textBoxAddress.Text.Trim();
        }

        //
        // textBoxPassword_TextChanged
        // ===========================
        private void textBoxPassword_TextChanged(object sender, EventArgs e) {
            customer.data.Password = textBoxPassword.Text.Trim();
        }

        //
        // buttonUpdate_Click
        // ==================
        private void buttonUpdate_Click(object sender, EventArgs e) {
            customer.Update(customerID);  
            textBoxCustomerID.Text = "";
            creating = false;
            textBoxCustomerID.Focus();
        }

        //
        // buttonClose_Click
        // =================
        // Return to FormMain. See the project Form Loading available on
        // GitHub for more information about managing multiple forms in
        // a Visual Studio C# project.
        //
        private void buttonClose_Click(object sender, EventArgs e) {
            // Hide this form now we have finished with it. Note that
            // this does not destroy FormOne or its lose its data. If
            // we come back, it will remember what we did last time.
            creating = false;
            this.Visible = false;

            // Go back to the parent of this form which is FormMain.
            FormParent.Show();
        }        
    }
}
