using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using Microsoft.VisualBasic.CompilerServices;
using RecursosHumanos.DataSet1TableAdapters;

namespace RecursosHumanos;

[DesignerGenerated]
public class Report_FichaSocial_L : XtraReport
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Detail")]
	private DetailBand _Detail;

	[AccessedThroughProperty("PageHeader")]
	private PageHeaderBand _PageHeader;

	[AccessedThroughProperty("PageFooter")]
	private PageFooterBand _PageFooter;

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

	[AccessedThroughProperty("DataSet11")]
	private DataSet1 _DataSet11;

	[AccessedThroughProperty("SpRRHH_Report_CuadroPerTableAdapter")]
	private spRRHH_Report_CuadroPerTableAdapter _SpRRHH_Report_CuadroPerTableAdapter;

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

	[AccessedThroughProperty("XrLabel3")]
	private XRLabel _XrLabel3;

	[AccessedThroughProperty("XrPictureBox1")]
	private XRPictureBox _XrPictureBox1;

	[AccessedThroughProperty("DetailReport")]
	private DetailReportBand _DetailReport;

	[AccessedThroughProperty("Detail1")]
	private DetailBand _Detail1;

	[AccessedThroughProperty("GroupHeader1")]
	private GroupHeaderBand _GroupHeader1;

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

	[AccessedThroughProperty("XrLabel5")]
	private XRLabel _XrLabel5;

	[AccessedThroughProperty("XrTableRow12")]
	private XRTableRow _XrTableRow12;

	[AccessedThroughProperty("XrTableCell55")]
	private XRTableCell _XrTableCell55;

	[AccessedThroughProperty("XrTableCell56")]
	private XRTableCell _XrTableCell56;

	[AccessedThroughProperty("XrTable4")]
	private XRTable _XrTable4;

	[AccessedThroughProperty("XrTableRow19")]
	private XRTableRow _XrTableRow19;

	[AccessedThroughProperty("XrTableCell83")]
	private XRTableCell _XrTableCell83;

	[AccessedThroughProperty("XrTableCell71")]
	private XRTableCell _XrTableCell71;

	[AccessedThroughProperty("XrTableRow18")]
	private XRTableRow _XrTableRow18;

	[AccessedThroughProperty("XrTableCell80")]
	private XRTableCell _XrTableCell80;

	[AccessedThroughProperty("XrTableCell84")]
	private XRTableCell _XrTableCell84;

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

	[AccessedThroughProperty("DetailReport1")]
	private DetailReportBand _DetailReport1;

	[AccessedThroughProperty("Detail2")]
	private DetailBand _Detail2;

	[AccessedThroughProperty("GroupHeader2")]
	private GroupHeaderBand _GroupHeader2;

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

	[AccessedThroughProperty("XrTableCell132")]
	private XRTableCell _XrTableCell132;

	[AccessedThroughProperty("XrTableCell133")]
	private XRTableCell _XrTableCell133;

	[AccessedThroughProperty("XrCheckBoxLabInst")]
	private XRCheckBox _XrCheckBoxLabInst;

	[AccessedThroughProperty("XrCheckBoxViveCasa")]
	private XRCheckBox _XrCheckBoxViveCasa;

	[AccessedThroughProperty("DetailReport2")]
	private DetailReportBand _DetailReport2;

	[AccessedThroughProperty("Detail3")]
	private DetailBand _Detail3;

	[AccessedThroughProperty("GroupHeader3")]
	private GroupHeaderBand _GroupHeader3;

	[AccessedThroughProperty("GroupFooter1")]
	private GroupFooterBand _GroupFooter1;

	[AccessedThroughProperty("XrLabel13")]
	private XRLabel _XrLabel13;

	[AccessedThroughProperty("XrLabel12")]
	private XRLabel _XrLabel12;

	[AccessedThroughProperty("XrLabel11")]
	private XRLabel _XrLabel11;

	[AccessedThroughProperty("XrLabel10")]
	private XRLabel _XrLabel10;

	[AccessedThroughProperty("XrLabel9")]
	private XRLabel _XrLabel9;

	[AccessedThroughProperty("XrLabel2")]
	private XRLabel _XrLabel2;

	[AccessedThroughProperty("XrTable10")]
	private XRTable _XrTable10;

	[AccessedThroughProperty("XrTableRow38")]
	private XRTableRow _XrTableRow38;

	[AccessedThroughProperty("XrTableCell140")]
	private XRTableCell _XrTableCell140;

	[AccessedThroughProperty("XrTableCell141")]
	private XRTableCell _XrTableCell141;

	[AccessedThroughProperty("XrTableRow47")]
	private XRTableRow _XrTableRow47;

	[AccessedThroughProperty("XrTableCell179")]
	private XRTableCell _XrTableCell179;

	[AccessedThroughProperty("XrTableCell180")]
	private XRTableCell _XrTableCell180;

	[AccessedThroughProperty("XrTableRow48")]
	private XRTableRow _XrTableRow48;

	[AccessedThroughProperty("XrTableCell183")]
	private XRTableCell _XrTableCell183;

	[AccessedThroughProperty("XrTableCell184")]
	private XRTableCell _XrTableCell184;

	[AccessedThroughProperty("XrLabel1")]
	private XRLabel _XrLabel1;

	[AccessedThroughProperty("DetailReport3")]
	private DetailReportBand _DetailReport3;

	[AccessedThroughProperty("Detail4")]
	private DetailBand _Detail4;

	[AccessedThroughProperty("GroupHeader4")]
	private GroupHeaderBand _GroupHeader4;

	[AccessedThroughProperty("XrTable15")]
	private XRTable _XrTable15;

	[AccessedThroughProperty("XrTableRow59")]
	private XRTableRow _XrTableRow59;

	[AccessedThroughProperty("XrTableCell210")]
	private XRTableCell _XrTableCell210;

	[AccessedThroughProperty("XrTableCell211")]
	private XRTableCell _XrTableCell211;

	[AccessedThroughProperty("XrTableRow60")]
	private XRTableRow _XrTableRow60;

	[AccessedThroughProperty("XrTableCell213")]
	private XRTableCell _XrTableCell213;

	[AccessedThroughProperty("XrTableCell214")]
	private XRTableCell _XrTableCell214;

	[AccessedThroughProperty("XrTable14")]
	private XRTable _XrTable14;

	[AccessedThroughProperty("XrTableRow53")]
	private XRTableRow _XrTableRow53;

	[AccessedThroughProperty("XrTableCell195")]
	private XRTableCell _XrTableCell195;

	[AccessedThroughProperty("XrTableCell196")]
	private XRTableCell _XrTableCell196;

	[AccessedThroughProperty("XrTableRow54")]
	private XRTableRow _XrTableRow54;

	[AccessedThroughProperty("XrTableCell197")]
	private XRTableCell _XrTableCell197;

	[AccessedThroughProperty("XrTableCell198")]
	private XRTableCell _XrTableCell198;

	[AccessedThroughProperty("XrTableRow55")]
	private XRTableRow _XrTableRow55;

	[AccessedThroughProperty("XrTableCell199")]
	private XRTableCell _XrTableCell199;

	[AccessedThroughProperty("XrTableCell200")]
	private XRTableCell _XrTableCell200;

	[AccessedThroughProperty("XrTableRow56")]
	private XRTableRow _XrTableRow56;

	[AccessedThroughProperty("XrTableCell201")]
	private XRTableCell _XrTableCell201;

	[AccessedThroughProperty("XrTableCell202")]
	private XRTableCell _XrTableCell202;

	[AccessedThroughProperty("XrTable11")]
	private XRTable _XrTable11;

	[AccessedThroughProperty("XrTableRow49")]
	private XRTableRow _XrTableRow49;

	[AccessedThroughProperty("XrTableCell187")]
	private XRTableCell _XrTableCell187;

	[AccessedThroughProperty("XrTableCell188")]
	private XRTableCell _XrTableCell188;

	[AccessedThroughProperty("XrTableRow50")]
	private XRTableRow _XrTableRow50;

	[AccessedThroughProperty("XrTableCell189")]
	private XRTableCell _XrTableCell189;

	[AccessedThroughProperty("XrTableCell190")]
	private XRTableCell _XrTableCell190;

	[AccessedThroughProperty("XrTableRow51")]
	private XRTableRow _XrTableRow51;

	[AccessedThroughProperty("XrTableCell191")]
	private XRTableCell _XrTableCell191;

	[AccessedThroughProperty("XrTableCell192")]
	private XRTableCell _XrTableCell192;

	[AccessedThroughProperty("XrTableRow52")]
	private XRTableRow _XrTableRow52;

	[AccessedThroughProperty("XrTableCell193")]
	private XRTableCell _XrTableCell193;

	[AccessedThroughProperty("XrTableCell194")]
	private XRTableCell _XrTableCell194;

	[AccessedThroughProperty("XrLabel15")]
	private XRLabel _XrLabel15;

	[AccessedThroughProperty("DetailReport4")]
	private DetailReportBand _DetailReport4;

	[AccessedThroughProperty("Detail5")]
	private DetailBand _Detail5;

	[AccessedThroughProperty("GroupHeader5")]
	private GroupHeaderBand _GroupHeader5;

	[AccessedThroughProperty("XrLabel18")]
	private XRLabel _XrLabel18;

	[AccessedThroughProperty("XrLabel17")]
	private XRLabel _XrLabel17;

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

	[AccessedThroughProperty("XrPageInfo1")]
	private XRPageInfo _XrPageInfo1;

	[AccessedThroughProperty("XrCheckBoxJefe")]
	private XRCheckBox _XrCheckBoxJefe;

	[AccessedThroughProperty("XrTableCell14")]
	private XRTableCell _XrTableCell14;

	[AccessedThroughProperty("XrTableCell19")]
	private XRTableCell _XrTableCell19;

	[AccessedThroughProperty("XrTable1")]
	private XRTable _XrTable1;

	[AccessedThroughProperty("XrTableRow4")]
	private XRTableRow _XrTableRow4;

	[AccessedThroughProperty("XrTableCell20")]
	private XRTableCell _XrTableCell20;

	[AccessedThroughProperty("XrTableCell21")]
	private XRTableCell _XrTableCell21;

	[AccessedThroughProperty("XrTableRow14")]
	private XRTableRow _XrTableRow14;

	[AccessedThroughProperty("XrTableCell53")]
	private XRTableCell _XrTableCell53;

	[AccessedThroughProperty("XrTableCell54")]
	private XRTableCell _XrTableCell54;

	[AccessedThroughProperty("XrTableRow13")]
	private XRTableRow _XrTableRow13;

	[AccessedThroughProperty("XrTableCell44")]
	private XRTableCell _XrTableCell44;

	[AccessedThroughProperty("XrTableCell50")]
	private XRTableCell _XrTableCell50;

	[AccessedThroughProperty("XrTableRow6")]
	private XRTableRow _XrTableRow6;

	[AccessedThroughProperty("XrTableCell37")]
	private XRTableCell _XrTableCell37;

	[AccessedThroughProperty("XrTableCell38")]
	private XRTableCell _XrTableCell38;

	[AccessedThroughProperty("XrTable3")]
	private XRTable _XrTable3;

	[AccessedThroughProperty("XrTableRow15")]
	private XRTableRow _XrTableRow15;

	[AccessedThroughProperty("XrTableCell22")]
	private XRTableCell _XrTableCell22;

	[AccessedThroughProperty("XrTableCell39")]
	private XRTableCell _XrTableCell39;

	[AccessedThroughProperty("XrLabel14")]
	private XRLabel _XrLabel14;

	[AccessedThroughProperty("XrLabel8")]
	private XRLabel _XrLabel8;

	[AccessedThroughProperty("XrTableCell57")]
	private XRTableCell _XrTableCell57;

	[AccessedThroughProperty("XrTableRow63")]
	private XRTableRow _XrTableRow63;

	[AccessedThroughProperty("XrTableCell226")]
	private XRTableCell _XrTableCell226;

	[AccessedThroughProperty("XrTableCell227")]
	private XRTableCell _XrTableCell227;

	[AccessedThroughProperty("XrTableCell228")]
	private XRTableCell _XrTableCell228;

	[AccessedThroughProperty("XrTableRow33")]
	private XRTableRow _XrTableRow33;

	[AccessedThroughProperty("XrTableCell97")]
	private XRTableCell _XrTableCell97;

	[AccessedThroughProperty("XrTableCell121")]
	private XRTableCell _XrTableCell121;

	[AccessedThroughProperty("XrTableCell122")]
	private XRTableCell _XrTableCell122;

	[AccessedThroughProperty("XrTableRow23")]
	private XRTableRow _XrTableRow23;

	[AccessedThroughProperty("XrTableCell89")]
	private XRTableCell _XrTableCell89;

	[AccessedThroughProperty("XrTableCell90")]
	private XRTableCell _XrTableCell90;

	[AccessedThroughProperty("XrTableCell91")]
	private XRTableCell _XrTableCell91;

	[AccessedThroughProperty("XrTableRow22")]
	private XRTableRow _XrTableRow22;

	[AccessedThroughProperty("XrTableCell82")]
	private XRTableCell _XrTableCell82;

	[AccessedThroughProperty("XrTableCell85")]
	private XRTableCell _XrTableCell85;

	[AccessedThroughProperty("XrTableCell86")]
	private XRTableCell _XrTableCell86;

	[AccessedThroughProperty("XrTableRow21")]
	private XRTableRow _XrTableRow21;

	[AccessedThroughProperty("XrTableCell76")]
	private XRTableCell _XrTableCell76;

	[AccessedThroughProperty("XrTableCell77")]
	private XRTableCell _XrTableCell77;

	[AccessedThroughProperty("XrTableCell78")]
	private XRTableCell _XrTableCell78;

	[AccessedThroughProperty("XrTableRow20")]
	private XRTableRow _XrTableRow20;

	[AccessedThroughProperty("XrTableCell69")]
	private XRTableCell _XrTableCell69;

	[AccessedThroughProperty("XrTableCell70")]
	private XRTableCell _XrTableCell70;

	[AccessedThroughProperty("XrTableCell72")]
	private XRTableCell _XrTableCell72;

	[AccessedThroughProperty("XrTableRow16")]
	private XRTableRow _XrTableRow16;

	[AccessedThroughProperty("XrTableCell51")]
	private XRTableCell _XrTableCell51;

	[AccessedThroughProperty("XrTableCell58")]
	private XRTableCell _XrTableCell58;

	[AccessedThroughProperty("XrTableCell59")]
	private XRTableCell _XrTableCell59;

	[AccessedThroughProperty("XrTableRow17")]
	private XRTableRow _XrTableRow17;

	[AccessedThroughProperty("XrTableCell60")]
	private XRTableCell _XrTableCell60;

	[AccessedThroughProperty("XrTableCell61")]
	private XRTableCell _XrTableCell61;

	[AccessedThroughProperty("XrTableCell62")]
	private XRTableCell _XrTableCell62;

	[AccessedThroughProperty("XrTableRow34")]
	private XRTableRow _XrTableRow34;

	[AccessedThroughProperty("XrTableCell63")]
	private XRTableCell _XrTableCell63;

	[AccessedThroughProperty("XrTableCell64")]
	private XRTableCell _XrTableCell64;

	[AccessedThroughProperty("XrTableCell65")]
	private XRTableCell _XrTableCell65;

	[AccessedThroughProperty("DetailReport5")]
	private DetailReportBand _DetailReport5;

	[AccessedThroughProperty("Detail6")]
	private DetailBand _Detail6;

	[AccessedThroughProperty("GroupHeader6")]
	private GroupHeaderBand _GroupHeader6;

	[AccessedThroughProperty("XrTable5")]
	private XRTable _XrTable5;

	[AccessedThroughProperty("XrTableRow64")]
	private XRTableRow _XrTableRow64;

	[AccessedThroughProperty("XrTableCell66")]
	private XRTableCell _XrTableCell66;

	[AccessedThroughProperty("XrLabel16")]
	private XRLabel _XrLabel16;

	[AccessedThroughProperty("DetailReport6")]
	private DetailReportBand _DetailReport6;

	[AccessedThroughProperty("Detail7")]
	private DetailBand _Detail7;

	[AccessedThroughProperty("XrTableRow68")]
	private XRTableRow _XrTableRow68;

	[AccessedThroughProperty("XrTableCell88")]
	private XRTableCell _XrTableCell88;

	[AccessedThroughProperty("XrTableRow69")]
	private XRTableRow _XrTableRow69;

	[AccessedThroughProperty("XrTableCell93")]
	private XRTableCell _XrTableCell93;

	[AccessedThroughProperty("XrTableRow67")]
	private XRTableRow _XrTableRow67;

	[AccessedThroughProperty("XrTableCell81")]
	private XRTableCell _XrTableCell81;

	[AccessedThroughProperty("XrTableRow66")]
	private XRTableRow _XrTableRow66;

	[AccessedThroughProperty("XrTableCell75")]
	private XRTableCell _XrTableCell75;

	[AccessedThroughProperty("XrTableRow65")]
	private XRTableRow _XrTableRow65;

	[AccessedThroughProperty("XrTableCell68")]
	private XRTableCell _XrTableCell68;

	[AccessedThroughProperty("XrTableRow70")]
	private XRTableRow _XrTableRow70;

	[AccessedThroughProperty("XrTableCell124")]
	private XRTableCell _XrTableCell124;

	[AccessedThroughProperty("XrTableRow76")]
	private XRTableRow _XrTableRow76;

	[AccessedThroughProperty("XrTableCell123")]
	private XRTableCell _XrTableCell123;

	[AccessedThroughProperty("XrTableRow75")]
	private XRTableRow _XrTableRow75;

	[AccessedThroughProperty("XrTableCell92")]
	private XRTableCell _XrTableCell92;

	[AccessedThroughProperty("XrTableRow74")]
	private XRTableRow _XrTableRow74;

	[AccessedThroughProperty("XrTableCell87")]
	private XRTableCell _XrTableCell87;

	[AccessedThroughProperty("XrTableRow73")]
	private XRTableRow _XrTableRow73;

	[AccessedThroughProperty("XrTableCell79")]
	private XRTableCell _XrTableCell79;

	[AccessedThroughProperty("XrTableRow72")]
	private XRTableRow _XrTableRow72;

	[AccessedThroughProperty("XrTableCell73")]
	private XRTableCell _XrTableCell73;

	[AccessedThroughProperty("XrTableRow71")]
	private XRTableRow _XrTableRow71;

	[AccessedThroughProperty("XrTableCell67")]
	private XRTableCell _XrTableCell67;

	[AccessedThroughProperty("XrTableRow77")]
	private XRTableRow _XrTableRow77;

	[AccessedThroughProperty("XrTableCell125")]
	private XRTableCell _XrTableCell125;

	[AccessedThroughProperty("XrTable8")]
	private XRTable _XrTable8;

	[AccessedThroughProperty("XrTableRow78")]
	private XRTableRow _XrTableRow78;

	[AccessedThroughProperty("XrTableCell127")]
	private XRTableCell _XrTableCell127;

	[AccessedThroughProperty("XrTableRow79")]
	private XRTableRow _XrTableRow79;

	[AccessedThroughProperty("XrTableCell229")]
	private XRTableCell _XrTableCell229;

	[AccessedThroughProperty("XrTableCell230")]
	private XRTableCell _XrTableCell230;

	[AccessedThroughProperty("XrTableRow80")]
	private XRTableRow _XrTableRow80;

	[AccessedThroughProperty("XrTableCell233")]
	private XRTableCell _XrTableCell233;

	[AccessedThroughProperty("XrTableCell234")]
	private XRTableCell _XrTableCell234;

	[AccessedThroughProperty("XrTableRow81")]
	private XRTableRow _XrTableRow81;

	[AccessedThroughProperty("XrTableCell237")]
	private XRTableCell _XrTableCell237;

	[AccessedThroughProperty("XrTableCell238")]
	private XRTableCell _XrTableCell238;

	[AccessedThroughProperty("XrTableRow82")]
	private XRTableRow _XrTableRow82;

	[AccessedThroughProperty("XrTableCell241")]
	private XRTableCell _XrTableCell241;

	[AccessedThroughProperty("XrTableCell242")]
	private XRTableCell _XrTableCell242;

	[AccessedThroughProperty("XrTableRow83")]
	private XRTableRow _XrTableRow83;

	[AccessedThroughProperty("XrTableCell245")]
	private XRTableCell _XrTableCell245;

	[AccessedThroughProperty("XrTableCell246")]
	private XRTableCell _XrTableCell246;

	[AccessedThroughProperty("XrTableRow84")]
	private XRTableRow _XrTableRow84;

	[AccessedThroughProperty("XrTableCell249")]
	private XRTableCell _XrTableCell249;

	[AccessedThroughProperty("XrTableCell250")]
	private XRTableCell _XrTableCell250;

	[AccessedThroughProperty("XrTableRow85")]
	private XRTableRow _XrTableRow85;

	[AccessedThroughProperty("XrTableCell253")]
	private XRTableCell _XrTableCell253;

	[AccessedThroughProperty("XrTableCell254")]
	private XRTableCell _XrTableCell254;

	[AccessedThroughProperty("XrTableRow87")]
	private XRTableRow _XrTableRow87;

	[AccessedThroughProperty("XrTableCell261")]
	private XRTableCell _XrTableCell261;

	[AccessedThroughProperty("XrTableCell262")]
	private XRTableCell _XrTableCell262;

	[AccessedThroughProperty("XrTableRow37")]
	private XRTableRow _XrTableRow37;

	[AccessedThroughProperty("XrTableCell126")]
	private XRTableCell _XrTableCell126;

	[AccessedThroughProperty("XrTableCell154")]
	private XRTableCell _XrTableCell154;

	[AccessedThroughProperty("XrTableCell136")]
	private XRTableCell _XrTableCell136;

	[AccessedThroughProperty("XrTableCell155")]
	private XRTableCell _XrTableCell155;

	[AccessedThroughProperty("XrTableCell139")]
	private XRTableCell _XrTableCell139;

	[AccessedThroughProperty("XrTableCell156")]
	private XRTableCell _XrTableCell156;

	[AccessedThroughProperty("XrTableCell142")]
	private XRTableCell _XrTableCell142;

	[AccessedThroughProperty("XrTableCell157")]
	private XRTableCell _XrTableCell157;

	[AccessedThroughProperty("XrTableCell147")]
	private XRTableCell _XrTableCell147;

	[AccessedThroughProperty("XrTableCell158")]
	private XRTableCell _XrTableCell158;

	[AccessedThroughProperty("XrTableCell148")]
	private XRTableCell _XrTableCell148;

	[AccessedThroughProperty("XrTableCell159")]
	private XRTableCell _XrTableCell159;

	[AccessedThroughProperty("XrTableCell149")]
	private XRTableCell _XrTableCell149;

	[AccessedThroughProperty("XrTableCell160")]
	private XRTableCell _XrTableCell160;

	[AccessedThroughProperty("XrTableCell150")]
	private XRTableCell _XrTableCell150;

	[AccessedThroughProperty("GroupHeader7")]
	private GroupHeaderBand _GroupHeader7;

	[AccessedThroughProperty("XrLabel19")]
	private XRLabel _XrLabel19;

	[AccessedThroughProperty("GroupFooter2")]
	private GroupFooterBand _GroupFooter2;

	[AccessedThroughProperty("XrLine2")]
	private XRLine _XrLine2;

	[AccessedThroughProperty("XrLine1")]
	private XRLine _XrLine1;

	[AccessedThroughProperty("XrLabel21")]
	private XRLabel _XrLabel21;

	[AccessedThroughProperty("XrLabel20")]
	private XRLabel _XrLabel20;

	[AccessedThroughProperty("XrLabel24")]
	private XRLabel _XrLabel24;

	[AccessedThroughProperty("XrLabel23")]
	private XRLabel _XrLabel23;

	[AccessedThroughProperty("XrPageInfo2")]
	private XRPageInfo _XrPageInfo2;

	[AccessedThroughProperty("XrLabel22")]
	private XRLabel _XrLabel22;

	[AccessedThroughProperty("XrTable18")]
	private XRTable _XrTable18;

	[AccessedThroughProperty("XrTableRow41")]
	private XRTableRow _XrTableRow41;

	[AccessedThroughProperty("XrTableCell128")]
	private XRTableCell _XrTableCell128;

	[AccessedThroughProperty("XrTableCell151")]
	private XRTableCell _XrTableCell151;

	[AccessedThroughProperty("XrTableCell152")]
	private XRTableCell _XrTableCell152;

	[AccessedThroughProperty("XrTableCell153")]
	private XRTableCell _XrTableCell153;

	[AccessedThroughProperty("XrTableRow42")]
	private XRTableRow _XrTableRow42;

	[AccessedThroughProperty("XrTableCell161")]
	private XRTableCell _XrTableCell161;

	[AccessedThroughProperty("XrTableCell162")]
	private XRTableCell _XrTableCell162;

	[AccessedThroughProperty("XrTableCell170")]
	private XRTableCell _XrTableCell170;

	[AccessedThroughProperty("XrTableCell171")]
	private XRTableCell _XrTableCell171;

	[AccessedThroughProperty("XrTableRow44")]
	private XRTableRow _XrTableRow44;

	[AccessedThroughProperty("XrTableCell176")]
	private XRTableCell _XrTableCell176;

	[AccessedThroughProperty("XrTableCell178")]
	private XRTableCell _XrTableCell178;

	[AccessedThroughProperty("XrTable19")]
	private XRTable _XrTable19;

	[AccessedThroughProperty("XrTableRow45")]
	private XRTableRow _XrTableRow45;

	[AccessedThroughProperty("XrTableCell177")]
	private XRTableCell _XrTableCell177;

	[AccessedThroughProperty("XrTableCell203")]
	private XRTableCell _XrTableCell203;

	[AccessedThroughProperty("XrTableCell185")]
	private XRTableCell _XrTableCell185;

	[AccessedThroughProperty("XrTableCell181")]
	private XRTableCell _XrTableCell181;

	[AccessedThroughProperty("XrTableCell182")]
	private XRTableCell _XrTableCell182;

	[AccessedThroughProperty("XrTableCell186")]
	private XRTableCell _XrTableCell186;

	[AccessedThroughProperty("XrTableCell204")]
	private XRTableCell _XrTableCell204;

	[AccessedThroughProperty("XrTable20")]
	private XRTable _XrTable20;

	[AccessedThroughProperty("XrTableRow46")]
	private XRTableRow _XrTableRow46;

	[AccessedThroughProperty("XrTableCell205")]
	private XRTableCell _XrTableCell205;

	[AccessedThroughProperty("XrTableCell225")]
	private XRTableCell _XrTableCell225;

	[AccessedThroughProperty("XrTableCell231")]
	private XRTableCell _XrTableCell231;

	[AccessedThroughProperty("XrTableCell232")]
	private XRTableCell _XrTableCell232;

	[AccessedThroughProperty("XrTableCell235")]
	private XRTableCell _XrTableCell235;

	[AccessedThroughProperty("XrTableCell236")]
	private XRTableCell _XrTableCell236;

	[AccessedThroughProperty("XrTableCell239")]
	private XRTableCell _XrTableCell239;

	[AccessedThroughProperty("XrCheckBox1")]
	private XRCheckBox _XrCheckBox1;

	[AccessedThroughProperty("XrTableRow43")]
	private XRTableRow _XrTableRow43;

	[AccessedThroughProperty("XrTableCell172")]
	private XRTableCell _XrTableCell172;

	[AccessedThroughProperty("XrTableCell173")]
	private XRTableCell _XrTableCell173;

	[AccessedThroughProperty("XrTableCell174")]
	private XRTableCell _XrTableCell174;

	[AccessedThroughProperty("XrTableCell175")]
	private XRTableCell _XrTableCell175;

	[AccessedThroughProperty("XrCheckBoxEnfCronica")]
	private XRCheckBox _XrCheckBoxEnfCronica;

	[AccessedThroughProperty("XrCheckBoxFamDisc")]
	private XRCheckBox _XrCheckBoxFamDisc;

	[AccessedThroughProperty("XrTableCell206")]
	private XRTableCell _XrTableCell206;

	[AccessedThroughProperty("XrTableCell208")]
	private XRTableCell _XrTableCell208;

	[AccessedThroughProperty("XrTableCell207")]
	private XRTableCell _XrTableCell207;

	[AccessedThroughProperty("XrTableCell209")]
	private XRTableCell _XrTableCell209;

	[AccessedThroughProperty("SpRRHH_Ficha_ExpLabTableAdapter")]
	private spRRHH_Ficha_ExpLabTableAdapter _SpRRHH_Ficha_ExpLabTableAdapter;

	[AccessedThroughProperty("XrTableRow57")]
	private XRTableRow _XrTableRow57;

	[AccessedThroughProperty("XrTableCell212")]
	private XRTableCell _XrTableCell212;

	[AccessedThroughProperty("XrCheckBoxCable")]
	private XRCheckBox _XrCheckBoxCable;

	[AccessedThroughProperty("XrCheckBoxInter")]
	private XRCheckBox _XrCheckBoxInter;

	[AccessedThroughProperty("XrCheckBoxFono")]
	private XRCheckBox _XrCheckBoxFono;

	[AccessedThroughProperty("XrTableRow86")]
	private XRTableRow _XrTableRow86;

	[AccessedThroughProperty("XrTableCell243")]
	private XRTableCell _XrTableCell243;

	[AccessedThroughProperty("XrTableCell244")]
	private XRTableCell _XrTableCell244;

	[AccessedThroughProperty("XrTableRow89")]
	private XRTableRow _XrTableRow89;

	[AccessedThroughProperty("XrTableCell251")]
	private XRTableCell _XrTableCell251;

	[AccessedThroughProperty("XrTableCell252")]
	private XRTableCell _XrTableCell252;

	[AccessedThroughProperty("XrTableRow88")]
	private XRTableRow _XrTableRow88;

	[AccessedThroughProperty("XrTableCell247")]
	private XRTableCell _XrTableCell247;

	[AccessedThroughProperty("XrTableCell248")]
	private XRTableCell _XrTableCell248;

	[AccessedThroughProperty("XrTableRow90")]
	private XRTableRow _XrTableRow90;

	[AccessedThroughProperty("XrTableCell255")]
	private XRTableCell _XrTableCell255;

	[AccessedThroughProperty("XrTableCell256")]
	private XRTableCell _XrTableCell256;

	[AccessedThroughProperty("XrCheckBoxOtros")]
	private XRCheckBox _XrCheckBoxOtros;

	[AccessedThroughProperty("XrTable21")]
	private XRTable _XrTable21;

	[AccessedThroughProperty("XrTableRow58")]
	private XRTableRow _XrTableRow58;

	[AccessedThroughProperty("XrTableCell240")]
	private XRTableCell _XrTableCell240;

	[AccessedThroughProperty("XrTableCell257")]
	private XRTableCell _XrTableCell257;

	[AccessedThroughProperty("XrTable22")]
	private XRTable _XrTable22;

	[AccessedThroughProperty("XrTableRow91")]
	private XRTableRow _XrTableRow91;

	[AccessedThroughProperty("XrTableCell258")]
	private XRTableCell _XrTableCell258;

	[AccessedThroughProperty("XrTableCell259")]
	private XRTableCell _XrTableCell259;

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

	internal spRRHH_Report_CuadroPerTableAdapter SpRRHH_Report_CuadroPerTableAdapter
	{
		[DebuggerNonUserCode]
		get
		{
			return _SpRRHH_Report_CuadroPerTableAdapter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SpRRHH_Report_CuadroPerTableAdapter = value;
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

	internal XRLabel XrLabel13
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel13 = value;
		}
	}

	internal XRLabel XrLabel12
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel12 = value;
		}
	}

	internal XRLabel XrLabel11
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel11 = value;
		}
	}

	internal XRLabel XrLabel10
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel10 = value;
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

	internal XRTableRow XrTableRow47
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow47 = value;
		}
	}

	internal XRTableCell XrTableCell179
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell179;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell179 = value;
		}
	}

	internal XRTableCell XrTableCell180
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell180;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell180 = value;
		}
	}

	internal XRTableRow XrTableRow48
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow48 = value;
		}
	}

	internal XRTableCell XrTableCell183
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell183;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell183 = value;
		}
	}

	internal XRTableCell XrTableCell184
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell184;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell184 = value;
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

	internal XRTable XrTable15
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable15 = value;
		}
	}

	internal XRTableRow XrTableRow59
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow59 = value;
		}
	}

	internal XRTableCell XrTableCell210
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell210;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell210 = value;
		}
	}

	internal XRTableCell XrTableCell211
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell211;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell211 = value;
		}
	}

	internal XRTableRow XrTableRow60
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow60 = value;
		}
	}

	internal XRTableCell XrTableCell213
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell213;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell213 = value;
		}
	}

	internal XRTableCell XrTableCell214
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell214;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell214 = value;
		}
	}

	internal XRTable XrTable14
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable14 = value;
		}
	}

	internal XRTableRow XrTableRow53
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow53 = value;
		}
	}

	internal XRTableCell XrTableCell195
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell195;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell195 = value;
		}
	}

	internal XRTableCell XrTableCell196
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell196;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell196 = value;
		}
	}

	internal XRTableRow XrTableRow54
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow54 = value;
		}
	}

	internal XRTableCell XrTableCell197
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell197;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell197 = value;
		}
	}

	internal XRTableCell XrTableCell198
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell198;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell198 = value;
		}
	}

	internal XRTableRow XrTableRow55
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow55 = value;
		}
	}

	internal XRTableCell XrTableCell199
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell199;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell199 = value;
		}
	}

	internal XRTableCell XrTableCell200
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell200;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell200 = value;
		}
	}

	internal XRTableRow XrTableRow56
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow56 = value;
		}
	}

	internal XRTableCell XrTableCell201
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell201;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell201 = value;
		}
	}

	internal XRTableCell XrTableCell202
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell202;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell202 = value;
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

	internal XRTableRow XrTableRow49
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow49 = value;
		}
	}

	internal XRTableCell XrTableCell187
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell187;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell187 = value;
		}
	}

	internal XRTableCell XrTableCell188
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell188;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell188 = value;
		}
	}

	internal XRTableRow XrTableRow50
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow50 = value;
		}
	}

	internal XRTableCell XrTableCell189
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell189;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell189 = value;
		}
	}

	internal XRTableCell XrTableCell190
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell190;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell190 = value;
		}
	}

	internal XRTableRow XrTableRow51
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow51 = value;
		}
	}

	internal XRTableCell XrTableCell191
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell191;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell191 = value;
		}
	}

	internal XRTableCell XrTableCell192
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell192;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell192 = value;
		}
	}

	internal XRTableRow XrTableRow52
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow52 = value;
		}
	}

	internal XRTableCell XrTableCell193
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell193;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell193 = value;
		}
	}

	internal XRTableCell XrTableCell194
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell194;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell194 = value;
		}
	}

	internal XRLabel XrLabel15
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel15 = value;
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

	internal XRLabel XrLabel16
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel16 = value;
		}
	}

	internal DetailReportBand DetailReport6
	{
		[DebuggerNonUserCode]
		get
		{
			return _DetailReport6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_DetailReport6 = value;
		}
	}

	internal DetailBand Detail7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Detail7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Detail7 = value;
		}
	}

	internal XRTableRow XrTableRow68
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow68 = value;
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

	internal XRTableRow XrTableRow69
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow69 = value;
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

	internal XRTableRow XrTableRow67
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow67 = value;
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

	internal XRTableRow XrTableRow70
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow70;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow70 = value;
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

	internal XRTableRow XrTableRow76
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow76 = value;
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

	internal XRTableRow XrTableRow75
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow75 = value;
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

	internal XRTableRow XrTableRow74
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow74 = value;
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

	internal XRTableRow XrTableRow73
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow73 = value;
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

	internal XRTableRow XrTableRow72
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow72 = value;
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

	internal XRTableRow XrTableRow71
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow71 = value;
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

	internal XRTableRow XrTableRow77
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow77 = value;
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

	internal XRTableRow XrTableRow78
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow78 = value;
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

	internal XRTableRow XrTableRow79
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow79 = value;
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

	internal XRTableRow XrTableRow80
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow80 = value;
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

	internal XRTableRow XrTableRow81
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow81 = value;
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

	internal XRTableRow XrTableRow82
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow82;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow82 = value;
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

	internal XRTableRow XrTableRow83
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow83;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow83 = value;
		}
	}

	internal XRTableCell XrTableCell245
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell245;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell245 = value;
		}
	}

	internal XRTableCell XrTableCell246
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell246;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell246 = value;
		}
	}

	internal XRTableRow XrTableRow84
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow84;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow84 = value;
		}
	}

	internal XRTableCell XrTableCell249
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell249;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell249 = value;
		}
	}

	internal XRTableCell XrTableCell250
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell250;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell250 = value;
		}
	}

	internal XRTableRow XrTableRow85
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow85 = value;
		}
	}

	internal XRTableCell XrTableCell253
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell253;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell253 = value;
		}
	}

	internal XRTableCell XrTableCell254
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell254;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell254 = value;
		}
	}

	internal XRTableRow XrTableRow87
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow87;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow87 = value;
		}
	}

	internal XRTableCell XrTableCell261
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell261;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell261 = value;
		}
	}

	internal XRTableCell XrTableCell262
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell262;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell262 = value;
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

	internal XRTableCell XrTableCell154
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell154;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell154 = value;
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

	internal XRTableCell XrTableCell155
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell155;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell155 = value;
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

	internal XRTableCell XrTableCell156
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell156;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell156 = value;
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

	internal XRTableCell XrTableCell157
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell157;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell157 = value;
		}
	}

	internal XRTableCell XrTableCell147
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell147;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell147 = value;
		}
	}

	internal XRTableCell XrTableCell158
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell158;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell158 = value;
		}
	}

	internal XRTableCell XrTableCell148
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell148;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell148 = value;
		}
	}

	internal XRTableCell XrTableCell159
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell159;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell159 = value;
		}
	}

	internal XRTableCell XrTableCell149
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell149;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell149 = value;
		}
	}

	internal XRTableCell XrTableCell160
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell160;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell160 = value;
		}
	}

	internal XRTableCell XrTableCell150
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell150;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell150 = value;
		}
	}

	internal GroupHeaderBand GroupHeader7
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupHeader7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupHeader7 = value;
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

	internal XRLine XrLine2
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLine2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLine2 = value;
		}
	}

	internal XRLine XrLine1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLine1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLine1 = value;
		}
	}

	internal XRLabel XrLabel21
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel21 = value;
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

	internal XRLabel XrLabel24
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel24 = value;
		}
	}

	internal XRLabel XrLabel23
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel23 = value;
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

	internal XRLabel XrLabel22
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrLabel22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrLabel22 = value;
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

	internal XRTableRow XrTableRow41
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow41 = value;
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

	internal XRTableCell XrTableCell151
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell151;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell151 = value;
		}
	}

	internal XRTableCell XrTableCell152
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell152;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell152 = value;
		}
	}

	internal XRTableCell XrTableCell153
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell153;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell153 = value;
		}
	}

	internal XRTableRow XrTableRow42
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow42 = value;
		}
	}

	internal XRTableCell XrTableCell161
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell161;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell161 = value;
		}
	}

	internal XRTableCell XrTableCell162
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell162;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell162 = value;
		}
	}

	internal XRTableCell XrTableCell170
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell170;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell170 = value;
		}
	}

	internal XRTableCell XrTableCell171
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell171;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell171 = value;
		}
	}

	internal XRTableRow XrTableRow44
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow44 = value;
		}
	}

	internal XRTableCell XrTableCell176
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell176;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell176 = value;
		}
	}

	internal XRTableCell XrTableCell178
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell178;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell178 = value;
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

	internal XRTableRow XrTableRow45
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow45 = value;
		}
	}

	internal XRTableCell XrTableCell177
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell177;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell177 = value;
		}
	}

	internal XRTableCell XrTableCell203
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell203;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell203 = value;
		}
	}

	internal XRTableCell XrTableCell185
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell185;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell185 = value;
		}
	}

	internal XRTableCell XrTableCell181
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell181;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell181 = value;
		}
	}

	internal XRTableCell XrTableCell182
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell182;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell182 = value;
		}
	}

	internal XRTableCell XrTableCell186
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell186;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell186 = value;
		}
	}

	internal XRTableCell XrTableCell204
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell204;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell204 = value;
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

	internal XRTableRow XrTableRow46
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow46 = value;
		}
	}

	internal XRTableCell XrTableCell205
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell205;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell205 = value;
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

	internal XRCheckBox XrCheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBox1 = value;
		}
	}

	internal XRTableRow XrTableRow43
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow43 = value;
		}
	}

	internal XRTableCell XrTableCell172
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell172;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell172 = value;
		}
	}

	internal XRTableCell XrTableCell173
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell173;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell173 = value;
		}
	}

	internal XRTableCell XrTableCell174
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell174;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell174 = value;
		}
	}

	internal XRTableCell XrTableCell175
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell175;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell175 = value;
		}
	}

	internal XRCheckBox XrCheckBoxEnfCronica
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxEnfCronica;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxEnfCronica = value;
		}
	}

	internal XRCheckBox XrCheckBoxFamDisc
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxFamDisc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxFamDisc = value;
		}
	}

	internal XRTableCell XrTableCell206
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell206;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell206 = value;
		}
	}

	internal XRTableCell XrTableCell208
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell208;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell208 = value;
		}
	}

	internal XRTableCell XrTableCell207
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell207;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell207 = value;
		}
	}

	internal XRTableCell XrTableCell209
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell209;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell209 = value;
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

	internal XRTableRow XrTableRow57
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow57 = value;
		}
	}

	internal XRTableCell XrTableCell212
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell212;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell212 = value;
		}
	}

	internal XRCheckBox XrCheckBoxCable
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxCable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxCable = value;
		}
	}

	internal XRCheckBox XrCheckBoxInter
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxInter;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxInter = value;
		}
	}

	internal XRCheckBox XrCheckBoxFono
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxFono;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxFono = value;
		}
	}

	internal XRTableRow XrTableRow86
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow86 = value;
		}
	}

	internal XRTableCell XrTableCell243
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell243;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell243 = value;
		}
	}

	internal XRTableCell XrTableCell244
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell244;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell244 = value;
		}
	}

	internal XRTableRow XrTableRow89
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow89 = value;
		}
	}

	internal XRTableCell XrTableCell251
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell251;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell251 = value;
		}
	}

	internal XRTableCell XrTableCell252
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell252;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell252 = value;
		}
	}

	internal XRTableRow XrTableRow88
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow88 = value;
		}
	}

	internal XRTableCell XrTableCell247
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell247;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell247 = value;
		}
	}

	internal XRTableCell XrTableCell248
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell248;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell248 = value;
		}
	}

	internal XRTableRow XrTableRow90
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow90 = value;
		}
	}

	internal XRTableCell XrTableCell255
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell255;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell255 = value;
		}
	}

	internal XRTableCell XrTableCell256
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell256;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell256 = value;
		}
	}

	internal XRCheckBox XrCheckBoxOtros
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrCheckBoxOtros;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrCheckBoxOtros = value;
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

	internal XRTableRow XrTableRow58
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow58 = value;
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

	internal XRTableCell XrTableCell257
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell257;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell257 = value;
		}
	}

	internal XRTable XrTable22
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTable22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTable22 = value;
		}
	}

	internal XRTableRow XrTableRow91
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableRow91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableRow91 = value;
		}
	}

	internal XRTableCell XrTableCell258
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell258;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell258 = value;
		}
	}

	internal XRTableCell XrTableCell259
	{
		[DebuggerNonUserCode]
		get
		{
			return _XrTableCell259;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_XrTableCell259 = value;
		}
	}

	[DebuggerNonUserCode]
	public Report_FichaSocial_L()
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
		XrLabel3 = new XRLabel();
		XrPictureBox1 = new XRPictureBox();
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
		XrTableRow12 = new XRTableRow();
		XrTableCell14 = new XRTableCell();
		XrTableCell19 = new XRTableCell();
		XrTableCell55 = new XRTableCell();
		XrTableCell56 = new XRTableCell();
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
		PageHeader = new PageHeaderBand();
		PageFooter = new PageFooterBand();
		XrPageInfo1 = new XRPageInfo();
		DataSet11 = new DataSet1();
		SpRRHH_Report_CuadroPerTableAdapter = new spRRHH_Report_CuadroPerTableAdapter();
		DetailReport = new DetailReportBand();
		Detail1 = new DetailBand();
		GroupHeader1 = new GroupHeaderBand();
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
		XrTableRow19 = new XRTableRow();
		XrTableCell83 = new XRTableCell();
		XrTableCell71 = new XRTableCell();
		XrTableRow18 = new XRTableRow();
		XrTableCell80 = new XRTableCell();
		XrTableCell84 = new XRTableCell();
		XrLabel5 = new XRLabel();
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
		XrTable22 = new XRTable();
		XrTableRow91 = new XRTableRow();
		XrTableCell258 = new XRTableCell();
		XrTableCell259 = new XRTableCell();
		XrTable3 = new XRTable();
		XrTableRow15 = new XRTableRow();
		XrTableCell22 = new XRTableCell();
		XrTableCell39 = new XRTableCell();
		XrTableCell57 = new XRTableCell();
		XrTableRow63 = new XRTableRow();
		XrTableCell226 = new XRTableCell();
		XrTableCell227 = new XRTableCell();
		XrTableCell228 = new XRTableCell();
		XrTableRow33 = new XRTableRow();
		XrTableCell97 = new XRTableCell();
		XrTableCell121 = new XRTableCell();
		XrTableCell122 = new XRTableCell();
		XrTableRow23 = new XRTableRow();
		XrTableCell89 = new XRTableCell();
		XrTableCell90 = new XRTableCell();
		XrTableCell91 = new XRTableCell();
		XrTableRow22 = new XRTableRow();
		XrTableCell82 = new XRTableCell();
		XrTableCell85 = new XRTableCell();
		XrTableCell86 = new XRTableCell();
		XrTableRow21 = new XRTableRow();
		XrTableCell76 = new XRTableCell();
		XrTableCell77 = new XRTableCell();
		XrTableCell78 = new XRTableCell();
		XrTableRow20 = new XRTableRow();
		XrTableCell69 = new XRTableCell();
		XrTableCell70 = new XRTableCell();
		XrTableCell72 = new XRTableCell();
		XrTableRow16 = new XRTableRow();
		XrTableCell51 = new XRTableCell();
		XrTableCell58 = new XRTableCell();
		XrTableCell59 = new XRTableCell();
		XrTableRow17 = new XRTableRow();
		XrTableCell60 = new XRTableCell();
		XrTableCell61 = new XRTableCell();
		XrTableCell62 = new XRTableCell();
		XrTableRow34 = new XRTableRow();
		XrTableCell63 = new XRTableCell();
		XrTableCell64 = new XRTableCell();
		XrTableCell65 = new XRTableCell();
		XrLabel14 = new XRLabel();
		XrLabel8 = new XRLabel();
		XrTable1 = new XRTable();
		XrTableRow4 = new XRTableRow();
		XrTableCell20 = new XRTableCell();
		XrTableCell21 = new XRTableCell();
		XrTableRow14 = new XRTableRow();
		XrTableCell53 = new XRTableCell();
		XrTableCell54 = new XRTableCell();
		XrTableRow13 = new XRTableRow();
		XrTableCell44 = new XRTableCell();
		XrTableCell50 = new XRTableCell();
		XrTableRow6 = new XRTableRow();
		XrTableCell37 = new XRTableCell();
		XrTableCell38 = new XRTableCell();
		DetailReport2 = new DetailReportBand();
		Detail3 = new DetailBand();
		GroupHeader3 = new GroupHeaderBand();
		XrTable8 = new XRTable();
		XrTableRow78 = new XRTableRow();
		XrTableCell127 = new XRTableCell();
		XrTableRow79 = new XRTableRow();
		XrTableCell229 = new XRTableCell();
		XrTableCell230 = new XRTableCell();
		XrTableCell154 = new XRTableCell();
		XrTableCell136 = new XRTableCell();
		XrTableRow80 = new XRTableRow();
		XrTableCell233 = new XRTableCell();
		XrTableCell234 = new XRTableCell();
		XrTableCell155 = new XRTableCell();
		XrTableCell139 = new XRTableCell();
		XrTableRow81 = new XRTableRow();
		XrTableCell237 = new XRTableCell();
		XrTableCell238 = new XRTableCell();
		XrTableCell156 = new XRTableCell();
		XrTableCell142 = new XRTableCell();
		XrTableRow82 = new XRTableRow();
		XrTableCell241 = new XRTableCell();
		XrTableCell242 = new XRTableCell();
		XrTableCell157 = new XRTableCell();
		XrTableCell147 = new XRTableCell();
		XrTableRow83 = new XRTableRow();
		XrTableCell245 = new XRTableCell();
		XrTableCell246 = new XRTableCell();
		XrTableCell158 = new XRTableCell();
		XrTableCell148 = new XRTableCell();
		XrTableRow84 = new XRTableRow();
		XrTableCell249 = new XRTableCell();
		XrTableCell250 = new XRTableCell();
		XrTableCell159 = new XRTableCell();
		XrTableCell149 = new XRTableCell();
		XrTableRow85 = new XRTableRow();
		XrTableCell253 = new XRTableCell();
		XrTableCell254 = new XRTableCell();
		XrTableCell160 = new XRTableCell();
		XrTableCell150 = new XRTableCell();
		XrTableRow87 = new XRTableRow();
		XrTableCell261 = new XRTableCell();
		XrTableCell262 = new XRTableCell();
		XrLabel13 = new XRLabel();
		XrLabel12 = new XRLabel();
		XrLabel11 = new XRLabel();
		XrLabel10 = new XRLabel();
		XrLabel9 = new XRLabel();
		XrLabel2 = new XRLabel();
		XrTable10 = new XRTable();
		XrTableRow37 = new XRTableRow();
		XrTableCell126 = new XRTableCell();
		XrTableRow38 = new XRTableRow();
		XrTableCell140 = new XRTableCell();
		XrTableCell141 = new XRTableCell();
		XrTableRow47 = new XRTableRow();
		XrTableCell179 = new XRTableCell();
		XrTableCell180 = new XRTableCell();
		XrTableRow48 = new XRTableRow();
		XrTableCell183 = new XRTableCell();
		XrTableCell184 = new XRTableCell();
		XrLabel1 = new XRLabel();
		DetailReport3 = new DetailReportBand();
		Detail4 = new DetailBand();
		GroupHeader4 = new GroupHeaderBand();
		XrTable21 = new XRTable();
		XrTableRow58 = new XRTableRow();
		XrTableCell240 = new XRTableCell();
		XrTableCell257 = new XRTableCell();
		XrTable14 = new XRTable();
		XrTableRow53 = new XRTableRow();
		XrTableCell195 = new XRTableCell();
		XrTableCell196 = new XRTableCell();
		XrTableRow54 = new XRTableRow();
		XrTableCell197 = new XRTableCell();
		XrTableCell198 = new XRTableCell();
		XrTableRow55 = new XRTableRow();
		XrTableCell199 = new XRTableCell();
		XrTableCell200 = new XRTableCell();
		XrTableRow56 = new XRTableRow();
		XrTableCell201 = new XRTableCell();
		XrTableCell202 = new XRTableCell();
		XrTableRow86 = new XRTableRow();
		XrTableCell243 = new XRTableCell();
		XrTableCell244 = new XRTableCell();
		XrCheckBoxFono = new XRCheckBox();
		XrTableRow89 = new XRTableRow();
		XrTableCell251 = new XRTableCell();
		XrTableCell252 = new XRTableCell();
		XrCheckBoxInter = new XRCheckBox();
		XrTableRow88 = new XRTableRow();
		XrTableCell247 = new XRTableCell();
		XrTableCell248 = new XRTableCell();
		XrCheckBoxCable = new XRCheckBox();
		XrTableRow90 = new XRTableRow();
		XrTableCell255 = new XRTableCell();
		XrTableCell256 = new XRTableCell();
		XrCheckBoxOtros = new XRCheckBox();
		XrTable15 = new XRTable();
		XrTableRow57 = new XRTableRow();
		XrTableCell212 = new XRTableCell();
		XrTableRow59 = new XRTableRow();
		XrTableCell210 = new XRTableCell();
		XrTableCell211 = new XRTableCell();
		XrTableCell206 = new XRTableCell();
		XrTableCell208 = new XRTableCell();
		XrTableRow60 = new XRTableRow();
		XrTableCell213 = new XRTableCell();
		XrTableCell214 = new XRTableCell();
		XrTableCell207 = new XRTableCell();
		XrTableCell209 = new XRTableCell();
		XrTable11 = new XRTable();
		XrTableRow49 = new XRTableRow();
		XrTableCell187 = new XRTableCell();
		XrTableCell188 = new XRTableCell();
		XrTableRow50 = new XRTableRow();
		XrTableCell189 = new XRTableCell();
		XrTableCell190 = new XRTableCell();
		XrTableRow51 = new XRTableRow();
		XrTableCell191 = new XRTableCell();
		XrTableCell192 = new XRTableCell();
		XrTableRow52 = new XRTableRow();
		XrTableCell193 = new XRTableCell();
		XrTableCell194 = new XRTableCell();
		XrLabel15 = new XRLabel();
		DetailReport4 = new DetailReportBand();
		Detail5 = new DetailBand();
		XrTable17 = new XRTable();
		XrTableRow62 = new XRTableRow();
		XrTableCell220 = new XRTableCell();
		XrTableCell221 = new XRTableCell();
		XrTableCell222 = new XRTableCell();
		XrTableCell223 = new XRTableCell();
		XrTableCell224 = new XRTableCell();
		GroupHeader5 = new GroupHeaderBand();
		XrTable16 = new XRTable();
		XrTableRow61 = new XRTableRow();
		XrTableCell215 = new XRTableCell();
		XrTableCell216 = new XRTableCell();
		XrTableCell217 = new XRTableCell();
		XrTableCell218 = new XRTableCell();
		XrTableCell219 = new XRTableCell();
		XrLabel18 = new XRLabel();
		XrLabel17 = new XRLabel();
		DetailReport5 = new DetailReportBand();
		Detail6 = new DetailBand();
		GroupHeader6 = new GroupHeaderBand();
		XrTable5 = new XRTable();
		XrTableRow68 = new XRTableRow();
		XrTableCell88 = new XRTableCell();
		XrTableRow64 = new XRTableRow();
		XrTableCell66 = new XRTableCell();
		XrTableRow69 = new XRTableRow();
		XrTableCell93 = new XRTableCell();
		XrTableRow67 = new XRTableRow();
		XrTableCell81 = new XRTableCell();
		XrTableRow66 = new XRTableRow();
		XrTableCell75 = new XRTableCell();
		XrTableRow65 = new XRTableRow();
		XrTableCell68 = new XRTableCell();
		XrTableRow70 = new XRTableRow();
		XrTableCell124 = new XRTableCell();
		XrTableRow76 = new XRTableRow();
		XrTableCell123 = new XRTableCell();
		XrTableRow75 = new XRTableRow();
		XrTableCell92 = new XRTableCell();
		XrTableRow77 = new XRTableRow();
		XrTableCell125 = new XRTableCell();
		XrTableRow74 = new XRTableRow();
		XrTableCell87 = new XRTableCell();
		XrTableRow73 = new XRTableRow();
		XrTableCell79 = new XRTableCell();
		XrTableRow72 = new XRTableRow();
		XrTableCell73 = new XRTableCell();
		XrTableRow71 = new XRTableRow();
		XrTableCell67 = new XRTableCell();
		XrLabel16 = new XRLabel();
		GroupFooter2 = new GroupFooterBand();
		XrLabel24 = new XRLabel();
		XrLabel23 = new XRLabel();
		XrPageInfo2 = new XRPageInfo();
		XrLabel22 = new XRLabel();
		XrLine2 = new XRLine();
		XrLine1 = new XRLine();
		XrLabel21 = new XRLabel();
		XrLabel20 = new XRLabel();
		DetailReport6 = new DetailReportBand();
		Detail7 = new DetailBand();
		XrTable20 = new XRTable();
		XrTableRow46 = new XRTableRow();
		XrTableCell205 = new XRTableCell();
		XrTableCell225 = new XRTableCell();
		XrTableCell231 = new XRTableCell();
		XrTableCell232 = new XRTableCell();
		XrTableCell235 = new XRTableCell();
		XrTableCell236 = new XRTableCell();
		XrTableCell239 = new XRTableCell();
		GroupHeader7 = new GroupHeaderBand();
		XrTable19 = new XRTable();
		XrTableRow45 = new XRTableRow();
		XrTableCell177 = new XRTableCell();
		XrTableCell203 = new XRTableCell();
		XrTableCell185 = new XRTableCell();
		XrTableCell181 = new XRTableCell();
		XrTableCell182 = new XRTableCell();
		XrTableCell186 = new XRTableCell();
		XrTableCell204 = new XRTableCell();
		XrTable18 = new XRTable();
		XrTableRow41 = new XRTableRow();
		XrTableCell128 = new XRTableCell();
		XrTableCell151 = new XRTableCell();
		XrCheckBoxEnfCronica = new XRCheckBox();
		XrTableCell152 = new XRTableCell();
		XrTableCell153 = new XRTableCell();
		XrTableRow42 = new XRTableRow();
		XrTableCell161 = new XRTableCell();
		XrTableCell162 = new XRTableCell();
		XrCheckBoxFamDisc = new XRCheckBox();
		XrTableCell170 = new XRTableCell();
		XrTableCell171 = new XRTableCell();
		XrTableRow43 = new XRTableRow();
		XrTableCell172 = new XRTableCell();
		XrTableCell173 = new XRTableCell();
		XrCheckBox1 = new XRCheckBox();
		XrTableCell174 = new XRTableCell();
		XrTableCell175 = new XRTableCell();
		XrTableRow44 = new XRTableRow();
		XrTableCell176 = new XRTableCell();
		XrTableCell178 = new XRTableCell();
		XrLabel19 = new XRLabel();
		SpRRHH_Ficha_ExpLabTableAdapter = new spRRHH_Ficha_ExpLabTableAdapter();
		((ISupportInitialize)XrTable2).BeginInit();
		((ISupportInitialize)DataSet11).BeginInit();
		((ISupportInitialize)XrTable6).BeginInit();
		((ISupportInitialize)XrTable4).BeginInit();
		((ISupportInitialize)XrTable12).BeginInit();
		((ISupportInitialize)XrTable13).BeginInit();
		((ISupportInitialize)XrTable7).BeginInit();
		((ISupportInitialize)XrTable22).BeginInit();
		((ISupportInitialize)XrTable3).BeginInit();
		((ISupportInitialize)XrTable1).BeginInit();
		((ISupportInitialize)XrTable8).BeginInit();
		((ISupportInitialize)XrTable10).BeginInit();
		((ISupportInitialize)XrTable21).BeginInit();
		((ISupportInitialize)XrTable14).BeginInit();
		((ISupportInitialize)XrTable15).BeginInit();
		((ISupportInitialize)XrTable11).BeginInit();
		((ISupportInitialize)XrTable17).BeginInit();
		((ISupportInitialize)XrTable16).BeginInit();
		((ISupportInitialize)XrTable5).BeginInit();
		((ISupportInitialize)XrTable20).BeginInit();
		((ISupportInitialize)XrTable19).BeginInit();
		((ISupportInitialize)XrTable18).BeginInit();
		((ISupportInitialize)this).BeginInit();
		Detail.Controls.AddRange(new XRControl[4] { XrLabel3, XrPictureBox1, XrLabel4, XrTable2 });
		Detail.Height = 416;
		Detail.Name = "Detail";
		XrLabel3.Font = new Font("Times New Roman", 14f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel = XrLabel3;
		Point location = new Point(250, 42);
		xrLabel.Location = location;
		XrLabel3.Name = "XrLabel3";
		XRLabel xrLabel2 = XrLabel3;
		PaddingInfo padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel2.Padding = padding;
		XrLabel3.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel3 = XrLabel3;
		Size size = new Size(150, 25);
		xrLabel3.Size = size;
		XrLabel3.Text = "FICHA SOCIAL";
		XrPictureBox1.Borders = BorderSide.All;
		XrPictureBox1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Image", null, "spRRHH_Ficha_DatosPersonales.foto", "")
		});
		XRPictureBox xrPictureBox = XrPictureBox1;
		location = new Point(525, 8);
		xrPictureBox.Location = location;
		XrPictureBox1.Name = "XrPictureBox1";
		XrPictureBox1.ParentStyleUsing.UseBorders = false;
		XRPictureBox xrPictureBox2 = XrPictureBox1;
		size = new Size(100, 108);
		xrPictureBox2.Size = size;
		XrPictureBox1.Sizing = ImageSizeMode.StretchImage;
		XrLabel4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel4 = XrLabel4;
		location = new Point(25, 100);
		xrLabel4.Location = location;
		XrLabel4.Name = "XrLabel4";
		XRLabel xrLabel5 = XrLabel4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel5.Padding = padding;
		XrLabel4.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel6 = XrLabel4;
		size = new Size(292, 25);
		xrLabel6.Size = size;
		XrLabel4.Text = "I. DATOS PERSONALES";
		XRTable xrTable = XrTable2;
		location = new Point(25, 133);
		xrTable.Location = location;
		XrTable2.Name = "XrTable2";
		XrTable2.Rows.AddRange(new XRTableRow[11]
		{
			XrTableRow2, XrTableRow3, XrTableRow5, XrTableRow12, XrTableRow7, XrTableRow8, XrTableRow9, XrTableRow10, XrTableRow24, XrTableRow1,
			XrTableRow11
		});
		XRTable xrTable2 = XrTable2;
		size = new Size(600, 275);
		xrTable2.Size = size;
		XrTableRow2.Cells.AddRange(new XRTableCell[4] { XrTableCell7, XrTableCell4, XrTableCell5, XrTableCell6 });
		XrTableRow2.Name = "XrTableRow2";
		XRTableRow xrTableRow = XrTableRow2;
		size = new Size(600, 25);
		xrTableRow.Size = size;
		XrTableCell7.Borders = BorderSide.Left | BorderSide.Top;
		XRTableCell xrTableCell = XrTableCell7;
		location = new Point(0, 0);
		xrTableCell.Location = location;
		XrTableCell7.Name = "XrTableCell7";
		XRTableCell xrTableCell2 = XrTableCell7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell2.Padding = padding;
		XrTableCell7.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell3 = XrTableCell7;
		size = new Size(142, 25);
		xrTableCell3.Size = size;
		XrTableCell4.Borders = BorderSide.Top;
		XrTableCell4.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell4 = XrTableCell4;
		location = new Point(142, 0);
		xrTableCell4.Location = location;
		XrTableCell4.Name = "XrTableCell4";
		XRTableCell xrTableCell5 = XrTableCell4;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell5.Padding = padding;
		XrTableCell4.ParentStyleUsing.UseBorders = false;
		XrTableCell4.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell6 = XrTableCell4;
		size = new Size(133, 25);
		xrTableCell6.Size = size;
		XrTableCell4.Text = "Apellido Paterno";
		XrTableCell5.Borders = BorderSide.Top;
		XrTableCell5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell7 = XrTableCell5;
		location = new Point(275, 0);
		xrTableCell7.Location = location;
		XrTableCell5.Name = "XrTableCell5";
		XRTableCell xrTableCell8 = XrTableCell5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell8.Padding = padding;
		XrTableCell5.ParentStyleUsing.UseBorders = false;
		XrTableCell5.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell9 = XrTableCell5;
		size = new Size(133, 25);
		xrTableCell9.Size = size;
		XrTableCell5.Text = "Apellido Materno";
		XrTableCell6.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell6.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell10 = XrTableCell6;
		location = new Point(408, 0);
		xrTableCell10.Location = location;
		XrTableCell6.Name = "XrTableCell6";
		XRTableCell xrTableCell11 = XrTableCell6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell11.Padding = padding;
		XrTableCell6.ParentStyleUsing.UseBorders = false;
		XrTableCell6.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell12 = XrTableCell6;
		size = new Size(192, 25);
		xrTableCell12.Size = size;
		XrTableCell6.Text = "Nombres";
		XrTableRow3.Cells.AddRange(new XRTableCell[4] { XrTableCell8, XrTableCell9, XrTableCell10, XrTableCell11 });
		XrTableRow3.Name = "XrTableRow3";
		XRTableRow xrTableRow2 = XrTableRow3;
		size = new Size(600, 25);
		xrTableRow2.Size = size;
		XrTableCell8.Borders = BorderSide.Left;
		XrTableCell8.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell13 = XrTableCell8;
		location = new Point(0, 0);
		xrTableCell13.Location = location;
		XrTableCell8.Name = "XrTableCell8";
		XRTableCell xrTableCell14 = XrTableCell8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell14.Padding = padding;
		XrTableCell8.ParentStyleUsing.UseBorders = false;
		XrTableCell8.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell15 = XrTableCell8;
		size = new Size(142, 25);
		xrTableCell15.Size = size;
		XrTableCell8.Text = "Nombres y Apellidos:";
		XrTableCell9.Borders = BorderSide.Bottom;
		XrTableCell9.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Paterno", "")
		});
		XRTableCell xrTableCell16 = XrTableCell9;
		location = new Point(142, 0);
		xrTableCell16.Location = location;
		XrTableCell9.Name = "XrTableCell9";
		XRTableCell xrTableCell17 = XrTableCell9;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell17.Padding = padding;
		XrTableCell9.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell18 = XrTableCell9;
		size = new Size(133, 25);
		xrTableCell18.Size = size;
		XrTableCell9.Text = "XrTableCell9";
		XrTableCell10.Borders = BorderSide.Bottom;
		XrTableCell10.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Apellido_Materno", "")
		});
		XRTableCell xrTableCell19 = XrTableCell10;
		location = new Point(275, 0);
		xrTableCell19.Location = location;
		XrTableCell10.Name = "XrTableCell10";
		XRTableCell xrTableCell20 = XrTableCell10;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell20.Padding = padding;
		XrTableCell10.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell21 = XrTableCell10;
		size = new Size(133, 25);
		xrTableCell21.Size = size;
		XrTableCell10.Text = "XrTableCell10";
		XrTableCell11.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell11.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Nombres", "")
		});
		XRTableCell xrTableCell22 = XrTableCell11;
		location = new Point(408, 0);
		xrTableCell22.Location = location;
		XrTableCell11.Name = "XrTableCell11";
		XRTableCell xrTableCell23 = XrTableCell11;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell23.Padding = padding;
		XrTableCell11.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell24 = XrTableCell11;
		size = new Size(192, 25);
		xrTableCell24.Size = size;
		XrTableCell11.Text = "XrTableCell11";
		XrTableRow5.Cells.AddRange(new XRTableCell[6] { XrTableCell15, XrTableCell16, XrTableCell17, XrTableCell18, XrTableCell24, XrTableCell23 });
		XrTableRow5.Name = "XrTableRow5";
		XRTableRow xrTableRow3 = XrTableRow5;
		size = new Size(600, 25);
		xrTableRow3.Size = size;
		XrTableCell15.Borders = BorderSide.Left | BorderSide.Top;
		XrTableCell15.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell25 = XrTableCell15;
		location = new Point(0, 0);
		xrTableCell25.Location = location;
		XrTableCell15.Name = "XrTableCell15";
		XRTableCell xrTableCell26 = XrTableCell15;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell26.Padding = padding;
		XrTableCell15.ParentStyleUsing.UseBorders = false;
		XrTableCell15.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell27 = XrTableCell15;
		size = new Size(42, 25);
		xrTableCell27.Size = size;
		XrTableCell15.Text = "Edad:";
		XrTableCell16.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell16.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.edadEmpleado", "")
		});
		XRTableCell xrTableCell28 = XrTableCell16;
		location = new Point(42, 0);
		xrTableCell28.Location = location;
		XrTableCell16.Name = "XrTableCell16";
		XRTableCell xrTableCell29 = XrTableCell16;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell29.Padding = padding;
		XrTableCell16.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell30 = XrTableCell16;
		size = new Size(100, 25);
		xrTableCell30.Size = size;
		XrTableCell16.Text = "XrTableCell16";
		XrTableCell17.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell31 = XrTableCell17;
		location = new Point(142, 0);
		xrTableCell31.Location = location;
		XrTableCell17.Name = "XrTableCell17";
		XRTableCell xrTableCell32 = XrTableCell17;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell32.Padding = padding;
		XrTableCell17.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell33 = XrTableCell17;
		size = new Size(58, 25);
		xrTableCell33.Size = size;
		XrTableCell17.Text = "Sexo:";
		XrTableCell18.Borders = BorderSide.Right;
		XrTableCell18.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.sexo", "")
		});
		XRTableCell xrTableCell34 = XrTableCell18;
		location = new Point(200, 0);
		xrTableCell34.Location = location;
		XrTableCell18.Name = "XrTableCell18";
		XRTableCell xrTableCell35 = XrTableCell18;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell35.Padding = padding;
		XrTableCell18.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell36 = XrTableCell18;
		size = new Size(58, 25);
		xrTableCell36.Size = size;
		XrTableCell18.Text = "XrTableCell18";
		XrTableCell24.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.TipoDoc", "")
		});
		XrTableCell24.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell37 = XrTableCell24;
		location = new Point(258, 0);
		xrTableCell37.Location = location;
		XrTableCell24.Name = "XrTableCell24";
		XRTableCell xrTableCell38 = XrTableCell24;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell38.Padding = padding;
		XrTableCell24.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell39 = XrTableCell24;
		size = new Size(133, 25);
		xrTableCell39.Size = size;
		XrTableCell24.Text = "XrTableCell24";
		XrTableCell23.Borders = BorderSide.Right;
		XrTableCell23.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumDocId", "")
		});
		XRTableCell xrTableCell40 = XrTableCell23;
		location = new Point(391, 0);
		xrTableCell40.Location = location;
		XrTableCell23.Name = "XrTableCell23";
		XRTableCell xrTableCell41 = XrTableCell23;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell41.Padding = padding;
		XrTableCell23.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell42 = XrTableCell23;
		size = new Size(209, 25);
		xrTableCell42.Size = size;
		XrTableCell23.Text = "XrTableCell23";
		XrTableRow12.Cells.AddRange(new XRTableCell[4] { XrTableCell14, XrTableCell19, XrTableCell55, XrTableCell56 });
		XrTableRow12.Name = "XrTableRow12";
		XRTableRow xrTableRow4 = XrTableRow12;
		size = new Size(600, 25);
		xrTableRow4.Size = size;
		XrTableCell14.Borders = BorderSide.Left | BorderSide.Top;
		XrTableCell14.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell43 = XrTableCell14;
		location = new Point(0, 0);
		xrTableCell43.Location = location;
		XrTableCell14.Name = "XrTableCell14";
		XRTableCell xrTableCell44 = XrTableCell14;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell44.Padding = padding;
		XrTableCell14.ParentStyleUsing.UseBorders = false;
		XrTableCell14.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell45 = XrTableCell14;
		size = new Size(197, 25);
		xrTableCell45.Size = size;
		XrTableCell14.Text = "Fecha de Nac.:";
		XrTableCell19.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell19.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FechaNacimiento", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell46 = XrTableCell19;
		location = new Point(197, 0);
		xrTableCell46.Location = location;
		XrTableCell19.Name = "XrTableCell19";
		XRTableCell xrTableCell47 = XrTableCell19;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell47.Padding = padding;
		XrTableCell19.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell48 = XrTableCell19;
		size = new Size(98, 25);
		xrTableCell48.Size = size;
		XrTableCell19.Text = "XrTableCell19";
		XrTableCell55.Borders = BorderSide.Top;
		XrTableCell55.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell49 = XrTableCell55;
		location = new Point(295, 0);
		xrTableCell49.Location = location;
		XrTableCell55.Name = "XrTableCell55";
		XRTableCell xrTableCell50 = XrTableCell55;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell50.Padding = padding;
		XrTableCell55.ParentStyleUsing.UseBorders = false;
		XrTableCell55.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell51 = XrTableCell55;
		size = new Size(99, 25);
		xrTableCell51.Size = size;
		XrTableCell55.Text = "Grupo Sanguíneo:";
		XrTableCell56.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell56.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DescripTS", "")
		});
		XRTableCell xrTableCell52 = XrTableCell56;
		location = new Point(394, 0);
		xrTableCell52.Location = location;
		XrTableCell56.Name = "XrTableCell56";
		XRTableCell xrTableCell53 = XrTableCell56;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell53.Padding = padding;
		XrTableCell56.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell54 = XrTableCell56;
		size = new Size(206, 25);
		xrTableCell54.Size = size;
		XrTableCell56.Text = "XrTableCell56";
		XrTableRow7.Cells.AddRange(new XRTableCell[5] { XrTableCell25, XrTableCell26, XrTableCell27, XrTableCell33, XrTableCell28 });
		XrTableRow7.Name = "XrTableRow7";
		XRTableRow xrTableRow5 = XrTableRow7;
		size = new Size(600, 25);
		xrTableRow5.Size = size;
		XrTableCell25.Borders = BorderSide.Left | BorderSide.Top;
		XRTableCell xrTableCell55 = XrTableCell25;
		location = new Point(0, 0);
		xrTableCell55.Location = location;
		XrTableCell25.Name = "XrTableCell25";
		XRTableCell xrTableCell56 = XrTableCell25;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell56.Padding = padding;
		XrTableCell25.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell57 = XrTableCell25;
		size = new Size(142, 25);
		xrTableCell57.Size = size;
		XrTableCell26.Borders = BorderSide.Top;
		XrTableCell26.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell58 = XrTableCell26;
		location = new Point(142, 0);
		xrTableCell58.Location = location;
		XrTableCell26.Name = "XrTableCell26";
		XRTableCell xrTableCell59 = XrTableCell26;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell59.Padding = padding;
		XrTableCell26.ParentStyleUsing.UseBorders = false;
		XrTableCell26.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell60 = XrTableCell26;
		size = new Size(115, 25);
		xrTableCell60.Size = size;
		XrTableCell26.Text = "Domicilio";
		XrTableCell27.Borders = BorderSide.Top;
		XrTableCell27.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell61 = XrTableCell27;
		location = new Point(257, 0);
		xrTableCell61.Location = location;
		XrTableCell27.Name = "XrTableCell27";
		XRTableCell xrTableCell62 = XrTableCell27;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell62.Padding = padding;
		XrTableCell27.ParentStyleUsing.UseBorders = false;
		XrTableCell27.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell63 = XrTableCell27;
		size = new Size(137, 25);
		xrTableCell63.Size = size;
		XrTableCell27.Text = "Centro Laboral";
		XrTableCell33.Borders = BorderSide.Top;
		XrTableCell33.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell64 = XrTableCell33;
		location = new Point(394, 0);
		xrTableCell64.Location = location;
		XrTableCell33.Name = "XrTableCell33";
		XRTableCell xrTableCell65 = XrTableCell33;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell65.Padding = padding;
		XrTableCell33.ParentStyleUsing.UseBorders = false;
		XrTableCell33.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell66 = XrTableCell33;
		size = new Size(103, 25);
		xrTableCell66.Size = size;
		XrTableCell33.Text = "Celular";
		XrTableCell28.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell28.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell67 = XrTableCell28;
		location = new Point(497, 0);
		xrTableCell67.Location = location;
		XrTableCell28.Name = "XrTableCell28";
		XRTableCell xrTableCell68 = XrTableCell28;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell68.Padding = padding;
		XrTableCell28.ParentStyleUsing.UseBorders = false;
		XrTableCell28.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell69 = XrTableCell28;
		size = new Size(103, 25);
		xrTableCell69.Size = size;
		XrTableCell28.Text = "Otro";
		XrTableRow8.Cells.AddRange(new XRTableCell[5] { XrTableCell29, XrTableCell30, XrTableCell31, XrTableCell34, XrTableCell32 });
		XrTableRow8.Name = "XrTableRow8";
		XRTableRow xrTableRow6 = XrTableRow8;
		size = new Size(600, 25);
		xrTableRow6.Size = size;
		XrTableCell29.Borders = BorderSide.Left;
		XrTableCell29.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell70 = XrTableCell29;
		location = new Point(0, 0);
		xrTableCell70.Location = location;
		XrTableCell29.Name = "XrTableCell29";
		XRTableCell xrTableCell71 = XrTableCell29;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell71.Padding = padding;
		XrTableCell29.ParentStyleUsing.UseBorders = false;
		XrTableCell29.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell72 = XrTableCell29;
		size = new Size(142, 25);
		xrTableCell72.Size = size;
		XrTableCell29.Text = "Teléfonos:";
		XrTableCell30.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Telefono", "")
		});
		XRTableCell xrTableCell73 = XrTableCell30;
		location = new Point(142, 0);
		xrTableCell73.Location = location;
		XrTableCell30.Name = "XrTableCell30";
		XRTableCell xrTableCell74 = XrTableCell30;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell74.Padding = padding;
		XRTableCell xrTableCell75 = XrTableCell30;
		size = new Size(115, 25);
		xrTableCell75.Size = size;
		XrTableCell30.Text = "XrTableCell30";
		XrTableCell31.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.FonoCentroLab", "")
		});
		XRTableCell xrTableCell76 = XrTableCell31;
		location = new Point(257, 0);
		xrTableCell76.Location = location;
		XrTableCell31.Name = "XrTableCell31";
		XRTableCell xrTableCell77 = XrTableCell31;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell77.Padding = padding;
		XRTableCell xrTableCell78 = XrTableCell31;
		size = new Size(137, 25);
		xrTableCell78.Size = size;
		XrTableCell31.Text = "XrTableCell31";
		XrTableCell34.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumCelular", "")
		});
		XRTableCell xrTableCell79 = XrTableCell34;
		location = new Point(394, 0);
		xrTableCell79.Location = location;
		XrTableCell34.Name = "XrTableCell34";
		XRTableCell xrTableCell80 = XrTableCell34;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell80.Padding = padding;
		XRTableCell xrTableCell81 = XrTableCell34;
		size = new Size(103, 25);
		xrTableCell81.Size = size;
		XrTableCell34.Text = "XrTableCell34";
		XrTableCell32.Borders = BorderSide.Right;
		XrTableCell32.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Fax", "")
		});
		XRTableCell xrTableCell82 = XrTableCell32;
		location = new Point(497, 0);
		xrTableCell82.Location = location;
		XrTableCell32.Name = "XrTableCell32";
		XRTableCell xrTableCell83 = XrTableCell32;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell83.Padding = padding;
		XrTableCell32.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell84 = XrTableCell32;
		size = new Size(103, 25);
		xrTableCell84.Size = size;
		XrTableCell32.Text = "XrTableCell32";
		XrTableRow9.Cells.AddRange(new XRTableCell[2] { XrTableCell35, XrTableCell36 });
		XrTableRow9.Name = "XrTableRow9";
		XRTableRow xrTableRow7 = XrTableRow9;
		size = new Size(600, 25);
		xrTableRow7.Size = size;
		XrTableCell35.Borders = BorderSide.Left | BorderSide.Top;
		XrTableCell35.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell85 = XrTableCell35;
		location = new Point(0, 0);
		xrTableCell85.Location = location;
		XrTableCell35.Name = "XrTableCell35";
		XRTableCell xrTableCell86 = XrTableCell35;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell86.Padding = padding;
		XrTableCell35.ParentStyleUsing.UseBorders = false;
		XrTableCell35.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell87 = XrTableCell35;
		size = new Size(142, 25);
		xrTableCell87.Size = size;
		XrTableCell35.Text = "Estado Civil:";
		XrTableCell36.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell36.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.EstadoCivil", "")
		});
		XRTableCell xrTableCell88 = XrTableCell36;
		location = new Point(142, 0);
		xrTableCell88.Location = location;
		XrTableCell36.Name = "XrTableCell36";
		XRTableCell xrTableCell89 = XrTableCell36;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell89.Padding = padding;
		XrTableCell36.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell90 = XrTableCell36;
		size = new Size(458, 25);
		xrTableCell90.Size = size;
		XrTableCell36.Text = "XrTableCell36";
		XrTableRow10.Cells.AddRange(new XRTableCell[4] { XrTableCell40, XrTableCell41, XrTableCell42, XrTableCell43 });
		XrTableRow10.Name = "XrTableRow10";
		XRTableRow xrTableRow8 = XrTableRow10;
		size = new Size(600, 25);
		xrTableRow8.Size = size;
		XrTableCell40.Borders = BorderSide.Left | BorderSide.Top;
		XRTableCell xrTableCell91 = XrTableCell40;
		location = new Point(0, 0);
		xrTableCell91.Location = location;
		XrTableCell40.Name = "XrTableCell40";
		XRTableCell xrTableCell92 = XrTableCell40;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell92.Padding = padding;
		XrTableCell40.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell93 = XrTableCell40;
		size = new Size(142, 25);
		xrTableCell93.Size = size;
		XrTableCell41.Borders = BorderSide.Top;
		XrTableCell41.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell94 = XrTableCell41;
		location = new Point(142, 0);
		xrTableCell94.Location = location;
		XrTableCell41.Name = "XrTableCell41";
		XRTableCell xrTableCell95 = XrTableCell41;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell95.Padding = padding;
		XrTableCell41.ParentStyleUsing.UseBorders = false;
		XrTableCell41.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell96 = XrTableCell41;
		size = new Size(133, 25);
		xrTableCell96.Size = size;
		XrTableCell41.Text = "Distrito";
		XrTableCell42.Borders = BorderSide.Top;
		XrTableCell42.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell97 = XrTableCell42;
		location = new Point(275, 0);
		xrTableCell97.Location = location;
		XrTableCell42.Name = "XrTableCell42";
		XRTableCell xrTableCell98 = XrTableCell42;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell98.Padding = padding;
		XrTableCell42.ParentStyleUsing.UseBorders = false;
		XrTableCell42.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell99 = XrTableCell42;
		size = new Size(133, 25);
		xrTableCell99.Size = size;
		XrTableCell42.Text = "Provincia";
		XrTableCell43.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell43.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell100 = XrTableCell43;
		location = new Point(408, 0);
		xrTableCell100.Location = location;
		XrTableCell43.Name = "XrTableCell43";
		XRTableCell xrTableCell101 = XrTableCell43;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell101.Padding = padding;
		XrTableCell43.ParentStyleUsing.UseBorders = false;
		XrTableCell43.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell102 = XrTableCell43;
		size = new Size(192, 25);
		xrTableCell102.Size = size;
		XrTableCell43.Text = "Departamento";
		XrTableRow24.Cells.AddRange(new XRTableCell[4] { XrTableCell98, XrTableCell99, XrTableCell100, XrTableCell101 });
		XrTableRow24.Name = "XrTableRow24";
		XRTableRow xrTableRow9 = XrTableRow24;
		size = new Size(600, 25);
		xrTableRow9.Size = size;
		XrTableCell98.Borders = BorderSide.Left;
		XrTableCell98.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell103 = XrTableCell98;
		location = new Point(0, 0);
		xrTableCell103.Location = location;
		XrTableCell98.Name = "XrTableCell98";
		XRTableCell xrTableCell104 = XrTableCell98;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell104.Padding = padding;
		XrTableCell98.ParentStyleUsing.UseBorders = false;
		XrTableCell98.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell105 = XrTableCell98;
		size = new Size(142, 25);
		xrTableCell105.Size = size;
		XrTableCell98.Text = "Lugar de Nacimiento:";
		XrTableCell99.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdistrito", "")
		});
		XRTableCell xrTableCell106 = XrTableCell99;
		location = new Point(142, 0);
		xrTableCell106.Location = location;
		XrTableCell99.Name = "XrTableCell99";
		XRTableCell xrTableCell107 = XrTableCell99;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell107.Padding = padding;
		XRTableCell xrTableCell108 = XrTableCell99;
		size = new Size(133, 25);
		xrTableCell108.Size = size;
		XrTableCell99.Text = "XrTableCell99";
		XrTableCell100.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desprovincia", "")
		});
		XRTableCell xrTableCell109 = XrTableCell100;
		location = new Point(275, 0);
		xrTableCell109.Location = location;
		XrTableCell100.Name = "XrTableCell100";
		XRTableCell xrTableCell110 = XrTableCell100;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell110.Padding = padding;
		XRTableCell xrTableCell111 = XrTableCell100;
		size = new Size(133, 25);
		xrTableCell111.Size = size;
		XrTableCell100.Text = "XrTableCell100";
		XrTableCell101.Borders = BorderSide.Right;
		XrTableCell101.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.desdepartamento", "")
		});
		XRTableCell xrTableCell112 = XrTableCell101;
		location = new Point(408, 0);
		xrTableCell112.Location = location;
		XrTableCell101.Name = "XrTableCell101";
		XRTableCell xrTableCell113 = XrTableCell101;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell113.Padding = padding;
		XrTableCell101.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell114 = XrTableCell101;
		size = new Size(192, 25);
		xrTableCell114.Size = size;
		XrTableCell101.Text = "XrTableCell101";
		XrTableRow1.Cells.AddRange(new XRTableCell[5] { XrTableCell1, XrTableCell2, XrTableCell3, XrTableCell12, XrTableCell13 });
		XrTableRow1.Name = "XrTableRow1";
		XRTableRow xrTableRow10 = XrTableRow1;
		size = new Size(600, 25);
		xrTableRow10.Size = size;
		XrTableCell1.Borders = BorderSide.Left | BorderSide.Top;
		XRTableCell xrTableCell115 = XrTableCell1;
		location = new Point(0, 0);
		xrTableCell115.Location = location;
		XrTableCell1.Name = "XrTableCell1";
		XRTableCell xrTableCell116 = XrTableCell1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell116.Padding = padding;
		XrTableCell1.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell117 = XrTableCell1;
		size = new Size(75, 25);
		xrTableCell117.Size = size;
		XrTableCell2.Borders = BorderSide.Top;
		XrTableCell2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell118 = XrTableCell2;
		location = new Point(75, 0);
		xrTableCell118.Location = location;
		XrTableCell2.Name = "XrTableCell2";
		XRTableCell xrTableCell119 = XrTableCell2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell119.Padding = padding;
		XrTableCell2.ParentStyleUsing.UseBorders = false;
		XrTableCell2.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell120 = XrTableCell2;
		size = new Size(200, 25);
		xrTableCell120.Size = size;
		XrTableCell2.Text = "Calle,Jirón, Av.";
		XrTableCell3.Borders = BorderSide.Top;
		XrTableCell3.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell121 = XrTableCell3;
		location = new Point(275, 0);
		xrTableCell121.Location = location;
		XrTableCell3.Name = "XrTableCell3";
		XRTableCell xrTableCell122 = XrTableCell3;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell122.Padding = padding;
		XrTableCell3.ParentStyleUsing.UseBorders = false;
		XrTableCell3.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell123 = XrTableCell3;
		size = new Size(133, 25);
		xrTableCell123.Size = size;
		XrTableCell3.Text = "Distrito";
		XrTableCell12.Borders = BorderSide.Top;
		XrTableCell12.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell124 = XrTableCell12;
		location = new Point(408, 0);
		xrTableCell124.Location = location;
		XrTableCell12.Name = "XrTableCell12";
		XRTableCell xrTableCell125 = XrTableCell12;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell125.Padding = padding;
		XrTableCell12.ParentStyleUsing.UseBorders = false;
		XrTableCell12.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell126 = XrTableCell12;
		size = new Size(100, 25);
		xrTableCell126.Size = size;
		XrTableCell12.Text = "Provincia";
		XrTableCell13.Borders = BorderSide.Top | BorderSide.Right;
		XrTableCell13.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell127 = XrTableCell13;
		location = new Point(508, 0);
		xrTableCell127.Location = location;
		XrTableCell13.Name = "XrTableCell13";
		XRTableCell xrTableCell128 = XrTableCell13;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell128.Padding = padding;
		XrTableCell13.ParentStyleUsing.UseBorders = false;
		XrTableCell13.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell129 = XrTableCell13;
		size = new Size(92, 25);
		xrTableCell129.Size = size;
		XrTableCell13.Text = "Departamento";
		XrTableRow11.Cells.AddRange(new XRTableCell[5] { XrTableCell45, XrTableCell46, XrTableCell47, XrTableCell48, XrTableCell49 });
		XrTableRow11.Name = "XrTableRow11";
		XRTableRow xrTableRow11 = XrTableRow11;
		size = new Size(600, 25);
		xrTableRow11.Size = size;
		XrTableCell45.Borders = BorderSide.Left | BorderSide.Bottom;
		XrTableCell45.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell130 = XrTableCell45;
		location = new Point(0, 0);
		xrTableCell130.Location = location;
		XrTableCell45.Name = "XrTableCell45";
		XRTableCell xrTableCell131 = XrTableCell45;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell131.Padding = padding;
		XrTableCell45.ParentStyleUsing.UseBorders = false;
		XrTableCell45.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell132 = XrTableCell45;
		size = new Size(75, 25);
		xrTableCell132.Size = size;
		XrTableCell45.Text = "Dirección:";
		XrTableCell46.Borders = BorderSide.Bottom;
		XrTableCell46.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.direccion", "")
		});
		XRTableCell xrTableCell133 = XrTableCell46;
		location = new Point(75, 0);
		xrTableCell133.Location = location;
		XrTableCell46.Name = "XrTableCell46";
		XRTableCell xrTableCell134 = XrTableCell46;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell134.Padding = padding;
		XrTableCell46.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell135 = XrTableCell46;
		size = new Size(200, 25);
		xrTableCell135.Size = size;
		XrTableCell46.Text = "XrTableCell46";
		XrTableCell47.Borders = BorderSide.Bottom;
		XrTableCell47.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.DistCasa", "")
		});
		XRTableCell xrTableCell136 = XrTableCell47;
		location = new Point(275, 0);
		xrTableCell136.Location = location;
		XrTableCell47.Name = "XrTableCell47";
		XRTableCell xrTableCell137 = XrTableCell47;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell137.Padding = padding;
		XrTableCell47.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell138 = XrTableCell47;
		size = new Size(133, 25);
		xrTableCell138.Size = size;
		XrTableCell47.Text = "XrTableCell47";
		XrTableCell48.Borders = BorderSide.Bottom;
		XrTableCell48.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ProvCasa", "")
		});
		XRTableCell xrTableCell139 = XrTableCell48;
		location = new Point(408, 0);
		xrTableCell139.Location = location;
		XrTableCell48.Name = "XrTableCell48";
		XRTableCell xrTableCell140 = XrTableCell48;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell140.Padding = padding;
		XrTableCell48.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell141 = XrTableCell48;
		size = new Size(92, 25);
		xrTableCell141.Size = size;
		XrTableCell48.Text = "XrTableCell48";
		XrTableCell49.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell49.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.depCasa", "")
		});
		XRTableCell xrTableCell142 = XrTableCell49;
		location = new Point(500, 0);
		xrTableCell142.Location = location;
		XrTableCell49.Name = "XrTableCell49";
		XRTableCell xrTableCell143 = XrTableCell49;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell143.Padding = padding;
		XrTableCell49.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell144 = XrTableCell49;
		size = new Size(100, 25);
		xrTableCell144.Size = size;
		XrTableCell49.Text = "XrTableCell49";
		PageHeader.Height = 0;
		PageHeader.Name = "PageHeader";
		PageFooter.Controls.AddRange(new XRControl[1] { XrPageInfo1 });
		PageFooter.Height = 42;
		PageFooter.Name = "PageFooter";
		XRPageInfo xrPageInfo = XrPageInfo1;
		location = new Point(625, 8);
		xrPageInfo.Location = location;
		XrPageInfo1.Name = "XrPageInfo1";
		XRPageInfo xrPageInfo2 = XrPageInfo1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo2.Padding = padding;
		XRPageInfo xrPageInfo3 = XrPageInfo1;
		size = new Size(58, 25);
		xrPageInfo3.Size = size;
		DataSet11.DataSetName = "DataSet1";
		DataSet11.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		DetailReport.Bands.AddRange(new Band[2] { Detail1, GroupHeader1 });
		DetailReport.DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DetailReport.DataMember = "spRRHH_Ficha_ExpLab";
		DetailReport.DataSource = DataSet11;
		DetailReport.Level = 1;
		DetailReport.Name = "DetailReport";
		Detail1.Height = 0;
		Detail1.Name = "Detail1";
		GroupHeader1.Controls.AddRange(new XRControl[3] { XrTable6, XrTable4, XrLabel5 });
		GroupHeader1.Height = 289;
		GroupHeader1.Name = "GroupHeader1";
		XRTable xrTable3 = XrTable6;
		location = new Point(25, 92);
		xrTable3.Location = location;
		XrTable6.Name = "XrTable6";
		XrTable6.Rows.AddRange(new XRTableRow[6] { XrTableRow25, XrTableRow29, XrTableRow27, XrTableRow26, XrTableRow31, XrTableRow32 });
		XRTable xrTable4 = XrTable6;
		size = new Size(600, 193);
		xrTable4.Size = size;
		XrTableRow25.Cells.AddRange(new XRTableCell[2] { XrTableCell52, XrTableCell102 });
		XrTableRow25.Name = "XrTableRow25";
		XRTableRow xrTableRow12 = XrTableRow25;
		size = new Size(600, 33);
		xrTableRow12.Size = size;
		XrTableCell52.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell145 = XrTableCell52;
		location = new Point(0, 0);
		xrTableCell145.Location = location;
		XrTableCell52.Name = "XrTableCell52";
		XRTableCell xrTableCell146 = XrTableCell52;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell146.Padding = padding;
		XrTableCell52.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell147 = XrTableCell52;
		size = new Size(198, 33);
		xrTableCell147.Size = size;
		XrTableCell52.Text = "Lugar de Trabajo:";
		XrTableCell102.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.AreaOrganizacional", "")
		});
		XRTableCell xrTableCell148 = XrTableCell102;
		location = new Point(198, 0);
		xrTableCell148.Location = location;
		XrTableCell102.Name = "XrTableCell102";
		XRTableCell xrTableCell149 = XrTableCell102;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell149.Padding = padding;
		XRTableCell xrTableCell150 = XrTableCell102;
		size = new Size(402, 33);
		xrTableCell150.Size = size;
		XrTableCell102.Text = "XrTableCell102";
		XrTableRow29.Cells.AddRange(new XRTableCell[2] { XrTableCell109, XrTableCell110 });
		XrTableRow29.Name = "XrTableRow29";
		XRTableRow xrTableRow13 = XrTableRow29;
		size = new Size(600, 33);
		xrTableRow13.Size = size;
		XrTableCell109.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell151 = XrTableCell109;
		location = new Point(0, 0);
		xrTableCell151.Location = location;
		XrTableCell109.Name = "XrTableCell109";
		XRTableCell xrTableCell152 = XrTableCell109;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell152.Padding = padding;
		XrTableCell109.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell153 = XrTableCell109;
		size = new Size(198, 33);
		xrTableCell153.Size = size;
		XrTableCell109.Text = "Condición Laboral:";
		XrTableCell110.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.CondicionLab", "")
		});
		XRTableCell xrTableCell154 = XrTableCell110;
		location = new Point(198, 0);
		xrTableCell154.Location = location;
		XrTableCell110.Name = "XrTableCell110";
		XRTableCell xrTableCell155 = XrTableCell110;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell155.Padding = padding;
		XRTableCell xrTableCell156 = XrTableCell110;
		size = new Size(402, 33);
		xrTableCell156.Size = size;
		XrTableCell110.Text = "XrTableCell110";
		XrTableRow27.Cells.AddRange(new XRTableCell[2] { XrTableCell105, XrTableCell106 });
		XrTableRow27.Name = "XrTableRow27";
		XRTableRow xrTableRow14 = XrTableRow27;
		size = new Size(600, 33);
		xrTableRow14.Size = size;
		XrTableCell105.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell157 = XrTableCell105;
		location = new Point(0, 0);
		xrTableCell157.Location = location;
		XrTableCell105.Name = "XrTableCell105";
		XRTableCell xrTableCell158 = XrTableCell105;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell158.Padding = padding;
		XrTableCell105.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell159 = XrTableCell105;
		size = new Size(198, 33);
		xrTableCell159.Size = size;
		XrTableCell105.Text = "Profesión u ocupación:";
		XrTableCell106.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.profesion", "")
		});
		XRTableCell xrTableCell160 = XrTableCell106;
		location = new Point(198, 0);
		xrTableCell160.Location = location;
		XrTableCell106.Name = "XrTableCell106";
		XRTableCell xrTableCell161 = XrTableCell106;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell161.Padding = padding;
		XRTableCell xrTableCell162 = XrTableCell106;
		size = new Size(402, 33);
		xrTableCell162.Size = size;
		XrTableCell106.Text = "XrTableCell106";
		XrTableRow26.Cells.AddRange(new XRTableCell[2] { XrTableCell103, XrTableCell104 });
		XrTableRow26.Name = "XrTableRow26";
		XRTableRow xrTableRow15 = XrTableRow26;
		size = new Size(600, 33);
		xrTableRow15.Size = size;
		XrTableCell103.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell163 = XrTableCell103;
		location = new Point(0, 0);
		xrTableCell163.Location = location;
		XrTableCell103.Name = "XrTableCell103";
		XRTableCell xrTableCell164 = XrTableCell103;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell164.Padding = padding;
		XrTableCell103.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell165 = XrTableCell103;
		size = new Size(250, 33);
		xrTableCell165.Size = size;
		XrTableCell103.Text = "Cargo que desempeña o labor que realiza:";
		XrTableCell104.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.cargo", "")
		});
		XRTableCell xrTableCell166 = XrTableCell104;
		location = new Point(250, 0);
		xrTableCell166.Location = location;
		XrTableCell104.Name = "XrTableCell104";
		XRTableCell xrTableCell167 = XrTableCell104;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell167.Padding = padding;
		XRTableCell xrTableCell168 = XrTableCell104;
		size = new Size(350, 33);
		xrTableCell168.Size = size;
		XrTableCell104.Text = "XrTableCell104";
		XrTableRow31.Cells.AddRange(new XRTableCell[4] { XrTableCell113, XrTableCell114, XrTableCell115, XrTableCell116 });
		XrTableRow31.Name = "XrTableRow31";
		XRTableRow xrTableRow16 = XrTableRow31;
		size = new Size(600, 33);
		xrTableRow16.Size = size;
		XrTableCell113.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell169 = XrTableCell113;
		location = new Point(0, 0);
		xrTableCell169.Location = location;
		XrTableCell113.Name = "XrTableCell113";
		XRTableCell xrTableCell170 = XrTableCell113;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell170.Padding = padding;
		XrTableCell113.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell171 = XrTableCell113;
		size = new Size(150, 33);
		xrTableCell171.Size = size;
		XrTableCell113.Text = "Reg. Pensión:";
		XrTableCell114.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.LeyRegimen", "")
		});
		XRTableCell xrTableCell172 = XrTableCell114;
		location = new Point(150, 0);
		xrTableCell172.Location = location;
		XrTableCell114.Name = "XrTableCell114";
		XRTableCell xrTableCell173 = XrTableCell114;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell173.Padding = padding;
		XRTableCell xrTableCell174 = XrTableCell114;
		size = new Size(150, 33);
		xrTableCell174.Size = size;
		XrTableCell114.Text = "XrTableCell114";
		XrTableCell115.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell175 = XrTableCell115;
		location = new Point(300, 0);
		xrTableCell175.Location = location;
		XrTableCell115.Name = "XrTableCell115";
		XRTableCell xrTableCell176 = XrTableCell115;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell176.Padding = padding;
		XrTableCell115.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell177 = XrTableCell115;
		size = new Size(150, 33);
		xrTableCell177.Size = size;
		XrTableCell115.Text = "AFP:";
		XrTableCell116.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.DescripAFP", "")
		});
		XRTableCell xrTableCell178 = XrTableCell116;
		location = new Point(450, 0);
		xrTableCell178.Location = location;
		XrTableCell116.Name = "XrTableCell116";
		XRTableCell xrTableCell179 = XrTableCell116;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell179.Padding = padding;
		XRTableCell xrTableCell180 = XrTableCell116;
		size = new Size(150, 33);
		xrTableCell180.Size = size;
		XrTableCell116.Text = "XrTableCell116";
		XrTableRow32.Cells.AddRange(new XRTableCell[4] { XrTableCell117, XrTableCell118, XrTableCell119, XrTableCell120 });
		XrTableRow32.Name = "XrTableRow32";
		XRTableRow xrTableRow17 = XrTableRow32;
		size = new Size(600, 28);
		xrTableRow17.Size = size;
		XrTableCell117.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell181 = XrTableCell117;
		location = new Point(0, 0);
		xrTableCell181.Location = location;
		XrTableCell117.Name = "XrTableCell117";
		XRTableCell xrTableCell182 = XrTableCell117;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell182.Padding = padding;
		XrTableCell117.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell183 = XrTableCell117;
		size = new Size(150, 28);
		xrTableCell183.Size = size;
		XrTableCell117.Text = "Fecha Inscrip. AFP:";
		XrTableCell118.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaAFP", "")
		});
		XRTableCell xrTableCell184 = XrTableCell118;
		location = new Point(150, 0);
		xrTableCell184.Location = location;
		XrTableCell118.Name = "XrTableCell118";
		XRTableCell xrTableCell185 = XrTableCell118;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell185.Padding = padding;
		XRTableCell xrTableCell186 = XrTableCell118;
		size = new Size(150, 28);
		xrTableCell186.Size = size;
		XrTableCell118.Text = "XrTableCell118";
		XrTableCell119.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell187 = XrTableCell119;
		location = new Point(300, 0);
		xrTableCell187.Location = location;
		XrTableCell119.Name = "XrTableCell119";
		XRTableCell xrTableCell188 = XrTableCell119;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell188.Padding = padding;
		XrTableCell119.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell189 = XrTableCell119;
		size = new Size(150, 28);
		xrTableCell189.Size = size;
		XrTableCell119.Text = "Num CUSPP:";
		XrTableCell120.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.NroAFP", "")
		});
		XRTableCell xrTableCell190 = XrTableCell120;
		location = new Point(450, 0);
		xrTableCell190.Location = location;
		XrTableCell120.Name = "XrTableCell120";
		XRTableCell xrTableCell191 = XrTableCell120;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell191.Padding = padding;
		XRTableCell xrTableCell192 = XrTableCell120;
		size = new Size(150, 28);
		xrTableCell192.Size = size;
		XrTableCell120.Text = "XrTableCell120";
		XRTable xrTable5 = XrTable4;
		location = new Point(25, 33);
		xrTable5.Location = location;
		XrTable4.Name = "XrTable4";
		XrTable4.Rows.AddRange(new XRTableRow[2] { XrTableRow19, XrTableRow18 });
		XRTable xrTable6 = XrTable4;
		size = new Size(600, 50);
		xrTable6.Size = size;
		XrTableRow19.Cells.AddRange(new XRTableCell[2] { XrTableCell83, XrTableCell71 });
		XrTableRow19.Name = "XrTableRow19";
		XRTableRow xrTableRow18 = XrTableRow19;
		size = new Size(600, 25);
		xrTableRow18.Size = size;
		XrTableCell83.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell193 = XrTableCell83;
		location = new Point(0, 0);
		xrTableCell193.Location = location;
		XrTableCell83.Name = "XrTableCell83";
		XRTableCell xrTableCell194 = XrTableCell83;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell194.Padding = padding;
		XrTableCell83.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell195 = XrTableCell83;
		size = new Size(208, 25);
		xrTableCell195.Size = size;
		XrTableCell83.Text = "Fecha de Ingreso al Estado:";
		XrTableCell71.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.FechaIngreEstado", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell196 = XrTableCell71;
		location = new Point(208, 0);
		xrTableCell196.Location = location;
		XrTableCell71.Name = "XrTableCell71";
		XRTableCell xrTableCell197 = XrTableCell71;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell197.Padding = padding;
		XRTableCell xrTableCell198 = XrTableCell71;
		size = new Size(392, 25);
		xrTableCell198.Size = size;
		XrTableCell71.Text = "XrTableCell71";
		XrTableRow18.Cells.AddRange(new XRTableCell[2] { XrTableCell80, XrTableCell84 });
		XrTableRow18.Name = "XrTableRow18";
		XRTableRow xrTableRow19 = XrTableRow18;
		size = new Size(600, 25);
		xrTableRow19.Size = size;
		XrTableCell80.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell199 = XrTableCell80;
		location = new Point(0, 0);
		xrTableCell199.Location = location;
		XrTableCell80.Name = "XrTableCell80";
		XRTableCell xrTableCell200 = XrTableCell80;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell200.Padding = padding;
		XrTableCell80.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell201 = XrTableCell80;
		size = new Size(208, 25);
		xrTableCell201.Size = size;
		XrTableCell80.Text = "Fecha de Ingreso a la Institución:";
		XrTableCell84.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_ExpLab_Datos.Fechaingreso", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell202 = XrTableCell84;
		location = new Point(208, 0);
		xrTableCell202.Location = location;
		XrTableCell84.Name = "XrTableCell84";
		XRTableCell xrTableCell203 = XrTableCell84;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell203.Padding = padding;
		XRTableCell xrTableCell204 = XrTableCell84;
		size = new Size(392, 25);
		xrTableCell204.Size = size;
		XrTableCell84.Text = "XrTableCell84";
		XrLabel5.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel7 = XrLabel5;
		location = new Point(25, 0);
		xrLabel7.Location = location;
		XrLabel5.Name = "XrLabel5";
		XRLabel xrLabel8 = XrLabel5;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel8.Padding = padding;
		XrLabel5.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel9 = XrLabel5;
		size = new Size(283, 25);
		xrLabel9.Size = size;
		XrLabel5.Text = "III. ASPECTO LABORAL DEL TRABAJADOR";
		DetailReport1.Bands.AddRange(new Band[3] { Detail2, GroupHeader2, GroupFooter1 });
		DetailReport1.DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DetailReport1.DataMember = "spRRHH_Ficha_Det_Familiar";
		DetailReport1.DataSource = DataSet11;
		DetailReport1.Level = 2;
		DetailReport1.Name = "DetailReport1";
		Detail2.Controls.AddRange(new XRControl[1] { XrTable12 });
		Detail2.Height = 25;
		Detail2.Name = "Detail2";
		XRTable xrTable7 = XrTable12;
		location = new Point(8, 0);
		xrTable7.Location = location;
		XrTable12.Name = "XrTable12";
		XrTable12.Rows.AddRange(new XRTableRow[1] { XrTableRow39 });
		XRTable xrTable8 = XrTable12;
		size = new Size(658, 25);
		xrTable8.Size = size;
		XrTableRow39.Cells.AddRange(new XRTableCell[8] { XrTableCell137, XrTableCell138, XrTableCell143, XrTableCell144, XrTableCell145, XrTableCell146, XrTableCell131, XrTableCell132 });
		XrTableRow39.Name = "XrTableRow39";
		XRTableRow xrTableRow20 = XrTableRow39;
		size = new Size(658, 25);
		xrTableRow20.Size = size;
		XrTableCell137.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.NombresFamilia", "")
		});
		XRTableCell xrTableCell205 = XrTableCell137;
		location = new Point(0, 0);
		xrTableCell205.Location = location;
		XrTableCell137.Name = "XrTableCell137";
		XRTableCell xrTableCell206 = XrTableCell137;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell206.Padding = padding;
		XRTableCell xrTableCell207 = XrTableCell137;
		size = new Size(183, 25);
		xrTableCell207.Size = size;
		XrTableCell137.Text = "XrTableCell137";
		XrTableCell138.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.edadFamiliar", "")
		});
		XRTableCell xrTableCell208 = XrTableCell138;
		location = new Point(183, 0);
		xrTableCell208.Location = location;
		XrTableCell138.Name = "XrTableCell138";
		XRTableCell xrTableCell209 = XrTableCell138;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell209.Padding = padding;
		XRTableCell xrTableCell210 = XrTableCell138;
		size = new Size(51, 25);
		xrTableCell210.Size = size;
		XrTableCell138.Text = "XrTableCell138";
		XrTableCell143.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamSexo", "")
		});
		XRTableCell xrTableCell211 = XrTableCell143;
		location = new Point(234, 0);
		xrTableCell211.Location = location;
		XrTableCell143.Name = "XrTableCell143";
		XRTableCell xrTableCell212 = XrTableCell143;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell212.Padding = padding;
		XRTableCell xrTableCell213 = XrTableCell143;
		size = new Size(42, 25);
		xrTableCell213.Size = size;
		XrTableCell143.Text = "XrTableCell143";
		XrTableCell144.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripTipoFam", "")
		});
		XRTableCell xrTableCell214 = XrTableCell144;
		location = new Point(276, 0);
		xrTableCell214.Location = location;
		XrTableCell144.Name = "XrTableCell144";
		XRTableCell xrTableCell215 = XrTableCell144;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell215.Padding = padding;
		XRTableCell xrTableCell216 = XrTableCell144;
		size = new Size(82, 25);
		xrTableCell216.Size = size;
		XrTableCell144.Text = "XrTableCell144";
		XrTableCell145.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.FamGradoInstruc", "")
		});
		XRTableCell xrTableCell217 = XrTableCell145;
		location = new Point(358, 0);
		xrTableCell217.Location = location;
		XrTableCell145.Name = "XrTableCell145";
		XRTableCell xrTableCell218 = XrTableCell145;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell218.Padding = padding;
		XRTableCell xrTableCell219 = XrTableCell145;
		size = new Size(93, 25);
		xrTableCell219.Size = size;
		XrTableCell145.Text = "XrTableCell145";
		XrTableCell146.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar.DescripEstCivil", "")
		});
		XRTableCell xrTableCell220 = XrTableCell146;
		location = new Point(451, 0);
		xrTableCell220.Location = location;
		XrTableCell146.Name = "XrTableCell146";
		XRTableCell xrTableCell221 = XrTableCell146;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell221.Padding = padding;
		XRTableCell xrTableCell222 = XrTableCell146;
		size = new Size(66, 25);
		xrTableCell222.Size = size;
		XrTableCell146.Text = "XrTableCell146";
		XrTableCell131.BookmarkParent = XrCheckBoxViveCasa;
		XrTableCell131.Controls.AddRange(new XRControl[1] { XrCheckBoxViveCasa });
		XRTableCell xrTableCell223 = XrTableCell131;
		location = new Point(517, 0);
		xrTableCell223.Location = location;
		XrTableCell131.Name = "XrTableCell131";
		XRTableCell xrTableCell224 = XrTableCell131;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell224.Padding = padding;
		XRTableCell xrTableCell225 = XrTableCell131;
		size = new Size(83, 25);
		xrTableCell225.Size = size;
		XrCheckBoxViveCasa.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.ViveCasa", "")
		});
		XRCheckBox xrCheckBoxViveCasa = XrCheckBoxViveCasa;
		location = new Point(25, 0);
		xrCheckBoxViveCasa.Location = location;
		XrCheckBoxViveCasa.Name = "XrCheckBoxViveCasa";
		XRCheckBox xrCheckBoxViveCasa2 = XrCheckBoxViveCasa;
		size = new Size(42, 25);
		xrCheckBoxViveCasa2.Size = size;
		XrTableCell132.BookmarkParent = XrCheckBoxLabInst;
		XrTableCell132.Controls.AddRange(new XRControl[1] { XrCheckBoxLabInst });
		XRTableCell xrTableCell226 = XrTableCell132;
		location = new Point(600, 0);
		xrTableCell226.Location = location;
		XrTableCell132.Name = "XrTableCell132";
		XRTableCell xrTableCell227 = XrTableCell132;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell227.Padding = padding;
		XRTableCell xrTableCell228 = XrTableCell132;
		size = new Size(58, 25);
		xrTableCell228.Size = size;
		XrCheckBoxLabInst.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Det_Familiar.LaboraInstitucion", "")
		});
		XRCheckBox xrCheckBoxLabInst = XrCheckBoxLabInst;
		location = new Point(8, 0);
		xrCheckBoxLabInst.Location = location;
		XrCheckBoxLabInst.Name = "XrCheckBoxLabInst";
		XRCheckBox xrCheckBoxLabInst2 = XrCheckBoxLabInst;
		size = new Size(50, 25);
		xrCheckBoxLabInst2.Size = size;
		GroupHeader2.Controls.AddRange(new XRControl[4] { XrTable13, XrLabel7, XrTable7, XrLabel6 });
		GroupHeader2.Height = 200;
		GroupHeader2.Name = "GroupHeader2";
		XrTable13.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable9 = XrTable13;
		location = new Point(8, 175);
		xrTable9.Location = location;
		XrTable13.Name = "XrTable13";
		XrTable13.ParentStyleUsing.UseFont = false;
		XrTable13.Rows.AddRange(new XRTableRow[1] { XrTableRow40 });
		XRTable xrTable10 = XrTable13;
		size = new Size(658, 25);
		xrTable10.Size = size;
		XrTableRow40.Cells.AddRange(new XRTableCell[8] { XrTableCell163, XrTableCell164, XrTableCell165, XrTableCell166, XrTableCell167, XrTableCell168, XrTableCell169, XrTableCell133 });
		XrTableRow40.Name = "XrTableRow40";
		XRTableRow xrTableRow21 = XrTableRow40;
		size = new Size(658, 25);
		xrTableRow21.Size = size;
		XRTableCell xrTableCell229 = XrTableCell163;
		location = new Point(0, 0);
		xrTableCell229.Location = location;
		XrTableCell163.Name = "XrTableCell163";
		XRTableCell xrTableCell230 = XrTableCell163;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell230.Padding = padding;
		XRTableCell xrTableCell231 = XrTableCell163;
		size = new Size(183, 25);
		xrTableCell231.Size = size;
		XrTableCell163.Text = "Nombres y Apellidos";
		XRTableCell xrTableCell232 = XrTableCell164;
		location = new Point(183, 0);
		xrTableCell232.Location = location;
		XrTableCell164.Name = "XrTableCell164";
		XRTableCell xrTableCell233 = XrTableCell164;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell233.Padding = padding;
		XRTableCell xrTableCell234 = XrTableCell164;
		size = new Size(51, 25);
		xrTableCell234.Size = size;
		XrTableCell164.Text = "Edad";
		XRTableCell xrTableCell235 = XrTableCell165;
		location = new Point(234, 0);
		xrTableCell235.Location = location;
		XrTableCell165.Name = "XrTableCell165";
		XRTableCell xrTableCell236 = XrTableCell165;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell236.Padding = padding;
		XRTableCell xrTableCell237 = XrTableCell165;
		size = new Size(42, 25);
		xrTableCell237.Size = size;
		XrTableCell165.Text = "Sexo";
		XRTableCell xrTableCell238 = XrTableCell166;
		location = new Point(276, 0);
		xrTableCell238.Location = location;
		XrTableCell166.Name = "XrTableCell166";
		XRTableCell xrTableCell239 = XrTableCell166;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell239.Padding = padding;
		XRTableCell xrTableCell240 = XrTableCell166;
		size = new Size(82, 25);
		xrTableCell240.Size = size;
		XrTableCell166.Text = "Parentesco";
		XRTableCell xrTableCell241 = XrTableCell167;
		location = new Point(358, 0);
		xrTableCell241.Location = location;
		XrTableCell167.Name = "XrTableCell167";
		XRTableCell xrTableCell242 = XrTableCell167;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell242.Padding = padding;
		XRTableCell xrTableCell243 = XrTableCell167;
		size = new Size(93, 25);
		xrTableCell243.Size = size;
		XrTableCell167.Text = "Grado de Inst.";
		XRTableCell xrTableCell244 = XrTableCell168;
		location = new Point(451, 0);
		xrTableCell244.Location = location;
		XrTableCell168.Name = "XrTableCell168";
		XRTableCell xrTableCell245 = XrTableCell168;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell245.Padding = padding;
		XRTableCell xrTableCell246 = XrTableCell168;
		size = new Size(66, 25);
		xrTableCell246.Size = size;
		XrTableCell168.Text = "E.Civil";
		XRTableCell xrTableCell247 = XrTableCell169;
		location = new Point(517, 0);
		xrTableCell247.Location = location;
		XrTableCell169.Name = "XrTableCell169";
		XRTableCell xrTableCell248 = XrTableCell169;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell248.Padding = padding;
		XRTableCell xrTableCell249 = XrTableCell169;
		size = new Size(83, 25);
		xrTableCell249.Size = size;
		XrTableCell169.Text = "Vive en Casa";
		XRTableCell xrTableCell250 = XrTableCell133;
		location = new Point(600, 0);
		xrTableCell250.Location = location;
		XrTableCell133.Name = "XrTableCell133";
		XRTableCell xrTableCell251 = XrTableCell133;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell251.Padding = padding;
		XRTableCell xrTableCell252 = XrTableCell133;
		size = new Size(58, 25);
		xrTableCell252.Size = size;
		XrTableCell133.Text = "Lab. Instit.";
		XrLabel7.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel10 = XrLabel7;
		location = new Point(58, 142);
		xrLabel10.Location = location;
		XrLabel7.Name = "XrLabel7";
		XRLabel xrLabel11 = XrLabel7;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel11.Padding = padding;
		XrLabel7.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel12 = XrLabel7;
		size = new Size(250, 25);
		xrLabel12.Size = size;
		XrLabel7.Text = "4.1 Composición Familiar:";
		XRTable xrTable11 = XrTable7;
		location = new Point(25, 50);
		xrTable11.Location = location;
		XrTable7.Name = "XrTable7";
		XrTable7.Rows.AddRange(new XRTableRow[3] { XrTableRow30, XrTableRow28, XrTableRow35 });
		XRTable xrTable12 = XrTable7;
		size = new Size(600, 75);
		xrTable12.Size = size;
		XrTableRow30.Cells.AddRange(new XRTableCell[2] { XrTableCell111, XrTableCell112 });
		XrTableRow30.Name = "XrTableRow30";
		XRTableRow xrTableRow22 = XrTableRow30;
		size = new Size(600, 25);
		xrTableRow22.Size = size;
		XrTableCell111.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell253 = XrTableCell111;
		location = new Point(0, 0);
		xrTableCell253.Location = location;
		XrTableCell111.Name = "XrTableCell111";
		XRTableCell xrTableCell254 = XrTableCell111;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell254.Padding = padding;
		XrTableCell111.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell255 = XrTableCell111;
		size = new Size(199, 25);
		xrTableCell255.Size = size;
		XrTableCell111.Text = "¿Con quién vives actualmente?";
		XrTableCell112.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Descripvivecon", "")
		});
		XRTableCell xrTableCell256 = XrTableCell112;
		location = new Point(199, 0);
		xrTableCell256.Location = location;
		XrTableCell112.Name = "XrTableCell112";
		XRTableCell xrTableCell257 = XrTableCell112;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell257.Padding = padding;
		XRTableCell xrTableCell258 = XrTableCell112;
		size = new Size(401, 25);
		xrTableCell258.Size = size;
		XrTableCell112.Text = "XrTableCell112";
		XrTableRow28.Cells.AddRange(new XRTableCell[4] { XrTableCell74, XrTableCell94, XrTableCell95, XrTableCell96 });
		XrTableRow28.Name = "XrTableRow28";
		XRTableRow xrTableRow23 = XrTableRow28;
		size = new Size(600, 25);
		xrTableRow23.Size = size;
		XrTableCell74.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell259 = XrTableCell74;
		location = new Point(0, 0);
		xrTableCell259.Location = location;
		XrTableCell74.Name = "XrTableCell74";
		XRTableCell xrTableCell260 = XrTableCell74;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell260.Padding = padding;
		XrTableCell74.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell261 = XrTableCell74;
		size = new Size(199, 25);
		xrTableCell261.Size = size;
		XrTableCell74.Text = "¿Eres Jefe de Hogar?";
		XrTableCell94.BookmarkParent = XrCheckBoxJefe;
		XrTableCell94.Controls.AddRange(new XRControl[1] { XrCheckBoxJefe });
		XRTableCell xrTableCell262 = XrTableCell94;
		location = new Point(199, 0);
		xrTableCell262.Location = location;
		XrTableCell94.Name = "XrTableCell94";
		XRTableCell xrTableCell263 = XrTableCell94;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell263.Padding = padding;
		XRTableCell xrTableCell264 = XrTableCell94;
		size = new Size(134, 25);
		xrTableCell264.Size = size;
		XrCheckBoxJefe.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.JefeHogar", "")
		});
		XRCheckBox xrCheckBoxJefe = XrCheckBoxJefe;
		location = new Point(34, 0);
		xrCheckBoxJefe.Location = location;
		XrCheckBoxJefe.Name = "XrCheckBoxJefe";
		XRCheckBox xrCheckBoxJefe2 = XrCheckBoxJefe;
		size = new Size(42, 25);
		xrCheckBoxJefe2.Size = size;
		XrTableCell95.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell265 = XrTableCell95;
		location = new Point(333, 0);
		xrTableCell265.Location = location;
		XrTableCell95.Name = "XrTableCell95";
		XRTableCell xrTableCell266 = XrTableCell95;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell266.Padding = padding;
		XrTableCell95.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell267 = XrTableCell95;
		size = new Size(166, 25);
		xrTableCell267.Size = size;
		XrTableCell95.Text = "Carga Familiar:";
		XrTableCell96.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.CargaFam", "")
		});
		XRTableCell xrTableCell268 = XrTableCell96;
		location = new Point(499, 0);
		xrTableCell268.Location = location;
		XrTableCell96.Name = "XrTableCell96";
		XRTableCell xrTableCell269 = XrTableCell96;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell269.Padding = padding;
		XRTableCell xrTableCell270 = XrTableCell96;
		size = new Size(101, 25);
		xrTableCell270.Size = size;
		XrTableCell96.Text = "XrTableCell96";
		XrTableRow35.Cells.AddRange(new XRTableCell[4] { XrTableCell107, XrTableCell108, XrTableCell129, XrTableCell130 });
		XrTableRow35.Name = "XrTableRow35";
		XRTableRow xrTableRow24 = XrTableRow35;
		size = new Size(600, 25);
		xrTableRow24.Size = size;
		XRTableCell xrTableCell271 = XrTableCell107;
		location = new Point(0, 0);
		xrTableCell271.Location = location;
		XrTableCell107.Name = "XrTableCell107";
		XRTableCell xrTableCell272 = XrTableCell107;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell272.Padding = padding;
		XRTableCell xrTableCell273 = XrTableCell107;
		size = new Size(199, 25);
		xrTableCell273.Size = size;
		XRTableCell xrTableCell274 = XrTableCell108;
		location = new Point(199, 0);
		xrTableCell274.Location = location;
		XrTableCell108.Name = "XrTableCell108";
		XRTableCell xrTableCell275 = XrTableCell108;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell275.Padding = padding;
		XRTableCell xrTableCell276 = XrTableCell108;
		size = new Size(134, 25);
		xrTableCell276.Size = size;
		XrTableCell129.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell277 = XrTableCell129;
		location = new Point(333, 0);
		xrTableCell277.Location = location;
		XrTableCell129.Name = "XrTableCell129";
		XRTableCell xrTableCell278 = XrTableCell129;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell278.Padding = padding;
		XrTableCell129.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell279 = XrTableCell129;
		size = new Size(166, 25);
		xrTableCell279.Size = size;
		XrTableCell129.Text = "Hijos:";
		XrTableCell130.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.Numhijos", "")
		});
		XRTableCell xrTableCell280 = XrTableCell130;
		location = new Point(499, 0);
		xrTableCell280.Location = location;
		XrTableCell130.Name = "XrTableCell130";
		XRTableCell xrTableCell281 = XrTableCell130;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell281.Padding = padding;
		XRTableCell xrTableCell282 = XrTableCell130;
		size = new Size(101, 25);
		xrTableCell282.Size = size;
		XrTableCell130.Text = "XrTableCell130";
		XrLabel6.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel13 = XrLabel6;
		location = new Point(25, 17);
		xrLabel13.Location = location;
		XrLabel6.Name = "XrLabel6";
		XRLabel xrLabel14 = XrLabel6;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel14.Padding = padding;
		XrLabel6.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel15 = XrLabel6;
		size = new Size(442, 25);
		xrLabel15.Size = size;
		XrLabel6.Text = "IV. ASPECTO SOCIO-FAMILIAR DEL TRABAJADOR";
		GroupFooter1.Controls.AddRange(new XRControl[5] { XrTable22, XrTable3, XrLabel14, XrLabel8, XrTable1 });
		GroupFooter1.Height = 488;
		GroupFooter1.Name = "GroupFooter1";
		XRTable xrTable13 = XrTable22;
		location = new Point(17, 450);
		xrTable13.Location = location;
		XrTable22.Name = "XrTable22";
		XrTable22.Rows.AddRange(new XRTableRow[1] { XrTableRow91 });
		XRTable xrTable14 = XrTable22;
		size = new Size(658, 25);
		xrTable14.Size = size;
		XrTableRow91.Cells.AddRange(new XRTableCell[2] { XrTableCell258, XrTableCell259 });
		XrTableRow91.Name = "XrTableRow91";
		XRTableRow xrTableRow25 = XrTableRow91;
		size = new Size(658, 25);
		xrTableRow25.Size = size;
		XrTableCell258.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Bottom;
		XrTableCell258.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell283 = XrTableCell258;
		location = new Point(0, 0);
		xrTableCell283.Location = location;
		XrTableCell258.Name = "XrTableCell258";
		XRTableCell xrTableCell284 = XrTableCell258;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell284.Padding = padding;
		XrTableCell258.ParentStyleUsing.UseBorders = false;
		XrTableCell258.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell285 = XrTableCell258;
		size = new Size(92, 25);
		xrTableCell285.Size = size;
		XrTableCell258.Text = "Observación:";
		XrTableCell259.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		XrTableCell259.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ObsFam", "")
		});
		XRTableCell xrTableCell286 = XrTableCell259;
		location = new Point(92, 0);
		xrTableCell286.Location = location;
		XrTableCell259.Name = "XrTableCell259";
		XRTableCell xrTableCell287 = XrTableCell259;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell287.Padding = padding;
		XrTableCell259.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell288 = XrTableCell259;
		size = new Size(566, 25);
		xrTableCell288.Size = size;
		XRTable xrTable15 = XrTable3;
		location = new Point(17, 183);
		xrTable15.Location = location;
		XrTable3.Name = "XrTable3";
		XrTable3.Rows.AddRange(new XRTableRow[10] { XrTableRow15, XrTableRow63, XrTableRow33, XrTableRow23, XrTableRow22, XrTableRow21, XrTableRow20, XrTableRow16, XrTableRow17, XrTableRow34 });
		XRTable xrTable16 = XrTable3;
		size = new Size(658, 250);
		xrTable16.Size = size;
		XrTableRow15.Cells.AddRange(new XRTableCell[3] { XrTableCell22, XrTableCell39, XrTableCell57 });
		XrTableRow15.Name = "XrTableRow15";
		XRTableRow xrTableRow26 = XrTableRow15;
		size = new Size(658, 25);
		xrTableRow26.Size = size;
		XRTableCell xrTableCell289 = XrTableCell22;
		location = new Point(0, 0);
		xrTableCell289.Location = location;
		XrTableCell22.Name = "XrTableCell22";
		XRTableCell xrTableCell290 = XrTableCell22;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell290.Padding = padding;
		XRTableCell xrTableCell291 = XrTableCell22;
		size = new Size(217, 25);
		xrTableCell291.Size = size;
		XRTableCell xrTableCell292 = XrTableCell39;
		location = new Point(217, 0);
		xrTableCell292.Location = location;
		XrTableCell39.Name = "XrTableCell39";
		XRTableCell xrTableCell293 = XrTableCell39;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell293.Padding = padding;
		XRTableCell xrTableCell294 = XrTableCell39;
		size = new Size(399, 25);
		xrTableCell294.Size = size;
		XrTableCell57.Borders = BorderSide.All;
		XrTableCell57.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell295 = XrTableCell57;
		location = new Point(616, 0);
		xrTableCell295.Location = location;
		XrTableCell57.Name = "XrTableCell57";
		XRTableCell xrTableCell296 = XrTableCell57;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell296.Padding = padding;
		XrTableCell57.ParentStyleUsing.UseBorders = false;
		XrTableCell57.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell297 = XrTableCell57;
		size = new Size(42, 25);
		xrTableCell297.Size = size;
		XrTableCell57.Text = "Resp.";
		XrTableRow63.Cells.AddRange(new XRTableCell[3] { XrTableCell226, XrTableCell227, XrTableCell228 });
		XrTableRow63.Name = "XrTableRow63";
		XRTableRow xrTableRow27 = XrTableRow63;
		size = new Size(658, 25);
		xrTableRow27.Size = size;
		XrTableCell226.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
		XrTableCell226.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell298 = XrTableCell226;
		location = new Point(0, 0);
		xrTableCell298.Location = location;
		XrTableCell226.Name = "XrTableCell226";
		XRTableCell xrTableCell299 = XrTableCell226;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell299.Padding = padding;
		XrTableCell226.ParentStyleUsing.UseBorders = false;
		XrTableCell226.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell300 = XrTableCell226;
		size = new Size(217, 25);
		xrTableCell300.Size = size;
		XrTableCell226.Text = "COMUNICACIÓN";
		XrTableCell226.TextAlignment = TextAlignment.TopCenter;
		XrTableCell227.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell301 = XrTableCell227;
		location = new Point(217, 0);
		xrTableCell301.Location = location;
		XrTableCell227.Name = "XrTableCell227";
		XRTableCell xrTableCell302 = XrTableCell227;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell302.Padding = padding;
		XrTableCell227.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell303 = XrTableCell227;
		size = new Size(399, 25);
		xrTableCell303.Size = size;
		XrTableCell227.Text = "Es verbal, Fluida y Abierta en todas las Situaciones";
		XrTableCell228.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell228.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.com1", "")
		});
		XRTableCell xrTableCell304 = XrTableCell228;
		location = new Point(616, 0);
		xrTableCell304.Location = location;
		XrTableCell228.Name = "XrTableCell228";
		XRTableCell xrTableCell305 = XrTableCell228;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell305.Padding = padding;
		XrTableCell228.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell306 = XrTableCell228;
		size = new Size(42, 25);
		xrTableCell306.Size = size;
		XrTableRow33.Cells.AddRange(new XRTableCell[3] { XrTableCell97, XrTableCell121, XrTableCell122 });
		XrTableRow33.Name = "XrTableRow33";
		XRTableRow xrTableRow28 = XrTableRow33;
		size = new Size(658, 25);
		xrTableRow28.Size = size;
		XrTableCell97.Borders = BorderSide.Left | BorderSide.Right;
		XRTableCell xrTableCell307 = XrTableCell97;
		location = new Point(0, 0);
		xrTableCell307.Location = location;
		XrTableCell97.Name = "XrTableCell97";
		XRTableCell xrTableCell308 = XrTableCell97;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell308.Padding = padding;
		XrTableCell97.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell309 = XrTableCell97;
		size = new Size(217, 25);
		xrTableCell309.Size = size;
		XrTableCell121.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell310 = XrTableCell121;
		location = new Point(217, 0);
		xrTableCell310.Location = location;
		XrTableCell121.Name = "XrTableCell121";
		XRTableCell xrTableCell311 = XrTableCell121;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell311.Padding = padding;
		XrTableCell121.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell312 = XrTableCell121;
		size = new Size(399, 25);
		xrTableCell312.Size = size;
		XrTableCell121.Text = "Solo cuando hay dificultades";
		XrTableCell122.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell122.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.com2", "")
		});
		XRTableCell xrTableCell313 = XrTableCell122;
		location = new Point(616, 0);
		xrTableCell313.Location = location;
		XrTableCell122.Name = "XrTableCell122";
		XRTableCell xrTableCell314 = XrTableCell122;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell314.Padding = padding;
		XrTableCell122.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell315 = XrTableCell122;
		size = new Size(42, 25);
		xrTableCell315.Size = size;
		XrTableRow23.Cells.AddRange(new XRTableCell[3] { XrTableCell89, XrTableCell90, XrTableCell91 });
		XrTableRow23.Name = "XrTableRow23";
		XRTableRow xrTableRow29 = XrTableRow23;
		size = new Size(658, 25);
		xrTableRow29.Size = size;
		XrTableCell89.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
		XrTableCell89.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell316 = XrTableCell89;
		location = new Point(0, 0);
		xrTableCell316.Location = location;
		XrTableCell89.Name = "XrTableCell89";
		XRTableCell xrTableCell317 = XrTableCell89;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell317.Padding = padding;
		XrTableCell89.ParentStyleUsing.UseBorders = false;
		XrTableCell89.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell318 = XrTableCell89;
		size = new Size(217, 25);
		xrTableCell318.Size = size;
		XrTableCell89.Text = "AFECTIVIDAD";
		XrTableCell89.TextAlignment = TextAlignment.TopCenter;
		XrTableCell90.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell319 = XrTableCell90;
		location = new Point(217, 0);
		xrTableCell319.Location = location;
		XrTableCell90.Name = "XrTableCell90";
		XRTableCell xrTableCell320 = XrTableCell90;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell320.Padding = padding;
		XrTableCell90.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell321 = XrTableCell90;
		size = new Size(399, 25);
		xrTableCell321.Size = size;
		XrTableCell90.Text = "Se brindan abrazos, besos, palabras cariñosas";
		XrTableCell91.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell91.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.afec1", "")
		});
		XRTableCell xrTableCell322 = XrTableCell91;
		location = new Point(616, 0);
		xrTableCell322.Location = location;
		XrTableCell91.Name = "XrTableCell91";
		XRTableCell xrTableCell323 = XrTableCell91;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell323.Padding = padding;
		XrTableCell91.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell324 = XrTableCell91;
		size = new Size(42, 25);
		xrTableCell324.Size = size;
		XrTableRow22.Cells.AddRange(new XRTableCell[3] { XrTableCell82, XrTableCell85, XrTableCell86 });
		XrTableRow22.Name = "XrTableRow22";
		XRTableRow xrTableRow30 = XrTableRow22;
		size = new Size(658, 25);
		xrTableRow30.Size = size;
		XrTableCell82.Borders = BorderSide.Left | BorderSide.Right;
		XRTableCell xrTableCell325 = XrTableCell82;
		location = new Point(0, 0);
		xrTableCell325.Location = location;
		XrTableCell82.Name = "XrTableCell82";
		XRTableCell xrTableCell326 = XrTableCell82;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell326.Padding = padding;
		XrTableCell82.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell327 = XrTableCell82;
		size = new Size(217, 25);
		xrTableCell327.Size = size;
		XrTableCell85.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell328 = XrTableCell85;
		location = new Point(217, 0);
		xrTableCell328.Location = location;
		XrTableCell85.Name = "XrTableCell85";
		XRTableCell xrTableCell329 = XrTableCell85;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell329.Padding = padding;
		XrTableCell85.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell330 = XrTableCell85;
		size = new Size(399, 25);
		xrTableCell330.Size = size;
		XrTableCell85.Text = "Se aceptan y toleran entre sí";
		XrTableCell86.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell86.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.afec2", "")
		});
		XRTableCell xrTableCell331 = XrTableCell86;
		location = new Point(616, 0);
		xrTableCell331.Location = location;
		XrTableCell86.Name = "XrTableCell86";
		XRTableCell xrTableCell332 = XrTableCell86;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell332.Padding = padding;
		XrTableCell86.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell333 = XrTableCell86;
		size = new Size(42, 25);
		xrTableCell333.Size = size;
		XrTableRow21.Cells.AddRange(new XRTableCell[3] { XrTableCell76, XrTableCell77, XrTableCell78 });
		XrTableRow21.Name = "XrTableRow21";
		XRTableRow xrTableRow31 = XrTableRow21;
		size = new Size(658, 25);
		xrTableRow31.Size = size;
		XrTableCell76.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
		XrTableCell76.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell334 = XrTableCell76;
		location = new Point(0, 0);
		xrTableCell334.Location = location;
		XrTableCell76.Name = "XrTableCell76";
		XRTableCell xrTableCell335 = XrTableCell76;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell335.Padding = padding;
		XrTableCell76.ParentStyleUsing.UseBorders = false;
		XrTableCell76.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell336 = XrTableCell76;
		size = new Size(217, 25);
		xrTableCell336.Size = size;
		XrTableCell76.Text = "TOMA DE DECISIONES";
		XrTableCell76.TextAlignment = TextAlignment.TopCenter;
		XrTableCell77.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell337 = XrTableCell77;
		location = new Point(217, 0);
		xrTableCell337.Location = location;
		XrTableCell77.Name = "XrTableCell77";
		XRTableCell xrTableCell338 = XrTableCell77;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell338.Padding = padding;
		XrTableCell77.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell339 = XrTableCell77;
		size = new Size(399, 25);
		xrTableCell339.Size = size;
		XrTableCell77.Text = "Ante un problema todos participan en la Solución";
		XrTableCell78.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell78.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.decis1", "")
		});
		XRTableCell xrTableCell340 = XrTableCell78;
		location = new Point(616, 0);
		xrTableCell340.Location = location;
		XrTableCell78.Name = "XrTableCell78";
		XRTableCell xrTableCell341 = XrTableCell78;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell341.Padding = padding;
		XrTableCell78.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell342 = XrTableCell78;
		size = new Size(42, 25);
		xrTableCell342.Size = size;
		XrTableRow20.Cells.AddRange(new XRTableCell[3] { XrTableCell69, XrTableCell70, XrTableCell72 });
		XrTableRow20.Name = "XrTableRow20";
		XRTableRow xrTableRow32 = XrTableRow20;
		size = new Size(658, 25);
		xrTableRow32.Size = size;
		XrTableCell69.Borders = BorderSide.Left | BorderSide.Right;
		XRTableCell xrTableCell343 = XrTableCell69;
		location = new Point(0, 0);
		xrTableCell343.Location = location;
		XrTableCell69.Name = "XrTableCell69";
		XRTableCell xrTableCell344 = XrTableCell69;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell344.Padding = padding;
		XrTableCell69.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell345 = XrTableCell69;
		size = new Size(217, 25);
		xrTableCell345.Size = size;
		XrTableCell70.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell346 = XrTableCell70;
		location = new Point(217, 0);
		xrTableCell346.Location = location;
		XrTableCell70.Name = "XrTableCell70";
		XRTableCell xrTableCell347 = XrTableCell70;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell347.Padding = padding;
		XrTableCell70.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell348 = XrTableCell70;
		size = new Size(399, 25);
		xrTableCell348.Size = size;
		XrTableCell70.Text = "Ante un problema solo los padres buscan la Solución";
		XrTableCell72.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell72.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.decis2", "")
		});
		XRTableCell xrTableCell349 = XrTableCell72;
		location = new Point(616, 0);
		xrTableCell349.Location = location;
		XrTableCell72.Name = "XrTableCell72";
		XRTableCell xrTableCell350 = XrTableCell72;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell350.Padding = padding;
		XrTableCell72.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell351 = XrTableCell72;
		size = new Size(42, 25);
		xrTableCell351.Size = size;
		XrTableRow16.Cells.AddRange(new XRTableCell[3] { XrTableCell51, XrTableCell58, XrTableCell59 });
		XrTableRow16.Name = "XrTableRow16";
		XRTableRow xrTableRow33 = XrTableRow16;
		size = new Size(658, 25);
		xrTableRow33.Size = size;
		XrTableCell51.Borders = BorderSide.Left | BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell352 = XrTableCell51;
		location = new Point(0, 0);
		xrTableCell352.Location = location;
		XrTableCell51.Name = "XrTableCell51";
		XRTableCell xrTableCell353 = XrTableCell51;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell353.Padding = padding;
		XrTableCell51.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell354 = XrTableCell51;
		size = new Size(217, 25);
		xrTableCell354.Size = size;
		XrTableCell58.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell355 = XrTableCell58;
		location = new Point(217, 0);
		xrTableCell355.Location = location;
		XrTableCell58.Name = "XrTableCell58";
		XRTableCell xrTableCell356 = XrTableCell58;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell356.Padding = padding;
		XrTableCell58.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell357 = XrTableCell58;
		size = new Size(399, 25);
		xrTableCell357.Size = size;
		XrTableCell58.Text = "Participan en Clubs, Juntas Vecinales y Otros.";
		XrTableCell59.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell59.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc1", "")
		});
		XRTableCell xrTableCell358 = XrTableCell59;
		location = new Point(616, 0);
		xrTableCell358.Location = location;
		XrTableCell59.Name = "XrTableCell59";
		XRTableCell xrTableCell359 = XrTableCell59;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell359.Padding = padding;
		XrTableCell59.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell360 = XrTableCell59;
		size = new Size(42, 25);
		xrTableCell360.Size = size;
		XrTableRow17.Cells.AddRange(new XRTableCell[3] { XrTableCell60, XrTableCell61, XrTableCell62 });
		XrTableRow17.Name = "XrTableRow17";
		XRTableRow xrTableRow34 = XrTableRow17;
		size = new Size(658, 25);
		xrTableRow34.Size = size;
		XrTableCell60.Borders = BorderSide.Left | BorderSide.Right;
		XrTableCell60.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell361 = XrTableCell60;
		location = new Point(0, 0);
		xrTableCell361.Location = location;
		XrTableCell60.Name = "XrTableCell60";
		XRTableCell xrTableCell362 = XrTableCell60;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell362.Padding = padding;
		XrTableCell60.ParentStyleUsing.UseBorders = false;
		XrTableCell60.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell363 = XrTableCell60;
		size = new Size(217, 25);
		xrTableCell363.Size = size;
		XrTableCell60.Text = "SOCIALIZACIÓN";
		XrTableCell60.TextAlignment = TextAlignment.TopCenter;
		XrTableCell61.Borders = BorderSide.Top | BorderSide.Right;
		XRTableCell xrTableCell364 = XrTableCell61;
		location = new Point(217, 0);
		xrTableCell364.Location = location;
		XrTableCell61.Name = "XrTableCell61";
		XRTableCell xrTableCell365 = XrTableCell61;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell365.Padding = padding;
		XrTableCell61.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell366 = XrTableCell61;
		size = new Size(399, 25);
		xrTableCell366.Size = size;
		XrTableCell61.Text = "Realizan sus Propias actividades familiares";
		XrTableCell62.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell62.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc2", "")
		});
		XRTableCell xrTableCell367 = XrTableCell62;
		location = new Point(616, 0);
		xrTableCell367.Location = location;
		XrTableCell62.Name = "XrTableCell62";
		XRTableCell xrTableCell368 = XrTableCell62;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell368.Padding = padding;
		XrTableCell62.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell369 = XrTableCell62;
		size = new Size(42, 25);
		xrTableCell369.Size = size;
		XrTableRow34.Cells.AddRange(new XRTableCell[3] { XrTableCell63, XrTableCell64, XrTableCell65 });
		XrTableRow34.Name = "XrTableRow34";
		XRTableRow xrTableRow35 = XrTableRow34;
		size = new Size(658, 25);
		xrTableRow35.Size = size;
		XrTableCell63.Borders = BorderSide.Left | BorderSide.Bottom;
		XRTableCell xrTableCell370 = XrTableCell63;
		location = new Point(0, 0);
		xrTableCell370.Location = location;
		XrTableCell63.Name = "XrTableCell63";
		XRTableCell xrTableCell371 = XrTableCell63;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell371.Padding = padding;
		XrTableCell63.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell372 = XrTableCell63;
		size = new Size(217, 25);
		xrTableCell372.Size = size;
		XrTableCell64.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		XRTableCell xrTableCell373 = XrTableCell64;
		location = new Point(217, 0);
		xrTableCell373.Location = location;
		XrTableCell64.Name = "XrTableCell64";
		XRTableCell xrTableCell374 = XrTableCell64;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell374.Padding = padding;
		XrTableCell64.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell375 = XrTableCell64;
		size = new Size(399, 25);
		xrTableCell375.Size = size;
		XrTableCell64.Text = "Buena relaciones con amigos y vecinos.";
		XrTableCell65.Borders = BorderSide.Right | BorderSide.Bottom;
		XrTableCell65.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc3", "")
		});
		XRTableCell xrTableCell376 = XrTableCell65;
		location = new Point(616, 0);
		xrTableCell376.Location = location;
		XrTableCell65.Name = "XrTableCell65";
		XRTableCell xrTableCell377 = XrTableCell65;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell377.Padding = padding;
		XrTableCell65.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell378 = XrTableCell65;
		size = new Size(42, 25);
		xrTableCell378.Size = size;
		XrLabel14.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel16 = XrLabel14;
		location = new Point(58, 8);
		xrLabel16.Location = location;
		XrLabel14.Name = "XrLabel14";
		XRLabel xrLabel17 = XrLabel14;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel17.Padding = padding;
		XrLabel14.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel18 = XrLabel14;
		size = new Size(167, 17);
		xrLabel18.Size = size;
		XrLabel14.Text = "4.2 Dinámica Familiar:";
		XrLabel8.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel19 = XrLabel8;
		location = new Point(58, 158);
		xrLabel19.Location = location;
		XrLabel8.Name = "XrLabel8";
		XRLabel xrLabel20 = XrLabel8;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel20.Padding = padding;
		XrLabel8.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel21 = XrLabel8;
		size = new Size(183, 17);
		xrLabel21.Size = size;
		XrLabel8.Text = "4.3 Funcionamiento Familiar:";
		XRTable xrTable17 = XrTable1;
		location = new Point(17, 42);
		xrTable17.Location = location;
		XrTable1.Name = "XrTable1";
		XrTable1.Rows.AddRange(new XRTableRow[4] { XrTableRow4, XrTableRow14, XrTableRow13, XrTableRow6 });
		XRTable xrTable18 = XrTable1;
		size = new Size(658, 100);
		xrTable18.Size = size;
		XrTableRow4.Cells.AddRange(new XRTableCell[2] { XrTableCell20, XrTableCell21 });
		XrTableRow4.Name = "XrTableRow4";
		XRTableRow xrTableRow36 = XrTableRow4;
		size = new Size(658, 25);
		xrTableRow36.Size = size;
		XrTableCell20.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell379 = XrTableCell20;
		location = new Point(0, 0);
		xrTableCell379.Location = location;
		XrTableCell20.Name = "XrTableCell20";
		XRTableCell xrTableCell380 = XrTableCell20;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell380.Padding = padding;
		XrTableCell20.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell381 = XrTableCell20;
		size = new Size(108, 25);
		xrTableCell381.Size = size;
		XrTableCell20.Text = "Tipo de Familia:";
		XrTableCell21.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.TipoFamDescrip", "")
		});
		XRTableCell xrTableCell382 = XrTableCell21;
		location = new Point(108, 0);
		xrTableCell382.Location = location;
		XrTableCell21.Name = "XrTableCell21";
		XRTableCell xrTableCell383 = XrTableCell21;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell383.Padding = padding;
		XRTableCell xrTableCell384 = XrTableCell21;
		size = new Size(550, 25);
		xrTableCell384.Size = size;
		XrTableRow14.Cells.AddRange(new XRTableCell[2] { XrTableCell53, XrTableCell54 });
		XrTableRow14.Name = "XrTableRow14";
		XRTableRow xrTableRow37 = XrTableRow14;
		size = new Size(658, 25);
		xrTableRow37.Size = size;
		XrTableCell53.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell385 = XrTableCell53;
		location = new Point(0, 0);
		xrTableCell385.Location = location;
		XrTableCell53.Name = "XrTableCell53";
		XRTableCell xrTableCell386 = XrTableCell53;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell386.Padding = padding;
		XrTableCell53.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell387 = XrTableCell53;
		size = new Size(125, 25);
		xrTableCell387.Size = size;
		XrTableCell53.Text = "Relación de Pareja:";
		XrTableCell54.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.relacParejaDescrip", "")
		});
		XRTableCell xrTableCell388 = XrTableCell54;
		location = new Point(125, 0);
		xrTableCell388.Location = location;
		XrTableCell54.Name = "XrTableCell54";
		XRTableCell xrTableCell389 = XrTableCell54;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell389.Padding = padding;
		XRTableCell xrTableCell390 = XrTableCell54;
		size = new Size(533, 25);
		xrTableCell390.Size = size;
		XrTableRow13.Cells.AddRange(new XRTableCell[2] { XrTableCell44, XrTableCell50 });
		XrTableRow13.Name = "XrTableRow13";
		XRTableRow xrTableRow38 = XrTableRow13;
		size = new Size(658, 25);
		xrTableRow38.Size = size;
		XrTableCell44.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell391 = XrTableCell44;
		location = new Point(0, 0);
		xrTableCell391.Location = location;
		XrTableCell44.Name = "XrTableCell44";
		XRTableCell xrTableCell392 = XrTableCell44;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell392.Padding = padding;
		XrTableCell44.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell393 = XrTableCell44;
		size = new Size(150, 25);
		xrTableCell393.Size = size;
		XrTableCell44.Text = "Relación Padres - Hijos:";
		XrTableCell50.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.RelacPHDescrip", "")
		});
		XRTableCell xrTableCell394 = XrTableCell50;
		location = new Point(150, 0);
		xrTableCell394.Location = location;
		XrTableCell50.Name = "XrTableCell50";
		XRTableCell xrTableCell395 = XrTableCell50;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell395.Padding = padding;
		XRTableCell xrTableCell396 = XrTableCell50;
		size = new Size(508, 25);
		xrTableCell396.Size = size;
		XrTableRow6.Cells.AddRange(new XRTableCell[2] { XrTableCell37, XrTableCell38 });
		XrTableRow6.Name = "XrTableRow6";
		XRTableRow xrTableRow39 = XrTableRow6;
		size = new Size(658, 25);
		xrTableRow39.Size = size;
		XrTableCell37.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell397 = XrTableCell37;
		location = new Point(0, 0);
		xrTableCell397.Location = location;
		XrTableCell37.Name = "XrTableCell37";
		XRTableCell xrTableCell398 = XrTableCell37;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell398.Padding = padding;
		XrTableCell37.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell399 = XrTableCell37;
		size = new Size(158, 25);
		xrTableCell399.Size = size;
		XrTableCell37.Text = "Relación entre Hermanos:";
		XrTableCell38.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.RelacHermanoDescrip", "")
		});
		XRTableCell xrTableCell400 = XrTableCell38;
		location = new Point(158, 0);
		xrTableCell400.Location = location;
		XrTableCell38.Name = "XrTableCell38";
		XRTableCell xrTableCell401 = XrTableCell38;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell401.Padding = padding;
		XRTableCell xrTableCell402 = XrTableCell38;
		size = new Size(500, 25);
		xrTableCell402.Size = size;
		DetailReport2.Bands.AddRange(new Band[2] { Detail3, GroupHeader3 });
		DetailReport2.DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DetailReport2.DataMember = "spRRHH_Ficha_Ingreso_Egreso";
		DetailReport2.DataSource = DataSet11;
		DetailReport2.Level = 5;
		DetailReport2.Name = "DetailReport2";
		Detail3.Height = 0;
		Detail3.Name = "Detail3";
		GroupHeader3.Controls.AddRange(new XRControl[9] { XrTable8, XrLabel13, XrLabel12, XrLabel11, XrLabel10, XrLabel9, XrLabel2, XrTable10, XrLabel1 });
		GroupHeader3.Height = 552;
		GroupHeader3.Name = "GroupHeader3";
		XRTable xrTable19 = XrTable8;
		location = new Point(25, 200);
		xrTable19.Location = location;
		XrTable8.Name = "XrTable8";
		XrTable8.Rows.AddRange(new XRTableRow[9] { XrTableRow78, XrTableRow79, XrTableRow80, XrTableRow81, XrTableRow82, XrTableRow83, XrTableRow84, XrTableRow85, XrTableRow87 });
		XRTable xrTable20 = XrTable8;
		size = new Size(533, 225);
		xrTable20.Size = size;
		XrTableRow78.Cells.AddRange(new XRTableCell[1] { XrTableCell127 });
		XrTableRow78.Name = "XrTableRow78";
		XRTableRow xrTableRow40 = XrTableRow78;
		size = new Size(533, 25);
		xrTableRow40.Size = size;
		XrTableCell127.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell403 = XrTableCell127;
		location = new Point(0, 0);
		xrTableCell403.Location = location;
		XrTableCell127.Name = "XrTableCell127";
		XRTableCell xrTableCell404 = XrTableCell127;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell404.Padding = padding;
		XrTableCell127.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell405 = XrTableCell127;
		size = new Size(533, 25);
		xrTableCell405.Size = size;
		XrTableCell127.Text = "Egresos";
		XrTableCell127.TextAlignment = TextAlignment.TopCenter;
		XrTableRow79.Cells.AddRange(new XRTableCell[4] { XrTableCell229, XrTableCell230, XrTableCell154, XrTableCell136 });
		XrTableRow79.Name = "XrTableRow79";
		XRTableRow xrTableRow41 = XrTableRow79;
		size = new Size(533, 25);
		xrTableRow41.Size = size;
		XRTableCell xrTableCell406 = XrTableCell229;
		location = new Point(0, 0);
		xrTableCell406.Location = location;
		XrTableCell229.Name = "XrTableCell229";
		XRTableCell xrTableCell407 = XrTableCell229;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell407.Padding = padding;
		XRTableCell xrTableCell408 = XrTableCell229;
		size = new Size(130, 25);
		xrTableCell408.Size = size;
		XrTableCell229.Text = "Alimentación:";
		XrTableCell230.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.Alimentacion", "")
		});
		XRTableCell xrTableCell409 = XrTableCell230;
		location = new Point(130, 0);
		xrTableCell409.Location = location;
		XrTableCell230.Name = "XrTableCell230";
		XRTableCell xrTableCell410 = XrTableCell230;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell410.Padding = padding;
		XRTableCell xrTableCell411 = XrTableCell230;
		size = new Size(138, 25);
		xrTableCell411.Size = size;
		XrTableCell230.Text = "XrTableCell147";
		XRTableCell xrTableCell412 = XrTableCell154;
		location = new Point(268, 0);
		xrTableCell412.Location = location;
		XrTableCell154.Name = "XrTableCell154";
		XRTableCell xrTableCell413 = XrTableCell154;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell413.Padding = padding;
		XRTableCell xrTableCell414 = XrTableCell154;
		size = new Size(85, 25);
		xrTableCell414.Size = size;
		XrTableCell154.Text = "Transporte:";
		XrTableCell136.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.transporte", "")
		});
		XRTableCell xrTableCell415 = XrTableCell136;
		location = new Point(353, 0);
		xrTableCell415.Location = location;
		XrTableCell136.Name = "XrTableCell136";
		XRTableCell xrTableCell416 = XrTableCell136;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell416.Padding = padding;
		XRTableCell xrTableCell417 = XrTableCell136;
		size = new Size(180, 25);
		xrTableCell417.Size = size;
		XrTableRow80.Cells.AddRange(new XRTableCell[4] { XrTableCell233, XrTableCell234, XrTableCell155, XrTableCell139 });
		XrTableRow80.Name = "XrTableRow80";
		XRTableRow xrTableRow42 = XrTableRow80;
		size = new Size(533, 25);
		xrTableRow42.Size = size;
		XRTableCell xrTableCell418 = XrTableCell233;
		location = new Point(0, 0);
		xrTableCell418.Location = location;
		XrTableCell233.Name = "XrTableCell233";
		XRTableCell xrTableCell419 = XrTableCell233;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell419.Padding = padding;
		XRTableCell xrTableCell420 = XrTableCell233;
		size = new Size(130, 25);
		xrTableCell420.Size = size;
		XrTableCell233.Text = "Vivienda:";
		XrTableCell234.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.vivienda", "")
		});
		XRTableCell xrTableCell421 = XrTableCell234;
		location = new Point(130, 0);
		xrTableCell421.Location = location;
		XrTableCell234.Name = "XrTableCell234";
		XRTableCell xrTableCell422 = XrTableCell234;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell422.Padding = padding;
		XRTableCell xrTableCell423 = XrTableCell234;
		size = new Size(138, 25);
		xrTableCell423.Size = size;
		XrTableCell234.Text = "XrTableCell151";
		XRTableCell xrTableCell424 = XrTableCell155;
		location = new Point(268, 0);
		xrTableCell424.Location = location;
		XrTableCell155.Name = "XrTableCell155";
		XRTableCell xrTableCell425 = XrTableCell155;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell425.Padding = padding;
		XRTableCell xrTableCell426 = XrTableCell155;
		size = new Size(85, 25);
		xrTableCell426.Size = size;
		XrTableCell155.Text = "Energía Eléctrica:";
		XrTableCell139.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.energiaelec", "")
		});
		XRTableCell xrTableCell427 = XrTableCell139;
		location = new Point(353, 0);
		xrTableCell427.Location = location;
		XrTableCell139.Name = "XrTableCell139";
		XRTableCell xrTableCell428 = XrTableCell139;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell428.Padding = padding;
		XRTableCell xrTableCell429 = XrTableCell139;
		size = new Size(180, 25);
		xrTableCell429.Size = size;
		XrTableRow81.Cells.AddRange(new XRTableCell[4] { XrTableCell237, XrTableCell238, XrTableCell156, XrTableCell142 });
		XrTableRow81.Name = "XrTableRow81";
		XRTableRow xrTableRow43 = XrTableRow81;
		size = new Size(533, 25);
		xrTableRow43.Size = size;
		XRTableCell xrTableCell430 = XrTableCell237;
		location = new Point(0, 0);
		xrTableCell430.Location = location;
		XrTableCell237.Name = "XrTableCell237";
		XRTableCell xrTableCell431 = XrTableCell237;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell431.Padding = padding;
		XRTableCell xrTableCell432 = XrTableCell237;
		size = new Size(130, 25);
		xrTableCell432.Size = size;
		XrTableCell237.Text = "Educación:";
		XrTableCell238.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.educacion", "")
		});
		XRTableCell xrTableCell433 = XrTableCell238;
		location = new Point(130, 0);
		xrTableCell433.Location = location;
		XrTableCell238.Name = "XrTableCell238";
		XRTableCell xrTableCell434 = XrTableCell238;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell434.Padding = padding;
		XRTableCell xrTableCell435 = XrTableCell238;
		size = new Size(138, 25);
		xrTableCell435.Size = size;
		XrTableCell238.Text = "XrTableCell155";
		XRTableCell xrTableCell436 = XrTableCell156;
		location = new Point(268, 0);
		xrTableCell436.Location = location;
		XrTableCell156.Name = "XrTableCell156";
		XRTableCell xrTableCell437 = XrTableCell156;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell437.Padding = padding;
		XRTableCell xrTableCell438 = XrTableCell156;
		size = new Size(85, 25);
		xrTableCell438.Size = size;
		XrTableCell156.Text = "Agua:";
		XrTableCell142.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.agua", "")
		});
		XRTableCell xrTableCell439 = XrTableCell142;
		location = new Point(353, 0);
		xrTableCell439.Location = location;
		XrTableCell142.Name = "XrTableCell142";
		XRTableCell xrTableCell440 = XrTableCell142;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell440.Padding = padding;
		XRTableCell xrTableCell441 = XrTableCell142;
		size = new Size(180, 25);
		xrTableCell441.Size = size;
		XrTableRow82.Cells.AddRange(new XRTableCell[4] { XrTableCell241, XrTableCell242, XrTableCell157, XrTableCell147 });
		XrTableRow82.Name = "XrTableRow82";
		XRTableRow xrTableRow44 = XrTableRow82;
		size = new Size(533, 25);
		xrTableRow44.Size = size;
		XRTableCell xrTableCell442 = XrTableCell241;
		location = new Point(0, 0);
		xrTableCell442.Location = location;
		XrTableCell241.Name = "XrTableCell241";
		XRTableCell xrTableCell443 = XrTableCell241;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell443.Padding = padding;
		XRTableCell xrTableCell444 = XrTableCell241;
		size = new Size(130, 25);
		xrTableCell444.Size = size;
		XrTableCell241.Text = "Salud:";
		XrTableCell242.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.salud", "")
		});
		XRTableCell xrTableCell445 = XrTableCell242;
		location = new Point(130, 0);
		xrTableCell445.Location = location;
		XrTableCell242.Name = "XrTableCell242";
		XRTableCell xrTableCell446 = XrTableCell242;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell446.Padding = padding;
		XRTableCell xrTableCell447 = XrTableCell242;
		size = new Size(138, 25);
		xrTableCell447.Size = size;
		XrTableCell242.Text = "XrTableCell159";
		XRTableCell xrTableCell448 = XrTableCell157;
		location = new Point(268, 0);
		xrTableCell448.Location = location;
		XrTableCell157.Name = "XrTableCell157";
		XRTableCell xrTableCell449 = XrTableCell157;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell449.Padding = padding;
		XRTableCell xrTableCell450 = XrTableCell157;
		size = new Size(85, 25);
		xrTableCell450.Size = size;
		XrTableCell157.Text = "Baja Policía:";
		XrTableCell147.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.bajapolicia", "")
		});
		XRTableCell xrTableCell451 = XrTableCell147;
		location = new Point(353, 0);
		xrTableCell451.Location = location;
		XrTableCell147.Name = "XrTableCell147";
		XRTableCell xrTableCell452 = XrTableCell147;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell452.Padding = padding;
		XRTableCell xrTableCell453 = XrTableCell147;
		size = new Size(180, 25);
		xrTableCell453.Size = size;
		XrTableRow83.Cells.AddRange(new XRTableCell[4] { XrTableCell245, XrTableCell246, XrTableCell158, XrTableCell148 });
		XrTableRow83.Name = "XrTableRow83";
		XRTableRow xrTableRow45 = XrTableRow83;
		size = new Size(533, 25);
		xrTableRow45.Size = size;
		XRTableCell xrTableCell454 = XrTableCell245;
		location = new Point(0, 0);
		xrTableCell454.Location = location;
		XrTableCell245.Name = "XrTableCell245";
		XRTableCell xrTableCell455 = XrTableCell245;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell455.Padding = padding;
		XRTableCell xrTableCell456 = XrTableCell245;
		size = new Size(130, 25);
		xrTableCell456.Size = size;
		XrTableCell245.Text = "Vestido:";
		XrTableCell246.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.vestido", "")
		});
		XRTableCell xrTableCell457 = XrTableCell246;
		location = new Point(130, 0);
		xrTableCell457.Location = location;
		XrTableCell246.Name = "XrTableCell246";
		XRTableCell xrTableCell458 = XrTableCell246;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell458.Padding = padding;
		XRTableCell xrTableCell459 = XrTableCell246;
		size = new Size(138, 25);
		xrTableCell459.Size = size;
		XrTableCell246.Text = "XrTableCell170";
		XRTableCell xrTableCell460 = XrTableCell158;
		location = new Point(268, 0);
		xrTableCell460.Location = location;
		XrTableCell158.Name = "XrTableCell158";
		XRTableCell xrTableCell461 = XrTableCell158;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell461.Padding = padding;
		XRTableCell xrTableCell462 = XrTableCell158;
		size = new Size(85, 25);
		xrTableCell462.Size = size;
		XrTableCell158.Text = "Teléfono:";
		XrTableCell148.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.telefono", "")
		});
		XRTableCell xrTableCell463 = XrTableCell148;
		location = new Point(353, 0);
		xrTableCell463.Location = location;
		XrTableCell148.Name = "XrTableCell148";
		XRTableCell xrTableCell464 = XrTableCell148;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell464.Padding = padding;
		XRTableCell xrTableCell465 = XrTableCell148;
		size = new Size(180, 25);
		xrTableCell465.Size = size;
		XrTableRow84.Cells.AddRange(new XRTableCell[4] { XrTableCell249, XrTableCell250, XrTableCell159, XrTableCell149 });
		XrTableRow84.Name = "XrTableRow84";
		XRTableRow xrTableRow46 = XrTableRow84;
		size = new Size(533, 25);
		xrTableRow46.Size = size;
		XRTableCell xrTableCell466 = XrTableCell249;
		location = new Point(0, 0);
		xrTableCell466.Location = location;
		XrTableCell249.Name = "XrTableCell249";
		XRTableCell xrTableCell467 = XrTableCell249;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell467.Padding = padding;
		XRTableCell xrTableCell468 = XrTableCell249;
		size = new Size(130, 25);
		xrTableCell468.Size = size;
		XrTableCell249.Text = "Recreación:";
		XrTableCell250.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.recreacion", "")
		});
		XRTableCell xrTableCell469 = XrTableCell250;
		location = new Point(130, 0);
		xrTableCell469.Location = location;
		XrTableCell250.Name = "XrTableCell250";
		XRTableCell xrTableCell470 = XrTableCell250;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell470.Padding = padding;
		XRTableCell xrTableCell471 = XrTableCell250;
		size = new Size(138, 25);
		xrTableCell471.Size = size;
		XrTableCell250.Text = "XrTableCell174";
		XRTableCell xrTableCell472 = XrTableCell159;
		location = new Point(268, 0);
		xrTableCell472.Location = location;
		XrTableCell159.Name = "XrTableCell159";
		XRTableCell xrTableCell473 = XrTableCell159;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell473.Padding = padding;
		XRTableCell xrTableCell474 = XrTableCell159;
		size = new Size(85, 25);
		xrTableCell474.Size = size;
		XrTableCell159.Text = "Seguro Privado:";
		XrTableCell149.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.seguropriv", "")
		});
		XRTableCell xrTableCell475 = XrTableCell149;
		location = new Point(353, 0);
		xrTableCell475.Location = location;
		XrTableCell149.Name = "XrTableCell149";
		XRTableCell xrTableCell476 = XrTableCell149;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell476.Padding = padding;
		XRTableCell xrTableCell477 = XrTableCell149;
		size = new Size(180, 25);
		xrTableCell477.Size = size;
		XrTableRow85.Cells.AddRange(new XRTableCell[4] { XrTableCell253, XrTableCell254, XrTableCell160, XrTableCell150 });
		XrTableRow85.Name = "XrTableRow85";
		XRTableRow xrTableRow47 = XrTableRow85;
		size = new Size(533, 25);
		xrTableRow47.Size = size;
		XRTableCell xrTableCell478 = XrTableCell253;
		location = new Point(0, 0);
		xrTableCell478.Location = location;
		XrTableCell253.Name = "XrTableCell253";
		XRTableCell xrTableCell479 = XrTableCell253;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell479.Padding = padding;
		XRTableCell xrTableCell480 = XrTableCell253;
		size = new Size(130, 25);
		xrTableCell480.Size = size;
		XrTableCell253.Text = "Tarjetas de Crédito:";
		XrTableCell254.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.prestamos", "")
		});
		XRTableCell xrTableCell481 = XrTableCell254;
		location = new Point(130, 0);
		xrTableCell481.Location = location;
		XrTableCell254.Name = "XrTableCell254";
		XRTableCell xrTableCell482 = XrTableCell254;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell482.Padding = padding;
		XRTableCell xrTableCell483 = XrTableCell254;
		size = new Size(138, 25);
		xrTableCell483.Size = size;
		XrTableCell254.Text = "XrTableCell178";
		XRTableCell xrTableCell484 = XrTableCell160;
		location = new Point(268, 0);
		xrTableCell484.Location = location;
		XrTableCell160.Name = "XrTableCell160";
		XRTableCell xrTableCell485 = XrTableCell160;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell485.Padding = padding;
		XRTableCell xrTableCell486 = XrTableCell160;
		size = new Size(85, 25);
		xrTableCell486.Size = size;
		XrTableCell160.Text = "Otros gastos personales:";
		XrTableCell150.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.OtrosEgresos", "")
		});
		XRTableCell xrTableCell487 = XrTableCell150;
		location = new Point(353, 0);
		xrTableCell487.Location = location;
		XrTableCell150.Name = "XrTableCell150";
		XRTableCell xrTableCell488 = XrTableCell150;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell488.Padding = padding;
		XRTableCell xrTableCell489 = XrTableCell150;
		size = new Size(180, 25);
		xrTableCell489.Size = size;
		XrTableCell150.Text = "XrTableCell150";
		XrTableRow87.Cells.AddRange(new XRTableCell[2] { XrTableCell261, XrTableCell262 });
		XrTableRow87.Name = "XrTableRow87";
		XRTableRow xrTableRow48 = XrTableRow87;
		size = new Size(533, 25);
		xrTableRow48.Size = size;
		XrTableCell261.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell490 = XrTableCell261;
		location = new Point(0, 0);
		xrTableCell490.Location = location;
		XrTableCell261.Name = "XrTableCell261";
		XRTableCell xrTableCell491 = XrTableCell261;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell491.Padding = padding;
		XrTableCell261.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell492 = XrTableCell261;
		size = new Size(267, 25);
		xrTableCell492.Size = size;
		XrTableCell261.Text = "Total de Egresos:";
		XrTableCell262.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.TotalEgreso", "")
		});
		XRTableCell xrTableCell493 = XrTableCell262;
		location = new Point(267, 0);
		xrTableCell493.Location = location;
		XrTableCell262.Name = "XrTableCell262";
		XRTableCell xrTableCell494 = XrTableCell262;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell494.Padding = padding;
		XRTableCell xrTableCell495 = XrTableCell262;
		size = new Size(266, 25);
		xrTableCell495.Size = size;
		XrTableCell262.Text = "XrTableCell186";
		XrLabel13.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.NumPersonaAportan", "")
		});
		XRLabel xrLabel22 = XrLabel13;
		location = new Point(542, 508);
		xrLabel22.Location = location;
		XrLabel13.Name = "XrLabel13";
		XRLabel xrLabel23 = XrLabel13;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel23.Padding = padding;
		XRLabel xrLabel24 = XrLabel13;
		size = new Size(100, 25);
		xrLabel24.Size = size;
		XrLabel13.Text = "XrLabel13";
		XRLabel xrLabel25 = XrLabel12;
		location = new Point(42, 508);
		xrLabel25.Location = location;
		XrLabel12.Name = "XrLabel12";
		XRLabel xrLabel26 = XrLabel12;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel26.Padding = padding;
		XRLabel xrLabel27 = XrLabel12;
		size = new Size(458, 25);
		xrLabel27.Size = size;
		XrLabel12.Text = "Nº de personas que aportan económicamente en la manutención de la familia:  Nº";
		XrLabel11.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.IngresoMiembros", "")
		});
		XRLabel xrLabel28 = XrLabel11;
		location = new Point(458, 475);
		xrLabel28.Location = location;
		XrLabel11.Name = "XrLabel11";
		XRLabel xrLabel29 = XrLabel11;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel29.Padding = padding;
		XRLabel xrLabel30 = XrLabel11;
		size = new Size(100, 25);
		xrLabel30.Size = size;
		XrLabel11.Text = "XrLabel11";
		XRLabel xrLabel31 = XrLabel10;
		location = new Point(42, 475);
		xrLabel31.Location = location;
		XrLabel10.Name = "XrLabel10";
		XRLabel xrLabel32 = XrLabel10;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel32.Padding = padding;
		XRLabel xrLabel33 = XrLabel10;
		size = new Size(383, 25);
		xrLabel33.Size = size;
		XrLabel10.Text = "Monto de ingresos generados por otros miembros de la familia:  S/.";
		XrLabel9.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel34 = XrLabel9;
		location = new Point(25, 442);
		xrLabel34.Location = location;
		XrLabel9.Name = "XrLabel9";
		XRLabel xrLabel35 = XrLabel9;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel35.Padding = padding;
		XrLabel9.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel36 = XrLabel9;
		size = new Size(192, 25);
		xrLabel36.Size = size;
		XrLabel9.Text = "5.2 Ingresos de la familia";
		XrLabel2.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel37 = XrLabel2;
		location = new Point(25, 58);
		xrLabel37.Location = location;
		XrLabel2.Name = "XrLabel2";
		XRLabel xrLabel38 = XrLabel2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel38.Padding = padding;
		XrLabel2.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel39 = XrLabel2;
		size = new Size(275, 25);
		xrLabel39.Size = size;
		XrLabel2.Text = "5.1  Ingresos y egresos del trabjador:";
		XRTable xrTable21 = XrTable10;
		location = new Point(25, 92);
		xrTable21.Location = location;
		XrTable10.Name = "XrTable10";
		XrTable10.Rows.AddRange(new XRTableRow[4] { XrTableRow37, XrTableRow38, XrTableRow47, XrTableRow48 });
		XRTable xrTable22 = XrTable10;
		size = new Size(333, 100);
		xrTable22.Size = size;
		XrTableRow37.Cells.AddRange(new XRTableCell[1] { XrTableCell126 });
		XrTableRow37.Name = "XrTableRow37";
		XRTableRow xrTableRow49 = XrTableRow37;
		size = new Size(333, 25);
		xrTableRow49.Size = size;
		XrTableCell126.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell496 = XrTableCell126;
		location = new Point(0, 0);
		xrTableCell496.Location = location;
		XrTableCell126.Name = "XrTableCell126";
		XRTableCell xrTableCell497 = XrTableCell126;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell497.Padding = padding;
		XrTableCell126.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell498 = XrTableCell126;
		size = new Size(333, 25);
		xrTableCell498.Size = size;
		XrTableCell126.Text = "Ingresos";
		XrTableCell126.TextAlignment = TextAlignment.TopCenter;
		XrTableRow38.Cells.AddRange(new XRTableCell[2] { XrTableCell140, XrTableCell141 });
		XrTableRow38.Name = "XrTableRow38";
		XRTableRow xrTableRow50 = XrTableRow38;
		size = new Size(333, 25);
		xrTableRow50.Size = size;
		XRTableCell xrTableCell499 = XrTableCell140;
		location = new Point(0, 0);
		xrTableCell499.Location = location;
		XrTableCell140.Name = "XrTableCell140";
		XRTableCell xrTableCell500 = XrTableCell140;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell500.Padding = padding;
		XRTableCell xrTableCell501 = XrTableCell140;
		size = new Size(166, 25);
		xrTableCell501.Size = size;
		XrTableCell140.Text = "Remuneración:";
		XrTableCell141.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.Remuneracion", "")
		});
		XRTableCell xrTableCell502 = XrTableCell141;
		location = new Point(166, 0);
		xrTableCell502.Location = location;
		XrTableCell141.Name = "XrTableCell141";
		XRTableCell xrTableCell503 = XrTableCell141;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell503.Padding = padding;
		XRTableCell xrTableCell504 = XrTableCell141;
		size = new Size(167, 25);
		xrTableCell504.Size = size;
		XrTableCell141.Text = "XrTableCell141";
		XrTableRow47.Cells.AddRange(new XRTableCell[2] { XrTableCell179, XrTableCell180 });
		XrTableRow47.Name = "XrTableRow47";
		XRTableRow xrTableRow51 = XrTableRow47;
		size = new Size(333, 25);
		xrTableRow51.Size = size;
		XRTableCell xrTableCell505 = XrTableCell179;
		location = new Point(0, 0);
		xrTableCell505.Location = location;
		XrTableCell179.Name = "XrTableCell179";
		XRTableCell xrTableCell506 = XrTableCell179;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell506.Padding = padding;
		XRTableCell xrTableCell507 = XrTableCell179;
		size = new Size(166, 25);
		xrTableCell507.Size = size;
		XrTableCell179.Text = "Otros Ingresos";
		XrTableCell180.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.OtrosIngresos", "")
		});
		XRTableCell xrTableCell508 = XrTableCell180;
		location = new Point(166, 0);
		xrTableCell508.Location = location;
		XrTableCell180.Name = "XrTableCell180";
		XRTableCell xrTableCell509 = XrTableCell180;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell509.Padding = padding;
		XRTableCell xrTableCell510 = XrTableCell180;
		size = new Size(167, 25);
		xrTableCell510.Size = size;
		XrTableCell180.Text = "XrTableCell180";
		XrTableRow48.Cells.AddRange(new XRTableCell[2] { XrTableCell183, XrTableCell184 });
		XrTableRow48.Name = "XrTableRow48";
		XRTableRow xrTableRow52 = XrTableRow48;
		size = new Size(333, 25);
		xrTableRow52.Size = size;
		XrTableCell183.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell511 = XrTableCell183;
		location = new Point(0, 0);
		xrTableCell511.Location = location;
		XrTableCell183.Name = "XrTableCell183";
		XRTableCell xrTableCell512 = XrTableCell183;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell512.Padding = padding;
		XrTableCell183.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell513 = XrTableCell183;
		size = new Size(166, 25);
		xrTableCell513.Size = size;
		XrTableCell183.Text = "Total de Ingresos:";
		XrTableCell184.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Ingreso_Egreso.TotalIngreso", "")
		});
		XRTableCell xrTableCell514 = XrTableCell184;
		location = new Point(166, 0);
		xrTableCell514.Location = location;
		XrTableCell184.Name = "XrTableCell184";
		XRTableCell xrTableCell515 = XrTableCell184;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell515.Padding = padding;
		XRTableCell xrTableCell516 = XrTableCell184;
		size = new Size(167, 25);
		xrTableCell516.Size = size;
		XrTableCell184.Text = "XrTableCell184";
		XrLabel1.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel40 = XrLabel1;
		location = new Point(25, 17);
		xrLabel40.Location = location;
		XrLabel1.Name = "XrLabel1";
		XRLabel xrLabel41 = XrLabel1;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel41.Padding = padding;
		XrLabel1.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel42 = XrLabel1;
		size = new Size(308, 17);
		xrLabel42.Size = size;
		XrLabel1.Text = "VII. ASPECTO ECONÓMICO";
		DetailReport3.Bands.AddRange(new Band[2] { Detail4, GroupHeader4 });
		DetailReport3.DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DetailReport3.DataMember = "spRRHH_Ficha_Vivienda";
		DetailReport3.DataSource = DataSet11;
		DetailReport3.Level = 3;
		DetailReport3.Name = "DetailReport3";
		DetailReport3.ParentStyleUsing.UseFont = false;
		Detail4.Height = 0;
		Detail4.Name = "Detail4";
		GroupHeader4.Controls.AddRange(new XRControl[5] { XrTable21, XrTable14, XrTable15, XrTable11, XrLabel15 });
		GroupHeader4.Height = 540;
		GroupHeader4.Name = "GroupHeader4";
		XrTable21.Borders = BorderSide.All;
		XRTable xrTable23 = XrTable21;
		location = new Point(25, 492);
		xrTable23.Location = location;
		XrTable21.Name = "XrTable21";
		XrTable21.ParentStyleUsing.UseBorders = false;
		XrTable21.Rows.AddRange(new XRTableRow[1] { XrTableRow58 });
		XRTable xrTable24 = XrTable21;
		size = new Size(575, 25);
		xrTable24.Size = size;
		XrTableRow58.Cells.AddRange(new XRTableCell[2] { XrTableCell240, XrTableCell257 });
		XrTableRow58.Name = "XrTableRow58";
		XRTableRow xrTableRow53 = XrTableRow58;
		size = new Size(575, 25);
		xrTableRow53.Size = size;
		XrTableCell240.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell517 = XrTableCell240;
		location = new Point(0, 0);
		xrTableCell517.Location = location;
		XrTableCell240.Name = "XrTableCell240";
		XRTableCell xrTableCell518 = XrTableCell240;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell518.Padding = padding;
		XrTableCell240.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell519 = XrTableCell240;
		size = new Size(100, 25);
		xrTableCell519.Size = size;
		XrTableCell240.Text = "Observaciones:";
		XrTableCell257.Borders = BorderSide.Top | BorderSide.Right | BorderSide.Bottom;
		XrTableCell257.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.observacion", "")
		});
		XRTableCell xrTableCell520 = XrTableCell257;
		location = new Point(100, 0);
		xrTableCell520.Location = location;
		XrTableCell257.Name = "XrTableCell257";
		XRTableCell xrTableCell521 = XrTableCell257;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell521.Padding = padding;
		XrTableCell257.ParentStyleUsing.UseBorders = false;
		XRTableCell xrTableCell522 = XrTableCell257;
		size = new Size(475, 25);
		xrTableCell522.Size = size;
		XrTableCell257.Text = "XrTableCell257";
		XRTable xrTable25 = XrTable14;
		location = new Point(25, 183);
		xrTable25.Location = location;
		XrTable14.Name = "XrTable14";
		XrTable14.Rows.AddRange(new XRTableRow[8] { XrTableRow53, XrTableRow54, XrTableRow55, XrTableRow56, XrTableRow86, XrTableRow89, XrTableRow88, XrTableRow90 });
		XRTable xrTable26 = XrTable14;
		size = new Size(575, 200);
		xrTable26.Size = size;
		XrTableRow53.Cells.AddRange(new XRTableCell[2] { XrTableCell195, XrTableCell196 });
		XrTableRow53.Name = "XrTableRow53";
		XRTableRow xrTableRow54 = XrTableRow53;
		size = new Size(575, 25);
		xrTableRow54.Size = size;
		XrTableCell195.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell523 = XrTableCell195;
		location = new Point(0, 0);
		xrTableCell523.Location = location;
		XrTableCell195.Name = "XrTableCell195";
		XRTableCell xrTableCell524 = XrTableCell195;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell524.Padding = padding;
		XrTableCell195.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell525 = XrTableCell195;
		size = new Size(190, 25);
		xrTableCell525.Size = size;
		XrTableCell195.Text = "Ubicacion:";
		XrTableCell196.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripUbicacion", "")
		});
		XRTableCell xrTableCell526 = XrTableCell196;
		location = new Point(190, 0);
		xrTableCell526.Location = location;
		XrTableCell196.Name = "XrTableCell196";
		XRTableCell xrTableCell527 = XrTableCell196;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell527.Padding = padding;
		XRTableCell xrTableCell528 = XrTableCell196;
		size = new Size(385, 25);
		xrTableCell528.Size = size;
		XrTableCell196.Text = "XrTableCell196";
		XrTableRow54.Cells.AddRange(new XRTableCell[2] { XrTableCell197, XrTableCell198 });
		XrTableRow54.Name = "XrTableRow54";
		XRTableRow xrTableRow55 = XrTableRow54;
		size = new Size(575, 25);
		xrTableRow55.Size = size;
		XrTableCell197.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell529 = XrTableCell197;
		location = new Point(0, 0);
		xrTableCell529.Location = location;
		XrTableCell197.Name = "XrTableCell197";
		XRTableCell xrTableCell530 = XrTableCell197;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell530.Padding = padding;
		XrTableCell197.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell531 = XrTableCell197;
		size = new Size(190, 25);
		xrTableCell531.Size = size;
		XrTableCell197.Text = "Alumbrado:";
		XrTableCell198.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripAlumbrado", "")
		});
		XRTableCell xrTableCell532 = XrTableCell198;
		location = new Point(190, 0);
		xrTableCell532.Location = location;
		XrTableCell198.Name = "XrTableCell198";
		XRTableCell xrTableCell533 = XrTableCell198;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell533.Padding = padding;
		XRTableCell xrTableCell534 = XrTableCell198;
		size = new Size(385, 25);
		xrTableCell534.Size = size;
		XrTableCell198.Text = "XrTableCell198";
		XrTableRow55.Cells.AddRange(new XRTableCell[2] { XrTableCell199, XrTableCell200 });
		XrTableRow55.Name = "XrTableRow55";
		XRTableRow xrTableRow56 = XrTableRow55;
		size = new Size(575, 25);
		xrTableRow56.Size = size;
		XrTableCell199.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell535 = XrTableCell199;
		location = new Point(0, 0);
		xrTableCell535.Location = location;
		XrTableCell199.Name = "XrTableCell199";
		XRTableCell xrTableCell536 = XrTableCell199;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell536.Padding = padding;
		XrTableCell199.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell537 = XrTableCell199;
		size = new Size(190, 25);
		xrTableCell537.Size = size;
		XrTableCell199.Text = "Abastecimiento de Agua:";
		XrTableCell200.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.descripAgua", "")
		});
		XRTableCell xrTableCell538 = XrTableCell200;
		location = new Point(190, 0);
		xrTableCell538.Location = location;
		XrTableCell200.Name = "XrTableCell200";
		XRTableCell xrTableCell539 = XrTableCell200;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell539.Padding = padding;
		XRTableCell xrTableCell540 = XrTableCell200;
		size = new Size(385, 25);
		xrTableCell540.Size = size;
		XrTableCell200.Text = "XrTableCell200";
		XrTableRow56.Cells.AddRange(new XRTableCell[2] { XrTableCell201, XrTableCell202 });
		XrTableRow56.Name = "XrTableRow56";
		XRTableRow xrTableRow57 = XrTableRow56;
		size = new Size(575, 25);
		xrTableRow57.Size = size;
		XrTableCell201.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell541 = XrTableCell201;
		location = new Point(0, 0);
		xrTableCell541.Location = location;
		XrTableCell201.Name = "XrTableCell201";
		XRTableCell xrTableCell542 = XrTableCell201;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell542.Padding = padding;
		XrTableCell201.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell543 = XrTableCell201;
		size = new Size(190, 25);
		xrTableCell543.Size = size;
		XrTableCell201.Text = "Eliminacion de Excretas:";
		XrTableCell202.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripExcretas", "")
		});
		XRTableCell xrTableCell544 = XrTableCell202;
		location = new Point(190, 0);
		xrTableCell544.Location = location;
		XrTableCell202.Name = "XrTableCell202";
		XRTableCell xrTableCell545 = XrTableCell202;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell545.Padding = padding;
		XRTableCell xrTableCell546 = XrTableCell202;
		size = new Size(385, 25);
		xrTableCell546.Size = size;
		XrTableCell202.Text = "XrTableCell202";
		XrTableRow86.Cells.AddRange(new XRTableCell[2] { XrTableCell243, XrTableCell244 });
		XrTableRow86.Name = "XrTableRow86";
		XRTableRow xrTableRow58 = XrTableRow86;
		size = new Size(575, 25);
		xrTableRow58.Size = size;
		XrTableCell243.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell547 = XrTableCell243;
		location = new Point(0, 0);
		xrTableCell547.Location = location;
		XrTableCell243.Name = "XrTableCell243";
		XRTableCell xrTableCell548 = XrTableCell243;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell548.Padding = padding;
		XrTableCell243.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell549 = XrTableCell243;
		size = new Size(190, 25);
		xrTableCell549.Size = size;
		XrTableCell243.Text = "Teléfono:";
		XrTableCell244.BookmarkParent = XrCheckBoxFono;
		XrTableCell244.Controls.AddRange(new XRControl[1] { XrCheckBoxFono });
		XRTableCell xrTableCell550 = XrTableCell244;
		location = new Point(190, 0);
		xrTableCell550.Location = location;
		XrTableCell244.Name = "XrTableCell244";
		XRTableCell xrTableCell551 = XrTableCell244;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell551.Padding = padding;
		XRTableCell xrTableCell552 = XrTableCell244;
		size = new Size(385, 25);
		xrTableCell552.Size = size;
		XrCheckBoxFono.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.telefono", "")
		});
		XRCheckBox xrCheckBoxFono = XrCheckBoxFono;
		location = new Point(10, 4);
		xrCheckBoxFono.Location = location;
		XrCheckBoxFono.Name = "XrCheckBoxFono";
		XRCheckBox xrCheckBoxFono2 = XrCheckBoxFono;
		size = new Size(33, 17);
		xrCheckBoxFono2.Size = size;
		XrCheckBoxFono.Text = "Si";
		XrTableRow89.Cells.AddRange(new XRTableCell[2] { XrTableCell251, XrTableCell252 });
		XrTableRow89.Name = "XrTableRow89";
		XRTableRow xrTableRow59 = XrTableRow89;
		size = new Size(575, 25);
		xrTableRow59.Size = size;
		XrTableCell251.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell553 = XrTableCell251;
		location = new Point(0, 0);
		xrTableCell553.Location = location;
		XrTableCell251.Name = "XrTableCell251";
		XRTableCell xrTableCell554 = XrTableCell251;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell554.Padding = padding;
		XrTableCell251.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell555 = XrTableCell251;
		size = new Size(190, 25);
		xrTableCell555.Size = size;
		XrTableCell251.Text = "Internet:";
		XrTableCell252.BookmarkParent = XrCheckBoxInter;
		XrTableCell252.Controls.AddRange(new XRControl[1] { XrCheckBoxInter });
		XRTableCell xrTableCell556 = XrTableCell252;
		location = new Point(190, 0);
		xrTableCell556.Location = location;
		XrTableCell252.Name = "XrTableCell252";
		XRTableCell xrTableCell557 = XrTableCell252;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell557.Padding = padding;
		XRTableCell xrTableCell558 = XrTableCell252;
		size = new Size(385, 25);
		xrTableCell558.Size = size;
		XrCheckBoxInter.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.internet", "")
		});
		XRCheckBox xrCheckBoxInter = XrCheckBoxInter;
		location = new Point(10, 5);
		xrCheckBoxInter.Location = location;
		XrCheckBoxInter.Name = "XrCheckBoxInter";
		XRCheckBox xrCheckBoxInter2 = XrCheckBoxInter;
		size = new Size(33, 17);
		xrCheckBoxInter2.Size = size;
		XrCheckBoxInter.Text = "Si";
		XrTableRow88.Cells.AddRange(new XRTableCell[2] { XrTableCell247, XrTableCell248 });
		XrTableRow88.Name = "XrTableRow88";
		XRTableRow xrTableRow60 = XrTableRow88;
		size = new Size(575, 25);
		xrTableRow60.Size = size;
		XrTableCell247.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell559 = XrTableCell247;
		location = new Point(0, 0);
		xrTableCell559.Location = location;
		XrTableCell247.Name = "XrTableCell247";
		XRTableCell xrTableCell560 = XrTableCell247;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell560.Padding = padding;
		XrTableCell247.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell561 = XrTableCell247;
		size = new Size(190, 25);
		xrTableCell561.Size = size;
		XrTableCell247.Text = "Cable:";
		XrTableCell248.BookmarkParent = XrCheckBoxCable;
		XrTableCell248.Controls.AddRange(new XRControl[1] { XrCheckBoxCable });
		XRTableCell xrTableCell562 = XrTableCell248;
		location = new Point(190, 0);
		xrTableCell562.Location = location;
		XrTableCell248.Name = "XrTableCell248";
		XRTableCell xrTableCell563 = XrTableCell248;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell563.Padding = padding;
		XRTableCell xrTableCell564 = XrTableCell248;
		size = new Size(385, 25);
		xrTableCell564.Size = size;
		XrCheckBoxCable.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.cable", "")
		});
		XRCheckBox xrCheckBoxCable = XrCheckBoxCable;
		location = new Point(10, 3);
		xrCheckBoxCable.Location = location;
		XrCheckBoxCable.Name = "XrCheckBoxCable";
		XRCheckBox xrCheckBoxCable2 = XrCheckBoxCable;
		size = new Size(33, 18);
		xrCheckBoxCable2.Size = size;
		XrCheckBoxCable.Text = "Si";
		XrTableRow90.Cells.AddRange(new XRTableCell[2] { XrTableCell255, XrTableCell256 });
		XrTableRow90.Name = "XrTableRow90";
		XRTableRow xrTableRow61 = XrTableRow90;
		size = new Size(575, 25);
		xrTableRow61.Size = size;
		XrTableCell255.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell565 = XrTableCell255;
		location = new Point(0, 0);
		xrTableCell565.Location = location;
		XrTableCell255.Name = "XrTableCell255";
		XRTableCell xrTableCell566 = XrTableCell255;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell566.Padding = padding;
		XrTableCell255.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell567 = XrTableCell255;
		size = new Size(190, 25);
		xrTableCell567.Size = size;
		XrTableCell255.Text = "Otros:";
		XrTableCell256.BookmarkParent = XrCheckBoxOtros;
		XrTableCell256.Controls.AddRange(new XRControl[1] { XrCheckBoxOtros });
		XRTableCell xrTableCell568 = XrTableCell256;
		location = new Point(190, 0);
		xrTableCell568.Location = location;
		XrTableCell256.Name = "XrTableCell256";
		XRTableCell xrTableCell569 = XrTableCell256;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell569.Padding = padding;
		XRTableCell xrTableCell570 = XrTableCell256;
		size = new Size(385, 25);
		xrTableCell570.Size = size;
		XrCheckBoxOtros.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_Vivienda.otros", "")
		});
		XRCheckBox xrCheckBoxOtros = XrCheckBoxOtros;
		location = new Point(10, 0);
		xrCheckBoxOtros.Location = location;
		XrCheckBoxOtros.Name = "XrCheckBoxOtros";
		XRCheckBox xrCheckBoxOtros2 = XrCheckBoxOtros;
		size = new Size(33, 25);
		xrCheckBoxOtros2.Size = size;
		XrCheckBoxOtros.Text = "Si";
		XRTable xrTable27 = XrTable15;
		location = new Point(25, 400);
		xrTable27.Location = location;
		XrTable15.Name = "XrTable15";
		XrTable15.Rows.AddRange(new XRTableRow[3] { XrTableRow57, XrTableRow59, XrTableRow60 });
		XRTable xrTable28 = XrTable15;
		size = new Size(575, 81);
		xrTable28.Size = size;
		XrTableRow57.Cells.AddRange(new XRTableCell[1] { XrTableCell212 });
		XrTableRow57.Name = "XrTableRow57";
		XRTableRow xrTableRow62 = XrTableRow57;
		size = new Size(575, 27);
		xrTableRow62.Size = size;
		XrTableCell212.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell571 = XrTableCell212;
		location = new Point(0, 0);
		xrTableCell571.Location = location;
		XrTableCell212.Name = "XrTableCell212";
		XRTableCell xrTableCell572 = XrTableCell212;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell572.Padding = padding;
		XrTableCell212.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell573 = XrTableCell212;
		size = new Size(575, 27);
		xrTableCell573.Size = size;
		XrTableCell212.Text = "Distribución";
		XrTableCell212.TextAlignment = TextAlignment.TopCenter;
		XrTableRow59.Cells.AddRange(new XRTableCell[4] { XrTableCell210, XrTableCell211, XrTableCell206, XrTableCell208 });
		XrTableRow59.Name = "XrTableRow59";
		XRTableRow xrTableRow63 = XrTableRow59;
		size = new Size(575, 27);
		xrTableRow63.Size = size;
		XrTableCell210.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell574 = XrTableCell210;
		location = new Point(0, 0);
		xrTableCell574.Location = location;
		XrTableCell210.Name = "XrTableCell210";
		XRTableCell xrTableCell575 = XrTableCell210;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell575.Padding = padding;
		XrTableCell210.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell576 = XrTableCell210;
		size = new Size(158, 27);
		xrTableCell576.Size = size;
		XrTableCell210.Text = "Dormitorios N°:";
		XrTableCell211.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumDormitorio", "")
		});
		XRTableCell xrTableCell577 = XrTableCell211;
		location = new Point(158, 0);
		xrTableCell577.Location = location;
		XrTableCell211.Name = "XrTableCell211";
		XRTableCell xrTableCell578 = XrTableCell211;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell578.Padding = padding;
		XRTableCell xrTableCell579 = XrTableCell211;
		size = new Size(125, 27);
		xrTableCell579.Size = size;
		XrTableCell211.Text = "XrTableCell211";
		XrTableCell206.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell580 = XrTableCell206;
		location = new Point(283, 0);
		xrTableCell580.Location = location;
		XrTableCell206.Name = "XrTableCell206";
		XRTableCell xrTableCell581 = XrTableCell206;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell581.Padding = padding;
		XrTableCell206.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell582 = XrTableCell206;
		size = new Size(125, 27);
		xrTableCell582.Size = size;
		XrTableCell206.Text = "Compartimientos Nº";
		XrTableCell208.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumCompart", "")
		});
		XRTableCell xrTableCell583 = XrTableCell208;
		location = new Point(408, 0);
		xrTableCell583.Location = location;
		XrTableCell208.Name = "XrTableCell208";
		XRTableCell xrTableCell584 = XrTableCell208;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell584.Padding = padding;
		XRTableCell xrTableCell585 = XrTableCell208;
		size = new Size(167, 27);
		xrTableCell585.Size = size;
		XrTableRow60.Cells.AddRange(new XRTableCell[4] { XrTableCell213, XrTableCell214, XrTableCell207, XrTableCell209 });
		XrTableRow60.Name = "XrTableRow60";
		XRTableRow xrTableRow64 = XrTableRow60;
		size = new Size(575, 27);
		xrTableRow64.Size = size;
		XrTableCell213.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell586 = XrTableCell213;
		location = new Point(0, 0);
		xrTableCell586.Location = location;
		XrTableCell213.Name = "XrTableCell213";
		XRTableCell xrTableCell587 = XrTableCell213;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell587.Padding = padding;
		XrTableCell213.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell588 = XrTableCell213;
		size = new Size(158, 27);
		xrTableCell588.Size = size;
		XrTableCell213.Text = "Servicios Higienicos N°";
		XrTableCell214.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumServHig", "")
		});
		XRTableCell xrTableCell589 = XrTableCell214;
		location = new Point(158, 0);
		xrTableCell589.Location = location;
		XrTableCell214.Name = "XrTableCell214";
		XRTableCell xrTableCell590 = XrTableCell214;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell590.Padding = padding;
		XRTableCell xrTableCell591 = XrTableCell214;
		size = new Size(125, 27);
		xrTableCell591.Size = size;
		XrTableCell214.Text = "XrTableCell214";
		XrTableCell207.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell592 = XrTableCell207;
		location = new Point(283, 0);
		xrTableCell592.Location = location;
		XrTableCell207.Name = "XrTableCell207";
		XRTableCell xrTableCell593 = XrTableCell207;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell593.Padding = padding;
		XrTableCell207.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell594 = XrTableCell207;
		size = new Size(125, 27);
		xrTableCell594.Size = size;
		XrTableCell207.Text = "Personas por Dorm. Nº";
		XrTableCell209.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.NumPerDorm", "")
		});
		XRTableCell xrTableCell595 = XrTableCell209;
		location = new Point(408, 0);
		xrTableCell595.Location = location;
		XrTableCell209.Name = "XrTableCell209";
		XRTableCell xrTableCell596 = XrTableCell209;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell596.Padding = padding;
		XRTableCell xrTableCell597 = XrTableCell209;
		size = new Size(167, 27);
		xrTableCell597.Size = size;
		XRTable xrTable29 = XrTable11;
		location = new Point(25, 67);
		xrTable29.Location = location;
		XrTable11.Name = "XrTable11";
		XrTable11.Rows.AddRange(new XRTableRow[4] { XrTableRow49, XrTableRow50, XrTableRow51, XrTableRow52 });
		XRTable xrTable30 = XrTable11;
		size = new Size(575, 100);
		xrTable30.Size = size;
		XrTableRow49.Cells.AddRange(new XRTableCell[2] { XrTableCell187, XrTableCell188 });
		XrTableRow49.Name = "XrTableRow49";
		XRTableRow xrTableRow65 = XrTableRow49;
		size = new Size(575, 25);
		xrTableRow65.Size = size;
		XrTableCell187.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell598 = XrTableCell187;
		location = new Point(0, 0);
		xrTableCell598.Location = location;
		XrTableCell187.Name = "XrTableCell187";
		XRTableCell xrTableCell599 = XrTableCell187;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell599.Padding = padding;
		XrTableCell187.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell600 = XrTableCell187;
		size = new Size(183, 25);
		xrTableCell600.Size = size;
		XrTableCell187.Text = "Tenencia:";
		XrTableCell188.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripTenencia", "")
		});
		XRTableCell xrTableCell601 = XrTableCell188;
		location = new Point(183, 0);
		xrTableCell601.Location = location;
		XrTableCell188.Name = "XrTableCell188";
		XRTableCell xrTableCell602 = XrTableCell188;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell602.Padding = padding;
		XRTableCell xrTableCell603 = XrTableCell188;
		size = new Size(392, 25);
		xrTableCell603.Size = size;
		XrTableCell188.Text = "XrTableCell188";
		XrTableRow50.Cells.AddRange(new XRTableCell[2] { XrTableCell189, XrTableCell190 });
		XrTableRow50.Name = "XrTableRow50";
		XRTableRow xrTableRow66 = XrTableRow50;
		size = new Size(575, 25);
		xrTableRow66.Size = size;
		XrTableCell189.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell604 = XrTableCell189;
		location = new Point(0, 0);
		xrTableCell604.Location = location;
		XrTableCell189.Name = "XrTableCell189";
		XRTableCell xrTableCell605 = XrTableCell189;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell605.Padding = padding;
		XrTableCell189.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell606 = XrTableCell189;
		size = new Size(183, 25);
		xrTableCell606.Size = size;
		XrTableCell189.Text = "Tipo:";
		XrTableCell190.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripTipo", "")
		});
		XRTableCell xrTableCell607 = XrTableCell190;
		location = new Point(183, 0);
		xrTableCell607.Location = location;
		XrTableCell190.Name = "XrTableCell190";
		XRTableCell xrTableCell608 = XrTableCell190;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell608.Padding = padding;
		XRTableCell xrTableCell609 = XrTableCell190;
		size = new Size(392, 25);
		xrTableCell609.Size = size;
		XrTableCell190.Text = "XrTableCell190";
		XrTableRow51.Cells.AddRange(new XRTableCell[2] { XrTableCell191, XrTableCell192 });
		XrTableRow51.Name = "XrTableRow51";
		XRTableRow xrTableRow67 = XrTableRow51;
		size = new Size(575, 25);
		xrTableRow67.Size = size;
		XrTableCell191.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell610 = XrTableCell191;
		location = new Point(0, 0);
		xrTableCell610.Location = location;
		XrTableCell191.Name = "XrTableCell191";
		XRTableCell xrTableCell611 = XrTableCell191;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell611.Padding = padding;
		XrTableCell191.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell612 = XrTableCell191;
		size = new Size(183, 25);
		xrTableCell612.Size = size;
		XrTableCell191.Text = "Material:";
		XrTableCell192.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripMaterial", "")
		});
		XRTableCell xrTableCell613 = XrTableCell192;
		location = new Point(183, 0);
		xrTableCell613.Location = location;
		XrTableCell192.Name = "XrTableCell192";
		XRTableCell xrTableCell614 = XrTableCell192;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell614.Padding = padding;
		XRTableCell xrTableCell615 = XrTableCell192;
		size = new Size(392, 25);
		xrTableCell615.Size = size;
		XrTableCell192.Text = "XrTableCell192";
		XrTableRow52.Cells.AddRange(new XRTableCell[2] { XrTableCell193, XrTableCell194 });
		XrTableRow52.Name = "XrTableRow52";
		XRTableRow xrTableRow68 = XrTableRow52;
		size = new Size(575, 25);
		xrTableRow68.Size = size;
		XrTableCell193.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell616 = XrTableCell193;
		location = new Point(0, 0);
		xrTableCell616.Location = location;
		XrTableCell193.Name = "XrTableCell193";
		XRTableCell xrTableCell617 = XrTableCell193;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell617.Padding = padding;
		XrTableCell193.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell618 = XrTableCell193;
		size = new Size(183, 25);
		xrTableCell618.Size = size;
		XrTableCell193.Text = "Condiciones de Conservación:";
		XrTableCell194.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Vivienda.DescripConserva", "")
		});
		XRTableCell xrTableCell619 = XrTableCell194;
		location = new Point(183, 0);
		xrTableCell619.Location = location;
		XrTableCell194.Name = "XrTableCell194";
		XRTableCell xrTableCell620 = XrTableCell194;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell620.Padding = padding;
		XRTableCell xrTableCell621 = XrTableCell194;
		size = new Size(392, 25);
		xrTableCell621.Size = size;
		XrTableCell194.Text = "XrTableCell194";
		XrLabel15.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel43 = XrLabel15;
		location = new Point(25, 25);
		xrLabel43.Location = location;
		XrLabel15.Name = "XrLabel15";
		XRLabel xrLabel44 = XrLabel15;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel44.Padding = padding;
		XrLabel15.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel45 = XrLabel15;
		size = new Size(433, 25);
		xrLabel45.Size = size;
		XrLabel15.Text = "V. ASPECTO DE VIVIENDA";
		DetailReport4.Bands.AddRange(new Band[2] { Detail5, GroupHeader5 });
		DetailReport4.DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DetailReport4.DataMember = "spRRHH_Ficha_Estudio_Realizado";
		DetailReport4.DataSource = DataSet11;
		DetailReport4.Name = "DetailReport4";
		Detail5.Controls.AddRange(new XRControl[1] { XrTable17 });
		Detail5.Height = 27;
		Detail5.Name = "Detail5";
		XRTable xrTable31 = XrTable17;
		location = new Point(25, 0);
		xrTable31.Location = location;
		XrTable17.Name = "XrTable17";
		XrTable17.ParentStyleUsing.UseFont = false;
		XrTable17.Rows.AddRange(new XRTableRow[1] { XrTableRow62 });
		XRTable xrTable32 = XrTable17;
		size = new Size(600, 25);
		xrTable32.Size = size;
		XrTableRow62.Cells.AddRange(new XRTableCell[5] { XrTableCell220, XrTableCell221, XrTableCell222, XrTableCell223, XrTableCell224 });
		XrTableRow62.Name = "XrTableRow62";
		XRTableRow xrTableRow69 = XrTableRow62;
		size = new Size(600, 25);
		xrTableRow69.Size = size;
		XrTableCell220.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripTipoEst", "")
		});
		XRTableCell xrTableCell622 = XrTableCell220;
		location = new Point(0, 0);
		xrTableCell622.Location = location;
		XrTableCell220.Name = "XrTableCell220";
		XRTableCell xrTableCell623 = XrTableCell220;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell623.Padding = padding;
		XRTableCell xrTableCell624 = XrTableCell220;
		size = new Size(120, 25);
		xrTableCell624.Size = size;
		XrTableCell220.Text = "Tipo de Estudio";
		XrTableCell221.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.CentroEstudios", "")
		});
		XRTableCell xrTableCell625 = XrTableCell221;
		location = new Point(120, 0);
		xrTableCell625.Location = location;
		XrTableCell221.Name = "XrTableCell221";
		XRTableCell xrTableCell626 = XrTableCell221;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell626.Padding = padding;
		XRTableCell xrTableCell627 = XrTableCell221;
		size = new Size(120, 25);
		xrTableCell627.Size = size;
		XrTableCell221.Text = "Centro de Estudios";
		XrTableCell222.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.AñoInicio", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell628 = XrTableCell222;
		location = new Point(240, 0);
		xrTableCell628.Location = location;
		XrTableCell222.Name = "XrTableCell222";
		XRTableCell xrTableCell629 = XrTableCell222;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell629.Padding = padding;
		XRTableCell xrTableCell630 = XrTableCell222;
		size = new Size(120, 25);
		xrTableCell630.Size = size;
		XrTableCell222.Text = "Fecha de Inicio";
		XrTableCell223.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.Añotermino", "{0:dd/MM/yyyy}")
		});
		XRTableCell xrTableCell631 = XrTableCell223;
		location = new Point(360, 0);
		xrTableCell631.Location = location;
		XrTableCell223.Name = "XrTableCell223";
		XRTableCell xrTableCell632 = XrTableCell223;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell632.Padding = padding;
		XRTableCell xrTableCell633 = XrTableCell223;
		size = new Size(120, 25);
		xrTableCell633.Size = size;
		XrTableCell223.Text = "Fecha de Termino";
		XrTableCell224.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Estudio_Realizado.DescripEstadoEstudio", "")
		});
		XRTableCell xrTableCell634 = XrTableCell224;
		location = new Point(480, 0);
		xrTableCell634.Location = location;
		XrTableCell224.Name = "XrTableCell224";
		XRTableCell xrTableCell635 = XrTableCell224;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell635.Padding = padding;
		XRTableCell xrTableCell636 = XrTableCell224;
		size = new Size(120, 25);
		xrTableCell636.Size = size;
		XrTableCell224.Text = "Estado";
		GroupHeader5.Controls.AddRange(new XRControl[3] { XrTable16, XrLabel18, XrLabel17 });
		GroupHeader5.Height = 118;
		GroupHeader5.Name = "GroupHeader5";
		XrTable16.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable33 = XrTable16;
		location = new Point(25, 92);
		xrTable33.Location = location;
		XrTable16.Name = "XrTable16";
		XrTable16.ParentStyleUsing.UseFont = false;
		XrTable16.Rows.AddRange(new XRTableRow[1] { XrTableRow61 });
		XRTable xrTable34 = XrTable16;
		size = new Size(600, 25);
		xrTable34.Size = size;
		XrTableRow61.Cells.AddRange(new XRTableCell[5] { XrTableCell215, XrTableCell216, XrTableCell217, XrTableCell218, XrTableCell219 });
		XrTableRow61.Name = "XrTableRow61";
		XRTableRow xrTableRow70 = XrTableRow61;
		size = new Size(600, 25);
		xrTableRow70.Size = size;
		XRTableCell xrTableCell637 = XrTableCell215;
		location = new Point(0, 0);
		xrTableCell637.Location = location;
		XrTableCell215.Name = "XrTableCell215";
		XRTableCell xrTableCell638 = XrTableCell215;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell638.Padding = padding;
		XRTableCell xrTableCell639 = XrTableCell215;
		size = new Size(120, 25);
		xrTableCell639.Size = size;
		XrTableCell215.Text = "Tipo de Estudio";
		XRTableCell xrTableCell640 = XrTableCell216;
		location = new Point(120, 0);
		xrTableCell640.Location = location;
		XrTableCell216.Name = "XrTableCell216";
		XRTableCell xrTableCell641 = XrTableCell216;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell641.Padding = padding;
		XRTableCell xrTableCell642 = XrTableCell216;
		size = new Size(120, 25);
		xrTableCell642.Size = size;
		XrTableCell216.Text = "Centro de Estudios";
		XRTableCell xrTableCell643 = XrTableCell217;
		location = new Point(240, 0);
		xrTableCell643.Location = location;
		XrTableCell217.Name = "XrTableCell217";
		XRTableCell xrTableCell644 = XrTableCell217;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell644.Padding = padding;
		XRTableCell xrTableCell645 = XrTableCell217;
		size = new Size(120, 25);
		xrTableCell645.Size = size;
		XrTableCell217.Text = "Fecha de Inicio";
		XRTableCell xrTableCell646 = XrTableCell218;
		location = new Point(360, 0);
		xrTableCell646.Location = location;
		XrTableCell218.Name = "XrTableCell218";
		XRTableCell xrTableCell647 = XrTableCell218;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell647.Padding = padding;
		XRTableCell xrTableCell648 = XrTableCell218;
		size = new Size(120, 25);
		xrTableCell648.Size = size;
		XrTableCell218.Text = "Fecha de Termino";
		XRTableCell xrTableCell649 = XrTableCell219;
		location = new Point(480, 0);
		xrTableCell649.Location = location;
		XrTableCell219.Name = "XrTableCell219";
		XRTableCell xrTableCell650 = XrTableCell219;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell650.Padding = padding;
		XRTableCell xrTableCell651 = XrTableCell219;
		size = new Size(120, 25);
		xrTableCell651.Size = size;
		XrTableCell219.Text = "Estado";
		XrLabel18.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRLabel xrLabel46 = XrLabel18;
		location = new Point(25, 50);
		xrLabel46.Location = location;
		XrLabel18.Name = "XrLabel18";
		XRLabel xrLabel47 = XrLabel18;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel47.Padding = padding;
		XrLabel18.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel48 = XrLabel18;
		size = new Size(367, 25);
		xrLabel48.Size = size;
		XrLabel18.Text = "2.1  Estudios Realizados:";
		XrLabel17.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel49 = XrLabel17;
		location = new Point(25, 8);
		xrLabel49.Location = location;
		XrLabel17.Name = "XrLabel17";
		XRLabel xrLabel50 = XrLabel17;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel50.Padding = padding;
		XrLabel17.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel51 = XrLabel17;
		size = new Size(367, 25);
		xrLabel51.Size = size;
		XrLabel17.Text = "II. ASPECTO EDUCATIVO";
		DetailReport5.Bands.AddRange(new Band[3] { Detail6, GroupHeader6, GroupFooter2 });
		DetailReport5.Level = 6;
		DetailReport5.Name = "DetailReport5";
		Detail6.Height = 0;
		Detail6.Name = "Detail6";
		GroupHeader6.Controls.AddRange(new XRControl[2] { XrTable5, XrLabel16 });
		GroupHeader6.Height = 381;
		GroupHeader6.Name = "GroupHeader6";
		XRTable xrTable35 = XrTable5;
		location = new Point(58, 42);
		xrTable35.Location = location;
		XrTable5.Name = "XrTable5";
		XrTable5.ParentStyleUsing.UseFont = false;
		XrTable5.Rows.AddRange(new XRTableRow[14]
		{
			XrTableRow68, XrTableRow64, XrTableRow69, XrTableRow67, XrTableRow66, XrTableRow65, XrTableRow70, XrTableRow76, XrTableRow75, XrTableRow77,
			XrTableRow74, XrTableRow73, XrTableRow72, XrTableRow71
		});
		XRTable xrTable36 = XrTable5;
		size = new Size(567, 333);
		xrTable36.Size = size;
		XrTableRow68.Cells.AddRange(new XRTableCell[1] { XrTableCell88 });
		XrTableRow68.Name = "XrTableRow68";
		XRTableRow xrTableRow71 = XrTableRow68;
		size = new Size(567, 23);
		xrTableRow71.Size = size;
		XrTableCell88.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell652 = XrTableCell88;
		location = new Point(0, 0);
		xrTableCell652.Location = location;
		XrTableCell88.Name = "XrTableCell88";
		XRTableCell xrTableCell653 = XrTableCell88;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell653.Padding = padding;
		XrTableCell88.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell654 = XrTableCell88;
		size = new Size(567, 23);
		xrTableCell654.Size = size;
		XrTableCell88.Text = "¿Se lleva bien con sus compañeros de Trabajo?";
		XrTableRow64.Cells.AddRange(new XRTableCell[1] { XrTableCell66 });
		XrTableRow64.Name = "XrTableRow64";
		XRTableRow xrTableRow72 = XrTableRow64;
		size = new Size(567, 23);
		xrTableRow72.Size = size;
		XrTableCell66.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.respues1", "")
		});
		XRTableCell xrTableCell655 = XrTableCell66;
		location = new Point(0, 0);
		xrTableCell655.Location = location;
		XrTableCell66.Name = "XrTableCell66";
		XRTableCell xrTableCell656 = XrTableCell66;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell656.Padding = padding;
		XRTableCell xrTableCell657 = XrTableCell66;
		size = new Size(567, 23);
		xrTableCell657.Size = size;
		XrTableRow69.Cells.AddRange(new XRTableCell[1] { XrTableCell93 });
		XrTableRow69.Name = "XrTableRow69";
		XRTableRow xrTableRow73 = XrTableRow69;
		size = new Size(567, 23);
		xrTableRow73.Size = size;
		XrTableCell93.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell658 = XrTableCell93;
		location = new Point(0, 0);
		xrTableCell658.Location = location;
		XrTableCell93.Name = "XrTableCell93";
		XRTableCell xrTableCell659 = XrTableCell93;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell659.Padding = padding;
		XrTableCell93.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell660 = XrTableCell93;
		size = new Size(567, 23);
		xrTableCell660.Size = size;
		XrTableCell93.Text = "¿Cómo se siente en su ámbito laboral?";
		XrTableRow67.Cells.AddRange(new XRTableCell[1] { XrTableCell81 });
		XrTableRow67.Name = "XrTableRow67";
		XRTableRow xrTableRow74 = XrTableRow67;
		size = new Size(567, 23);
		xrTableRow74.Size = size;
		XrTableCell81.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.respues2", "")
		});
		XRTableCell xrTableCell661 = XrTableCell81;
		location = new Point(0, 0);
		xrTableCell661.Location = location;
		XrTableCell81.Name = "XrTableCell81";
		XRTableCell xrTableCell662 = XrTableCell81;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell662.Padding = padding;
		XRTableCell xrTableCell663 = XrTableCell81;
		size = new Size(567, 23);
		xrTableCell663.Size = size;
		XrTableRow66.Cells.AddRange(new XRTableCell[1] { XrTableCell75 });
		XrTableRow66.Name = "XrTableRow66";
		XRTableRow xrTableRow75 = XrTableRow66;
		size = new Size(567, 23);
		xrTableRow75.Size = size;
		XrTableCell75.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell664 = XrTableCell75;
		location = new Point(0, 0);
		xrTableCell664.Location = location;
		XrTableCell75.Name = "XrTableCell75";
		XRTableCell xrTableCell665 = XrTableCell75;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell665.Padding = padding;
		XrTableCell75.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell666 = XrTableCell75;
		size = new Size(567, 23);
		xrTableCell666.Size = size;
		XrTableCell75.Text = "En general, ¿Cómo se siente tratado por su superior inmediato?";
		XrTableRow65.Cells.AddRange(new XRTableCell[1] { XrTableCell68 });
		XrTableRow65.Name = "XrTableRow65";
		XRTableRow xrTableRow76 = XrTableRow65;
		size = new Size(567, 23);
		xrTableRow76.Size = size;
		XrTableCell68.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.soc3", "")
		});
		XRTableCell xrTableCell667 = XrTableCell68;
		location = new Point(0, 0);
		xrTableCell667.Location = location;
		XrTableCell68.Name = "XrTableCell68";
		XRTableCell xrTableCell668 = XrTableCell68;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell668.Padding = padding;
		XRTableCell xrTableCell669 = XrTableCell68;
		size = new Size(567, 23);
		xrTableCell669.Size = size;
		XrTableRow70.Cells.AddRange(new XRTableCell[1] { XrTableCell124 });
		XrTableRow70.Name = "XrTableRow70";
		XRTableRow xrTableRow77 = XrTableRow70;
		size = new Size(567, 23);
		xrTableRow77.Size = size;
		XrTableCell124.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell670 = XrTableCell124;
		location = new Point(0, 0);
		xrTableCell670.Location = location;
		XrTableCell124.Name = "XrTableCell124";
		XRTableCell xrTableCell671 = XrTableCell124;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell671.Padding = padding;
		XrTableCell124.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell672 = XrTableCell124;
		size = new Size(567, 23);
		xrTableCell672.Size = size;
		XrTableCell124.Text = "¿Cuáles son los principales problemas conocidos por UD. que existen en la Institución?";
		XrTableRow76.Cells.AddRange(new XRTableCell[1] { XrTableCell123 });
		XrTableRow76.Name = "XrTableRow76";
		XRTableRow xrTableRow78 = XrTableRow76;
		size = new Size(567, 23);
		xrTableRow78.Size = size;
		XrTableCell123.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.PrincipProblemas", "")
		});
		XRTableCell xrTableCell673 = XrTableCell123;
		location = new Point(0, 0);
		xrTableCell673.Location = location;
		XrTableCell123.Name = "XrTableCell123";
		XRTableCell xrTableCell674 = XrTableCell123;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell674.Padding = padding;
		XRTableCell xrTableCell675 = XrTableCell123;
		size = new Size(567, 23);
		xrTableCell675.Size = size;
		XrTableRow75.Cells.AddRange(new XRTableCell[1] { XrTableCell92 });
		XrTableRow75.Name = "XrTableRow75";
		XRTableRow xrTableRow79 = XrTableRow75;
		size = new Size(567, 23);
		xrTableRow79.Size = size;
		XrTableCell92.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell676 = XrTableCell92;
		location = new Point(0, 0);
		xrTableCell676.Location = location;
		XrTableCell92.Name = "XrTableCell92";
		XRTableCell xrTableCell677 = XrTableCell92;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell677.Padding = padding;
		XrTableCell92.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell678 = XrTableCell92;
		size = new Size(567, 23);
		xrTableCell678.Size = size;
		XrTableCell92.Text = "¿Qué propone usted para mejorar esas situaciones problemáticas en su institución?";
		XrTableRow77.Cells.AddRange(new XRTableCell[1] { XrTableCell125 });
		XrTableRow77.Name = "XrTableRow77";
		XRTableRow xrTableRow80 = XrTableRow77;
		size = new Size(567, 23);
		xrTableRow80.Size = size;
		XrTableCell125.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.PropMejoraInstitu", "")
		});
		XRTableCell xrTableCell679 = XrTableCell125;
		location = new Point(0, 0);
		xrTableCell679.Location = location;
		XrTableCell125.Name = "XrTableCell125";
		XRTableCell xrTableCell680 = XrTableCell125;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell680.Padding = padding;
		XRTableCell xrTableCell681 = XrTableCell125;
		size = new Size(567, 23);
		xrTableCell681.Size = size;
		XrTableRow74.Cells.AddRange(new XRTableCell[1] { XrTableCell87 });
		XrTableRow74.Name = "XrTableRow74";
		XRTableRow xrTableRow81 = XrTableRow74;
		size = new Size(567, 23);
		xrTableRow81.Size = size;
		XrTableCell87.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell682 = XrTableCell87;
		location = new Point(0, 0);
		xrTableCell682.Location = location;
		XrTableCell87.Name = "XrTableCell87";
		XRTableCell xrTableCell683 = XrTableCell87;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell683.Padding = padding;
		XrTableCell87.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell684 = XrTableCell87;
		size = new Size(567, 23);
		xrTableCell684.Size = size;
		XrTableCell87.Text = "¿Cuál es su Hobby?";
		XrTableRow73.Cells.AddRange(new XRTableCell[1] { XrTableCell79 });
		XrTableRow73.Name = "XrTableRow73";
		XRTableRow xrTableRow82 = XrTableRow73;
		size = new Size(567, 23);
		xrTableRow82.Size = size;
		XrTableCell79.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.hobby", "")
		});
		XRTableCell xrTableCell685 = XrTableCell79;
		location = new Point(0, 0);
		xrTableCell685.Location = location;
		XrTableCell79.Name = "XrTableCell79";
		XRTableCell xrTableCell686 = XrTableCell79;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell686.Padding = padding;
		XRTableCell xrTableCell687 = XrTableCell79;
		size = new Size(567, 23);
		xrTableCell687.Size = size;
		XrTableRow72.Cells.AddRange(new XRTableCell[1] { XrTableCell73 });
		XrTableRow72.Name = "XrTableRow72";
		XRTableRow xrTableRow83 = XrTableRow72;
		size = new Size(567, 23);
		xrTableRow83.Size = size;
		XrTableCell73.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Italic);
		XRTableCell xrTableCell688 = XrTableCell73;
		location = new Point(0, 0);
		xrTableCell688.Location = location;
		XrTableCell73.Name = "XrTableCell73";
		XRTableCell xrTableCell689 = XrTableCell73;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell689.Padding = padding;
		XrTableCell73.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell690 = XrTableCell73;
		size = new Size(567, 23);
		xrTableCell690.Size = size;
		XrTableCell73.Text = "¿Qué actividades recreativas le gustaría realizar en el Centro de Trabajo?";
		XrTableRow71.Cells.AddRange(new XRTableCell[1] { XrTableCell67 });
		XrTableRow71.Name = "XrTableRow71";
		XRTableRow xrTableRow84 = XrTableRow71;
		size = new Size(567, 34);
		xrTableRow84.Size = size;
		XrTableCell67.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.ActRecreaInstitu", "")
		});
		XRTableCell xrTableCell691 = XrTableCell67;
		location = new Point(0, 0);
		xrTableCell691.Location = location;
		XrTableCell67.Name = "XrTableCell67";
		XRTableCell xrTableCell692 = XrTableCell67;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell692.Padding = padding;
		XRTableCell xrTableCell693 = XrTableCell67;
		size = new Size(567, 34);
		xrTableCell693.Size = size;
		XrLabel16.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel52 = XrLabel16;
		location = new Point(25, 8);
		xrLabel52.Location = location;
		XrLabel16.Name = "XrLabel16";
		XRLabel xrLabel53 = XrLabel16;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel53.Padding = padding;
		XrLabel16.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel54 = XrLabel16;
		size = new Size(325, 25);
		xrLabel54.Size = size;
		XrLabel16.Text = "VIII. ASPECTO SOCIO / RECREATIVO";
		GroupFooter2.Controls.AddRange(new XRControl[8] { XrLabel24, XrLabel23, XrPageInfo2, XrLabel22, XrLine2, XrLine1, XrLabel21, XrLabel20 });
		GroupFooter2.Height = 85;
		GroupFooter2.Name = "GroupFooter2";
		XrLabel24.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.NumDocId", "")
		});
		XRLabel xrLabel55 = XrLabel24;
		location = new Point(92, 67);
		xrLabel55.Location = location;
		XrLabel24.Name = "XrLabel24";
		XRLabel xrLabel56 = XrLabel24;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel56.Padding = padding;
		XRLabel xrLabel57 = XrLabel24;
		size = new Size(100, 17);
		xrLabel57.Size = size;
		XrLabel24.Text = "XrLabel24";
		XRLabel xrLabel58 = XrLabel23;
		location = new Point(58, 67);
		xrLabel58.Location = location;
		XrLabel23.Name = "XrLabel23";
		XRLabel xrLabel59 = XrLabel23;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel59.Padding = padding;
		XRLabel xrLabel60 = XrLabel23;
		size = new Size(33, 17);
		xrLabel60.Size = size;
		XrLabel23.Text = "DNI:";
		XrPageInfo2.Format = "{0:dd/MM/yyyy}";
		XRPageInfo xrPageInfo4 = XrPageInfo2;
		location = new Point(550, 67);
		xrPageInfo4.Location = location;
		XrPageInfo2.Name = "XrPageInfo2";
		XRPageInfo xrPageInfo5 = XrPageInfo2;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrPageInfo5.Padding = padding;
		XrPageInfo2.PageInfo = PageInfo.DateTime;
		XRPageInfo xrPageInfo6 = XrPageInfo2;
		size = new Size(75, 17);
		xrPageInfo6.Size = size;
		XRLabel xrLabel61 = XrLabel22;
		location = new Point(508, 67);
		xrLabel61.Location = location;
		XrLabel22.Name = "XrLabel22";
		XRLabel xrLabel62 = XrLabel22;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel62.Padding = padding;
		XRLabel xrLabel63 = XrLabel22;
		size = new Size(42, 17);
		xrLabel63.Size = size;
		XrLabel22.Text = "Fecha:";
		XRLine xrLine = XrLine2;
		location = new Point(25, 33);
		xrLine.Location = location;
		XrLine2.Name = "XrLine2";
		XRLine xrLine2 = XrLine2;
		size = new Size(175, 8);
		xrLine2.Size = size;
		XRLine xrLine3 = XrLine1;
		location = new Point(467, 33);
		xrLine3.Location = location;
		XrLine1.Name = "XrLine1";
		XRLine xrLine4 = XrLine1;
		size = new Size(209, 8);
		xrLine4.Size = size;
		XRLabel xrLabel64 = XrLabel21;
		location = new Point(483, 42);
		xrLabel64.Location = location;
		XrLabel21.Name = "XrLabel21";
		XRLabel xrLabel65 = XrLabel21;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel65.Padding = padding;
		XRLabel xrLabel66 = XrLabel21;
		size = new Size(175, 17);
		xrLabel66.Size = size;
		XrLabel21.Text = "Firma de la Trabajadora Social";
		XRLabel xrLabel67 = XrLabel20;
		location = new Point(50, 42);
		xrLabel67.Location = location;
		XrLabel20.Name = "XrLabel20";
		XRLabel xrLabel68 = XrLabel20;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel68.Padding = padding;
		XRLabel xrLabel69 = XrLabel20;
		size = new Size(125, 17);
		xrLabel69.Size = size;
		XrLabel20.Text = "Firma del Trabajador";
		DetailReport6.Bands.AddRange(new Band[2] { Detail7, GroupHeader7 });
		DetailReport6.DataMember = "spRRHH_Ficha_Det_Familiar_Salud";
		DetailReport6.DataSource = DataSet11;
		DetailReport6.Level = 4;
		DetailReport6.Name = "DetailReport6";
		Detail7.Controls.AddRange(new XRControl[1] { XrTable20 });
		Detail7.Height = 26;
		Detail7.Name = "Detail7";
		XRTable xrTable37 = XrTable20;
		location = new Point(17, 0);
		xrTable37.Location = location;
		XrTable20.Name = "XrTable20";
		XrTable20.ParentStyleUsing.UseFont = false;
		XrTable20.Rows.AddRange(new XRTableRow[1] { XrTableRow46 });
		XRTable xrTable38 = XrTable20;
		size = new Size(650, 25);
		xrTable38.Size = size;
		XrTableRow46.Cells.AddRange(new XRTableCell[7] { XrTableCell205, XrTableCell225, XrTableCell231, XrTableCell232, XrTableCell235, XrTableCell236, XrTableCell239 });
		XrTableRow46.Name = "XrTableRow46";
		XRTableRow xrTableRow85 = XrTableRow46;
		size = new Size(650, 25);
		xrTableRow85.Size = size;
		XrTableCell205.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.numdocid", "")
		});
		XRTableCell xrTableCell694 = XrTableCell205;
		location = new Point(0, 0);
		xrTableCell694.Location = location;
		XrTableCell205.Name = "XrTableCell205";
		XRTableCell xrTableCell695 = XrTableCell205;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell695.Padding = padding;
		XRTableCell xrTableCell696 = XrTableCell205;
		size = new Size(100, 25);
		xrTableCell696.Size = size;
		XrTableCell225.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.DescripTipoFam", "")
		});
		XRTableCell xrTableCell697 = XrTableCell225;
		location = new Point(100, 0);
		xrTableCell697.Location = location;
		XrTableCell225.Name = "XrTableCell225";
		XRTableCell xrTableCell698 = XrTableCell225;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell698.Padding = padding;
		XRTableCell xrTableCell699 = XrTableCell225;
		size = new Size(83, 25);
		xrTableCell699.Size = size;
		XrTableCell231.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.enfermedad", "")
		});
		XRTableCell xrTableCell700 = XrTableCell231;
		location = new Point(183, 0);
		xrTableCell700.Location = location;
		XrTableCell231.Name = "XrTableCell231";
		XRTableCell xrTableCell701 = XrTableCell231;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell701.Padding = padding;
		XRTableCell xrTableCell702 = XrTableCell231;
		size = new Size(137, 25);
		xrTableCell702.Size = size;
		XrTableCell232.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.tiempoenfermedad", "")
		});
		XRTableCell xrTableCell703 = XrTableCell232;
		location = new Point(320, 0);
		xrTableCell703.Location = location;
		XrTableCell232.Name = "XrTableCell232";
		XRTableCell xrTableCell704 = XrTableCell232;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell704.Padding = padding;
		XRTableCell xrTableCell705 = XrTableCell232;
		size = new Size(71, 25);
		xrTableCell705.Size = size;
		XRTableCell xrTableCell706 = XrTableCell235;
		location = new Point(391, 0);
		xrTableCell706.Location = location;
		XrTableCell235.Name = "XrTableCell235";
		XRTableCell xrTableCell707 = XrTableCell235;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell707.Padding = padding;
		XRTableCell xrTableCell708 = XrTableCell235;
		size = new Size(92, 25);
		xrTableCell708.Size = size;
		XrTableCell236.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.numautogensalud", "")
		});
		XRTableCell xrTableCell709 = XrTableCell236;
		location = new Point(483, 0);
		xrTableCell709.Location = location;
		XrTableCell236.Name = "XrTableCell236";
		XRTableCell xrTableCell710 = XrTableCell236;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell710.Padding = padding;
		XRTableCell xrTableCell711 = XrTableCell236;
		size = new Size(92, 25);
		xrTableCell711.Size = size;
		XrTableCell239.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_Det_Familiar_Salud.descripts", "")
		});
		XRTableCell xrTableCell712 = XrTableCell239;
		location = new Point(575, 0);
		xrTableCell712.Location = location;
		XrTableCell239.Name = "XrTableCell239";
		XRTableCell xrTableCell713 = XrTableCell239;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell713.Padding = padding;
		XRTableCell xrTableCell714 = XrTableCell239;
		size = new Size(75, 25);
		xrTableCell714.Size = size;
		GroupHeader7.Controls.AddRange(new XRControl[3] { XrTable19, XrTable18, XrLabel19 });
		GroupHeader7.Height = 175;
		GroupHeader7.Name = "GroupHeader7";
		XrTable19.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTable xrTable39 = XrTable19;
		location = new Point(17, 150);
		xrTable39.Location = location;
		XrTable19.Name = "XrTable19";
		XrTable19.ParentStyleUsing.UseFont = false;
		XrTable19.Rows.AddRange(new XRTableRow[1] { XrTableRow45 });
		XRTable xrTable40 = XrTable19;
		size = new Size(650, 25);
		xrTable40.Size = size;
		XrTableRow45.Cells.AddRange(new XRTableCell[7] { XrTableCell177, XrTableCell203, XrTableCell185, XrTableCell181, XrTableCell182, XrTableCell186, XrTableCell204 });
		XrTableRow45.Name = "XrTableRow45";
		XRTableRow xrTableRow86 = XrTableRow45;
		size = new Size(650, 25);
		xrTableRow86.Size = size;
		XRTableCell xrTableCell715 = XrTableCell177;
		location = new Point(0, 0);
		xrTableCell715.Location = location;
		XrTableCell177.Name = "XrTableCell177";
		XRTableCell xrTableCell716 = XrTableCell177;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell716.Padding = padding;
		XRTableCell xrTableCell717 = XrTableCell177;
		size = new Size(100, 25);
		xrTableCell717.Size = size;
		XrTableCell177.Text = "DNI";
		XRTableCell xrTableCell718 = XrTableCell203;
		location = new Point(100, 0);
		xrTableCell718.Location = location;
		XrTableCell203.Name = "XrTableCell203";
		XRTableCell xrTableCell719 = XrTableCell203;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell719.Padding = padding;
		XRTableCell xrTableCell720 = XrTableCell203;
		size = new Size(83, 25);
		xrTableCell720.Size = size;
		XrTableCell203.Text = "Parentesco";
		XRTableCell xrTableCell721 = XrTableCell185;
		location = new Point(183, 0);
		xrTableCell721.Location = location;
		XrTableCell185.Name = "XrTableCell185";
		XRTableCell xrTableCell722 = XrTableCell185;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell722.Padding = padding;
		XRTableCell xrTableCell723 = XrTableCell185;
		size = new Size(137, 25);
		xrTableCell723.Size = size;
		XrTableCell185.Text = "Enfermedad";
		XRTableCell xrTableCell724 = XrTableCell181;
		location = new Point(320, 0);
		xrTableCell724.Location = location;
		XrTableCell181.Name = "XrTableCell181";
		XRTableCell xrTableCell725 = XrTableCell181;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell725.Padding = padding;
		XRTableCell xrTableCell726 = XrTableCell181;
		size = new Size(71, 25);
		xrTableCell726.Size = size;
		XrTableCell181.Text = "Tiempo";
		XRTableCell xrTableCell727 = XrTableCell182;
		location = new Point(391, 0);
		xrTableCell727.Location = location;
		XrTableCell182.Name = "XrTableCell182";
		XRTableCell xrTableCell728 = XrTableCell182;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell728.Padding = padding;
		XRTableCell xrTableCell729 = XrTableCell182;
		size = new Size(92, 25);
		xrTableCell729.Size = size;
		XrTableCell182.Text = "Seguro";
		XRTableCell xrTableCell730 = XrTableCell186;
		location = new Point(483, 0);
		xrTableCell730.Location = location;
		XrTableCell186.Name = "XrTableCell186";
		XRTableCell xrTableCell731 = XrTableCell186;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell731.Padding = padding;
		XRTableCell xrTableCell732 = XrTableCell186;
		size = new Size(91, 25);
		xrTableCell732.Size = size;
		XrTableCell186.Text = "N° Autogen.";
		XRTableCell xrTableCell733 = XrTableCell204;
		location = new Point(574, 0);
		xrTableCell733.Location = location;
		XrTableCell204.Name = "XrTableCell204";
		XRTableCell xrTableCell734 = XrTableCell204;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell734.Padding = padding;
		XRTableCell xrTableCell735 = XrTableCell204;
		size = new Size(76, 25);
		xrTableCell735.Size = size;
		XrTableCell204.Text = "Tipo Sangre";
		XRTable xrTable41 = XrTable18;
		location = new Point(50, 33);
		xrTable41.Location = location;
		XrTable18.Name = "XrTable18";
		XrTable18.Rows.AddRange(new XRTableRow[4] { XrTableRow41, XrTableRow42, XrTableRow43, XrTableRow44 });
		XRTable xrTable42 = XrTable18;
		size = new Size(600, 100);
		xrTable42.Size = size;
		XrTableRow41.Cells.AddRange(new XRTableCell[4] { XrTableCell128, XrTableCell151, XrTableCell152, XrTableCell153 });
		XrTableRow41.Name = "XrTableRow41";
		XRTableRow xrTableRow87 = XrTableRow41;
		size = new Size(600, 25);
		xrTableRow87.Size = size;
		XrTableCell128.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell736 = XrTableCell128;
		location = new Point(0, 0);
		xrTableCell736.Location = location;
		XrTableCell128.Name = "XrTableCell128";
		XRTableCell xrTableCell737 = XrTableCell128;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell737.Padding = padding;
		XrTableCell128.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell738 = XrTableCell128;
		size = new Size(258, 25);
		xrTableCell738.Size = size;
		XrTableCell128.Text = "Enfermedad Crónica o Discapacidad:";
		XrTableCell151.BookmarkParent = XrCheckBoxEnfCronica;
		XrTableCell151.Controls.AddRange(new XRControl[1] { XrCheckBoxEnfCronica });
		XRTableCell xrTableCell739 = XrTableCell151;
		location = new Point(258, 0);
		xrTableCell739.Location = location;
		XrTableCell151.Name = "XrTableCell151";
		XRTableCell xrTableCell740 = XrTableCell151;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell740.Padding = padding;
		XRTableCell xrTableCell741 = XrTableCell151;
		size = new Size(51, 25);
		xrTableCell741.Size = size;
		XrCheckBoxEnfCronica.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.enfercronica", "")
		});
		XRCheckBox xrCheckBoxEnfCronica = XrCheckBoxEnfCronica;
		location = new Point(5, 0);
		xrCheckBoxEnfCronica.Location = location;
		XrCheckBoxEnfCronica.Name = "XrCheckBoxEnfCronica";
		XRCheckBox xrCheckBoxEnfCronica2 = XrCheckBoxEnfCronica;
		size = new Size(33, 25);
		xrCheckBoxEnfCronica2.Size = size;
		XrTableCell152.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell742 = XrTableCell152;
		location = new Point(309, 0);
		xrTableCell742.Location = location;
		XrTableCell152.Name = "XrTableCell152";
		XRTableCell xrTableCell743 = XrTableCell152;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell743.Padding = padding;
		XrTableCell152.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell744 = XrTableCell152;
		size = new Size(66, 25);
		xrTableCell744.Size = size;
		XrTableCell152.Text = "Mencione:";
		XrTableCell153.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.enfercronicadescrip", "")
		});
		XRTableCell xrTableCell745 = XrTableCell153;
		location = new Point(375, 0);
		xrTableCell745.Location = location;
		XrTableCell153.Name = "XrTableCell153";
		XRTableCell xrTableCell746 = XrTableCell153;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell746.Padding = padding;
		XRTableCell xrTableCell747 = XrTableCell153;
		size = new Size(225, 25);
		xrTableCell747.Size = size;
		XrTableRow42.Cells.AddRange(new XRTableCell[4] { XrTableCell161, XrTableCell162, XrTableCell170, XrTableCell171 });
		XrTableRow42.Name = "XrTableRow42";
		XRTableRow xrTableRow88 = XrTableRow42;
		size = new Size(600, 25);
		xrTableRow88.Size = size;
		XrTableCell161.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell748 = XrTableCell161;
		location = new Point(0, 0);
		xrTableCell748.Location = location;
		XrTableCell161.Name = "XrTableCell161";
		XRTableCell xrTableCell749 = XrTableCell161;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell749.Padding = padding;
		XrTableCell161.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell750 = XrTableCell161;
		size = new Size(258, 25);
		xrTableCell750.Size = size;
		XrTableCell161.Text = "Miembros de su Familia con Discapacidad:";
		XrTableCell162.BookmarkParent = XrCheckBoxFamDisc;
		XrTableCell162.Controls.AddRange(new XRControl[1] { XrCheckBoxFamDisc });
		XRTableCell xrTableCell751 = XrTableCell162;
		location = new Point(258, 0);
		xrTableCell751.Location = location;
		XrTableCell162.Name = "XrTableCell162";
		XRTableCell xrTableCell752 = XrTableCell162;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell752.Padding = padding;
		XRTableCell xrTableCell753 = XrTableCell162;
		size = new Size(51, 25);
		xrTableCell753.Size = size;
		XrCheckBoxFamDisc.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.famdiscapacidad", "")
		});
		XRCheckBox xrCheckBoxFamDisc = XrCheckBoxFamDisc;
		location = new Point(4, 3);
		xrCheckBoxFamDisc.Location = location;
		XrCheckBoxFamDisc.Name = "XrCheckBoxFamDisc";
		XRCheckBox xrCheckBoxFamDisc2 = XrCheckBoxFamDisc;
		size = new Size(38, 17);
		xrCheckBoxFamDisc2.Size = size;
		XrTableCell170.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell754 = XrTableCell170;
		location = new Point(309, 0);
		xrTableCell754.Location = location;
		XrTableCell170.Name = "XrTableCell170";
		XRTableCell xrTableCell755 = XrTableCell170;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell755.Padding = padding;
		XrTableCell170.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell756 = XrTableCell170;
		size = new Size(66, 25);
		xrTableCell756.Size = size;
		XrTableCell170.Text = "Mencione:";
		XrTableCell171.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.famdiscapdescrip", "")
		});
		XRTableCell xrTableCell757 = XrTableCell171;
		location = new Point(375, 0);
		xrTableCell757.Location = location;
		XrTableCell171.Name = "XrTableCell171";
		XRTableCell xrTableCell758 = XrTableCell171;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell758.Padding = padding;
		XRTableCell xrTableCell759 = XrTableCell171;
		size = new Size(225, 25);
		xrTableCell759.Size = size;
		XrTableRow43.Cells.AddRange(new XRTableCell[4] { XrTableCell172, XrTableCell173, XrTableCell174, XrTableCell175 });
		XrTableRow43.Name = "XrTableRow43";
		XRTableRow xrTableRow89 = XrTableRow43;
		size = new Size(600, 25);
		xrTableRow89.Size = size;
		XrTableCell172.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell760 = XrTableCell172;
		location = new Point(0, 0);
		xrTableCell760.Location = location;
		XrTableCell172.Name = "XrTableCell172";
		XRTableCell xrTableCell761 = XrTableCell172;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell761.Padding = padding;
		XrTableCell172.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell762 = XrTableCell172;
		size = new Size(258, 25);
		xrTableCell762.Size = size;
		XrTableCell172.Text = "Es Alérgico a algún medicamento?";
		XrTableCell173.BookmarkParent = XrCheckBox1;
		XrTableCell173.Controls.AddRange(new XRControl[1] { XrCheckBox1 });
		XRTableCell xrTableCell763 = XrTableCell173;
		location = new Point(258, 0);
		xrTableCell763.Location = location;
		XrTableCell173.Name = "XrTableCell173";
		XRTableCell xrTableCell764 = XrTableCell173;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell764.Padding = padding;
		XRTableCell xrTableCell765 = XrTableCell173;
		size = new Size(51, 25);
		xrTableCell765.Size = size;
		XrCheckBox1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("CheckState", null, "spRRHH_Ficha_DatosPersonales.alergico", "")
		});
		XRCheckBox xrCheckBox = XrCheckBox1;
		location = new Point(4, 3);
		xrCheckBox.Location = location;
		XrCheckBox1.Name = "XrCheckBox1";
		XRCheckBox xrCheckBox2 = XrCheckBox1;
		size = new Size(38, 17);
		xrCheckBox2.Size = size;
		XrTableCell174.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell766 = XrTableCell174;
		location = new Point(309, 0);
		xrTableCell766.Location = location;
		XrTableCell174.Name = "XrTableCell174";
		XRTableCell xrTableCell767 = XrTableCell174;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell767.Padding = padding;
		XrTableCell174.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell768 = XrTableCell174;
		size = new Size(66, 25);
		xrTableCell768.Size = size;
		XrTableCell174.Text = "Mencione:";
		XrTableCell175.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.alergicodescrip", "")
		});
		XRTableCell xrTableCell769 = XrTableCell175;
		location = new Point(375, 0);
		xrTableCell769.Location = location;
		XrTableCell175.Name = "XrTableCell175";
		XRTableCell xrTableCell770 = XrTableCell175;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell770.Padding = padding;
		XRTableCell xrTableCell771 = XrTableCell175;
		size = new Size(225, 25);
		xrTableCell771.Size = size;
		XrTableRow44.Cells.AddRange(new XRTableCell[2] { XrTableCell176, XrTableCell178 });
		XrTableRow44.Name = "XrTableRow44";
		XRTableRow xrTableRow90 = XrTableRow44;
		size = new Size(600, 25);
		xrTableRow90.Size = size;
		XrTableCell176.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold);
		XRTableCell xrTableCell772 = XrTableCell176;
		location = new Point(0, 0);
		xrTableCell772.Location = location;
		XrTableCell176.Name = "XrTableCell176";
		XRTableCell xrTableCell773 = XrTableCell176;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell773.Padding = padding;
		XrTableCell176.ParentStyleUsing.UseFont = false;
		XRTableCell xrTableCell774 = XrTableCell176;
		size = new Size(258, 25);
		xrTableCell774.Size = size;
		XrTableCell176.Text = "Donde Acude en Caso de Enfermedad?";
		XrTableCell178.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "spRRHH_Ficha_DatosPersonales.AcudeEnfermDescrip", "")
		});
		XRTableCell xrTableCell775 = XrTableCell178;
		location = new Point(258, 0);
		xrTableCell775.Location = location;
		XrTableCell178.Name = "XrTableCell178";
		XRTableCell xrTableCell776 = XrTableCell178;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrTableCell776.Padding = padding;
		XRTableCell xrTableCell777 = XrTableCell178;
		size = new Size(342, 25);
		xrTableCell777.Size = size;
		XrLabel19.Font = new Font("Times New Roman", 9.75f, FontStyle.Bold | FontStyle.Underline);
		XRLabel xrLabel70 = XrLabel19;
		location = new Point(25, 8);
		xrLabel70.Location = location;
		XrLabel19.Name = "XrLabel19";
		XRLabel xrLabel71 = XrLabel19;
		padding = new PaddingInfo(2, 2, 0, 0, 100f);
		xrLabel71.Padding = padding;
		XrLabel19.ParentStyleUsing.UseFont = false;
		XRLabel xrLabel72 = XrLabel19;
		size = new Size(317, 17);
		xrLabel72.Size = size;
		XrLabel19.Text = "VI. ASPECTO SALUD";
		Bands.AddRange(new Band[10] { Detail, PageHeader, PageFooter, DetailReport, DetailReport1, DetailReport2, DetailReport3, DetailReport4, DetailReport5, DetailReport6 });
		DataAdapter = SpRRHH_Report_CuadroPerTableAdapter;
		DataMember = "spRRHH_Report_CuadroPer";
		DataSource = DataSet11;
		Margins = new Margins(100, 59, 100, 100);
		((ISupportInitialize)XrTable2).EndInit();
		((ISupportInitialize)DataSet11).EndInit();
		((ISupportInitialize)XrTable6).EndInit();
		((ISupportInitialize)XrTable4).EndInit();
		((ISupportInitialize)XrTable12).EndInit();
		((ISupportInitialize)XrTable13).EndInit();
		((ISupportInitialize)XrTable7).EndInit();
		((ISupportInitialize)XrTable22).EndInit();
		((ISupportInitialize)XrTable3).EndInit();
		((ISupportInitialize)XrTable1).EndInit();
		((ISupportInitialize)XrTable8).EndInit();
		((ISupportInitialize)XrTable10).EndInit();
		((ISupportInitialize)XrTable21).EndInit();
		((ISupportInitialize)XrTable14).EndInit();
		((ISupportInitialize)XrTable15).EndInit();
		((ISupportInitialize)XrTable11).EndInit();
		((ISupportInitialize)XrTable17).EndInit();
		((ISupportInitialize)XrTable16).EndInit();
		((ISupportInitialize)XrTable5).EndInit();
		((ISupportInitialize)XrTable20).EndInit();
		((ISupportInitialize)XrTable19).EndInit();
		((ISupportInitialize)XrTable18).EndInit();
		((ISupportInitialize)this).EndInit();
	}
}
