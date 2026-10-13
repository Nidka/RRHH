using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.DataSet1TableAdapters;
using RecursosHumanos.My.Resources;

namespace RecursosHumanos;

[DesignerGenerated]
public class Report_Ficha_Escalaf : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("DataSet11")]
	private DataSet1 _DataSet11;

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("XrTable8")]
	private XRTable _XrTable8;

	[AccessedThroughProperty("XrTableRow33")]
	private XRTableRow _XrTableRow33;

	[AccessedThroughProperty("XrTableCell122")]
	private XRTableCell _XrTableCell122;

	[AccessedThroughProperty("XrTableCell127")]
	private XRTableCell _XrTableCell127;

	[AccessedThroughProperty("XrTableRow34")]
	private XRTableRow _XrTableRow34;

	[AccessedThroughProperty("XrTableCell123")]
	private XRTableCell _XrTableCell123;

	[AccessedThroughProperty("XrTableCell126")]
	private XRTableCell _XrTableCell126;

	[AccessedThroughProperty("XrLabel8")]
	private XRLabel _XrLabel8;

	[AccessedThroughProperty("XrLabel4")]
	private XRLabel _XrLabel4;

	[AccessedThroughProperty("XrTable2")]
	private XRTable _XrTable2;

	[AccessedThroughProperty("XrTableRow2")]
	private XRTableRow _XrTableRow2;

	[AccessedThroughProperty("XrTableCell7")]
	private XRTableCell _XrTableCell7;

	[AccessedThroughProperty("XrTableCell4")]
	private XRTableCell _XrTableCell4;

	[AccessedThroughProperty("XrTableCell5")]
	private XRTableCell _XrTableCell5;

	[AccessedThroughProperty("XrTableCell6")]
	private XRTableCell _XrTableCell6;

	[AccessedThroughProperty("XrTableRow3")]
	private XRTableRow _XrTableRow3;

	[AccessedThroughProperty("XrTableCell8")]
	private XRTableCell _XrTableCell8;

	[AccessedThroughProperty("XrTableCell9")]
	private XRTableCell _XrTableCell9;

	[AccessedThroughProperty("XrTableCell10")]
	private XRTableCell _XrTableCell10;

	[AccessedThroughProperty("XrTableCell11")]
	private XRTableCell _XrTableCell11;

	[AccessedThroughProperty("XrTableRow5")]
	private XRTableRow _XrTableRow5;

	[AccessedThroughProperty("XrTableCell15")]
	private XRTableCell _XrTableCell15;

	[AccessedThroughProperty("XrTableCell16")]
	private XRTableCell _XrTableCell16;

	[AccessedThroughProperty("XrTableCell17")]
	private XRTableCell _XrTableCell17;

	[AccessedThroughProperty("XrTableCell18")]
	private XRTableCell _XrTableCell18;

	[AccessedThroughProperty("XrTableCell24")]
	private XRTableCell _XrTableCell24;

	[AccessedThroughProperty("XrTableCell23")]
	private XRTableCell _XrTableCell23;

	[AccessedThroughProperty("XrTableRow4")]
	private XRTableRow _XrTableRow4;

	[AccessedThroughProperty("XrTableCell14")]
	private XRTableCell _XrTableCell14;

	[AccessedThroughProperty("XrTableCell44")]
	private XRTableCell _XrTableCell44;

	[AccessedThroughProperty("XrTableCell50")]
	private XRTableCell _XrTableCell50;

	[AccessedThroughProperty("XrTableCell51")]
	private XRTableCell _XrTableCell51;

	[AccessedThroughProperty("XrTableRow12")]
	private XRTableRow _XrTableRow12;

	[AccessedThroughProperty("XrTableCell53")]
	private XRTableCell _XrTableCell53;

	[AccessedThroughProperty("XrTableCell54")]
	private XRTableCell _XrTableCell54;

	[AccessedThroughProperty("XrTableCell55")]
	private XRTableCell _XrTableCell55;

	[AccessedThroughProperty("XrTableCell56")]
	private XRTableCell _XrTableCell56;

	[AccessedThroughProperty("XrTableRow6")]
	private XRTableRow _XrTableRow6;

	[AccessedThroughProperty("XrTableCell19")]
	private XRTableCell _XrTableCell19;

	[AccessedThroughProperty("XrTableCell20")]
	private XRTableCell _XrTableCell20;

	[AccessedThroughProperty("XrTableCell21")]
	private XRTableCell _XrTableCell21;

	[AccessedThroughProperty("XrTableCell22")]
	private XRTableCell _XrTableCell22;

	[AccessedThroughProperty("XrTableRow7")]
	private XRTableRow _XrTableRow7;

	[AccessedThroughProperty("XrTableCell25")]
	private XRTableCell _XrTableCell25;

	[AccessedThroughProperty("XrTableCell26")]
	private XRTableCell _XrTableCell26;

	[AccessedThroughProperty("XrTableCell27")]
	private XRTableCell _XrTableCell27;

	[AccessedThroughProperty("XrTableCell33")]
	private XRTableCell _XrTableCell33;

	[AccessedThroughProperty("XrTableCell28")]
	private XRTableCell _XrTableCell28;

	[AccessedThroughProperty("XrTableRow8")]
	private XRTableRow _XrTableRow8;

	[AccessedThroughProperty("XrTableCell29")]
	private XRTableCell _XrTableCell29;

	[AccessedThroughProperty("XrTableCell30")]
	private XRTableCell _XrTableCell30;

	[AccessedThroughProperty("XrTableCell31")]
	private XRTableCell _XrTableCell31;

	[AccessedThroughProperty("XrTableCell34")]
	private XRTableCell _XrTableCell34;

	[AccessedThroughProperty("XrTableCell32")]
	private XRTableCell _XrTableCell32;

	[AccessedThroughProperty("XrTableRow9")]
	private XRTableRow _XrTableRow9;

	[AccessedThroughProperty("XrTableCell35")]
	private XRTableCell _XrTableCell35;

	[AccessedThroughProperty("XrTableCell36")]
	private XRTableCell _XrTableCell36;

	[AccessedThroughProperty("XrTableCell37")]
	private XRTableCell _XrTableCell37;

	[AccessedThroughProperty("XrTableCell38")]
	private XRTableCell _XrTableCell38;

	[AccessedThroughProperty("XrTableRow23")]
	private XRTableRow _XrTableRow23;

	[AccessedThroughProperty("XrTableCell39")]
	private XRTableCell _XrTableCell39;

	[AccessedThroughProperty("XrTableCell97")]
	private XRTableCell _XrTableCell97;

	[AccessedThroughProperty("XrTableRow10")]
	private XRTableRow _XrTableRow10;

	[AccessedThroughProperty("XrTableCell40")]
	private XRTableCell _XrTableCell40;

	[AccessedThroughProperty("XrTableCell41")]
	private XRTableCell _XrTableCell41;

	[AccessedThroughProperty("XrTableCell42")]
	private XRTableCell _XrTableCell42;

	[AccessedThroughProperty("XrTableCell43")]
	private XRTableCell _XrTableCell43;

	[AccessedThroughProperty("XrTableRow24")]
	private XRTableRow _XrTableRow24;

	[AccessedThroughProperty("XrTableCell98")]
	private XRTableCell _XrTableCell98;

	[AccessedThroughProperty("XrTableCell99")]
	private XRTableCell _XrTableCell99;

	[AccessedThroughProperty("XrTableCell100")]
	private XRTableCell _XrTableCell100;

	[AccessedThroughProperty("XrTableCell101")]
	private XRTableCell _XrTableCell101;

	[AccessedThroughProperty("XrTableRow1")]
	private XRTableRow _XrTableRow1;

	[AccessedThroughProperty("XrTableCell1")]
	private XRTableCell _XrTableCell1;

	[AccessedThroughProperty("XrTableCell2")]
	private XRTableCell _XrTableCell2;

	[AccessedThroughProperty("XrTableCell3")]
	private XRTableCell _XrTableCell3;

	[AccessedThroughProperty("XrTableCell12")]
	private XRTableCell _XrTableCell12;

	[AccessedThroughProperty("XrTableCell13")]
	private XRTableCell _XrTableCell13;

	[AccessedThroughProperty("XrTableRow11")]
	private XRTableRow _XrTableRow11;

	[AccessedThroughProperty("XrTableCell45")]
	private XRTableCell _XrTableCell45;

	[AccessedThroughProperty("XrTableCell46")]
	private XRTableCell _XrTableCell46;

	[AccessedThroughProperty("XrTableCell47")]
	private XRTableCell _XrTableCell47;

	[AccessedThroughProperty("XrTableCell48")]
	private XRTableCell _XrTableCell48;

	[AccessedThroughProperty("XrTableCell49")]
	private XRTableCell _XrTableCell49;

	[AccessedThroughProperty("DetailReport")]
	private DetailReportBand _DetailReport;

	[AccessedThroughProperty("Detail1")]
	private DetailBand _Detail1;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

	[AccessedThroughProperty("XrLabel5")]
	private XRLabel _XrLabel5;

	[AccessedThroughProperty("XrTable6")]
	private XRTable _XrTable6;

	[AccessedThroughProperty("XrTableRow25")]
	private XRTableRow _XrTableRow25;

	[AccessedThroughProperty("XrTableCell52")]
	private XRTableCell _XrTableCell52;

	[AccessedThroughProperty("XrTableCell102")]
	private XRTableCell _XrTableCell102;

	[AccessedThroughProperty("XrTableRow29")]
	private XRTableRow _XrTableRow29;

	[AccessedThroughProperty("XrTableCell109")]
	private XRTableCell _XrTableCell109;

	[AccessedThroughProperty("XrTableCell110")]
	private XRTableCell _XrTableCell110;

	[AccessedThroughProperty("XrTableRow27")]
	private XRTableRow _XrTableRow27;

	[AccessedThroughProperty("XrTableCell105")]
	private XRTableCell _XrTableCell105;

	[AccessedThroughProperty("XrTableCell106")]
	private XRTableCell _XrTableCell106;

	[AccessedThroughProperty("XrTableRow26")]
	private XRTableRow _XrTableRow26;

	[AccessedThroughProperty("XrTableCell103")]
	private XRTableCell _XrTableCell103;

	[AccessedThroughProperty("XrTableCell104")]
	private XRTableCell _XrTableCell104;

	[AccessedThroughProperty("XrTableRow22")]
	private XRTableRow _XrTableRow22;

	[AccessedThroughProperty("XrTableCell72")]
	private XRTableCell _XrTableCell72;

	[AccessedThroughProperty("XrTableCell73")]
	private XRTableCell _XrTableCell73;

	[AccessedThroughProperty("XrTableRow31")]
	private XRTableRow _XrTableRow31;

	[AccessedThroughProperty("XrTableCell113")]
	private XRTableCell _XrTableCell113;

	[AccessedThroughProperty("XrTableCell114")]
	private XRTableCell _XrTableCell114;

	[AccessedThroughProperty("XrTableCell115")]
	private XRTableCell _XrTableCell115;

	[AccessedThroughProperty("XrTableCell116")]
	private XRTableCell _XrTableCell116;

	[AccessedThroughProperty("XrTableRow32")]
	private XRTableRow _XrTableRow32;

	[AccessedThroughProperty("XrTableCell117")]
	private XRTableCell _XrTableCell117;

	[AccessedThroughProperty("XrTableCell118")]
	private XRTableCell _XrTableCell118;

	[AccessedThroughProperty("XrTableCell119")]
	private XRTableCell _XrTableCell119;

	[AccessedThroughProperty("XrTableCell120")]
	private XRTableCell _XrTableCell120;

	[AccessedThroughProperty("XrTable4")]
	private XRTable _XrTable4;

	[AccessedThroughProperty("XrTableRow15")]
	private XRTableRow _XrTableRow15;

	[AccessedThroughProperty("XrTableCell69")]
	private XRTableCell _XrTableCell69;

	[AccessedThroughProperty("XrTableRow19")]
	private XRTableRow _XrTableRow19;

	[AccessedThroughProperty("XrTableCell81")]
	private XRTableCell _XrTableCell81;

	[AccessedThroughProperty("XrTableCell82")]
	private XRTableCell _XrTableCell82;

	[AccessedThroughProperty("XrTableCell83")]
	private XRTableCell _XrTableCell83;

	[AccessedThroughProperty("XrTableCell71")]
	private XRTableCell _XrTableCell71;

	[AccessedThroughProperty("XrTableRow18")]
	private XRTableRow _XrTableRow18;

	[AccessedThroughProperty("XrTableCell78")]
	private XRTableCell _XrTableCell78;

	[AccessedThroughProperty("XrTableCell79")]
	private XRTableCell _XrTableCell79;

	[AccessedThroughProperty("XrTableCell80")]
	private XRTableCell _XrTableCell80;

	[AccessedThroughProperty("XrTable5")]
	private XRTable _XrTable5;

	[AccessedThroughProperty("XrTableRow16")]
	private XRTableRow _XrTableRow16;

	[AccessedThroughProperty("XrTableCell70")]
	private XRTableCell _XrTableCell70;

	[AccessedThroughProperty("XrTableRow17")]
	private XRTableRow _XrTableRow17;

	[AccessedThroughProperty("XrTableCell75")]
	private XRTableCell _XrTableCell75;

	[AccessedThroughProperty("XrTableCell76")]
	private XRTableCell _XrTableCell76;

	[AccessedThroughProperty("XrTableCell77")]
	private XRTableCell _XrTableCell77;

	[AccessedThroughProperty("XrTableCell85")]
	private XRTableCell _XrTableCell85;

	[AccessedThroughProperty("XrTableRow20")]
	private XRTableRow _XrTableRow20;

	[AccessedThroughProperty("XrTableCell86")]
	private XRTableCell _XrTableCell86;

	[AccessedThroughProperty("XrTableCell87")]
	private XRTableCell _XrTableCell87;

	[AccessedThroughProperty("XrTableCell88")]
	private XRTableCell _XrTableCell88;

	[AccessedThroughProperty("XrTableCell89")]
	private XRTableCell _XrTableCell89;

	[AccessedThroughProperty("XrTableRow21")]
	private XRTableRow _XrTableRow21;

	[AccessedThroughProperty("XrTableCell90")]
	private XRTableCell _XrTableCell90;

	[AccessedThroughProperty("XrTableCell91")]
	private XRTableCell _XrTableCell91;

	[AccessedThroughProperty("XrTableCell92")]
	private XRTableCell _XrTableCell92;

	[AccessedThroughProperty("XrTableCell93")]
	private XRTableCell _XrTableCell93;

	[AccessedThroughProperty("XrLabel14")]
	private XRLabel _XrLabel14;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow13")]
	private XRTableRow _XrTableRow13;

	[AccessedThroughProperty("XrTableCell57")]
	private XRTableCell _XrTableCell57;

	[AccessedThroughProperty("XrTableCell58")]
	private XRTableCell _XrTableCell58;

	[AccessedThroughProperty("XrTableCell59")]
	private XRTableCell _XrTableCell59;

	[AccessedThroughProperty("XrTableCell60")]
	private XRTableCell _XrTableCell60;

	[AccessedThroughProperty("XrTableCell61")]
	private XRTableCell _XrTableCell61;

	[AccessedThroughProperty("XrTableCell62")]
	private XRTableCell _XrTableCell62;

	[AccessedThroughProperty("XrTable3")]
	private XRTable _XrTable3;

	[AccessedThroughProperty("XrTableRow14")]
	private XRTableRow _XrTableRow14;

	[AccessedThroughProperty("XrTableCell63")]
	private XRTableCell _XrTableCell63;

	[AccessedThroughProperty("XrTableCell64")]
	private XRTableCell _XrTableCell64;

	[AccessedThroughProperty("XrTableCell65")]
	private XRTableCell _XrTableCell65;

	[AccessedThroughProperty("XrTableCell66")]
	private XRTableCell _XrTableCell66;

	[AccessedThroughProperty("XrTableCell67")]
	private XRTableCell _XrTableCell67;

	[AccessedThroughProperty("XrTableCell68")]
	private XRTableCell _XrTableCell68;

	[AccessedThroughProperty("DetailReport1")]
	private DetailReportBand _DetailReport1;

	[AccessedThroughProperty("Detail2")]
	private DetailBand _Detail2;

	[AccessedThroughProperty("GroupHeader2")]
	private GroupHeaderBand _GroupHeader2;

	[AccessedThroughProperty("XrTable13")]
	private XRTable _XrTable13;

	[AccessedThroughProperty("XrTableRow40")]
	private XRTableRow _XrTableRow40;

	[AccessedThroughProperty("XrTableCell163")]
	private XRTableCell _XrTableCell163;

	[AccessedThroughProperty("XrTableCell164")]
	private XRTableCell _XrTableCell164;

	[AccessedThroughProperty("XrTableCell165")]
	private XRTableCell _XrTableCell165;

	[AccessedThroughProperty("XrTableCell166")]
	private XRTableCell _XrTableCell166;

	[AccessedThroughProperty("XrTableCell167")]
	private XRTableCell _XrTableCell167;

	[AccessedThroughProperty("XrTableCell168")]
	private XRTableCell _XrTableCell168;

	[AccessedThroughProperty("XrTableCell169")]
	private XRTableCell _XrTableCell169;

	[AccessedThroughProperty("XrTableCell133")]
	private XRTableCell _XrTableCell133;

	[AccessedThroughProperty("XrLabel7")]
	private XRLabel _XrLabel7;

	[AccessedThroughProperty("XrTable7")]
	private XRTable _XrTable7;

	[AccessedThroughProperty("XrTableRow30")]
	private XRTableRow _XrTableRow30;

	[AccessedThroughProperty("XrTableCell111")]
	private XRTableCell _XrTableCell111;

	[AccessedThroughProperty("XrTableCell112")]
	private XRTableCell _XrTableCell112;

	[AccessedThroughProperty("XrTableRow28")]
	private XRTableRow _XrTableRow28;

	[AccessedThroughProperty("XrTableCell74")]
	private XRTableCell _XrTableCell74;

	[AccessedThroughProperty("XrTableCell94")]
	private XRTableCell _XrTableCell94;

	[AccessedThroughProperty("XrCheckBoxJefe")]
	private XRCheckBox _XrCheckBoxJefe;

	[AccessedThroughProperty("XrTableCell95")]
	private XRTableCell _XrTableCell95;

	[AccessedThroughProperty("XrTableCell96")]
	private XRTableCell _XrTableCell96;

	[AccessedThroughProperty("XrTableRow35")]
	private XRTableRow _XrTableRow35;

	[AccessedThroughProperty("XrTableCell107")]
	private XRTableCell _XrTableCell107;

	[AccessedThroughProperty("XrTableCell108")]
	private XRTableCell _XrTableCell108;

	[AccessedThroughProperty("XrTableCell129")]
	private XRTableCell _XrTableCell129;

	[AccessedThroughProperty("XrTableCell130")]
	private XRTableCell _XrTableCell130;

	[AccessedThroughProperty("XrLabel6")]
	private XRLabel _XrLabel6;

	[AccessedThroughProperty("XrTable12")]
	private XRTable _XrTable12;

	[AccessedThroughProperty("XrTableRow39")]
	private XRTableRow _XrTableRow39;

	[AccessedThroughProperty("XrTableCell137")]
	private XRTableCell _XrTableCell137;

	[AccessedThroughProperty("XrTableCell138")]
	private XRTableCell _XrTableCell138;

	[AccessedThroughProperty("XrTableCell143")]
	private XRTableCell _XrTableCell143;

	[AccessedThroughProperty("XrTableCell144")]
	private XRTableCell _XrTableCell144;

	[AccessedThroughProperty("XrTableCell145")]
	private XRTableCell _XrTableCell145;

	[AccessedThroughProperty("XrTableCell146")]
	private XRTableCell _XrTableCell146;

	[AccessedThroughProperty("XrTableCell131")]
	private XRTableCell _XrTableCell131;

	[AccessedThroughProperty("XrCheckBoxViveCasa")]
	private XRCheckBox _XrCheckBoxViveCasa;

	[AccessedThroughProperty("XrTableCell132")]
	private XRTableCell _XrTableCell132;

	[AccessedThroughProperty("XrCheckBoxLabInst")]
	private XRCheckBox _XrCheckBoxLabInst;

	[AccessedThroughProperty("GroupFooter1")]
	private GroupFooterBand _GroupFooter1;

	[AccessedThroughProperty("XrTable9")]
	private XRTable _XrTable9;

	[AccessedThroughProperty("XrTableRow36")]
	private XRTableRow _XrTableRow36;

	[AccessedThroughProperty("XrTableCell134")]
	private XRTableCell _XrTableCell134;

	[AccessedThroughProperty("XrTableCell135")]
	private XRTableCell _XrTableCell135;

	[AccessedThroughProperty("DetailReport2")]
	private DetailReportBand _DetailReport2;

	[AccessedThroughProperty("Detail3")]
	private DetailBand _Detail3;

	[AccessedThroughProperty("GroupHeader3")]
	private GroupHeaderBand _GroupHeader3;

	[AccessedThroughProperty("XrTable16")]
	private XRTable _XrTable16;

	[AccessedThroughProperty("XrTableRow61")]
	private XRTableRow _XrTableRow61;

	[AccessedThroughProperty("XrTableCell215")]
	private XRTableCell _XrTableCell215;

	[AccessedThroughProperty("XrTableCell216")]
	private XRTableCell _XrTableCell216;

	[AccessedThroughProperty("XrTableCell217")]
	private XRTableCell _XrTableCell217;

	[AccessedThroughProperty("XrTableCell218")]
	private XRTableCell _XrTableCell218;

	[AccessedThroughProperty("XrTableCell219")]
	private XRTableCell _XrTableCell219;

	[AccessedThroughProperty("XrLabel18")]
	private XRLabel _XrLabel18;

	[AccessedThroughProperty("XrLabel17")]
	private XRLabel _XrLabel17;

	[AccessedThroughProperty("XrTable17")]
	private XRTable _XrTable17;

	[AccessedThroughProperty("XrTableRow62")]
	private XRTableRow _XrTableRow62;

	[AccessedThroughProperty("XrTableCell220")]
	private XRTableCell _XrTableCell220;

	[AccessedThroughProperty("XrTableCell221")]
	private XRTableCell _XrTableCell221;

	[AccessedThroughProperty("XrTableCell222")]
	private XRTableCell _XrTableCell222;

	[AccessedThroughProperty("XrTableCell223")]
	private XRTableCell _XrTableCell223;

	[AccessedThroughProperty("XrTableCell224")]
	private XRTableCell _XrTableCell224;

	[AccessedThroughProperty("DetailReport3")]
	private DetailReportBand _DetailReport3;

	[AccessedThroughProperty("Detail4")]
	private DetailBand _Detail4;

	[AccessedThroughProperty("GroupHeader4")]
	private GroupHeaderBand _GroupHeader4;

	[AccessedThroughProperty("XrTable18")]
	private XRTable _XrTable18;

	[AccessedThroughProperty("XrTableRow63")]
	private XRTableRow _XrTableRow63;

	[AccessedThroughProperty("XrTableCell226")]
	private XRTableCell _XrTableCell226;

	[AccessedThroughProperty("XrTableCell227")]
	private XRTableCell _XrTableCell227;

	[AccessedThroughProperty("XrTableCell228")]
	private XRTableCell _XrTableCell228;

	[AccessedThroughProperty("XrTableCell225")]
	private XRTableCell _XrTableCell225;

	[AccessedThroughProperty("XrLabel19")]
	private XRLabel _XrLabel19;

	[AccessedThroughProperty("XrTable19")]
	private XRTable _XrTable19;

	[AccessedThroughProperty("XrTableRow64")]
	private XRTableRow _XrTableRow64;

	[AccessedThroughProperty("XrTableCell229")]
	private XRTableCell _XrTableCell229;

	[AccessedThroughProperty("XrTableCell230")]
	private XRTableCell _XrTableCell230;

	[AccessedThroughProperty("XrTableCell231")]
	private XRTableCell _XrTableCell231;

	[AccessedThroughProperty("XrTableCell232")]
	private XRTableCell _XrTableCell232;

	[AccessedThroughProperty("DetailReport4")]
	private DetailReportBand _DetailReport4;

	[AccessedThroughProperty("Detail5")]
	private DetailBand _Detail5;

	[AccessedThroughProperty("GroupHeader5")]
	private GroupHeaderBand _GroupHeader5;

	[AccessedThroughProperty("XrTable20")]
	private XRTable _XrTable20;

	[AccessedThroughProperty("XrTableRow65")]
	private XRTableRow _XrTableRow65;

	[AccessedThroughProperty("XrTableCell233")]
	private XRTableCell _XrTableCell233;

	[AccessedThroughProperty("XrTableCell234")]
	private XRTableCell _XrTableCell234;

	[AccessedThroughProperty("XrTableCell235")]
	private XRTableCell _XrTableCell235;

	[AccessedThroughProperty("XrTableCell236")]
	private XRTableCell _XrTableCell236;

	[AccessedThroughProperty("XrTableCell237")]
	private XRTableCell _XrTableCell237;

	[AccessedThroughProperty("XrLabel20")]
	private XRLabel _XrLabel20;

	[AccessedThroughProperty("XrTable21")]
	private XRTable _XrTable21;

	[AccessedThroughProperty("XrTableRow66")]
	private XRTableRow _XrTableRow66;

	[AccessedThroughProperty("XrTableCell238")]
	private XRTableCell _XrTableCell238;

	[AccessedThroughProperty("XrTableCell239")]
	private XRTableCell _XrTableCell239;

	[AccessedThroughProperty("XrTableCell240")]
	private XRTableCell _XrTableCell240;

	[AccessedThroughProperty("XrTableCell241")]
	private XRTableCell _XrTableCell241;

	[AccessedThroughProperty("XrTableCell242")]
	private XRTableCell _XrTableCell242;

	[AccessedThroughProperty("XrPageInfo1")]
	private XRPageInfo _XrPageInfo1;

	[AccessedThroughProperty("GroupFooter2")]
	private GroupFooterBand _GroupFooter2;

	[AccessedThroughProperty("XrPictureBox1")]
	private XRPictureBox _XrPictureBox1;

	[AccessedThroughProperty("DetailReport5")]
	private DetailReportBand _DetailReport5;

	[AccessedThroughProperty("Detail6")]
	private DetailBand _Detail6;

	[AccessedThroughProperty("GroupHeader6")]
	private GroupHeaderBand _GroupHeader6;

	[AccessedThroughProperty("XrTable10")]
	private XRTable _XrTable10;

	[AccessedThroughProperty("XrTableRow37")]
	private XRTableRow _XrTableRow37;

	[AccessedThroughProperty("XrTableCell84")]
	private XRTableCell _XrTableCell84;

	[AccessedThroughProperty("XrTableCell121")]
	private XRTableCell _XrTableCell121;

	[AccessedThroughProperty("XrTableCell124")]
	private XRTableCell _XrTableCell124;

	[AccessedThroughProperty("XrTableCell125")]
	private XRTableCell _XrTableCell125;

	[AccessedThroughProperty("XrTableCell128")]
	private XRTableCell _XrTableCell128;

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrTable11")]
	private XRTable _XrTable11;

	[AccessedThroughProperty("XrTableRow38")]
	private XRTableRow _XrTableRow38;

	[AccessedThroughProperty("XrTableCell136")]
	private XRTableCell _XrTableCell136;

	[AccessedThroughProperty("XrTableCell139")]
	private XRTableCell _XrTableCell139;

	[AccessedThroughProperty("XrTableCell142")]
	private XRTableCell _XrTableCell142;

	[AccessedThroughProperty("XrTableCell140")]
	private XRTableCell _XrTableCell140;

	[AccessedThroughProperty("XrTableCell141")]
	private XRTableCell _XrTableCell141;

	[AccessedThroughProperty("GroupFooter3")]
	private GroupFooterBand _GroupFooter3;

	[AccessedThroughProperty("SpRRHH_busca_DisciplinaTableAdapter")]
	private spRRHH_busca_DisciplinaTableAdapter _SpRRHH_busca_DisciplinaTableAdapter;

	[AccessedThroughProperty("XrPageInfo2")]
	private XRPageInfo _XrPageInfo2;

	[AccessedThroughProperty("XrLabel9")]
	private XRLabel _XrLabel9;

	[AccessedThroughProperty("TopMarginBand1")]
	private TopMarginBand _TopMarginBand1;

	[AccessedThroughProperty("BottomMarginBand1")]
	private BottomMarginBand _BottomMarginBand1;

	internal DetailBand Detail
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail = value;
		}
	}

	internal PageHeaderBand PageHeader
	{
		[DebuggerNonUserCode]
		get
		{
			return _PageHeader;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PageHeader = value;
		}
	}

	internal PageFooterBand PageFooter
	{
		[DebuggerNonUserCode]
		get
		{
			return _PageFooter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PageFooter = value;
		}
	}

	internal XRLabel XrLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel1 = value;
		}
	}

	internal DataSet1 DataSet11
	{
		[DebuggerNonUserCode]
		get
		{
			return _DataSet11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DataSet11 = value;
		}
	}

	internal spRRHH_Ficha_ExpLabTableAdapter SpRRHH_Ficha_ExpLabTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_Ficha_ExpLabTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_Ficha_ExpLabTableAdapter = value;
		}
	}

	internal XRLabel XrLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel2 = value;
		}
	}

	internal XRTable XrTable8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable8 = value;
		}
	}

	internal XRTableRow XrTableRow33
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow33 = value;
		}
	}

	internal XRTableCell XrTableCell122
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell122;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell122 = value;
		}
	}

	internal XRTableCell XrTableCell127
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell127;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell127 = value;
		}
	}

	internal XRTableRow XrTableRow34
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow34 = value;
		}
	}

	internal XRTableCell XrTableCell123
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell123;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell123 = value;
		}
	}

	internal XRTableCell XrTableCell126
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell126;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell126 = value;
		}
	}

	internal XRLabel XrLabel8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel8 = value;
		}
	}

	internal XRLabel XrLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel4 = value;
		}
	}

	internal XRTable XrTable2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable2 = value;
		}
	}

	internal XRTableRow XrTableRow2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow2 = value;
		}
	}

	internal XRTableCell XrTableCell7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell7 = value;
		}
	}

	internal XRTableCell XrTableCell4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell4 = value;
		}
	}

	internal XRTableCell XrTableCell5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell5 = value;
		}
	}

	internal XRTableCell XrTableCell6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell6 = value;
		}
	}

	internal XRTableRow XrTableRow3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow3 = value;
		}
	}

	internal XRTableCell XrTableCell8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell8 = value;
		}
	}

	internal XRTableCell XrTableCell9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell9 = value;
		}
	}

	internal XRTableCell XrTableCell10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell10 = value;
		}
	}

	internal XRTableCell XrTableCell11
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell11 = value;
		}
	}

	internal XRTableRow XrTableRow5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow5 = value;
		}
	}

	internal XRTableCell XrTableCell15
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell15 = value;
		}
	}

	internal XRTableCell XrTableCell16
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell16 = value;
		}
	}

	internal XRTableCell XrTableCell17
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell17 = value;
		}
	}

	internal XRTableCell XrTableCell18
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell18 = value;
		}
	}

	internal XRTableCell XrTableCell24
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell24 = value;
		}
	}

	internal XRTableCell XrTableCell23
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell23 = value;
		}
	}

	internal XRTableRow XrTableRow4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow4 = value;
		}
	}

	internal XRTableCell XrTableCell14
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell14 = value;
		}
	}

	internal XRTableCell XrTableCell44
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell44 = value;
		}
	}

	internal XRTableCell XrTableCell50
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell50 = value;
		}
	}

	internal XRTableCell XrTableCell51
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell51 = value;
		}
	}

	internal XRTableRow XrTableRow12
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow12 = value;
		}
	}

	internal XRTableCell XrTableCell53
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell53 = value;
		}
	}

	internal XRTableCell XrTableCell54
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell54 = value;
		}
	}

	internal XRTableCell XrTableCell55
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell55 = value;
		}
	}

	internal XRTableCell XrTableCell56
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell56 = value;
		}
	}

	internal XRTableRow XrTableRow6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow6 = value;
		}
	}

	internal XRTableCell XrTableCell19
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell19 = value;
		}
	}

	internal XRTableCell XrTableCell20
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell20 = value;
		}
	}

	internal XRTableCell XrTableCell21
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell21 = value;
		}
	}

	internal XRTableCell XrTableCell22
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell22 = value;
		}
	}

	internal XRTableRow XrTableRow7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow7 = value;
		}
	}

	internal XRTableCell XrTableCell25
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell25 = value;
		}
	}

	internal XRTableCell XrTableCell26
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell26 = value;
		}
	}

	internal XRTableCell XrTableCell27
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell27 = value;
		}
	}

	internal XRTableCell XrTableCell33
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell33 = value;
		}
	}

	internal XRTableCell XrTableCell28
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell28 = value;
		}
	}

	internal XRTableRow XrTableRow8
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow8 = value;
		}
	}

	internal XRTableCell XrTableCell29
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell29 = value;
		}
	}

	internal XRTableCell XrTableCell30
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell30 = value;
		}
	}

	internal XRTableCell XrTableCell31
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell31 = value;
		}
	}

	internal XRTableCell XrTableCell34
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell34 = value;
		}
	}

	internal XRTableCell XrTableCell32
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell32 = value;
		}
	}

	internal XRTableRow XrTableRow9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow9 = value;
		}
	}

	internal XRTableCell XrTableCell35
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell35 = value;
		}
	}

	internal XRTableCell XrTableCell36
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell36 = value;
		}
	}

	internal XRTableCell XrTableCell37
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell37 = value;
		}
	}

	internal XRTableCell XrTableCell38
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell38 = value;
		}
	}

	internal XRTableRow XrTableRow23
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow23 = value;
		}
	}

	internal XRTableCell XrTableCell39
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell39 = value;
		}
	}

	internal XRTableCell XrTableCell97
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell97;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell97 = value;
		}
	}

	internal XRTableRow XrTableRow10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow10 = value;
		}
	}

	internal XRTableCell XrTableCell40
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell40 = value;
		}
	}

	internal XRTableCell XrTableCell41
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell41 = value;
		}
	}

	internal XRTableCell XrTableCell42
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell42 = value;
		}
	}

	internal XRTableCell XrTableCell43
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell43 = value;
		}
	}

	internal XRTableRow XrTableRow24
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow24 = value;
		}
	}

	internal XRTableCell XrTableCell98
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell98 = value;
		}
	}

	internal XRTableCell XrTableCell99
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell99;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell99 = value;
		}
	}

	internal XRTableCell XrTableCell100
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell100 = value;
		}
	}

	internal XRTableCell XrTableCell101
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell101 = value;
		}
	}

	internal XRTableRow XrTableRow1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow1 = value;
		}
	}

	internal XRTableCell XrTableCell1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell1 = value;
		}
	}

	internal XRTableCell XrTableCell2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell2 = value;
		}
	}

	internal XRTableCell XrTableCell3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell3 = value;
		}
	}

	internal XRTableCell XrTableCell12
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell12 = value;
		}
	}

	internal XRTableCell XrTableCell13
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell13 = value;
		}
	}

	internal XRTableRow XrTableRow11
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow11 = value;
		}
	}

	internal XRTableCell XrTableCell45
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell45 = value;
		}
	}

	internal XRTableCell XrTableCell46
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell46 = value;
		}
	}

	internal XRTableCell XrTableCell47
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell47 = value;
		}
	}

	internal XRTableCell XrTableCell48
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell48 = value;
		}
	}

	internal XRTableCell XrTableCell49
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell49 = value;
		}
	}

	internal DetailReportBand DetailReport
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport = value;
		}
	}

	internal DetailBand Detail1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail1 = value;
		}
	}

	internal GroupHeaderBand GroupHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader1 = value;
		}
	}

	internal XRLabel XrLabel5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel5 = value;
		}
	}

	internal XRTable XrTable6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable6 = value;
		}
	}

	internal XRTableRow XrTableRow25
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow25 = value;
		}
	}

	internal XRTableCell XrTableCell52
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell52 = value;
		}
	}

	internal XRTableCell XrTableCell102
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell102;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell102 = value;
		}
	}

	internal XRTableRow XrTableRow29
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow29 = value;
		}
	}

	internal XRTableCell XrTableCell109
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell109;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell109 = value;
		}
	}

	internal XRTableCell XrTableCell110
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell110;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell110 = value;
		}
	}

	internal XRTableRow XrTableRow27
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow27 = value;
		}
	}

	internal XRTableCell XrTableCell105
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell105;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell105 = value;
		}
	}

	internal XRTableCell XrTableCell106
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell106;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell106 = value;
		}
	}

	internal XRTableRow XrTableRow26
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow26 = value;
		}
	}

	internal XRTableCell XrTableCell103
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell103;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell103 = value;
		}
	}

	internal XRTableCell XrTableCell104
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell104;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell104 = value;
		}
	}

	internal XRTableRow XrTableRow22
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow22 = value;
		}
	}

	internal XRTableCell XrTableCell72
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell72 = value;
		}
	}

	internal XRTableCell XrTableCell73
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell73 = value;
		}
	}

	internal XRTableRow XrTableRow31
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow31 = value;
		}
	}

	internal XRTableCell XrTableCell113
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell113;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell113 = value;
		}
	}

	internal XRTableCell XrTableCell114
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell114;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell114 = value;
		}
	}

	internal XRTableCell XrTableCell115
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell115;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell115 = value;
		}
	}

	internal XRTableCell XrTableCell116
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell116;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell116 = value;
		}
	}

	internal XRTableRow XrTableRow32
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow32 = value;
		}
	}

	internal XRTableCell XrTableCell117
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell117;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell117 = value;
		}
	}

	internal XRTableCell XrTableCell118
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell118;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell118 = value;
		}
	}

	internal XRTableCell XrTableCell119
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell119;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell119 = value;
		}
	}

	internal XRTableCell XrTableCell120
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell120;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell120 = value;
		}
	}

	internal XRTable XrTable4
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable4 = value;
		}
	}

	internal XRTableRow XrTableRow15
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow15 = value;
		}
	}

	internal XRTableCell XrTableCell69
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell69 = value;
		}
	}

	internal XRTableRow XrTableRow19
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow19 = value;
		}
	}

	internal XRTableCell XrTableCell81
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell81 = value;
		}
	}

	internal XRTableCell XrTableCell82
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell82 = value;
		}
	}

	internal XRTableCell XrTableCell83
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell83 = value;
		}
	}

	internal XRTableCell XrTableCell71
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell71 = value;
		}
	}

	internal XRTableRow XrTableRow18
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow18 = value;
		}
	}

	internal XRTableCell XrTableCell78
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell78 = value;
		}
	}

	internal XRTableCell XrTableCell79
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell79 = value;
		}
	}

	internal XRTableCell XrTableCell80
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell80 = value;
		}
	}

	internal XRTable XrTable5
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable5 = value;
		}
	}

	internal XRTableRow XrTableRow16
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow16 = value;
		}
	}

	internal XRTableCell XrTableCell70
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell70 = value;
		}
	}

	internal XRTableRow XrTableRow17
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow17 = value;
		}
	}

	internal XRTableCell XrTableCell75
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell75 = value;
		}
	}

	internal XRTableCell XrTableCell76
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell76 = value;
		}
	}

	internal XRTableCell XrTableCell77
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell77 = value;
		}
	}

	internal XRTableCell XrTableCell85
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell85 = value;
		}
	}

	internal XRTableRow XrTableRow20
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow20 = value;
		}
	}

	internal XRTableCell XrTableCell86
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell86 = value;
		}
	}

	internal XRTableCell XrTableCell87
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell87 = value;
		}
	}

	internal XRTableCell XrTableCell88
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell88 = value;
		}
	}

	internal XRTableCell XrTableCell89
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell89 = value;
		}
	}

	internal XRTableRow XrTableRow21
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow21 = value;
		}
	}

	internal XRTableCell XrTableCell90
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell90 = value;
		}
	}

	internal XRTableCell XrTableCell91
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell91 = value;
		}
	}

	internal XRTableCell XrTableCell92
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell92;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell92 = value;
		}
	}

	internal XRTableCell XrTableCell93
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell93;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell93 = value;
		}
	}

	internal XRLabel XrLabel14
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel14 = value;
		}
	}

	internal XRTable XrTable1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable1 = value;
		}
	}

	internal XRTableRow XrTableRow13
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow13 = value;
		}
	}

	internal XRTableCell XrTableCell57
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell57 = value;
		}
	}

	internal XRTableCell XrTableCell58
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell58 = value;
		}
	}

	internal XRTableCell XrTableCell59
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell59 = value;
		}
	}

	internal XRTableCell XrTableCell60
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell60 = value;
		}
	}

	internal XRTableCell XrTableCell61
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell61 = value;
		}
	}

	internal XRTableCell XrTableCell62
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell62 = value;
		}
	}

	internal XRTable XrTable3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable3 = value;
		}
	}

	internal XRTableRow XrTableRow14
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow14 = value;
		}
	}

	internal XRTableCell XrTableCell63
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell63 = value;
		}
	}

	internal XRTableCell XrTableCell64
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell64 = value;
		}
	}

	internal XRTableCell XrTableCell65
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell65 = value;
		}
	}

	internal XRTableCell XrTableCell66
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell66 = value;
		}
	}

	internal XRTableCell XrTableCell67
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell67 = value;
		}
	}

	internal XRTableCell XrTableCell68
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell68 = value;
		}
	}

	internal DetailReportBand DetailReport1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport1 = value;
		}
	}

	internal DetailBand Detail2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail2 = value;
		}
	}

	internal GroupHeaderBand GroupHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader2 = value;
		}
	}

	internal XRTable XrTable13
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable13 = value;
		}
	}

	internal XRTableRow XrTableRow40
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow40 = value;
		}
	}

	internal XRTableCell XrTableCell163
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell163;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell163 = value;
		}
	}

	internal XRTableCell XrTableCell164
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell164;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell164 = value;
		}
	}

	internal XRTableCell XrTableCell165
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell165;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell165 = value;
		}
	}

	internal XRTableCell XrTableCell166
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell166;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell166 = value;
		}
	}

	internal XRTableCell XrTableCell167
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell167;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell167 = value;
		}
	}

	internal XRTableCell XrTableCell168
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell168;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell168 = value;
		}
	}

	internal XRTableCell XrTableCell169
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell169;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell169 = value;
		}
	}

	internal XRTableCell XrTableCell133
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell133;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell133 = value;
		}
	}

	internal XRLabel XrLabel7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel7 = value;
		}
	}

	internal XRTable XrTable7
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable7 = value;
		}
	}

	internal XRTableRow XrTableRow30
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow30 = value;
		}
	}

	internal XRTableCell XrTableCell111
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell111;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell111 = value;
		}
	}

	internal XRTableCell XrTableCell112
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell112;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell112 = value;
		}
	}

	internal XRTableRow XrTableRow28
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow28 = value;
		}
	}

	internal XRTableCell XrTableCell74
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell74 = value;
		}
	}

	internal XRTableCell XrTableCell94
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell94;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell94 = value;
		}
	}

	internal XRCheckBox XrCheckBoxJefe
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxJefe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxJefe = value;
		}
	}

	internal XRTableCell XrTableCell95
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell95;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell95 = value;
		}
	}

	internal XRTableCell XrTableCell96
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell96;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell96 = value;
		}
	}

	internal XRTableRow XrTableRow35
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow35 = value;
		}
	}

	internal XRTableCell XrTableCell107
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell107;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell107 = value;
		}
	}

	internal XRTableCell XrTableCell108
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell108;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell108 = value;
		}
	}

	internal XRTableCell XrTableCell129
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell129;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell129 = value;
		}
	}

	internal XRTableCell XrTableCell130
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell130;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell130 = value;
		}
	}

	internal XRLabel XrLabel6
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel6 = value;
		}
	}

	internal XRTable XrTable12
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable12 = value;
		}
	}

	internal XRTableRow XrTableRow39
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow39 = value;
		}
	}

	internal XRTableCell XrTableCell137
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell137;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell137 = value;
		}
	}

	internal XRTableCell XrTableCell138
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell138;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell138 = value;
		}
	}

	internal XRTableCell XrTableCell143
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell143;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell143 = value;
		}
	}

	internal XRTableCell XrTableCell144
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell144;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell144 = value;
		}
	}

	internal XRTableCell XrTableCell145
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell145;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell145 = value;
		}
	}

	internal XRTableCell XrTableCell146
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell146;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell146 = value;
		}
	}

	internal XRTableCell XrTableCell131
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell131;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell131 = value;
		}
	}

	internal XRCheckBox XrCheckBoxViveCasa
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxViveCasa;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxViveCasa = value;
		}
	}

	internal XRTableCell XrTableCell132
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell132;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell132 = value;
		}
	}

	internal XRCheckBox XrCheckBoxLabInst
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxLabInst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxLabInst = value;
		}
	}

	internal GroupFooterBand GroupFooter1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupFooter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupFooter1 = value;
		}
	}

	internal XRTable XrTable9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable9 = value;
		}
	}

	internal XRTableRow XrTableRow36
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow36 = value;
		}
	}

	internal XRTableCell XrTableCell134
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell134;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell134 = value;
		}
	}

	internal XRTableCell XrTableCell135
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell135;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell135 = value;
		}
	}

	internal DetailReportBand DetailReport2
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport2 = value;
		}
	}

	internal DetailBand Detail3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail3 = value;
		}
	}

	internal GroupHeaderBand GroupHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader3 = value;
		}
	}

	internal XRTable XrTable16
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable16 = value;
		}
	}

	internal XRTableRow XrTableRow61
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow61 = value;
		}
	}

	internal XRTableCell XrTableCell215
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell215;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell215 = value;
		}
	}

	internal XRTableCell XrTableCell216
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell216;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell216 = value;
		}
	}

	internal XRTableCell XrTableCell217
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell217;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell217 = value;
		}
	}

	internal XRTableCell XrTableCell218
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell218;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell218 = value;
		}
	}

	internal XRTableCell XrTableCell219
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell219;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell219 = value;
		}
	}

	internal XRLabel XrLabel18
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel18 = value;
		}
	}

	internal XRLabel XrLabel17
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel17 = value;
		}
	}

	internal XRTable XrTable17
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable17 = value;
		}
	}

	internal XRTableRow XrTableRow62
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow62 = value;
		}
	}

	internal XRTableCell XrTableCell220
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell220;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell220 = value;
		}
	}

	internal XRTableCell XrTableCell221
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell221;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell221 = value;
		}
	}

	internal XRTableCell XrTableCell222
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell222;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell222 = value;
		}
	}

	internal XRTableCell XrTableCell223
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell223;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell223 = value;
		}
	}

	internal XRTableCell XrTableCell224
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell224;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell224 = value;
		}
	}

	internal DetailReportBand DetailReport3
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport3 = value;
		}
	}

	internal DetailBand Detail4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail4 = value;
		}
	}

	internal GroupHeaderBand GroupHeader4
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader4 = value;
		}
	}

	internal XRTable XrTable18
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable18 = value;
		}
	}

	internal XRTableRow XrTableRow63
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow63 = value;
		}
	}

	internal XRTableCell XrTableCell226
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell226;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell226 = value;
		}
	}

	internal XRTableCell XrTableCell227
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell227;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell227 = value;
		}
	}

	internal XRTableCell XrTableCell228
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell228;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell228 = value;
		}
	}

	internal XRTableCell XrTableCell225
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell225;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell225 = value;
		}
	}

	internal XRLabel XrLabel19
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel19 = value;
		}
	}

	internal XRTable XrTable19
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable19 = value;
		}
	}

	internal XRTableRow XrTableRow64
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow64 = value;
		}
	}

	internal XRTableCell XrTableCell229
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell229;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell229 = value;
		}
	}

	internal XRTableCell XrTableCell230
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell230;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell230 = value;
		}
	}

	internal XRTableCell XrTableCell231
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell231;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell231 = value;
		}
	}

	internal XRTableCell XrTableCell232
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell232;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell232 = value;
		}
	}

	internal DetailReportBand DetailReport4
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport4 = value;
		}
	}

	internal DetailBand Detail5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail5 = value;
		}
	}

	internal GroupHeaderBand GroupHeader5
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader5 = value;
		}
	}

	internal XRTable XrTable20
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable20 = value;
		}
	}

	internal XRTableRow XrTableRow65
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow65 = value;
		}
	}

	internal XRTableCell XrTableCell233
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell233;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell233 = value;
		}
	}

	internal XRTableCell XrTableCell234
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell234;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell234 = value;
		}
	}

	internal XRTableCell XrTableCell235
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell235;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell235 = value;
		}
	}

	internal XRTableCell XrTableCell236
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell236;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell236 = value;
		}
	}

	internal XRTableCell XrTableCell237
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell237;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell237 = value;
		}
	}

	internal XRLabel XrLabel20
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel20 = value;
		}
	}

	internal XRTable XrTable21
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable21 = value;
		}
	}

	internal XRTableRow XrTableRow66
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow66 = value;
		}
	}

	internal XRTableCell XrTableCell238
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell238;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell238 = value;
		}
	}

	internal XRTableCell XrTableCell239
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell239;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell239 = value;
		}
	}

	internal XRTableCell XrTableCell240
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell240;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell240 = value;
		}
	}

	internal XRTableCell XrTableCell241
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell241;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell241 = value;
		}
	}

	internal XRTableCell XrTableCell242
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell242;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell242 = value;
		}
	}

	internal XRPageInfo XrPageInfo1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrPageInfo1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrPageInfo1 = value;
		}
	}

	internal GroupFooterBand GroupFooter2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupFooter2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupFooter2 = value;
		}
	}

	internal XRPictureBox XrPictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrPictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrPictureBox1 = value;
		}
	}

	internal DetailReportBand DetailReport5
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport5 = value;
		}
	}

	internal DetailBand Detail6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail6 = value;
		}
	}

	internal GroupHeaderBand GroupHeader6
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader6 = value;
		}
	}

	internal XRTable XrTable10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable10 = value;
		}
	}

	internal XRTableRow XrTableRow37
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow37 = value;
		}
	}

	internal XRTableCell XrTableCell84
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell84 = value;
		}
	}

	internal XRTableCell XrTableCell121
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell121;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell121 = value;
		}
	}

	internal XRTableCell XrTableCell124
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell124;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell124 = value;
		}
	}

	internal XRTableCell XrTableCell125
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell125;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell125 = value;
		}
	}

	internal XRTableCell XrTableCell128
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell128;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell128 = value;
		}
	}

	internal XRLabel XrLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel3 = value;
		}
	}

	internal XRTable XrTable11
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable11 = value;
		}
	}

	internal XRTableRow XrTableRow38
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow38 = value;
		}
	}

	internal XRTableCell XrTableCell136
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell136;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell136 = value;
		}
	}

	internal XRTableCell XrTableCell139
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell139;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell139 = value;
		}
	}

	internal XRTableCell XrTableCell142
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell142;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell142 = value;
		}
	}

	internal XRTableCell XrTableCell140
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell140;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell140 = value;
		}
	}

	internal XRTableCell XrTableCell141
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell141;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell141 = value;
		}
	}

	internal GroupFooterBand GroupFooter3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupFooter3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupFooter3 = value;
		}
	}

	internal spRRHH_busca_DisciplinaTableAdapter SpRRHH_busca_DisciplinaTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_busca_DisciplinaTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_busca_DisciplinaTableAdapter = value;
		}
	}

	internal XRPageInfo XrPageInfo2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrPageInfo2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrPageInfo2 = value;
		}
	}

	internal XRLabel XrLabel9
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel9 = value;
		}
	}

	internal TopMarginBand TopMarginBand1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TopMarginBand1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TopMarginBand1 = value;
		}
	}

	internal BottomMarginBand BottomMarginBand1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BottomMarginBand1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BottomMarginBand1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Report_Ficha_Escalaf()
	{
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Detail = new DetailBand();
		XrPictureBox1 = new XRPictureBox();
		XrTable8 = new XRTable();
		XrTableRow33 = new XRTableRow();
		XrTableCell122 = new XRTableCell();
		XrTableCell127 = new XRTableCell();
		XrTableRow34 = new XRTableRow();
		XrTableCell123 = new XRTableCell();
		XrTableCell126 = new XRTableCell();
		XrLabel8 = new XRLabel();
		XrLabel4 = new XRLabel();
		XrTable2 = new XRTable();
		XrTableRow2 = new XRTableRow();
		XrTableCell7 = new XRTableCell();
		XrTableCell4 = new XRTableCell();
		XrTableCell5 = new XRTableCell();
		XrTableCell6 = new XRTableCell();
		XrTableRow3 = new XRTableRow();
		XrTableCell8 = new XRTableCell();
		XrTableCell9 = new XRTableCell();
		XrTableCell10 = new XRTableCell();
		XrTableCell11 = new XRTableCell();
		XrTableRow5 = new XRTableRow();
		XrTableCell15 = new XRTableCell();
		XrTableCell16 = new XRTableCell();
		XrTableCell17 = new XRTableCell();
		XrTableCell18 = new XRTableCell();
		XrTableCell24 = new XRTableCell();
		XrTableCell23 = new XRTableCell();
		XrTableRow4 = new XRTableRow();
		XrTableCell14 = new XRTableCell();
		XrTableCell44 = new XRTableCell();
		XrTableCell50 = new XRTableCell();
		XrTableCell51 = new XRTableCell();
		XrTableRow12 = new XRTableRow();
		XrTableCell53 = new XRTableCell();
		XrTableCell54 = new XRTableCell();
		XrTableCell55 = new XRTableCell();
		XrTableCell56 = new XRTableCell();
		XrTableRow6 = new XRTableRow();
		XrTableCell19 = new XRTableCell();
		XrTableCell20 = new XRTableCell();
		XrTableCell21 = new XRTableCell();
		XrTableCell22 = new XRTableCell();
		XrTableRow7 = new XRTableRow();
		XrTableCell25 = new XRTableCell();
		XrTableCell26 = new XRTableCell();
		XrTableCell27 = new XRTableCell();
		XrTableCell33 = new XRTableCell();
		XrTableCell28 = new XRTableCell();
		XrTableRow8 = new XRTableRow();
		XrTableCell29 = new XRTableCell();
		XrTableCell30 = new XRTableCell();
		XrTableCell31 = new XRTableCell();
		XrTableCell34 = new XRTableCell();
		XrTableCell32 = new XRTableCell();
		XrTableRow9 = new XRTableRow();
		XrTableCell35 = new XRTableCell();
		XrTableCell36 = new XRTableCell();
		XrTableCell37 = new XRTableCell();
		XrTableCell38 = new XRTableCell();
		XrTableRow23 = new XRTableRow();
		XrTableCell39 = new XRTableCell();
		XrTableCell97 = new XRTableCell();
		XrTableRow10 = new XRTableRow();
		XrTableCell40 = new XRTableCell();
		XrTableCell41 = new XRTableCell();
		XrTableCell42 = new XRTableCell();
		XrTableCell43 = new XRTableCell();
		XrTableRow24 = new XRTableRow();
		XrTableCell98 = new XRTableCell();
		XrTableCell99 = new XRTableCell();
		XrTableCell100 = new XRTableCell();
		XrTableCell101 = new XRTableCell();
		XrTableRow1 = new XRTableRow();
		XrTableCell1 = new XRTableCell();
		XrTableCell2 = new XRTableCell();
		XrTableCell3 = new XRTableCell();
		XrTableCell12 = new XRTableCell();
		XrTableCell13 = new XRTableCell();
		XrTableRow11 = new XRTableRow();
		XrTableCell45 = new XRTableCell();
		XrTableCell46 = new XRTableCell();
		XrTableCell47 = new XRTableCell();
		XrTableCell48 = new XRTableCell();
		XrTableCell49 = new XRTableCell();
		XrLabel2 = new XRLabel();
		XrLabel1 = new XRLabel();
		PageHeader = new PageHeaderBand();
		PageFooter = new PageFooterBand();
		XrPageInfo2 = new XRPageInfo();
		XrLabel9 = new XRLabel();
		XrPageInfo1 = new XRPageInfo();
		DataSet11 = new DataSet1();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		DetailReport = new DetailReportBand();
		Detail1 = new DetailBand();
		XrTable3 = new XRTable();
		XrTableRow14 = new XRTableRow();
		XrTableCell63 = new XRTableCell();
		XrTableCell64 = new XRTableCell();
		XrTableCell65 = new XRTableCell();
		XrTableCell66 = new XRTableCell();
		XrTableCell67 = new XRTableCell();
		XrTableCell68 = new XRTableCell();
		GroupHeader1 = new GroupHeaderBand();
		XrLabel5 = new XRLabel();
		XrTable6 = new XRTable();
		XrTableRow25 = new XRTableRow();
		XrTableCell52 = new XRTableCell();
		XrTableCell102 = new XRTableCell();
		XrTableRow29 = new XRTableRow();
		XrTableCell109 = new XRTableCell();
		XrTableCell110 = new XRTableCell();
		XrTableRow27 = new XRTableRow();
		XrTableCell105 = new XRTableCell();
		XrTableCell106 = new XRTableCell();
		XrTableRow26 = new XRTableRow();
		XrTableCell103 = new XRTableCell();
		XrTableCell104 = new XRTableCell();
		XrTableRow22 = new XRTableRow();
		XrTableCell72 = new XRTableCell();
		XrTableCell73 = new XRTableCell();
		XrTableRow31 = new XRTableRow();
		XrTableCell113 = new XRTableCell();
		XrTableCell114 = new XRTableCell();
		XrTableCell115 = new XRTableCell();
		XrTableCell116 = new XRTableCell();
		XrTableRow32 = new XRTableRow();
		XrTableCell117 = new XRTableCell();
		XrTableCell118 = new XRTableCell();
		XrTableCell119 = new XRTableCell();
		XrTableCell120 = new XRTableCell();
		XrTable4 = new XRTable();
		XrTableRow15 = new XRTableRow();
		XrTableCell69 = new XRTableCell();
		XrTableRow19 = new XRTableRow();
		XrTableCell81 = new XRTableCell();
		XrTableCell82 = new XRTableCell();
		XrTableCell83 = new XRTableCell();
		XrTableCell71 = new XRTableCell();
		XrTableRow18 = new XRTableRow();
		XrTableCell78 = new XRTableCell();
		XrTableCell79 = new XRTableCell();
		XrTableCell80 = new XRTableCell();
		XrTable5 = new XRTable();
		XrTableRow16 = new XRTableRow();
		XrTableCell70 = new XRTableCell();
		XrTableRow17 = new XRTableRow();
		XrTableCell75 = new XRTableCell();
		XrTableCell76 = new XRTableCell();
		XrTableCell77 = new XRTableCell();
		XrTableCell85 = new XRTableCell();
		XrTableRow20 = new XRTableRow();
		XrTableCell86 = new XRTableCell();
		XrTableCell87 = new XRTableCell();
		XrTableCell88 = new XRTableCell();
		XrTableCell89 = new XRTableCell();
		XrTableRow21 = new XRTableRow();
		XrTableCell90 = new XRTableCell();
		XrTableCell91 = new XRTableCell();
		XrTableCell92 = new XRTableCell();
		XrTableCell93 = new XRTableCell();
		XrLabel14 = new XRLabel();
		XrTable1 = new XRTable();
		XrTableRow13 = new XRTableRow();
		XrTableCell57 = new XRTableCell();
		XrTableCell58 = new XRTableCell();
		XrTableCell59 = new XRTableCell();
		XrTableCell60 = new XRTableCell();
		XrTableCell61 = new XRTableCell();
		XrTableCell62 = new XRTableCell();
		DetailReport1 = new DetailReportBand();
		Detail2 = new DetailBand();
		XrTable12 = new XRTable();
		XrTableRow39 = new XRTableRow();
		XrTableCell137 = new XRTableCell();
		XrTableCell138 = new XRTableCell();
		XrTableCell143 = new XRTableCell();
		XrTableCell144 = new XRTableCell();
		XrTableCell145 = new XRTableCell();
		XrTableCell146 = new XRTableCell();
		XrTableCell131 = new XRTableCell();
		XrCheckBoxViveCasa = new XRCheckBox();
		XrTableCell132 = new XRTableCell();
		XrCheckBoxLabInst = new XRCheckBox();
		GroupHeader2 = new GroupHeaderBand();
		XrTable13 = new XRTable();
		XrTableRow40 = new XRTableRow();
		XrTableCell163 = new XRTableCell();
		XrTableCell164 = new XRTableCell();
		XrTableCell165 = new XRTableCell();
		XrTableCell166 = new XRTableCell();
		XrTableCell167 = new XRTableCell();
		XrTableCell168 = new XRTableCell();
		XrTableCell169 = new XRTableCell();
		XrTableCell133 = new XRTableCell();
		XrLabel7 = new XRLabel();
		XrTable7 = new XRTable();
		XrTableRow30 = new XRTableRow();
		XrTableCell111 = new XRTableCell();
		XrTableCell112 = new XRTableCell();
		XrTableRow28 = new XRTableRow();
		XrTableCell74 = new XRTableCell();
		XrTableCell94 = new XRTableCell();
		XrCheckBoxJefe = new XRCheckBox();
		XrTableCell95 = new XRTableCell();
		XrTableCell96 = new XRTableCell();
		XrTableRow35 = new XRTableRow();
		XrTableCell107 = new XRTableCell();
		XrTableCell108 = new XRTableCell();
		XrTableCell129 = new XRTableCell();
		XrTableCell130 = new XRTableCell();
		XrLabel6 = new XRLabel();
		GroupFooter1 = new GroupFooterBand();
		XrTable9 = new XRTable();
		XrTableRow36 = new XRTableRow();
		XrTableCell134 = new XRTableCell();
		XrTableCell135 = new XRTableCell();
		DetailReport2 = new DetailReportBand();
		Detail3 = new DetailBand();
		XrTable17 = new XRTable();
		XrTableRow62 = new XRTableRow();
		XrTableCell220 = new XRTableCell();
		XrTableCell221 = new XRTableCell();
		XrTableCell222 = new XRTableCell();
		XrTableCell223 = new XRTableCell();
		XrTableCell224 = new XRTableCell();
		GroupHeader3 = new GroupHeaderBand();
		XrTable16 = new XRTable();
		XrTableRow61 = new XRTableRow();
		XrTableCell215 = new XRTableCell();
		XrTableCell216 = new XRTableCell();
		XrTableCell217 = new XRTableCell();
		XrTableCell218 = new XRTableCell();
		XrTableCell219 = new XRTableCell();
		XrLabel18 = new XRLabel();
		XrLabel17 = new XRLabel();
		DetailReport3 = new DetailReportBand();
		Detail4 = new DetailBand();
		XrTable19 = new XRTable();
		XrTableRow64 = new XRTableRow();
		XrTableCell229 = new XRTableCell();
		XrTableCell230 = new XRTableCell();
		XrTableCell231 = new XRTableCell();
		XrTableCell232 = new XRTableCell();
		GroupHeader4 = new GroupHeaderBand();
		XrTable18 = new XRTable();
		XrTableRow63 = new XRTableRow();
		XrTableCell226 = new XRTableCell();
		XrTableCell227 = new XRTableCell();
		XrTableCell228 = new XRTableCell();
		XrTableCell225 = new XRTableCell();
		XrLabel19 = new XRLabel();
		DetailReport4 = new DetailReportBand();
		Detail5 = new DetailBand();
		XrTable21 = new XRTable();
		XrTableRow66 = new XRTableRow();
		XrTableCell238 = new XRTableCell();
		XrTableCell239 = new XRTableCell();
		XrTableCell240 = new XRTableCell();
		XrTableCell241 = new XRTableCell();
		XrTableCell242 = new XRTableCell();
		GroupHeader5 = new GroupHeaderBand();
		XrTable20 = new XRTable();
		XrTableRow65 = new XRTableRow();
		XrTableCell233 = new XRTableCell();
		XrTableCell234 = new XRTableCell();
		XrTableCell235 = new XRTableCell();
		XrTableCell236 = new XRTableCell();
		XrTableCell237 = new XRTableCell();
		XrLabel20 = new XRLabel();
		GroupFooter2 = new GroupFooterBand();
		DetailReport5 = new DetailReportBand();
		Detail6 = new DetailBand();
		XrTable11 = new XRTable();
		XrTableRow38 = new XRTableRow();
		XrTableCell136 = new XRTableCell();
		XrTableCell139 = new XRTableCell();
		XrTableCell142 = new XRTableCell();
		XrTableCell140 = new XRTableCell();
		XrTableCell141 = new XRTableCell();
		GroupHeader6 = new GroupHeaderBand();
		XrTable10 = new XRTable();
		XrTableRow37 = new XRTableRow();
		XrTableCell84 = new XRTableCell();
		XrTableCell121 = new XRTableCell();
		XrTableCell124 = new XRTableCell();
		XrTableCell125 = new XRTableCell();
		XrTableCell128 = new XRTableCell();
		XrLabel3 = new XRLabel();
		GroupFooter3 = new GroupFooterBand();
		SpRRHH_busca_DisciplinaTableAdapter = new spRRHH_busca_DisciplinaTableAdapter();
		TopMarginBand1 = new TopMarginBand();
		BottomMarginBand1 = new BottomMarginBand();
		((ISupportInitialize)XrTable8).BeginInit();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)XrTable3).BeginInit();
		((ISupportInitialize)XrTable6).BeginInit();
		((ISupportInitialize)XrTable4).BeginInit();
		((ISupportInitialize)XrTable5).BeginInit();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)XrTable12).BeginInit();
		((ISupportInitialize)XrTable13).BeginInit();
		((ISupportInitialize)XrTable7).BeginInit();
		((ISupportInitialize)XrTable9).BeginInit();
		((ISupportInitialize)XrTable17).BeginInit();
		((ISupportInitialize)XrTable16).BeginInit();
		((ISupportInitialize)XrTable19).BeginInit();
		((ISupportInitialize)XrTable18).BeginInit();
		((ISupportInitialize)XrTable21).BeginInit();
		((ISupportInitialize)XrTable20).BeginInit();
		((ISupportInitialize)XrTable11).BeginInit();
		((ISupportInitialize)XrTable10).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[7] { XrPictureBox1, XrTable8, XrLabel8, XrLabel4, XrTable2, XrLabel2, XrLabel1 });
		Detail.HeightF = 658f;
		Detail.Name = "Detail";
		DetailBand detail = Detail;
		PaddingInfo padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail.Padding = padding;
		Detail.TextAlignment = TextAlignment.TopLeft;
		XrPictureBox1.Image = Resources.Logo_GRLL_ok;
		XRPictureBox xrPictureBox = XrPictureBox1;
		PointFloat locationFloat = new PointFloat(50f, 8f);
		xrPictureBox.LocationFloat = locationFloat;
		XrPictureBox1.Name = "XrPictureBox1";
		XRPictureBox xrPictureBox2 = XrPictureBox1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		xrPictureBox2.Padding = padding;
		XRPictureBox xrPictureBox3 = XrPictureBox1;
		SizeF sizeF = new SizeF(100f, 108f);
		xrPictureBox3.SizeF = sizeF;
		XrPictureBox1.Sizing = ImageSizeMode.StretchImage;
		XrTable8.Font = new Font("Times New Roman", 10f);
		XRTable xrTable = XrTable8;
		locationFloat = new PointFloat(42f, 150f);
		xrTable.LocationFloat = locationFloat;
		XrTable8.Name = "XrTable8";
		XRTable xrTable2 = XrTable8;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable2.Padding = padding;
		XrTable8.Rows.AddRange(new XRTableRow[2] { XrTableRow33, XrTableRow34 });
		XRTable xrTable3 = XrTable8;
		sizeF = new SizeF(600f, 34f);
		xrTable3.SizeF = sizeF;
		XrTable8.TextAlignment = TextAlignment.TopLeft;
		XrTableRow33.Cells.AddRange(new XRTableCell[2] { XrTableCell122, XrTableCell127 });
		XrTableRow33.Name = "XrTableRow33";
		XRTableRow xrTableRow = XrTableRow33;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow.Padding = padding;
		XrTableRow33.TextAlignment = TextAlignment.TopLeft;
		XrTableRow33.Weight = 0.5;
		XrTableCell122.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell122.Name = "XrTableCell122";
		XRTableCell xrTableCell = XrTableCell122;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell.Padding = padding;
		XrTableCell122.Text = "Cod. Sistema:";
		XrTableCell122.TextAlignment = TextAlignment.TopLeft;
		XrTableCell122.Weight = 71.0 / 300.0;
		XrTableCell127.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.idempleado")
		});
		XrTableCell127.Name = "XrTableCell127";
		XRTableCell xrTableCell2 = XrTableCell127;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XrTableCell127.Text = "XrTableCell127";
		XrTableCell127.TextAlignment = TextAlignment.TopLeft;
		XrTableCell127.Weight = 229.0 / 300.0;
		XrTableRow34.Cells.AddRange(new XRTableCell[2] { XrTableCell123, XrTableCell126 });
		XrTableRow34.Name = "XrTableRow34";
		XRTableRow xrTableRow2 = XrTableRow34;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow2.Padding = padding;
		XrTableRow34.TextAlignment = TextAlignment.TopLeft;
		XrTableRow34.Weight = 0.5;
		XrTableCell123.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell123.Name = "XrTableCell123";
		XRTableCell xrTableCell3 = XrTableCell123;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell3.Padding = padding;
		XrTableCell123.Text = "Fecha de Inscrip.:";
		XrTableCell123.TextAlignment = TextAlignment.TopLeft;
		XrTableCell123.Weight = 71.0 / 300.0;
		XrTableCell126.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FechaRegistro", "{0:dd/MM/yyyy}")
		});
		XrTableCell126.Name = "XrTableCell126";
		XRTableCell xrTableCell4 = XrTableCell126;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell4.Padding = padding;
		XrTableCell126.Text = "XrTableCell126";
		XrTableCell126.TextAlignment = TextAlignment.TopLeft;
		XrTableCell126.Weight = 229.0 / 300.0;
		XrLabel8.Font = new Font("Times New Roman", 10f, FontStyle.Bold);
		XRLabel xrLabel = XrLabel8;
		locationFloat = new PointFloat(42f, 117f);
		xrLabel.LocationFloat = locationFloat;
		XrLabel8.Name = "XrLabel8";
		XRLabel xrLabel2 = XrLabel8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XRLabel xrLabel3 = XrLabel8;
		sizeF = new SizeF(142f, 25f);
		xrLabel3.SizeF = sizeF;
		XrLabel8.Text = "I. IDENTIFICACION";
		XrLabel8.TextAlignment = TextAlignment.TopLeft;
		XrLabel4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel4 = XrLabel4;
		locationFloat = new PointFloat(42f, 200f);
		xrLabel4.LocationFloat = locationFloat;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel5 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XRLabel xrLabel6 = XrLabel4;
		sizeF = new SizeF(292f, 25f);
		xrLabel6.SizeF = sizeF;
		XrLabel4.Text = "II. DATOS PERSONALES DEL TRABAJADOR";
		XrLabel4.TextAlignment = TextAlignment.TopLeft;
		XrTable2.Borders = BorderSide.None;
		XRTable xrTable4 = XrTable2;
		locationFloat = new PointFloat(42f, 233f);
		xrTable4.LocationFloat = locationFloat;
		XrTable2.Name = "XrTable2";
		XRTable xrTable5 = XrTable2;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable5.Padding = padding;
		XrTable2.Rows.AddRange(new XRTableRow[14]
		{
			XrTableRow2, XrTableRow3, XrTableRow5, XrTableRow4, XrTableRow12, XrTableRow6, XrTableRow7, XrTableRow8, XrTableRow9, XrTableRow23,
			XrTableRow10, XrTableRow24, XrTableRow1, XrTableRow11
		});
		XRTable xrTable6 = XrTable2;
		sizeF = new SizeF(600f, 350f);
		xrTable6.SizeF = sizeF;
		XrTable2.TextAlignment = TextAlignment.TopLeft;
		XrTableRow2.Cells.AddRange(new XRTableCell[4] { XrTableCell7, XrTableCell4, XrTableCell5, XrTableCell6 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow3 = XrTableRow2;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow3.Padding = padding;
		XrTableRow2.TextAlignment = TextAlignment.TopLeft;
		XrTableRow2.Weight = 1.0 / 14.0;
		XrTableCell7.Borders = BorderSide.Left | BorderSide.Top;
		XrTableCell7.Name = "XrTableCell7";
		XRTableCell xrTableCell5 = XrTableCell7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XrTableCell7.TextAlignment = TextAlignment.TopLeft;
		XrTableCell7.Weight = 71.0 / 300.0;
		XrTableCell4.Borders = BorderSide.Top;
		XrTableCell4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell6 = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell6.Padding = padding;
		XrTableCell4.Text = "Apellido Paterno";
		XrTableCell4.TextAlignment = TextAlignment.TopLeft;
		XrTableCell4.Weight = 133.0 / 600.0;
		XrTableCell5.Borders = BorderSide.Top;
		XrTableCell5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell5.Name = "XrTableCell5";
		XRTableCell xrTableCell7 = XrTableCell5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell7.Padding = padding;
		XrTableCell5.Text = "Apellido Materno";
		XrTableCell5.TextAlignment = TextAlignment.TopLeft;
		XrTableCell5.Weight = 133.0 / 600.0;
		XrTableCell6.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell6.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell6.Name = "XrTableCell6";
		XRTableCell xrTableCell8 = XrTableCell6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell8.Padding = padding;
		XrTableCell6.Text = "Nombres";
		XrTableCell6.TextAlignment = TextAlignment.TopLeft;
		XrTableCell6.Weight = 0.32;
		XrTableRow3.Cells.AddRange(new XRTableCell[4] { XrTableCell8, XrTableCell9, XrTableCell10, XrTableCell11 });
		XrTableRow3.Name = "XrTableRow3";
		XRTableRow xrTableRow4 = XrTableRow3;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow4.Padding = padding;
		XrTableRow3.TextAlignment = TextAlignment.TopLeft;
		XrTableRow3.Weight = 1.0 / 14.0;
		XrTableCell8.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell8.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell8.Name = "XrTableCell8";
		XRTableCell xrTableCell9 = XrTableCell8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell9.Padding = padding;
		XrTableCell8.Text = "Nombres y Apellidos:";
		XrTableCell8.TextAlignment = TextAlignment.TopLeft;
		XrTableCell8.Weight = 71.0 / 300.0;
		XrTableCell9.Borders = BorderSide.Bottom;
		XrTableCell9.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Paterno")
		});
		XrTableCell9.Name = "XrTableCell9";
		XRTableCell xrTableCell10 = XrTableCell9;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell10.Padding = padding;
		XrTableCell9.Text = "XrTableCell9";
		XrTableCell9.TextAlignment = TextAlignment.TopLeft;
		XrTableCell9.Weight = 133.0 / 600.0;
		XrTableCell10.Borders = BorderSide.Bottom;
		XrTableCell10.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Materno")
		});
		XrTableCell10.Name = "XrTableCell10";
		XRTableCell xrTableCell11 = XrTableCell10;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell11.Padding = padding;
		XrTableCell10.Text = "XrTableCell10";
		XrTableCell10.TextAlignment = TextAlignment.TopLeft;
		XrTableCell10.Weight = 133.0 / 600.0;
		XrTableCell11.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell11.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Nombres")
		});
		XrTableCell11.Name = "XrTableCell11";
		XRTableCell xrTableCell12 = XrTableCell11;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell12.Padding = padding;
		XrTableCell11.Text = "XrTableCell11";
		XrTableCell11.TextAlignment = TextAlignment.TopLeft;
		XrTableCell11.Weight = 0.32;
		XrTableRow5.Cells.AddRange(new XRTableCell[6] { XrTableCell15, XrTableCell16, XrTableCell17, XrTableCell18, XrTableCell24, XrTableCell23 });
		XrTableRow5.Name = "XrTableRow5";
		XRTableRow xrTableRow5 = XrTableRow5;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow5.Padding = padding;
		XrTableRow5.TextAlignment = TextAlignment.TopLeft;
		XrTableRow5.Weight = 1.0 / 14.0;
		XrTableCell15.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell15.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell15.Name = "XrTableCell15";
		XRTableCell xrTableCell13 = XrTableCell15;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell13.Padding = padding;
		XrTableCell15.Text = "Edad:";
		XrTableCell15.TextAlignment = TextAlignment.TopLeft;
		XrTableCell15.Weight = 0.07;
		XrTableCell16.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell16.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.edadEmpleado")
		});
		XrTableCell16.Name = "XrTableCell16";
		XRTableCell xrTableCell14 = XrTableCell16;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell14.Padding = padding;
		XrTableCell16.Text = "XrTableCell16";
		XrTableCell16.TextAlignment = TextAlignment.TopLeft;
		XrTableCell16.Weight = 1.0 / 6.0;
		XrTableCell17.Borders = BorderSide.Bottom;
		XrTableCell17.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell17.Name = "XrTableCell17";
		XRTableCell xrTableCell15 = XrTableCell17;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell15.Padding = padding;
		XrTableCell17.Text = "Sexo:";
		XrTableCell17.TextAlignment = TextAlignment.TopLeft;
		XrTableCell17.Weight = 29.0 / 300.0;
		XrTableCell18.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell18.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.sexo")
		});
		XrTableCell18.Name = "XrTableCell18";
		XRTableCell xrTableCell16 = XrTableCell18;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell16.Padding = padding;
		XrTableCell18.Text = "XrTableCell18";
		XrTableCell18.TextAlignment = TextAlignment.TopLeft;
		XrTableCell18.Weight = 29.0 / 300.0;
		XrTableCell24.Borders = BorderSide.Bottom;
		XrTableCell24.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.TipoDoc")
		});
		XrTableCell24.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell24.Name = "XrTableCell24";
		XRTableCell xrTableCell17 = XrTableCell24;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell17.Padding = padding;
		XrTableCell24.Text = "XrTableCell24";
		XrTableCell24.TextAlignment = TextAlignment.TopLeft;
		XrTableCell24.Weight = 133.0 / 600.0;
		XrTableCell23.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell23.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumDocId")
		});
		XrTableCell23.Name = "XrTableCell23";
		XRTableCell xrTableCell18 = XrTableCell23;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell18.Padding = padding;
		XrTableCell23.Text = "XrTableCell23";
		XrTableCell23.TextAlignment = TextAlignment.TopLeft;
		XrTableCell23.Weight = 209.0 / 600.0;
		XrTableRow4.Cells.AddRange(new XRTableCell[4] { XrTableCell14, XrTableCell44, XrTableCell50, XrTableCell51 });
		XrTableRow4.Name = "XrTableRow4";
		XRTableRow xrTableRow6 = XrTableRow4;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow6.Padding = padding;
		XrTableRow4.TextAlignment = TextAlignment.TopLeft;
		XrTableRow4.Weight = 1.0 / 14.0;
		XrTableCell14.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell14.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell14.Name = "XrTableCell14";
		XRTableCell xrTableCell19 = XrTableCell14;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell19.Padding = padding;
		XrTableCell14.Text = "Nº Libreta Militar:";
		XrTableCell14.TextAlignment = TextAlignment.TopLeft;
		XrTableCell14.Weight = 71.0 / 300.0;
		XrTableCell44.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell44.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumLibretaMilitar")
		});
		XrTableCell44.Name = "XrTableCell44";
		XRTableCell xrTableCell20 = XrTableCell44;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell20.Padding = padding;
		XrTableCell44.Text = "XrTableCell44";
		XrTableCell44.TextAlignment = TextAlignment.TopLeft;
		XrTableCell44.Weight = 0.25;
		XrTableCell50.Borders = BorderSide.Bottom;
		XrTableCell50.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell50.Name = "XrTableCell50";
		XRTableCell xrTableCell21 = XrTableCell50;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell21.Padding = padding;
		XrTableCell50.Text = "Nº RUC:";
		XrTableCell50.TextAlignment = TextAlignment.TopLeft;
		XrTableCell50.Weight = 0.165;
		XrTableCell51.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell51.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumRUC")
		});
		XrTableCell51.Name = "XrTableCell51";
		XRTableCell xrTableCell22 = XrTableCell51;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell22.Padding = padding;
		XrTableCell51.Text = "XrTableCell51";
		XrTableCell51.TextAlignment = TextAlignment.TopLeft;
		XrTableCell51.Weight = 209.0 / 600.0;
		XrTableRow12.Cells.AddRange(new XRTableCell[4] { XrTableCell53, XrTableCell54, XrTableCell55, XrTableCell56 });
		XrTableRow12.Name = "XrTableRow12";
		XRTableRow xrTableRow7 = XrTableRow12;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow7.Padding = padding;
		XrTableRow12.TextAlignment = TextAlignment.TopLeft;
		XrTableRow12.Weight = 1.0 / 14.0;
		XrTableCell53.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell53.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell53.Name = "XrTableCell53";
		XRTableCell xrTableCell23 = XrTableCell53;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell23.Padding = padding;
		XrTableCell53.Text = "Nº de Brevete:";
		XrTableCell53.TextAlignment = TextAlignment.TopLeft;
		XrTableCell53.Weight = 71.0 / 300.0;
		XrTableCell54.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell54.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.brevete")
		});
		XrTableCell54.Name = "XrTableCell54";
		XRTableCell xrTableCell24 = XrTableCell54;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell24.Padding = padding;
		XrTableCell54.Text = "XrTableCell54";
		XrTableCell54.TextAlignment = TextAlignment.TopLeft;
		XrTableCell54.Weight = 23.0 / 120.0;
		XrTableCell55.Borders = BorderSide.Bottom;
		XrTableCell55.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell55.Name = "XrTableCell55";
		XRTableCell xrTableCell25 = XrTableCell55;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell25.Padding = padding;
		XrTableCell55.Text = "Grupo Sanguíneo:";
		XrTableCell55.TextAlignment = TextAlignment.TopLeft;
		XrTableCell55.Weight = 137.0 / 600.0;
		XrTableCell56.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell56.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DescripTS")
		});
		XrTableCell56.Name = "XrTableCell56";
		XRTableCell xrTableCell26 = XrTableCell56;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell26.Padding = padding;
		XrTableCell56.Text = "XrTableCell56";
		XrTableCell56.TextAlignment = TextAlignment.TopLeft;
		XrTableCell56.Weight = 103.0 / 300.0;
		XrTableRow6.Cells.AddRange(new XRTableCell[4] { XrTableCell19, XrTableCell20, XrTableCell21, XrTableCell22 });
		XrTableRow6.Name = "XrTableRow6";
		XRTableRow xrTableRow8 = XrTableRow6;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow8.Padding = padding;
		XrTableRow6.TextAlignment = TextAlignment.TopLeft;
		XrTableRow6.Weight = 1.0 / 14.0;
		XrTableCell19.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell19.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell19.Name = "XrTableCell19";
		XRTableCell xrTableCell27 = XrTableCell19;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell27.Padding = padding;
		XrTableCell19.Text = "Nacionalidad:";
		XrTableCell19.TextAlignment = TextAlignment.TopLeft;
		XrTableCell19.Weight = 71.0 / 300.0;
		XrTableCell20.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell20.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Nacionalidad")
		});
		XrTableCell20.Name = "XrTableCell20";
		XRTableCell xrTableCell28 = XrTableCell20;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell28.Padding = padding;
		XrTableCell20.Text = "XrTableCell20";
		XrTableCell20.TextAlignment = TextAlignment.TopLeft;
		XrTableCell20.Weight = 23.0 / 120.0;
		XrTableCell21.Borders = BorderSide.Bottom;
		XrTableCell21.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell21.Name = "XrTableCell21";
		XRTableCell xrTableCell29 = XrTableCell21;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell29.Padding = padding;
		XrTableCell21.Text = "Fecha de Nac.:";
		XrTableCell21.TextAlignment = TextAlignment.TopLeft;
		XrTableCell21.Weight = 137.0 / 600.0;
		XrTableCell22.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell22.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FechaNacimiento", "{0:dd/MM/yyyy}")
		});
		XrTableCell22.Name = "XrTableCell22";
		XRTableCell xrTableCell30 = XrTableCell22;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell30.Padding = padding;
		XrTableCell22.Text = "XrTableCell22";
		XrTableCell22.TextAlignment = TextAlignment.TopLeft;
		XrTableCell22.Weight = 103.0 / 300.0;
		XrTableRow7.Cells.AddRange(new XRTableCell[5] { XrTableCell25, XrTableCell26, XrTableCell27, XrTableCell33, XrTableCell28 });
		XrTableRow7.Name = "XrTableRow7";
		XRTableRow xrTableRow9 = XrTableRow7;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow9.Padding = padding;
		XrTableRow7.TextAlignment = TextAlignment.TopLeft;
		XrTableRow7.Weight = 1.0 / 14.0;
		XrTableCell25.Borders = BorderSide.Left;
		XrTableCell25.Name = "XrTableCell25";
		XRTableCell xrTableCell31 = XrTableCell25;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell31.Padding = padding;
		XrTableCell25.TextAlignment = TextAlignment.TopLeft;
		XrTableCell25.Weight = 71.0 / 300.0;
		XrTableCell26.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell26.Name = "XrTableCell26";
		XRTableCell xrTableCell32 = XrTableCell26;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell32.Padding = padding;
		XrTableCell26.Text = "Domicilio";
		XrTableCell26.TextAlignment = TextAlignment.TopLeft;
		XrTableCell26.Weight = 23.0 / 120.0;
		XrTableCell27.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell27.Name = "XrTableCell27";
		XRTableCell xrTableCell33 = XrTableCell27;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell33.Padding = padding;
		XrTableCell27.Text = "Centro Laboral";
		XrTableCell27.TextAlignment = TextAlignment.TopLeft;
		XrTableCell27.Weight = 137.0 / 600.0;
		XrTableCell33.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell33.Name = "XrTableCell33";
		XRTableCell xrTableCell34 = XrTableCell33;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell34.Padding = padding;
		XrTableCell33.Text = "Celular";
		XrTableCell33.TextAlignment = TextAlignment.TopLeft;
		XrTableCell33.Weight = 103.0 / 600.0;
		XrTableCell28.Borders = BorderSide.Right;
		XrTableCell28.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell28.Name = "XrTableCell28";
		XRTableCell xrTableCell35 = XrTableCell28;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell35.Padding = padding;
		XrTableCell28.Text = "Otro";
		XrTableCell28.TextAlignment = TextAlignment.TopLeft;
		XrTableCell28.Weight = 103.0 / 600.0;
		XrTableRow8.Cells.AddRange(new XRTableCell[5] { XrTableCell29, XrTableCell30, XrTableCell31, XrTableCell34, XrTableCell32 });
		XrTableRow8.Name = "XrTableRow8";
		XRTableRow xrTableRow10 = XrTableRow8;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow10.Padding = padding;
		XrTableRow8.TextAlignment = TextAlignment.TopLeft;
		XrTableRow8.Weight = 1.0 / 14.0;
		XrTableCell29.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell29.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell29.Name = "XrTableCell29";
		XRTableCell xrTableCell36 = XrTableCell29;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell36.Padding = padding;
		XrTableCell29.Text = "Teléfonos:";
		XrTableCell29.TextAlignment = TextAlignment.TopLeft;
		XrTableCell29.Weight = 71.0 / 300.0;
		XrTableCell30.Borders = BorderSide.Bottom;
		XrTableCell30.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Telefono")
		});
		XrTableCell30.Name = "XrTableCell30";
		XRTableCell xrTableCell37 = XrTableCell30;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell37.Padding = padding;
		XrTableCell30.Text = "XrTableCell30";
		XrTableCell30.TextAlignment = TextAlignment.TopLeft;
		XrTableCell30.Weight = 23.0 / 120.0;
		XrTableCell31.Borders = BorderSide.Bottom;
		XrTableCell31.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FonoCentroLab")
		});
		XrTableCell31.Name = "XrTableCell31";
		XRTableCell xrTableCell38 = XrTableCell31;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell38.Padding = padding;
		XrTableCell31.Text = "XrTableCell31";
		XrTableCell31.TextAlignment = TextAlignment.TopLeft;
		XrTableCell31.Weight = 137.0 / 600.0;
		XrTableCell34.Borders = BorderSide.Bottom;
		XrTableCell34.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumCelular")
		});
		XrTableCell34.Name = "XrTableCell34";
		XRTableCell xrTableCell39 = XrTableCell34;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell39.Padding = padding;
		XrTableCell34.Text = "XrTableCell34";
		XrTableCell34.TextAlignment = TextAlignment.TopLeft;
		XrTableCell34.Weight = 103.0 / 600.0;
		XrTableCell32.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell32.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Fax")
		});
		XrTableCell32.Name = "XrTableCell32";
		XRTableCell xrTableCell40 = XrTableCell32;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell40.Padding = padding;
		XrTableCell32.Text = "XrTableCell32";
		XrTableCell32.TextAlignment = TextAlignment.TopLeft;
		XrTableCell32.Weight = 103.0 / 600.0;
		XrTableRow9.Cells.AddRange(new XRTableCell[4] { XrTableCell35, XrTableCell36, XrTableCell37, XrTableCell38 });
		XrTableRow9.Name = "XrTableRow9";
		XRTableRow xrTableRow11 = XrTableRow9;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow11.Padding = padding;
		XrTableRow9.TextAlignment = TextAlignment.TopLeft;
		XrTableRow9.Weight = 1.0 / 14.0;
		XrTableCell35.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell35.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell35.Name = "XrTableCell35";
		XRTableCell xrTableCell41 = XrTableCell35;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell41.Padding = padding;
		XrTableCell35.Text = "Estado Civil:";
		XrTableCell35.TextAlignment = TextAlignment.TopLeft;
		XrTableCell35.Weight = 71.0 / 300.0;
		XrTableCell36.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell36.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.EstadoCivil")
		});
		XrTableCell36.Name = "XrTableCell36";
		XRTableCell xrTableCell42 = XrTableCell36;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell42.Padding = padding;
		XrTableCell36.Text = "XrTableCell36";
		XrTableCell36.TextAlignment = TextAlignment.TopLeft;
		XrTableCell36.Weight = 23.0 / 120.0;
		XrTableCell37.Borders = BorderSide.Bottom;
		XrTableCell37.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell37.Name = "XrTableCell37";
		XRTableCell xrTableCell43 = XrTableCell37;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell43.Padding = padding;
		XrTableCell37.Text = "Discapacidad:";
		XrTableCell37.TextAlignment = TextAlignment.TopLeft;
		XrTableCell37.Weight = 137.0 / 600.0;
		XrTableCell38.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell38.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Discapacidad")
		});
		XrTableCell38.Name = "XrTableCell38";
		XRTableCell xrTableCell44 = XrTableCell38;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell44.Padding = padding;
		XrTableCell38.Text = "XrTableCell38";
		XrTableCell38.TextAlignment = TextAlignment.TopLeft;
		XrTableCell38.Weight = 103.0 / 300.0;
		XrTableRow23.Cells.AddRange(new XRTableCell[2] { XrTableCell39, XrTableCell97 });
		XrTableRow23.Name = "XrTableRow23";
		XRTableRow xrTableRow12 = XrTableRow23;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow12.Padding = padding;
		XrTableRow23.TextAlignment = TextAlignment.TopLeft;
		XrTableRow23.Weight = 1.0 / 14.0;
		XrTableCell39.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell39.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell39.Name = "XrTableCell39";
		XRTableCell xrTableCell45 = XrTableCell39;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell45.Padding = padding;
		XrTableCell39.Text = "Grado de Instrucción:";
		XrTableCell39.TextAlignment = TextAlignment.TopLeft;
		XrTableCell39.Weight = 71.0 / 300.0;
		XrTableCell97.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell97.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.gradoInstruccion")
		});
		XrTableCell97.Name = "XrTableCell97";
		XRTableCell xrTableCell46 = XrTableCell97;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell46.Padding = padding;
		XrTableCell97.Text = "XrTableCell97";
		XrTableCell97.TextAlignment = TextAlignment.TopLeft;
		XrTableCell97.Weight = 229.0 / 300.0;
		XrTableRow10.Cells.AddRange(new XRTableCell[4] { XrTableCell40, XrTableCell41, XrTableCell42, XrTableCell43 });
		XrTableRow10.Name = "XrTableRow10";
		XRTableRow xrTableRow13 = XrTableRow10;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow13.Padding = padding;
		XrTableRow10.TextAlignment = TextAlignment.TopLeft;
		XrTableRow10.Weight = 1.0 / 14.0;
		XrTableCell40.Borders = BorderSide.Left;
		XrTableCell40.Name = "XrTableCell40";
		XRTableCell xrTableCell47 = XrTableCell40;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell47.Padding = padding;
		XrTableCell40.TextAlignment = TextAlignment.TopLeft;
		XrTableCell40.Weight = 71.0 / 300.0;
		XrTableCell41.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell41.Name = "XrTableCell41";
		XRTableCell xrTableCell48 = XrTableCell41;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell48.Padding = padding;
		XrTableCell41.Text = "Distrito";
		XrTableCell41.TextAlignment = TextAlignment.TopLeft;
		XrTableCell41.Weight = 133.0 / 600.0;
		XrTableCell42.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell42.Name = "XrTableCell42";
		XRTableCell xrTableCell49 = XrTableCell42;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell49.Padding = padding;
		XrTableCell42.Text = "Provincia";
		XrTableCell42.TextAlignment = TextAlignment.TopLeft;
		XrTableCell42.Weight = 133.0 / 600.0;
		XrTableCell43.Borders = BorderSide.Right;
		XrTableCell43.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell43.Name = "XrTableCell43";
		XRTableCell xrTableCell50 = XrTableCell43;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell50.Padding = padding;
		XrTableCell43.Text = "Departamento";
		XrTableCell43.TextAlignment = TextAlignment.TopLeft;
		XrTableCell43.Weight = 0.32;
		XrTableRow24.Cells.AddRange(new XRTableCell[4] { XrTableCell98, XrTableCell99, XrTableCell100, XrTableCell101 });
		XrTableRow24.Name = "XrTableRow24";
		XRTableRow xrTableRow14 = XrTableRow24;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow14.Padding = padding;
		XrTableRow24.TextAlignment = TextAlignment.TopLeft;
		XrTableRow24.Weight = 1.0 / 14.0;
		XrTableCell98.Borders = BorderSide.Left;
		XrTableCell98.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell98.Name = "XrTableCell98";
		XRTableCell xrTableCell51 = XrTableCell98;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell51.Padding = padding;
		XrTableCell98.Text = "Lugar de Nacimiento:";
		XrTableCell98.TextAlignment = TextAlignment.TopLeft;
		XrTableCell98.Weight = 71.0 / 300.0;
		XrTableCell99.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdistrito")
		});
		XrTableCell99.Name = "XrTableCell99";
		XRTableCell xrTableCell52 = XrTableCell99;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell52.Padding = padding;
		XrTableCell99.Text = "XrTableCell99";
		XrTableCell99.TextAlignment = TextAlignment.TopLeft;
		XrTableCell99.Weight = 133.0 / 600.0;
		XrTableCell100.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desprovincia")
		});
		XrTableCell100.Name = "XrTableCell100";
		XRTableCell xrTableCell53 = XrTableCell100;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell53.Padding = padding;
		XrTableCell100.Text = "XrTableCell100";
		XrTableCell100.TextAlignment = TextAlignment.TopLeft;
		XrTableCell100.Weight = 133.0 / 600.0;
		XrTableCell101.Borders = BorderSide.Right;
		XrTableCell101.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdepartamento")
		});
		XrTableCell101.Name = "XrTableCell101";
		XRTableCell xrTableCell54 = XrTableCell101;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell54.Padding = padding;
		XrTableCell101.Text = "XrTableCell101";
		XrTableCell101.TextAlignment = TextAlignment.TopLeft;
		XrTableCell101.Weight = 0.32;
		XrTableRow1.Cells.AddRange(new XRTableCell[5] { XrTableCell1, XrTableCell2, XrTableCell3, XrTableCell12, XrTableCell13 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow15 = XrTableRow1;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow15.Padding = padding;
		XrTableRow1.TextAlignment = TextAlignment.TopLeft;
		XrTableRow1.Weight = 1.0 / 14.0;
		XrTableCell1.Borders = BorderSide.Left | BorderSide.Top;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell55 = XrTableCell1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell55.Padding = padding;
		XrTableCell1.TextAlignment = TextAlignment.TopLeft;
		XrTableCell1.Weight = 0.125;
		XrTableCell2.Borders = BorderSide.Top;
		XrTableCell2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell56 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell56.Padding = padding;
		XrTableCell2.Text = "Calle,Jirón, Av.";
		XrTableCell2.TextAlignment = TextAlignment.TopLeft;
		XrTableCell2.Weight = 1.0 / 3.0;
		XrTableCell3.Borders = BorderSide.Top;
		XrTableCell3.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell57 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell57.Padding = padding;
		XrTableCell3.Text = "Distrito";
		XrTableCell3.TextAlignment = TextAlignment.TopLeft;
		XrTableCell3.Weight = 133.0 / 600.0;
		XrTableCell12.Borders = BorderSide.Top;
		XrTableCell12.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell12.Name = "XrTableCell12";
		XRTableCell xrTableCell58 = XrTableCell12;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell58.Padding = padding;
		XrTableCell12.Text = "Provincia";
		XrTableCell12.TextAlignment = TextAlignment.TopLeft;
		XrTableCell12.Weight = 1.0 / 6.0;
		XrTableCell13.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell13.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell13.Name = "XrTableCell13";
		XRTableCell xrTableCell59 = XrTableCell13;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell59.Padding = padding;
		XrTableCell13.Text = "Departamento";
		XrTableCell13.TextAlignment = TextAlignment.TopLeft;
		XrTableCell13.Weight = 23.0 / 150.0;
		XrTableRow11.Cells.AddRange(new XRTableCell[5] { XrTableCell45, XrTableCell46, XrTableCell47, XrTableCell48, XrTableCell49 });
		XrTableRow11.Name = "XrTableRow11";
		XRTableRow xrTableRow16 = XrTableRow11;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow16.Padding = padding;
		XrTableRow11.TextAlignment = TextAlignment.TopLeft;
		XrTableRow11.Weight = 1.0 / 14.0;
		XrTableCell45.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell45.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell45.Name = "XrTableCell45";
		XRTableCell xrTableCell60 = XrTableCell45;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell60.Padding = padding;
		XrTableCell45.Text = "Dirección:";
		XrTableCell45.TextAlignment = TextAlignment.TopLeft;
		XrTableCell45.Weight = 0.125;
		XrTableCell46.Borders = BorderSide.Bottom;
		XrTableCell46.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.direccion")
		});
		XrTableCell46.Name = "XrTableCell46";
		XRTableCell xrTableCell61 = XrTableCell46;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell61.Padding = padding;
		XrTableCell46.Text = "XrTableCell46";
		XrTableCell46.TextAlignment = TextAlignment.TopLeft;
		XrTableCell46.Weight = 1.0 / 3.0;
		XrTableCell47.Borders = BorderSide.Bottom;
		XrTableCell47.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DistCasa")
		});
		XrTableCell47.Name = "XrTableCell47";
		XRTableCell xrTableCell62 = XrTableCell47;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell62.Padding = padding;
		XrTableCell47.Text = "XrTableCell47";
		XrTableCell47.TextAlignment = TextAlignment.TopLeft;
		XrTableCell47.Weight = 133.0 / 600.0;
		XrTableCell48.Borders = BorderSide.Bottom;
		XrTableCell48.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ProvCasa")
		});
		XrTableCell48.Name = "XrTableCell48";
		XRTableCell xrTableCell63 = XrTableCell48;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell63.Padding = padding;
		XrTableCell48.Text = "XrTableCell48";
		XrTableCell48.TextAlignment = TextAlignment.TopLeft;
		XrTableCell48.Weight = 1.0 / 6.0;
		XrTableCell49.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell49.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.depCasa")
		});
		XrTableCell49.Name = "XrTableCell49";
		XRTableCell xrTableCell64 = XrTableCell49;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell64.Padding = padding;
		XrTableCell49.Text = "XrTableCell49";
		XrTableCell49.TextAlignment = TextAlignment.TopLeft;
		XrTableCell49.Weight = 23.0 / 150.0;
		XrLabel2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.foto")
		});
		XRLabel xrLabel7 = XrLabel2;
		locationFloat = new PointFloat(575f, 17f);
		xrLabel7.LocationFloat = locationFloat;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel8 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XRLabel xrLabel9 = XrLabel2;
		sizeF = new SizeF(100f, 92f);
		xrLabel9.SizeF = sizeF;
		XrLabel2.Text = "XrLabel2";
		XrLabel2.TextAlignment = TextAlignment.TopLeft;
		XrLabel1.Font = new Font("Arial", 18f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel1;
		locationFloat = new PointFloat(233f, 17f);
		xrLabel10.LocationFloat = locationFloat;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel11 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XRLabel xrLabel12 = XrLabel1;
		sizeF = new SizeF(250f, 33f);
		xrLabel12.SizeF = sizeF;
		XrLabel1.Text = "Ficha Escalafonaria";
		XrLabel1.TextAlignment = TextAlignment.TopLeft;
		PageHeader.HeightF = 0f;
		PageHeader.Name = "PageHeader";
		PageHeaderBand pageHeader = PageHeader;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		pageHeader.Padding = padding;
		PageHeader.TextAlignment = TextAlignment.TopLeft;
		PageFooter.Controls.AddRange(new XRControl[3] { XrPageInfo2, XrLabel9, XrPageInfo1 });
		PageFooter.HeightF = 42f;
		PageFooter.Name = "PageFooter";
		PageFooterBand pageFooter = PageFooter;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		pageFooter.Padding = padding;
		PageFooter.TextAlignment = TextAlignment.TopLeft;
		XRPageInfo xrPageInfo = XrPageInfo2;
		locationFloat = new PointFloat(92f, 8f);
		xrPageInfo.LocationFloat = locationFloat;
		XrPageInfo2.Name = "XrPageInfo2";
		XRPageInfo xrPageInfo2 = XrPageInfo2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.Padding = padding;
		XrPageInfo2.PageInfo = PageInfo.DateTime;
		XRPageInfo xrPageInfo3 = XrPageInfo2;
		sizeF = new SizeF(167f, 17f);
		xrPageInfo3.SizeF = sizeF;
		XRLabel xrLabel13 = XrLabel9;
		locationFloat = new PointFloat(8f, 8f);
		xrLabel13.LocationFloat = locationFloat;
		XrLabel9.Name = "XrLabel9";
		XRLabel xrLabel14 = XrLabel9;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.Padding = padding;
		XRLabel xrLabel15 = XrLabel9;
		sizeF = new SizeF(75f, 17f);
		xrLabel15.SizeF = sizeF;
		XrLabel9.Text = "Impreso el:";
		XRPageInfo xrPageInfo4 = XrPageInfo1;
		locationFloat = new PointFloat(658f, 8f);
		xrPageInfo4.LocationFloat = locationFloat;
		XrPageInfo1.Name = "XrPageInfo1";
		XRPageInfo xrPageInfo5 = XrPageInfo1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo5.Padding = padding;
		XRPageInfo xrPageInfo6 = XrPageInfo1;
		sizeF = new SizeF(33f, 25f);
		xrPageInfo6.SizeF = sizeF;
		XrPageInfo1.TextAlignment = TextAlignment.TopLeft;
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		SpRRHH_Ficha_ExpLabTableAdapter.ClearBeforeFill = true;
		DetailReport.Bands.AddRange(new Band[2] { Detail1, GroupHeader1 });
		DetailReport.DataMember = "spRRHH_Ficha_ExpLab";
		DetailReport.DataSource = DataSet11;
		DetailReport.Level = 0;
		DetailReport.Name = "DetailReport";
		DetailReportBand detailReport = DetailReport;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detailReport.Padding = padding;
		DetailReport.TextAlignment = TextAlignment.TopLeft;
		Detail1.Controls.AddRange(new XRControl[1] { XrTable3 });
		Detail1.HeightF = 25f;
		Detail1.Name = "Detail1";
		DetailBand detail2 = Detail1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail2.Padding = padding;
		Detail1.TextAlignment = TextAlignment.TopLeft;
		XrTable3.Font = new Font("Times New Roman", 9.75f);
		XRTable xrTable7 = XrTable3;
		locationFloat = new PointFloat(50f, 0f);
		xrTable7.LocationFloat = locationFloat;
		XrTable3.Name = "XrTable3";
		XRTable xrTable8 = XrTable3;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable8.Padding = padding;
		XrTable3.Rows.AddRange(new XRTableRow[1] { XrTableRow14 });
		XRTable xrTable9 = XrTable3;
		sizeF = new SizeF(600f, 25f);
		xrTable9.SizeF = sizeF;
		XrTable3.TextAlignment = TextAlignment.TopLeft;
		XrTableRow14.Cells.AddRange(new XRTableCell[6] { XrTableCell63, XrTableCell64, XrTableCell65, XrTableCell66, XrTableCell67, XrTableCell68 });
		XrTableRow14.Name = "XrTableRow14";
		XRTableRow xrTableRow17 = XrTableRow14;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow17.Padding = padding;
		XrTableRow14.TextAlignment = TextAlignment.TopLeft;
		XrTableRow14.Weight = 1.0;
		XrTableCell63.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.DescriptipoInstitucion")
		});
		XrTableCell63.Name = "XrTableCell63";
		XRTableCell xrTableCell65 = XrTableCell63;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell65.Padding = padding;
		XrTableCell63.Text = "Tipo de Institución";
		XrTableCell63.TextAlignment = TextAlignment.TopLeft;
		XrTableCell63.Weight = 0.195;
		XrTableCell64.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.NomInstitucion")
		});
		XrTableCell64.Name = "XrTableCell64";
		XRTableCell xrTableCell66 = XrTableCell64;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell66.Padding = padding;
		XrTableCell64.Text = "Nombre de la Institución";
		XrTableCell64.TextAlignment = TextAlignment.TopLeft;
		XrTableCell64.Weight = 0.235;
		XrTableCell65.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.CargoExp")
		});
		XrTableCell65.Name = "XrTableCell65";
		XRTableCell xrTableCell67 = XrTableCell65;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell67.Padding = padding;
		XrTableCell65.Text = "Cargo";
		XrTableCell65.TextAlignment = TextAlignment.TopLeft;
		XrTableCell65.Weight = 83.0 / 600.0;
		XrTableCell66.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.UnidadOrgaExp")
		});
		XrTableCell66.Name = "XrTableCell66";
		XRTableCell xrTableCell68 = XrTableCell66;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell68.Padding = padding;
		XrTableCell66.Text = "Unidad Organica";
		XrTableCell66.TextAlignment = TextAlignment.TopLeft;
		XrTableCell66.Weight = 109.0 / 600.0;
		XrTableCell67.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.FechaIngresoExp", "{0:dd/MM/yyyy}")
		});
		XrTableCell67.Name = "XrTableCell67";
		XRTableCell xrTableCell69 = XrTableCell67;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell69.Padding = padding;
		XrTableCell67.Text = "Fecha Ingreso";
		XrTableCell67.TextAlignment = TextAlignment.TopLeft;
		XrTableCell67.Weight = 0.125;
		XrTableCell68.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab.FEchaEgresoExp", "{0:dd/MM/yyyy}")
		});
		XrTableCell68.Name = "XrTableCell68";
		XRTableCell xrTableCell70 = XrTableCell68;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell70.Padding = padding;
		XrTableCell68.Text = "Fecha Egreso";
		XrTableCell68.TextAlignment = TextAlignment.TopLeft;
		XrTableCell68.Weight = 0.125;
		GroupHeader1.Controls.AddRange(new XRControl[6] { XrLabel5, XrTable6, XrTable4, XrTable5, XrLabel14, XrTable1 });
		GroupHeader1.HeightF = 608f;
		GroupHeader1.Name = "GroupHeader1";
		GroupHeaderBand groupHeader = GroupHeader1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader.Padding = padding;
		GroupHeader1.TextAlignment = TextAlignment.TopLeft;
		XrLabel5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel16 = XrLabel5;
		locationFloat = new PointFloat(50f, 0f);
		xrLabel16.LocationFloat = locationFloat;
		XrLabel5.Name = "XrLabel5";
		XRLabel xrLabel17 = XrLabel5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.Padding = padding;
		XRLabel xrLabel18 = XrLabel5;
		sizeF = new SizeF(283f, 25f);
		xrLabel18.SizeF = sizeF;
		XrLabel5.Text = "III. ASPECTO LABORAL DEL TRABAJADOR";
		XrLabel5.TextAlignment = TextAlignment.TopLeft;
		XRTable xrTable10 = XrTable6;
		locationFloat = new PointFloat(50f, 33f);
		xrTable10.LocationFloat = locationFloat;
		XrTable6.Name = "XrTable6";
		XRTable xrTable11 = XrTable6;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable11.Padding = padding;
		XrTable6.Rows.AddRange(new XRTableRow[7] { XrTableRow25, XrTableRow29, XrTableRow27, XrTableRow26, XrTableRow22, XrTableRow31, XrTableRow32 });
		XRTable xrTable12 = XrTable6;
		sizeF = new SizeF(600f, 226f);
		xrTable12.SizeF = sizeF;
		XrTable6.TextAlignment = TextAlignment.TopLeft;
		XrTableRow25.Cells.AddRange(new XRTableCell[2] { XrTableCell52, XrTableCell102 });
		XrTableRow25.Name = "XrTableRow25";
		XRTableRow xrTableRow18 = XrTableRow25;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow18.Padding = padding;
		XrTableRow25.TextAlignment = TextAlignment.TopLeft;
		XrTableRow25.Weight = 33.0 / 226.0;
		XrTableCell52.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell52.Name = "XrTableCell52";
		XRTableCell xrTableCell71 = XrTableCell52;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell71.Padding = padding;
		XrTableCell52.Text = "Lugar de Trabajo:";
		XrTableCell52.TextAlignment = TextAlignment.TopLeft;
		XrTableCell52.Weight = 0.33;
		XrTableCell102.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.AreaOrganizacional")
		});
		XrTableCell102.Name = "XrTableCell102";
		XRTableCell xrTableCell72 = XrTableCell102;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell72.Padding = padding;
		XrTableCell102.Text = "XrTableCell102";
		XrTableCell102.TextAlignment = TextAlignment.TopLeft;
		XrTableCell102.Weight = 0.67;
		XrTableRow29.Cells.AddRange(new XRTableCell[2] { XrTableCell109, XrTableCell110 });
		XrTableRow29.Name = "XrTableRow29";
		XRTableRow xrTableRow19 = XrTableRow29;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow19.Padding = padding;
		XrTableRow29.TextAlignment = TextAlignment.TopLeft;
		XrTableRow29.Weight = 33.0 / 226.0;
		XrTableCell109.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell109.Name = "XrTableCell109";
		XRTableCell xrTableCell73 = XrTableCell109;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell73.Padding = padding;
		XrTableCell109.Text = "Condición Laboral:";
		XrTableCell109.TextAlignment = TextAlignment.TopLeft;
		XrTableCell109.Weight = 0.33;
		XrTableCell110.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.CondicionLab")
		});
		XrTableCell110.Name = "XrTableCell110";
		XRTableCell xrTableCell74 = XrTableCell110;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell74.Padding = padding;
		XrTableCell110.Text = "XrTableCell110";
		XrTableCell110.TextAlignment = TextAlignment.TopLeft;
		XrTableCell110.Weight = 0.67;
		XrTableRow27.Cells.AddRange(new XRTableCell[2] { XrTableCell105, XrTableCell106 });
		XrTableRow27.Name = "XrTableRow27";
		XRTableRow xrTableRow20 = XrTableRow27;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow20.Padding = padding;
		XrTableRow27.TextAlignment = TextAlignment.TopLeft;
		XrTableRow27.Weight = 33.0 / 226.0;
		XrTableCell105.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell105.Name = "XrTableCell105";
		XRTableCell xrTableCell75 = XrTableCell105;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell75.Padding = padding;
		XrTableCell105.Text = "Profesión u ocupación:";
		XrTableCell105.TextAlignment = TextAlignment.TopLeft;
		XrTableCell105.Weight = 0.33;
		XrTableCell106.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.profesion")
		});
		XrTableCell106.Name = "XrTableCell106";
		XRTableCell xrTableCell76 = XrTableCell106;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell76.Padding = padding;
		XrTableCell106.Text = "XrTableCell106";
		XrTableCell106.TextAlignment = TextAlignment.TopLeft;
		XrTableCell106.Weight = 0.67;
		XrTableRow26.Cells.AddRange(new XRTableCell[2] { XrTableCell103, XrTableCell104 });
		XrTableRow26.Name = "XrTableRow26";
		XRTableRow xrTableRow21 = XrTableRow26;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow21.Padding = padding;
		XrTableRow26.TextAlignment = TextAlignment.TopLeft;
		XrTableRow26.Weight = 33.0 / 226.0;
		XrTableCell103.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell103.Name = "XrTableCell103";
		XRTableCell xrTableCell77 = XrTableCell103;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell77.Padding = padding;
		XrTableCell103.Text = "Cargo que desempeña o labor que realiza:";
		XrTableCell103.TextAlignment = TextAlignment.TopLeft;
		XrTableCell103.Weight = 5.0 / 12.0;
		XrTableCell104.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.cargo")
		});
		XrTableCell104.Name = "XrTableCell104";
		XRTableCell xrTableCell78 = XrTableCell104;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell78.Padding = padding;
		XrTableCell104.Text = "XrTableCell104";
		XrTableCell104.TextAlignment = TextAlignment.TopLeft;
		XrTableCell104.Weight = 7.0 / 12.0;
		XrTableRow22.Cells.AddRange(new XRTableCell[2] { XrTableCell72, XrTableCell73 });
		XrTableRow22.Name = "XrTableRow22";
		XRTableRow xrTableRow22 = XrTableRow22;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow22.Padding = padding;
		XrTableRow22.TextAlignment = TextAlignment.TopLeft;
		XrTableRow22.Weight = 33.0 / 226.0;
		XrTableCell72.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell72.Name = "XrTableCell72";
		XRTableCell xrTableCell79 = XrTableCell72;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell79.Padding = padding;
		XrTableCell72.Text = "Nº Autogenerado de Salud:";
		XrTableCell72.TextAlignment = TextAlignment.TopLeft;
		XrTableCell72.Weight = 1.0 / 3.0;
		XrTableCell73.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumAutogenSalud")
		});
		XrTableCell73.Name = "XrTableCell73";
		XRTableCell xrTableCell80 = XrTableCell73;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell80.Padding = padding;
		XrTableCell73.Text = "XrTableCell73";
		XrTableCell73.TextAlignment = TextAlignment.TopLeft;
		XrTableCell73.Weight = 2.0 / 3.0;
		XrTableRow31.Cells.AddRange(new XRTableCell[4] { XrTableCell113, XrTableCell114, XrTableCell115, XrTableCell116 });
		XrTableRow31.Name = "XrTableRow31";
		XRTableRow xrTableRow23 = XrTableRow31;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow23.Padding = padding;
		XrTableRow31.TextAlignment = TextAlignment.TopLeft;
		XrTableRow31.Weight = 33.0 / 226.0;
		XrTableCell113.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell113.Name = "XrTableCell113";
		XRTableCell xrTableCell81 = XrTableCell113;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell81.Padding = padding;
		XrTableCell113.Text = "Reg. Pensión:";
		XrTableCell113.TextAlignment = TextAlignment.TopLeft;
		XrTableCell113.Weight = 0.25;
		XrTableCell114.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.LeyRegimen")
		});
		XrTableCell114.Name = "XrTableCell114";
		XRTableCell xrTableCell82 = XrTableCell114;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell82.Padding = padding;
		XrTableCell114.Text = "XrTableCell114";
		XrTableCell114.TextAlignment = TextAlignment.TopLeft;
		XrTableCell114.Weight = 0.25;
		XrTableCell115.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell115.Name = "XrTableCell115";
		XRTableCell xrTableCell83 = XrTableCell115;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell83.Padding = padding;
		XrTableCell115.Text = "AFP:";
		XrTableCell115.TextAlignment = TextAlignment.TopLeft;
		XrTableCell115.Weight = 0.25;
		XrTableCell116.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.DescripAFP")
		});
		XrTableCell116.Name = "XrTableCell116";
		XRTableCell xrTableCell84 = XrTableCell116;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell84.Padding = padding;
		XrTableCell116.Text = "XrTableCell116";
		XrTableCell116.TextAlignment = TextAlignment.TopLeft;
		XrTableCell116.Weight = 0.25;
		XrTableRow32.Cells.AddRange(new XRTableCell[4] { XrTableCell117, XrTableCell118, XrTableCell119, XrTableCell120 });
		XrTableRow32.Name = "XrTableRow32";
		XRTableRow xrTableRow24 = XrTableRow32;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow24.Padding = padding;
		XrTableRow32.TextAlignment = TextAlignment.TopLeft;
		XrTableRow32.Weight = 0.12389380530973451;
		XrTableCell117.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell117.Name = "XrTableCell117";
		XRTableCell xrTableCell85 = XrTableCell117;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell85.Padding = padding;
		XrTableCell117.Text = "Fecha Inscrip. AFP:";
		XrTableCell117.TextAlignment = TextAlignment.TopLeft;
		XrTableCell117.Weight = 0.25;
		XrTableCell118.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaAFP", "{0:dd/MM/yyyy}")
		});
		XrTableCell118.Name = "XrTableCell118";
		XRTableCell xrTableCell86 = XrTableCell118;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell86.Padding = padding;
		XrTableCell118.Text = "XrTableCell118";
		XrTableCell118.TextAlignment = TextAlignment.TopLeft;
		XrTableCell118.Weight = 0.25;
		XrTableCell119.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell119.Name = "XrTableCell119";
		XRTableCell xrTableCell87 = XrTableCell119;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell87.Padding = padding;
		XrTableCell119.Text = "Num CUSPP:";
		XrTableCell119.TextAlignment = TextAlignment.TopLeft;
		XrTableCell119.Weight = 0.25;
		XrTableCell120.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NroAFP")
		});
		XrTableCell120.Name = "XrTableCell120";
		XRTableCell xrTableCell88 = XrTableCell120;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell88.Padding = padding;
		XrTableCell120.Text = "XrTableCell120";
		XrTableCell120.TextAlignment = TextAlignment.TopLeft;
		XrTableCell120.Weight = 0.25;
		XRTable xrTable13 = XrTable4;
		locationFloat = new PointFloat(50f, 267f);
		xrTable13.LocationFloat = locationFloat;
		XrTable4.Name = "XrTable4";
		XRTable xrTable14 = XrTable4;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable14.Padding = padding;
		XrTable4.Rows.AddRange(new XRTableRow[3] { XrTableRow15, XrTableRow19, XrTableRow18 });
		XRTable xrTable15 = XrTable4;
		sizeF = new SizeF(600f, 108f);
		xrTable15.SizeF = sizeF;
		XrTable4.TextAlignment = TextAlignment.TopLeft;
		XrTableRow15.Cells.AddRange(new XRTableCell[1] { XrTableCell69 });
		XrTableRow15.Name = "XrTableRow15";
		XRTableRow xrTableRow25 = XrTableRow15;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow25.Padding = padding;
		XrTableRow15.TextAlignment = TextAlignment.TopLeft;
		XrTableRow15.Weight = 1.0 / 3.0;
		XrTableCell69.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell69.Name = "XrTableCell69";
		XRTableCell xrTableCell89 = XrTableCell69;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell89.Padding = padding;
		XrTableCell69.Text = "PARA EL PERSONAL ACTIVO";
		XrTableCell69.TextAlignment = TextAlignment.TopLeft;
		XrTableCell69.Weight = 1.0;
		XrTableRow19.Cells.AddRange(new XRTableCell[4] { XrTableCell81, XrTableCell82, XrTableCell83, XrTableCell71 });
		XrTableRow19.Name = "XrTableRow19";
		XRTableRow xrTableRow26 = XrTableRow19;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow26.Padding = padding;
		XrTableRow19.TextAlignment = TextAlignment.TopLeft;
		XrTableRow19.Weight = 1.0 / 3.0;
		XrTableCell81.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell81.Name = "XrTableCell81";
		XRTableCell xrTableCell90 = XrTableCell81;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell90.Padding = padding;
		XrTableCell81.Text = "Nº Resolución de Ingreso al Estado:";
		XrTableCell81.TextAlignment = TextAlignment.TopLeft;
		XrTableCell81.Weight = 0.25;
		XrTableCell82.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResoIngreEsta")
		});
		XrTableCell82.Name = "XrTableCell82";
		XRTableCell xrTableCell91 = XrTableCell82;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell91.Padding = padding;
		XrTableCell82.Text = "XrTableCell82";
		XrTableCell82.TextAlignment = TextAlignment.TopLeft;
		XrTableCell82.Weight = 79.0 / 300.0;
		XrTableCell83.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell83.Name = "XrTableCell83";
		XRTableCell xrTableCell92 = XrTableCell83;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell92.Padding = padding;
		XrTableCell83.Text = "Fecha de Ingreso al Estado:";
		XrTableCell83.TextAlignment = TextAlignment.TopLeft;
		XrTableCell83.Weight = 151.0 / 600.0;
		XrTableCell71.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaIngreEstado", "{0:dd/MM/yyyy}")
		});
		XrTableCell71.Name = "XrTableCell71";
		XRTableCell xrTableCell93 = XrTableCell71;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell93.Padding = padding;
		XrTableCell71.Text = "XrTableCell71";
		XrTableCell71.TextAlignment = TextAlignment.TopLeft;
		XrTableCell71.Weight = 0.235;
		XrTableRow18.Cells.AddRange(new XRTableCell[3] { XrTableCell78, XrTableCell79, XrTableCell80 });
		XrTableRow18.Name = "XrTableRow18";
		XRTableRow xrTableRow27 = XrTableRow18;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow27.Padding = padding;
		XrTableRow18.TextAlignment = TextAlignment.TopLeft;
		XrTableRow18.Weight = 1.0 / 3.0;
		XrTableCell78.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell78.Name = "XrTableCell78";
		XRTableCell xrTableCell94 = XrTableCell78;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell94.Padding = padding;
		XrTableCell78.Text = "Nº Resolución de Ingreso a la Institución:";
		XrTableCell78.TextAlignment = TextAlignment.TopJustify;
		XrTableCell78.Weight = 0.25;
		XrTableCell79.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResoIngreInstitu")
		});
		XrTableCell79.Name = "XrTableCell79";
		XRTableCell xrTableCell95 = XrTableCell79;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell95.Padding = padding;
		XrTableCell79.Text = "XrTableCell79";
		XrTableCell79.TextAlignment = TextAlignment.TopLeft;
		XrTableCell79.Weight = 79.0 / 300.0;
		XrTableCell80.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell80.Name = "XrTableCell80";
		XRTableCell xrTableCell96 = XrTableCell80;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell96.Padding = padding;
		XrTableCell80.TextAlignment = TextAlignment.TopLeft;
		XrTableCell80.Weight = 0.48666666666666664;
		XRTable xrTable16 = XrTable5;
		locationFloat = new PointFloat(50f, 383f);
		xrTable16.LocationFloat = locationFloat;
		XrTable5.Name = "XrTable5";
		XRTable xrTable17 = XrTable5;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable17.Padding = padding;
		XrTable5.Rows.AddRange(new XRTableRow[4] { XrTableRow16, XrTableRow17, XrTableRow20, XrTableRow21 });
		XRTable xrTable18 = XrTable5;
		sizeF = new SizeF(600f, 150f);
		xrTable18.SizeF = sizeF;
		XrTable5.TextAlignment = TextAlignment.TopLeft;
		XrTableRow16.Cells.AddRange(new XRTableCell[1] { XrTableCell70 });
		XrTableRow16.Name = "XrTableRow16";
		XRTableRow xrTableRow28 = XrTableRow16;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow28.Padding = padding;
		XrTableRow16.TextAlignment = TextAlignment.TopLeft;
		XrTableRow16.Weight = 37.0 / 150.0;
		XrTableCell70.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell70.Name = "XrTableCell70";
		XRTableCell xrTableCell97 = XrTableCell70;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell97.Padding = padding;
		XrTableCell70.Text = "PARA EL PERSONAL PENSIONISTA";
		XrTableCell70.TextAlignment = TextAlignment.TopLeft;
		XrTableCell70.Weight = 1.0;
		XrTableRow17.Cells.AddRange(new XRTableCell[4] { XrTableCell75, XrTableCell76, XrTableCell77, XrTableCell85 });
		XrTableRow17.Name = "XrTableRow17";
		XRTableRow xrTableRow29 = XrTableRow17;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow29.Padding = padding;
		XrTableRow17.TextAlignment = TextAlignment.TopLeft;
		XrTableRow17.Weight = 37.0 / 150.0;
		XrTableCell75.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell75.Multiline = true;
		XrTableCell75.Name = "XrTableCell75";
		XRTableCell xrTableCell98 = XrTableCell75;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell98.Padding = padding;
		XrTableCell75.Text = "Nº Resolución de Incorporación a la 20530:";
		XrTableCell75.TextAlignment = TextAlignment.TopLeft;
		XrTableCell75.Weight = 0.25;
		XrTableCell76.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResol20530")
		});
		XrTableCell76.Name = "XrTableCell76";
		XRTableCell xrTableCell99 = XrTableCell76;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell99.Padding = padding;
		XrTableCell76.Text = "XrTableCell76";
		XrTableCell76.TextAlignment = TextAlignment.TopLeft;
		XrTableCell76.Weight = 79.0 / 300.0;
		XrTableCell77.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell77.Name = "XrTableCell77";
		XRTableCell xrTableCell100 = XrTableCell77;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell100.Padding = padding;
		XrTableCell77.Text = "Fecha de Incorporación a la 20530:";
		XrTableCell77.TextAlignment = TextAlignment.TopLeft;
		XrTableCell77.Weight = 0.25;
		XrTableCell85.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaResol20530", "{0:dd/MM/yyyy}")
		});
		XrTableCell85.Name = "XrTableCell85";
		XRTableCell xrTableCell101 = XrTableCell85;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell101.Padding = padding;
		XrTableCell85.Text = "XrTableCell85";
		XrTableCell85.TextAlignment = TextAlignment.TopLeft;
		XrTableCell85.Weight = 71.0 / 300.0;
		XrTableRow20.Cells.AddRange(new XRTableCell[4] { XrTableCell86, XrTableCell87, XrTableCell88, XrTableCell89 });
		XrTableRow20.Name = "XrTableRow20";
		XRTableRow xrTableRow30 = XrTableRow20;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow30.Padding = padding;
		XrTableRow20.TextAlignment = TextAlignment.TopLeft;
		XrTableRow20.Weight = 37.0 / 150.0;
		XrTableCell86.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell86.Name = "XrTableCell86";
		XRTableCell xrTableCell102 = XrTableCell86;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell102.Padding = padding;
		XrTableCell86.Text = "Nº Resolución de Cese";
		XrTableCell86.TextAlignment = TextAlignment.TopLeft;
		XrTableCell86.Weight = 0.25;
		XrTableCell87.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResolCese")
		});
		XrTableCell87.Name = "XrTableCell87";
		XRTableCell xrTableCell103 = XrTableCell87;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell103.Padding = padding;
		XrTableCell87.Text = "XrTableCell87";
		XrTableCell87.TextAlignment = TextAlignment.TopLeft;
		XrTableCell87.Weight = 79.0 / 300.0;
		XrTableCell88.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell88.Name = "XrTableCell88";
		XRTableCell xrTableCell104 = XrTableCell88;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell104.Padding = padding;
		XrTableCell88.Text = "Fecha de Cese:";
		XrTableCell88.TextAlignment = TextAlignment.TopLeft;
		XrTableCell88.Weight = 0.25;
		XrTableCell89.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaResolCese", "{0:dd/MM/yyyy}")
		});
		XrTableCell89.Name = "XrTableCell89";
		XRTableCell xrTableCell105 = XrTableCell89;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell105.Padding = padding;
		XrTableCell89.Text = "XrTableCell89";
		XrTableCell89.TextAlignment = TextAlignment.TopLeft;
		XrTableCell89.Weight = 71.0 / 300.0;
		XrTableRow21.Cells.AddRange(new XRTableCell[4] { XrTableCell90, XrTableCell91, XrTableCell92, XrTableCell93 });
		XrTableRow21.Name = "XrTableRow21";
		XRTableRow xrTableRow31 = XrTableRow21;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow31.Padding = padding;
		XrTableRow21.TextAlignment = TextAlignment.TopLeft;
		XrTableRow21.Weight = 0.26;
		XrTableCell90.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell90.Multiline = true;
		XrTableCell90.Name = "XrTableCell90";
		XRTableCell xrTableCell106 = XrTableCell90;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell106.Padding = padding;
		XrTableCell90.Text = "Nº Resolución de Pensionista Mensual - Cesantía";
		XrTableCell90.TextAlignment = TextAlignment.TopLeft;
		XrTableCell90.Weight = 0.25;
		XrTableCell91.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NumResolPenMen")
		});
		XrTableCell91.Name = "XrTableCell91";
		XRTableCell xrTableCell107 = XrTableCell91;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell107.Padding = padding;
		XrTableCell91.Text = "XrTableCell91";
		XrTableCell91.TextAlignment = TextAlignment.TopLeft;
		XrTableCell91.Weight = 79.0 / 300.0;
		XrTableCell92.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell92.Name = "XrTableCell92";
		XRTableCell xrTableCell108 = XrTableCell92;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell108.Padding = padding;
		XrTableCell92.Text = "Fecha de Pensión Mensual - Cesantía:";
		XrTableCell92.TextAlignment = TextAlignment.TopLeft;
		XrTableCell92.Weight = 0.25;
		XrTableCell93.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaResolPenMen", "{0:dd/MM/yyyy}")
		});
		XrTableCell93.Name = "XrTableCell93";
		XRTableCell xrTableCell109 = XrTableCell93;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell109.Padding = padding;
		XrTableCell93.Text = "XrTableCell93";
		XrTableCell93.TextAlignment = TextAlignment.TopLeft;
		XrTableCell93.Weight = 71.0 / 300.0;
		XrLabel14.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel19 = XrLabel14;
		locationFloat = new PointFloat(75f, 542f);
		xrLabel19.LocationFloat = locationFloat;
		XrLabel14.Name = "XrLabel14";
		XRLabel xrLabel20 = XrLabel14;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.Padding = padding;
		XRLabel xrLabel21 = XrLabel14;
		sizeF = new SizeF(192f, 25f);
		xrLabel21.SizeF = sizeF;
		XrLabel14.Text = "Experiencia Laboral:";
		XrLabel14.TextAlignment = TextAlignment.TopLeft;
		XrTable1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable19 = XrTable1;
		locationFloat = new PointFloat(50f, 583f);
		xrTable19.LocationFloat = locationFloat;
		XrTable1.Name = "XrTable1";
		XRTable xrTable20 = XrTable1;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable20.Padding = padding;
		XrTable1.Rows.AddRange(new XRTableRow[1] { XrTableRow13 });
		XRTable xrTable21 = XrTable1;
		sizeF = new SizeF(600f, 25f);
		xrTable21.SizeF = sizeF;
		XrTable1.TextAlignment = TextAlignment.TopLeft;
		XrTableRow13.Cells.AddRange(new XRTableCell[6] { XrTableCell57, XrTableCell58, XrTableCell59, XrTableCell60, XrTableCell61, XrTableCell62 });
		XrTableRow13.Name = "XrTableRow13";
		XRTableRow xrTableRow32 = XrTableRow13;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow32.Padding = padding;
		XrTableRow13.TextAlignment = TextAlignment.TopLeft;
		XrTableRow13.Weight = 1.0;
		XrTableCell57.Name = "XrTableCell57";
		XRTableCell xrTableCell110 = XrTableCell57;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell110.Padding = padding;
		XrTableCell57.Text = "Tipo de Institución";
		XrTableCell57.TextAlignment = TextAlignment.TopLeft;
		XrTableCell57.Weight = 0.195;
		XrTableCell58.Name = "XrTableCell58";
		XRTableCell xrTableCell111 = XrTableCell58;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell111.Padding = padding;
		XrTableCell58.Text = "Nombre de la Institución";
		XrTableCell58.TextAlignment = TextAlignment.TopLeft;
		XrTableCell58.Weight = 0.235;
		XrTableCell59.Name = "XrTableCell59";
		XRTableCell xrTableCell112 = XrTableCell59;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell112.Padding = padding;
		XrTableCell59.Text = "Cargo";
		XrTableCell59.TextAlignment = TextAlignment.TopLeft;
		XrTableCell59.Weight = 83.0 / 600.0;
		XrTableCell60.Name = "XrTableCell60";
		XRTableCell xrTableCell113 = XrTableCell60;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell113.Padding = padding;
		XrTableCell60.Text = "Unidad Organica";
		XrTableCell60.TextAlignment = TextAlignment.TopLeft;
		XrTableCell60.Weight = 109.0 / 600.0;
		XrTableCell61.Name = "XrTableCell61";
		XRTableCell xrTableCell114 = XrTableCell61;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell114.Padding = padding;
		XrTableCell61.Text = "Fecha Ingreso";
		XrTableCell61.TextAlignment = TextAlignment.TopLeft;
		XrTableCell61.Weight = 0.125;
		XrTableCell62.Name = "XrTableCell62";
		XRTableCell xrTableCell115 = XrTableCell62;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell115.Padding = padding;
		XrTableCell62.Text = "Fecha Egreso";
		XrTableCell62.TextAlignment = TextAlignment.TopLeft;
		XrTableCell62.Weight = 0.125;
		DetailReport1.Bands.AddRange(new Band[3] { Detail2, GroupHeader2, GroupFooter1 });
		DetailReport1.DataMember = "spRRHH_Ficha_Det_Familiar";
		DetailReport1.DataSource = DataSet11;
		DetailReport1.Level = 1;
		DetailReport1.Name = "DetailReport1";
		DetailReportBand detailReport2 = DetailReport1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detailReport2.Padding = padding;
		DetailReport1.TextAlignment = TextAlignment.TopLeft;
		Detail2.Controls.AddRange(new XRControl[1] { XrTable12 });
		Detail2.HeightF = 25f;
		Detail2.Name = "Detail2";
		DetailBand detail3 = Detail2;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail3.Padding = padding;
		Detail2.TextAlignment = TextAlignment.TopLeft;
		XRTable xrTable22 = XrTable12;
		locationFloat = new PointFloat(17f, 0f);
		xrTable22.LocationFloat = locationFloat;
		XrTable12.Name = "XrTable12";
		XRTable xrTable23 = XrTable12;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable23.Padding = padding;
		XrTable12.Rows.AddRange(new XRTableRow[1] { XrTableRow39 });
		XRTable xrTable24 = XrTable12;
		sizeF = new SizeF(658f, 25f);
		xrTable24.SizeF = sizeF;
		XrTable12.TextAlignment = TextAlignment.TopLeft;
		XrTableRow39.Cells.AddRange(new XRTableCell[8] { XrTableCell137, XrTableCell138, XrTableCell143, XrTableCell144, XrTableCell145, XrTableCell146, XrTableCell131, XrTableCell132 });
		XrTableRow39.Name = "XrTableRow39";
		XRTableRow xrTableRow33 = XrTableRow39;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow33.Padding = padding;
		XrTableRow39.TextAlignment = TextAlignment.TopLeft;
		XrTableRow39.Weight = 1.0;
		XrTableCell137.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.NombresFamilia")
		});
		XrTableCell137.Name = "XrTableCell137";
		XRTableCell xrTableCell116 = XrTableCell137;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell116.Padding = padding;
		XrTableCell137.Text = "XrTableCell137";
		XrTableCell137.TextAlignment = TextAlignment.TopLeft;
		XrTableCell137.Weight = 183.0 / 658.0;
		XrTableCell138.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.edadFamiliar")
		});
		XrTableCell138.Name = "XrTableCell138";
		XRTableCell xrTableCell117 = XrTableCell138;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell117.Padding = padding;
		XrTableCell138.Text = "XrTableCell138";
		XrTableCell138.TextAlignment = TextAlignment.TopLeft;
		XrTableCell138.Weight = 51.0 / 658.0;
		XrTableCell143.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamSexo")
		});
		XrTableCell143.Name = "XrTableCell143";
		XRTableCell xrTableCell118 = XrTableCell143;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell118.Padding = padding;
		XrTableCell143.Text = "XrTableCell143";
		XrTableCell143.TextAlignment = TextAlignment.TopLeft;
		XrTableCell143.Weight = 0.06382978723404255;
		XrTableCell144.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripTipoFam")
		});
		XrTableCell144.Name = "XrTableCell144";
		XRTableCell xrTableCell119 = XrTableCell144;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell119.Padding = padding;
		XrTableCell144.Text = "XrTableCell144";
		XrTableCell144.TextAlignment = TextAlignment.TopLeft;
		XrTableCell144.Weight = 0.12462006079027356;
		XrTableCell145.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamGradoInstruc")
		});
		XrTableCell145.Name = "XrTableCell145";
		XRTableCell xrTableCell120 = XrTableCell145;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell120.Padding = padding;
		XrTableCell145.Text = "XrTableCell145";
		XrTableCell145.TextAlignment = TextAlignment.TopLeft;
		XrTableCell145.Weight = 93.0 / 658.0;
		XrTableCell146.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripEstCivil")
		});
		XrTableCell146.Name = "XrTableCell146";
		XRTableCell xrTableCell121 = XrTableCell146;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell121.Padding = padding;
		XrTableCell146.Text = "XrTableCell146";
		XrTableCell146.TextAlignment = TextAlignment.TopLeft;
		XrTableCell146.Weight = 0.10030395136778116;
		XrTableCell131.BookmarkParent = XrCheckBoxViveCasa;
		XrTableCell131.Controls.AddRange(new XRControl[1] { XrCheckBoxViveCasa });
		XrTableCell131.Name = "XrTableCell131";
		XRTableCell xrTableCell122 = XrTableCell131;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell122.Padding = padding;
		XrTableCell131.Text = "XrTableCell131";
		XrTableCell131.TextAlignment = TextAlignment.TopLeft;
		XrTableCell131.Weight = 83.0 / 658.0;
		XrCheckBoxViveCasa.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.ViveCasa")
		});
		XRCheckBox xrCheckBoxViveCasa = XrCheckBoxViveCasa;
		locationFloat = new PointFloat(25f, 0f);
		xrCheckBoxViveCasa.LocationFloat = locationFloat;
		XrCheckBoxViveCasa.Name = "XrCheckBoxViveCasa";
		XRCheckBox xrCheckBoxViveCasa2 = XrCheckBoxViveCasa;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrCheckBoxViveCasa2.Padding = padding;
		XRCheckBox xrCheckBoxViveCasa3 = XrCheckBoxViveCasa;
		sizeF = new SizeF(42f, 25f);
		xrCheckBoxViveCasa3.SizeF = sizeF;
		XrTableCell132.BookmarkParent = XrCheckBoxLabInst;
		XrTableCell132.Controls.AddRange(new XRControl[1] { XrCheckBoxLabInst });
		XrTableCell132.Name = "XrTableCell132";
		XRTableCell xrTableCell123 = XrTableCell132;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell123.Padding = padding;
		XrTableCell132.Text = "XrTableCell132";
		XrTableCell132.TextAlignment = TextAlignment.TopLeft;
		XrTableCell132.Weight = 0.08814589665653495;
		XrCheckBoxLabInst.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.LaboraInstitucion")
		});
		XRCheckBox xrCheckBoxLabInst = XrCheckBoxLabInst;
		locationFloat = new PointFloat(17f, 0f);
		xrCheckBoxLabInst.LocationFloat = locationFloat;
		XrCheckBoxLabInst.Name = "XrCheckBoxLabInst";
		XRCheckBox xrCheckBoxLabInst2 = XrCheckBoxLabInst;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrCheckBoxLabInst2.Padding = padding;
		XRCheckBox xrCheckBoxLabInst3 = XrCheckBoxLabInst;
		sizeF = new SizeF(33f, 25f);
		xrCheckBoxLabInst3.SizeF = sizeF;
		GroupHeader2.Controls.AddRange(new XRControl[4] { XrTable13, XrLabel7, XrTable7, XrLabel6 });
		GroupHeader2.HeightF = 217f;
		GroupHeader2.Name = "GroupHeader2";
		GroupHeaderBand groupHeader2 = GroupHeader2;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader2.Padding = padding;
		GroupHeader2.TextAlignment = TextAlignment.TopLeft;
		XrTable13.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable25 = XrTable13;
		locationFloat = new PointFloat(17f, 192f);
		xrTable25.LocationFloat = locationFloat;
		XrTable13.Name = "XrTable13";
		XRTable xrTable26 = XrTable13;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable26.Padding = padding;
		XrTable13.Rows.AddRange(new XRTableRow[1] { XrTableRow40 });
		XRTable xrTable27 = XrTable13;
		sizeF = new SizeF(658f, 25f);
		xrTable27.SizeF = sizeF;
		XrTable13.TextAlignment = TextAlignment.TopLeft;
		XrTableRow40.Cells.AddRange(new XRTableCell[8] { XrTableCell163, XrTableCell164, XrTableCell165, XrTableCell166, XrTableCell167, XrTableCell168, XrTableCell169, XrTableCell133 });
		XrTableRow40.Name = "XrTableRow40";
		XRTableRow xrTableRow34 = XrTableRow40;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow34.Padding = padding;
		XrTableRow40.TextAlignment = TextAlignment.TopLeft;
		XrTableRow40.Weight = 1.0;
		XrTableCell163.Name = "XrTableCell163";
		XRTableCell xrTableCell124 = XrTableCell163;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell124.Padding = padding;
		XrTableCell163.Text = "Nombres y Apellidos";
		XrTableCell163.TextAlignment = TextAlignment.TopLeft;
		XrTableCell163.Weight = 183.0 / 658.0;
		XrTableCell164.Name = "XrTableCell164";
		XRTableCell xrTableCell125 = XrTableCell164;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell125.Padding = padding;
		XrTableCell164.Text = "Edad";
		XrTableCell164.TextAlignment = TextAlignment.TopLeft;
		XrTableCell164.Weight = 51.0 / 658.0;
		XrTableCell165.Name = "XrTableCell165";
		XRTableCell xrTableCell126 = XrTableCell165;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell126.Padding = padding;
		XrTableCell165.Text = "Sexo";
		XrTableCell165.TextAlignment = TextAlignment.TopLeft;
		XrTableCell165.Weight = 0.06382978723404255;
		XrTableCell166.Name = "XrTableCell166";
		XRTableCell xrTableCell127 = XrTableCell166;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell127.Padding = padding;
		XrTableCell166.Text = "Parentesco";
		XrTableCell166.TextAlignment = TextAlignment.TopLeft;
		XrTableCell166.Weight = 0.12462006079027356;
		XrTableCell167.Name = "XrTableCell167";
		XRTableCell xrTableCell128 = XrTableCell167;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell128.Padding = padding;
		XrTableCell167.Text = "Grado de Inst.";
		XrTableCell167.TextAlignment = TextAlignment.TopLeft;
		XrTableCell167.Weight = 93.0 / 658.0;
		XrTableCell168.Name = "XrTableCell168";
		XRTableCell xrTableCell129 = XrTableCell168;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell129.Padding = padding;
		XrTableCell168.Text = "E.Civil";
		XrTableCell168.TextAlignment = TextAlignment.TopLeft;
		XrTableCell168.Weight = 0.10030395136778116;
		XrTableCell169.Name = "XrTableCell169";
		XRTableCell xrTableCell130 = XrTableCell169;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell130.Padding = padding;
		XrTableCell169.Text = "Vive en Casa";
		XrTableCell169.TextAlignment = TextAlignment.TopLeft;
		XrTableCell169.Weight = 83.0 / 658.0;
		XrTableCell133.Name = "XrTableCell133";
		XRTableCell xrTableCell131 = XrTableCell133;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell131.Padding = padding;
		XrTableCell133.Text = "Lab. Instit.";
		XrTableCell133.TextAlignment = TextAlignment.TopLeft;
		XrTableCell133.Weight = 0.08814589665653495;
		XrLabel7.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel22 = XrLabel7;
		locationFloat = new PointFloat(67f, 150f);
		xrLabel22.LocationFloat = locationFloat;
		XrLabel7.Name = "XrLabel7";
		XRLabel xrLabel23 = XrLabel7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel23.Padding = padding;
		XRLabel xrLabel24 = XrLabel7;
		sizeF = new SizeF(250f, 25f);
		xrLabel24.SizeF = sizeF;
		XrLabel7.Text = "4.5 Composición Familiar:";
		XrLabel7.TextAlignment = TextAlignment.TopLeft;
		XRTable xrTable28 = XrTable7;
		locationFloat = new PointFloat(33f, 58f);
		xrTable28.LocationFloat = locationFloat;
		XrTable7.Name = "XrTable7";
		XRTable xrTable29 = XrTable7;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable29.Padding = padding;
		XrTable7.Rows.AddRange(new XRTableRow[3] { XrTableRow30, XrTableRow28, XrTableRow35 });
		XRTable xrTable30 = XrTable7;
		sizeF = new SizeF(600f, 75f);
		xrTable30.SizeF = sizeF;
		XrTable7.TextAlignment = TextAlignment.TopLeft;
		XrTableRow30.Cells.AddRange(new XRTableCell[2] { XrTableCell111, XrTableCell112 });
		XrTableRow30.Name = "XrTableRow30";
		XRTableRow xrTableRow35 = XrTableRow30;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow35.Padding = padding;
		XrTableRow30.TextAlignment = TextAlignment.TopLeft;
		XrTableRow30.Weight = 1.0 / 3.0;
		XrTableCell111.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell111.Name = "XrTableCell111";
		XRTableCell xrTableCell132 = XrTableCell111;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell132.Padding = padding;
		XrTableCell111.Text = "¿Con quién vives actualmente?";
		XrTableCell111.TextAlignment = TextAlignment.TopLeft;
		XrTableCell111.Weight = 199.0 / 600.0;
		XrTableCell112.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Descripvivecon")
		});
		XrTableCell112.Name = "XrTableCell112";
		XRTableCell xrTableCell133 = XrTableCell112;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell133.Padding = padding;
		XrTableCell112.Text = "XrTableCell112";
		XrTableCell112.TextAlignment = TextAlignment.TopLeft;
		XrTableCell112.Weight = 401.0 / 600.0;
		XrTableRow28.Cells.AddRange(new XRTableCell[4] { XrTableCell74, XrTableCell94, XrTableCell95, XrTableCell96 });
		XrTableRow28.Name = "XrTableRow28";
		XRTableRow xrTableRow36 = XrTableRow28;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow36.Padding = padding;
		XrTableRow28.TextAlignment = TextAlignment.TopLeft;
		XrTableRow28.Weight = 1.0 / 3.0;
		XrTableCell74.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell74.Name = "XrTableCell74";
		XRTableCell xrTableCell134 = XrTableCell74;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell134.Padding = padding;
		XrTableCell74.Text = "¿Eres Jefe de Hogar?";
		XrTableCell74.TextAlignment = TextAlignment.TopLeft;
		XrTableCell74.Weight = 199.0 / 600.0;
		XrTableCell94.BookmarkParent = XrCheckBoxJefe;
		XrTableCell94.Controls.AddRange(new XRControl[1] { XrCheckBoxJefe });
		XrTableCell94.Name = "XrTableCell94";
		XRTableCell xrTableCell135 = XrTableCell94;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell135.Padding = padding;
		XrTableCell94.Text = "XrTableCell94";
		XrTableCell94.TextAlignment = TextAlignment.TopLeft;
		XrTableCell94.Weight = 67.0 / 300.0;
		XrCheckBoxJefe.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.JefeHogar")
		});
		XRCheckBox xrCheckBoxJefe = XrCheckBoxJefe;
		locationFloat = new PointFloat(9f, 0f);
		xrCheckBoxJefe.LocationFloat = locationFloat;
		XrCheckBoxJefe.Name = "XrCheckBoxJefe";
		XRCheckBox xrCheckBoxJefe2 = XrCheckBoxJefe;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrCheckBoxJefe2.Padding = padding;
		XRCheckBox xrCheckBoxJefe3 = XrCheckBoxJefe;
		sizeF = new SizeF(42f, 25f);
		xrCheckBoxJefe3.SizeF = sizeF;
		XrTableCell95.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell95.Name = "XrTableCell95";
		XRTableCell xrTableCell136 = XrTableCell95;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell136.Padding = padding;
		XrTableCell95.Text = "Carga Familiar:";
		XrTableCell95.TextAlignment = TextAlignment.TopLeft;
		XrTableCell95.Weight = 83.0 / 300.0;
		XrTableCell96.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.CargaFam")
		});
		XrTableCell96.Name = "XrTableCell96";
		XRTableCell xrTableCell137 = XrTableCell96;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell137.Padding = padding;
		XrTableCell96.Text = "XrTableCell96";
		XrTableCell96.TextAlignment = TextAlignment.TopLeft;
		XrTableCell96.Weight = 101.0 / 600.0;
		XrTableRow35.Cells.AddRange(new XRTableCell[4] { XrTableCell107, XrTableCell108, XrTableCell129, XrTableCell130 });
		XrTableRow35.Name = "XrTableRow35";
		XRTableRow xrTableRow37 = XrTableRow35;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow37.Padding = padding;
		XrTableRow35.TextAlignment = TextAlignment.TopLeft;
		XrTableRow35.Weight = 1.0 / 3.0;
		XrTableCell107.Name = "XrTableCell107";
		XRTableCell xrTableCell138 = XrTableCell107;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell138.Padding = padding;
		XrTableCell107.TextAlignment = TextAlignment.TopLeft;
		XrTableCell107.Weight = 199.0 / 600.0;
		XrTableCell108.Name = "XrTableCell108";
		XRTableCell xrTableCell139 = XrTableCell108;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell139.Padding = padding;
		XrTableCell108.TextAlignment = TextAlignment.TopLeft;
		XrTableCell108.Weight = 67.0 / 300.0;
		XrTableCell129.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell129.Name = "XrTableCell129";
		XRTableCell xrTableCell140 = XrTableCell129;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell140.Padding = padding;
		XrTableCell129.Text = "Hijos:";
		XrTableCell129.TextAlignment = TextAlignment.TopLeft;
		XrTableCell129.Weight = 83.0 / 300.0;
		XrTableCell130.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Numhijos")
		});
		XrTableCell130.Name = "XrTableCell130";
		XRTableCell xrTableCell141 = XrTableCell130;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell141.Padding = padding;
		XrTableCell130.Text = "XrTableCell130";
		XrTableCell130.TextAlignment = TextAlignment.TopLeft;
		XrTableCell130.Weight = 101.0 / 600.0;
		XrLabel6.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel25 = XrLabel6;
		locationFloat = new PointFloat(33f, 25f);
		xrLabel25.LocationFloat = locationFloat;
		XrLabel6.Name = "XrLabel6";
		XRLabel xrLabel26 = XrLabel6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel26.Padding = padding;
		XRLabel xrLabel27 = XrLabel6;
		sizeF = new SizeF(442f, 25f);
		xrLabel27.SizeF = sizeF;
		XrLabel6.Text = "IV. ASPECTO SOCIO-FAMILIAR DEL TRABAJADOR";
		XrLabel6.TextAlignment = TextAlignment.TopLeft;
		GroupFooter1.Controls.AddRange(new XRControl[1] { XrTable9 });
		GroupFooter1.HeightF = 36f;
		GroupFooter1.Name = "GroupFooter1";
		GroupFooterBand groupFooter = GroupFooter1;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupFooter.Padding = padding;
		GroupFooter1.TextAlignment = TextAlignment.TopLeft;
		XRTable xrTable31 = XrTable9;
		locationFloat = new PointFloat(17f, 0f);
		xrTable31.LocationFloat = locationFloat;
		XrTable9.Name = "XrTable9";
		XRTable xrTable32 = XrTable9;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable32.Padding = padding;
		XrTable9.Rows.AddRange(new XRTableRow[1] { XrTableRow36 });
		XRTable xrTable33 = XrTable9;
		sizeF = new SizeF(658f, 25f);
		xrTable33.SizeF = sizeF;
		XrTable9.TextAlignment = TextAlignment.TopLeft;
		XrTableRow36.Cells.AddRange(new XRTableCell[2] { XrTableCell134, XrTableCell135 });
		XrTableRow36.Name = "XrTableRow36";
		XRTableRow xrTableRow38 = XrTableRow36;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow38.Padding = padding;
		XrTableRow36.TextAlignment = TextAlignment.TopLeft;
		XrTableRow36.Weight = 1.0;
		XrTableCell134.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XrTableCell134.Name = "XrTableCell134";
		XRTableCell xrTableCell142 = XrTableCell134;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell142.Padding = padding;
		XrTableCell134.Text = "Observaciones:";
		XrTableCell134.TextAlignment = TextAlignment.TopLeft;
		XrTableCell134.Weight = 0.23708206686930092;
		XrTableCell135.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ObsFam")
		});
		XrTableCell135.Name = "XrTableCell135";
		XRTableCell xrTableCell143 = XrTableCell135;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell143.Padding = padding;
		XrTableCell135.Text = "XrTableCell135";
		XrTableCell135.TextAlignment = TextAlignment.TopLeft;
		XrTableCell135.Weight = 0.7629179331306991;
		DetailReport2.Bands.AddRange(new Band[2] { Detail3, GroupHeader3 });
		DetailReport2.DataMember = "spRRHH_Ficha_Estudio_Realizado";
		DetailReport2.DataSource = DataSet11;
		DetailReport2.Level = 2;
		DetailReport2.Name = "DetailReport2";
		DetailReportBand detailReport3 = DetailReport2;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detailReport3.Padding = padding;
		DetailReport2.TextAlignment = TextAlignment.TopLeft;
		Detail3.Controls.AddRange(new XRControl[1] { XrTable17 });
		Detail3.HeightF = 30f;
		Detail3.Name = "Detail3";
		DetailBand detail4 = Detail3;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail4.Padding = padding;
		Detail3.TextAlignment = TextAlignment.TopLeft;
		XrTable17.Font = new Font("Times New Roman", 9.75f);
		XRTable xrTable34 = XrTable17;
		locationFloat = new PointFloat(50f, 0f);
		xrTable34.LocationFloat = locationFloat;
		XrTable17.Name = "XrTable17";
		XRTable xrTable35 = XrTable17;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable35.Padding = padding;
		XrTable17.Rows.AddRange(new XRTableRow[1] { XrTableRow62 });
		XRTable xrTable36 = XrTable17;
		sizeF = new SizeF(600f, 25f);
		xrTable36.SizeF = sizeF;
		XrTable17.TextAlignment = TextAlignment.TopLeft;
		XrTableRow62.Cells.AddRange(new XRTableCell[5] { XrTableCell220, XrTableCell221, XrTableCell222, XrTableCell223, XrTableCell224 });
		XrTableRow62.Name = "XrTableRow62";
		XRTableRow xrTableRow39 = XrTableRow62;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow39.Padding = padding;
		XrTableRow62.TextAlignment = TextAlignment.TopLeft;
		XrTableRow62.Weight = 1.0;
		XrTableCell220.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripTipoEst")
		});
		XrTableCell220.Name = "XrTableCell220";
		XRTableCell xrTableCell144 = XrTableCell220;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell144.Padding = padding;
		XrTableCell220.Text = "Tipo de Estudio";
		XrTableCell220.TextAlignment = TextAlignment.TopLeft;
		XrTableCell220.Weight = 0.2;
		XrTableCell221.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.CentroEstudios")
		});
		XrTableCell221.Name = "XrTableCell221";
		XRTableCell xrTableCell145 = XrTableCell221;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell145.Padding = padding;
		XrTableCell221.Text = "Centro de Estudios";
		XrTableCell221.TextAlignment = TextAlignment.TopLeft;
		XrTableCell221.Weight = 0.2;
		XrTableCell222.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.AñoInicio", "{0:dd/MM/yyyy}")
		});
		XrTableCell222.Name = "XrTableCell222";
		XRTableCell xrTableCell146 = XrTableCell222;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell146.Padding = padding;
		XrTableCell222.Text = "Fecha de Inicio";
		XrTableCell222.TextAlignment = TextAlignment.TopLeft;
		XrTableCell222.Weight = 0.2;
		XrTableCell223.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.Añotermino", "{0:dd/MM/yyyy}")
		});
		XrTableCell223.Name = "XrTableCell223";
		XRTableCell xrTableCell147 = XrTableCell223;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell147.Padding = padding;
		XrTableCell223.Text = "Fecha de Termino";
		XrTableCell223.TextAlignment = TextAlignment.TopLeft;
		XrTableCell223.Weight = 0.2;
		XrTableCell224.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudio")
		});
		XrTableCell224.Name = "XrTableCell224";
		XRTableCell xrTableCell148 = XrTableCell224;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell148.Padding = padding;
		XrTableCell224.Text = "Estado";
		XrTableCell224.TextAlignment = TextAlignment.TopLeft;
		XrTableCell224.Weight = 0.2;
		GroupHeader3.Controls.AddRange(new XRControl[3] { XrTable16, XrLabel18, XrLabel17 });
		GroupHeader3.HeightF = 125f;
		GroupHeader3.Name = "GroupHeader3";
		GroupHeaderBand groupHeader3 = GroupHeader3;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader3.Padding = padding;
		GroupHeader3.TextAlignment = TextAlignment.TopLeft;
		XrTable16.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable37 = XrTable16;
		locationFloat = new PointFloat(50f, 100f);
		xrTable37.LocationFloat = locationFloat;
		XrTable16.Name = "XrTable16";
		XRTable xrTable38 = XrTable16;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable38.Padding = padding;
		XrTable16.Rows.AddRange(new XRTableRow[1] { XrTableRow61 });
		XRTable xrTable39 = XrTable16;
		sizeF = new SizeF(600f, 25f);
		xrTable39.SizeF = sizeF;
		XrTable16.TextAlignment = TextAlignment.TopLeft;
		XrTableRow61.Cells.AddRange(new XRTableCell[5] { XrTableCell215, XrTableCell216, XrTableCell217, XrTableCell218, XrTableCell219 });
		XrTableRow61.Name = "XrTableRow61";
		XRTableRow xrTableRow40 = XrTableRow61;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow40.Padding = padding;
		XrTableRow61.TextAlignment = TextAlignment.TopLeft;
		XrTableRow61.Weight = 1.0;
		XrTableCell215.Name = "XrTableCell215";
		XRTableCell xrTableCell149 = XrTableCell215;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell149.Padding = padding;
		XrTableCell215.Text = "Tipo de Estudio";
		XrTableCell215.TextAlignment = TextAlignment.TopLeft;
		XrTableCell215.Weight = 0.2;
		XrTableCell216.Name = "XrTableCell216";
		XRTableCell xrTableCell150 = XrTableCell216;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell150.Padding = padding;
		XrTableCell216.Text = "Centro de Estudios";
		XrTableCell216.TextAlignment = TextAlignment.TopLeft;
		XrTableCell216.Weight = 0.2;
		XrTableCell217.Name = "XrTableCell217";
		XRTableCell xrTableCell151 = XrTableCell217;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell151.Padding = padding;
		XrTableCell217.Text = "Fecha de Inicio";
		XrTableCell217.TextAlignment = TextAlignment.TopLeft;
		XrTableCell217.Weight = 0.2;
		XrTableCell218.Name = "XrTableCell218";
		XRTableCell xrTableCell152 = XrTableCell218;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell152.Padding = padding;
		XrTableCell218.Text = "Fecha de Termino";
		XrTableCell218.TextAlignment = TextAlignment.TopLeft;
		XrTableCell218.Weight = 0.2;
		XrTableCell219.Name = "XrTableCell219";
		XRTableCell xrTableCell153 = XrTableCell219;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell153.Padding = padding;
		XrTableCell219.Text = "Estado";
		XrTableCell219.TextAlignment = TextAlignment.TopLeft;
		XrTableCell219.Weight = 0.2;
		XrLabel18.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel28 = XrLabel18;
		locationFloat = new PointFloat(50f, 58f);
		xrLabel28.LocationFloat = locationFloat;
		XrLabel18.Name = "XrLabel18";
		XRLabel xrLabel29 = XrLabel18;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel29.Padding = padding;
		XRLabel xrLabel30 = XrLabel18;
		sizeF = new SizeF(367f, 25f);
		xrLabel30.SizeF = sizeF;
		XrLabel18.Text = "5.1  Estudios Realizados:";
		XrLabel18.TextAlignment = TextAlignment.TopLeft;
		XrLabel17.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel31 = XrLabel17;
		locationFloat = new PointFloat(50f, 17f);
		xrLabel31.LocationFloat = locationFloat;
		XrLabel17.Name = "XrLabel17";
		XRLabel xrLabel32 = XrLabel17;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel32.Padding = padding;
		XRLabel xrLabel33 = XrLabel17;
		sizeF = new SizeF(367f, 25f);
		xrLabel33.SizeF = sizeF;
		XrLabel17.Text = "V. ASPECTO DE EDUCACION DEL TRABAJADOR";
		XrLabel17.TextAlignment = TextAlignment.TopLeft;
		DetailReport3.Bands.AddRange(new Band[2] { Detail4, GroupHeader4 });
		DetailReport3.DataMember = "spRRHH_Ficha_Estudio_Titulo";
		DetailReport3.DataSource = DataSet11;
		DetailReport3.Level = 3;
		DetailReport3.Name = "DetailReport3";
		DetailReportBand detailReport4 = DetailReport3;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detailReport4.Padding = padding;
		DetailReport3.TextAlignment = TextAlignment.TopLeft;
		Detail4.Controls.AddRange(new XRControl[1] { XrTable19 });
		Detail4.HeightF = 27f;
		Detail4.Name = "Detail4";
		DetailBand detail5 = Detail4;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail5.Padding = padding;
		Detail4.TextAlignment = TextAlignment.TopLeft;
		XrTable19.Font = new Font("Times New Roman", 9.75f);
		XRTable xrTable40 = XrTable19;
		locationFloat = new PointFloat(50f, 0f);
		xrTable40.LocationFloat = locationFloat;
		XrTable19.Name = "XrTable19";
		XRTable xrTable41 = XrTable19;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable41.Padding = padding;
		XrTable19.Rows.AddRange(new XRTableRow[1] { XrTableRow64 });
		XRTable xrTable42 = XrTable19;
		sizeF = new SizeF(600f, 25f);
		xrTable42.SizeF = sizeF;
		XrTable19.TextAlignment = TextAlignment.TopLeft;
		XrTableRow64.Cells.AddRange(new XRTableCell[4] { XrTableCell229, XrTableCell230, XrTableCell231, XrTableCell232 });
		XrTableRow64.Name = "XrTableRow64";
		XRTableRow xrTableRow41 = XrTableRow64;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow41.Padding = padding;
		XrTableRow64.TextAlignment = TextAlignment.TopLeft;
		XrTableRow64.Weight = 1.0;
		XrTableCell229.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.NumColegiatura")
		});
		XrTableCell229.Name = "XrTableCell229";
		XRTableCell xrTableCell154 = XrTableCell229;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell154.Padding = padding;
		XrTableCell229.Text = "Num. Colegiatura";
		XrTableCell229.TextAlignment = TextAlignment.TopLeft;
		XrTableCell229.Weight = 5.0 / 24.0;
		XrTableCell230.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.DenominacionGrado")
		});
		XrTableCell230.Name = "XrTableCell230";
		XRTableCell xrTableCell155 = XrTableCell230;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell155.Padding = padding;
		XrTableCell230.Text = "Denominación del Grado y/o Título";
		XrTableCell230.TextAlignment = TextAlignment.TopLeft;
		XrTableCell230.Weight = 0.375;
		XrTableCell231.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.Institucion")
		});
		XrTableCell231.Name = "XrTableCell231";
		XRTableCell xrTableCell156 = XrTableCell231;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell156.Padding = padding;
		XrTableCell231.Text = "Institución";
		XrTableCell231.TextAlignment = TextAlignment.TopLeft;
		XrTableCell231.Weight = 71.0 / 300.0;
		XrTableCell232.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Titulo.Fecha", "{0:dd/MM/yyyy}")
		});
		XrTableCell232.Name = "XrTableCell232";
		XRTableCell xrTableCell157 = XrTableCell232;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell157.Padding = padding;
		XrTableCell232.Text = "Fecha";
		XrTableCell232.TextAlignment = TextAlignment.TopLeft;
		XrTableCell232.Weight = 0.18;
		GroupHeader4.Controls.AddRange(new XRControl[2] { XrTable18, XrLabel19 });
		GroupHeader4.HeightF = 83f;
		GroupHeader4.Name = "GroupHeader4";
		GroupHeaderBand groupHeader4 = GroupHeader4;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader4.Padding = padding;
		GroupHeader4.TextAlignment = TextAlignment.TopLeft;
		XrTable18.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable43 = XrTable18;
		locationFloat = new PointFloat(50f, 58f);
		xrTable43.LocationFloat = locationFloat;
		XrTable18.Name = "XrTable18";
		XRTable xrTable44 = XrTable18;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable44.Padding = padding;
		XrTable18.Rows.AddRange(new XRTableRow[1] { XrTableRow63 });
		XRTable xrTable45 = XrTable18;
		sizeF = new SizeF(600f, 25f);
		xrTable45.SizeF = sizeF;
		XrTable18.TextAlignment = TextAlignment.TopLeft;
		XrTableRow63.Cells.AddRange(new XRTableCell[4] { XrTableCell226, XrTableCell227, XrTableCell228, XrTableCell225 });
		XrTableRow63.Name = "XrTableRow63";
		XRTableRow xrTableRow42 = XrTableRow63;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow42.Padding = padding;
		XrTableRow63.TextAlignment = TextAlignment.TopLeft;
		XrTableRow63.Weight = 1.0;
		XrTableCell226.Name = "XrTableCell226";
		XRTableCell xrTableCell158 = XrTableCell226;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell158.Padding = padding;
		XrTableCell226.Text = "Num. Colegiatura";
		XrTableCell226.TextAlignment = TextAlignment.TopLeft;
		XrTableCell226.Weight = 5.0 / 24.0;
		XrTableCell227.Name = "XrTableCell227";
		XRTableCell xrTableCell159 = XrTableCell227;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell159.Padding = padding;
		XrTableCell227.Text = "Denominación del Grado y/o Título";
		XrTableCell227.TextAlignment = TextAlignment.TopLeft;
		XrTableCell227.Weight = 0.375;
		XrTableCell228.Name = "XrTableCell228";
		XRTableCell xrTableCell160 = XrTableCell228;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell160.Padding = padding;
		XrTableCell228.Text = "Institución";
		XrTableCell228.TextAlignment = TextAlignment.TopLeft;
		XrTableCell228.Weight = 71.0 / 300.0;
		XrTableCell225.Name = "XrTableCell225";
		XRTableCell xrTableCell161 = XrTableCell225;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell161.Padding = padding;
		XrTableCell225.Text = "Fecha";
		XrTableCell225.TextAlignment = TextAlignment.TopLeft;
		XrTableCell225.Weight = 0.18;
		XrLabel19.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel34 = XrLabel19;
		locationFloat = new PointFloat(50f, 17f);
		xrLabel34.LocationFloat = locationFloat;
		XrLabel19.Name = "XrLabel19";
		XRLabel xrLabel35 = XrLabel19;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel35.Padding = padding;
		XRLabel xrLabel36 = XrLabel19;
		sizeF = new SizeF(150f, 25f);
		xrLabel36.SizeF = sizeF;
		XrLabel19.Text = "5.2  Grados y Titulos:";
		XrLabel19.TextAlignment = TextAlignment.TopLeft;
		DetailReport4.Bands.AddRange(new Band[3] { Detail5, GroupHeader5, GroupFooter2 });
		DetailReport4.DataMember = "spRRHH_Ficha_Estudio_Capacitacion";
		DetailReport4.DataSource = DataSet11;
		DetailReport4.Level = 4;
		DetailReport4.Name = "DetailReport4";
		DetailReportBand detailReport5 = DetailReport4;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detailReport5.Padding = padding;
		DetailReport4.TextAlignment = TextAlignment.TopLeft;
		Detail5.Controls.AddRange(new XRControl[1] { XrTable21 });
		Detail5.HeightF = 25f;
		Detail5.Name = "Detail5";
		DetailBand detail6 = Detail5;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		detail6.Padding = padding;
		Detail5.TextAlignment = TextAlignment.TopLeft;
		XrTable21.Font = new Font("Times New Roman", 9.75f);
		XRTable xrTable46 = XrTable21;
		locationFloat = new PointFloat(50f, 0f);
		xrTable46.LocationFloat = locationFloat;
		XrTable21.Name = "XrTable21";
		XRTable xrTable47 = XrTable21;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable47.Padding = padding;
		XrTable21.Rows.AddRange(new XRTableRow[1] { XrTableRow66 });
		XRTable xrTable48 = XrTable21;
		sizeF = new SizeF(600f, 25f);
		xrTable48.SizeF = sizeF;
		XrTable21.TextAlignment = TextAlignment.TopLeft;
		XrTableRow66.Cells.AddRange(new XRTableCell[5] { XrTableCell238, XrTableCell239, XrTableCell240, XrTableCell241, XrTableCell242 });
		XrTableRow66.Name = "XrTableRow66";
		XRTableRow xrTableRow43 = XrTableRow66;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow43.Padding = padding;
		XrTableRow66.TextAlignment = TextAlignment.TopLeft;
		XrTableRow66.Weight = 1.0;
		XrTableCell238.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.NombreCurso")
		});
		XrTableCell238.Name = "XrTableCell238";
		XRTableCell xrTableCell162 = XrTableCell238;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell162.Padding = padding;
		XrTableCell238.Text = "Nombre del Curso";
		XrTableCell238.TextAlignment = TextAlignment.TopLeft;
		XrTableCell238.Weight = 0.2;
		XrTableCell239.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.FechaInicio", "{0:dd/MM/yyyy}")
		});
		XrTableCell239.Name = "XrTableCell239";
		XRTableCell xrTableCell163 = XrTableCell239;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell163.Padding = padding;
		XrTableCell239.Text = "Fecha de Inicio";
		XrTableCell239.TextAlignment = TextAlignment.TopLeft;
		XrTableCell239.Weight = 0.2;
		XrTableCell240.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.FechaFin", "{0:dd/MM/yyyy}")
		});
		XrTableCell240.Name = "XrTableCell240";
		XRTableCell xrTableCell164 = XrTableCell240;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell164.Padding = padding;
		XrTableCell240.Text = "Fecha de Fin";
		XrTableCell240.TextAlignment = TextAlignment.TopLeft;
		XrTableCell240.Weight = 0.2;
		XrTableCell241.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.NumHoras")
		});
		XrTableCell241.Name = "XrTableCell241";
		XRTableCell xrTableCell165 = XrTableCell241;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell165.Padding = padding;
		XrTableCell241.Text = "Nº de Horas";
		XrTableCell241.TextAlignment = TextAlignment.TopLeft;
		XrTableCell241.Weight = 0.2;
		XrTableCell242.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Capacitacion.InstitucionOrganizadora")
		});
		XrTableCell242.Name = "XrTableCell242";
		XRTableCell xrTableCell166 = XrTableCell242;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell166.Padding = padding;
		XrTableCell242.Text = "Inst. Organizadora";
		XrTableCell242.TextAlignment = TextAlignment.TopLeft;
		XrTableCell242.Weight = 0.2;
		GroupHeader5.Controls.AddRange(new XRControl[2] { XrTable20, XrLabel20 });
		GroupHeader5.HeightF = 83f;
		GroupHeader5.Name = "GroupHeader5";
		GroupHeaderBand groupHeader5 = GroupHeader5;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupHeader5.Padding = padding;
		GroupHeader5.TextAlignment = TextAlignment.TopLeft;
		XrTable20.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable49 = XrTable20;
		locationFloat = new PointFloat(50f, 58f);
		xrTable49.LocationFloat = locationFloat;
		XrTable20.Name = "XrTable20";
		XRTable xrTable50 = XrTable20;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable50.Padding = padding;
		XrTable20.Rows.AddRange(new XRTableRow[1] { XrTableRow65 });
		XRTable xrTable51 = XrTable20;
		sizeF = new SizeF(600f, 25f);
		xrTable51.SizeF = sizeF;
		XrTable20.TextAlignment = TextAlignment.TopLeft;
		XrTableRow65.Cells.AddRange(new XRTableCell[5] { XrTableCell233, XrTableCell234, XrTableCell235, XrTableCell236, XrTableCell237 });
		XrTableRow65.Name = "XrTableRow65";
		XRTableRow xrTableRow44 = XrTableRow65;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow44.Padding = padding;
		XrTableRow65.TextAlignment = TextAlignment.TopLeft;
		XrTableRow65.Weight = 1.0;
		XrTableCell233.Name = "XrTableCell233";
		XRTableCell xrTableCell167 = XrTableCell233;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell167.Padding = padding;
		XrTableCell233.Text = "Nombre del Curso";
		XrTableCell233.TextAlignment = TextAlignment.TopLeft;
		XrTableCell233.Weight = 0.2;
		XrTableCell234.Name = "XrTableCell234";
		XRTableCell xrTableCell168 = XrTableCell234;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell168.Padding = padding;
		XrTableCell234.Text = "Fecha de Inicio";
		XrTableCell234.TextAlignment = TextAlignment.TopLeft;
		XrTableCell234.Weight = 0.2;
		XrTableCell235.Name = "XrTableCell235";
		XRTableCell xrTableCell169 = XrTableCell235;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell169.Padding = padding;
		XrTableCell235.Text = "Fecha de Fin";
		XrTableCell235.TextAlignment = TextAlignment.TopLeft;
		XrTableCell235.Weight = 0.2;
		XrTableCell236.Name = "XrTableCell236";
		XRTableCell xrTableCell170 = XrTableCell236;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell170.Padding = padding;
		XrTableCell236.Text = "Nº de Horas";
		XrTableCell236.TextAlignment = TextAlignment.TopLeft;
		XrTableCell236.Weight = 0.2;
		XrTableCell237.Name = "XrTableCell237";
		XRTableCell xrTableCell171 = XrTableCell237;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell171.Padding = padding;
		XrTableCell237.Text = "Inst. Organizadora";
		XrTableCell237.TextAlignment = TextAlignment.TopLeft;
		XrTableCell237.Weight = 0.2;
		XrLabel20.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel37 = XrLabel20;
		locationFloat = new PointFloat(50f, 17f);
		xrLabel37.LocationFloat = locationFloat;
		XrLabel20.Name = "XrLabel20";
		XRLabel xrLabel38 = XrLabel20;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel38.Padding = padding;
		XRLabel xrLabel39 = XrLabel20;
		sizeF = new SizeF(133f, 25f);
		xrLabel39.SizeF = sizeF;
		XrLabel20.Text = "5.3  Capacitaciones:";
		XrLabel20.TextAlignment = TextAlignment.TopLeft;
		GroupFooter2.HeightF = 24f;
		GroupFooter2.Name = "GroupFooter2";
		GroupFooterBand groupFooter2 = GroupFooter2;
		padding = new PaddingInfo(0, 0, 0, 0, 100f);
		groupFooter2.Padding = padding;
		GroupFooter2.TextAlignment = TextAlignment.TopLeft;
		DetailReport5.Bands.AddRange(new Band[3] { Detail6, GroupHeader6, GroupFooter3 });
		DetailReport5.DataMember = "spRRHH_busca_Disciplina";
		DetailReport5.DataSource = DataSet11;
		DetailReport5.Level = 5;
		DetailReport5.Name = "DetailReport5";
		Detail6.Controls.AddRange(new XRControl[1] { XrTable11 });
		Detail6.HeightF = 25f;
		Detail6.Name = "Detail6";
		XRTable xrTable52 = XrTable11;
		locationFloat = new PointFloat(50f, 0f);
		xrTable52.LocationFloat = locationFloat;
		XrTable11.Name = "XrTable11";
		XrTable11.Rows.AddRange(new XRTableRow[1] { XrTableRow38 });
		XRTable xrTable53 = XrTable11;
		sizeF = new SizeF(633f, 25f);
		xrTable53.SizeF = sizeF;
		XrTableRow38.Cells.AddRange(new XRTableCell[5] { XrTableCell136, XrTableCell139, XrTableCell142, XrTableCell140, XrTableCell141 });
		XrTableRow38.Name = "XrTableRow38";
		XrTableRow38.Weight = 1.0;
		XrTableCell136.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_busca_Disciplina.TipoCompDescrip")
		});
		XrTableCell136.Name = "XrTableCell136";
		XrTableCell136.Text = "XrTableCell136";
		XrTableCell136.Weight = 0.5545023696682465;
		XrTableCell139.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_busca_Disciplina.Fecha", "{0:MM/dd/yyyy}")
		});
		XrTableCell139.Name = "XrTableCell139";
		XrTableCell139.Text = "XrTableCell139";
		XrTableCell139.Weight = 0.5900473933649288;
		XrTableCell142.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_busca_Disciplina.NumResol")
		});
		XrTableCell142.Name = "XrTableCell142";
		XrTableCell142.Text = "XrTableCell142";
		XrTableCell142.Weight = 235.0 / 422.0;
		XrTableCell140.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_busca_Disciplina.Titulo")
		});
		XrTableCell140.Name = "XrTableCell140";
		XrTableCell140.Text = "XrTableCell140";
		XrTableCell140.Weight = 0.5900473933649288;
		XrTableCell141.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_busca_Disciplina.Descripcion")
		});
		XrTableCell141.Name = "XrTableCell141";
		XrTableCell141.Text = "XrTableCell141";
		XrTableCell141.Weight = 0.7085308056872037;
		GroupHeader6.Controls.AddRange(new XRControl[2] { XrTable10, XrLabel3 });
		GroupHeader6.HeightF = 83f;
		GroupHeader6.Name = "GroupHeader6";
		XrTable10.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable54 = XrTable10;
		locationFloat = new PointFloat(50f, 58f);
		xrTable54.LocationFloat = locationFloat;
		XrTable10.Name = "XrTable10";
		XRTable xrTable55 = XrTable10;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTable55.Padding = padding;
		XrTable10.Rows.AddRange(new XRTableRow[1] { XrTableRow37 });
		XRTable xrTable56 = XrTable10;
		sizeF = new SizeF(633f, 25f);
		xrTable56.SizeF = sizeF;
		XrTable10.TextAlignment = TextAlignment.TopLeft;
		XrTableRow37.Cells.AddRange(new XRTableCell[5] { XrTableCell84, XrTableCell121, XrTableCell124, XrTableCell125, XrTableCell128 });
		XrTableRow37.Name = "XrTableRow37";
		XRTableRow xrTableRow45 = XrTableRow37;
		padding = new PaddingInfo(0, 0, 0, 0, 96f);
		xrTableRow45.Padding = padding;
		XrTableRow37.TextAlignment = TextAlignment.TopLeft;
		XrTableRow37.Weight = 1.0;
		XrTableCell84.Name = "XrTableCell84";
		XRTableCell xrTableCell172 = XrTableCell84;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell172.Padding = padding;
		XrTableCell84.Text = "Tipo";
		XrTableCell84.TextAlignment = TextAlignment.TopLeft;
		XrTableCell84.Weight = 0.2;
		XrTableCell121.Name = "XrTableCell121";
		XRTableCell xrTableCell173 = XrTableCell121;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell173.Padding = padding;
		XrTableCell121.Text = "Fecha";
		XrTableCell121.TextAlignment = TextAlignment.TopLeft;
		XrTableCell121.Weight = 0.2;
		XrTableCell124.Name = "XrTableCell124";
		XRTableCell xrTableCell174 = XrTableCell124;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell174.Padding = padding;
		XrTableCell124.Text = "Nro. Documento";
		XrTableCell124.TextAlignment = TextAlignment.TopLeft;
		XrTableCell124.Weight = 0.2;
		XrTableCell125.Name = "XrTableCell125";
		XRTableCell xrTableCell175 = XrTableCell125;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell175.Padding = padding;
		XrTableCell125.Text = "Titulo";
		XrTableCell125.TextAlignment = TextAlignment.TopLeft;
		XrTableCell125.Weight = 0.2;
		XrTableCell128.Name = "XrTableCell128";
		XRTableCell xrTableCell176 = XrTableCell128;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell176.Padding = padding;
		XrTableCell128.Text = "Descripcion";
		XrTableCell128.TextAlignment = TextAlignment.TopLeft;
		XrTableCell128.Weight = 0.255;
		XrLabel3.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel40 = XrLabel3;
		locationFloat = new PointFloat(50f, 17f);
		xrLabel40.LocationFloat = locationFloat;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel41 = XrLabel3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel41.Padding = padding;
		XRLabel xrLabel42 = XrLabel3;
		sizeF = new SizeF(233f, 25f);
		xrLabel42.SizeF = sizeF;
		XrLabel3.Text = "5.4  Aspecto Disciplinario:";
		XrLabel3.TextAlignment = TextAlignment.TopLeft;
		GroupFooter3.Name = "GroupFooter3";
		SpRRHH_busca_DisciplinaTableAdapter.ClearBeforeFill = true;
		TopMarginBand1.HeightF = 50f;
		TopMarginBand1.Name = "TopMarginBand1";
		BottomMarginBand1.HeightF = 40f;
		BottomMarginBand1.Name = "BottomMarginBand1";
		Bands.AddRange(new Band[11]
		{
			Detail, PageHeader, PageFooter, DetailReport, DetailReport1, DetailReport2, DetailReport3, DetailReport4, DetailReport5, TopMarginBand1,
			BottomMarginBand1
		});
		DataAdapter = SpRRHH_Ficha_ExpLabTableAdapter;
		DataMember = "spRRHH_Ficha_DatosPersonales";
		DataSource = DataSet11;
		Margins = new Margins(100, 30, 50, 40);
		PageHeight = 1169;
		PageWidth = 827;
		PaperKind = PaperKind.A4;
		Version = "11.2";
		((ISupportInitialize)XrTable8).EndInit();
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)XrTable3).EndInit();
		((ISupportInitialize)XrTable6).EndInit();
		((ISupportInitialize)XrTable4).EndInit();
		((ISupportInitialize)XrTable5).EndInit();
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)XrTable12).EndInit();
		((ISupportInitialize)XrTable13).EndInit();
		((ISupportInitialize)XrTable7).EndInit();
		((ISupportInitialize)XrTable9).EndInit();
		((ISupportInitialize)XrTable17).EndInit();
		((ISupportInitialize)XrTable16).EndInit();
		((ISupportInitialize)XrTable19).EndInit();
		((ISupportInitialize)XrTable18).EndInit();
		((ISupportInitialize)XrTable21).EndInit();
		((ISupportInitialize)XrTable20).EndInit();
		((ISupportInitialize)XrTable11).EndInit();
		((ISupportInitialize)XrTable10).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
