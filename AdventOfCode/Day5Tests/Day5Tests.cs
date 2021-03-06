using Day5;
using FluentAssertions;
using System;
using Xunit;

namespace Day5Tests
{
	public class Day5Tests
	{
		[Fact]
		public void Test_Example()
		{
			// Assign
			var radar = new Radar();
			var inputs = new int[][]
			{
				new[]{0,9},new[]{5,9},
				new[]{8,0},new[]{0,8},
				new[]{9,4},new[]{3,4},
				new[]{2,2},new[]{2,1},
				new[]{7,0},new[]{7,4},
				new[]{6,4},new[]{2,0},
				new[]{0,9},new[]{2,9},
				new[]{3,4},new[]{1,4},
				new[]{0,0},new[]{8,8},
				new[]{5,5},new[]{8,2}
			};

			// Act
			for (var i = 0; i < inputs.GetLength(0); i += 2)
			{
				radar.AddInput((x: inputs[i][0], y: inputs[i][1]), (x: inputs[i+1][0], y: inputs[i+1][1]));
			}

			var result = radar.CountOverlap(2);

			// Assert
			result.Should().Be(5);
		}

		[Fact]
		public void Test_Example2()
		{
			// Assign
			var radar = new Radar(true);
			var inputs = new int[][]
			{
				new[]{0,9},new[]{5,9},
				new[]{8,0},new[]{0,8},
				new[]{9,4},new[]{3,4},
				new[]{2,2},new[]{2,1},
				new[]{7,0},new[]{7,4},
				new[]{6,4},new[]{2,0},
				new[]{0,9},new[]{2,9},
				new[]{3,4},new[]{1,4},
				new[]{0,0},new[]{8,8},
				new[]{5,5},new[]{8,2}
			};

			// Act
			for (var i = 0; i < inputs.GetLength(0); i += 2)
			{
				radar.AddInput((x: inputs[i][0], y: inputs[i][1]), (x: inputs[i + 1][0], y: inputs[i + 1][1]));
			}

			var result = radar.CountOverlap(2);

			// Assert
			result.Should().Be(12);
		}

