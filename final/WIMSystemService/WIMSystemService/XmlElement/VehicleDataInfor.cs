using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WIMSystemService.XmlElement
{
    public class VehicleDataInfor
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlAttribute("time")]
        public DateTime DectectionTime { get; set; }
        [XmlAttribute("lp_front")]
        public string PlateNumberFront { get; set; }
        [XmlAttribute("lp_front_ilpc")]
        public string PlateNumberCountryCodeFront { get; set; }
        [XmlAttribute("lp_back")]
        public string PlateNumberBack { get; set; }
        [XmlAttribute("lp_back_ilpc")]
        public string PlateNumberCountryCodeBack { get; set; }
        [XmlAttribute("direction")]
        public bool Direction { get; set; }
        [XmlAttribute("head")]
        public int Head { get; set; }
        [XmlAttribute("gap")]
        public int Gap { get; set; }
        [XmlAttribute("speed")]
        public int VehicleSpeed { get; set; }
        [XmlAttribute("length")]
        public int VehicleLength { get; set; }
        [XmlAttribute("class")]
        public int  VehicleClass { get; set; }
        [XmlAttribute("overloaded_total")]
        public int IsOverload { get; set; }
        [XmlAttribute("weight_total ")]
        public int GrossWeigth { get; set; }
        [XmlAttribute("credibility")]
        public string Credibility { get; set; }
        [XmlElement("LP_IMAGE_FRONT")]
        public string PlateNumberImageFront { get; set; }
        [XmlElement("LP_IMAGE_BACK")]
        public String PlateNumberImageBack { get; set; }
        [XmlElement("DETAIL_IMAGE_FRONT")]
        public string DetailImageFront { get; set; }
        [XmlElement("DETAIL_IMAGE_BACK")]
        public string DetailImageBack { get; set; }
        [XmlElement("OVERVIEW_IMAGE")]
        public string OverviewImage { get; set; }
         [XmlElement("AXLES")]
         public List<AxleDataInfor> AxlesData { get; set; }

       
    }
}
