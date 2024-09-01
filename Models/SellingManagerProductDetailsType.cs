    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerProductDetailsType
    {
        
        private string productNameField;
        
        private long productIDField;
        
        private bool productIDFieldSpecified;
        
        private string customLabelField;
        
        private int quantityAvailableField;
        
        private bool quantityAvailableFieldSpecified;
        
        private AmountType unitCostField;
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
        private bool restockAlertField;
        
        private bool restockAlertFieldSpecified;
        
        private int restockThresholdField;
        
        private bool restockThresholdFieldSpecified;
        
        private SellingManagerVendorDetailsType vendorInfoField;
        
        private string noteField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ProductName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductIDSpecified
        {
            get
            {
                return this.productIDFieldSpecified;
            }
            set
            {
                this.productIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CustomLabel
        {
            get
            {
                return this.customLabelField;
            }
            set
            {
                this.customLabelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int QuantityAvailable
        {
            get
            {
                return this.quantityAvailableField;
            }
            set
            {
                this.quantityAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityAvailableSpecified
        {
            get
            {
                return this.quantityAvailableFieldSpecified;
            }
            set
            {
                this.quantityAvailableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType UnitCost
        {
            get
            {
                return this.unitCostField;
            }
            set
            {
                this.unitCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long FolderID
        {
            get
            {
                return this.folderIDField;
            }
            set
            {
                this.folderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FolderIDSpecified
        {
            get
            {
                return this.folderIDFieldSpecified;
            }
            set
            {
                this.folderIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool RestockAlert
        {
            get
            {
                return this.restockAlertField;
            }
            set
            {
                this.restockAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestockAlertSpecified
        {
            get
            {
                return this.restockAlertFieldSpecified;
            }
            set
            {
                this.restockAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int RestockThreshold
        {
            get
            {
                return this.restockThresholdField;
            }
            set
            {
                this.restockThresholdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RestockThresholdSpecified
        {
            get
            {
                return this.restockThresholdFieldSpecified;
            }
            set
            {
                this.restockThresholdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerVendorDetailsType VendorInfo
        {
            get
            {
                return this.vendorInfoField;
            }
            set
            {
                this.vendorInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
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
