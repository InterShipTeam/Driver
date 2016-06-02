using System;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    [XmlRoot("DOC")]
    public class CommunicationInfor
    {
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("version")]
        public string Version { get; set; }
        [XmlAttribute("number")]
        public int Number { get; set; }


        [XmlAttribute("send_time")]
        private DateTime sendtime;
        public DateTime Sendtime
        {
            get { return sendtime; }
            set { sendtime = DateTime.Parse(value.ToString()); }
        }
        
        [XmlAttribute("transmission")]
        public string Transmission { get; set; }

    }
}
