    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VeROReportItemsRequestType : AbstractRequestType
    {
        
        private string rightsOwnerIDField;
        
        private VeROReportItemType[] reportItemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RightsOwnerID
        {
            get
            {
                return this.rightsOwnerIDField;
            }
            set
            {
                this.rightsOwnerIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("ReportItem", IsNullable=false)]
        public VeROReportItemType[] ReportItems
        {
            get
            {
                return this.reportItemsField;
            }
            set
            {
                this.reportItemsField = value;
            }
        }
    }
