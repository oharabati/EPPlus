/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.FormulaParsing.Excel.Functions.MathFunctions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Logical;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Numeric;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;
using System.Globalization;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Statistical;
using OfficeOpenXml.FormulaParsing.Excel.Functions.MathFunctions;

namespace OfficeOpenXml.FormulaParsing.Excel.Functions
{
    public class BuiltInFunctions : FunctionsModule
    {
        /// <summary>
        /// 
        /// </summary>
        public BuiltInFunctions()
        {
            // Text
            Functions["len"] = new Len();
            Functions["lower"] = new Lower();
            Functions["upper"] = new Upper();
            Functions["left"] = new Left();
            Functions["right"] = new Right();
            Functions["mid"] = new Mid();
            Functions["replace"] = new Replace();
            Functions["rept"] = new Rept();
            Functions["substitute"] = new Substitute();
            Functions["concatenate"] = new Concatenate();
            Functions["concat"] = new Concat();
            Functions["textjoin"] = new Textjoin();
            Functions["char"] = new CharFunction();
            Functions["exact"] = new Exact();
            Functions["find"] = new Find();
            Functions["fixed"] = new Fixed();
            Functions["proper"] = new Proper();
            Functions["search"] = new Search();
            Functions["text"] = new Text.Text();
            Functions["t"] = new T();
            Functions["hyperlink"] = new Hyperlink();
            Functions["value"] = new Value(CultureInfo.CurrentCulture);
            Functions["trim"] = new Trim();
            Functions["clean"] = new Clean();
            Functions["unicode"] = new Unicode();
            Functions["unichar"] = new Unichar();
            Functions["numbervalue"] = new NumberValue();
            Functions["dollar"] = new Dollar();
            // Numbers
            Functions["int"] = new CInt();
            // Math
            Functions["aggregate"] = new Aggregate();
            Functions["abs"] = new Abs();
            Functions["asin"] = new Asin();
            Functions["asinh"] = new Asinh();
            Functions["acot"] = new Acot();
            Functions["acoth"] = new Acoth();
            Functions["cos"] = new Cos();
            Functions["cot"] = new Cot();
            Functions["coth"] = new Coth();
            Functions["cosh"] = new Cosh();
            Functions["csc"] = new Csc();
            Functions["csch"] = new Csch();
            Functions["power"] = new Power();
            Functions["gcd"] = new Gcd();
            Functions["lcm"] = new Lcm();
            Functions["sec"] = new Sec();
            Functions["sech"] = new SecH();
            Functions["sign"] = new Sign();
            Functions["sqrt"] = new Sqrt();
            Functions["sqrtpi"] = new SqrtPi();
            Functions["pi"] = new Pi();
            Functions["product"] = new Product();
            Functions["ceiling"] = new Ceiling();
            Functions["ceiling.precise"] = new CeilingPrecise();
            Functions["ceiling.math"] = new CeilingMath();
            Functions["iso.ceiling"] = new IsoCeiling();
            Functions["combin"] = new Combin();
            Functions["combina"] = new Combina();
            Functions["permut"] = new Permut();
            Functions["permutationa"] = new Permutationa();
            Functions["count"] = new Count();
            Functions["counta"] = new CountA();
            Functions["countblank"] = new CountBlank();
            Functions["countif"] = new CountIf();
            Functions["countifs"] = new CountIfs();
            Functions["fact"] = new Fact();
            Functions["factdouble"] = new FactDouble();
            Functions["floor"] = new Floor();
            Functions["floor.precise"] = new FloorPrecise();
            Functions["floor.math"] = new FloorMath();
            Functions["radians"] = new Radians();
            Functions["roman"] = new Roman();
            Functions["sin"] = new Sin();
            Functions["sinh"] = new Sinh();
            Functions["sum"] = new Sum();
            Functions["sumif"] = new SumIf();
            Functions["sumifs"] = new SumIfs();
            Functions["sumproduct"] = new SumProduct();
            Functions["sumsq"] = new Sumsq();
            Functions["sumxmy2"] = new Sumxmy2();
            Functions["sumx2my2"] = new SumX2mY2();
            Functions["sumx2py2"] = new SumX2pY2();
            Functions["seriessum"] = new Seriessum();
            Functions["stdev"] = new Stdev();
            Functions["stdeva"] = new Stdeva();
            Functions["stdevp"] = new StdevP();
            Functions["stdevpa"] = new Stdevpa();
            Functions["stdev.s"] = new StdevDotS();
            Functions["stdev.p"] = new StdevDotP();
            Functions["subtotal"] = new Subtotal();
            Functions["exp"] = new Exp();
            Functions["log"] = new Log();
            Functions["log10"] = new Log10();
            Functions["ln"] = new Ln();
            Functions["max"] = new Max();
            Functions["maxa"] = new Maxa();
            Functions["median"] = new Median();
            Functions["min"] = new Min();
            Functions["mina"] = new Mina();
            Functions["mod"] = new Mod();
            Functions["mode"] = new Mode();
            Functions["mode.sngl"] = new ModeSngl();
            Functions["mround"] = new Mround();
            Functions["multinomial"] = new Multinomial();
            Functions["average"] = new Average();
            Functions["averagea"] = new AverageA();
            Functions["averageif"] = new AverageIf();
            Functions["averageifs"] = new AverageIfs();
            Functions["round"] = new Round();
            Functions["rounddown"] = new Rounddown();
            Functions["roundup"] = new Roundup();
            Functions["rand"] = new Rand();
            Functions["randbetween"] = new RandBetween();
            Functions["randarray"] = new RandArray();
            Functions["rank"] = new Rank();
            Functions["rank.eq"] = new RankEq();
            Functions["rank.avg"] = new RankAvg();
            Functions["percentile"] = new Percentile();
            Functions["percentile.inc"] = new PercentileInc();
            Functions["percentile.exc"] = new PercentileExc();
            Functions["quartile"] = new Quartile();
            Functions["quartile.inc"] = new QuartileInc();
            Functions["quartile.exc"] = new QuartileExc();
            Functions["percentrank"] = new Percentrank();
            Functions["percentrank.inc"] = new PercentrankInc();
            Functions["percentrank.exc"] = new PercentrankExc();
            Functions["quotient"] = new Quotient();
            Functions["trunc"] = new Trunc();
            Functions["tan"] = new Tan();
            Functions["tanh"] = new Tanh();
            Functions["atan"] = new Atan();
            Functions["atan2"] = new Atan2();
            Functions["atanh"] = new Atanh();
            Functions["acos"] = new Acos();
            Functions["acosh"] = new Acosh();
            Functions["covar"] = new Covar();
            Functions["covariance.p"] = new CovarianceP();
            Functions["covariance.s"] = new CovarianceS();
            Functions["var"] = new Var();
            Functions["vara"] = new Vara();
            Functions["var.s"] = new VarDotS();
            Functions["varp"] = new VarP();
            Functions["varpa"] = new Varpa();
            Functions["var.p"] = new VarDotP();
            Functions["large"] = new Large();
            Functions["small"] = new Small();
            Functions["degrees"] = new Degrees();
            Functions["odd"] = new Odd();
            Functions["even"] = new Even();
            Functions["sequence"] = new Sequence();
            // Statistical
            Functions["confidence.norm"] = new ConfidenceNorm();
            Functions["confidence"] = new Confidence();
            Functions["confidence.t"] = new ConfidenceT();
            Functions["devsq"] = new Devsq();
            Functions["avedev"] = new Avedev();
            Functions["betadist"] = new Betadist();
            Functions["beta.dist"] = new BetaDotDist();
            Functions["betainv"] = new Betainv();
            Functions["beta.inv"] = new BetaDotInv();
            Functions["gamma"] = new Gamma();
            Functions["gammaln"] = new Gammaln();
            Functions["gammaln.precise"] = new GammalnPrecise();
            Functions["norminv"] = new NormInv();
            Functions["norm.inv"] = new NormDotInv();
            Functions["normsinv"] = new NormsInv();
            Functions["norm.s.inv"] = new NormDotSdotInv();
            Functions["normdist"] = new Normdist();
            Functions["normsdist"] = new Normsdist();
            Functions["norm.dist"] = new NormDotDist();
            Functions["norm.s.dist"] = new NormDotSdotDist();
            Functions["correl"] = new Correl();
            Functions["fisher"] = new Fisher();
            Functions["fisherinv"] = new FisherInv();
            Functions["frequency"] = new Frequency();
            Functions["geomean"] = new Geomean();
            Functions["harmean"] = new Harmean();
            Functions["pearson"] = new Pearson();
            Functions["phi"] = new Phi();
            Functions["rsq"] = new Rsq();
            Functions["skew"] = new Skew();
            Functions["skew.p"] = new SkewP();
            Functions["kurt"] = new Kurt();
            Functions["gauss"] = new Gauss();
            Functions["standardize"] = new Standardize();
            Functions["forecast"] = new Forecast();
            Functions["forecast.linear"] = new ForecastLinear();
            Functions["intercept"] = new Intercept();
            Functions["chidist"] = new ChiDist();
            Functions["chisq.dist.rt"] = new ChiSqDistRt();
            Functions["chisq.inv"] = new ChisqInv();
            Functions["chisq.inv.rt"] = new ChisqInvRt();
            Functions["chiinv"] = new ChiInv();
            Functions["chisq.test"] = new ChisqTest();
            Functions["expondist"] = new Expondist();
            Functions["expon.dist"] = new ExponDotDist();
            Functions["steyx"] = new Steyx();
            // Information
            Functions["isblank"] = new IsBlank();
            Functions["isnumber"] = new IsNumber();
            Functions["istext"] = new IsText();
            Functions["isnontext"] = new IsNonText();
            Functions["iserror"] = new IsError();
            Functions["iserr"] = new IsErr();
            Functions["error.type"] = new ErrorType();
            Functions["iseven"] = new IsEven();
            Functions["isodd"] = new IsOdd();
            Functions["islogical"] = new IsLogical();
            Functions["isna"] = new IsNa();
            Functions["na"] = new Na();
            Functions["n"] = new N();
            Functions["type"] = new TypeFunction();
            Functions["sheet"] = new Sheet();
            // Logical
            Functions["if"] = new If();
            Functions["ifs"] = new Ifs();
            Functions["maxifs"] = new MaxIfs();
            Functions["minifs"] = new MinIfs();
            Functions["iferror"] = new IfError();
            Functions["ifna"] = new IfNa();
            Functions["not"] = new Not();
            Functions["and"] = new And();
            Functions["or"] = new Or();
            Functions["true"] = new True();
            Functions["false"] = new False();
            Functions["switch"] = new Switch();
            Functions["xor"] = new Xor();
            // Reference and lookup
            Functions["address"] = new Address();
            Functions["hlookup"] = new HLookupV2();
            Functions["vlookup"] = new VLookupV2();
            Functions["xlookup"] = new Xlookup();
            Functions["lookup"] = new LookupV2();
            Functions["match"] = new MatchV2();
            Functions["xmatch"] = new XMatch();
            Functions["row"] = new Row();
            Functions["rows"] = new Rows();
            Functions["column"] = new Column();
            Functions["columns"] = new Columns();
            Functions["choose"] = new Choose();
            Functions["index"] = new RefAndLookup.Index();
            Functions["indirect"] = new Indirect();
            Functions["offset"] = new Offset();
            Functions["transpose"] = new Transpose();
            Functions["filter"] = new FilterFunction();
            Functions["sort"] = new SortFunction();
            Functions["sortby"] = new SortBy();
            Functions["unique"] = new Unique();
            Functions["anchorarray"] = new AnchorArray();
            Functions["single"] = new SingleFunction();
            Functions["drop"] = new Drop();
            Functions["take"] = new Take();
            Functions["torow"] = new ToRow();
            Functions["tocol"] = new ToCol();
            Functions["expand"] = new Expand();
            Functions["choosecols"] = new ChooseCols();
            Functions["chooserows"] = new ChooseRows();
            Functions["vstack"] = new Vstack();
            Functions["hstack"] = new Hstack();
            // Date
            Functions["date"] = new Date();
            Functions["datedif"] = new DateDif();
            Functions["today"] = new Today();
            Functions["now"] = new Now();
            Functions["day"] = new Day();
            Functions["month"] = new Month();
            Functions["year"] = new Year();
            Functions["time"] = new Time();
            Functions["hour"] = new Hour();
            Functions["minute"] = new Minute();
            Functions["second"] = new Second();
            Functions["weeknum"] = new Weeknum();
            Functions["weekday"] = new Weekday();
            Functions["days"] = new Days();
            Functions["days360"] = new Days360();
            Functions["yearfrac"] = new Yearfrac();
            Functions["edate"] = new Edate();
            Functions["eomonth"] = new Eomonth();
            Functions["isoweeknum"] = new IsoWeekNum();
            Functions["workday"] = new Workday();
            Functions["workday.intl"] = new WorkdayIntl();
            Functions["networkdays"] = new Networkdays();
            Functions["networkdays.intl"] = new NetworkdaysIntl();
            Functions["datevalue"] = new DateValue();
            Functions["timevalue"] = new TimeValue();
            // Database
            Functions["dget"] = new Dget();
            Functions["dcount"] = new Dcount();
            Functions["dcounta"] = new DcountA();
            Functions["dmax"] = new Dmax();
            Functions["dmin"] = new Dmin();
            Functions["dsum"] = new Dsum();
            Functions["daverage"] = new Daverage();
            Functions["dvar"] = new Dvar();
            Functions["dvarp"] = new Dvarp();
            //Finance
            Functions["accrint"] = new Accrint();
            Functions["accrintm"] = new AccrintM();
            Functions["cumipmt"] = new Cumipmt();
            Functions["cumprinc"] = new Cumprinc();
            Functions["dollarde"] = new DollarDe();
            Functions["dollarfr"] = new DollarFr();
            Functions["db"] = new Db();
            Functions["ddb"] = new Ddb();
            Functions["effect"] = new Effect();
            Functions["fvschedule"] = new FvSchedule();
            Functions["pduration"] = new Pduration();
            Functions["rri"] = new Rri();
            Functions["pmt"] = new Pmt();
            Functions["ppmt"] = new Ppmt();
            Functions["ipmt"] = new Ipmt();
            Functions["ispmt"] = new IsPmt();
            Functions["pv"] = new Pv();
            Functions["fv"] = new Fv();
            Functions["npv"] = new Npv();
            Functions["rate"] = new Rate();
            Functions["nper"] = new Nper();
            Functions["nominal"] = new Nominal();
            Functions["irr"] = new Irr();
            Functions["mirr"] = new Mirr();
            Functions["xirr"] = new Xirr();
            Functions["sln"] = new Sln();
            Functions["syd"] = new Syd();
            Functions["xnpv"] = new Xnpv();
            Functions["coupdays"] = new Coupdays();
            Functions["coupdaysnc"] = new Coupdaysnc();
            Functions["coupdaybs"] = new Coupdaybs();
            Functions["coupnum"] = new Coupnum();
            Functions["coupncd"] = new Coupncd();
            Functions["couppcd"] = new Couppcd();
            Functions["price"] = new Price();
            Functions["yield"] = new Yield();
            Functions["yieldmat"] = new Yieldmat();
            Functions["duration"] = new Duration();
            Functions["mduration"] = new Mduration();
            Functions["intrate"] = new Intrate();
            Functions["disc"] = new Disc();
            Functions["tbilleq"] = new Tbilleq();
            Functions["tbillprice"] = new TbillPrice();
            Functions["tbillyield"] = new TbillYield();
            //Engineering
            Functions["bitand"] = new BitAnd();
            Functions["bitor"] = new BitOr();
            Functions["bitxor"] = new BitXor();
            Functions["bitlshift"] = new BitLshift();
            Functions["bitrshift"] = new BitRshift();
            Functions["convert"] = new ConvertFunction();
            Functions["bin2dec"] = new Bin2Dec();
            Functions["bin2hex"] = new Bin2Hex();
            Functions["bin2oct"] = new Bin2Oct();
            Functions["dec2bin"] = new Dec2Bin();
            Functions["dec2hex"] = new Dec2Hex();
            Functions["dec2oct"] = new Dec2Oct();
            Functions["hex2bin"] = new Hex2Bin();
            Functions["hex2dec"] = new Hex2Dec();
            Functions["hex2oct"] = new Hex2Oct();
            Functions["oct2bin"] = new Oct2Bin();
            Functions["oct2dec"] = new Oct2Dec();
            Functions["oct2hex"] = new Oct2Hex();
            Functions["delta"] = new Delta();
            Functions["erf"] = new Erf();
            Functions["erf.precise"] = new ErfPrecise();
            Functions["erfc"] = new Erfc();
            Functions["erfc.precise"] = new ErfcPrecise();
            Functions["besseli"] = new BesselI();
            Functions["besselj"] = new BesselJ();
            Functions["besselk"] = new BesselK();
            Functions["bessely"] = new BesselY();
            Functions["complex"] = new Complex();
        }
    }
}
