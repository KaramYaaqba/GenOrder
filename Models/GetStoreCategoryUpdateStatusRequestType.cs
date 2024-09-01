    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStoreCategoryUpdateStatusRequestType : AbstractRequestType
    {
        
        private long taskIDField;
        
        private bool taskIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long TaskID
        {
            get
            {
                return this.taskIDField;
            }
            set
            {
                this.taskIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaskIDSpecified
        {
            get
            {
                return this.taskIDFieldSpecified;
            }
            set
            {
                this.taskIDFieldSpecified = value;
            }
        }
    }
