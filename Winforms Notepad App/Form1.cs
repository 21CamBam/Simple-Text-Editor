// Cammi Smith
// 11366085

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;

namespace Winforms_Notepad_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadText(TextReader sr) // Generic loading function
        {
            textBox1.Text = "";
            while (sr.Peek() != -1)
            {
                textBox1.AppendText(sr.ReadLine()); // Loads line by line so that even non-.txt files can be opened
                textBox1.AppendText("\n");
            }
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog(); // Open file dialog
            of.ShowDialog();
            string file = of.FileName;

            if (file != "") // If user accidentally clicked "Load from file...", program won't crash
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    LoadText(sr);
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = "Text File | *.txt"; // Defaults to text file for saving
            if (sf.ShowDialog() == DialogResult.OK) // If "Save" was clicked
            {
                using (StreamWriter sw = new StreamWriter(sf.OpenFile()))
                {
                    sw.Write(textBox1.Text); // Write all text
                }
            }
        }

        private void loadFibonacciNumbersfirst50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FibonacciTextReader fr = new FibonacciTextReader(50))
            {
                LoadText(fr);
            }
        }

        private void loadFibonacciNumbersfirst100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FibonacciTextReader fr = new FibonacciTextReader(100))
            {
                LoadText(fr);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }

    public class FibonacciTextReader : TextReader
    {
        private List<BigInteger> fibList; // Master list oof fibonacci numbers
        private int readCount; // Keeps track of how many "lines" read

        public FibonacciTextReader(int num)
        {
            fibList = new List<BigInteger>();
            fibonacci_sequence(num); // Populate Fibonacci sequence at constructor call
            readCount = 0;
        }

        public override string ReadLine()
        {
            int num = readCount + 1;
            string line = Convert.ToString(num) + ": " + Convert.ToString(fibList[readCount]); // Build fibonacci line string
            readCount++; // Increment "lines" read

            if (readCount == fibList.Count) // Return null at the nth number
                return null;

            return line;
        }

        public override int Peek() // Had to override for generic load function
        {
            if (readCount + 1 < fibList.Count) // if the next number exists
                return 1;
            else
                return -1;
        }

        private void fibonacci_sequence(int num)
        {
            for (int i = 0; i <= num; i++) // Up to max
            {
                if (i == 0) // 0 case
                {
                    fibList.Add(0);
                    continue;
                }

                if (i == 1) // 1 case
                {
                    fibList.Add(1);
                    continue;
                }
                fibList.Add(fibList[i - 1] + fibList[i - 2]); // Fibonacci formula
            }
        }
    }
}
