    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetDescriptionTemplatesRequestType : AbstractRequestType
    {
        
        private string categoryIDField;
        
        private System.DateTime lastModifiedTimeField;
        
        private bool lastModifiedTimeFieldSpecified;
        
        private bool motorVehiclesField;
        
        private bool motorVehiclesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastModifiedTime
        {
            get
            {
                return this.lastModifiedTimeField;
            }
            set
            {
                this.lastModifiedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedTimeSpecified
        {
            get
            {
                return this.lastModifiedTimeFieldSpecified;
            }
            set
            {
                this.lastModifiedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool MotorVehicles
        {
            get
            {
                return this.motorVehiclesField;
            }
            set
            {
                this.motorVehiclesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MotorVehiclesSpecified
        {
            get
            {
                return this.motorVehiclesFieldSpecified;
            }
            set
            {
                this.motorVehiclesFieldSpecified = value;
            }
        }
    }
