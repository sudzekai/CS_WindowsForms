using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_WindowsForms
{
    public partial class laba28_2 : Form
    {

        private string[] names = { "Екатерина", "Алексей", "Роман", "Юрий" };
        private string[] specs = { "ИСПП", "ИСПВ", "ОИБ", "КСК" };
        private List<Student> students = new List<Student>();
        private Random random = new Random();
        public laba28_2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh1();
        }

        private void Refresh1()
        {
            label1.Text = string.Empty;
            students.Clear();

            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student(names[random.Next(4)], specs[random.Next(4)], random.Next(1, 5)));
            }

            for (int i = 0; i < 5; i++)
            {
                label1.Text += $"{students.ToArray()[i].name} {students.ToArray()[i].spec} {students.ToArray()[i].course}" + "\n";
            }

            


            dataGridView1.DataSource = students;
            
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Специальность";
            dataGridView1.Columns[2].HeaderText = "Курс";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void laba28_2_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
    }

    public class Student
    {
        public string name { get; set; }
        public string spec { get; set; }
        public int course { get; set; }
        
        public Student (string nm, string spc, int crs)
        {
            name = nm;
            spec = spc;
            course = crs;
        }
    }
}
