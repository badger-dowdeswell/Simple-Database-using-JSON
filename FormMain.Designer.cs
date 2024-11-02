namespace Simple_Database {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelManageCustomers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelManageCustomers
            // 
            this.labelManageCustomers.AutoSize = true;
            this.labelManageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCustomers.Location = new System.Drawing.Point(61, 56);
            this.labelManageCustomers.Name = "labelManageCustomers";
            this.labelManageCustomers.Size = new System.Drawing.Size(148, 20);
            this.labelManageCustomers.TabIndex = 0;
            this.labelManageCustomers.Text = "Manage Customers";
            this.labelManageCustomers.Click += new System.EventHandler(this.labelManageCustomers_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelManageCustomers);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Database Management Example";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageCustomers;
    }
}

