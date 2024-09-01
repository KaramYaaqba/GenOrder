    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerEmailLogResponseType : AbstractResponseType
    {
        
        private SellingManagerEmailLogType[] emailLogField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmailLog" )]
        public SellingManagerEmailLogType[] EmailLog
        {
            get
            {
                return this.emailLogField;
            }
            set
            {
                this.emailLogField = value;
            }
        }
    }
