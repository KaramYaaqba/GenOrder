    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMessagePreferencesResponseType : AbstractResponseType
    {
        
        private ASQPreferencesType aSQPreferencesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ASQPreferencesType ASQPreferences
        {
            get
            {
                return this.aSQPreferencesField;
            }
            set
            {
                this.aSQPreferencesField = value;
            }
        }
    }
