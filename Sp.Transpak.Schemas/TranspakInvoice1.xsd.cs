namespace Sp.Transpak.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UBLVersionID", @"CustomizationID", @"ProfileID", @"ID", @"IssueDate", @"InvoiceTypeCode", @"DocumentCurrencyCode", @"BuyerReference", @"URI", @"EndpointID", @"Name", @"StreetName", @"CityName", @"PostalZone", @"CountrySubentity", @"IdentificationCode", @"CompanyID", @"RegistrationName", @"Telephone", @"ElectronicMail", @"Note", @"TaxAmount", @"TaxableAmount", @"Percent", @"LineExtensionAmount", @"TaxExclusiveAmount", @"TaxInclusiveAmount", @"AllowanceTotalAmount", @"ChargeTotalAmount", 
@"PayableAmount", @"InvoicedQuantity", @"ChargeIndicator", @"AllowanceChargeReason", @"Amount", @"Description", @"ItemClassificationCode", @"PriceAmount"})]
    public sealed class TranspakInvoice1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""UBLVersionID"" type=""xs:decimal"" />
  <xs:element name=""CustomizationID"" type=""xs:string"" />
  <xs:element name=""ProfileID"" type=""xs:string"" />
  <xs:element name=""ID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeID"" type=""xs:unsignedByte"" use=""optional"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""IssueDate"" type=""xs:date"" />
  <xs:element name=""InvoiceTypeCode"" type=""xs:unsignedShort"" />
  <xs:element name=""DocumentCurrencyCode"" type=""xs:string"" />
  <xs:element name=""BuyerReference"" type=""xs:string"" />
  <xs:element name=""URI"" type=""xs:string"" />
  <xs:element name=""EndpointID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeID"" type=""xs:unsignedByte"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Name"" type=""xs:string"" />
  <xs:element name=""StreetName"" type=""xs:string"" />
  <xs:element name=""CityName"" type=""xs:string"" />
  <xs:element name=""PostalZone"" type=""xs:unsignedInt"" />
  <xs:element name=""CountrySubentity"" type=""xs:string"" />
  <xs:element name=""IdentificationCode"" type=""xs:string"" />
  <xs:element name=""CompanyID"" type=""xs:string"" />
  <xs:element name=""RegistrationName"" type=""xs:string"" />
  <xs:element name=""Telephone"" type=""xs:unsignedInt"" />
  <xs:element name=""ElectronicMail"" type=""xs:string"" />
  <xs:element name=""Note"" type=""xs:string"" />
  <xs:element name=""TaxAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxableAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Percent"" type=""xs:unsignedByte"" />
  <xs:element name=""LineExtensionAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxExclusiveAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxInclusiveAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AllowanceTotalAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ChargeTotalAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PayableAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoicedQuantity"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""unitCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ChargeIndicator"" type=""xs:boolean"" />
  <xs:element name=""AllowanceChargeReason"" type=""xs:string"" />
  <xs:element name=""Amount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Description"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""languageID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ItemClassificationCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:unsignedByte"">
          <xs:attribute name=""listID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PriceAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TranspakInvoice1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [37];
                _RootElements[0] = "UBLVersionID";
                _RootElements[1] = "CustomizationID";
                _RootElements[2] = "ProfileID";
                _RootElements[3] = "ID";
                _RootElements[4] = "IssueDate";
                _RootElements[5] = "InvoiceTypeCode";
                _RootElements[6] = "DocumentCurrencyCode";
                _RootElements[7] = "BuyerReference";
                _RootElements[8] = "URI";
                _RootElements[9] = "EndpointID";
                _RootElements[10] = "Name";
                _RootElements[11] = "StreetName";
                _RootElements[12] = "CityName";
                _RootElements[13] = "PostalZone";
                _RootElements[14] = "CountrySubentity";
                _RootElements[15] = "IdentificationCode";
                _RootElements[16] = "CompanyID";
                _RootElements[17] = "RegistrationName";
                _RootElements[18] = "Telephone";
                _RootElements[19] = "ElectronicMail";
                _RootElements[20] = "Note";
                _RootElements[21] = "TaxAmount";
                _RootElements[22] = "TaxableAmount";
                _RootElements[23] = "Percent";
                _RootElements[24] = "LineExtensionAmount";
                _RootElements[25] = "TaxExclusiveAmount";
                _RootElements[26] = "TaxInclusiveAmount";
                _RootElements[27] = "AllowanceTotalAmount";
                _RootElements[28] = "ChargeTotalAmount";
                _RootElements[29] = "PayableAmount";
                _RootElements[30] = "InvoicedQuantity";
                _RootElements[31] = "ChargeIndicator";
                _RootElements[32] = "AllowanceChargeReason";
                _RootElements[33] = "Amount";
                _RootElements[34] = "Description";
                _RootElements[35] = "ItemClassificationCode";
                _RootElements[36] = "PriceAmount";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"UBLVersionID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UBLVersionID"})]
        public sealed class UBLVersionID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UBLVersionID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UBLVersionID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CustomizationID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CustomizationID"})]
        public sealed class CustomizationID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CustomizationID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CustomizationID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ProfileID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProfileID"})]
        public sealed class ProfileID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProfileID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProfileID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ID"})]
        public sealed class ID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"IssueDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IssueDate"})]
        public sealed class IssueDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IssueDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IssueDate";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"InvoiceTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoiceTypeCode"})]
        public sealed class InvoiceTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoiceTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoiceTypeCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"DocumentCurrencyCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentCurrencyCode"})]
        public sealed class DocumentCurrencyCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentCurrencyCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentCurrencyCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"BuyerReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BuyerReference"})]
        public sealed class BuyerReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BuyerReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BuyerReference";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"URI")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"URI"})]
        public sealed class URI : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public URI() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "URI";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"EndpointID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EndpointID"})]
        public sealed class EndpointID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EndpointID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EndpointID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Name")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Name"})]
        public sealed class Name : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Name() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Name";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"StreetName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StreetName"})]
        public sealed class StreetName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StreetName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StreetName";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CityName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CityName"})]
        public sealed class CityName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CityName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CityName";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PostalZone")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PostalZone"})]
        public sealed class PostalZone : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PostalZone() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PostalZone";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CountrySubentity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CountrySubentity"})]
        public sealed class CountrySubentity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CountrySubentity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CountrySubentity";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"IdentificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IdentificationCode"})]
        public sealed class IdentificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IdentificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IdentificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CompanyID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CompanyID"})]
        public sealed class CompanyID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CompanyID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CompanyID";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"RegistrationName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RegistrationName"})]
        public sealed class RegistrationName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RegistrationName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RegistrationName";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Telephone")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Telephone"})]
        public sealed class Telephone : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Telephone() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Telephone";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ElectronicMail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ElectronicMail"})]
        public sealed class ElectronicMail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ElectronicMail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ElectronicMail";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Note")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Note"})]
        public sealed class Note : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Note() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Note";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxAmount"})]
        public sealed class TaxAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxableAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxableAmount"})]
        public sealed class TaxableAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxableAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxableAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Percent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Percent"})]
        public sealed class Percent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Percent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Percent";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"LineExtensionAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LineExtensionAmount"})]
        public sealed class LineExtensionAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LineExtensionAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LineExtensionAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxExclusiveAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxExclusiveAmount"})]
        public sealed class TaxExclusiveAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxExclusiveAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxExclusiveAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxInclusiveAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxInclusiveAmount"})]
        public sealed class TaxInclusiveAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxInclusiveAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxInclusiveAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AllowanceTotalAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceTotalAmount"})]
        public sealed class AllowanceTotalAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceTotalAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceTotalAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ChargeTotalAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ChargeTotalAmount"})]
        public sealed class ChargeTotalAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ChargeTotalAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ChargeTotalAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PayableAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PayableAmount"})]
        public sealed class PayableAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PayableAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PayableAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"InvoicedQuantity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoicedQuantity"})]
        public sealed class InvoicedQuantity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoicedQuantity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoicedQuantity";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ChargeIndicator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ChargeIndicator"})]
        public sealed class ChargeIndicator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ChargeIndicator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ChargeIndicator";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AllowanceChargeReason")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceChargeReason"})]
        public sealed class AllowanceChargeReason : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceChargeReason() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceChargeReason";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Amount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Amount"})]
        public sealed class Amount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Amount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Amount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Description")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Description"})]
        public sealed class Description : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Description() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Description";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ItemClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemClassificationCode"})]
        public sealed class ItemClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemClassificationCode";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PriceAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PriceAmount"})]
        public sealed class PriceAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PriceAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PriceAmount";
                    return _RootElements;
                }
            }
            
            protected override object RawSchema {
                get {
                    return _rawSchema;
                }
                set {
                    _rawSchema = value;
                }
            }
        }
    }
}
