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

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadValuesFromFile();
            ReadHistoryFromFile();
        }
        private double  Calculate()
        {
            var neededTime = ReturnTimeFromString(neadedBox.Text);
            var readyTime = ReturnTimeFromString(readyBox.Text);

            double result = readyTime / neededTime * 100;
            progressBar1.Value = (int)Math.Round(result);
            resultLabel.Text = $"{Math.Round(result)}%";
            return result;
        }
        private void GetResult(object sender, EventArgs e)
        {
            var result = Calculate();
            //resultLabel.Text =$"{result}%";
            SaveValuesIntoFile(neadedBox.Text, readyBox.Text, Subject.Text);
            SaveHistoryIntoFile();
            ReadHistoryFromFile();
        }
        private double ReturnTimeFromString(string text)
        {
            if (text.Contains(':'))
            {
                (double hours, double minutes) = GetHoursAndMinutes(':', text);
                var result = hours * 60 + minutes;
                return result;
            }
            if (text.Contains(' '))
            {
                (double hours, double minutes) = GetHoursAndMinutes(' ', text);
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
        private void SaveValuesIntoFile(string value1, string value2, string subject)
        {
            using (StreamWriter writer = new StreamWriter("save.txt"))
            {
                var stringToSave = $"{value1},{value2},{subject}";
                writer.WriteLine(stringToSave);
            }
            
        }
        private void SaveHistoryIntoFile()
        {
            using (StreamWriter writer = new StreamWriter("history.txt", true))
            {
                var stringToSave = $"{Subject.Text} - {DateTime.Now.ToShortDateString()} - {readyBox.Text}/{neadedBox.Text} - {resultLabel.Text}";
                writer.WriteLine(stringToSave);
            }

        }
        private void ReadValuesFromFile()
        {
            using (StreamReader reader = new StreamReader("save.txt"))
            {
               var result = reader.ReadLine();
                var values = result.Split(',');
                neadedBox.Text = values[0];
                readyBox.Text = values[1];
                Subject.Text = values[2];
                Calculate();
            }

        }
        private void ReadHistoryFromFile()
        {

            using (StreamReader reader = new StreamReader("history.txt"))
            {
                var result = reader.ReadToEnd();
                history.Text = result;
            }

        }
    }
}
