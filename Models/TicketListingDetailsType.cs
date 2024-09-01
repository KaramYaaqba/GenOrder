    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TicketListingDetailsType
    {
        
        private string eventTitleField;
        
        private string venueField;
        
        private string printedDateField;
        
        private string printedTimeField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EventTitle
        {
            get
            {
                return this.eventTitleField;
            }
            set
            {
                this.eventTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Venue
        {
            get
            {
                return this.venueField;
            }
            set
            {
                this.venueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PrintedDate
        {
            get
            {
                return this.printedDateField;
            }
            set
            {
                this.printedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PrintedTime
        {
            get
            {
                return this.printedTimeField;
            }
            set
            {
                this.printedTimeField = value;
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
