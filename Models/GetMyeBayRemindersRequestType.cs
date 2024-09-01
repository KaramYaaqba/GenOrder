    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyeBayRemindersRequestType : AbstractRequestType
    {
        
        private ReminderCustomizationType buyingRemindersField;
        
        private ReminderCustomizationType sellingRemindersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ReminderCustomizationType BuyingReminders
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
        public ReminderCustomizationType SellingReminders
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
