using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Contact
{
    public partial class frmAddorEdite : Form
    {
        public int ContactID = 0;
        EF_DBEntities db=new EF_DBEntities();
        public frmAddorEdite()
            
        {
            
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddorEdite_Load(object sender, EventArgs e)
        {
            
            if (ContactID==0)
            {
                lbladoredite.Text = "ADD USER";
            }
            else
            {
                lbladoredite.Text = "EDITE USER";
                People contact=db.People.Find(ContactID);
                txtname.Text=contact.Name;
                txtfamily.Text=contact.Family;
                txtemail.Text = contact.Email;
                txtMobile.Text = contact.Mobile;
                txtAddres.Text = contact.location;
                dtPicker.Value = (DateTime)contact.Age;

            }
        }

        bool ValidateInput() 
        {

            if (txtname.Text=="")
            {
                MessageBox.Show("Please enter name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtfamily.Text =="")
            {
                MessageBox.Show("Please enter Family ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("Please enter Mobile ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                People contact = new People();
                contact.Name = txtname.Text;
                contact.Family = txtfamily.Text;
                contact.Mobile = txtMobile.Text;
                contact.Age = dtPicker.Value;
                contact.Email = txtemail.Text;
                contact.location = txtAddres.Text;
                db.People.Add(contact);

                if (ContactID==0)
                {

                   db.People.Add(contact);
                    
                }
                else
                {
                    People people=db.People.Find(ContactID);
                    people.Name = txtname.Text;
                    people.Family = txtfamily.Text;
                    people.Email = txtemail.Text;
                    people.Mobile= txtMobile.Text;
                    people.Age= dtPicker.Value;
                    people.location= txtAddres.Text;


                }
                db.SaveChanges();
                MessageBox.Show("mission accomplished");
              DialogResult = DialogResult.OK;
            }
        }
    }
}
