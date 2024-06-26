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
            item.itemName_KR = "저주받은 검";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 1000%, and amplifies <color=#F25D1C>Physical Attack</color> by 400%.\nInstant death when hit, negating damage nullification except for invincibility and parrying.";
            item.itemDescription_KR = "<color=#F25D1C>물리공격력</color>이 1000% 증가 및 300% 증폭됩니다.\n피격 시 무적과 패링을 제외한 모든 피해 무효화 수단을 무시하고 즉사합니다.";

            item.itemLore_EN = "Kill before you get killed. Simple, right?";
            item.itemLore_KR = "자, 죽기 전에 죽이면 돼. 간단하지?";

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
            item.itemName_KR = "미지의 두루마리";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 25%.\nIncreases skill cooldown speed by 25%.\nDecreases incoming damage by 10%.\nIncreases Max HP by 30.\nThe second inscription of this item is randomly chosen between Courage, Mana Cycle, Revenge, and Mystery.\nThe improved version of this item changes depending on its second inscription.";
            item.itemDescription_KR = "<color=#F25D1C>물리공격력</color>이 25% 증가합니다.\n스킬 쿨다운 속도가 25% 증가합니다.\n받는 데미지가 10% 감소합니다.\n최대체력이 20 증가합니다\n이 아이템의 두번째 각인은 임의로 용기, 마나 순환, 복수, 그리고 신비중 하나로 지정됩니다.\n이 아이템의 강화된 버전은 두번째 각인에 따라 바뀝니다.";

            item.itemLore_EN = "Not knowing what is inside makes it valuable.";
            item.itemLore_KR = "안에 뭐가 들었는지 모르니까 가치가 있는 법이다.";

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
            item.itemName_KR = "권능의 두루마리: 진화체";

            item.itemDescription_EN = "If this item was found unintentionally, please report to me ASAP!";
            item.itemDescription_KR = "만약 예기치 않게 이 아이템을 발견하셨다면, 저한테 바로 신고해주세요!";

            item.itemLore_EN = "W-Where did you get this from...?";
            item.itemLore_KR = "뭐야... 이거 어디서 가져온거야..?";

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
            item.itemName_KR = "권능의 두루마리: 잔혹성";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 75%.\nIncreases Max HP by 55.";
            item.itemDescription_KR = "<color=#F25D1C>물리공격력</color>이 75% 증가합니다.\n최대체력이 55 증가합니다.";

            item.itemLore_EN = "The scroll of power representing brutality.\nOnly true fighters can learn how to use this scroll.";
            item.itemLore_KR = "잔혹성을 대표하는 권능의 두루마리.\n진정한 싸움꾼들만이 이 두루마리를 응용할 수 있다.";

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
            item.itemName_KR = "권능의 두루마리: 전략가";

            item.itemDescription_EN = "Increases skill cooldown speed by 75%.\nIncreases Max HP by 40.";
            item.itemDescription_KR = "스킬 쿨다운 속도가 75% 증가합니다.\n최대체력이 40 증가합니다.";

            item.itemLore_EN = "The scroll of power representing tactics.\nAlways remember that patience is the key to victory.";
            item.itemLore_KR = "전략가를 대표하는 권능의 두루마리.\n침착함이야말로 승리를 향한 길임을 명심하자.";

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
            item.itemName_KR = "권능의 두루마리: 생존술";

            item.itemDescription_EN = "Decreases incoming damage by 30%.\nIncreases Max HP by 60.";
            item.itemDescription_KR = "받는 데미지가 30% 감소합니다.\n최대체력이 60 증가합니다.";

            item.itemLore_EN = "The scroll of power representing survival.\nIt isn't the strongest that survives, it's the survived who is the strongest.";
            item.itemLore_KR = "생존술을 대표하는 권능의 두루마리.\n강한 자가 살아남는 것이 아니라, 살아남는 자가 강한 것이다.";

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
            item.itemName_KR = "전능의 두루마리";

            item.itemDescription_EN = "Increases <color=#F25D1C>Physical Attack</color> by 40%.\nIncreases skill cooldown speed by 40%.\nDecreases incoming damage by 20%.\nIncreases Max HP by 45.";
            item.itemDescription_KR = "<color=#F25D1C>물리공격력</color>이 40% 증가합니다.\n스킬 쿨다운 속도가 40% 증가합니다.\n받는 데미지가 20% 감소합니다.\n최대체력이 45 증가합니다.";

            item.itemLore_EN = "This will make training at least 3 times more efficient!";
            item.itemLore_KR = "이걸로 수련의 능률이 3배는 오르겠군!";

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
            item.itemName_KR = "탐욕의 방패";

            item.itemDescription_EN = "Upon being hit, you gain 15 gold (5 times maximum per room).";
            item.itemDescription_KR = "피격 시 15 금화가 떨어집니다 (방마다 5회 제한).";

            item.itemLore_EN = "Seriously, who would ever make money out of getting hit?\nLet's do it.";
            item.itemLore_KR = "맞으면서 돈을 벌다니, 그것 참 한심한 생각이군.\n당장 하자.";

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
            item.itemName_KR = "비상용 회복약";

            item.itemDescription_EN = "When having less than 20% of your health, empties the Health Flask and heals 40% of your health.";
            item.itemDescription_KR = "현재 체력이 20% 미만일 시 회복약을 비우며 현재 체력의 40%를 회복합니다.";

            item.itemLore_EN = "It is disposable, so please handle with care.";
            item.itemLore_KR = "일회용이니 취급에 주의해주세요.";

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
            item.itemName_KR = "빈 유리관";

            item.itemDescription_EN = "When a boss is defeated, refills the Empty Flask.";
            item.itemDescription_KR = "보스 처치 시 회복약이 다시 채워집니다.";

            item.itemLore_EN = "You're not supposed to... chug that...";
            item.itemLore_KR = "아니... 그걸 한입에 쳐 마시면... 하...";

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
