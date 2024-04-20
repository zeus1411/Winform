using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAndEditForm1.CourseNScore
{
    public partial class CourseStudentList : Form
    {
        Course course = new Course();
        Student student = new Student();
        public CourseStudentList()
        {
            InitializeComponent();
            txtnamecourse.Text = ManageCourseForm.x;
        }
        
   
        private void CourseStudentList_Load(object sender, EventArgs e)
        {
            string searchText = txtnamecourse.Text.Trim();
            // TODO: This line of code loads data into the 'qLSVDBDataSet5.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDBDataSet5.std);
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM std",connection);
                DataTable dt = new DataTable();

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Fname", typeof(string));
                dt.Columns.Add("Lname", typeof(string));
                dt.Columns.Add("Bdate", typeof(DateTime));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Gender", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Address", typeof(string));
                dt.Columns.Add("Selectedcourse", typeof(string));
                dt.Columns.Add("Picture", typeof(System.Byte[]));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["SelectedCourse"].ToString().Contains(txtnamecourse.Text))
                        
                    {
                        DataRow newRow = dt.NewRow();
                        newRow["ID"] = reader["Id"];
                        newRow["Fname"] = reader["fname"];
                        newRow["Lname"] = reader["lname"];
                        newRow["Bdate"] = reader["bdate"];
                        newRow["Email"] = reader["email"];
                        newRow["Gender"] = reader["gender"];
                        newRow["Phone"] = reader["phone"];
                        newRow["Address"] = reader["address"];
                        newRow["Selectedcourse"] = reader["SelectedCourse"];
                        newRow["Picture"] = reader["picture"];
                        dt.Rows.Add(newRow);
                    }
                }
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80;
                picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dt;
                reader.Close();
                connection.Close();

            }

            
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(id,fname,lname,address,SelectedCourse)LIKE '%" + txtnamecourse.Text + "%'");
            
            fillGrid(command);
        }

        private void fillGrid(SqlCommand command)
        {

            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            // Dem sinh vien 
           
        }

        public void DisplayStudents(int courseId)
        {
            
            // Kết nối cơ sở dữ liệu và truy vấn dữ liệu sinh viên cho khóa học cụ thể
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSVDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT std.Id, std.fname, std.lname, std.bdate, std.email, std.gender, std.phone, std.address " +
                               "FROM std " +
                               "INNER JOIN Course ON std.SelectedCourse = Course.label " +
                               "WHERE Course.Id = @CourseId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);

                    // Thực thi truy vấn và gán dữ liệu vào DataGridView
                    DataTable dtStudents = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtStudents);
                    }

                    dataGridView1.DataSource = dtStudents;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtnamecourse_TextChanged(object sender, EventArgs e)
        {
            
            
        }
        public void TxtCourseName()
        {

        }
    }
}
