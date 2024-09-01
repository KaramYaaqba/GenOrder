    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PicturesType
    {
        
        private string variationSpecificNameField;
        
        private VariationSpecificPictureSetType[] variationSpecificPictureSetField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string VariationSpecificName
        {
            get
            {
                return this.variationSpecificNameField;
            }
            set
            {
                this.variationSpecificNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VariationSpecificPictureSet" )]
        public VariationSpecificPictureSetType[] VariationSpecificPictureSet
        {
            get
            {
                return this.variationSpecificPictureSetField;
            }
            set
            {
                this.variationSpecificPictureSetField = value;
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
