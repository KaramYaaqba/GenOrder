    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ApiAccessRuleType
    {
        
        private string callNameField;
        
        private bool countsTowardAggregateField;
        
        private bool countsTowardAggregateFieldSpecified;
        
        private long dailyHardLimitField;
        
        private bool dailyHardLimitFieldSpecified;
        
        private long dailySoftLimitField;
        
        private bool dailySoftLimitFieldSpecified;
        
        private long dailyUsageField;
        
        private bool dailyUsageFieldSpecified;
        
        private long hourlyHardLimitField;
        
        private bool hourlyHardLimitFieldSpecified;
        
        private long hourlySoftLimitField;
        
        private bool hourlySoftLimitFieldSpecified;
        
        private long hourlyUsageField;
        
        private bool hourlyUsageFieldSpecified;
        
        private int periodField;
        
        private bool periodFieldSpecified;
        
        private long periodicHardLimitField;
        
        private bool periodicHardLimitFieldSpecified;
        
        private long periodicSoftLimitField;
        
        private bool periodicSoftLimitFieldSpecified;
        
        private long periodicUsageField;
        
        private bool periodicUsageFieldSpecified;
        
        private System.DateTime periodicStartDateField;
        
        private bool periodicStartDateFieldSpecified;
        
        private System.DateTime modTimeField;
        
        private bool modTimeFieldSpecified;
        
        private AccessRuleCurrentStatusCodeType ruleCurrentStatusField;
        
        private bool ruleCurrentStatusFieldSpecified;
        
        private AccessRuleStatusCodeType ruleStatusField;
        
        private bool ruleStatusFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CallName
        {
            get
            {
                return this.callNameField;
            }
            set
            {
                this.callNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CountsTowardAggregate
        {
            get
            {
                return this.countsTowardAggregateField;
            }
            set
            {
                this.countsTowardAggregateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CountsTowardAggregateSpecified
        {
            get
            {
                return this.countsTowardAggregateFieldSpecified;
            }
            set
            {
                this.countsTowardAggregateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long DailyHardLimit
        {
            get
            {
                return this.dailyHardLimitField;
            }
            set
            {
                this.dailyHardLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DailyHardLimitSpecified
        {
            get
            {
                return this.dailyHardLimitFieldSpecified;
            }
            set
            {
                this.dailyHardLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long DailySoftLimit
        {
            get
            {
                return this.dailySoftLimitField;
            }
            set
            {
                this.dailySoftLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DailySoftLimitSpecified
        {
            get
            {
                return this.dailySoftLimitFieldSpecified;
            }
            set
            {
                this.dailySoftLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long DailyUsage
        {
            get
            {
                return this.dailyUsageField;
            }
            set
            {
                this.dailyUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DailyUsageSpecified
        {
            get
            {
                return this.dailyUsageFieldSpecified;
            }
            set
            {
                this.dailyUsageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long HourlyHardLimit
        {
            get
            {
                return this.hourlyHardLimitField;
            }
            set
            {
                this.hourlyHardLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HourlyHardLimitSpecified
        {
            get
            {
                return this.hourlyHardLimitFieldSpecified;
            }
            set
            {
                this.hourlyHardLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long HourlySoftLimit
        {
            get
            {
                return this.hourlySoftLimitField;
            }
            set
            {
                this.hourlySoftLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HourlySoftLimitSpecified
        {
            get
            {
                return this.hourlySoftLimitFieldSpecified;
            }
            set
            {
                this.hourlySoftLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long HourlyUsage
        {
            get
            {
                return this.hourlyUsageField;
            }
            set
            {
                this.hourlyUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HourlyUsageSpecified
        {
            get
            {
                return this.hourlyUsageFieldSpecified;
            }
            set
            {
                this.hourlyUsageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodSpecified
        {
            get
            {
                return this.periodFieldSpecified;
            }
            set
            {
                this.periodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PeriodicHardLimit
        {
            get
            {
                return this.periodicHardLimitField;
            }
            set
            {
                this.periodicHardLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodicHardLimitSpecified
        {
            get
            {
                return this.periodicHardLimitFieldSpecified;
            }
            set
            {
                this.periodicHardLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PeriodicSoftLimit
        {
            get
            {
                return this.periodicSoftLimitField;
            }
            set
            {
                this.periodicSoftLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodicSoftLimitSpecified
        {
            get
            {
                return this.periodicSoftLimitFieldSpecified;
            }
            set
            {
                this.periodicSoftLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PeriodicUsage
        {
            get
            {
                return this.periodicUsageField;
            }
            set
            {
                this.periodicUsageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodicUsageSpecified
        {
            get
            {
                return this.periodicUsageFieldSpecified;
            }
            set
            {
                this.periodicUsageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime PeriodicStartDate
        {
            get
            {
                return this.periodicStartDateField;
            }
            set
            {
                this.periodicStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodicStartDateSpecified
        {
            get
            {
                return this.periodicStartDateFieldSpecified;
            }
            set
            {
                this.periodicStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ModTime
        {
            get
            {
                return this.modTimeField;
            }
            set
            {
                this.modTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeSpecified
        {
            get
            {
                return this.modTimeFieldSpecified;
            }
            set
            {
                this.modTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccessRuleCurrentStatusCodeType RuleCurrentStatus
        {
            get
            {
                return this.ruleCurrentStatusField;
            }
            set
            {
                this.ruleCurrentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleCurrentStatusSpecified
        {
            get
            {
                return this.ruleCurrentStatusFieldSpecified;
            }
            set
            {
                this.ruleCurrentStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccessRuleStatusCodeType RuleStatus
        {
            get
            {
                return this.ruleStatusField;
            }
            set
            {
                this.ruleStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RuleStatusSpecified
        {
            get
            {
                return this.ruleStatusFieldSpecified;
            }
            set
            {
                this.ruleStatusFieldSpecified = value;
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
