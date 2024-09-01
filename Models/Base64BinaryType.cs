    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class Base64BinaryType
    {
        
        private string contentTypeField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value
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
