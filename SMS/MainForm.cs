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
        List<Student> students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string StudentID = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();


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

                students.Add(student);
                gcStudentInfo.DataSource = LoadStudents();
                teFirstName.Clear();
                teMiddleName.Clear();
                teLastName.Clear();
                teNameExtension.Clear();
            }

        }

        public List<Student> LoadStudents()
        {
            return students.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to update?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                int focusedRowHandle = gvStudentData.FocusedRowHandle;

                if (focusedRowHandle >= 0)
                {
                    Student rowToUpdate = (Student)gvStudentData.GetRow(focusedRowHandle);

                    if (rowToUpdate != null)
                    {
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
                        gcStudentInfo.DataSource = LoadStudents();

                    }
                    else
                    {
                        XtraMessageBox.Show("Please select a row");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove the student?", "Remove", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                int focusedRowHandle = gvStudentData.FocusedRowHandle;

                if (focusedRowHandle >= 0)
                {
                    Student rowToDelete = (Student)gvStudentData.GetRow(focusedRowHandle);

                    if (rowToDelete != null)
                    {
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
                    this.Close();
                }
            }
        }
    }
}