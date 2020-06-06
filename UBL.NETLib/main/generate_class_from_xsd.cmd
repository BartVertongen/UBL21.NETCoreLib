REM Generate_class_from_xsd.cmd

xsd.exe UBL-Waybill-2.1.xsd  ../common/UBL-CommonAggregateComponents-2.1.xsd ^
	../common/UBL-CommonBasicComponents-2.1.xsd ^
	../common/UBL-CommonExtensionComponents-2.1.xsd ^
	../common/UBL-UnqualifiedDataTypes-2.1.xsd ^
	../common/UBL-CoreComponentParameters-2.1.xsd ^
	../common/CCTS_CCT_SchemaModule-2.1.xsd ^
	/c