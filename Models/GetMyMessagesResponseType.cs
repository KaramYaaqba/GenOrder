    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyMessagesResponseType : AbstractResponseType
    {
        
        private MyMessagesSummaryType summaryField;
        
        private MyMessagesAlertType[] alertsField;
        
        private MyMessagesMessageType[] messagesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyMessagesSummaryType Summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Alert", IsNullable=false)]
        public MyMessagesAlertType[] Alerts
        {
            get
            {
                return this.alertsField;
            }
            set
            {
                this.alertsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Message", IsNullable=false)]
        public MyMessagesMessageType[] Messages
        {
            get
            {
                return this.messagesField;
            }
            set
            {
                this.messagesField = value;
            }
        }
    }
