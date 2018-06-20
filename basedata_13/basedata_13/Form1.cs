using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basedata_13
{


    public partial class Form1 : Form
    {
        private static List<Passenger> passengers = new List<Passenger>();

        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstNameBox.Text == "" ||
                lastNameBox.Text == "" ||
                middleNameBox.Text == "" ||
                Convert.ToInt32(flightNumberBox.Text) <= 0 ||
                Convert.ToInt32(flightNumberBox.Text) <= 0 ||
                Convert.ToInt32(flightNumberBox.Text) <= 0 ||
                Convert.ToInt32(flightNumberBox.Text) <= 0 )
            {
                MessageBox.Show("Check passenger fields", "Error detected in input", 0);
                return;
            }
            passengers.Add(new Passenger(firstNameBox.Text,
                                         lastNameBox.Text,
                                         middleNameBox.Text,
                                         Convert.ToInt32(flightNumberBox.Text),
                                         Convert.ToInt32(baggageReceiptNumBox.Text),
                                         Convert.ToInt32(luggagePiecesNumBox.Text),
                                         Convert.ToInt32(totalBaggageWeightBox.Text)));

            //button2_Click(this, System.EventArgs.Empty);
            updateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (Passenger passenger in passengers)
            {
                dataGridView1.Rows.Add(passenger.FirstName,
                                       passenger.LastName,
                                       passenger.MiddleName,
                                       passenger.FlightNumber,
                                       passenger.BaggageReceiptNumber,
                                       passenger.LuggagePiecesNumber,
                                       passenger.TotalBaggageWeight);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //open file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "Base files (*.bs)|*.bs|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string line;
            int succesPassengersParsed = 0;
            int failedPassengersParsed = 0;
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            passengers.Clear();
            //dataGridView1.Row
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                if (words.Length == 7)
                {
                    passengers.Add(new Passenger(words[0],
                                                 words[1],
                                                 words[2],
                                                 Convert.ToInt32(words[3]),
                                                 Convert.ToInt32(words[4]),
                                                 Convert.ToInt32(words[5]),
                                                 Convert.ToInt32(words[6])));
                    ++succesPassengersParsed;
                }
                else
                {
                    ++failedPassengersParsed;
                }
            }
            toolStripStatusLabel1.Text = "Loaded " + Convert.ToString(succesPassengersParsed) + " and " + Convert.ToString(failedPassengersParsed) + " Failed";
            file.Close();
            updateDataGrid();//button2_Click(this,System.EventArgs.Empty);
            //*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int counter = 0;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Base files (*.bs)|*.bs|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName);
            foreach (Passenger passenger in passengers)
            {
                file.WriteLine(passenger.FirstName + ',' +
                               passenger.LastName + ',' +
                               passenger.MiddleName + ',' +
                               passenger.FlightNumber + ',' + 
                               passenger.BaggageReceiptNumber + ',' +
                               passenger.LuggagePiecesNumber + ',' + 
                               passenger.TotalBaggageWeight);
                ++counter;
            }
            file.Close();
            toolStripStatusLabel1.Text = Convert.ToString(counter) + " passengers was saved to file";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            int sumWeight = 0;
            foreach (Passenger passenger in passengers)
            {
                sumWeight += passenger.TotalBaggageWeight;
            }
            sumWeightBox.Text = Convert.ToString(sumWeight);
        }

        private void findBaggageButton_Click(object sender, EventArgs e)
        {
            foundedFlightBox.Text = "";
            if (findBaggageBox.Text == "")
            {
                //baggageReceiptNumBox.Text = "Input Error!";
                MessageBox.Show("Input Error!", "Error detected in input", 0);
                return;
            }

            int baggageNum = Convert.ToInt32(findBaggageBox.Text);

            foreach (Passenger passenger in passengers)
            {
                if (passenger.BaggageReceiptNumber == baggageNum)
                {
                    foundedFlightBox.Text = Convert.ToString(passenger.FlightNumber);
                }
                else
                {
                    toolStripStatusLabel1.Text = "Not Found!";
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(findLastNameBox.Text == "")
            {
                MessageBox.Show("Input Error!", "Error detected in input", 0);
                toolStripStatusLabel1.Text = "Input Error!";
                return;
            }

            foreach (Passenger passenger in passengers)
            {
                if (passenger.LastName == findLastNameBox.Text)
                {
                    passengers.Remove(passenger);
                    break;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Not Found!";
                }
            }
            updateDataGrid(); //button2_Click(this, System.EventArgs.Empty);
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            int HeavyWeightsCounter = 0;
            dataGridView1.Rows.Clear();
            foreach(Passenger passenger in passengers)
            {
                if (passenger.TotalBaggageWeight > 30)
                {
                    dataGridView1.Rows.Add(passenger.FirstName,
                                           passenger.LastName,
                                           passenger.MiddleName,
                                           passenger.FlightNumber,
                                           passenger.BaggageReceiptNumber,
                                           passenger.LuggagePiecesNumber,
                                           passenger.TotalBaggageWeight);
                    ++HeavyWeightsCounter;
                }
            }
            toolStripStatusLabel1.Text = "Detected " + Convert.ToString(HeavyWeightsCounter) + " heavyweighter(s)";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select row in table to delete!", "Table error!", 0);
                return;
            }
            if (passengers.Count > 0)
            {
                passengers.Remove(passengers[dataGridView1.CurrentRow.Index]);
            }
            else
            {
                MessageBox.Show("Base is empty!", "Deleting error!", 0);
            }

            updateDataGrid();
        }
    }
}
