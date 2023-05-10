using Humanizer;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;
using System.Dynamic;
using System.IO;
using static System.Net.WebRequestMethods;

namespace LocalIntegration.Service.Enum
{
    public static class LOVEnums
    {
        public enum MainTXTType
        {
            MIN,
            MOUT,
            OTHER,
            CMIN,
            CMOUT,
            COTHER,
        }

        public enum PartyRole
        {
            POL_HOLDER,
            POL_CO_HOLDER,
            INSURED,
            BENEFICIARY,
            PAYOR,
            LOANB,
            DEATHB,
            PRIMARYB,
            RECOVABLEB,
            IRREVOCABLEB,
            CLAIMB,
            TRUSTEE,
            PROXY,
            LEGALG,
            DEFAULT,
            AGENT,
            BROKER,            
            OTHER,
            POL_SEC_HOLDER,
            MEMBER,
            INSURED_ACT
        }

        public enum CreditDebit
        {
            C,   //Credit
            D    //Debit
        }

        public enum InstallmentFrequency
        {
            M,   //Monthly
            Q,   //Quarterly
            B,   //Bi-annually 
            A,   //Annualy
            O    //Other frequency
        }

        public enum GenderCode
        {
            GN001,  //Male
            GN002, //Female
            GN003, //Unknown
        }

        public enum Country
        {
            PR,  //Puerto Rico
            PS,  //Palestine, State of
            PT,  //Portugal
            PW,  //Palau
            PY,  //Paraguay
            QA,  //Qatar
            RE,  //Réunion
            RO,  //Romania
            RS,  //Serbia
            RU,  //Russian Federation
            RW,  //Rwanda
            SA,  //Saudi Arabia
            SB,  //Solomon Islands
            SC,  //Seychelles
            SD,  //Sudan
            SE,  //Sweden
            SG,  //Singapore
            SH,  //Saint Helena, Ascension and Tristan da Cunha
            SI,  //Slovenia
            SJ,  //Svalbard and Jan Mayen
            SK,  //Slovakia
            SL,  //Sierra Leone            
            SM,  //San Marino
            SN,  //Senegal
            SO,  //Somalia
            SR,  ///Suriname
            SS,  //South Sudan
            ST,  //Sao Tome and Principe
            SV,  //El Salvador
            SX,  //Sint Maarten (Dutch part)
            SY,  //Syrian Arab Republic
            SZ,  //Eswatini
            TC,  //Turks and Caicos Islands
            TD,  //Chad
            TF,  ///French Southern Territories
            TG,  //Togo
            TH,  //Thailand
            TJ,  //Tajikistan
            TK,  //Tokelau
            TL,  //Timor-Leste
            TM,  //Turkmenistan
            TN,  //Tunisia
            TO,  //Tonga
            TR,  //Turkey
            TT,  //Trinidad and Tobago
            TV,  //Tuvalu
            TW,  //Taiwan, Province of China
            TZ,  //Tanzania, United Republic of
            UA,  //Ukraine
            UG,  //Uganda
            UM,  //United States Minor Outlying Islands
            US,  //United States of America
            UY,  //Uruguay
            UZ,  //Uzbekistan
            VA,  //Holy See
            VC,  //Saint Vincent and the Grenadines
            VE,  //Venezuela(Bolivarian Republic of)
            VG,  //Virgin Islands(British)
            VI,  //Virgin Islands(U.S.)
            VN,  //VietNam
            VU,  //Vanuatu
            WF,  //Wallis and Futuna
            WS,  //Samoa
            X1,  //empty
            X2,  //Not applicable
            X3,  //Unknown
            XK,  //Kosovo
            YE,  //Yemen
            YT,  //Mayotte
            ZA,  //South Africa
            ZM,  //Zambia
            ZW,  //Zimbabwe
        }

