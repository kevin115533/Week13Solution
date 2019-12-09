using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Kevin Tran
 * ITD 1253
 * Fall 2019
 */

namespace Week13Project
{
    public partial class frmCustomers : Form
    {
        Customers c;
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void rBtnCom_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCom.Checked == true)
            {
                lblHomePhone.Visible = false;
                lblNeighborhood.Visible = false;
                lblCustomerID.Visible = false;
                lblEDI.Visible = true;
                lblBusinessName.Visible = true;
                lblBusinessPhone.Visible = true;
                lblContract.Visible = false;
                lblDepartment.Visible = false;
                lblGovID.Visible = false;
            }
        }

        private void rBtnRes_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRes.Checked == true)
            {
                lblHomePhone.Visible = true;
                lblNeighborhood.Visible = true;
                lblCustomerID.Visible = true;
                lblEDI.Visible = false;
                lblBusinessName.Visible = false;
                lblBusinessPhone.Visible = false;
                lblContract.Visible = false;
                lblDepartment.Visible = false;
                lblGovID.Visible = false;
            }
        }

        private void rBtnGov_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnGov.Checked == true)
            {
                lblHomePhone.Visible = false;
                lblNeighborhood.Visible = false;
                lblCustomerID.Visible = false;
                lblEDI.Visible = false;
                lblBusinessName.Visible = false;
                lblBusinessPhone.Visible = false;
                lblContract.Visible = true;
                lblDepartment.Visible = true;
                lblGovID.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            string middleName = txtMiddle.Text;
            string address1 = txtAdd1.Text;
            string address2 = txtAdd2.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;
            string info1 = txt1.Text;
            string info2 = txt2.Text;
            string info3 = txt3.Text;
            
            if(rBtnRes.Checked == true)
            {
                Residential resident = new Residential(firstName, lastName, middleName, address1, address2, city, state, zip, info1, info2, info3);
                c = resident;
            }
            if(rBtnCom.Checked == true)
            {
                Commercial comm = new Commercial(firstName, lastName, middleName, address1, address2, city, state, zip, info1, info2, info3);
                c = comm;
            }
            if(rBtnGov.Checked == true)
            {
                Government gov = new Government(firstName, lastName, middleName, address1, address2, city, state, zip, info1, info2, info3);
                c = gov;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
                lblDisplay.Text = c.displayInfo(" ");
        }
    }
}
