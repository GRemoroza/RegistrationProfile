using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationProfile
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
        }

        public frmConfirmation(long _StudentNo)
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration submitted successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInfoClass.SetStudentNo.ToString();
            lblName.Text = StudentInfoClass.SetFullName;
            lblProgram.Text = StudentInfoClass.SetProgram;
            lblBirthday.Text = StudentInfoClass.SetBirthDay;
            lblGender.Text = StudentInfoClass.SetGender;
            lblContactNo.Text = StudentInfoClass.SetContactNo.ToString();
            lblAge.Text = StudentInfoClass.SetAge.ToString();

        }
    }
}
