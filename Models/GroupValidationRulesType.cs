    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GroupValidationRulesType
    {
        
        private int minRequiredField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MinRequired
        {
            get
            {
                return this.minRequiredField;
            }
            set
            {
                this.minRequiredField = value;
            }
        }
    }
