    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetVeROReasonCodeDetailsResponseType : AbstractResponseType
    {
        
        private VeROSiteDetailType[] veROReasonCodeDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("VeROSiteDetail", IsNullable=false)]
        public VeROSiteDetailType[] VeROReasonCodeDetails
        {
            get
            {
                return this.veROReasonCodeDetailsField;
            }
            set
            {
                this.veROReasonCodeDetailsField = value;
            }
        }
    }
