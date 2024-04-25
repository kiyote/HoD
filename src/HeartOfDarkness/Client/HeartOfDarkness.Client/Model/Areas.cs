using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartOfDarkness.Client.Model;

public class Areas {

	private readonly Dictionary<string, string> _areas;

	public Areas() {
		_areas = new Dictionary<string, string>() {
			{ RegionId.Mocambique, "1331,2613,1338,2469,1328,2448,1358,2381,1404,2314,1444,2314,1466,2277,1457,2211,1479,2163,1619,2149,1589,2188,1540,2230,1498,2233,1501,2285,1530,2364,1535,2448,1511,2522,1392,2561,1368,2588,1373,2637,1341,2638" }
		};
	}

	public string this[string regionId] {
		get {
			return _areas[regionId];
		}
	}
}
