<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<html>
			<head>
				<title>Кіноматограф</title>
			</head>
			<body>
				<h1>Перелік режисерів, фільмів які вони зняли та акторських складів</h1>
				<xsl:apply-templates/>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="cinema">
		<xsl:apply-templates/>
	</xsl:template>

	<xsl:template match="director">
		<h2>
			<xsl:value-of select="@name"/>
		</h2>
		<xsl:apply-templates/>
	</xsl:template>

	<xsl:template match="year">
		<h3>
			<xsl:value-of select="@name"/>
		</h3>
		<xsl:apply-templates/>
	</xsl:template>

	<xsl:template match="movie">
		<h4>
			<xsl:value-of select="@name"/>
		</h4>
		<table border="1">
			<tr>
				<th>Актор</th>
				<th>Екранний час</th>
			</tr>
			<xsl:apply-templates select="actor"/>
		</table>
	</xsl:template>

	<xsl:template match="actor">
		<tr>
			<td>
				<xsl:value-of select="@name"/>
			</td>
			<td>
				<xsl:value-of select="@screentime"/>
			</td>
		</tr>
	</xsl:template>

</xsl:stylesheet>