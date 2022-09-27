using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Prog_lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Note();
            propertyGrid.PropertySort = PropertySort.NoSort;
        }

        private void Note()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Notepad));
            var notepadFromXml = new List<Note>();

            using (Stream reader = new FileStream(@"E:\test.xml", FileMode.Open))
            {
                notepadFromXml = ((Notepad)serializer.Deserialize(reader)).Items;
            }

            foreach (var note in notepadFromXml)
            {
                listBox.Items.Add(note);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                propertyGrid.SelectedObject = listBox.SelectedItem;
            }
        }

        private void addNewNode_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
