    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ExtendedProductFinderIDType
    {
        
        private int productFinderIDField;
        
        private bool productFinderIDFieldSpecified;
        
        private bool productFinderBuySideField;
        
        private bool productFinderBuySideFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ProductFinderID
        {
            get
            {
                return this.productFinderIDField;
            }
            set
            {
                this.productFinderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductFinderIDSpecified
        {
            get
            {
                return this.productFinderIDFieldSpecified;
            }
            set
            {
                this.productFinderIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ProductFinderBuySide
        {
            get
            {
                return this.productFinderBuySideField;
            }
            set
            {
                this.productFinderBuySideField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductFinderBuySideSpecified
        {
            get
            {
                return this.productFinderBuySideFieldSpecified;
            }
            set
            {
                this.productFinderBuySideFieldSpecified = value;
            }
        }
    }
