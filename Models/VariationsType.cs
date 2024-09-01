    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VariationsType
    {
        
        private VariationType[] variationField;
        
        private PicturesType[] picturesField;
        
        private NameValueListType[] variationSpecificsSetField;
        
        private ModifyNameType[] modifyNameListField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Variation" )]
        public VariationType[] Variation
        {
            get
            {
                return this.variationField;
            }
            set
            {
                this.variationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pictures" )]
        public PicturesType[] Pictures
        {
            get
            {
                return this.picturesField;
            }
            set
            {
                this.picturesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NameValueList", IsNullable=false)]
        public NameValueListType[] VariationSpecificsSet
        {
            get
            {
                return this.variationSpecificsSetField;
            }
            set
            {
                this.variationSpecificsSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("ModifyName", IsNullable=false)]
        public ModifyNameType[] ModifyNameList
        {
            get
            {
                return this.modifyNameListField;
            }
            set
            {
                this.modifyNameListField = value;
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
