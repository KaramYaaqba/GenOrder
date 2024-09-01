    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCharitiesResponseType : AbstractResponseType
    {
        
        private CharityInfoType[] charityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Charity" )]
        public CharityInfoType[] Charity
        {
            get
            {
                return this.charityField;
            }
            set
            {
                this.charityField = value;
            }
        }
    }
