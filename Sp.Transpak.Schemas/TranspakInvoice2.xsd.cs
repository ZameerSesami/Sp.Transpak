namespace Sp.Transpak.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderReference", @"AdditionalDocumentReference", @"AccountingSupplierParty", @"AccountingCustomerParty", @"PaymentTerms", @"TaxTotal", @"LegalMonetaryTotal", @"InvoiceLine", @"TaxScheme"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.Transpak.Schemas.TranspakInvoice1", typeof(global::Sp.Transpak.Schemas.TranspakInvoice1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.Transpak.Schemas.TranspakInvoice", typeof(global::Sp.Transpak.Schemas.TranspakInvoice))]
    public sealed class TranspakInvoice2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.Transpak.Schemas.TranspakInvoice1"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
  <xs:import schemaLocation=""Sp.Transpak.Schemas.TranspakInvoice"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
        <reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
        <reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OrderReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q1:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AdditionalDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q2=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q2:ID"" />
        <xs:element name=""Attachment"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ExternalReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q3=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q3:URI"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingSupplierParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q4=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q4:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q5=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q5:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q6=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q6:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q7=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q7:StreetName"" />
                    <xs:element xmlns:q8=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q8:CityName"" />
                    <xs:element xmlns:q9=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q9:PostalZone"" />
                    <xs:element xmlns:q10=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q10:CountrySubentity"" />
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q11=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q11:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""PartyTaxScheme"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q12=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q12:CompanyID"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q13=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q13:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q14=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q14:RegistrationName"" />
                    <xs:element xmlns:q15=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q15:CompanyID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q16=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q16:Name"" />
                    <xs:element xmlns:q17=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q17:Telephone"" />
                    <xs:element xmlns:q18=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q18:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingCustomerParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q19=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q19:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q20=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q20:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q21=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q21:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q22=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q22:StreetName"" />
                    <xs:element xmlns:q23=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q23:CityName"" />
                    <xs:element xmlns:q24=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q24:CountrySubentity"" />
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q25=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q25:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q26=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q26:RegistrationName"" />
                    <xs:element xmlns:q27=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q27:CompanyID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q28=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q28:Name"" />
                    <xs:element xmlns:q29=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q29:Telephone"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PaymentTerms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q30=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q30:Note"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxTotal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q31=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q31:TaxAmount"" />
        <xs:element name=""TaxSubtotal"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q32=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q32:TaxableAmount"" />
              <xs:element xmlns:q33=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q33:TaxAmount"" />
              <xs:element name=""TaxCategory"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q34=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q34:ID"" />
                    <xs:element xmlns:q35=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q35:Percent"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q36=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q36:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LegalMonetaryTotal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q37=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q37:LineExtensionAmount"" />
        <xs:element xmlns:q38=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q38:TaxExclusiveAmount"" />
        <xs:element xmlns:q39=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q39:TaxInclusiveAmount"" />
        <xs:element xmlns:q40=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q40:AllowanceTotalAmount"" />
        <xs:element xmlns:q41=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q41:ChargeTotalAmount"" />
        <xs:element xmlns:q42=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q42:PayableAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceLine"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q43=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q43:ID"" />
        <xs:element xmlns:q44=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q44:InvoicedQuantity"" />
        <xs:element xmlns:q45=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q45:LineExtensionAmount"" />
        <xs:element name=""AllowanceCharge"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q46=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q46:ChargeIndicator"" />
              <xs:element xmlns:q47=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q47:AllowanceChargeReason"" />
              <xs:element xmlns:q48=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q48:Amount"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q49=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q49:Description"" />
              <xs:element xmlns:q50=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q50:Name"" />
              <xs:element name=""CommodityClassification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q51=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q51:ItemClassificationCode"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element xmlns:q52=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" ref=""q52:ClassifiedTaxCategory"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Price"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q53=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q53:PriceAmount"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxScheme"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q54=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q54:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TranspakInvoice2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [9];
                _RootElements[0] = "OrderReference";
                _RootElements[1] = "AdditionalDocumentReference";
                _RootElements[2] = "AccountingSupplierParty";
                _RootElements[3] = "AccountingCustomerParty";
                _RootElements[4] = "PaymentTerms";
                _RootElements[5] = "TaxTotal";
                _RootElements[6] = "LegalMonetaryTotal";
                _RootElements[7] = "InvoiceLine";
                _RootElements[8] = "TaxScheme";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OrderReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderReference"})]
        public sealed class OrderReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AdditionalDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AdditionalDocumentReference"})]
        public sealed class AdditionalDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AdditionalDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AdditionalDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AccountingSupplierParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingSupplierParty"})]
        public sealed class AccountingSupplierParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingSupplierParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingSupplierParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AccountingCustomerParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingCustomerParty"})]
        public sealed class AccountingCustomerParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingCustomerParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingCustomerParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"PaymentTerms")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PaymentTerms"})]
        public sealed class PaymentTerms : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PaymentTerms() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PaymentTerms";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"TaxTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxTotal"})]
        public sealed class TaxTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxTotal";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"LegalMonetaryTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LegalMonetaryTotal"})]
        public sealed class LegalMonetaryTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LegalMonetaryTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LegalMonetaryTotal";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"InvoiceLine")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoiceLine"})]
        public sealed class InvoiceLine : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoiceLine() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoiceLine";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"TaxScheme")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxScheme"})]
        public sealed class TaxScheme : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxScheme() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxScheme";
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
