using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Serialization;



namespace Student_HM
{
    public partial class Form1 : Form
    {
        FileStream fs;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
               Student student = new Student();
                student.studentrollno = Convert.ToInt32(txtstudentrollno.Text);
                student.studentname = txtstudentname.Text;
                student.percentage  =(txtpercentage.Text);
                binaryFormatter.Serialize(fs, student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
          Student student = new Student();
                student = (Student)binaryFormatter.Deserialize(fs);
               txtstudentrollno.Text = student.studentrollno .ToString();
                txtstudentname.Text = student.studentname ;
                txtpercentage.Text = student.percentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlwrite_Click(object sender, EventArgs e)
        {

            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.Xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student student = new Student();
                student.studentrollno = Convert.ToInt32(txtstudentrollno .Text);
                student.studentname = txtstudentname.Text;
                student.percentage  =  (txtpercentage.Text);
                xmlSerializer.Serialize(fs,student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.Xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student));
                Student student = new Student();
                student = (Student)xmlSerializer.Deserialize(fs);
                txtstudentrollno .Text = student.studentrollno.ToString();
                txtstudentname .Text = student.studentname;
                txtpercentage.Text = student.percentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter formatter = new SoapFormatter();
                Student student = new Student();
                student.studentrollno = Convert.ToInt32(txtstudentrollno .Text);
                student.studentname = txtstudentname .Text;
                student.percentage = (txtstudentname .Text);
                formatter.Serialize(fs, student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter formatter = new SoapFormatter();
                Student student = new Student();
                student = (Student)formatter.Deserialize(fs);
               txtstudentrollno .Text = student.studentrollno.ToString();
                txtstudentname.Text = student.studentname;
                txtpercentage.Text = student.percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.json", FileMode.Create, FileAccess.Write);
              
                Student student = new Student();
                student.studentrollno = Convert.ToInt32(txtstudentrollno.Text);
                student.studentname = txtstudentname.Text;
                student.percentage =(txtpercentage .Text);
               JsonSerializer.Serialize <Student>(fs,student);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslaq\dept.json", FileMode.Open, FileAccess.Read);
       
                Student student = new Student();
              student=JsonSerializer.Deserialize <Student>(fs);
          txtstudentrollno .Text = student.studentrollno.ToString();
                txtstudentname.Text = student.studentname;
                txtpercentage.Text = student.percentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
