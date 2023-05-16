using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LocalIntegration.Service.Core.Model
{
    public class Customer
    {
        [Key]
        [Required]
        [MaxLength(126)]
        public string CUSTOMER_SOURCE_UNIQUE_ID { get; set; }

        [Required]
        public DateTime RUN_TIMESTAMP { get; set; }

        [Required]
        [MaxLength(3)]
        public string ORGUNIT_CODE { get; set; }

        [MaxLength(50)]
        public string PERSON_TITLE { get; set; } //Business Mandatory

        [MaxLength(150)]
        public string FIRST_NAME { get; set; }  //Business Mandatory

        [MaxLength(700)]
        public string MIDDLE_NAMES { get; set; } //Business Mandatory

        [MaxLength(100)]
        public string LAST_NAME { get; set; }   //Business Mandatory

        [MaxLength(50)]
        public string SUFFIX { get; set; }     //Business Mandatory

        [Required]
        [MaxLength(100)]
        public string CUSTOMER_NAME { get; set; }

        [MaxLength(1000)]
        public string COMPANY_NAME { get; set; } //Business Mandatory

        [MaxLength(20)]
        public string COMPANY_FORM { get; set; }  //Business Mandatory

        [MaxLength(30)]
        public string REGISTERED_NUMBER { get; set; }  //Business Mandatory 

        public DateOnly INCORPORATION_DATE { get; set; }  //Business Mandatory

        [MaxLength(3)]
        public string INCORPORATION_COUNTRY_CODE { get; set; } //Business Mandatory

        public BUSINESS_SEGMENT_1 BUSINESS_SEGMENT_1 { get; set; } //Business Mandatory

        [MaxLength(60)]
        public string BUSINESS_SEGMENT_2 { get; set; } //Business Mandatory

        [MaxLength(5)]
        public string INITIALS { get; set; }  //Business Mandatory

        public DateOnly DATE_OF_BIRTH { get; set; } //Business Mandatory

        [MaxLength(100)]
        public string NAME_OF_BIRTH { get; set; }  //Business Mandatory

        [MaxLength(400)]
        public string ADDRESS { get; set; }  //Business Mandatory

        [MaxLength(100)]
        public string ZONE { get; set; }  //Business Mandatory

        [MaxLength(100)]
        public string CITY { get; set; }  //Business Mandatory

        [MaxLength(20)]
        public string POSTAL_CODE { get; set; }  //Business Mandatory

        [MaxLength(3)]
        public string COUNTRY_OF_RESIDENCE { get; set; } //Business Mandatory

        [MaxLength(3)]
        public string COUNTRY_OF_ORIGIN { get; set; }  //Business Mandatory

        [MaxLength(3)]
        public string NATIONALITY_CODE { get; set; }  //Business Mandatory

        [MaxLength(50)]
        public string PLACE_OF_BIRTH { get; set; } //Business Mandatory

        [MaxLength(10)]
        public string GENDER_CODE { get; set; }  //Business Mandatory  

        [MaxLength(1)]
        public string EMPLOYEE_FLAG { get; set; } //Business Mandatory

        public OCCUPATION OCCUPATION { get; set; }  //Business Mandatory

        [MaxLength(6)]
        public string OCCUPATION_1 { get; set; }  //Business Mandatory

        public string ACQUISITION_DATE { get; set; } //Business Mandatory

        public string CANCELLED_DATE { get; set; }  //Business Mandatory

        [Required]
        [MaxLength(20)]
        public string CUSTOMER_TYPE_CODE { get; set; }

        [Required]
        [MaxLength(10)]
        public string CUSTOMER_STATUS_CODE { get; set; }

        [MaxLength(1)]
        public string RESIDENCE_FLAG { get; set; }  //Business Mandatory

        [MaxLength(1)]
        public string SPECIAL_ATTENTION_FLAG { get; set; } //Business Mandatory

        [MaxLength(1)]
        public string DECEASED_FLAG { get; set; }  //Business Mandatory

        [MaxLength(1)]
        public string COMPLEX_STRUCTURE { get; set; } //Business Mandatory

        [MaxLength(50)]
        public string VAT_NUMBER { get; set; }  //Business Mandatory

        [MaxLength(1)]
        public string BLACK_LISTED_FLAG { get; set; }  //Business Mandatory

        [MaxLength(25)]
        public string TAX_NUMBER { get; set; }  //Business Mandatory

        [MaxLength(3)]
        public string TAX_NUMBER_ISSUED_BY { get; set; } //Business Mandatory

        [MaxLength(20)]
        public string CUSTOMER_CATEGORY_CODE { get; set; } //Business Mandatory

        public string ADDRESS_VALID_FROM { get; set; } //Business Mandatory


        public string ADDRESS_VALID_TO { get; set; } //Business Mandatory

        [MaxLength(256)]
        public string EMAIL { get; set; } //Business Mandatory


        public string EMAIL_VALID_FROM { get; set; } //Business Mandatory

        public string EMAIL_VALID_TO { get; set; } //Business Mandatory

        [MaxLength(5)]
        public string PHONE_COUNTRY_CODE { get; set; } //Business Mandatory

        [MaxLength(5)]
        public string PHONE_AREA_CODE { get; set; } //Business Mandatory

        [MaxLength(20)]
        public string PHONE_NUMBER { get; set; } //Business Mandatory

        [MaxLength(6)]
        public string PHONE_EXTENSION { get; set; } //Business Mandatory

        public string PHONE_VALID_FROM { get; set; } //Business Mandatory

        public string PHONE_VALID_TO { get; set; } //Business Mandatory

        [MaxLength(1000)]
        public string ALTERNATE_NAME { get; set; } //Business Mandatory

        [MaxLength(100)]
        public string TAX_NUMBER_TYPE { get; set; } //Business Mandatory

        [MaxLength(50)]
        public string COUNTRY_OF_HQ { get; set; } //Business Mandatory


        public string COUNTRY_OF_OPERATIONS { get; set; } //Business Mandatory

        [MaxLength(3)]
        public string COUNTRY_OF_TAX_RESIDENCE { get; set; } //Business Mandatory

        [MaxLength(3)]
        public string NATIONALITY_CODE_2 { get; set; } //Business Mandatory

        public string[] CUSTOMER_IDENTIFICATION { get; set; } //Business Mandatory

        [MaxLength(100)]
        public string IDENTIFICATION_NUMBER { get; set; } //Business Mandatory

        [MaxLength(100)]
        public string ISSUING_AUTHORITY { get; set; } //Business Mandatory

        [MaxLength(3)]
        public string COUNTRY_CODE { get; set; } //Business Mandatory

        [MaxLength(32)]
        public string IDENTIFICATION_TYPE { get; set; } //Business Mandatory

        public string VALID_FROM { get; set; } //Contextual Mandatory

        public string VALID_TO { get; set; } //Contextual Mandatory

        [MaxLength(100)]
        public string X_SUBSCRIPTION_KEYWORD { get; set; } //Business Mandatory

        [MaxLength(100)]
        public string X_SOURCE_SYSTEM { get; set; } //Business Mandatory

        [MaxLength(1)]
        public string X_SENSITIVE_CUSTOMER_FLAG { get; set; } //Business Mandatory

        [MaxLength(126)]
        public string X_OLD_CUSTOMER_SOURCE_UNIQUE_ID { get; set; } //Business Mandatory

        [MaxLength(126)]
        public string X_NEW_CUSTOMER_SOURCE_UNIQUE_ID { get; set; } //Business Mandatory

        [MaxLength(126)]
        public string X_CUSTOMER_INTERMEDIARY_REF_ID { get; set; } //Business Mandatory

        public DateTime? X_SCREENING_END_DATE { get; set; } //Business Mandatory

        [MaxLength(6)]
        public string BUSINESSES_SEGMENT_1_1 { get; set; } //Business Mandatory

        [MaxLength(10)]
        public string MARITAL_STATUS { get; set; }

        [MaxLength(1)]
        public string COUNTRY_OF_OPERATIONS_1 { get; set; } //Business Mandatory



    }
}
