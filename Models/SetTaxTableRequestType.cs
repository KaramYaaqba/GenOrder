    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetTaxTableRequestType : AbstractRequestType
    {
        
        private TaxJurisdictionType[] taxTableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("TaxJurisdiction", IsNullable=false)]
        public TaxJurisdictionType[] TaxTable
        {
            get
            {
                return this.taxTableField;
            }
            set
            {
                this.taxTableField = value;
            }
        }
    }
