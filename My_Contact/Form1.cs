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
    public partial class Form1 : Form
    {
        public int contactID;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh_Grid();
        }

        private void Refresh_Grid()
        {
            using (EF_DBEntities db = new EF_DBEntities())
            {

                dgcontact.AutoGenerateColumns = false;
                dgcontact.DataSource = db.People.ToList();
                db.SaveChanges();
            }
        }

        //close Form1
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add user
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmAddorEdite frm = new frmAddorEdite();
            frm.ShowDialog();
            if (frm.DialogResult==DialogResult.OK)
            {
                Refresh_Grid();
            }
        }

        //Search
        private void txtsearch_TextChange(object sender, EventArgs e)
        {
            using (EF_DBEntities db = new EF_DBEntities())
            {

                dgcontact.DataSource = db.People.Where(p => p.Name.ToLower().Contains(txtsearch.Text) || p.Family.ToLower().Contains(txtsearch.Text)).ToList();

            }
        }

       

        //Delete
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (dgcontact.CurrentRow != null)
            {
                string name = dgcontact.CurrentRow.Cells[1].Value.ToString();
                string family = dgcontact.CurrentRow.Cells[2].Value.ToString();
                string fulname = name+family;
                if (MessageBox.Show($"Are you sure about removing {fulname}", "Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    using (EF_DBEntities db = new EF_DBEntities())
                    {
                        contactID = int.Parse(dgcontact.CurrentRow.Cells[0].Value.ToString());
                        People select= db.People.Single(p => p.PersonID==contactID);
                        db.People.Remove(select);
                        db.SaveChanges();

                    }
                    Refresh_Grid();
                }
            }

        }

        private void BtnEdite_Click(object sender, EventArgs e)
        {
            if (dgcontact.CurrentRow!=null)
            {
                contactID = int.Parse(dgcontact.CurrentRow.Cells[0].Value.ToString());                
                frmAddorEdite frm = new frmAddorEdite();
                frm.ContactID = contactID;
                frm.ShowDialog();
                if (frm.DialogResult==DialogResult.OK)
                {
                    Refresh_Grid();
                }
            }
        
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            Refresh_Grid();
        }
    }
}
