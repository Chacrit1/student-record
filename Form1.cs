using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> StudentList = new List<Student>();
        List<double> GradeList = new List<double>();
        public Form1()
        {
            InitializeComponent();

            //Set ค่าเริ่มต้นจำนวนนักศึกษา
            labelAllStudent.Text = (StudentList.Count).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // รับค่าจาก Textbox
                string name = this.textBoxName.Text;
                string student_id = this.textBoxStudentId.Text;
                string yeardate = this.textBoxYearDate.Text;
                int height = int.Parse(this.textBoxHeight.Text);
                double grade = double.Parse(this.comboBoxGrade.Text);
                string branch = this.comboBoxBranch.Text;

                //สร้าง Object
                Student student1 = new Student(name, student_id, yeardate, height, grade, branch);

                //เครียค่า Textbox
                this.textBoxName.Text = string.Empty;
                this.textBoxStudentId.Text = string.Empty;
                this.textBoxYearDate.Text = string.Empty;
                this.textBoxHeight.Text = string.Empty;
                this.comboBoxGrade.Text = string.Empty;
                this.comboBoxBranch.Text = string.Empty;

                //เพิ่ม Object ใส่ใน StudentList
                this.StudentList.Add(student1);

                //Loopเพิ่ม Grade ใส่ใน GradeList
                foreach (var val in this.StudentList){this.GradeList.Add(val.Grade);}

                //หาเกรดที่สูงที่สุด
                double MaxGrade = GradeList.Max();

                //หาเกรดที่ต่ำที่สุด
                double MinGrade = GradeList.Min();

                //Set จำนวนนักศึกษาทั้งหมด
                this.labelAllStudent.Text = (StudentList.Count).ToString();

                //Set เกรดสูงสุด
                this.MaxGrade.Text = MaxGrade.ToString();

                //Set เกรดต่ำสุด
                this.MinGrade.Text = MinGrade.ToString();

                //Set ตาราง
                BindingSource source = new BindingSource();
                source.DataSource = this.StudentList;
                this.dataGridView1.DataSource = source;
            }
            catch
            {
                return;
            }
  

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
