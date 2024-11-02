//
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Database {
    public partial class FormCustomer : Form {

        Form FormParent;

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
            this.Visible = false;

            // Go back to the parent of this form which is FormMain.
            FormParent.Show();
        }        
    }
}
