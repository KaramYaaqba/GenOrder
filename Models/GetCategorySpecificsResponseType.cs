    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategorySpecificsResponseType : AbstractResponseType
    {
        
        private RecommendationsType[] recommendationsField;
        
        private string taskReferenceIDField;
        
        private string fileReferenceIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Recommendations" )]
        public RecommendationsType[] Recommendations
        {
            get
            {
                return this.recommendationsField;
            }
            set
            {
                this.recommendationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TaskReferenceID
        {
            get
            {
                return this.taskReferenceIDField;
            }
            set
            {
                this.taskReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string FileReferenceID
        {
            get
            {
                return this.fileReferenceIDField;
            }
            set
            {
                this.fileReferenceIDField = value;
            }
        }
    }
