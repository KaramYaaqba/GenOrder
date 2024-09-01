    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PickupOptionsType
    {
        
        private string pickupMethodField;
        
        private int pickupPriorityField;
        
        private bool pickupPriorityFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string PickupMethod
        {
            get
            {
                return this.pickupMethodField;
            }
            set
            {
                this.pickupMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PickupPriority
        {
            get
            {
                return this.pickupPriorityField;
            }
            set
            {
                this.pickupPriorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PickupPrioritySpecified
        {
            get
            {
                return this.pickupPriorityFieldSpecified;
            }
            set
            {
                this.pickupPriorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
