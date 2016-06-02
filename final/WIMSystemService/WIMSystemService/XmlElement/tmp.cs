
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class DOC
{

    private DOCDEV_DATA dEV_DATAField;

    private string typeField;

    private decimal versionField;

    private ushort numberField;

    private string send_timeField;

    private string transmissionField;

    /// <remarks/>
    public DOCDEV_DATA DEV_DATA
    {
        get
        {
            return this.dEV_DATAField;
        }
        set
        {
            this.dEV_DATAField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string send_time
    {
        get
        {
            return this.send_timeField;
        }
        set
        {
            this.send_timeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string transmission
    {
        get
        {
            return this.transmissionField;
        }
        set
        {
            this.transmissionField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATA
{

    private DOCDEV_DATASUB_DATA sUB_DATAField;

    private string senderField;

    private string receiverField;

    private string device_typeField;

    private string data_typeField;

    private string device_subsysField;

    private string device_subsys_typeField;

    private string start_timeField;

    private string end_timeField;

    /// <remarks/>
    public DOCDEV_DATASUB_DATA SUB_DATA
    {
        get
        {
            return this.sUB_DATAField;
        }
        set
        {
            this.sUB_DATAField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sender
    {
        get
        {
            return this.senderField;
        }
        set
        {
            this.senderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string receiver
    {
        get
        {
            return this.receiverField;
        }
        set
        {
            this.receiverField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string device_type
    {
        get
        {
            return this.device_typeField;
        }
        set
        {
            this.device_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string data_type
    {
        get
        {
            return this.data_typeField;
        }
        set
        {
            this.data_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string device_subsys
    {
        get
        {
            return this.device_subsysField;
        }
        set
        {
            this.device_subsysField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string device_subsys_type
    {
        get
        {
            return this.device_subsys_typeField;
        }
        set
        {
            this.device_subsys_typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string start_time
    {
        get
        {
            return this.start_timeField;
        }
        set
        {
            this.start_timeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string end_time
    {
        get
        {
            return this.end_timeField;
        }
        set
        {
            this.end_timeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATA
{

    private DOCDEV_DATASUB_DATAALARM aLARMField;

    private string subsysField;

    private string subsys_typeField;

    /// <remarks/>
    public DOCDEV_DATASUB_DATAALARM ALARM
    {
        get
        {
            return this.aLARMField;
        }
        set
        {
            this.aLARMField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string subsys
    {
        get
        {
            return this.subsysField;
        }
        set
        {
            this.subsysField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string subsys_type
    {
        get
        {
            return this.subsys_typeField;
        }
        set
        {
            this.subsys_typeField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATAALARM
{

    private DOCDEV_DATASUB_DATAALARMCLASS cLASSField;

    private string lP_FRONTField;

    private string lP_FRONT_ILPCField;

    private string lP_BACKField;

    private string lP_BACK_ILPCField;

    private string lP_IMAGE_FRONTField;

    private string lP_IMAGE_BACKField;

    private string dETAIL_IMAGE_FRONTField;

    private string dETAIL_IMAGE_BACKField;

    private string oVERVIEW_IMAGEField;

    private string tIMEField;

    private DOCDEV_DATASUB_DATAALARMOVERWEIGHT[] oVERWEIGHTSField;

    private DOCDEV_DATASUB_DATAALARMWIM_INFO wIM_INFOField;

    private byte valueField;

    private string descriptionField;

    /// <remarks/>
    public DOCDEV_DATASUB_DATAALARMCLASS CLASS
    {
        get
        {
            return this.cLASSField;
        }
        set
        {
            this.cLASSField = value;
        }
    }

    /// <remarks/>
    public string LP_FRONT
    {
        get
        {
            return this.lP_FRONTField;
        }
        set
        {
            this.lP_FRONTField = value;
        }
    }

    /// <remarks/>
    public string LP_FRONT_ILPC
    {
        get
        {
            return this.lP_FRONT_ILPCField;
        }
        set
        {
            this.lP_FRONT_ILPCField = value;
        }
    }

    /// <remarks/>
    public string LP_BACK
    {
        get
        {
            return this.lP_BACKField;
        }
        set
        {
            this.lP_BACKField = value;
        }
    }

    /// <remarks/>
    public string LP_BACK_ILPC
    {
        get
        {
            return this.lP_BACK_ILPCField;
        }
        set
        {
            this.lP_BACK_ILPCField = value;
        }
    }

    /// <remarks/>
    public string LP_IMAGE_FRONT
    {
        get
        {
            return this.lP_IMAGE_FRONTField;
        }
        set
        {
            this.lP_IMAGE_FRONTField = value;
        }
    }

    /// <remarks/>
    public string LP_IMAGE_BACK
    {
        get
        {
            return this.lP_IMAGE_BACKField;
        }
        set
        {
            this.lP_IMAGE_BACKField = value;
        }
    }

    /// <remarks/>
    public string DETAIL_IMAGE_FRONT
    {
        get
        {
            return this.dETAIL_IMAGE_FRONTField;
        }
        set
        {
            this.dETAIL_IMAGE_FRONTField = value;
        }
    }

    /// <remarks/>
    public string DETAIL_IMAGE_BACK
    {
        get
        {
            return this.dETAIL_IMAGE_BACKField;
        }
        set
        {
            this.dETAIL_IMAGE_BACKField = value;
        }
    }

    /// <remarks/>
    public string OVERVIEW_IMAGE
    {
        get
        {
            return this.oVERVIEW_IMAGEField;
        }
        set
        {
            this.oVERVIEW_IMAGEField = value;
        }
    }

    /// <remarks/>
    public string TIME
    {
        get
        {
            return this.tIMEField;
        }
        set
        {
            this.tIMEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OVERWEIGHT", IsNullable = false)]
    public DOCDEV_DATASUB_DATAALARMOVERWEIGHT[] OVERWEIGHTS
    {
        get
        {
            return this.oVERWEIGHTSField;
        }
        set
        {
            this.oVERWEIGHTSField = value;
        }
    }

    /// <remarks/>
    public DOCDEV_DATASUB_DATAALARMWIM_INFO WIM_INFO
    {
        get
        {
            return this.wIM_INFOField;
        }
        set
        {
            this.wIM_INFOField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATAALARMCLASS
{

    private string typeField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATAALARMOVERWEIGHT
{

    private string typeField;

    private ushort weight_limitField;

    private ushort weight_measuredField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort weight_limit
    {
        get
        {
            return this.weight_limitField;
        }
        set
        {
            this.weight_limitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort weight_measured
    {
        get
        {
            return this.weight_measuredField;
        }
        set
        {
            this.weight_measuredField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATAALARMWIM_INFO
{

    private DOCDEV_DATASUB_DATAALARMWIM_INFOAXLES aXLESField;

    private string idField;

    private byte directionField;

    private ushort headField;

    private ushort gapField;

    private byte speedField;

    private ushort heightField;

    private ushort widthField;

    private ushort lengthField;

    private byte classField;

    private byte overloaded_totalField;

    private ushort weight_totalField;

    private string credibilityField;

    /// <remarks/>
    public DOCDEV_DATASUB_DATAALARMWIM_INFOAXLES AXLES
    {
        get
        {
            return this.aXLESField;
        }
        set
        {
            this.aXLESField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte direction
    {
        get
        {
            return this.directionField;
        }
        set
        {
            this.directionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort head
    {
        get
        {
            return this.headField;
        }
        set
        {
            this.headField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort gap
    {
        get
        {
            return this.gapField;
        }
        set
        {
            this.gapField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte speed
    {
        get
        {
            return this.speedField;
        }
        set
        {
            this.speedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte @class
    {
        get
        {
            return this.classField;
        }
        set
        {
            this.classField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte overloaded_total
    {
        get
        {
            return this.overloaded_totalField;
        }
        set
        {
            this.overloaded_totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort weight_total
    {
        get
        {
            return this.weight_totalField;
        }
        set
        {
            this.weight_totalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string credibility
    {
        get
        {
            return this.credibilityField;
        }
        set
        {
            this.credibilityField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATAALARMWIM_INFOAXLES
{

    private DOCDEV_DATASUB_DATAALARMWIM_INFOAXLESAXLE[] aXLEField;

    private byte countField;

    private ushort lengthField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AXLE")]
    public DOCDEV_DATASUB_DATAALARMWIM_INFOAXLESAXLE[] AXLE
    {
        get
        {
            return this.aXLEField;
        }
        set
        {
            this.aXLEField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DOCDEV_DATASUB_DATAALARMWIM_INFOAXLESAXLE
{

    private byte orderField;

    private ushort distField;

    private ushort leftside_loadField;

    private ushort rightside_loadField;

    private ushort weightField;

    private byte overloadedField;

    private byte tires_countField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte order
    {
        get
        {
            return this.orderField;
        }
        set
        {
            this.orderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort dist
    {
        get
        {
            return this.distField;
        }
        set
        {
            this.distField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort leftside_load
    {
        get
        {
            return this.leftside_loadField;
        }
        set
        {
            this.leftside_loadField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort rightside_load
    {
        get
        {
            return this.rightside_loadField;
        }
        set
        {
            this.rightside_loadField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte overloaded
    {
        get
        {
            return this.overloadedField;
        }
        set
        {
            this.overloadedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte tires_count
    {
        get
        {
            return this.tires_countField;
        }
        set
        {
            this.tires_countField = value;
        }
    }
}

