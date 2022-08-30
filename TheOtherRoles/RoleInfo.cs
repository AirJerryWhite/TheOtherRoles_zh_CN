using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
        public bool isModifier;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
        }

        public static RoleInfo jester = new RoleInfo("小丑", Jester.color, "把自己投出去", "把自己投出去", RoleId.Jester, true);
        public static RoleInfo mayor = new RoleInfo("市长", Mayor.color, "一票顶两", "一票顶两", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("传送门测试员", Portalmaker.color, "你可以建造传送门", "你可以建造传送门", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("工程师",  Engineer.color, "维护船上的重要系统", "你可以", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, "击毙<color=#FF1919FF>内鬼</color>", "击毙内鬼，别误会好人", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("警员", Sheriff.color, "铐住 <color=#FF1919FF>内鬼</color>", "你可以使用手铐禁用某人的技能一段时间", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("执灯人", Lighter.color, "灯火永存", "你的灯光不会熄灭", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父", Godfather.color, "杀害所有的船员", "杀害所有的船员", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("黑手党", Mafioso.color, "和 <color=#FF1919FF>搬运工</color> 一起杀害船员", "杀害所有船员", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("搬运工", Janitor.color, "替 <color=#FF1919FF>黑手党</color> 毁尸灭迹", "在别人报警前把尸体转移", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("化形者", Morphling.color, "你可以伪装他人来栽赃陷害", "你可以伪装他人来栽赃陷害", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("伪装者", Camouflager.color, "伪装并击杀船员", "你可以隐蔽在人群之中", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, "将你的敌人吸成肉干", "将你的敌人吸成肉干", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("抹除者", Eraser.color, "抹除你敌人的身份", "抹除你敌人的身份", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("骗术师", Trickster.color, "为你的敌人制造惊吓", "为你的敌人制造惊吓", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清洁工", Cleaner.color, "打扫干净，然后无事发生", "打扫干净，然后无事发生", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("术士", Warlock.color, "咒杀别人", "咒杀别人", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("赏金猎人", BountyHunter.color, "追捕你的赏金", "追捕你的赏金", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, "通过脚印找出 <color=#FF1919FF>内鬼</color>", "通过追踪脚印找出内鬼", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("时间之主", TimeMaster.color, "使用你的时间之盾来保护自己", "使用你的时间之盾来保护自己", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("医生", Medic.color, "保护其他玩家", "保护其他玩家", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("交换师", Shifter.color, "你可以和别人交换身份", "你可以和别人交换身份", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("换票师", Swapper.color, "你可以更好投票结果来投出<color=#FF1919FF>内鬼</color>", "你可以更好投票结果来投出内鬼", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("灵媒", Seer.color, "你可以预见死亡", "你可以预见死亡", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("黑客", Hacker.color, "黑入船上系统来发现<color=#FF1919FF>内鬼</color>", "你可以黑入控制台来获取所有人的位置信息", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("追踪者", Tracker.color, "追踪 <color=#FF1919FF>内鬼</color> ", "跟踪内鬼", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密者", Snitch.color, "完成你的任务以获悉 <color=#FF1919FF>内鬼</color> 是谁", "偷偷摸摸完成你的任务，然后真相大白", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, "杀害所有的船员和 <color=#FF1919FF>内鬼</color> 以获得胜利", "杀死所有人", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("跟班", Sidekick.color, "帮助豺狼杀死所有人", "帮助豺狼杀死所有人", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("卧底", Spy.color, "迷惑 <color=#FF1919FF>内鬼</color>", "迷惑内鬼", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("保安", SecurityGuard.color, "你可以堵住下水道，安装新的摄像头", "堵上下水道、安上摄像头", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("纵火犯", Arsonist.color, "让我把飞船烧成灰", "让我把飞船烧成灰", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("正义赌怪", Guesser.color, "生命是一场豪赌", "生命是一场豪赌", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("邪恶赌怪", Palette.ImpostorRed, "生命是一场豪赌", "生命是一场豪赌", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("秃鹫", Vulture.color, "吞噬尸体以获得胜利", "吞噬尸体以获得胜利", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("通灵师", Medium.color, "向已逝之人提去问题，以获悉凶手的信息", "向已逝之人提去问题，以获悉凶手的信息", RoleId.Medium);
        public static RoleInfo lawyer = new RoleInfo("律师", Lawyer.color, "保护你的客户", "保护你的客户", RoleId.Lawyer, true);
        public static RoleInfo pursuer = new RoleInfo("起诉人", Pursuer.color, "使用空包弹来阻止内鬼", "使用空包弹来阻止内鬼", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("内鬼", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破坏并杀害所有人"), "破坏并杀害所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船员", Color.white, "找出内鬼", "找出内鬼", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("女巫", Witch.color, "通过你的咒语杀害你的敌人", "咒杀你的敌人", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("忍者", Ninja.color, "出其不意地刺杀你的敌人", "出其不意地刺杀你的敌人", RoleId.Ninja);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("败血病", Color.yellow, "你的死亡会使杀人者染上血渍", "你的死亡会使杀人者染上血渍", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("晕传者", Color.yellow, "你不会被传送", "你不会被传送", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("破平者", Color.yellow, "你可以打破平局", "打破平局", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("诱饵", Color.yellow, "敢杀你的人会去自首", "敢杀你的人会去自首", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("墨镜", Color.yellow, "你带上了帅气的墨镜", "你的视野受到了限制", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("恋人", Lovers.color, $"你坠入了爱河", $"你坠入了爱河", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("迷你船员", Color.yellow, "你只是个孩子，没有人会伤害你", "你只是个孩子，没有人会伤害你", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("贵宾", Color.yellow, "你是贵宾，你的名声享誉全船。", "当你死后全船为之震动", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("酒鬼", Color.yellow, "你昨晚在酒吧宿醉了", "你的移动按键颠倒了", RoleId.Invert, false, true);


        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            bountyHunter,
            witch,
            ninja,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            crewmate,
            shifter,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
            }

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
            if (p == Guesser.evilGuesser) infos.Add(badGuesser);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer) infos.Add(lawyer);
            if (p == Pursuer.pursuer) infos.Add(pursuer);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}
