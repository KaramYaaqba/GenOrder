    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PurchaseReminderEmailPreferencesType
    {
        
        private bool purchaseReminderEmailPreferencesField;
        
        private bool purchaseReminderEmailPreferencesFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PurchaseReminderEmailPreferences
        {
            get
            {
                return this.purchaseReminderEmailPreferencesField;
            }
            set
            {
                this.purchaseReminderEmailPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PurchaseReminderEmailPreferencesSpecified
        {
            get
            {
                return this.purchaseReminderEmailPreferencesFieldSpecified;
            }
            set
            {
                this.purchaseReminderEmailPreferencesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
