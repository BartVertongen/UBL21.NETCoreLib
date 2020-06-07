<?xml version="1.0"?>
<!DOCTYPE xsl:stylesheet
[
  <!ENTITY logo  SYSTEM '../OASISLogo.jpg' NDATA dummy>
  <!ENTITY css   SYSTEM '../css/' NDATA dummy>
  <!NOTATION dummy SYSTEM "">
]>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                version="1.0">
<!-- $Id: oasis-note-html-offline.xsl,v 1.1 2013/07/17 18:42:13 admin Exp $ -->

<!-- Imported stylesheet is a customization of the DocBook XSL Stylesheets -->
<!-- from http://docs.oasis-open.org/templates/
     to have resource locations parameterized -->
<!-- See http://sourceforge.net/projects/docbook/ -->
<xsl:import href="oasis-note-html.xsl"/>

<!-- ============================================================ -->
<!-- Parameters -->

<xsl:param name="css.path">
  <xsl:for-each select="document('')">
    <xsl:value-of select="unparsed-entity-uri('css')"/>
  </xsl:for-each>
</xsl:param>

<xsl:param name="oasis.logo">
  <xsl:for-each select="document('')">
    <xsl:value-of select="unparsed-entity-uri('logo')"/>
  </xsl:for-each>
</xsl:param>

<xsl:param name="oasis-base" select="'no'"/>

</xsl:stylesheet>
