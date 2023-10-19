using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo, _StudentNo;
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"

            };
            for (int i = 0; i< 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());

            }
        }
        public long StudentNumber(string studNum)
        {
            if (!Regex.IsMatch(studNum, "^[0-9]{10,11}$"))
            {
                throw new FormatException("Invalid student number format.");
            }

            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }
        public long ContactNo(string contact)
        {
            if (!Regex.IsMatch(contact, "^[0-9]{10,11}$"))
            {
                throw new FormatException("Invalid contact number format.");
            }

            _ContactNo = long.Parse(contact);
            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (!Regex.IsMatch(LastName, "^[a-zA-Z]+$") || !Regex.IsMatch(FirstName, "^[a-zA-Z]+$") || !Regex.IsMatch(MiddleInitial, "^[a-zA-Z]+$"))
            {
                throw new FormatException("Invalid name format.");
            }

            _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            return _FullName;
        }
        public int Age(string age)
        {
            if (!Regex.IsMatch(age, "^[0-9]{1,3}$"))
            {
                throw new FormatException("Invalid age format.");
            }
            _Age = int.Parse(age);
            if (_Age < 1 || _Age > 150)
            {
                throw new ArgumentOutOfRangeException("Age is out of valid range.");
            }
            return _Age;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {

            try
            {
                StudentInfoClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);
                StudentInfoClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInfoClass.SetProgram = cbPrograms.Text;
                StudentInfoClass.SetGender = cbGender.Text;
                StudentInfoClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInfoClass.SetAge = Age(txtAge.Text);
                StudentInfoClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirmation frm = new frmConfirmation(StudentInfoClass.SetStudentNo);
                frm.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}