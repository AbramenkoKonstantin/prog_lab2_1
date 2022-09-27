using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prog_lab2_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView.ColumnHeadersVisible = false;
            int row = 6;
            for (int rowAddCounter = 0; rowAddCounter < row; ++rowAddCounter)
            {
                dataGridView.Rows.Add();
            }
            
            dataGridView.Rows[0].Cells[0].Value = "Date";
            dataGridView.Rows[1].Cells[0].Value = "Time";
            dataGridView.Rows[2].Cells[0].Value = "Subject";
            dataGridView.Rows[3].Cells[0].Value = "Importance";
            dataGridView.Rows[4].Cells[0].Value = "Text";
            dataGridView.Rows[5].Cells[0].Value = "Tel";

        }

        abstract class AddNotepad
        {
            public List<Note> Items { get; set; }
        }

        abstract class AddNote
        {
            public string Date { get; set; }

            public string Time { get; set; }

            public string Subject { get; set; }

            public string Importance { get; set; }

            public List<AddNodeText> Text { get; set; }

            public override string ToString()
            {
                return Subject;
            }

        }

        public class AddNodeText
        {
            public string Text { get; set; }

            public string Tel { get; set; }
        }

        public void saveNote_Click(object sender, EventArgs e)
        {
            int column = dataGridView.ColumnCount;
            int row = dataGridView.RowCount;
            string[,] matrix = new string[row, column];

            for (int rowMatrixCounter = 0; rowMatrixCounter < row; ++rowMatrixCounter)
            {
                for (int columnMatrixCounter = 0; columnMatrixCounter < column; ++columnMatrixCounter)
                {
                    matrix[rowMatrixCounter, columnMatrixCounter] = Convert.ToString(dataGridView.Rows[rowMatrixCounter].Cells[columnMatrixCounter].Value);
                }
            }
            this.Close();
        }
    }
}
