using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        private bool Revert = false;

        public Form1()
        {
            InitializeComponent();
            ReadValuesFromFile();
            ReadHistoryFromFile();
        }

        private double Calculate()
        {
            var neededTime = ReturnTimeFromString(neadedBox.Text);
            var readyTime = ReturnTimeFromString(readyBox.Text);

            var result = readyTime / neededTime * 100;
            progressBar1.Value = Revert ? 100 - (int) Math.Round(result) : (int) Math.Round(result);
            resultLabel.Text = $"{progressBar1.Value}%";
            return result;
        }

        private void GetResult(object sender, EventArgs e)
        {
            var result = Calculate();
            //resultLabel.Text =$"{result}%";
            SaveValuesIntoFile(neadedBox.Text, readyBox.Text, checkBox1.Checked, Subject.Text);
            SaveHistoryIntoFile();
            ReadHistoryFromFile();
        }

        private double ReturnTimeFromString(string text)
        {
            if (text.Contains(':'))
            {
                var (hours, minutes) = GetHoursAndMinutes(':', text);
                var result = hours * 60 + minutes;
                return result;
            }

            if (text.Contains(' '))
            {
                var (hours, minutes) = GetHoursAndMinutes(' ', text);
                var result = hours * 60 + minutes;
                return result;
            }

            return int.Parse(text);
        }


        private (double hours, double minutes) GetHoursAndMinutes(char symbol, string text)
        {
            var elements = text.Split(symbol).ToList();
            var numbers = elements.Select(elem => double.Parse(elem)).ToArray();
            return (numbers[0], numbers[1]);
        }

        private void SaveValuesIntoFile(string value1, string value2, bool isRevert, string subject)
        {
            using (var writer = new StreamWriter("save.txt"))
            {
                var stringToSave = $"{value1},{value2},{subject},{isRevert}";
                writer.WriteLine(stringToSave);
            }
        }

        private void SaveHistoryIntoFile()
        {
            using (var writer = new StreamWriter("history.txt", true))
            {
                var stringToSave =
                    $"{Subject.Text} - {DateTime.Now.ToShortDateString()} - {readyBox.Text}/{neadedBox.Text} - {resultLabel.Text}";
                writer.WriteLine(stringToSave);
            }
        }

        private void ReadValuesFromFile()
        {
            using (var reader = new StreamReader("save.txt"))
            {
                var result = reader.ReadLine();
                var values = result.Split(',');
                neadedBox.Text = values[0];
                readyBox.Text = values[1];
                Subject.Text = values[2];
                checkBox1.Checked = bool.Parse(values[3]);
                Calculate();
            }
        }

        private void ReadHistoryFromFile()
        {
            using (var reader = new StreamReader("history.txt"))
            {
                var result = reader.ReadToEnd();
                history.Text = result;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Revert = checkBox1.Checked;
            progressBar1.Value = 100 - progressBar1.Value;
            resultLabel.Text = $"{progressBar1.Value}%";

        }
    }
}