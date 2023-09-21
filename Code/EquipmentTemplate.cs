using System.Collections.Generic;
using WolfRPG.Core;
using WolfRPG.Inventory;

namespace Code
{
	public class EquipmentTemplate: IWolfRPGTemplate
	{
		public string Name => "Item: Equipment";

		public IEnumerable<IRPGComponent> GetComponents() {
			var itemData = new ItemData
			{
				Type = ItemType.Equipment
			};
			return new List<IRPGComponent>
			{
				itemData,
				new EquipmentData()
			};

		}
	}
}