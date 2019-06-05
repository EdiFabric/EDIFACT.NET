<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <xsl:apply-templates select="/TSORDERS" />
  </xsl:template>
  <xsl:template match="/TSORDERS">
    <PurchaseOrder>
      <xsl:if test="BGM/Documentmessagenumber_02">
        <RefNumber>
          <xsl:value-of select="BGM/Documentmessagenumber_02/text()" />
        </RefNumber>
      </xsl:if>

      <xsl:for-each select="DTM">
        <xsl:for-each select="DTM">
          <xsl:variable name="v2" select="string(DATETIMEPERIOD_01/Datetimeperiodqualifier_01/text())='137'" />
          <xsl:if test="string($v2)='true'">
            <Date>
              <xsl:value-of select="concat(substring(DATETIMEPERIOD_01/Datetimeperiod_02/text(),1,4),'-',substring(DATETIMEPERIOD_01/Datetimeperiod_02/text(),5,2),'-',substring(DATETIMEPERIOD_01/Datetimeperiod_02/text(),7,2))" />
            </Date>
          </xsl:if>
        </xsl:for-each>
      </xsl:for-each>

      <xsl:for-each select="NADLoop">
        <xsl:for-each select="Loop_NAD_ORDERS">
          <xsl:variable name="v1" select="string(NAD/Partyqualifier_01/text())='BY'" />
          <Customer>
            <xsl:if test="string($v1)='true'">
              <Name>
                <xsl:value-of select="NAD/PARTYNAME_04/Partyname_01/text()" />
              </Name>
            </xsl:if>
            <xsl:if test="string($v1)='true'">
              <RefNumber>
                <xsl:value-of select="NAD/PARTYIDENTIFICATIONDETAILS_02/Partyididentification_01/text()" />
              </RefNumber>
            </xsl:if>
            <xsl:if test="string($v1)='true'">
              <AddressLine>
                <xsl:value-of select="NAD/STREET_05/Streetandnumberpobox_01/text()" />
              </AddressLine>
            </xsl:if>
            <xsl:if test="string($v1)='true'">
              <City>
                <xsl:value-of select="NAD/Cityname_06/text()" />
              </City>
            </xsl:if>
            <xsl:if test="string($v1)='true'">
              <State>
                <xsl:value-of select="NAD/Countrysubentityidentification_07/text()" />
              </State>
            </xsl:if>
            <xsl:if test="string($v1)='true'">
              <PostCode>
                <xsl:value-of select="NAD/Postcodeidentification_08/text()" />
              </PostCode>
            </xsl:if>
          </Customer>
        </xsl:for-each>
      </xsl:for-each>
      <OrderLines>
        <xsl:for-each select="LINLoop">
          <xsl:for-each select="Loop_LIN_ORDERS">
            <OrderLine>
              <xsl:if test="LIN/Lineitemnumber_01">
                <LineNumber>
                  <xsl:value-of select="LIN/Lineitemnumber_01/text()" />
                </LineNumber>
              </xsl:if>
              <xsl:if test="LIN/ITEMNUMBERIDENTIFICATION_03/Itemnumber_01">
                <UPCNumber>
                  <xsl:value-of select="LIN/ITEMNUMBERIDENTIFICATION_03/Itemnumber_01/text()" />
                </UPCNumber>
              </xsl:if>

              <xsl:for-each select="QTY">
                <xsl:variable name="v3" select="string(QTY/QUANTITYDETAILS_01/Quantityqualifier_01/text())='21'" />
                <xsl:if test="string($v3)='true'">
                  <Quantity>
                    <xsl:value-of select="QTY/QUANTITYDETAILS_01/Quantity_02/text()" />
                  </Quantity>
                </xsl:if>
              </xsl:for-each>

              <xsl:for-each select="PRILoop">
                <xsl:for-each select="Loop_PRI_ORDERS">
                  <xsl:variable name="v4" select="string(PRI/PRICEINFORMATION_01/Pricequalifier_01/text())='AAA'" />
                  <xsl:if test="string($v4)='true'">
                    <Price>
                      <xsl:value-of select="PRI/PRICEINFORMATION_01/Price_02/text()" />
                    </Price>
                  </xsl:if>
                </xsl:for-each>
              </xsl:for-each>

              <xsl:for-each select="QTY">
                <xsl:variable name="v3" select="string(QTY/QUANTITYDETAILS_01/Quantityqualifier_01/text())='21'" />
                <xsl:if test="string($v3)='true'">
                  <UOM>
                    <xsl:value-of select="QTY/QUANTITYDETAILS_01/Measureunitqualifier_03/text()" />
                  </UOM>
                </xsl:if>

              </xsl:for-each>
            </OrderLine>
          </xsl:for-each>
        </xsl:for-each>
      </OrderLines>
    </PurchaseOrder>
  </xsl:template>
</xsl:stylesheet>
