    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NotificationMessageType : AbstractResponseType
    {
        
        private string messageBodyField;
        
        private string eIASField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MessageBody
        {
            get
            {
                return this.messageBodyField;
            }
            set
            {
                this.messageBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EIAS
        {
            get
            {
                return this.eIASField;
            }
            set
            {
                this.eIASField = value;
            }
        }
    }
