    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RecommendationValidationRulesType
    {
        
        private ValueTypeCodeType valueTypeField;
        
        private bool valueTypeFieldSpecified;
        
        private int minValuesField;
        
        private bool minValuesFieldSpecified;
        
        private int maxValuesField;
        
        private bool maxValuesFieldSpecified;
        
        private SelectionModeCodeType selectionModeField;
        
        private bool selectionModeFieldSpecified;
        
        private AspectUsageCodeType aspectUsageField;
        
        private bool aspectUsageFieldSpecified;
        
        private int maxValueLengthField;
        
        private bool maxValueLengthFieldSpecified;
        
        private ProductRequiredCodeType productRequiredField;
        
        private bool productRequiredFieldSpecified;
        
        private UsageConstraintCodeType usageConstraintField;
        
        private bool usageConstraintFieldSpecified;
        
        private int confidenceField;
        
        private bool confidenceFieldSpecified;
        
        private NameValueRelationshipType[] relationshipField;
        
        private VariationPictureRuleCodeType variationPictureField;
        
        private bool variationPictureFieldSpecified;
        
        private VariationSpecificsRuleCodeType variationSpecificsField;
        
        private bool variationSpecificsFieldSpecified;
        
        private ValueFormatCodeType valueFormatField;
        
        private bool valueFormatFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ValueTypeCodeType ValueType
        {
            get
            {
                return this.valueTypeField;
            }
            set
            {
                this.valueTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueTypeSpecified
        {
            get
            {
                return this.valueTypeFieldSpecified;
            }
            set
            {
                this.valueTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MinValues
        {
            get
            {
                return this.minValuesField;
            }
            set
            {
                this.minValuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinValuesSpecified
        {
            get
            {
                return this.minValuesFieldSpecified;
            }
            set
            {
                this.minValuesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxValues
        {
            get
            {
                return this.maxValuesField;
            }
            set
            {
                this.maxValuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxValuesSpecified
        {
            get
            {
                return this.maxValuesFieldSpecified;
            }
            set
            {
                this.maxValuesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SelectionModeCodeType SelectionMode
        {
            get
            {
                return this.selectionModeField;
            }
            set
            {
                this.selectionModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SelectionModeSpecified
        {
            get
            {
                return this.selectionModeFieldSpecified;
            }
            set
            {
                this.selectionModeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AspectUsageCodeType AspectUsage
        {
            get
            {
                return this.aspectUsageField;
            }
            set
            {
                this.aspectUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AspectUsageSpecified
        {
            get
            {
                return this.aspectUsageFieldSpecified;
            }
            set
            {
                this.aspectUsageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxValueLength
        {
            get
            {
                return this.maxValueLengthField;
            }
            set
            {
                this.maxValueLengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxValueLengthSpecified
        {
            get
            {
                return this.maxValueLengthFieldSpecified;
            }
            set
            {
                this.maxValueLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ProductRequiredCodeType ProductRequired
        {
            get
            {
                return this.productRequiredField;
            }
            set
            {
                this.productRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProductRequiredSpecified
        {
            get
            {
                return this.productRequiredFieldSpecified;
            }
            set
            {
                this.productRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UsageConstraintCodeType UsageConstraint
        {
            get
            {
                return this.usageConstraintField;
            }
            set
            {
                this.usageConstraintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UsageConstraintSpecified
        {
            get
            {
                return this.usageConstraintFieldSpecified;
            }
            set
            {
                this.usageConstraintFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConfidenceSpecified
        {
            get
            {
                return this.confidenceFieldSpecified;
            }
            set
            {
                this.confidenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Relationship" )]
        public NameValueRelationshipType[] Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VariationPictureRuleCodeType VariationPicture
        {
            get
            {
                return this.variationPictureField;
            }
            set
            {
                this.variationPictureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariationPictureSpecified
        {
            get
            {
                return this.variationPictureFieldSpecified;
            }
            set
            {
                this.variationPictureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VariationSpecificsRuleCodeType VariationSpecifics
        {
            get
            {
                return this.variationSpecificsField;
            }
            set
            {
                this.variationSpecificsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VariationSpecificsSpecified
        {
            get
            {
                return this.variationSpecificsFieldSpecified;
            }
            set
            {
                this.variationSpecificsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ValueFormatCodeType ValueFormat
        {
            get
            {
                return this.valueFormatField;
            }
            set
            {
                this.valueFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueFormatSpecified
        {
            get
            {
                return this.valueFormatFieldSpecified;
            }
            set
            {
                this.valueFormatFieldSpecified = value;
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
