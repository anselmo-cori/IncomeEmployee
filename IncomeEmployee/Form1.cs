using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace IncomeEmployee
{
    public partial class DataOutput : Form
    {  
        private string ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        private List<Department> DepartmentsList = new List<Department>();
        private List<string[]> EmployeeDataList = new List<string[]>();
        private List<string[]> filteredList = new List<string[]>();

        public DataOutput()
        {
            InitializeComponent();            
        }        

        private void DataOutput_Load(object sender, EventArgs e)
        {            
            //Подключение к БД
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlDataReader dataReader = null;
            string[] EmployeeDataRow = null;

            try
            {
                //Запрос всех департаментов
                string selectCommandText = "select id, name from department"; 
                SqlCommand sqlCommand = new SqlCommand(selectCommandText, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                //Заполним лист и ConboBox
                DepartmentsList.Add(new Department());
                while (dataReader.Read())
                {
                    DepartmentsList.Add(new Department() { Id = Convert.ToInt32(dataReader["id"]), Name = Convert.ToString(dataReader["name"]) });
                }
                DepartmentComboBox.DataSource = DepartmentsList;
                DepartmentComboBox.DisplayMember = "Name";
                DepartmentComboBox.ValueMember = "Id";
                dataReader.Close();                

                //Выполним запрос и заполним таблицу
                selectCommandText = "select emp.id as EmpID, emp.name as EmpName, emp.department_id as EmpDepID, emp.salary as EmpSalary, dep.name as DepName, dep.id as DepID, chief_id as ChiefId from employee emp join department dep on dep.id = emp.department_id";
                sqlCommand = new SqlCommand(selectCommandText, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    EmployeeDataRow = new string[]
                    {
                        Convert.ToString(dataReader["EmpID"]),
                        Convert.ToString(dataReader["EmpName"]),
                        Convert.ToString(dataReader["EmpDepID"]),
                        Convert.ToString(dataReader["EmpSalary"]),
                        Convert.ToString(dataReader["DepName"]),
                        Convert.ToString(dataReader["DepID"]),
                        Convert.ToString(dataReader["ChiefId"])
                    };
                    
                    EmployeeDataList.Add(EmployeeDataRow);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshList(EmployeeDataList);
        }
        //Перезагрузка листа
        private void RefreshList(List<string[]> list)
        {
            int sum = 0;
            listView1.Items.Clear();
            foreach (string[] str in list)
            {
                listView1.Items.Add(new ListViewItem( new string[] { str[1], str[3], str[4], str[6] } ));
                sum += int.Parse(str[3]);
                listView1.Columns[3].Width = 0;
            }
            TotalBox.Text = Convert.ToString(sum);
            filteredList.Clear();
        }

        class Department
        {
            public int Id { get; set; }
            public string Name { get; set; }            
        }        
        //Сброс всех фильтров
        private void ResetFilter_Click(object sender, EventArgs e)
        {
            DepartmentComboBox.Text = null;            
            IsRuk.Checked = false;
            IsRuk.Enabled = false;
            checkBox1.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Checked = false;
            checkBox2.Enabled = true;            
        }

        //1 фильтр. Фильтруем список по выбранному департаменту
        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (DepartmentComboBox.SelectedIndex >= 1)
            {                
                filteredList = EmployeeDataList.Where(emp => emp[5].Contains(Convert.ToString(DepartmentComboBox.SelectedValue))).ToList();
                RefreshList(filteredList);
                IsRuk.Enabled = true;
                IsRuk.Checked = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {

                IsRuk.Enabled = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                RefreshList(EmployeeDataList);
            }            
        }        

        //1 фильтр. Добавляем руководителя по выбранному департамету
        private void IsRuk_CheckedChanged(object sender, EventArgs e)
        {            
            if (IsRuk.Checked)
            {
                filteredList = EmployeeDataList.Where(emp => emp[5].Contains(Convert.ToString(DepartmentComboBox.SelectedValue))).ToList();
                filteredList.Add(EmployeeDataList.Where(emp => emp[0].Contains(Convert.ToString(listView1.Items[0].SubItems[3].Text))).FirstOrDefault());                
                RefreshList(filteredList);
            }
            else
            {
                filteredList = EmployeeDataList.Where(emp => emp[5].Contains(Convert.ToString(DepartmentComboBox.SelectedValue))).ToList();
                RefreshList(filteredList);
            }
        }        
        
        //2 фильтр. Руководители департаментов по убыванию
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (checkBox2.Checked)
            {
                DepartmentComboBox.Enabled = false;
                checkBox1.Enabled = false;
                var depid = EmployeeDataList.GroupBy(emp => emp[6]).ToList();               
                foreach (var d in depid)
                {
                    if (String.IsNullOrEmpty(d.Key) != true)
                    {
                        filteredList.Add(EmployeeDataList.Where(emp => emp[0].Contains(Convert.ToString(d.Key))).FirstOrDefault());
                    }
                }                
                RefreshList(filteredList.OrderByDescending(f => int.Parse(f[3])).ToList());
            }
            else
            {
                DepartmentComboBox.Enabled = true;
                checkBox1.Enabled = true;
                RefreshList(EmployeeDataList);
            } 
        }
        
        //3 фильтр. Сотрудник с наибольшей зарплатой
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (checkBox1.Checked)
            {
                DepartmentComboBox.Enabled = false;
                checkBox2.Enabled = false;
                var maxRow = EmployeeDataList.Max(x => int.Parse(x[3]));
                filteredList = EmployeeDataList.Where(emp => emp[3].Contains(Convert.ToString(maxRow))).ToList(); // Max();// Max(x => x[3]));

                RefreshList(filteredList);
            }
            else
            {
                DepartmentComboBox.Enabled = true;
                checkBox2.Enabled = true;
                RefreshList(EmployeeDataList);
            }
        }        
    }
}
