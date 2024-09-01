    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RevokeTokenRequestType : AbstractRequestType
    {
        
        private bool unsubscribeNotificationField;
        
        private bool unsubscribeNotificationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UnsubscribeNotification
        {
            get
            {
                return this.unsubscribeNotificationField;
            }
            set
            {
                this.unsubscribeNotificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnsubscribeNotificationSpecified
        {
            get
            {
                return this.unsubscribeNotificationFieldSpecified;
            }
            set
            {
                this.unsubscribeNotificationFieldSpecified = value;
            }
        }
    }
