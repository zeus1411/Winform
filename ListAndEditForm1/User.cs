using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListAndEditForm1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        

        private void btRegister_Click(object sender, EventArgs e)
        {
            Userr user = new Userr();
            int id = Convert.ToInt32(tbID.Text);
            string fname = tbFname.Text;
            string lname = tbLname.Text;
            string username = tbUsername.Text;
            string password = tbPass.Text;
            MemoryStream fig = new MemoryStream();

            if(verif())
            {
                pictureBox1.Image.Save(fig, pictureBox1.Image.RawFormat);
                if(user.InsertUser(id,fname,lname, username, password,fig))
                {
                    MessageBox.Show("New Student Added", "Register Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Register Completed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Register Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((tbFname.Text.Trim() == "")
                        || (tbLname.Text.Trim() == "")
                        || (tbUsername.Text.Trim() == "")
                        || (tbPass.Text.Trim() == "")
                        || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void btUpLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
