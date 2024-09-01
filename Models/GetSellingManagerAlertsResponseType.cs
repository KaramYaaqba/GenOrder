    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerAlertsResponseType : AbstractResponseType
    {
        
        private SellingManagerAlertType[] alertField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alert" )]
        public SellingManagerAlertType[] Alert
        {
            get
            {
                return this.alertField;
            }
            set
            {
                this.alertField = value;
            }
        }
    }
