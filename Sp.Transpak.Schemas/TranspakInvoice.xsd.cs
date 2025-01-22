namespace Sp.Transpak.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Invoice", @"ClassifiedTaxCategory"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.Transpak.Schemas.TranspakInvoice1", typeof(global::Sp.Transpak.Schemas.TranspakInvoice1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.Transpak.Schemas.TranspakInvoice2", typeof(global::Sp.Transpak.Schemas.TranspakInvoice2))]
    public sealed class TranspakInvoice : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:cbc=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:cac=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.Transpak.Schemas.TranspakInvoice1"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
  <xs:import schemaLocation=""Sp.Transpak.Schemas.TranspakInvoice2"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
        <reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
        <reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Invoice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""cbc:UBLVersionID"" />
        <xs:element ref=""cbc:CustomizationID"" />
        <xs:element ref=""cbc:ProfileID"" />
        <xs:element ref=""cbc:ID"" />
        <xs:element ref=""cbc:IssueDate"" />
        <xs:element ref=""cbc:InvoiceTypeCode"" />
        <xs:element ref=""cbc:DocumentCurrencyCode"" />
        <xs:element ref=""cbc:BuyerReference"" />
        <xs:element ref=""cac:OrderReference"" />
        <xs:element ref=""cac:AdditionalDocumentReference"" />
        <xs:element ref=""cac:AccountingSupplierParty"" />
        <xs:element ref=""cac:AccountingCustomerParty"" />
        <xs:element ref=""cac:PaymentTerms"" />
        <xs:element ref=""cac:TaxTotal"" />
        <xs:element ref=""cac:LegalMonetaryTotal"" />
        <xs:element maxOccurs=""unbounded"" ref=""cac:InvoiceLine"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ClassifiedTaxCategory"">
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""cbc:ID"" />
        <xs:element ref=""cbc:Percent"" />
        <xs:element ref=""cac:TaxScheme"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TranspakInvoice() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "Invoice";
                _RootElements[1] = "ClassifiedTaxCategory";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",@"Invoice")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Invoice"})]
        public sealed class Invoice : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Invoice() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Invoice";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",@"ClassifiedTaxCategory")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ClassifiedTaxCategory"})]
        public sealed class ClassifiedTaxCategory : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ClassifiedTaxCategory() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ClassifiedTaxCategory";
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
