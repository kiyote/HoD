﻿namespace HeartOfDarkness.Client.Data;

internal sealed class StaticMapDefinitionProvider : IMapDefinitionProvider {

	private readonly MapDefinition _mapDefinition =
		new MapDefinition(
			new ImageDefinition(
				"img/HOD_map.png",
				1904,
				2931
			),
			[
				"Mocambique",
				"Angola",
				"Fernando Poo",
				"Zanzibar",
				"Khartoum"
			],
			[
				new RegionDefinition(
					Id: "Mocambique",
					Shape: "1331,2613,1338,2469,1328,2448,1358,2381,1404,2314,1444,2314,1466,2277,1457,2211,1479,2163,1619,2149,1589,2188,1540,2230,1498,2233,1501,2285,1530,2364,1535,2448,1511,2522,1392,2561,1368,2588,1373,2637,1341,2638",
					Token: "",
					AdjacentRegionIds: [
						"Ndebele",
						"Shona"
						]
				),
				new RegionDefinition(
					Id: "Angola",
					Shape: "206,1381,233,1376,260,1382,287,1391,320,1423,356,1623,369,1687,354,1722,332,1739,324,1714,304,1677,282,1618,300,1601,287,1547,236,1461",
					Token: "",
					AdjacentRegionIds: [
						"Kongo",
						"Kimbundu"
						]
				),
				new RegionDefinition(
					Id: "Fernando Poo",
					Shape: "43,787,97,789,127,822,174,851,140,876,132,942,137,965,85,964,100,908,85,869,56,859,29,827",
					Token: "",
					AdjacentRegionIds: [
						"Bamileke",
						"Fang"
						]
				),
				new RegionDefinition(
					Id: "Zanzibar",
					Shape: "1706,1581,1688,1559,1732,1508,1764,1423,1752,1397,1774,1362,1757,1359,1764,1302,1817,1328,1782,1397,1770,1463,1812,1498,1787,1581",
					Token: "",
					AdjacentRegionIds: [
						"Kikuyu",
						"Hehe"
						]
				),
				new RegionDefinition(
					Id: "Khartoum",
					Shape: "1385,437,1350,343,1357,239,1378,153,1377,57,1436,55,1484,77,1545,150,1626,200,1626,254,1605,269,1595,399,1543,380,1523,351,1479,350,1442,358,1410,372,1402,400",
					Token: "1480,230",
					AdjacentRegionIds: [
						"Kababish",
						"Nuer"
						]
				),
				new RegionDefinition(
					Id: "Nuer",
					Shape: "1525,360,1535,383,1587,404,1589,429,1594,473,1555,486,1543,526,1552,584,1503,575,1447,584,1429,639,1395,652,1345,617,1284,610,1244,580,1235,540,1254,511,1308,511,1326,476,1355,456,1387,449,1397,415,1412,380,1447,365,1473,355",
					Token: "",
					AdjacentRegionIds: [
						"Kababish",
						"Khartoum",
						"Oromo",
						"Murle",
						"Dinka"
						]
				),
				new RegionDefinition(
					Id: "Oromo",
					Shape: "1555,508,1562,486,1599,473,1609,479,1624,473,1669,483,1720,506,1730,520,1767,540,1802,540,1816,536,1849,577,1841,604,1811,614,1809,649,1831,669,1843,663,1858,671,1863,765,1831,785,1799,758,1785,733,1748,718,1737,748,1715,762,1688,725,1649,723,1602,731,1563,710,1528,664,1557,647,1621,657,1642,647,1629,627,1597,612,1573,609,1548,587,1542,526",
					Token: "",
					AdjacentRegionIds: [
						"Nuer",
						"Murle",
						"Somali"
						]
				),
				new RegionDefinition(
					Id: "Kababish",
					Shape: "1146,55,1161,57,1161,39,1192,39,1222,29,1272,29,1301,35,1333,35,1343,54,1375,52,1370,111,1377,136,1353,214,1346,274,1343,318,1360,400,1380,444,1355,451,1331,464,1308,494,1298,478,1252,469,1190,474,1178,449,1180,387,1175,341,1166,272,1161,200",
					Token: "",
					AdjacentRegionIds: [
						"Bideyat",
						"Zaghawa",
						"Dinka",
						"Nuer",
						"Khartoum"
						]
				),
				new RegionDefinition(
					Id: "Murle",
					Shape: "1452,587,1501,572,1550,584,1565,609,1595,614,1621,624,1636,647,1624,656,1558,642,1530,661,1560,706,1600,731,1654,720,1683,721,1708,765,1659,770,1639,795,1614,797,1600,826,1547,799,1513,800,1474,822,1437,805,1439,790,1392,768,1373,725,1383,679,1394,654,1425,639",
					Token: "",
					AdjacentRegionIds: [
						"Nuer",
						"Oromo",
						"Somali",
						"Turkana",
						"Dinka"
						]
				),
				new RegionDefinition(
					Id: "Bideyat",
					Shape: "759,40,793,34,794,55,816,55,836,39,875,35,936,37,936,50,959,50,988,25,1050,35,1119,35,1134,55,1143,67,1166,283,1018,304,997,261,919,222,889,237,889,252,864,284,823,257,793,225,753,209",
					Token: "",
					AdjacentRegionIds: [
						"Daza",
						"Fur",
						"Zaghawa",
						"Kababish"
						]
				),
				new RegionDefinition(
					Id: "Daza",
					Shape: "754,203,645,252,484,319,438,259,435,223,420,203,394,201,297,153,258,156,241,146,189,141,171,144,127,153,182,77,238,47,268,32,366,27,457,25,480,30,547,32,551,53,576,74,593,79,596,39,616,32,621,49,642,50,665,64,689,66,687,39,758,37",
					Token: "",
					AdjacentRegionIds: [
						"Kanembu",
						"Bagirmi",
						"Fur",
						"Bideyat"
						]
				),
				new RegionDefinition(
					Id: "Kanembu",
					Shape: "93,175,124,151,193,138,241,143,255,156,299,153,389,203,416,205,430,225,435,266,475,313,465,338,485,368,465,388,423,385,398,405,373,383,334,368,334,348,304,323,283,293,283,262,251,254,250,276,228,284,105,234,78,229,46,244,58,202,90,192",
					Token: "",
					AdjacentRegionIds: [
						"Daza",
						"Bagirmi",
						"Fulani",
						"Kanuri"
						]
				),
				new RegionDefinition(
					Id: "Kanuri",
					Shape: "58,239,56,274,41,276,28,313,43,321,34,425,41,434,82,402,87,412,122,444,145,483,203,493,213,467,214,447,270,427,283,377,283,345,299,326,285,296,282,264,253,256,253,281,226,288,188,271,114,240,80,230",
					Token: "",
					AdjacentRegionIds: [
						"Kanembu",
						"Fulani",
						"Bamileke"
						]
				),
				new RegionDefinition(
					Id: "Fur",
					Shape: "584,276,748,203,791,225,859,286,887,261,889,239,924,224,992,261,1012,299,1035,341,980,372,923,382,869,404,852,454,889,484,931,494,931,548,907,553,897,587,837,573,786,572,768,506,724,504,657,478,627,473,637,447,600,412,618,351,627,321",
					Token: "",
					AdjacentRegionIds: [
						"Daza",
						"Bideyat",
						"Zaghawa",
						"Banda",
						"Bagirmi"
						]
				),
				new RegionDefinition(
					Id: "Zaghawa",
					Shape: "1018,309,1161,288,1177,373,1171,444,1187,473,1086,474,1055,496,1057,547,1050,557,1025,540,1010,567,1017,607,995,610,899,592,907,557,939,550,934,491,889,481,859,456,874,410,919,385,978,373,1035,343",
					Token: "",
					AdjacentRegionIds: [
						"Bideyat",
						"Kababish",
						"Dinka",
						"Banda",
						"Fur"
						]

				),
				new RegionDefinition(
					Id: "Bagirmi",
					Shape: "468,333,581,277,623,318,596,414,635,444,627,464,664,483,722,504,763,503,780,572,706,597,596,641,590,621,428,540,438,506,420,461,378,447,368,432,415,415,399,402,423,387,479,378,484,356",
					Token: "",
					AdjacentRegionIds: [
						"Kanembu",
						"Daza",
						"Fur",
						"Banda",
						"Nbaka",
						"Fulani"
						]

				),
				new RegionDefinition(
					Id: "Dinka",
					Shape: "1082,478,1220,478,1247,467,1296,479,1304,508,1256,508,1240,528,1235,550,1244,578,1271,605,1345,619,1392,652,1372,720,1390,768,1442,790,1434,805,1466,819,1439,841,1392,839,1365,866,1331,841,1304,826,1272,822,1234,822,1195,757,1148,700,1104,785,1087,795,1072,789,1074,748,1060,713,1027,694,1029,652,1018,612,1008,572,1023,547,1050,560,1059,536,1055,498",
					Token: "",
					AdjacentRegionIds: [
						"Zaghawa",
						"Kababish",
						"Nuer",
						"Murle",
						"Turkana",
						"Zande",
						"Banda"
						]
				),
				new RegionDefinition(
					Id: "Banda",
					Shape: "1017,614,1025,654,1025,694,965,716,936,731,906,760,849,758,781,789,743,794,736,782,665,758,623,775,605,775,608,755,600,720,647,696,657,679,637,669,611,671,596,683,590,639,642,627,729,594,790,578,847,575",
					Token: "",
					AdjacentRegionIds: [
						"Bagirmi",
						"Fur",
						"Zaghawa",
						"Dinka",
						"Zande",
						"Ngbaka"
						]
				),
				new RegionDefinition(
					Id: "Ngbaka",
					Shape: "421,540,406,568,426,609,403,678,452,694,470,713,507,720,521,774,529,822,547,829,544,854,569,881,584,918,627,928,672,925,712,898,724,864,759,859,786,879,833,859,827,844,875,802,896,784,899,763,850,757,795,784,743,797,733,779,667,758,625,777,606,768,608,747,601,718,647,700,657,683,640,671,615,668,596,678,583,617",
					Token: "",
					AdjacentRegionIds: [
						"Bagirmi",
						"Banda",
						"Zande",
						"Mongo",
						"Bangi",
						"Baya",
						"Fulani"
						]
				),
				new RegionDefinition(
					Id: "Fulani",
					Shape: "304,328,278,346,278,424,208,449,201,494,166,597,147,614,151,639,142,691,214,708,250,711,278,713,278,694,325,698,364,676,401,676,426,609,406,572,435,510,420,464,374,449,362,434,411,414,354,373,332,368,332,346",
					Token: "",
					AdjacentRegionIds: [
						"Kanembu",
						"Bagirmi",
						"Ngbaka",
						"Baya",
						"Bamileke",
						"Kanuri"
						]

				),
				new RegionDefinition(
					Id: "Bamileke",
					Shape: "82,404,41,434,56,457,46,476,36,489,41,518,41,543,53,567,56,589,50,609,45,669,53,681,45,713,41,790,55,787,93,787,157,832,172,797,199,794,277,802,309,777,302,725,270,711,208,710,142,688,154,634,140,615,162,595,199,498,142,484,127,452",
					Token: "",
					AdjacentRegionIds: [
						"Kanuri",
						"Fulani",
						"Baya",
						"Fang",
						"Fernando Poo"
						]
				),
				new RegionDefinition(
					Id: "Fang",
					Shape: "184,791,259,806,250,842,243,886,284,946,290,1018,275,1050,243,1042,198,1055,174,1074,107,1081,73,1079,63,1059,85,1064,87,1044,102,1033,72,1027,94,968,146,968,136,938,144,886,183,867,184,845,163,830",
					Token: "",
					AdjacentRegionIds: [
						"Fernando Poo",
						"Bamileke",
						"Baya",
						"Mpongwe"
						]
				),
				new RegionDefinition(
					Id: "Baya",
					Shape: "285,700,331,696,362,671,405,678,453,696,465,713,502,718,521,762,494,768,480,799,447,799,418,797,394,804,369,812,359,856,384,896,405,928,389,974,433,989,455,1054,399,1085,388,1115,327,1110,258,1140,236,1108,246,1069,268,1069,275,1049,294,1019,283,947,246,885,255,800,277,805,314,782,307,725,278,715",
					Token: "",
					AdjacentRegionIds: [
						"Fulani",
						"Ngbaka",
						"Bangi",
						"Teke",
						"Mpngwe",
						"Fang",
						"Bamileke"
						]
				),
				new RegionDefinition(
					Id: "Bangi",
					Shape: "369,812,420,797,480,800,492,768,521,767,524,817,544,829,544,859,566,879,586,920,627,928,669,925,670,967,647,990,618,1061,606,1073,579,1071,574,1051,546,1056,541,1100,512,1152,485,1165,453,1170,410,1132,389,1112,399,1078,457,1049,455,1029,438,995,393,972,408,935,386,890,362,858",
					Token: "",
					AdjacentRegionIds: [
						"Ngbaka",
						"Mongo",
						"Bushongo",
						"Teke",
						"Baya"
						]
				),
				new RegionDefinition(
					Id: "Zande",
					Shape: "1029,699,1060,709,1074,745,1067,783,1081,790,1104,782,1150,709,1197,761,1224,824,1298,827,1341,857,1358,874,1338,889,1296,913,1303,955,1286,973,1257,988,1256,1014,1240,1009,1227,982,1165,967,1150,1005,1131,1015,1094,1024,1054,1017,1025,1029,1005,1022,1018,995,1005,982,990,967,1013,951,1003,913,1013,888,1040,876,1030,852,1013,847,949,864,938,894,918,898,884,901,862,913,847,883,837,859,833,842,899,782,911,756,949,719",
					Token: "",
					AdjacentRegionIds: [
						"Ngbaka",
						"Banda",
						"Dinka",
						"Turkana",
						"Baganda",
						"Kumu",
						"Mongo"
						]
				),
				new RegionDefinition(
					Id: "Turkana",
					Shape: "1394,834,1439,836,1511,804,1540,800,1595,826,1626,896,1626,950,1616,984,1560,962,1545,969,1505,997,1474,987,1437,980,1368,990,1351,962,1308,962,1301,911,1368,874",
					Token: "",
					AdjacentRegionIds: [
						"Murle",
						"Somali",
						"Maasai",
						"Baganda",
						"Zande",
						"Dinka"
						]
				),
				new RegionDefinition(
					Id: "Somali",
					Shape: "1750,720,1779,733,1806,762,1833,790,1864,770,1868,797,1853,816,1846,837,1861,853,1853,871,1864,896,1861,948,1849,962,1851,999,1871,1038,1864,1138,1846,1138,1851,1160,1863,1165,1873,1239,1851,1254,1838,1191,1821,1133,1787,1085,1767,1064,1747,1029,1705,1029,1691,987,1701,933,1671,927,1634,908,1604,831,1616,805,1642,797,1661,775,1710,765,1742,750",
					Token: "",
					AdjacentRegionIds: [
						"Oromo",
						"Kikuyu",
						"Maasai",
						"Turkana",
						"Murle"
						]
				),
				new RegionDefinition(
					Id: "Mongo",
					Shape: "727,867,762,860,789,882,836,862,867,915,890,897,929,899,961,860,1008,852,1030,858,1038,877,1018,889,1005,926,1003,952,993,968,1006,996,1008,1021,1023,1031,998,1058,947,1037,900,1075,907,1129,892,1166,803,1173,751,1163,698,1144,658,1121,624,1124,614,1068,648,991,675,966,678,922,719,897",
					Token: "",
					AdjacentRegionIds: [
						"Ngbaka",
						"Zande",
						"Kumu",
						"Songye",
						"Bushongo",
						"Bangi"
						]
				),
				new RegionDefinition(
					Id: "Mpongwe",
					Shape: "24,1140,48,1143,56,1090,97,1085,164,1071,206,1053,233,1046,268,1051,263,1066,238,1073,228,1101,251,1140,223,1157,211,1223,233,1223,248,1261,169,1283,164,1307,124,1288,95,1253,117,1243,98,1228,75,1226,56,1202,71,1186,48,1174,26,1162",
					Token: "",
					AdjacentRegionIds: [
						"Fang",
						"Baya",
						"Teke",
						"Kongo"
						]
				),
				new RegionDefinition(
					Id: "Teke",
					Shape: "218,1214,223,1159,324,1113,389,1115,421,1154,445,1169,489,1169,522,1169,547,1192,571,1217,509,1236,489,1258,517,1325,472,1355,455,1377,425,1370,369,1355,322,1298,300,1280,288,1258,248,1260",
					Token: "",
					AdjacentRegionIds: [
						"Baya",
						"Bangi",
						"Bushongo",
						"Mbala",
						"Kongo",
						"Mpongwe"
						]

				),
				new RegionDefinition(
					Id: "Kongo",
					Shape: "176,1283,238,1266,285,1263,334,1312,364,1359,431,1374,452,1401,458,1438,482,1497,460,1508,462,1532,420,1547,389,1562,349,1552,342,1495,324,1426,312,1401,282,1381,241,1377,233,1370,206,1372,203,1350,182,1345,171,1320",
					Token: "",
					AdjacentRegionIds: [
						"Teke",
						"Mbala",
						"Kimbundu",
						"Angola",
						"Mpongwe"
						]
				),
				new RegionDefinition(
					Id: "Bushongo",
					Shape: "550,1063,578,1055,578,1075,610,1070,617,1124,647,1120,688,1149,777,1176,779,1300,832,1332,878,1332,858,1369,871,1413,780,1388,713,1430,674,1411,620,1388,580,1327,520,1320,494,1265,506,1240,568,1225,528,1167,474,1171,519,1143,547,1098",
					Token: "",
					AdjacentRegionIds: [
						"Mongo",
						"Songye",
						"Lunda",
						"Mbala",
						"Teke",
						"Bangi"
						]
				),
				new RegionDefinition(
					Id: "Songye",
					Shape: "785,1171,882,1171,919,1171,944,1156,944,1177,971,1183,1012,1183,1030,1157,1055,1186,1077,1191,1089,1216,1055,1231,1054,1287,1076,1282,1097,1325,1096,1367,1084,1404,1045,1408,976,1457,943,1457,887,1478,882,1411,864,1373,877,1324,837,1327,783,1300",
					Token: "",
					AdjacentRegionIds: [
						"Mongo",
						"Kumu",
						"Bahutu",
						"Buye",
						"Luba",
						"Lunda",
						"Bushongo"
						]
				),
				new RegionDefinition(
					Id: "Kumu",
					Shape: "889,1167,903,1126,899,1069,935,1041,995,1054,1026,1029,1047,1019,1093,1025,1147,1000,1157,973,1212,977,1229,1009,1249,1010,1248,1067,1224,1120,1160,1084,1118,1143,1094,1158,1079,1189,1056,1192,1032,1150,999,1182,970,1178,943,1172,941,1152,920,1165",
					Token: "",
					AdjacentRegionIds: [
						"Zande",
						"Baganda",
						"Bahutu",
						"Songye",
						"Mongo"
						]
				),
				new RegionDefinition(
					Id: "Baganda",
					Shape: "1302,961,1344,962,1358,996,1417,991,1445,972,1477,987,1503,1013,1528,1038,1491,1048,1481,1085,1476,1127,1459,1149,1398,1151,1355,1107,1314,1103,1329,1144,1309,1171,1252,1171,1198,1154,1233,1124,1259,1066,1252,1021,1264,992",
					Token: "",
					AdjacentRegionIds: [
						"Turkana",
						"Maasai",
						"Nyamwesi",
						"Bahutu",
						"Kumu",
						"Zande"
						]
				),
				new RegionDefinition(
					Id: "Maasai",
					Shape: "1505,1006,1530,987,1558,962,1614,974,1627,942,1627,903,1649,915,1700,930,1691,989,1705,1024,1690,1034,1683,1064,1647,1071,1621,1157,1649,1186,1706,1211,1738,1226,1674,1239,1669,1302,1703,1347,1688,1372,1666,1392,1624,1389,1622,1335,1589,1275,1538,1285,1545,1249,1531,1216,1558,1184,1531,1140,1513,1159,1466,1150,1483,1128,1481,1083,1488,1044,1523,1034",
					Token: "",
					AdjacentRegionIds: [
						"Somali",
						"Kikuyu",
						"Hehe",
						"Nyamwesi",
						"Baganda",
						"Turkana"
						]
				),
				new RegionDefinition(
					Id: "Bahutu",
					Shape: "1158,1090,1227,1118,1195,1149,1261,1172,1316,1175,1311,1233,1304,1265,1331,1280,1321,1339,1301,1369,1254,1387,1234,1310,1175,1305,1109,1327,1077,1283,1054,1285,1050,1231,1084,1228,1077,1194,1091,1167,1136,1137",
					Token: "",
					AdjacentRegionIds: [
						"Baganda",
						"Nyamwesi",
						"Buye",
						"Songye",
						"Kumu"
						]
				),
				new RegionDefinition(
					Id: "Kikuyu",
					Shape: "1681,1066,1700,1033,1745,1036,1760,1063,1814,1124,1848,1230,1844,1253,1854,1265,1822,1322,1784,1299,1762,1300,1747,1356,1772,1366,1753,1398,1755,1426,1732,1489,1693,1482,1663,1457,1673,1396,1688,1376,1703,1344,1673,1309,1671,1240,1732,1228,1706,1206,1653,1189,1627,1159,1647,1073",
					Token: "",
					AdjacentRegionIds: [
						"Somali",
						"Zanzibar",
						"Hehe",
						"Maasai"
						]

				),
				new RegionDefinition(
					Id: "Nyamwesi",
					Shape: "1314,1108,1355,1105,1387,1145,1461,1150,1508,1159,1531,1143,1562,1180,1523,1214,1536,1239,1526,1271,1535,1281,1493,1295,1474,1323,1478,1386,1513,1428,1515,1488,1471,1515,1444,1529,1451,1557,1451,1574,1363,1626,1370,1581,1377,1549,1370,1524,1341,1554,1284,1539,1303,1476,1272,1471,1257,1453,1276,1431,1249,1413,1261,1381,1318,1360,1335,1327,1330,1276,1311,1249,1314,1175,1335,1145",
					Token: "",
					AdjacentRegionIds: [
						"Baganda",
						"Maasai",
						"Hehe",
						"Kinga",
						"Bemba",
						"Buye",
						"Bahutu"
						]
				),
				new RegionDefinition(
					Id: "Hehe",
					Shape: "1494,1293,1585,1278,1622,1320,1617,1381,1668,1396,1663,1456,1688,1480,1737,1478,1708,1524,1683,1557,1700,1584,1752,1587,1794,1592,1817,1650,1785,1660,1713,1638,1678,1640,1661,1623,1612,1624,1568,1648,1518,1646,1503,1616,1476,1576,1451,1561,1446,1527,1521,1481,1520,1431,1481,1386,1474,1333",
					Token: "",
					AdjacentRegionIds: [
						"Maasai",
						"Kikuyu",
						"Zanzibar",
						"Yao",
						"Kinga",
						"Nyamwesi"
						]
				),
				new RegionDefinition(
					Id: "Buye",
					Shape: "1097,1323,1158,1313,1227,1322,1246,1381,1249,1409,1272,1433,1254,1455,1271,1470,1296,1475,1284,1537,1269,1552,1219,1561,1153,1562,1163,1544,1118,1503,1077,1465,1082,1409,1099,1369",
					Token: "",
					AdjacentRegionIds: [
						"Bahutu",
						"Nyamwesi",
						"Bemba",
						"Luba",
						"Songye"
						]
				),
				new RegionDefinition(
					Id: "Mbala",
					Shape: "435,1370,457,1379,480,1350,527,1327,583,1322,613,1374,670,1409,714,1431,731,1450,716,1468,687,1451,653,1471,640,1520,643,1574,578,1599,547,1591,558,1554,536,1524,497,1518,482,1493,462,1458,455,1406",
					Token: "",
					AdjacentRegionIds: [
						"Bushongo",
						"Lunda",
						"Ovimbundu",
						"Kimbundu",
						"Kongo",
						"Teke"
						]
				),
				new RegionDefinition(
					Id: "Kimbundu",
					Shape: "354,1562,388,1562,462,1537,477,1500,495,1520,536,1530,558,1552,542,1587,541,1633,526,1660,457,1690,440,1744,399,1801,351,1826,320,1813,336,1784,332,1739,368,1717,378,1678,356,1594",
					Token: "",
					AdjacentRegionIds: [
						"Kongo",
						"Mbala",
						"Ovimbundu",
						"Nyaneka",
						"Angola"
						]
				),
				new RegionDefinition(
					Id: "Lunda",
					Shape: "657,1492,685,1460,716,1465,739,1455,717,1429,785,1389,875,1411,882,1470,855,1485,849,1530,870,1554,907,1655,840,1687,753,1714,697,1705,623,1729,606,1687,618,1646,660,1636,658,1604,643,1571,642,1529",
					Token: "",
					AdjacentRegionIds: [
						"Sonye",
						"Luba",
						"Luvale",
						"Ovimbundu",
						"Mbala",
						"Bushongo"
						]
				),
				new RegionDefinition(
					Id: "Luba",
					Shape: "860,1487,899,1478,948,1456,973,1461,1050,1411,1079,1409,1067,1463,1150,1542,1118,1626,1116,1651,1126,1692,1128,1714,1106,1712,1067,1682,1032,1677,1015,1703,904,1653,886,1592,870,1555,845,1527",
					Token: "",
					AdjacentRegionIds: [
						"Songye",
						"Buye",
						"Bemba",
						"Lamba",
						"Luvale",
						"Lunda"
						]
				),
				new RegionDefinition(
					Id: "Ovimbundu",
					Shape: "356,1825,398,1796,445,1745,453,1693,534,1658,546,1624,541,1589,579,1596,640,1577,658,1608,653,1628,613,1650,608,1690,616,1725,526,1774,527,1809,558,1856,566,1910,547,1954,536,1983,561,2013,522,2025,455,2018,415,1915,388,1907,364,1892,344,1862",
					Token: "",
					AdjacentRegionIds: [
						"Mbala",
						"Lunda",
						"Luvale",
						"Ovambo",
						"Nyaneka",
						"Kimbundu"
						]
				),
				new RegionDefinition(
					Id: "Luvale",
					Shape: "529,1777,613,1732,697,1708,759,1715,830,1697,906,1658,1018,1702,988,1729,1002,1759,976,1803,939,1846,939,1868,867,1883,844,1868,759,1868,721,1934,704,1971,684,2025,652,2031,618,2015,568,2011,537,1986,568,1917,563,1860,527,1809",
					Token: "",
					AdjacentRegionIds: [
						"Lunda",
						"Luba",
						"Lamba",
						"Lozi",
						"Ovambo",
						"Ovimbundu"
						]
				),
				new RegionDefinition(
					Id: "Bemba",
					Shape: "1153,1569,1264,1559,1289,1544,1341,1550,1370,1529,1385,1550,1353,1586,1368,1629,1378,1665,1412,1685,1373,1697,1242,1786,1128,1720,1133,1685,1118,1640",
					Token: "",
					AdjacentRegionIds: [
						"Buye",
						"Nyamwesi",
						"Kinga",
						"Kunda",
						"Lamba",
						"Luba"
						]
				),
				new RegionDefinition(
					Id: "Kinga",
					Shape: "1370,1624,1452,1577,1452,1562,1479,1571,1513,1640,1563,1646,1597,1629,1627,1618,1632,1666,1621,1714,1577,1740,1545,1793,1548,1858,1511,1888,1476,1888,1466,1856,1471,1825,1429,1804,1404,1771,1422,1735,1415,1685,1378,1663",
					Token: "",
					AdjacentRegionIds: [
						"Nyamwesi",
						"Hehe",
						"Yao",
						"Makua",
						"Kunda",
						"Bemba"
						]
				),
				new RegionDefinition(
					Id: "Yao",
					Shape: "1627,1626,1654,1628,1679,1643,1720,1643,1784,1661,1817,1655,1824,1680,1859,1697,1863,1735,1839,1754,1851,1764,1854,1825,1829,1826,1799,1826,1747,1821,1663,1833,1580,1798,1552,1777,1582,1739,1619,1720,1639,1666",
					Token: "",
					AdjacentRegionIds: [
						"Hehe",
						"Makua",
						"Kinga"
						]
				),
				new RegionDefinition(
					Id: "Nyaneka",
					Shape: "226,2008,235,1981,240,1932,260,1892,258,1870,288,1830,314,1818,351,1823,344,1855,352,1897,376,1897,406,1920,421,1947,448,2013,389,2053,319,2013",
					Token: "",
					AdjacentRegionIds: [
						"Kimbundu",
						"Ovimbundu",
						"Ovambo",
						"Herero"
						]
				),
				new RegionDefinition(
					Id: "Lamba",
					Shape: "1037,1675,1071,1683,1099,1710,1128,1717,1239,1791,1170,1846,1138,1880,1101,1885,1091,1927,1076,1947,1022,1961,997,2023,971,1998,960,1981,931,1989,887,1932,923,1905,936,1865,948,1840,1003,1761,993,1735",
					Token: "",
					AdjacentRegionIds: [
						"Luba",
						"Bemba",
						"Kunda",
						"Tonga",
						"Lozi",
						"Luvale"
						]
				),
				new RegionDefinition(
					Id: "Kunda",
					Shape: "1412,1692,1425,1727,1405,1761,1429,1804,1462,1814,1466,1858,1476,1890,1508,1890,1523,1870,1548,1868,1526,1910,1520,1957,1479,1998,1462,2026,1457,2057,1429,2043,1394,2041,1325,2011,1262,1986,1198,1989,1096,1924,1104,1882,1150,1878,1187,1835,1271,1764,1360,1702",
					Token: "",
					AdjacentRegionIds: [
						"Kinga",
						"Makua",
						"Shona",
						"Tonga",
						"Lamba",
						"Bemba"
						]
				),
				new RegionDefinition(
					Id: "Makua",
					Shape: "1521,1954,1521,1909,1543,1867,1542,1821,1548,1793,1557,1772,1599,1808,1658,1833,1745,1818,1849,1826,1853,1909,1834,1929,1859,1932,1844,1979,1856,1989,1794,2052,1767,2065,1743,2087,1727,2087,1641,2045,1602,1994,1602,1957,1567,1959,1540,1966",
					Token: "",
					AdjacentRegionIds: [
						"Yao",
						"Shona",
						"Kunda",
						"Kinga"
						]
				),
				new RegionDefinition(
					Id: "Herero",
					Shape: "221,2004,305,2011,376,2057,341,2105,341,2151,405,2178,521,2196,558,2257,591,2337,613,2416,564,2427,517,2411,475,2421,431,2386,384,2405,369,2381,352,2341,324,2316,310,2275,255,2191,223,2144,225,2105,219,2058",
					Token: "",
					AdjacentRegionIds: [
						"Nyaneka",
						"Ovambo",
						"Khoisan",
						"Nama",
						]
				),
				new RegionDefinition(
					Id: "Ovambo",
					Shape: "379,2058,453,2020,527,2030,564,2015,620,2013,662,2033,746,2004,813,2060,775,2089,670,2129,532,2151,531,2191,416,2179,346,2154,346,2109",
					Token: "",
					AdjacentRegionIds: [
						"Nyaneka",
						"Ovambo",
						"Khoisan",
						"Nama"
						]
				),
				new RegionDefinition(
					Id: "Lozi",
					Shape: "764,1873,850,1873,867,1887,931,1870,923,1904,887,1925,921,1986,953,1984,983,2028,956,2053,975,2122,956,2196,926,2181,869,2127,810,2065,744,2001,692,2021,711,1964,731,1912",
					Token: "",
					AdjacentRegionIds: [
						"Luvale",
						"Lamba",
						"Tonga",
						"Ohekwe",
						"Khoisan",
						"Ovambo"
						]
				),
				new RegionDefinition(
					Id: "Tonga",
					Shape: "956,2052,992,2023,1015,1967,1089,1946,1094,1927,1195,1988,1220,1991,1222,2058,1193,2083,1173,2139,1148,2117,1047,2151,1060,2179,1010,2196,963,2194,978,2127",
					Token: "",
					AdjacentRegionIds: [
						"Lamba",
						"Kunda",
						"Shona",
						"Ndebele",
						"Ohekwe",
						"Lozi"
						]
				),
				new RegionDefinition(
					Id: "Shona",
					Shape: "1227,1991,1259,1986,1397,2036,1425,2036,1452,2060,1471,2013,1518,1961,1542,1971,1602,1957,1597,1991,1632,2046,1743,2083,1676,2110,1622,2141,1486,2156,1462,2166,1447,2210,1454,2275,1442,2309,1404,2310,1378,2294,1328,2295,1272,2263,1219,2238,1203,2164,1178,2137,1197,2092,1229,2058",
					Token: "",
					AdjacentRegionIds: [
						"Makua",
						"Mocambique",
						"Ndebele",
						"Tonga",
						"Kunda"
						]
				),
				new RegionDefinition(
					Id: "Khoisan",
					Shape: "526,2191,534,2151,648,2127,734,2107,780,2090,810,2065,874,2131,855,2168,864,2198,852,2267,820,2336,771,2393,734,2455,677,2425,618,2418,606,2353",
					Token: "",
					AdjacentRegionIds: [
						"Lozi",
						"Ohekwe",
						"Tswana",
						"Nama",
						"Herero",
						"Ovambo"
						]
				),
				new RegionDefinition(
					Id: "Ohekwe",
					Shape: "874,2134,943,2193,1003,2201,1062,2173,1067,2265,1082,2310,1123,2336,1146,2381,1113,2390,1097,2421,1010,2420,978,2445,934,2458,825,2356,825,2331,862,2263,867,2198,855,2169",
					Token: "",
					AdjacentRegionIds: [
						"Tonga",
						"Nebele",
						"Tsawna",
						"Khoisan",
						"Lozi"
						]
				),
				new RegionDefinition(
					Id: "Ndebele",
					Shape: "1055,2152,1145,2126,1170,2141,1203,2166,1214,2237,1266,2260,1309,2304,1380,2297,1395,2314,1318,2458,1335,2482,1320,2489,1299,2479,1156,2474,1156,2432,1156,2383,1141,2368,1131,2334,1077,2307,1067,2176",
					Token: "",
					AdjacentRegionIds: [
						"Shona",
						"Mocambique",
						"Tswana",
						"Ohekwe",
						"Tonga"
						]
				),
				new RegionDefinition(
					Id: "Tswana",
					Shape: "1151,2378,1161,2462,1106,2512,1030,2559,1000,2595,971,2659,953,2731,916,2719,894,2719,869,2704,825,2697,808,2674,800,2652,793,2606,759,2538,733,2492,734,2450,761,2410,796,2369,820,2334,825,2364,926,2453,981,2447,998,2418,1094,2416,1113,2388",
					Token: "",
					AdjacentRegionIds: [
						"Ohekwe",
						"Ndebele",
						"Nama",
						"Khoisan"
						]
				),
				new RegionDefinition(
					Id: "Nama",
					Shape: "425,2383,477,2420,519,2410,573,2427,600,2425,670,2427,724,2455,727,2489,764,2549,786,2598,812,2675,783,2677,633,2677,553,2685,447,2692,416,2632,399,2590,401,2524,379,2490,386,2462,384,2408",
					Token: "",
					AdjacentRegionIds: [
						"Khoisan",
						"Tswana",
						"Herero"
						]
				)
			]
		);


	Task<MapDefinition> IMapDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _mapDefinition );
	}
}