        public enum Currency
        {
            AED,     //UAE Dirham
            AFN,     //Afghani
            ALL,     //Lek
            AMD,     //Armenian Dram
            ANG,     //Netherlands Antillean Guilder
            AOA,     //Kwanza
            ARS,     //Argentine Peso
            AUD,     //Australian Dollar
            AWG,     //Aruban Florin
            AZN,     //Azerbaijan Manat
            BAM,     //Convertible Mark
            BBD,     //Barbados Dollar
            BDT,     //Taka
            BGN,     //Bulgarian Lev
            BHD,     //Bahraini Dinar
            BIF,     //Burundi Franc
            BMD,     //Bermudian Dollar
            BND,     //Brunei Dollar
            BOB,     //Boliviano
            BOV,     //Mvdol
            BRL,     //Brazilian Real
            BSD,     //Bahamian Dollar
            BTN,     //Ngultrum
            BWP,     //Pula
            BYN,     //Belarusian Ruble
            BZD,     //Belize Dollar
            CAD,     //Canadian Dollar
            CDF,     //Congolese Franc
            CHE,     //WIR Euro
            CHF,     //Swiss Franc
            CHW,     //WIR Franc
            CLF,     //Unidad de Fomento
            CLP,     //Chilean Peso
            CNY,     //Yuan Renminbi
            COP,     //Colombian Peso
            COU,     //Unidad de Valor Real
            CRC,     //Costa Rican Colon
            CUC,     //Peso Convertible
            CUP,     //Cuban Peso
            CVE,     //Cabo Verde Escudo
            CZK,     //Czech Koruna
            DJF,     //Djibouti Franc
            DKK,     //Danish Krone
            DOP,     //Dominican Peso
            DZD,     //Algerian Dinar
            EGP,     //Egyptian Pound
            ERN,     //Nakfa
            ETB,     //Ethiopian Birr
            ETH,     //Ether
            EUR,     //Euro
            FJD,     //Fiji Dollar
            FKP,     //Falkland Islands Pound
            GBP,     //Pound Sterling
            GEL,     //Lari
            GHS,     //Ghana Cedi
            GIP,     //Gibraltar Pound
            GMD,     //Dalasi
            GNF,     //Guinean Franc
            GTQ,     //Quetzal
            GYD,     //Guyana Dollar
            HKD,     //Hong Kong Dollar
            HNL,     //Lempira
            HRK,     //Kuna
            HTG,     //Gourde
            HUF,     //Forint
            IDR,     //Rupiah
            ILS,     //New Israeli Sheqel
            INR,     //Indian Rupee
            IQD,     //Iraqi Dinar
            IRR,     //Iranian Rial
            ISK,     //Iceland Krona
            JMD,     //Jamaican Dollar
            JOD,     //Jordanian Dinar
            JPY,     //Yen
            KES,     //Kenyan Shilling
            KGS,     //Som
            KHR,     //Riel
            KMF,     //Comorian Franc
            KPW,     //North Korean Won
            KRW,     //Won
            KWD,     //Kuwaiti Dinar
            KYD,     //Cayman Islands Dollar
            KZT,     //Tenge
            LAK,     //Lao Kip
            LBP,     //Lebanese Pound
            LKR,     //Sri Lanka Rupee
            LRD,     //Liberian Dollar
            LSL,     //Loti
            LTC,     //Litecoin
            LYD,     //Libyan Dinar
            MAD,     //Moroccan Dirham
            MDL,     //Moldovan Leu
            MGA,     //Malagasy Ariary
            MKD,     //Denar
            MMK,     //Kyat
            MNT,     //Tugrik
            MOP,     //Pataca
            MRU,     //Ouguiya
            MUR,     //Mauritius Rupee
            MVR,     //Rufiyaa
            MWK,     //Malawi Kwacha
            MXN,     //Mexican Peso
            MXV,     //Mexican Unidad de Inversion (UDI)
            MYR,     //Malaysian Ringgit
            MZN,     //Mozambique Metical
            NAD,     //Namibia Dollar
            NGN,     //Naira
            NIO,     //Cordoba Oro
            NMC,     //Namecoin
            NOK,     //Norwegian Krone
            NPR,     //Nepalese Rupee
            NZD,     //New Zealand Dollar
            OMR,     //Rial Omani
            PAB,     //Balboa
            PEN,     //Sol
            PGK,     //Kina
            PHP,     //Philippine Peso
            PKR,     //Pakistan Rupee
            PLN,     //Zloty
            PYG,     //Guarani
            QAR,     //Qatari Rial
            RON,     //Romanian Leu
            RSD,     //Serbian Dinar
            RUB,     //Russian Ruble
            RWF,     //Rwanda Franc
            SAR,     //Saudi Riyal
            SBD,     //Solomon Islands Dollar
            SCR,     //Seychelles Rupee
            SDG,     //Sudanese Pound
            SEK,     //Swedish Krona
            SGD,     //Singapore Dollar
            SHP,     //Saint Helena Pound
            SLL,     //Leone
            SOS,     //Somali Shilling
            SRD,     //Surinam Dollar
            SSP,     //South Sudanese Pound
            STN,     //Dobra
            SVC,     //El Salvador Colon
            SYP,     //Syrian Pound
            SZL,     //Lilangeni
            THB,     //Baht
            TJS,     //Somoni
            TMT,     //Turkmenistan New Manat
            TND,     //Tunisian Dinar
            TOP,     //Pa’anga
            TRY,     //Turkish Lira
            TTD,     //Trinidad and Tobago Dollar
            TWD,     //New Taiwan Dollar
            TZS,     //Tanzanian Shilling
            UAH,     //Hryvnia
            UGX,     //Uganda Shilling
            USD,     //US Dollar
            USN,     //US Dollar(Next day)
            UYI,     //Uruguay Peso en Unidades Indexadas(UI)
            UYU,     //Peso Uruguayo
            UYW,     //Unidad Previsional
            UZS,     //Uzbekistan Sum
            VES,     //Bolívar Soberano
            VND,     //Dong
            VTC,     //Vertcoin
            VUV,     //Vatu
            WST,     //Tala
            XAF,     //CFA Franc BEAC
            XAG,     //Silver
            XAU,     //Gold
            XBA,     //Bond Markets Unit European Composite Unit(EURCO)
            XBB,     //Bond Markets Unit European Monetary Unit(E.M.U.-6)
            XBC,     //Bond Markets Unit European Unit of Account 9 (E.U.A.-9)
            XBD,     //Bond Markets Unit European Unit of Account 17 (E.U.A.-17)
            XBT,     //Bitcoin
            XCD,     //East Caribbean Dollar
            XDR,     //SDR(Special Drawing Right)
            XLM,     //Stellar Lumen
            XMR,     //Monero
            XOF,     //CFA Franc BCEAO
            XPD,     //Palladium
            XPF,     //CFP Franc
            XPT,     //Platinum
            XRP,     //XRP Ledger
            XSU,     //Sucre
            XTS,     //reserved for testing purposes
            XUA,     //ADB Unit of Account
            XXX,     //code for transactions where no currency
            YER,     //Yemeni Rial
            ZAR,     //Rand
            ZEC,     //Zcash
            ZMW,     //Zambian Kwacha
            ZWL,     //Zimbabwe Dollar
            XX1,     //empty
            XX2,     //Not applicable
            XX3,     //Unknown
        }

