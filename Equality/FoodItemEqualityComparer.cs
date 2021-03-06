using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equality
{
	class FoodItemEqualityComparer : IEqualityComparer<FoodItem>
	{
		private static readonly FoodItemEqualityComparer _instance = new FoodItemEqualityComparer();
		public static FoodItemEqualityComparer Instance {get {return _instance; }}

		private FoodItemEqualityComparer() {}

		//implementing IEqualityComparer<FoodItem>
		public override bool Equals(FoodItem x, FoodItem y)
		{
			return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant() && x.Group == y.Group;
		}

		public override int GetHashCode(FoodItem obj)
		{
			return obj.Name.ToUpperInvariant().GetHashCode() ^ obj.Group.GetHashCode();
		}
	}
}