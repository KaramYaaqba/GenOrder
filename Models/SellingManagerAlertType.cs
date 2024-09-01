    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerAlertType
    {
        
        private SellingManagerAlertTypeCodeType alertTypeField;
        
        private bool alertTypeFieldSpecified;
        
        private SellingManagerSoldListingsPropertyTypeCodeType soldAlertField;
        
        private bool soldAlertFieldSpecified;
        
        private SellingManagerInventoryPropertyTypeCodeType inventoryAlertField;
        
        private bool inventoryAlertFieldSpecified;
        
        private SellingManagerAutomationPropertyTypeCodeType automationAlertField;
        
        private bool automationAlertFieldSpecified;
        
        private SellingManagerPaisaPayPropertyTypeCodeType paisaPayAlertField;
        
        private bool paisaPayAlertFieldSpecified;
        
        private SellingManagerGeneralPropertyTypeCodeType generalAlertField;
        
        private bool generalAlertFieldSpecified;
        
        private int durationInDaysField;
        
        private bool durationInDaysFieldSpecified;
        
        private long countField;
        
        private bool countFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAlertTypeCodeType AlertType
        {
            get
            {
                return this.alertTypeField;
            }
            set
            {
                this.alertTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AlertTypeSpecified
        {
            get
            {
                return this.alertTypeFieldSpecified;
            }
            set
            {
                this.alertTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerSoldListingsPropertyTypeCodeType SoldAlert
        {
            get
            {
                return this.soldAlertField;
            }
            set
            {
                this.soldAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoldAlertSpecified
        {
            get
            {
                return this.soldAlertFieldSpecified;
            }
            set
            {
                this.soldAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerInventoryPropertyTypeCodeType InventoryAlert
        {
            get
            {
                return this.inventoryAlertField;
            }
            set
            {
                this.inventoryAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventoryAlertSpecified
        {
            get
            {
                return this.inventoryAlertFieldSpecified;
            }
            set
            {
                this.inventoryAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutomationPropertyTypeCodeType AutomationAlert
        {
            get
            {
                return this.automationAlertField;
            }
            set
            {
                this.automationAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutomationAlertSpecified
        {
            get
            {
                return this.automationAlertFieldSpecified;
            }
            set
            {
                this.automationAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerPaisaPayPropertyTypeCodeType PaisaPayAlert
        {
            get
            {
                return this.paisaPayAlertField;
            }
            set
            {
                this.paisaPayAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaisaPayAlertSpecified
        {
            get
            {
                return this.paisaPayAlertFieldSpecified;
            }
            set
            {
                this.paisaPayAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerGeneralPropertyTypeCodeType GeneralAlert
        {
            get
            {
                return this.generalAlertField;
            }
            set
            {
                this.generalAlertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GeneralAlertSpecified
        {
            get
            {
                return this.generalAlertFieldSpecified;
            }
            set
            {
                this.generalAlertFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int DurationInDays
        {
            get
            {
                return this.durationInDaysField;
            }
            set
            {
                this.durationInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationInDaysSpecified
        {
            get
            {
                return this.durationInDaysFieldSpecified;
            }
            set
            {
                this.durationInDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountSpecified
        {
            get
            {
                return this.countFieldSpecified;
            }
            set
            {
                this.countFieldSpecified = value;
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