        public enum LinkType 
        {
            RETAIL,              //Retail
            RESPONDENT,          //Respondent (used for Correspondent Banking)
            SUBCUSTOMER,         //Sub-Customer(used for Correspondent Banking)
            CONDUCTOR,           //Conductor – a conductor who is not a customer
            PROSPECT,            //Prospect(used for CDD and WLM assessment of prospect customers).
            CONNECTED_PARTY,     //Non-Customer.Could be for example Beneficial Owners
            CONNECTED_PARTY_2,   //Non-Customer who participate to the score without being scored
            OTHER_PARTY,         //any other party not in this list
            PRE_PROSPECT,        //Used manly for telemarketing to detect partiesbefore calling them
            INTERMEDIARY,        //Intermediary
            EMPLOYEE             //Employee
        }

        public enum CustomerStatus 
        {
            ACTIVE,      //This Customer is an active customer
            INACTIVE,    //This Customer is dormant but policy not closed
            REJECTED,    //This Customer has been rejected
            APPROVED,    //This Customer has been accepted
        }

        public enum MaritalStatus 
        {
            SEPARATED,
            DIVORCED,
            MARRIED,
            SINGLE,
            WIDOWED,
            UNKNOWN,
            NA
        }

        public enum IntermediaryType 
        {
            DEFAULT,
            AGENT,
            BROKER,
        }

        public enum PolicyStatus 
        {
            OPENED,         //Opened
            INACTIVE,       //Inactive
            TERMINATED,     //Terminated
            IN_FORCE,       //In Force
            APPLICATION,    //Application form done
            UNDERQUOTATION, //Underwriting done
            ACCEPTED        //Policy accepted
        }

