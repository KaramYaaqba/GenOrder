    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VeROReportItemsResponseType : AbstractResponseType
    {
        
        private long veROReportPacketIDField;
        
        private bool veROReportPacketIDFieldSpecified;
        
        private VeROReportPacketStatusCodeType veROReportPacketStatusField;
        
        private bool veROReportPacketStatusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long VeROReportPacketID
        {
            get
            {
                return this.veROReportPacketIDField;
            }
            set
            {
                this.veROReportPacketIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VeROReportPacketIDSpecified
        {
            get
            {
                return this.veROReportPacketIDFieldSpecified;
            }
            set
            {
                this.veROReportPacketIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VeROReportPacketStatusCodeType VeROReportPacketStatus
        {
            get
            {
                return this.veROReportPacketStatusField;
            }
            set
            {
                this.veROReportPacketStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VeROReportPacketStatusSpecified
        {
            get
            {
                return this.veROReportPacketStatusFieldSpecified;
            }
            set
            {
                this.veROReportPacketStatusFieldSpecified = value;
            }
        }
    }
