using Newtonsoft.Json;
using System.Xml.Linq;
using System;

namespace Anket.winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string Surname = textBox1.Text;
            string Fathername = textBox3.Text;
            string Country = textBox4.Text;
            string City = textBox5.Text;
            string Phone = textBox6.Text;
            DateTime birthdaydateTime = dateTimePicker1.Value;
            string Gender = "";
            if (radioButton1.Checked)
            {
                Gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                Gender = "Female";
            }
            Human human = new Human(name, Surname, Fathername, Country, City, Phone, birthdaydateTime, Gender);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files (*.json)|*.json";
                saveFileDialog.Title = "Save JSON File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    var json = JsonConvert.SerializeObject(human);
                    File.WriteAllText(saveFileDialog.FileName, json);
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json";
                openFileDialog.Title = "Save JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var json = File.ReadAllText(openFileDialog.FileName);
                    var data = JsonConvert.DeserializeObject(json);

                    var Humann = JsonConvert.DeserializeObject<Human>(json);

                    string surname = Humann.Surname;
                    string name = Humann.Name;
                    string Country = Humann.Country;
                    string Phone = Humann.Phone;
                    string fatherName = Humann.FatherName;
                    string Gender = Humann.Gender;
                    DateTime birthdayDate = Humann.BirthdayDate;
                    string city = Humann.City;

                    textBox1.Text =surname;
                    textBox2.Text =name;
                    textBox3.Text =fatherName;
                    textBox4.Text =Country;
                    textBox5.Text =city;
                    textBox6.Text =Phone;
                    dateTimePicker1.Value = birthdayDate;
                    if (Gender=="Male")
                    {
                        radioButton1.Checked = true; 
                        radioButton2.Checked = false; 

                    }
                    if (Gender=="Female")
                    {
                        radioButton2.Checked =true;
                        radioButton1.Checked =false;
                    }



                }
            }
        }
    }
}