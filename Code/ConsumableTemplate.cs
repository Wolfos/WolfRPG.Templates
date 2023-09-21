using System.Collections.Generic;
using WolfRPG.Core;
using WolfRPG.Inventory;

namespace Code
{
	public class ConsumableTemplate: IWolfRPGTemplate
	{
		public string Name => "Item: Consumable";

		public IEnumerable<IRPGComponent> GetComponents()
		{
			var itemData = new ItemData
			{
				Type = ItemType.Consumable
			};
			return new List<IRPGComponent>
			{
				itemData,
				new ConsumableData()
			};

		}
	}
}