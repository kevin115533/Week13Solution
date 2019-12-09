namespace Week13Project
{
    partial class frmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCustomerType = new System.Windows.Forms.GroupBox();
            this.rBtnRes = new System.Windows.Forms.RadioButton();
            this.rBtnGov = new System.Windows.Forms.RadioButton();
            this.rBtnCom = new System.Windows.Forms.RadioButton();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblNeighborhood = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblBusinessPhone = new System.Windows.Forms.Label();
            this.lblEDI = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblGovID = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.grpCustomerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerType
            // 
            this.grpCustomerType.Controls.Add(this.rBtnRes);
            this.grpCustomerType.Controls.Add(this.rBtnGov);
            this.grpCustomerType.Controls.Add(this.rBtnCom);
            this.grpCustomerType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerType.Location = new System.Drawing.Point(13, 13);
            this.grpCustomerType.Name = "grpCustomerType";
            this.grpCustomerType.Size = new System.Drawing.Size(547, 62);
            this.grpCustomerType.TabIndex = 0;
            this.grpCustomerType.TabStop = false;
            this.grpCustomerType.Text = "Customer Type";
            // 
            // rBtnRes
            // 
            this.rBtnRes.AutoSize = true;
            this.rBtnRes.Checked = true;
            this.rBtnRes.Location = new System.Drawing.Point(36, 27);
            this.rBtnRes.Name = "rBtnRes";
            this.rBtnRes.Size = new System.Drawing.Size(104, 25);
            this.rBtnRes.TabIndex = 8;
            this.rBtnRes.Text = "Residential";
            this.rBtnRes.UseVisualStyleBackColor = true;
            this.rBtnRes.CheckedChanged += new System.EventHandler(this.rBtnRes_CheckedChanged);
            // 
            // rBtnGov
            // 
            this.rBtnGov.AutoSize = true;
            this.rBtnGov.Location = new System.Drawing.Point(386, 27);
            this.rBtnGov.Name = "rBtnGov";
            this.rBtnGov.Size = new System.Drawing.Size(115, 25);
            this.rBtnGov.TabIndex = 7;
            this.rBtnGov.Text = "Government";
            this.rBtnGov.UseVisualStyleBackColor = true;
            this.rBtnGov.CheckedChanged += new System.EventHandler(this.rBtnGov_CheckedChanged);
            // 
            // rBtnCom
            // 
            this.rBtnCom.AutoSize = true;
            this.rBtnCom.Location = new System.Drawing.Point(201, 27);
            this.rBtnCom.Name = "rBtnCom";
            this.rBtnCom.Size = new System.Drawing.Size(112, 25);
            this.rBtnCom.TabIndex = 6;
            this.rBtnCom.Text = "Commercial";
            this.rBtnCom.UseVisualStyleBackColor = true;
            this.rBtnCom.CheckedChanged += new System.EventHandler(this.rBtnCom_CheckedChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(16, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(71, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(16, 114);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 16);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(16, 144);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(88, 16);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd1.Location = new System.Drawing.Point(287, 179);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(67, 16);
            this.lblAdd1.TabIndex = 4;
            this.lblAdd1.Text = "Address 1";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(16, 234);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(26, 16);
            this.lblZip.TabIndex = 5;
            this.lblZip.Text = "Zip";
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd2.Location = new System.Drawing.Point(287, 209);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(67, 16);
            this.lblAdd2.TabIndex = 6;
            this.lblAdd2.Text = "Address 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(16, 174);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(16, 204);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 16);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePhone.Location = new System.Drawing.Point(287, 84);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(83, 16);
            this.lblHomePhone.TabIndex = 9;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // lblNeighborhood
            // 
            this.lblNeighborhood.AutoSize = true;
            this.lblNeighborhood.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighborhood.Location = new System.Drawing.Point(287, 114);
            this.lblNeighborhood.Name = "lblNeighborhood";
            this.lblNeighborhood.Size = new System.Drawing.Size(95, 16);
            this.lblNeighborhood.TabIndex = 10;
            this.lblNeighborhood.Text = "Neighborhood";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.Location = new System.Drawing.Point(286, 84);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(96, 16);
            this.lblBusinessName.TabIndex = 11;
            this.lblBusinessName.Text = "Business Name";
            this.lblBusinessName.Visible = false;
            // 
            // lblBusinessPhone
            // 
            this.lblBusinessPhone.AutoSize = true;
            this.lblBusinessPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessPhone.Location = new System.Drawing.Point(286, 114);
            this.lblBusinessPhone.Name = "lblBusinessPhone";
            this.lblBusinessPhone.Size = new System.Drawing.Size(97, 16);
            this.lblBusinessPhone.TabIndex = 12;
            this.lblBusinessPhone.Text = "Business Phone";
            this.lblBusinessPhone.Visible = false;
            // 
            // lblEDI
            // 
            this.lblEDI.AutoSize = true;
            this.lblEDI.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDI.Location = new System.Drawing.Point(286, 144);
            this.lblEDI.Name = "lblEDI";
            this.lblEDI.Size = new System.Drawing.Size(62, 16);
            this.lblEDI.TabIndex = 13;
            this.lblEDI.Text = "EDI Code";
            this.lblEDI.Visible = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(287, 144);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(80, 16);
            this.lblCustomerID.TabIndex = 14;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(286, 84);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(109, 16);
            this.lblContract.TabIndex = 15;
            this.lblContract.Text = "Contract Number";
            this.lblContract.Visible = false;
            // 
            // lblGovID
            // 
            this.lblGovID.AutoSize = true;
            this.lblGovID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGovID.Location = new System.Drawing.Point(286, 114);
            this.lblGovID.Name = "lblGovID";
            this.lblGovID.Size = new System.Drawing.Size(95, 16);
            this.lblGovID.TabIndex = 16;
            this.lblGovID.Text = "Government ID";
            this.lblGovID.Visible = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(287, 144);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(77, 16);
            this.lblDepartment.TabIndex = 17;
            this.lblDepartment.Text = "Department";
            this.lblDepartment.Visible = false;
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(109, 81);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(160, 24);
            this.txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            this.txtLast.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.Location = new System.Drawing.Point(109, 111);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(160, 24);
            this.txtLast.TabIndex = 1;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.Location = new System.Drawing.Point(109, 141);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(160, 24);
            this.txtMiddle.TabIndex = 2;
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.Location = new System.Drawing.Point(380, 176);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(179, 24);
            this.txtAdd1.TabIndex = 9;
            // 
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.Location = new System.Drawing.Point(380, 206);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(179, 24);
            this.txtAdd2.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(109, 171);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(160, 24);
            this.txtCity.TabIndex = 3;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(109, 201);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(160, 24);
            this.txtState.TabIndex = 4;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(109, 231);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(160, 24);
            this.txtZip.TabIndex = 5;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(399, 81);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(160, 24);
            this.txt1.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(399, 141);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(160, 24);
            this.txt3.TabIndex = 8;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(399, 111);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(160, 24);
            this.txt2.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(290, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(19, 283);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(540, 196);
            this.lblDisplay.TabIndex = 30;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(424, 236);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(115, 23);
            this.btnDisplay.TabIndex = 31;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 488);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblGovID);
            this.Controls.Add(this.lblContract);
            this.Controls.Add(this.lblEDI);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdd2);
            this.Controls.Add(this.txtAdd1);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblBusinessPhone);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblNeighborhood);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAdd2);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblAdd1);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.grpCustomerType);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.grpCustomerType.ResumeLayout(false);
            this.grpCustomerType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerType;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.RadioButton rBtnGov;
        private System.Windows.Forms.RadioButton rBtnCom;
        private System.Windows.Forms.RadioButton rBtnRes;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblNeighborhood;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblBusinessPhone;
        private System.Windows.Forms.Label lblEDI;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.Label lblGovID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnDisplay;
    }
}

