    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetNotificationPreferencesRequestType : AbstractRequestType
    {
        
        private NotificationRoleCodeType preferenceLevelField;
        
        private bool preferenceLevelFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NotificationRoleCodeType PreferenceLevel
        {
            get
            {
                return this.preferenceLevelField;
            }
            set
            {
                this.preferenceLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferenceLevelSpecified
        {
            get
            {
                return this.preferenceLevelFieldSpecified;
            }
            set
            {
                this.preferenceLevelFieldSpecified = value;
            }
        }
    }
