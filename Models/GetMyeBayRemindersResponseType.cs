    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyeBayRemindersResponseType : AbstractResponseType
    {
        
        private RemindersType buyingRemindersField;
        
        private RemindersType sellingRemindersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RemindersType BuyingReminders
        {
            get
            {
                return this.buyingRemindersField;
            }
            set
            {
                this.buyingRemindersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RemindersType SellingReminders
        {
            get
            {
                return this.sellingRemindersField;
            }
            set
            {
                this.sellingRemindersField = value;
            }
        }
    }
