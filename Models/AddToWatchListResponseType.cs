    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddToWatchListResponseType : AbstractResponseType
    {
        
        private int watchListCountField;
        
        private bool watchListCountFieldSpecified;
        
        private int watchListMaximumField;
        
        private bool watchListMaximumFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int WatchListCount
        {
            get
            {
                return this.watchListCountField;
            }
            set
            {
                this.watchListCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WatchListCountSpecified
        {
            get
            {
                return this.watchListCountFieldSpecified;
            }
            set
            {
                this.watchListCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int WatchListMaximum
        {
            get
            {
                return this.watchListMaximumField;
            }
            set
            {
                this.watchListMaximumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WatchListMaximumSpecified
        {
            get
            {
                return this.watchListMaximumFieldSpecified;
            }
            set
            {
                this.watchListMaximumFieldSpecified = value;
            }
        }
    }
