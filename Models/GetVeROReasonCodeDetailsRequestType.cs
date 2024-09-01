    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetVeROReasonCodeDetailsRequestType : AbstractRequestType
    {
        
        private long reasonCodeIDField;
        
        private bool reasonCodeIDFieldSpecified;
        
        private bool returnAllSitesField;
        
        private bool returnAllSitesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ReasonCodeID
        {
            get
            {
                return this.reasonCodeIDField;
            }
            set
            {
                this.reasonCodeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReasonCodeIDSpecified
        {
            get
            {
                return this.reasonCodeIDFieldSpecified;
            }
            set
            {
                this.reasonCodeIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ReturnAllSites
        {
            get
            {
                return this.returnAllSitesField;
            }
            set
            {
                this.returnAllSitesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnAllSitesSpecified
        {
            get
            {
                return this.returnAllSitesFieldSpecified;
            }
            set
            {
                this.returnAllSitesFieldSpecified = value;
            }
        }
    }
