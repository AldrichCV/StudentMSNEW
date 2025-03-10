using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        //The list that holds the student's information//
        List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        //Adds Student's data to List//
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Auto Generates ID//
            string StudentID = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();

            //Validates empty form fields//
            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teMiddleName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text) ||
                string.IsNullOrWhiteSpace(cbGender.Text) ||
                string.IsNullOrWhiteSpace(deDateOfBirth.Text) ||
                string.IsNullOrWhiteSpace(cbDepartment.Text) ||
                string.IsNullOrWhiteSpace(cbYearLevel.Text))
            {
                MessageBox.Show("Please fill in all fields!");
            }

            else
            {
                //Adds student data to the class
                Student student = new Student();
                {
                    student.StudentID = StudentID;
                    student.FirstName = teFirstName.Text;
                    student.MiddleName = teMiddleName.Text;
                    student.LastName = teLastName.Text;
                    student.NameExtension = teNameExtension.Text;
                    student.Gender = cbGender.Text;
                    student.DateOfBirth = deDateOfBirth.DateTime.Date;
                    student.Department = cbDepartment.Text;
                    student.YearLevel = cbYearLevel.Text;

                };
                //Then adds the data to list
                students.Add(student);

                //Loads the student's data to gridcontrol
                gcStudentInfo.DataSource = LoadStudents();
                teFirstName.Clear();
                teMiddleName.Clear();
                teLastName.Clear();
                teNameExtension.Clear();
            }

        }

        //Loads the student's data
        public List<Student> LoadStudents()
        {
            return students.ToList();
        }

        //Updates the student's data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validates if user is sure to update
            DialogResult dialogResult = MessageBox.Show("Are you sure to update?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //If yes, then it gets the selected row
                int focusedRowHandle = gvStudentData.FocusedRowHandle;

                if (focusedRowHandle >= 0)
                {
                    Student rowToUpdate = (Student)gvStudentData.GetRow(focusedRowHandle);

                    if (rowToUpdate != null)
                    {
                        //Then replaces the existing data of that row
                        Student student = new Student();
                        {
                            rowToUpdate.FirstName = teFirstName.Text;
                            rowToUpdate.MiddleName = teMiddleName.Text;
                            rowToUpdate.LastName = teLastName.Text;
                            rowToUpdate.NameExtension = teNameExtension.Text;
                            rowToUpdate.Gender = cbGender.Text;
                            rowToUpdate.DateOfBirth = deDateOfBirth.DateTime.Date;
                            rowToUpdate.Department = cbDepartment.Text;
                            rowToUpdate.YearLevel = cbYearLevel.Text;
                        };
                        //And loads it back to the gridcontrol
                        gcStudentInfo.DataSource = LoadStudents();

                    }
                    else
                    {
                        XtraMessageBox.Show("Please select a row");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //If no, then the update is cancelled
                    this.Close();
                }
            }
        }

        //Removes the student's data
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove the student?", "Remove", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //If yes, then it gets the selected row
                int focusedRowHandle = gvStudentData.FocusedRowHandle;

                if (focusedRowHandle >= 0)
                {
                    Student rowToDelete = (Student)gvStudentData.GetRow(focusedRowHandle);

                    if (rowToDelete != null)
                    { //Then removes it from the list
                        students.Remove(rowToDelete);
                        gcStudentInfo.DataSource = students;
                        gvStudentData.RefreshData();

                    }
                    else
                    {
                        XtraMessageBox.Show("Please select a row");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //If no, then the removal is cancelled
                    this.Close();
                }
            }
        }
    }
}