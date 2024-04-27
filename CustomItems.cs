using System.Collections.Generic;
using System.Linq;
using Characters;
using Characters.Abilities;
using Characters.Gear.Synergy.Inscriptions;
using DeadCellsCustomItems.CustomAbilities;
using UnityEngine.AddressableAssets;

namespace DeadCellsCustomItems;

public class CustomItems
{
    public static readonly List<CustomItemReference> Items = InitializeItems();

    /**
     * TODO
     * 
     */

    private static List<CustomItemReference> InitializeItems()
    {
        List<CustomItemReference> items = new();
        {
            var item = new CustomItemReference();
            item.name = "CursedSword";
            item.rarity = Rarity.Legendary;

            item.itemName_EN = "Cursed Sword";
            item.itemName_KR = "���ֹ��� ��";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 1000%, and amplifies <color=#F25D1C>Physical Attack</color> by 400%.\nInstant death when hit, negating damage nullification except for invincibility and parrying.";
            item.itemDescription_KR = "<color=#F25D1C>�������ݷ�</color>�� 1000% ���� �� 300% �����˴ϴ�.\n�ǰ� �� ������ �и��� ������ ��� ���� ��ȿȭ ������ �����ϰ� ����մϴ�.";

            item.itemLore_EN = "Kill before you get killed. Simple, right?";
            item.itemLore_KR = "��, �ױ� ���� ���̸� ��. ��������?";

            item.prefabKeyword1 = Inscription.Key.Execution;
            item.prefabKeyword2 = Inscription.Key.Arms;

            item.stats = new Stat.Values(new Stat.Value[] {
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.PhysicalAttackDamage, 10.0),
                new Stat.Value(Stat.Category.Percent, Stat.Kind.PhysicalAttackDamage, 5.0),
            });

            item.abilities = new Ability[] {
                new InstaKillIgnoringNegation(),
            };

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "MysteriousScroll";
            item.rarity = Rarity.Unique;

            item.itemName_EN = "Mysterious Scroll";
            item.itemName_KR = "������ �η縶��";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 25%.\nIncreases skill cooldown speed by 25%.\nDecreases incoming damage by 10%.\nIncreases Max HP by 30.\nThe second inscription of this item is randomly chosen between Courage, Mana Cycle, Revenge, and Mystery.\nThe improved version of this item changes depending on its second inscription.";
            item.itemDescription_KR = "<color=#F25D1C>�������ݷ�</color>�� 25% �����մϴ�.\n��ų ��ٿ� �ӵ��� 25% �����մϴ�.\n�޴� �������� 10% �����մϴ�.\n�ִ�ü���� 20 �����մϴ�\n�� �������� �ι�° ������ ���Ƿ� ���, ���� ��ȯ, ����, �׸��� �ź��� �ϳ��� �����˴ϴ�.\n�� �������� ��ȭ�� ������ �ι�° ���ο� ���� �ٲ�ϴ�.";

            item.itemLore_EN = "Not knowing what is inside makes it valuable.";
            item.itemLore_KR = "�ȿ� ���� ������� �𸣴ϱ� ��ġ�� �ִ� ���̴�.";

            item.prefabKeyword1 = Inscription.Key.Masterpiece;
            item.prefabKeyword2 = Inscription.Key.None;

            item.stats = new Stat.Values(new Stat.Value[] {
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.PhysicalAttackDamage, 0.25),
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.SkillCooldownSpeed, 0.25),
                new Stat.Value(Stat.Category.Percent, Stat.Kind.TakingDamage, 0.9),
                new Stat.Value(Stat.Category.Fixed, Stat.Kind.Health, 20),
            });

            item.extraComponents = new[] {
                typeof(MysteriousScrollKeyWordRandomizer),
            };

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "MysteriousScroll_2";
            item.obtainable = false;
            item.rarity = Rarity.Unique;

            item.itemName_EN = "Scroll of Power: Evolution";
            item.itemName_KR = "�Ǵ��� �η縶��: ��ȭü";

            item.itemDescription_EN = "If this item was found unintentionally, please report to me ASAP!";
            item.itemDescription_KR = "���� ����ġ �ʰ� �� �������� �߰��ϼ̴ٸ�, ������ �ٷ� �Ű����ּ���!";

            item.itemLore_EN = "W-Where did you get this from...?";
            item.itemLore_KR = "����... �̰� ��� �����°ž�..?";

            item.prefabKeyword1 = Inscription.Key.Masterpiece;
            item.prefabKeyword2 = Inscription.Key.None;

            item.forbiddenDrops = new[] { "MysteriousScroll" };

            item.extraComponents = new[] {
                typeof(UpgradeMysteriousScroll),
            };

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "MysteriousScroll_2_1";
            item.obtainable = false;
            item.rarity = Rarity.Unique;

            item.itemName_EN = "Scroll of Power: Brutality";
            item.itemName_KR = "�Ǵ��� �η縶��: ��Ȥ��";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 75%.\nIncreases Max HP by 55.";
            item.itemDescription_KR = "<color=#F25D1C>�������ݷ�</color>�� 75% �����մϴ�.\n�ִ�ü���� 55 �����մϴ�.";

            item.itemLore_EN = "The scroll of power representing brutality.\nOnly true fighters can learn how to use this scroll.";
            item.itemLore_KR = "��Ȥ���� ��ǥ�ϴ� �Ǵ��� �η縶��.\n������ �ο�۵鸸�� �� �η縶���� ������ �� �ִ�.";

            item.prefabKeyword1 = Inscription.Key.None;
            item.prefabKeyword2 = Inscription.Key.None;

            item.forbiddenDrops = new[] { "MysteriousScroll" };

            item.stats = new Stat.Values(new Stat.Value[] {
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.PhysicalAttackDamage, 0.75),
                new Stat.Value(Stat.Category.Fixed, Stat.Kind.Health, 55),
            });

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "MysteriousScroll_2_2";
            item.obtainable = false;
            item.rarity = Rarity.Unique;

            item.itemName_EN = "Scroll of Power: Tactics";
            item.itemName_KR = "�Ǵ��� �η縶��: ������";

            item.itemDescription_EN = "Increases skill cooldown speed by 75%.\nIncreases Max HP by 40.";
            item.itemDescription_KR = "��ų ��ٿ� �ӵ��� 75% �����մϴ�.\n�ִ�ü���� 40 �����մϴ�.";

            item.itemLore_EN = "The scroll of power representing tactics.\nAlways remember that patience is the key to victory.";
            item.itemLore_KR = "�������� ��ǥ�ϴ� �Ǵ��� �η縶��.\nħ�����̾߸��� �¸��� ���� ������ �������.";

            item.prefabKeyword1 = Inscription.Key.None;
            item.prefabKeyword2 = Inscription.Key.None;

            item.forbiddenDrops = new[] { "MysteriousScroll" };

            item.stats = new Stat.Values(new Stat.Value[] {
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.SkillCooldownSpeed, 0.75),
                new Stat.Value(Stat.Category.Fixed, Stat.Kind.Health, 40),
            });

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "MysteriousScroll_2_3";
            item.obtainable = false;
            item.rarity = Rarity.Unique;

            item.itemName_EN = "Scroll of Power: Survival";
            item.itemName_KR = "�Ǵ��� �η縶��: ������";

            item.itemDescription_EN = "Decreases incoming damage by 30%.\nIncreases Max HP by 60.";
            item.itemDescription_KR = "�޴� �������� 30% �����մϴ�.\n�ִ�ü���� 60 �����մϴ�.";

            item.itemLore_EN = "The scroll of power representing survival.\nIt isn't the strongest that survives, it's the survived who is the strongest.";
            item.itemLore_KR = "�������� ��ǥ�ϴ� �Ǵ��� �η縶��.\n���� �ڰ� ��Ƴ��� ���� �ƴ϶�, ��Ƴ��� �ڰ� ���� ���̴�.";

            item.prefabKeyword1 = Inscription.Key.None;
            item.prefabKeyword2 = Inscription.Key.None;

            item.forbiddenDrops = new[] { "MysteriousScroll" };

            item.stats = new Stat.Values(new Stat.Value[] {
                new Stat.Value(Stat.Category.Percent, Stat.Kind.TakingDamage, 0.7),
                new Stat.Value(Stat.Category.Fixed, Stat.Kind.Health, 60),
            });

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "MysteriousScroll_2_4";
            item.obtainable = false;
            item.rarity = Rarity.Unique;

            item.itemName_EN = "Epic Scroll of Power";
            item.itemName_KR = "������ �η縶��";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 40%.\nIncreases skill cooldown speed by 40%.\nDecreases incoming damage by 20%.\nIncreases Max HP by 45.";
            item.itemDescription_KR = "<color=#F25D1C>�������ݷ�</color>�� 40% �����մϴ�.\n��ų ��ٿ� �ӵ��� 40% �����մϴ�.\n�޴� �������� 20% �����մϴ�.\n�ִ�ü���� 45 �����մϴ�.";

            item.itemLore_EN = "This will make training at least 3 times more efficient!";
            item.itemLore_KR = "�̰ɷ� ������ �ɷ��� 3��� �����ڱ�!";

            item.prefabKeyword1 = Inscription.Key.None;
            item.prefabKeyword2 = Inscription.Key.None;

            item.forbiddenDrops = new[] { "MysteriousScroll" };

            item.stats = new Stat.Values(new Stat.Value[] {
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.PhysicalAttackDamage, 0.4),
                new Stat.Value(Stat.Category.PercentPoint, Stat.Kind.SkillCooldownSpeed, 0.4),
                new Stat.Value(Stat.Category.Percent, Stat.Kind.TakingDamage, 0.8),
                new Stat.Value(Stat.Category.Fixed, Stat.Kind.Health, 45),
            });

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "ShieldOfGreed";
            item.rarity = Rarity.Common;

            item.itemName_EN = "Shield of Greed";
            item.itemName_KR = "Ž���� ����";

            item.itemDescription_EN = "Upon being hit, you gain 15 gold (5 times maximum per room).";
            item.itemDescription_KR = "�ǰ� �� 15 ��ȭ�� �������ϴ� (�渶�� 5ȸ ����).";

            item.itemLore_EN = "Seriously, who would ever make money out of getting hit?\nLet's do it.";
            item.itemLore_KR = "�����鼭 ���� ���ٴ�, �װ� �� �ѽ��� �����̱�.\n���� ����.";

            item.prefabKeyword1 = Inscription.Key.Fortress;
            item.prefabKeyword2 = Inscription.Key.Treasure;

            item.abilities = new Ability[] {
                new GainGoldUponHit(),
            };

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "EmergencyHealthFlask";
            item.rarity = Rarity.Rare;

            item.itemName_EN = "Emergency Health Flask";
            item.itemName_KR = "���� ȸ����";

            item.itemDescription_EN = "When having less than 20% of your health, empties the Health Flask and heals 40% of your health.";
            item.itemDescription_KR = "���� ü���� 20% �̸��� �� ȸ������ ���� ���� ü���� 40%�� ȸ���մϴ�.";

            item.itemLore_EN = "It is disposable, so please handle with care.";
            item.itemLore_KR = "��ȸ���̴� ��޿� �������ּ���.";

            item.prefabKeyword1 = Inscription.Key.Antique;
            item.prefabKeyword2 = Inscription.Key.Relic;

            item.extraComponents = new[] {
                typeof(ChangeItemWhenLowHealth),
            };

            items.Add(item);
        }

        {
            var item = new CustomItemReference();
            item.name = "EmergencyHealthFlask_2";
            item.obtainable = false;
            item.rarity = Rarity.Rare;

            item.itemName_EN = "Empty Flask";
            item.itemName_KR = "�� ������";

            item.itemDescription_EN = "When a boss is defeated, refills the Empty Flask.";
            item.itemDescription_KR = "���� óġ �� ȸ������ �ٽ� ä�����ϴ�.";

            item.itemLore_EN = "You're not supposed to... chug that...";
            item.itemLore_KR = "�ƴ�... �װ� ���Կ� �� ���ø�... ��...";

            item.prefabKeyword1 = Inscription.Key.Antique;
            item.prefabKeyword2 = Inscription.Key.Relic;

            item.extraComponents = new[] {
                typeof(ChangeItemWhenKilledBoss),
            };

            items.Add(item);
        }

        return items;
    }

    internal static void LoadSprites()
    {
        Items.ForEach(item => item.LoadSprites());
    }

    internal static Dictionary<string, string> MakeStringDictionary()
    {
        Dictionary<string, string> strings = new(Items.Count * 8);

        foreach (var item in Items)
        {
            strings.Add("item/" + item.name + "/name", item.itemName);
            strings.Add("item/" + item.name + "/desc", item.itemDescription);
            strings.Add("item/" + item.name + "/flavor", item.itemLore);
        }

        return strings;
    }

    internal static List<Masterpiece.EnhancementMap> ListMasterpieces()
    {
        var masterpieces = Items.Where(i => (i.prefabKeyword1 == Inscription.Key.Masterpiece) || (i.prefabKeyword2 == Inscription.Key.Masterpiece))
                                .ToDictionary(i => i.name);

        return masterpieces.Where(item => masterpieces.ContainsKey(item.Key + "_2"))
                           .Select(item => new Masterpiece.EnhancementMap()
                           {
                               _from = new AssetReference(item.Value.guid),
                               _to = new AssetReference(masterpieces[item.Key + "_2"].guid),
                           })
                           .ToList();
    }
}
