using AttendanceRecords.ConnectionFactory;
using AttendanceRecords.Model.DTO;
using AttendanceRecords.Properties;
using AttendanceRecords.Reports;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AttendanceRecords
{
    public partial class Form1 : Form
    {
        private IConnectionFactory _connectionFactory;

        public Form1()
        {
            InitializeComponent();
            _connectionFactory = new SqlConnectionFactory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            var connection = _connectionFactory.Create(Resources.ConnectionString);

            var report = new SkippingClassReport(connection);

            var flags = new SkippedFlags(radioButton1.Checked, radioButton2.Checked,
                                        radioButton2.Checked, dateTimePicker1.Value,
                                        dateTimePicker2.Value);

            var data = report.GetReport(flags);

            if (data is IEnumerable<SkippedForClass> classes)
                dataGridView1.DataSource = classes;

            if (data is IEnumerable<SkippedForScoolSubject> subjects)
                dataGridView1.DataSource = subjects;

            if (data is IEnumerable<SkippedForTeacher> teachers)
                dataGridView1.DataSource = teachers;

            toolStripStatusLabel1.Text += $" {report.GetPercentSkipped()}";
        }
    }
}
