    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMemberMessagesResponseType : AbstractResponseType
    {
        
        private MemberMessageExchangeType[] memberMessageField;
        
        private PaginationResultType paginationResultField;
        
        private bool hasMoreItemsField;
        
        private bool hasMoreItemsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("MemberMessageExchange", IsNullable=false)]
        public MemberMessageExchangeType[] MemberMessage
        {
            get
            {
                return this.memberMessageField;
            }
            set
            {
                this.memberMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationResultType PaginationResult
        {
            get
            {
                return this.paginationResultField;
            }
            set
            {
                this.paginationResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HasMoreItems
        {
            get
            {
                return this.hasMoreItemsField;
            }
            set
            {
                this.hasMoreItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMoreItemsSpecified
        {
            get
            {
                return this.hasMoreItemsFieldSpecified;
            }
            set
            {
                this.hasMoreItemsFieldSpecified = value;
            }
        }
    }
