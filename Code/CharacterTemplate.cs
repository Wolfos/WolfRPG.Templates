using System.Collections.Generic;
using WolfRPG.Character;
using WolfRPG.Core;
using WolfRPG.Inventory;

public class CharacterTemplate : IWolfRPGTemplate
{
	public string Name => "Character";
	
	public IEnumerable<IRPGComponent> GetComponents() {
		return new List<IRPGComponent>
		{
			new CharacterComponent(),
			new CharacterAttributes(),
			new CharacterSkills(),
			new LoadoutComponent()
		};

	}
}
