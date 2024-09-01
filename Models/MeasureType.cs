    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MeasureType
    {
        
        private string unitField;
        
        private MeasurementSystemCodeType measurementSystemField;
        
        private bool measurementSystemFieldSpecified;
        
        private decimal valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MeasurementSystemCodeType measurementSystem
        {
            get
            {
                return this.measurementSystemField;
            }
            set
            {
                this.measurementSystemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool measurementSystemSpecified
        {
            get
            {
                return this.measurementSystemFieldSpecified;
            }
            set
            {
                this.measurementSystemFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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