		[Fact]
		public void Test1()
		{
			// Assign
			var radar1 = new Radar();
			var radar2 = new Radar(true);
			var inputs = new int[][]
			{
				new[]{541,808},new[]{108,808},
				new[]{982,23},new[]{45,960},
				new[]{558,21},new[]{558,318},
				new[]{907,877},new[]{43,13},
				new[]{532,213},new[]{532,801},
				new[]{599,387},new[]{870,387},
				new[]{762,208},new[]{78,208},
				new[]{739,527},new[]{739,907},
				new[]{64,21},new[]{64,958},
				new[]{258,267},new[]{929,938},
				new[]{22,75},new[]{725,778},
				new[]{347,950},new[]{347,345},
				new[]{705,906},new[]{61,906},
				new[]{53,16},new[]{950,913},
				new[]{468,474},new[]{475,481},
				new[]{567,602},new[]{914,602},
				new[]{570,531},new[]{570,530},
				new[]{180,307},new[]{180,823},
				new[]{546,374},new[]{390,374},
				new[]{750,142},new[]{861,31},
				new[]{586,631},new[]{905,950},
				new[]{971,680},new[]{784,680},
				new[]{428,174},new[]{352,174},
				new[]{825,676},new[]{228,676},
				new[]{630,617},new[]{70,617},
				new[]{156,912},new[]{944,124},
				new[]{805,203},new[]{25,983},
				new[]{726,808},new[]{726,96},
				new[]{986,564},new[]{908,642},
				new[]{594,293},new[]{594,458},
				new[]{182,126},new[]{182,476},
				new[]{979,43},new[]{35,987},
				new[]{642,272},new[]{642,446},
				new[]{759,690},new[]{891,690},
				new[]{951,518},new[]{161,518},
				new[]{357,769},new[]{336,769},
				new[]{904,297},new[]{904,533},
				new[]{326,332},new[]{326,316},
				new[]{758,356},new[]{654,460},
				new[]{432,425},new[]{432,819},
				new[]{31,602},new[]{31,421},
				new[]{318,555},new[]{898,555},
				new[]{326,220},new[]{777,671},
				new[]{708,957},new[]{708,273},
				new[]{26,24},new[]{974,972},
				new[]{341,172},new[]{341,394},
				new[]{33,926},new[]{864,95},
				new[]{486,324},new[]{486,704},
				new[]{850,82},new[]{132,800},
				new[]{62,506},new[]{113,506},
				new[]{816,429},new[]{816,141},
				new[]{184,17},new[]{184,328},
				new[]{40,680},new[]{30,670},
				new[]{640,294},new[]{127,807},
				new[]{654,512},new[]{654,296},
				new[]{722,301},new[]{629,301},
				new[]{255,430},new[]{811,430},
				new[]{376,385},new[]{376,379},
				new[]{227,207},new[]{227,947},
				new[]{363,533},new[]{757,533},
				new[]{150,616},new[]{150,284},
				new[]{943,100},new[]{79,964},
				new[]{275,963},new[]{275,461},
				new[]{409,768},new[]{409,574},
				new[]{516,349},new[]{516,656},
				new[]{19,666},new[]{847,666},
				new[]{962,358},new[]{962,907},
				new[]{781,789},new[]{781,870},
				new[]{778,380},new[]{501,657},
				new[]{895,29},new[]{12,912},
				new[]{12,677},new[]{12,761},
				new[]{614,728},new[]{690,652},
				new[]{415,786},new[]{778,423},
				new[]{683,84},new[]{683,574},
				new[]{973,909},new[]{75,11},
				new[]{854,791},new[]{260,197},
				new[]{965,55},new[]{559,55},
				new[]{624,542},new[]{235,153},
				new[]{924,57},new[]{16,965},
				new[]{540,736},new[]{540,65},
				new[]{293,293},new[]{929,293},
				new[]{587,176},new[]{587,432},
				new[]{389,126},new[]{389,590},
				new[]{267,149},new[]{92,149},
				new[]{424,596},new[]{697,323},
				new[]{412,697},new[]{773,697},
				new[]{473,579},new[]{310,416},
				new[]{149,175},new[]{837,863},
				new[]{848,984},new[]{159,295},
				new[]{608,613},new[]{292,613},
				new[]{344,970},new[]{546,970},
				new[]{589,531},new[]{589,74},
				new[]{220,727},new[]{220,831},
				new[]{651,240},new[]{318,240},
				new[]{717,609},new[]{847,479},
				new[]{917,954},new[]{327,364},
				new[]{780,102},new[]{228,654},
				new[]{201,95},new[]{201,921},
				new[]{403,88},new[]{403,79},
				new[]{755,76},new[]{755,529},
				new[]{654,762},new[]{654,97},
				new[]{957,988},new[]{44,75},
				new[]{899,43},new[]{51,891},
				new[]{855,892},new[]{175,212},
				new[]{295,962},new[]{613,962},
				new[]{284,800},new[]{946,800},
				new[]{494,771},new[]{793,472},
				new[]{212,799},new[]{212,784},
				new[]{25,829},new[]{824,30},
				new[]{277,135},new[]{396,135},
				new[]{981,986},new[]{187,192},
				new[]{794,88},new[]{308,88},
				new[]{425,140},new[]{73,140},
				new[]{155,900},new[]{155,500},
				new[]{339,768},new[]{339,621},
				new[]{720,407},new[]{824,303},
				new[]{746,679},new[]{746,490},
				new[]{672,632},new[]{30,632},
				new[]{74,628},new[]{49,628},
				new[]{534,770},new[]{249,485},
				new[]{59,802},new[]{605,256},
				new[]{481,543},new[]{723,301},
				new[]{163,425},new[]{947,425},
				new[]{10,782},new[]{779,782},
				new[]{185,851},new[]{68,968},
				new[]{536,479},new[]{536,217},
				new[]{987,472},new[]{960,472},
				new[]{802,623},new[]{202,23},
				new[]{548,73},new[]{548,838},
				new[]{711,678},new[]{711,655},
				new[]{91,578},new[]{91,162},
				new[]{803,27},new[]{31,27},
				new[]{198,524},new[]{282,608},
				new[]{45,585},new[]{45,973},
				new[]{741,157},new[]{317,581},
				new[]{263,843},new[]{819,843},
				new[]{240,786},new[]{240,272},
				new[]{453,148},new[]{657,148},
				new[]{646,74},new[]{646,758},
				new[]{367,521},new[]{367,185},
				new[]{355,356},new[]{503,356},
				new[]{306,780},new[]{41,780},
				new[]{783,779},new[]{513,779},
				new[]{81,886},new[]{81,531},
				new[]{403,592},new[]{69,926},
				new[]{575,458},new[]{575,709},
				new[]{406,695},new[]{406,563},
				new[]{342,690},new[]{269,690},
				new[]{712,766},new[]{712,693},
				new[]{929,608},new[]{929,355},
				new[]{562,750},new[]{571,759},
				new[]{353,780},new[]{424,780},
				new[]{296,111},new[]{944,759},
				new[]{341,28},new[]{859,28},
				new[]{415,28},new[]{415,153},
				new[]{104,16},new[]{966,878},
				new[]{554,780},new[]{726,780},
				new[]{749,645},new[]{749,466},
				new[]{188,724},new[]{933,724},
				new[]{806,185},new[]{614,185},
				new[]{244,181},new[]{682,181},
				new[]{104,937},new[]{367,937},
				new[]{400,116},new[]{183,333},
				new[]{749,94},new[]{301,542},
				new[]{638,543},new[]{811,716},
				new[]{694,727},new[]{694,44},
				new[]{46,259},new[]{46,721},
				new[]{467,748},new[]{620,595},
				new[]{739,543},new[]{391,543},
				new[]{734,454},new[]{734,101},
				new[]{200,954},new[]{200,654},
				new[]{592,358},new[]{592,581},
				new[]{758,29},new[]{758,401},
				new[]{386,685},new[]{519,685},
				new[]{538,294},new[]{298,294},
				new[]{82,269},new[]{766,269},
				new[]{840,114},new[]{332,114},
				new[]{924,542},new[]{185,542},
				new[]{936,311},new[]{369,878},
				new[]{820,724},new[]{590,724},
				new[]{277,689},new[]{68,689},
				new[]{76,634},new[]{167,634},
				new[]{255,503},new[]{144,503},
				new[]{753,915},new[]{753,27},
				new[]{288,329},new[]{513,554},
				new[]{729,297},new[]{447,297},
				new[]{128,533},new[]{128,530},
				new[]{252,718},new[]{856,114},
				new[]{947,498},new[]{312,498},
				new[]{142,917},new[]{950,109},
				new[]{815,845},new[]{770,845},
				new[]{863,98},new[]{332,98},
				new[]{927,694},new[]{927,276},
				new[]{682,232},new[]{227,687},
				new[]{640,474},new[]{840,274},
				new[]{98,37},new[]{98,149},
				new[]{203,170},new[]{99,170},
				new[]{736,956},new[]{736,539},
				new[]{686,384},new[]{882,580},
				new[]{976,152},new[]{380,748},
				new[]{80,859},new[]{80,208},
				new[]{687,252},new[]{687,748},
				new[]{819,978},new[]{101,260},
				new[]{17,722},new[]{17,306},
				new[]{99,96},new[]{99,929},
				new[]{713,757},new[]{157,201},
				new[]{469,986},new[]{469,393},
				new[]{813,210},new[]{789,186},
				new[]{360,319},new[]{360,43},
				new[]{777,707},new[]{606,707},
				new[]{928,413},new[]{380,961},
				new[]{566,850},new[]{828,850},
				new[]{380,650},new[]{717,650},
				new[]{863,889},new[]{373,399},
				new[]{521,97},new[]{967,97},
				new[]{12,989},new[]{975,26},
				new[]{965,974},new[]{965,848},
				new[]{639,331},new[]{639,948},
				new[]{815,731},new[]{235,151},
				new[]{823,369},new[]{610,369},
				new[]{22,930},new[]{898,54},
				new[]{635,113},new[]{635,495},
				new[]{462,123},new[]{771,123},
				new[]{445,274},new[]{304,133},
				new[]{743,633},new[]{43,633},
				new[]{811,267},new[]{811,936},
				new[]{745,549},new[]{636,549},
				new[]{321,720},new[]{511,530},
				new[]{949,138},new[]{308,138},
				new[]{563,34},new[]{720,191},
				new[]{449,313},new[]{966,830},
				new[]{857,308},new[]{392,773},
				new[]{244,80},new[]{820,80},
				new[]{212,345},new[]{327,460},
				new[]{28,941},new[]{28,22},
				new[]{122,988},new[]{122,50},
				new[]{51,889},new[]{880,60},
				new[]{328,161},new[]{328,820},
				new[]{703,639},new[]{40,639},
				new[]{107,47},new[]{839,779},
				new[]{338,260},new[]{828,750},
				new[]{947,304},new[]{276,975},
				new[]{509,281},new[]{281,281},
				new[]{200,42},new[]{820,662},
				new[]{728,940},new[]{728,897},
				new[]{511,770},new[]{376,635},
				new[]{197,99},new[]{929,99},
				new[]{699,648},new[]{352,301},
				new[]{915,291},new[]{256,950},
				new[]{641,586},new[]{641,346},
				new[]{337,722},new[]{965,722},
				new[]{739,92},new[]{739,884},
				new[]{656,676},new[]{649,676},
				new[]{369,450},new[]{686,450},
				new[]{33,672},new[]{409,296},
				new[]{336,979},new[]{336,595},
				new[]{95,289},new[]{888,289},
				new[]{286,128},new[]{985,827},
				new[]{471,300},new[]{899,300},
				new[]{824,959},new[]{66,201},
				new[]{884,104},new[]{166,822},
				new[]{562,681},new[]{562,948},
				new[]{987,974},new[]{77,64},
				new[]{61,47},new[]{61,528},
				new[]{359,647},new[]{709,647},
				new[]{34,398},new[]{270,398},
				new[]{526,66},new[]{257,335},
				new[]{744,545},new[]{502,787},
				new[]{805,726},new[]{728,803},
				new[]{184,749},new[]{184,839},
				new[]{136,148},new[]{842,148},
				new[]{538,244},new[]{306,476},
				new[]{202,698},new[]{958,698},
				new[]{264,519},new[]{903,519},
				new[]{367,310},new[]{26,310},
				new[]{391,747},new[]{307,831},
				new[]{580,945},new[]{706,945},
				new[]{199,776},new[]{98,776},
				new[]{408,242},new[]{408,474},
				new[]{929,706},new[]{929,570},
				new[]{351,524},new[]{221,524},
				new[]{773,783},new[]{274,783},
				new[]{770,790},new[]{770,653},
				new[]{572,182},new[]{572,574},
				new[]{979,13},new[]{29,963},
				new[]{175,454},new[]{457,736},
				new[]{170,399},new[]{170,202},
				new[]{570,406},new[]{97,406},
				new[]{813,37},new[]{556,37},
				new[]{80,886},new[]{465,501},
				new[]{317,799},new[]{876,799},
				new[]{602,399},new[]{362,639},
				new[]{891,257},new[]{445,257},
				new[]{346,275},new[]{297,275},
				new[]{345,136},new[]{345,755},
				new[]{252,460},new[]{252,731},
				new[]{17,573},new[]{729,573},
				new[]{901,838},new[]{230,167},
				new[]{754,582},new[]{754,970},
				new[]{415,964},new[]{415,605},
				new[]{857,758},new[]{857,612},
				new[]{319,613},new[]{256,613},
				new[]{34,614},new[]{34,802},
				new[]{443,118},new[]{443,891},
				new[]{335,300},new[]{80,45},
				new[]{284,340},new[]{552,608},
				new[]{154,31},new[]{33,31},
				new[]{440,720},new[]{20,720},
				new[]{331,219},new[]{311,219},
				new[]{163,83},new[]{868,788},
				new[]{775,733},new[]{775,284},
				new[]{859,240},new[]{859,159},
				new[]{144,249},new[]{105,210},
				new[]{710,809},new[]{710,910},
				new[]{76,481},new[]{76,86},
				new[]{825,603},new[]{916,603},
				new[]{404,575},new[]{740,575},
				new[]{612,427},new[]{612,571},
				new[]{63,765},new[]{63,538},
				new[]{979,170},new[]{183,966},
				new[]{781,372},new[]{911,372},
				new[]{237,732},new[]{321,648},
				new[]{457,474},new[]{954,971},
				new[]{887,110},new[]{551,446},
				new[]{894,962},new[]{48,116},
				new[]{276,534},new[]{800,534},
				new[]{40,42},new[]{950,952},
				new[]{986,941},new[]{123,78},
				new[]{348,857},new[]{899,857},
				new[]{57,728},new[]{57,802},
				new[]{776,536},new[]{776,462},
				new[]{683,618},new[]{683,443},
				new[]{468,914},new[]{750,914},
				new[]{420,129},new[]{984,693},
				new[]{254,913},new[]{166,913},
				new[]{832,737},new[]{832,422},
				new[]{472,724},new[]{12,724},
				new[]{483,916},new[]{483,226},
				new[]{206,751},new[]{206,250},
				new[]{890,901},new[]{20,31},
				new[]{156,198},new[]{883,925},
				new[]{972,367},new[]{67,367},
				new[]{409,196},new[]{320,196},
				new[]{59,188},new[]{815,188},
				new[]{856,856},new[]{856,756},
				new[]{84,871},new[]{942,13},
				new[]{475,91},new[]{475,784},
				new[]{363,578},new[]{363,405},
				new[]{219,976},new[]{219,717},
				new[]{243,25},new[]{243,173},
				new[]{115,194},new[]{462,194},
				new[]{91,960},new[]{889,162},
				new[]{20,957},new[]{915,62},
				new[]{60,955},new[]{250,765},
				new[]{882,707},new[]{267,92},
				new[]{122,626},new[]{122,202},
				new[]{705,74},new[]{147,632},
				new[]{418,122},new[]{976,680},
				new[]{500,522},new[]{936,522},
				new[]{715,652},new[]{82,19},
				new[]{118,872},new[]{118,479},
				new[]{918,70},new[]{918,811},
				new[]{968,968},new[]{347,347},
				new[]{985,479},new[]{587,877},
				new[]{749,259},new[]{749,841},
				new[]{475,102},new[]{200,102},
				new[]{808,976},new[]{515,976},
				new[]{761,726},new[]{761,358},
				new[]{778,523},new[]{729,474},
				new[]{266,251},new[]{396,251},
				new[]{46,921},new[]{914,921},
				new[]{384,424},new[]{804,844},
				new[]{442,359},new[]{646,155},
				new[]{929,774},new[]{920,783},
				new[]{344,958},new[]{344,281},
				new[]{33,173},new[]{607,173},
				new[]{40,125},new[]{897,982},
				new[]{345,640},new[]{432,640},
				new[]{845,170},new[]{403,612},
				new[]{763,84},new[]{763,885},
				new[]{855,388},new[]{123,388},
				new[]{861,858},new[]{861,940},
				new[]{449,736},new[]{97,384},
				new[]{576,592},new[]{906,262},
				new[]{868,817},new[]{868,633},
				new[]{14,100},new[]{610,696},
				new[]{878,412},new[]{416,412},
				new[]{43,427},new[]{118,502},
				new[]{250,829},new[]{770,829},
				new[]{814,444},new[]{814,769},
				new[]{647,857},new[]{528,857},
				new[]{648,102},new[]{514,102},
				new[]{956,12},new[]{887,12},
				new[]{665,957},new[]{665,891},
				new[]{760,367},new[]{178,949},
				new[]{704,524},new[]{815,524},
				new[]{269,88},new[]{322,88},
				new[]{414,881},new[]{414,788},
				new[]{550,696},new[]{550,788},
				new[]{624,367},new[]{391,367},
				new[]{133,536},new[]{432,835},
				new[]{635,154},new[]{169,154},
				new[]{396,149},new[]{396,166},
				new[]{796,505},new[]{886,505},
				new[]{348,235},new[]{530,235},
				new[]{428,851},new[]{240,851},
				new[]{535,441},new[]{637,441},
				new[]{661,175},new[]{782,175},
				new[]{589,780},new[]{99,290},
				new[]{771,746},new[]{771,239},
				new[]{16,567},new[]{821,567},
				new[]{320,572},new[]{320,136},
				new[]{200,990},new[]{513,990},
				new[]{984,987},new[]{11,14},
				new[]{60,712},new[]{60,137},
				new[]{629,405},new[]{738,405},
				new[]{541,536},new[]{541,225},
				new[]{250,579},new[]{507,579},
				new[]{825,264},new[]{974,264},
				new[]{380,832},new[]{262,832},
				new[]{598,695},new[]{598,159},
				new[]{716,782},new[]{418,782},
				new[]{124,698},new[]{713,698},
				new[]{930,83},new[]{212,801},
				new[]{389,287},new[]{344,287},
				new[]{571,788},new[]{106,788},
				new[]{519,498},new[]{135,114},
				new[]{281,761},new[]{221,761},
				new[]{295,133},new[]{295,654},
				new[]{686,960},new[]{592,960},
				new[]{984,495},new[]{984,913},
				new[]{677,751},new[]{677,102},
				new[]{252,326},new[]{252,824},
				new[]{921,500},new[]{357,500},
				new[]{608,908},new[]{608,381},
				new[]{587,878},new[]{587,677},
				new[]{392,929},new[]{449,929},
				new[]{239,444},new[]{822,444},
				new[]{87,897},new[]{252,897},
				new[]{865,887},new[]{368,887},
				new[]{368,934},new[]{368,308},
				new[]{64,950},new[]{182,950},
				new[]{747,429},new[]{636,540},
				new[]{378,109},new[]{378,865},
				new[]{187,266},new[]{856,935},
				new[]{159,769},new[]{708,769},
				new[]{71,119},new[]{892,940},
				new[]{629,825},new[]{87,283},
				new[]{900,903},new[]{900,656},
				new[]{749,703},new[]{812,703},
				new[]{225,421},new[]{842,421},
				new[]{15,896},new[]{837,74},
				new[]{800,887},new[]{58,145},
				new[]{456,798},new[]{679,798},
				new[]{434,963},new[]{434,166},
				new[]{508,491},new[]{976,959},
				new[]{809,540},new[]{809,614},
				new[]{624,632},new[]{975,983},
				new[]{733,102},new[]{195,640},
				new[]{83,691},new[]{623,151},
				new[]{140,257},new[]{29,257},
				new[]{429,934},new[]{429,482},
				new[]{702,91},new[]{702,137},
				new[]{986,185},new[]{986,386},
				new[]{84,920},new[]{448,920},
				new[]{927,779},new[]{927,679},
				new[]{903,345},new[]{546,345},
				new[]{303,523},new[]{303,862},
				new[]{360,877},new[]{360,202},
				new[]{544,593},new[]{544,802},
				new[]{27,192},new[]{27,837},
				new[]{105,24},new[]{574,24},
				new[]{955,783},new[]{556,384},
				new[]{416,85},new[]{416,322},
				new[]{923,139},new[]{553,139},
				new[]{527,523},new[]{828,523},
				new[]{788,320},new[]{949,320},
				new[]{391,652},new[]{391,166},
				new[]{754,378},new[]{607,378},
				new[]{563,409},new[]{563,27},
				new[]{285,169},new[]{285,883},
				new[]{16,10},new[]{988,982},
				new[]{452,563},new[]{452,479},
				new[]{881,800},new[]{881,542},
				new[]{564,272},new[]{457,272},
				new[]{887,441},new[]{887,298},
				new[]{941,837},new[]{119,15},
				new[]{606,137},new[]{606,152},
				new[]{135,472},new[]{135,322},
				new[]{881,775},new[]{881,132},
				new[]{566,263},new[]{406,103},
				new[]{912,696},new[]{912,965},
				new[]{123,554},new[]{123,911},
				new[]{735,737},new[]{533,939},
				new[]{61,197},new[]{534,197},
				new[]{91,856},new[]{91,465},
				new[]{624,411},new[]{624,247},
				new[]{607,899},new[]{607,786},
				new[]{139,408},new[]{466,735},
				new[]{89,274},new[]{545,730}
			};

			// Act
			for (var i = 0; i < inputs.GetLength(0); i += 2)
			{
				radar1.AddInput((x: inputs[i][0], y: inputs[i][1]), (x: inputs[i + 1][0], y: inputs[i + 1][1]));
				radar2.AddInput((x: inputs[i][0], y: inputs[i][1]), (x: inputs[i + 1][0], y: inputs[i + 1][1]));
			}

			// Assert
			var result1 = radar1.CountOverlap(2);
			var result2 = radar2.CountOverlap(2);
		}
	}
}