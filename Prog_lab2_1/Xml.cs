using System.Collections.Generic;
using System.Xml.Serialization;

namespace Prog_lab2_1
{
    [XmlRoot("notepad")]
    public class Notepad
    {
        [XmlElement("note")]
        public List<Note> Items { get; set; }
    }

    public class Note
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("date")]
        public string Date { get; set; }

        [XmlAttribute("time")]
        public string Time { get; set; }

        [XmlElement("subject")]
        public string Subject { get; set; }

        [XmlElement("importance")]
        public string Importance { get; set; }

        [XmlElement("text")]
        public List<NoteText> Text { get; set; }

        public override string ToString()
        {

            return Id + ". " + Subject;
        }

    }

    public class NoteText
    {
        [XmlText()]
        public string Text { get; set; }

        [XmlElement("tel")]
        public string Tel { get; set; }

    }
}
