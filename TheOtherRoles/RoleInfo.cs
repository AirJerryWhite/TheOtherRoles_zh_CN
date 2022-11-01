using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;
using TheOtherRoles.Utilities;
using TheOtherRoles.CustomGameModes;

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
        public static RoleInfo mayor = new RoleInfo("市长", Mayor.color, "一票顶�?", "一票顶�?", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("传送门测试�?", Portalmaker.color, "你可以建造传送门", "你可以建造传送门", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("工程�?",  Engineer.color, "维护船上的重要系�?", "你可以修复紧急事�?", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, "击毙<color=#FF1919FF>内鬼</color>", "击毙内鬼", RoleId.Sheriff);
        public static RoleInfo deputy = new RoleInfo("警员", Sheriff.color, "铐住 <color=#FF1919FF>内鬼</color>", "你可以使用手铐禁用某人的技能一段时�?", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("执灯�?", Lighter.color, "灯火永存", "你的灯光不会熄灭", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父", Godfather.color, "杀害所有的船员", "杀害所有的船员", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("黑手党成�?", Mafioso.color, "�? <color=#FF1919FF>其他黑手党成�?</color> 一起杀害船�?", "杀害所有船�?", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("搬运�?", Janitor.color, "�?<color=#FF1919FF>黑手党成�?</color>毁尸灭迹", "隐匿尸体", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("化形�?", Morphling.color, "你可以化形他人来栽赃陷害", "化形成他�?", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("伪装�?", Camouflager.color, "隐匿在人群中击杀船员", "你可以隐蔽在人群之中", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("吸血�?", Vampire.color, "将你的敌人吸成肉�?", "将你的敌人吸成肉�?", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("抹除�?", Eraser.color, "击杀船员并抹除他们的身份", "抹除敌人的身�?", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("骗术�?", Trickster.color, "使用你的惊吓盒带给别人惊�?", "通过惊吓盒间的穿行带给敌人惊�?", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清洁�?", Cleaner.color, "击杀船员并且不留痕迹", "清理尸体", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("术士", Warlock.color, "咒杀别人", "咒杀别人", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("赏金猎人", BountyHunter.color, "追捕你的赏金目标", "追捕你的赏金目标", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, "通过脚印找出<color=#FF1919FF>内鬼</color>", "通过追踪脚印找出内鬼", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("时间之主", TimeMaster.color, "使用你的时间之盾来保护自�?", "使用你的时间之盾来保护自�?", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("医生", Medic.color, "通过你的护盾来保护其他船�?", "保护其他船员", RoleId.Medic);
        public static RoleInfo swapper = new RoleInfo("换票�?", Swapper.color, "交换票型投出<color=#FF1919FF>内鬼</color>", "交换票型", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("灵媒", Seer.color, "你可以感受到死亡的气�?", "你可以感受到死亡的气�?", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("黑客", Hacker.color, "黑入船上系统来发�?<color=#FF1919FF>内鬼</color>", "黑入面板来获取更多的信息", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("追踪�?", Tracker.color, "追捕�?<color=#FF1919FF>内鬼</color>", "追捕到内�?", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密�?", Snitch.color, "完成你的任务以获�?<color=#FF1919FF>内鬼</color>的信�?", "完成你的任务", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, "杀害所有的船员�?<color=#FF1919FF>内鬼</color>以获得胜�?", "杀害所有人", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("跟班", Sidekick.color, "帮助豺狼杀害所有人", "帮助豺狼杀害所有人", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("卧底", Spy.color, "迷惑<color=#FF1919FF>内鬼</color>", "迷惑内鬼", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("保安", SecurityGuard.color, "你可以堵住下水道，安装新的摄像头", "堵上下水道、安上摄像头", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("纵火�?", Arsonist.color, "把飞船烧成灰", "把飞船烧成灰", RoleId.Arsonist, true);
        public static RoleInfo goodGuesser = new RoleInfo("正义赌�?", Guesser.color, "生命是一场豪�?", "生命是一场豪�?", RoleId.NiceGuesser);
        public static RoleInfo badGuesser = new RoleInfo("邪恶赌�?", Palette.ImpostorRed, "生命是一场豪�?", "生命是一场豪�?", RoleId.EvilGuesser);
        public static RoleInfo vulture = new RoleInfo("秃鹫", Vulture.color, "吞噬尸体以获得胜�?", "吞噬尸体", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("通灵�?", Medium.color, "通灵以获悉凶手的信息", "通灵以获悉凶手的信息", RoleId.Medium);
        public static RoleInfo trapper = new RoleInfo("设陷�?", Trapper.color, "放置陷阱以获取内鬼的信息", "放置陷阱", RoleId.Trapper);
        public static RoleInfo lawyer = new RoleInfo("律师", Lawyer.color, "保护你的客户", "保护你的客户", RoleId.Lawyer, true);
        public static RoleInfo prosecutor = new RoleInfo("起诉�?", Lawyer.color, "投出你的目标", "投出你的目标", RoleId.Prosecutor, true);
        public static RoleInfo pursuer = new RoleInfo("追捕�?", Pursuer.color, "使用空包弹来阻止内鬼", "使用空包弹来阻止内鬼", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("内鬼", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破坏并杀害所有人"), "破坏并杀害所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船员", Color.white, "找出内鬼", "找出内鬼", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("女巫", Witch.color, "通过你的咒语杀害你的敌�?", "咒杀你的敌人", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("忍�?", Ninja.color, "出其不意地刺杀你的敌人", "出其不意地刺杀你的敌人", RoleId.Ninja);
        public static RoleInfo thief = new RoleInfo("盗贼", Thief.color, "窃取并杀害具有击杀能力的玩家的职业", "窃取具有击杀能力的玩家的职业", RoleId.Thief, true);

        public static RoleInfo hunter = new RoleInfo("猎人", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "搜寻并杀害所有人"), "搜寻并杀害所有人", RoleId.Impostor);
        public static RoleInfo hunted = new RoleInfo("猎物", Color.white, "躲藏不被猎人发现", "躲藏不被猎人发现", RoleId.Crewmate);



        // Modifier
        public static RoleInfo bloody = new RoleInfo("败血�?", Color.yellow, "你的死亡会使杀人者染上血�?", "你的死亡会使杀人者染上血�?", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("晕传�?", Color.yellow, "你不会被传�?", "你不会被传�?", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("破平�?", Color.yellow, "你可以打破平局", "打破平局", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("诱饵", Color.yellow, "杀害你的人会去自首", "杀害你的人会去自首", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("墨镜", Color.yellow, "你带上了帅气的墨�?", "你的视野受到了限�?", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("恋人", Lovers.color, $"你坠入了爱河", $"你坠入了爱河", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("迷你船员", Color.yellow, "没有人会伤害一个孩子，直到你长�?", "没有人会伤害一个孩�?", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("贵宾", Color.yellow, "你是贵宾，你的名声享誉全�?", "所有人都会注意到你的死�?", RoleId.Vip, false, true);
        public static RoleInfo invert = new RoleInfo("酒鬼", Color.yellow, "你宿醉了", "你的移动按键颠倒了", RoleId.Invert, false, true);
        public static RoleInfo chameleon = new RoleInfo("变色�?", Color.yellow, "当你不动时你将很难被发现", "当你不动时你将很难被发现", RoleId.Chameleon, false, true);
        public static RoleInfo shifter = new RoleInfo("交换�?", Color.yellow, "交换你的角色", "交换你的角色", RoleId.Shifter, false, true);


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
            thief,
            prosecutor,
            crewmate,
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
            trapper,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            invert,
            chameleon,
            shifter
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead || AmongUsClient.Instance.GameState == InnerNet.InnerNetClient.GameStates.Ended)
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
                if (Chameleon.chameleon.Any(x => x.PlayerId == p.PlayerId)) infos.Add(chameleon);
                if (p == Shifter.shifter) infos.Add(shifter);
            }

            int count = infos.Count;  // Save count after modifiers are added so that the role count can be checked

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
            if (p == Lawyer.lawyer && !Lawyer.isProsecutor) infos.Add(lawyer);
            if (p == Lawyer.lawyer && Lawyer.isProsecutor) infos.Add(prosecutor);
            if (p == Trapper.trapper) infos.Add(trapper);
            if (p == Pursuer.pursuer) infos.Add(pursuer);
            if (p == Thief.thief) infos.Add(thief);

            // Default roles (just impostor, just crewmate, or hunter / hunted for hide n seek
            if (infos.Count == count) {
                if (p.Data.Role.IsImpostor)
                    infos.Add(MapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunter : RoleInfo.impostor);
                else
                    infos.Add(MapOptions.gameMode == CustomGamemodes.HideNSeek ? RoleInfo.hunted : RoleInfo.crewmate);
            }

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) 
                roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            if (HandleGuesser.isGuesserGm && HandleGuesser.isGuesser(p.PlayerId)) roleName += " (Guesser)";
            return roleName;
        }
    }
}
