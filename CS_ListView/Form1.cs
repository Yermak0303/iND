using System;
using System.Windows.Forms;


namespace CS_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item1;
            item1 = listView1.Items.Add(txtStudentID.Text);
            item1.SubItems.Add(txtFirstname.Text);
            item1.SubItems.Add(txtSurname.Text);
            item1.SubItems.Add(txtAddress.Text);
            item1.SubItems.Add(mtbGraduatepoint.Text);
            item1.SubItems.Add(cmbScale.Text);
            item1.SubItems.Add(cmbCourse.Text);
            item1.SubItems.Add(cmbYear.Text);

            txtStudentID.Text = "";
            txtFirstname.Text = "";
            txtSurname.Text = "";
            txtAddress.Text = "";
            mtbGraduatepoint.Text = "";
            cmbScale.Text = "";
            cmbCourse.Text = "";
            cmbYear.Text = "";

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbScale.Items.Add("A");
            cmbScale.Items.Add("B");
            cmbScale.Items.Add("C");
            cmbScale.Items.Add("D");


            cmbCourse.Items.Add("Computer Sceense");
            cmbCourse.Items.Add("Games Development");
            cmbCourse.Items.Add("Match");
            cmbCourse.Items.Add("OBD");
            cmbCourse.Items.Add("lOGIC");
            cmbCourse.Items.Add("Business Studies");
            cmbCourse.Items.Add("Phisics");
            cmbCourse.Items.Add("TEMK");
            cmbCourse.Items.Add("Auto Cad");


            cmbYear.Items.Add("First");
            cmbYear.Items.Add("second");
            cmbYear.Items.Add("Third");
            cmbYear.Items.Add("Fourth");
            cmbYear.Items.Add("Fifth");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                label9.Text = " Item" + listView1.SelectedIndices[0] + " Was clicked.";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "System Down", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes) { Application.Exit(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ListViewItem item1;
                item1 = listView1.SelectedItems[0];
                item1.Remove();
                label9.Text = "";

            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}