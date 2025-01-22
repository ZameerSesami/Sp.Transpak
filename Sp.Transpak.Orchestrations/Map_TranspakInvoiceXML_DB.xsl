<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s4 s0 s3 s1 s2 userCSharp" version="1.0" xmlns:ns0="http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo" xmlns:s4="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:s2="http://schemas.microsoft.com/BizTalk/2003/aggschema" xmlns:s1="http://Sp.Transpak.Schemas.SSOValues" xmlns:s0="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:ns4="http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfaceInvoiceInsert" xmlns:ns3="http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo" xmlns:s3="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s2:Root" />
  </xsl:template>
  <xsl:template match="/s2:Root">
    <xsl:variable name="varHubID" select="userCSharp:StringConcat(string(InputMessagePart_1/s1:Root/HubID/text()))" />
    <ns0:InterfaceInvoiceInsert>
      <ns0:InvHeaderType>
        <xsl:for-each select="InputMessagePart_0/s0:Invoice">
        <!--<xsl:for-each select="InputMessagePart_0/s0:Invoice/s3:InvoiceLine">-->
          <!--<xsl:variable name="var:v1" select="userCSharp:StringConcat(string(../s4:InvoiceTypeCode/text()))" />-->
          <ns3:InvoiceHeaderTableType>
            <!--<ns3:HubID>
              <xsl:value-of select="../../../InputMessagePart_1/s1:Root/HubID/text()" />
            </ns3:HubID>-->
            
            <ns3:HubID>
              <xsl:value-of select="$varHubID" />
            </ns3:HubID>
            <ns3:InvoiceNumber>
              <xsl:value-of select="../s4:ID/text()" />
            </ns3:InvoiceNumber>
            <ns3:IssueDate>
              <xsl:value-of select="../s4:IssueDate/text()" />
            </ns3:IssueDate>
            <ns3:InvoiceTypeCode>
              <xsl:value-of select="$varHubID" />
            </ns3:InvoiceTypeCode>
            <ns3:BuyerReference>
              <xsl:value-of select="../s4:BuyerReference/text()" />
            </ns3:BuyerReference>
            <ns3:OrderReference>
              <xsl:value-of select="../s3:OrderReference/s4:ID/text()" />
            </ns3:OrderReference>
            <ns3:SupplierEndPointID>
              <xsl:value-of select="../s3:AccountingSupplierParty/s3:Party/s4:EndpointID/text()" />
            </ns3:SupplierEndPointID>
            <ns3:SupplierIdentificationID>
              <xsl:value-of select="../s3:AccountingSupplierParty/s3:Party/s3:PartyIdentification/s4:ID/text()" />
            </ns3:SupplierIdentificationID>
            <ns3:TotalTaxAmount>
              <xsl:value-of select="../s3:TaxTotal/s4:TaxAmount/text()" />
            </ns3:TotalTaxAmount>
            <ns3:TotalLineQty>
              <xsl:value-of select="s4:InvoicedQuantity/text()" />
            </ns3:TotalLineQty>
            <xsl:if test="../../../InputMessagePart_1/s1:Root/FileName">
              <xsl:variable name="var:v2" select="string(../../../InputMessagePart_1/s1:Root/FileName/@xsi:nil) = 'true'" />
              <xsl:if test="string($var:v2)='true'">
                <ns3:InterfaceFileName>
                  <xsl:attribute name="xsi:nil">
                    <xsl:value-of select="'true'" />
                  </xsl:attribute>
                </ns3:InterfaceFileName>
              </xsl:if>
              <xsl:if test="string($var:v2)='false'">
                <ns3:InterfaceFileName>
                  <xsl:value-of select="../../../InputMessagePart_1/s1:Root/FileName/text()" />
                </ns3:InterfaceFileName>
              </xsl:if>
            </xsl:if>
          </ns3:InvoiceHeaderTableType>
        </xsl:for-each>
      </ns0:InvHeaderType>
      <ns0:InvAttachmentsType>
        <ns3:InvoiceAttachmentsTableType>
          <ns3:Filename>
            <xsl:value-of select="InputMessagePart_0/s0:Invoice/s3:AdditionalDocumentReference/s3:Attachment/s3:ExternalReference/s4:URI/text()" />
          </ns3:Filename>
        </ns3:InvoiceAttachmentsTableType>
      </ns0:InvAttachmentsType>
    </ns0:InterfaceInvoiceInsert>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>