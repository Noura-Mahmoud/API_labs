using InsDeptDesktopApp.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InsDeptDesktopApp
{
    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewInstructors.SelectionChanged -= Instructors_SelectionChanged;
            dataGridViewDepts.SelectionChanged -= Depts_SelectionChanged;

            client = new HttpClient();

            HttpResponseMessage resultIns = client.GetAsync(ConfigurationManager.AppSettings["Instructors"]).Result;
            if (resultIns.IsSuccessStatusCode)
            {
                List<Instructor> instructors = resultIns.Content.ReadAsAsync<List<Instructor>>().Result;
                dataGridViewInstructors.DataSource = instructors;
            }
            else
            {
                MessageBox.Show("Error");
            }

            HttpResponseMessage resultDept = client.GetAsync(ConfigurationManager.AppSettings["Departments"]).Result;
            if (resultDept.IsSuccessStatusCode)
            {
                List<Department> departments = resultDept.Content.ReadAsAsync<List<Department>>().Result;
                dataGridViewDepts.DataSource = departments;

                // link them to combobox
                comboBoxDept.DataSource = departments;
                comboBoxDept.ValueMember = "Id";
                comboBoxDept.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Error");
            }
            FillInsBoxesWithData(new Instructor()
            {
                Name = "Mona",
                SSN = "812-63-5056",
                Address = "mmmm",
                Phone = "223-776-5436",
                Email = "m@m.m",
                Password = "Ads@sd235",
                Age = 30,
                Salary = 3000,
                DOB = DateTime.Parse("6/6/1990")
            }) ;
            comboBoxDept.SelectedIndex = 0;
            FillDeptBoxesWithData(new Department()
            {
                Name = "UI",
                Description = "User nterface",
                Branches = "Smart, Alex, Ismalia",
                Location = "Smart"
            });

            dataGridViewInstructors.Rows[0].Selected = true;
            dataGridViewDepts.Rows[0].Selected = true;

            //dataGridViewInstructors.SelectionChanged += Instructors_SelectionChanged;
            insPage.Enter += addInstructorsSelectionChanged;
            insPage.Leave += removeInstructorsSelectionChanged;

            //dataGridViewDepts.SelectionChanged += Depts_SelectionChanged;
            deptPage.Enter += addDeptsSelectionChanged;
            deptPage.Leave += removeDeptsSelectionChanged;
        }

        private void addInstructorsSelectionChanged(object sender, EventArgs e)
        {
            dataGridViewInstructors.Rows[0].Selected = true;
            dataGridViewDepts.Rows[0].Selected = true;
            dataGridViewInstructors.SelectionChanged += Instructors_SelectionChanged;
        }
        private void removeInstructorsSelectionChanged(object sender, EventArgs e)
        {
            dataGridViewDepts.Rows[0].Selected = true;
            dataGridViewInstructors.SelectionChanged -= Instructors_SelectionChanged;
        }
        private void addDeptsSelectionChanged(object sender, EventArgs e)
        {
            dataGridViewDepts.Rows[0].Selected = true;
            dataGridViewInstructors.SelectionChanged += Instructors_SelectionChanged;

            dataGridViewDepts.SelectionChanged += Depts_SelectionChanged;
        }
        private void removeDeptsSelectionChanged(object sender, EventArgs e)
        {
            dataGridViewInstructors.Rows[0].Selected = true;
            dataGridViewDepts.SelectionChanged -= Depts_SelectionChanged;
        }
        private void btnNewDept_Click(object sender, EventArgs e)
        {
            Department dept =GetDeptDataFromBoxes();
            if (dept == null)
            {
                MessageBox.Show("Check the data again");
            }
            else
            {
                HttpResponseMessage resultDept = client.PostAsJsonAsync(ConfigurationManager.AppSettings["Departments"], dept).Result;
                //HttpResponseMessage resultDept = client.PostAsJsonAsync("https://localhost:7167/api/Departments", dept).Result;
                if (resultDept.IsSuccessStatusCode)
                {
                    Form1_Load(null, null);
                }
                else
                {
                    //MessageBox.Show(resultDept.StatusCode.ToString());
                    MessageBox.Show("Error adding new department");
                }
            }
        }

        private void btnNewIns_Click(object sender, EventArgs e)
        {
            //if(!Decimal.TryParse(txtSalary.Text, out decimal salary))
            //{
            //    MessageBox.Show("Salary must be a number");
            //}
            //else if (!int.TryParse(txtAge.Text, out int age))
            //{
            //    MessageBox.Show("Age must be a number");
            //}
            //else 
            //{
            //    Instructor ins = new Instructor()
            //    {
            //Name = txtNameIns.Text,
            //SSN = txtSSN.Text,
            //Address = txtAddress.Text,
            //Phone = txtPhone.Text,
            //Email = txtEmail.Text,
            //Password = txtPassword.Text,
            //Age = age,
            //Salary = salary,
            ////DOB = DateTime.Parse(birthDate.Text)
            //DOB = DateTime.Parse(txtBirthdate.Text)
            //};

            Instructor ins = GetInsDataFromBoxes();
            if (ins == null)
            {
                MessageBox.Show("Chheck the data again");
            }
            else
            {
                HttpResponseMessage resultIns = client.PostAsJsonAsync(ConfigurationManager.AppSettings["Instructors"], ins).Result;
                //HttpResponseMessage resultIns = client.PostAsJsonAsync("https://localhost:7167/api/Instructors", ins).Result;
                if (resultIns.IsSuccessStatusCode)
                {
                    Form1_Load(null, null);
                }
                else
                {
                    //MessageBox.Show(resultIns.StatusCode.ToString());
                    MessageBox.Show("Error adding new instructor");
                }
            }
            //}
        }

        private void dataGridViewInstructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this instructor?", "Confirm", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                int id = (int) dataGridViewInstructors.SelectedRows[0].Cells[0].Value;
                HttpResponseMessage resultDeleteIns = client.DeleteAsync($"https://localhost:7167/api/Instructors/{id}").Result;
                //HttpResponseMessage resultDeleteIns = client.DeleteAsync(ConfigurationManager.AppSettings["Instructors"]+$"/{id}").Result;
                if (resultDeleteIns.IsSuccessStatusCode)
                {
                    Form1_Load(null, null);
                }
                else
                {
                    //MessageBox.Show(resultDeleteIns.StatusCode.ToString());
                    MessageBox.Show("Error deleting new instructor");
                }
            }
        }

        private void Instructors_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewInstructors.SelectedRows[0].Cells[0].Value;
                HttpResponseMessage resultIns = client.GetAsync(ConfigurationManager.AppSettings["Instructors"] + $"/{id}").Result;
                Instructor instructor = resultIns.Content.ReadAsAsync<Instructor>().Result;
                FillInsBoxesWithData(instructor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }


        private Instructor GetInsDataFromBoxes()
        {
            if (!Decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Salary must be a number");
                return null;
            }
            else if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age must be a number");
                return null;
            }
            else
            {
                return new Instructor()
                {
                    Name = txtNameIns.Text,
                    SSN = txtSSN.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Age = age,
                    Salary = salary,
                    //DOB = DateTime.Parse(birthDate.Text)
                    DOB = DateTime.Parse(txtBirthdate.Text),
                    DepartmentId = (int) comboBoxDept.SelectedValue
                };
            }
        }
        private Department GetDeptDataFromBoxes()
        {
            return new Department()
            {
                Name = txtNameDept.Text,
                Location = txtLocation.Text,
                Description = txtDescription.Text,
                Branches = txtBranches.Text
            };
        }

        private void FillInsBoxesWithData(Instructor instructor)
        {
            txtNameIns.Text = instructor.Name;
            txtSSN.Text = instructor.SSN;
            txtAddress.Text = instructor.Address;
            txtPhone.Text = instructor.Phone;
            txtEmail.Text = instructor.Email;
            txtPassword.Text = instructor.Password;
            txtAge.Text = instructor.Age.ToString();
            txtSalary.Text = instructor.Salary.ToString();
            txtBirthdate.Text = instructor.DOB.Date.ToString();
            comboBoxDept.SelectedValue = instructor.DepartmentId;
        }

        private void FillDeptBoxesWithData(Department department)
        {
            txtNameDept.Text = department.Name;
            txtLocation.Text = department.Location;
            txtDescription.Text = department.Description;
            txtBranches.Text = department.Branches;
        }

        private void btnUpdateIns_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewInstructors.SelectedRows[0].Cells[0].Value;
            Instructor ins = GetInsDataFromBoxes();
            ins.Id = id;
            HttpResponseMessage resultUpdateIns = client.PutAsJsonAsync($"https://localhost:7167/api/Instructors/{id}", ins).Result;
            //HttpResponseMessage resultUpdateIns = client.PutAsJsonAsync(ConfigurationManager.AppSettings["Instructors"] + $"/{id}", ins).Result;
            if (resultUpdateIns.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }
            else
            {
                //MessageBox.Show(resultUpdateIns.StatusCode.ToString());
                MessageBox.Show("Error updating instructor");
            }
        }

        private void dataGridViewDepts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this department?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dataGridViewDepts.SelectedRows[0].Cells[0].Value;
                HttpResponseMessage resultDeleteDept= client.DeleteAsync($"https://localhost:7167/api/Departments/{id}").Result;
                //HttpResponseMessage resultDeleteDept = client.DeleteAsync(ConfigurationManager.AppSettings["Departments"]+$"/{id}").Result;
                if (resultDeleteDept.IsSuccessStatusCode)
                {
                    Form1_Load(null, null);
                }
                else
                {
                    //MessageBox.Show(resultDeleteDept.StatusCode.ToString());
                    MessageBox.Show("Error deleting new instructor");
                }
            }
        }

        private void Depts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewDepts.SelectedRows[0].Cells[0].Value;
                HttpResponseMessage resultDept = client.GetAsync(ConfigurationManager.AppSettings["Departments"] + $"/{id}").Result;
                Department dept = resultDept.Content.ReadAsAsync<Department>().Result;
                FillDeptBoxesWithData(dept);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnUpdateDept_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewDepts.SelectedRows[0].Cells[0].Value;
            Department dept = GetDeptDataFromBoxes();
            dept.Id = id;
            HttpResponseMessage resultUpdateDept = client.PutAsJsonAsync(ConfigurationManager.AppSettings["Departments"] + $"/{id}", dept).Result;
            
            if (resultUpdateDept.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }
            else
            {
                //MessageBox.Show(resultUpdateDept.StatusCode.ToString());
                MessageBox.Show("Error updating department");
            }
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            dataGridViewFoundIns.DataSource = null;
            if(int.TryParse(txtSearchId.Text, out int id))
            {
                HttpResponseMessage resultIns = client.GetAsync($"https://localhost:7167/api/Instructors/{id}").Result;
                //HttpResponseMessage resultIns = client.GetAsync(ConfigurationManager.AppSettings["Instructors"]+$"/{id}").Result;
                if (resultIns.IsSuccessStatusCode)
                {
                    List<Instructor> insList = new List<Instructor>();
                    Instructor ins  = resultIns.Content.ReadAsAsync<Instructor>().Result;
                    insList.Add(ins);
                    dataGridViewFoundIns.DataSource = insList;
                }
                else
                {
                    MessageBox.Show("Doesn't exist");
                }
            }
            else
            {
                MessageBox.Show("ID must be a number");
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            dataGridViewFoundIns.DataSource = null;
            try
            {
                string name = txtSearchName.Text; 
                HttpResponseMessage resultIns = client.GetAsync($"https://localhost:7167/api/Instructors/{name}").Result;
                //HttpResponseMessage resultIns = client.GetAsync(ConfigurationManager.AppSettings["Instructors"]+$"/{id}").Result;
                if (resultIns.IsSuccessStatusCode)
                {
                    List<Instructor> insList = new List<Instructor>();
                    Instructor ins = resultIns.Content.ReadAsAsync<Instructor>().Result;
                    insList.Add(ins);
                    dataGridViewFoundIns.DataSource = insList;
                }
                else
                {
                    MessageBox.Show("No Instructors of this name found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

