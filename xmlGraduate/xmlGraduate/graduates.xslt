<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Graduates table</title>
      </head>
      <body>
        <h1>Graduates table</h1>
        <table border="1">
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>FaculcyName</th>    
            <th>Departament</th>
            <th>Occupation</th>
            <th>EnterDate</th>
            <th>EndDate</th>
          </tr>
          <xsl:apply-templates select="Graduates/Graduate"/>
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="Graduate">
    <tr>
      <td><xsl:value-of select="Id"/></td>
      <td><xsl:value-of select="Name"/></td>
      <td><xsl:value-of select="FaculcyName"/></td>
      <td><xsl:value-of select="Departament"/></td>
      <td><xsl:value-of select="Occupation"/></td>
      <td><xsl:value-of select="EnterDate"/></td>
      <td><xsl:value-of select="EndDate"/></td>
    </tr>
  </xsl:template>

</xsl:stylesheet>
