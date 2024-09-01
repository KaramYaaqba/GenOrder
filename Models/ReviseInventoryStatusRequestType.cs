    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ReviseInventoryStatusRequestType : AbstractRequestType
    {
        
        private InventoryStatusType[] inventoryStatusField;
       
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InventoryStatus" )]
        public InventoryStatusType[] InventoryStatus
        {
            get
            {
                return this.inventoryStatusField;
            }
            set
            {
                this.inventoryStatusField = value;
            }
        }
        
    }
