using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WIMSystemService.XmlElement;

namespace WIMSystemService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string strDevData = "";
        private string strSubData = "";
        private string strAlarm = "";
        public MainWindow()
        {
            InitializeComponent();

            try
            {

                TextReader reader = new StreamReader("demoxml.xml");

                var xmlSerializer = new XmlSerializer(typeof(CommunicationInfor));
                xmlSerializer.UnknownElement += xmlSerializer_UnknownElement;
                CommunicationInfor myApp = xmlSerializer.Deserialize(reader) as CommunicationInfor;

                var xmlserDev = new XmlSerializer(typeof(RequestInforCommon));
                xmlserDev.UnknownElement += xmlserDev_UnknownElement;
                RequestInforCommon dev = xmlserDev.Deserialize(new StringReader(strDevData)) as RequestInforCommon;

                //SubsystemInfor
                var xmlserSub = new XmlSerializer(typeof(SubsystemInfor));
                xmlserSub.UnknownElement += xmlserSub_UnknownElement;
                SubsystemInfor sub = xmlserSub.Deserialize(new StringReader(strSubData)) as SubsystemInfor;
                //Alarm
                var xmlAlarm = new XmlSerializer(typeof(AlarmDataInfor));
                xmlAlarm.UnknownElement += xmlAlarm_UnknownElement;
                AlarmDataInfor alarm = xmlAlarm.Deserialize(new StringReader(strAlarm)) as AlarmDataInfor;
                //
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        void xmlAlarm_UnknownElement(object sender, XmlElementEventArgs e)
        {
            strAlarm = e.Element.OuterXml;
        }

        void xmlserSub_UnknownElement(object sender, XmlElementEventArgs e)
        {
            strAlarm = e.Element.OuterXml;
        }

        void xmlserDev_UnknownElement(object sender, XmlElementEventArgs e)
        {
            strSubData = e.Element.OuterXml;
        }

        void xmlSerializer_UnknownElement(object sender, XmlElementEventArgs e)
        {
            strDevData = e.Element.OuterXml;
        }

        private void btnDo_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