        public enum Industry
        {
            IN0000,  //ADMINISTRATIVE AND SUPPORT SERVICE ACTIVITIES
            IN7700,  //Rental and leasing activities
            IN7800,  //Employment activities
            IN7900,  //Travel agency, tour operator and other reservation service and related activities
            IN8000,  //Security and investigation activities
            IN8100,  //Services to buildings and landscape activities
            IN8200,  //Office administrative, office support and other business support activities
            IO0000,  //PUBLIC ADMINISTRATION AND DEFENCE; COMPULSORY SOCIAL SECURITY
            IO8400,  //Public administration and defence; compulsory social security
            IP0000,  //EDUCATION
            IP8500,  //Education
            IQ0000,  //HUMAN HEALTH AND SOCIAL WORK ACTIVITIES
            IQ8600,  //Human health activities
            IQ8700,  //Residential care activities
            IQ8800,  //Social work activities without accommodation
            IR0000,  //ARTS, ENTERTAINMENT AND RECREATION
            IR9000,  //Creative, arts and entertainment activities
            IR9100,  //Libraries, archives, museums and other cultural activities
            IR9200,  //Gambling and betting activities
            IR9300,  //Sports activities and amusement and recreation activities
            IS0000,  //OTHER SERVICE ACTIVITIES
            IS9400,  //Activities of membership organisations
            IS9500,  //Repair of computers and personal and household goods
            IS9600,  //Other personal service activities
            IT0000,  //ACTIVITIES OF HOUSEHOLDS AS EMPLOYERS; UNDIFFERENTIATED GOODS- AND SERVICES-PRODUCING ACTIVITIES OF HOUSEHOLDS FOR OWN USE
            IT9700,  //Activities of households as employers of domestic personnel
            IT9800,  //Undifferentiated goods- and services-producing activities of private households for own use
            IU0000,  //ACTIVITIES OF EXTRATERRITORIAL ORGANISATIONS AND BODIES
            IU9900,  //Activities of extraterritorial organisations and bodies
            IXXXX1,  //Empty or ""
            IXXXX2,  //Unknown
            IXXXX3   //NA
                     //empty allowed if wlm only,,
        }

        public enum DistChannel 
        {
            CC01,
            CC02,
            CC03,
            CC04,
            CC05,
            CC06,
            CC07,
            CC08,
            CCX1,
            CCX2,
            CCX3
        }

        public enum Province 
        {
            PV0001,  //Bali
            PV0002,  //Bangka Belitung
            PV0003,  //Banten
            PV0004,  //Bengkulu
            PV0005,  //D.I. Yogyakarta
            PV0006,  //DKI Jakarta
            PV0007,  //Gorontalo
            PV0008,  //Jambi
            PV0009,  //Jawa Barat
            PV0010,  //Jawa Tengah
            PV0011,  //Jawa Timur
            PV0012,  //Kalimantan Barat
            PV0013,  //Kalimantan Selatan
            PV0014,  //Kalimantan Tengah
            PV0015,  //Kalimantan Timur
            PV0016,  //Kalimantan Utara
            PV0017,  //Kepulauan Riau
            PV0018,  //Lampung
            PV0019,  //Maluku
            PV0020,  //Maluku Utara
            PV0021,  //Nanggroe Aceh Darussalam
            PV0022,  //Nusa Tenggara Barat
            PV0023,  //Nusa Tenggara Timur
            PV0024,  //Papua
            PV0025,  //Papua Barat
            PV0026,  //Riau
            PV0027,  //Sulawesi Barat
            PV0028,  //Sulawesi Selatan
            PV0029,  //Sulawesi Tengah
            PV0030,  //Sulawesi Tenggara
            PV0031,  //Sulawesi Utara
            PV0032,  //Sumatera Barat
            PV0033,  //Sumatera Selatan
            PV0034,  //Sumatera Utara
            PVX001,  //empty
            PVX002,  //Not applicable
            PVX003  //Unknown
        }

        public enum PaymentMethod
        {
            CASH,    //Cash
            CHQ,     //Cheque
            DRAFT,   //Bank Draft
            MNOD,    //Money Order
            WTT,     //Wire Transfer (TT)
            DBIN,    //Direct Bank IN
            CCP,     //Credit Card
            ATM,     //Automatic Teller Machine
            PPS,     //Pay Phone Service
            ATP,     //Auto Pay - AutoPay is a service that automatically schedules and deducts monthly payments from your bank account on your due date			
            others   //others
        }


    }       
}
