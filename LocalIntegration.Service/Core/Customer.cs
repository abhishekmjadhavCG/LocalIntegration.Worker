using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LocalIntegration.Service.Core
{
    public class Customer
    {
        [Key]        
        public string CUSTOMER_SOURCE_UNIQUE_ID { get; set; }
        public string ORGUNIT_CODE { get; set; }
        public string PERSON_TITLE { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAMES { get; set;}
        public string LAST_NAME { get; set; }
        public string SUFFIX { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string COMPANY_NAME { get; set; }
        public string COMPANY_FORM { get; set; }
        public string REGISTERED_NUMBER { get; set; }   
        public string INCORPORATION_DATE { get; set; }
        public string INCORPORATION_COUNTRY_CODE { get; set; }
        public BUSINESS_SEGMENT_1 BUSINESS_SEGMENT_1 { get; set; }
        public string BUSINESS_SEGMENT_2 { get; set; }
        public string INITIALS { get; set; }
        public string DATE_OF_BIRTH { get; set; }
        public string NAME_OF_BIRTH { get; set;}    
        public string ADDRESS { get; set; } 
        public string ZONE { get; set; }
        public string CITY { get; set; }
        public string POSTAL_CODE { get; set; }
        public string COUNTRY_OF_RESIDENCE { get; set; }
        public string COUNTRY_OF_ORIGIN { get; set; }
        public string NATIONALITY_CODE { get; set; }
        public string PLACE_OF_BIRTH { get; set;}
        public string GENDER_CODE { get; set; }
        public string EMPLOYEE_FLAG { get; set; }
        public OCCUPATION OCCUPATION { get; set; }        
        public DateTime? ACQUISITION_DATE { get; set; }
        public DateTime? CANCELLED_DATE { get; set; }
        public string CUSTOMER_TYPE_CODE { get; set; }
        public string CUSTOMER_STATUS_CODE { get; set; }
        public string RESIDENCE_FLAG { get; set; }
        public string SPECIAL_ATTENTION_FLAG { get; set; }
        public string DECEASED_FLAG { get; set; }
        public string COMPLEX_STRUCTURE { get; set; }        
        public string VAT_NUMBER { get; set; }
        public string BLACK_LISTED_FLAG { get; set; }
        public string TAX_NUMBER { get; set; }
        public string TAX_NUMBER_ISSUED_BY { get; set; }        
        public string CUSTOMER_CATEGORY_CODE { get; set; }
        public string ADDRESS_VALID_FROM { get; set; }
        public string ADDRESS_VALID_TO { get;set; }
        public string EMAIL { get; set; }
        public string EMAIL_VALID_FROM { get; set; }
        public string EMAIL_VALID_TO { get;set; }
        public string PHONE_COUNTRY_CODE { get; set; }
        public string PHONE_AREA_CODE { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string PHONE_EXTENSION { get; set; }
        public string PHONE_VALID_FROM { get; set; }
        public string PHONE_VALID_TO { get; set; }
        public string ALTERNATE_NAME { get; set; }
        public string TAX_NUMBER_TYPE { get; set; }
        public string COUNTRY_OF_HQ { get; set; }
        public string COUNTRY_OF_OPERATIONS { get; set; }
        public string COUNTRY_OF_TAX_RESIDENCE { get; set; }
        public string NATIONALITY_CODE_2 { get; set; }
        public string[] CUSTOMER_IDENTIFICATION { get; set; }
        public string IDENTIFICATION_NUMBER { get; set; }
        public string ISSUING_AUTHORITY { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string IDENTIFICATION_TYPE { get; set; }
        public string VALID_FROM { get; set; }
        public string VALID_TO { get; set;}
        public string X_SUBSCRIPTION_KEYWORD { get; set; }
        public string X_SOURCE_SYSTEM { get; set; }
        public string X_SENSITIVE_CUSTOMER_FLAG { get; set; }
        public string X_OLD_CUSTOMER_SOURCE_UNIQUE_ID { get; set; }
        public string X_NEW_CUSTOMER_SOURCE_UNIQUE_ID { get; set; }
        public string X_CUSTOMER_INTERMEDIARY_REF_ID { get; set; }        
        public DateTime? X_SCREENING_END_DATE { get; set; }
        public string BUSINESSES_SEGMENT_1_N { get; set; }
        public string MARITAL_STATUS { get; set; }
        public string COUNTRY_OF_OPERATIONS_N { get; set; }
        public string OCCUPATION_N { get; set; }

    }
}
