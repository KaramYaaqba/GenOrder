    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DeleteMyMessagesRequestType : AbstractRequestType
    {
        
        private string[] alertIDsField;
        
        private string[] messageIDsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("AlertID", IsNullable=false)]
        public string[] AlertIDs
        {
            get
            {
                return this.alertIDsField;
            }
            set
            {
                this.alertIDsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("MessageID", IsNullable=false)]
        public string[] MessageIDs
        {
            get
            {
                return this.messageIDsField;
            }
            set
            {
                this.messageIDsField = value;
            }
        }
    }
