using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNews.Models.cjl;

namespace AspNews.cs
{
    public class NewsInitAlways:DropCreateDatabaseAlways<News>
    {
        private content1 c = new content1();
        protected override void Seed(News context)
        {
            var RightDb = new List<RightDb>
             {
                new RightDb { RightID =1 , RightName = "管理员" },
                new RightDb { RightID =2 , RightName = "一般用户" },
             };
            RightDb.ForEach(p => context.RightDb.Add(p));
            context.SaveChanges();

            var UserDb = new List<UserDb>
             {
                new UserDb { UserID =1 , UserName = "管理员"  , RightID =1 , UserPassword = "123456" },
                new UserDb { UserID =2 , UserName = "一般用户", RightID =2 , UserPassword = "123456" },
             };
            UserDb.ForEach(p => context.UserDb.Add(p));
            context.SaveChanges();

            var RankDb = new List<RankDb>
             {
                new RankDb { RankID =1 , RankName = "重大事件"  , RankDescribed = "非常重要的事件" },
                new RankDb { RankID =2 , RankName = "紧急事件"  , RankDescribed = "突发新闻" },
                new RankDb { RankID =3 , RankName = "重要事件"  , RankDescribed = "较重要的新闻" },
                new RankDb { RankID =4 , RankName = "一般事件"  , RankDescribed = "一般新闻" },
             };
            RankDb.ForEach(p => context.RankDb.Add(p));
            context.SaveChanges();


            var TypeDb = new List<TypeDb>
             {
                new TypeDb { TypeID =1 , TypeName = "社会",TypeEnName = "Society" },
                new TypeDb { TypeID =2 , TypeName = "法治",TypeEnName = "Laws" },
                new TypeDb { TypeID =3 , TypeName = "科技",TypeEnName = "Technology" },
                new TypeDb { TypeID =4 , TypeName = "生活",TypeEnName = "Life" },
                new TypeDb { TypeID =5 , TypeName = "人物",TypeEnName = "people" },
                new TypeDb { TypeID =6 , TypeName = "军事",TypeEnName = "Military" },
                new TypeDb { TypeID =7 , TypeName = "娱乐",TypeEnName = "Entertainment" },
                new TypeDb { TypeID =8 , TypeName = "国际",TypeEnName = "International" },
                new TypeDb { TypeID =9 , TypeName = "教育",TypeEnName = "Education" },
             };
            TypeDb.ForEach(p => context.TypeDb.Add(p));
            context.SaveChanges();

            var NewsDb = new List<NewsDb>
             {
                new NewsDb { NewsId = "1" ,  TypeID =9 , RankID =3 , NewsDescribed = "26日起，2021年全国硕士研究生招生考试将举行，本次考试报考人数达到377万人，创历史新高。在疫情防控的大背景下，各地就本次考试的防疫措施进行了部署。同时，教育部也强调，坚决维护研招考试公平公正，并公布考试违规违法行为举报电话。"  , NewsWriter = "邢斯馨"   , NewsTitle = "2021考研开考：377万人报名 各地强调考场防疫"  , NewsSource = "中国新闻网"   , NewsKeywords = "考试报名,考场纪律"   , ReleaseTime = DateTime.Parse("2020-12-26 23:34Z")   ,
                             NewsContent = c.news1   ,
                             ImageURL = "Image/News/new001.jpg"   , ReadingNum = 454554  },
                new NewsDb { NewsId = "2" ,  TypeID =9 , RankID =4 , NewsDescribed = "记者25日获悉，教育部今天召开视频调度会议，研究部署今冬明春教育系统疫情防控工作提出，今冬明春是疫情防控的关键时期，教育系统要科学精准做好寒假期间疫情防控工作，确保春季学期高校错峰开学，妥善安排留校师生学习和生活。"      , NewsWriter = "邢斯馨"  , NewsTitle = "教育部要求确保春季学期高校错峰开学" , NewsSource = "新华社“新华视点”微博"  , NewsKeywords = "错峰,开学,教育部"  , ReleaseTime = DateTime.Parse("2020-12-25 10:55Z")  ,
                             NewsContent = c.news2  ,
                             ImageURL = "Image/News/new002.jpg"  , ReadingNum = 754546  },
                new NewsDb { NewsId = "3" ,  TypeID =2 , RankID =4 , NewsDescribed = "广东海警局近日联合多地海关缉私部门成功打掉5个长期活跃在广东海域的走私成品油团伙。初步查证涉案柴油约16万吨，案值约8亿元，涉嫌偷逃税款约4亿元。"  , NewsWriter = "谢博韬"   , NewsTitle = "中国海警破获特大涉嫌走私成品油案 案值约8亿元"  , NewsSource = "新华网"   , NewsKeywords = "中国海警,走私,成品油"  , ReleaseTime = DateTime.Parse("2020-12-26 09:51Z")   ,
                             NewsContent = c.news3   ,
                             ImageURL = "Image/News/new003.jpg"   , ReadingNum = 676546  },
                new NewsDb { NewsId = "4" ,  TypeID =2 , RankID =3 , NewsDescribed = "骗取、贪污土地开发补偿款高达5亿余元；安排其父亲、妻子、兄弟及亲信入选村“两委”，把持基层政权达30多年；无恶不作，实施抢劫致1人死亡"      , NewsWriter = "谢博韬"  , NewsTitle = "一涉黑案件挖出腐败及“保护伞”93人" , NewsSource = "法治日报"  , NewsKeywords = "保护伞,涉黑,办案"  , ReleaseTime = DateTime.Parse("2020-12-26 19:08Z")  ,
                             NewsContent = c.news4  ,
                             ImageURL = "Image/News/new004.jpg"  , ReadingNum = 544878  },
                new NewsDb { NewsId = "5" ,  TypeID =3 , RankID =4 , NewsDescribed = "我国科学家领衔的一支国际研究团队在探月领域再出新成果。该团队在月球撞击坑智能识别和年代标定方面取得突破性进展，新识别月球上近11万个撞击坑，并有超过18000个撞击坑被标定了地质年代。"  , NewsWriter = "谢博韬"   , NewsTitle = "中外科学家合作新识别月球上近11万个撞击坑"  , NewsSource = "新华网"   , NewsKeywords = "撞击坑,月球探测,中外合作"   , ReleaseTime = DateTime.Parse("2020-12-26 11:03Z")   ,
                             NewsContent = c.news5   ,
                             ImageURL = "Image/News/new005.jpg"   , ReadingNum = 423745  },
                new NewsDb { NewsId = "6" ,  TypeID =3 , RankID =3 , NewsDescribed = "中国药科大学洪浩团队经多年研究发现，一种名为TGR5的受体与抑郁行为相关，这为研发新型抗抑郁药物提供了新思路。相关成果近日发表在国际神经精神领域学术期刊《生物精神病学》上。"   , NewsWriter = "谢博韬"  , NewsTitle = "中国药科大学一科研团队发现治疗抑郁症的新靶标" , NewsSource = "新华网"  , NewsKeywords = "抗抑郁作用,药科大学,靶标"  , ReleaseTime = DateTime.Parse("2020-12-26 10:26Z")  ,
                             NewsContent = c.news6  ,
                             ImageURL = "Image/News/new006.jpg"  , ReadingNum = 653235  },
                new NewsDb { NewsId = "7" ,  TypeID =4 , RankID =4 , NewsDescribed = "目前，强化控制血糖的观念已“深入人心”，越来越多的人开始关注如何降低高血糖。然而，随着血糖的达标，也增加了低血糖风险，以下4类人要尤为注意。"  , NewsWriter = "谢博韬"   , NewsTitle = "都在说控制血糖 这四类人群最该防低血糖"  , NewsSource = "人民网"   , NewsKeywords = "低血糖,血脂紊乱,氮质血症"   , ReleaseTime = DateTime.Parse("2020-12-26 10:22Z")   ,
                             NewsContent = c.news7   ,
                             ImageURL = "Image/News/new007.jpg"   , ReadingNum = 797245  },
                new NewsDb { NewsId = "8" ,  TypeID =4 , RankID =3 , NewsDescribed = "前不久，媒体报道称，广东佛山一名女童在奶奶不注意的情况下，误服了放在桌上的降压药，后因未及时送医，孩子在误服药两个多小时后经抢救无效不幸离世。"      , NewsWriter = "谢博韬"  , NewsTitle = "药不能吃错 误服药危害五花八门" , NewsSource = "人民网"  , NewsKeywords = "误服,泡腾片,家庭药箱"  , ReleaseTime = DateTime.Parse("2020-12-26 14:21Z")  ,
                             NewsContent = c.news8  ,
                             ImageURL = "Image/News/new008.jpg"  , ReadingNum = 879877  },
                new NewsDb { NewsId = "9" ,  TypeID =5 , RankID =4 , NewsDescribed = "王俭， 43岁，中共党员，从一名普通民警成长为派出所副所长、所长，一步一个脚印走过了19个春秋，现在也进入了不惑之年。"  , NewsWriter = "戴萌萌"   , NewsTitle = "邛崃公安的“工匠”人"  , NewsSource = "央视网 "   , NewsKeywords = "奉献,工匠,精神"   , ReleaseTime = DateTime.Parse("2020-12-25 10:41Z")   ,
                             NewsContent = c.news9   ,
                             ImageURL = "Image/News/new009.jpg"   , ReadingNum = 215785  },
                new NewsDb { NewsId = "10" , TypeID =5 , RankID =4 , NewsDescribed = "再次见到刘海婷和许国娟，她们依旧戴着口罩，面对患者，冲在一线。只是，她们脱下了防护服，回到各自的工作岗位，从“头版”回归平淡。"      , NewsWriter = "谢博韬"  , NewsTitle = "援鄂护士：曾经“上过头版”，归来仍冲一线" , NewsSource = "新华每日电讯"  , NewsKeywords = "奉献,牺牲,抗疫"  , ReleaseTime = DateTime.Parse("2020-12-25 14:59Z")  ,
                             NewsContent = c.news10  ,
                             ImageURL = "Image/News/new010.jpg"  , ReadingNum = 548795  },
                new NewsDb { NewsId = "11" , TypeID =6 , RankID =4 , NewsDescribed = "南部战区海军某训练基地靶场，空气中弥漫着一股浓浓硝烟味，新兵自动步枪射击考核紧张进行中。"  , NewsWriter = "汪佳莹 "   , NewsTitle = "这批新兵赶上了“模块化组训”"  , NewsSource = "解放军报"   , NewsKeywords = "新兵,训练,模块化"   , ReleaseTime = DateTime.Parse("2020-12-24 07:17Z")   ,
                             NewsContent = c.news11  ,
                             ImageURL = "Image/News/new011.jpg"   , ReadingNum = 787574  },
                new NewsDb { NewsId = "12" , TypeID =6 , RankID =4 , NewsDescribed = "12月22日，中国与俄罗斯两国空军位亚太地区组织实施第二次联合空中战略巡航。"    , NewsWriter = "谢博韬 "  , NewsTitle = "中俄两军组织实施第二次联合空中战略巡航" , NewsSource = "解放军报"  , NewsKeywords = "巡航,演习"  , ReleaseTime = DateTime.Parse("2020-12-23 02:21Z")  ,
                             NewsContent = c.news12  ,
                             ImageURL = "Image/News/new012.jpg"  , ReadingNum = 54457  },
                new NewsDb { NewsId = "13" , TypeID =7 , RankID =4 , NewsDescribed = "2021年元旦期间，中央广播电视总台推出多档节目共迎新年，数十位港澳台艺人参加总台多场迎新年盛典，同心唱祝福，欢聚迎新年。"  , NewsWriter = "戴萌萌"  , NewsTitle = "精彩！港澳台艺人加盟总台多场迎新年盛典"  , NewsSource = "中央广播电视总台央视文艺"  , NewsKeywords =  "港澳台,新年盛典"   , ReleaseTime = DateTime.Parse("2020-12-29 12:34Z")   ,
                             NewsContent = c.news13   ,
                             ImageURL = "Image/News/new013.jpg"   , ReadingNum = 487254  },
                new NewsDb { NewsId = "14" , TypeID =7 , RankID =4 , NewsDescribed = "三年前，号称“史上尺度最大”的反腐剧《人民的名义》以最高收视率破8的成绩，创造了近十年国产剧收视最高纪录。目前正在湖南卫视播出的《巡回检察组》，则聚齐了《人民的名义》原班人马强势回归。"  , NewsWriter = "邱伟"  , NewsTitle = "同写检察官 看点各不同"  , NewsSource = "北京日报"  , NewsKeywords =  "巡回检查组,人民的名义"   , ReleaseTime = DateTime.Parse("2020-12-29 10:26Z")   ,
                             NewsContent = c.news14 ,
                             ImageURL = "Image/News/new014.jpg"  , ReadingNum = 468684  },
                new NewsDb { NewsId = "15" , TypeID =8 , RankID =4 , NewsDescribed = "当地时间2020年12月28日，法国马赛，由于清洁工罢工，街头垃圾堆积成山。"  , NewsWriter = "人民视觉"  , NewsTitle = "法国清洁工罢工 马赛街头垃圾堆积成山"  , NewsSource = "央视网"  , NewsKeywords =  "法国,清洁工,罢工"   , ReleaseTime = DateTime.Parse("2020-12-29 13:30Z")   ,
                             NewsContent = c.news15   ,
                             ImageURL = "Image/News/new015.jpg"   , ReadingNum = 54648  },
                new NewsDb { NewsId = "16" , TypeID =8 , RankID =4 , NewsDescribed = "韩国法务部28日表示，首尔东部拘留所对27日第二次新冠全面检测中呈阴性的1689人进行第三次检测，共233人检测结果呈阳性。由此，该拘留所确诊病例累计达748例。"  , NewsWriter = "苏璇"  , NewsTitle = "韩国前总统李明博所在监狱累计确诊748例 总理表惭愧"  , NewsSource = "中国新闻网"  , NewsKeywords =  "李明博,首尔"   , ReleaseTime = DateTime.Parse("2020-12-29 10:14Z")   ,
                             NewsContent = c.news16   ,
                             ImageURL = "Image/News/new016.jpg"  , ReadingNum = 543488  },
                new NewsDb { NewsId = "17" , TypeID =1 , RankID =4 , NewsDescribed = "从2021年1月1日起，上海首批15个主要健身品牌400余家门店将正式实行“健身会员卡办卡七天冷静期”。"  , NewsWriter = "王玉西"  , NewsTitle = "上海：办理健身卡将有七天“冷静期”"  , NewsSource = "新华网"  , NewsKeywords =  "上海,健身卡,冷静期"   , ReleaseTime = DateTime.Parse("2020-12-29 07:36Z")   ,
                             NewsContent = c.news17   ,
                             ImageURL = "Image/News/new017.jpg"   , ReadingNum = 457846  },
                new NewsDb { NewsId = "18" , TypeID =1 , RankID =4 , NewsDescribed = "近日，陕西汉中市民王先生自称购买的冷冻火腿肠中吃出老鼠腿。当地市场监督部门介入调查后公开回复称，“投诉人要求商家赔偿30万元至50万元”；涉事的内有老鼠腿的火腿肠，因完整性遭到破坏无法送检。"  , NewsWriter = "黄佐春"  , NewsTitle = "自称在火腿肠中吃出老鼠腿 当事人否认索赔30万元"  , NewsSource = "澎湃新闻"  , NewsKeywords =  "火腿肠,索赔,老鼠"   , ReleaseTime = DateTime.Parse("2020-12-28 16:34Z")   ,
                             NewsContent = c.news18   ,
                             ImageURL = "Image/News/new018.jpg"  , ReadingNum = 486468  },
                new NewsDb { NewsId = "19" , TypeID =1 , RankID =3 , NewsDescribed = "外交部发言人赵立坚表示，西藏问题事关中国主权和领土完整，纯属中国内政，不容任何外部势力干涉。中国政府维护国家主权、安全、发展利益的决心坚定不移。"  , NewsWriter = "郭倩"  , NewsTitle = "外交部回应美方签署涉藏、涉台法案"  , NewsSource = "央视新闻客户端"  , NewsKeywords =  "外交部"   , ReleaseTime = DateTime.Parse("2020-12-29 00:13Z")   ,
                             NewsContent = c.news19   ,
                             ImageURL = "Image/News/new019.jpg"   , ReadingNum = 2454546  },
                new NewsDb { NewsId = "20" , TypeID =1 , RankID =4 , NewsDescribed = "北京官方表示，随着元旦、春节临近，将迎来人员流动、聚集高峰，要适度从严从紧做好“两节”期间疫情防控工作，严控中转入境进京。倡导民众非必要不出京，做到非必要不出境。"  , NewsWriter = "谢博韬"  , NewsTitle = "连续两天新增本地无症状感染者 北京倡导非必要不出京"  , NewsSource = "中新社"  , NewsKeywords =  "疫情防控,感染者,无症状"   , ReleaseTime = DateTime.Parse("2020-12-25 14:05Z")   ,
                             NewsContent = c.news20   ,
                             ImageURL = "Image/News/new020.jpg"  , ReadingNum = 548796  },
                new NewsDb { NewsId = "21" , TypeID =1 , RankID =3 , NewsDescribed = "据“上海疾控”微信公众号消息，近日，上海市疾控中心在对英国输入的新冠肺炎确诊病例进行基因测序监测中，发现1例病例的新冠病毒基因序列为B.1.1.7亚型，与近期英国报道的变异病毒基因相似。"  , NewsWriter = "程祥"  , NewsTitle = "上海发现一境外输入病例 基因序列与英国报道变异病毒相似"  , NewsSource = "中国新闻网"  , NewsKeywords =  "上海,疫情,病例"   , ReleaseTime = DateTime.Parse("2021-01-01 17:23Z")   ,
                             NewsContent = c.news21   ,
                             ImageURL = "Image/News/new021.jpg"  , ReadingNum = 548696  },
                new NewsDb { NewsId = "22" , TypeID =2 , RankID =4 , NewsDescribed = "不法分子境外成立赌博公司，向境内发布广告吸引万余名赌客，记者日前从安徽省马鞍山市当涂县公安局了解到，当地警方打掉了这个犯罪团伙，抓获犯罪嫌疑人24名，涉案流水达4.4亿元。 "  , NewsWriter = "苏璇"  , NewsTitle = "安徽警方破获特大跨境网络赌博案 涉案资金达4.4亿元"  , NewsSource = "新华网"  , NewsKeywords =  "网络赌博,安徽"   , ReleaseTime = DateTime.Parse("2020-12-30 14:36Z")   ,
                             NewsContent = c.news22   ,
                             ImageURL = "Image/News/new022.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "23" , TypeID =2 , RankID =4 , NewsDescribed = "2020年以来，全国公安机关深入推进“净网2020”专项行动，截至12月20日，全国共侦办侵犯公民个人信息刑事案件3100余起，抓获犯罪嫌疑人9700余名。 "  , NewsWriter = "苏璇"  , NewsTitle = "2020年公安机关侦办侵犯公民个人信息刑事案件3100余起"  , NewsSource = "新华网 "  , NewsKeywords =  "个人信息,公安机关"   , ReleaseTime = DateTime.Parse("2020-12-30 14:32Z")   ,
                             NewsContent = c.news23   ,
                             ImageURL = "Image/News/new023.jpg"  , ReadingNum = 755696  },
                new NewsDb { NewsId = "24" , TypeID =2 , RankID =4 , NewsDescribed = "近日，甘肃省敦煌市人民检察院依法以涉嫌强迫交易罪对嫌疑人邸某某等7人提起公诉，案件正在进一步办理中。"  , NewsWriter = "黄佐春"  , NewsTitle = "敦煌“陷阱公厕事件”7人被公诉：涉嫌强迫交易罪"  , NewsSource = "澎湃新闻 "  , NewsKeywords =  "强迫交易罪,提起公诉,涉嫌"   , ReleaseTime = DateTime.Parse("2020-12-28 15:28Z")   ,
                             NewsContent = c.news24   ,
                             ImageURL = "Image/News/new024.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "25" , TypeID =3 , RankID =4 , NewsDescribed = "国务院联防联控机制今日（12月31日）举行新闻发布会。科学技术部、国家卫生健康委员会、国家药品监督管理局、外交部、工业和信息化部有关负责人，疫苗研发专班专家，国药集团负责人介绍新冠病毒疫苗有关情况并答记者问。"  , NewsWriter = "钱景童"  , NewsTitle = "重磅！中国新冠病毒疫苗获批上市 保护率79.34%"  , NewsSource = "国药集团药监局新冠"  , NewsKeywords =  "国药集团,药监局,新冠"   , ReleaseTime = DateTime.Parse("2020-12-31 11:07Z")   ,
                             NewsContent = c.news25   ,
                             ImageURL = "Image/News/new025.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "26" , TypeID =3 , RankID =4 , NewsDescribed = "韩国超导托卡马克先进研究(KSTAR)中心宣布，在与首尔国立大学和美国哥伦比亚大学的联合研究中，成功让等离子体在超过1亿摄氏度高温下连续运行了20秒。"  , NewsWriter = "谢博韬"  , NewsTitle = "韩国人造太阳一亿度高温下运行20秒"  , NewsSource = "中国纪检监察报"  , NewsKeywords =  "人造太阳,KSTAR,等离子体"   , ReleaseTime = DateTime.Parse("2020-12-31 06:36Z")   ,
                             NewsContent = c.news26   ,
                             ImageURL = "Image/News/new026.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "27" , TypeID =3 , RankID =4 , NewsDescribed = "天文预报显示，即将到来的2021年1月，蜂巢星团伴月、象限仪流星雨极大、金星合月、火星合月、水星东大距等天象将依次登场，闪亮天宇。"  , NewsWriter = "苏璇"  , NewsTitle = "2021年1月天宇将迎来象限仪流星雨极大、水星东大距等天象"  , NewsSource = "新华社"  , NewsKeywords =  "流星雨,水星"   , ReleaseTime = DateTime.Parse("2020-12-30 10:28Z")   ,
                             NewsContent = c.news27   ,
                             ImageURL = "Image/News/new027.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "28" , TypeID =4 , RankID =4 , NewsDescribed = "中国气象局今天发布元旦假日期间（2021年1月1—3日）天气预测，预计假日期间冷空气势力弱，全国大部分地区以晴到多云天气为主，风力不大，中东部地区气温呈逐步回升趋势，但元旦当天受前期寒潮影响，气温仍较常年同期显著偏低。"  , NewsWriter = "钱景童"  , NewsTitle = "元旦假期全国天气晴好 气温仍将偏低"  , NewsSource = "央视新闻"  , NewsKeywords =  "天气预测,全国天气,多云天气"   , ReleaseTime = DateTime.Parse("2020-12-31 11:14Z")   ,
                             NewsContent = c.news28   ,
                             ImageURL = "Image/News/new028.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "29" , TypeID =4 , RankID =4 , NewsDescribed = "受寒潮天气影响，北京12月29日最高气温创近30年12月同期新低。目前虽然寒潮接近尾声，但强冷空气威力仍在，预计元旦假期期间气温仍较低，白天最高气温维持在冰点附近。"  , NewsWriter = "苏璇"  , NewsTitle = "北京最高气温创近30年12月同期新低 元旦假期继续“冰冻”"  , NewsSource = "中国天气网"  , NewsKeywords =  "最低气温,寒潮天气"   , ReleaseTime = DateTime.Parse("2020-12-30 14:39Z")   ,
                             NewsContent = c.news29   ,
                             ImageURL = "Image/News/new029.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "30" , TypeID =4 , RankID =4 , NewsDescribed = "今天（12月30日），北京仍有大风劲吹，阵风6至7级，白天最高气温将仅有-6℃，夜间最低气温-13℃，寒潮、持续低温和大风蓝色预警中，需注意防范。"  , NewsWriter = "苏璇"  , NewsTitle = "北京今日寒冷依旧阵风6至7级 跨年夜最低温不足零下10℃"  , NewsSource = "中国天气网"  , NewsKeywords =  "北京,大风"   , ReleaseTime = DateTime.Parse("2020-12-30 09:14Z")   ,
                             NewsContent = c.news30   ,
                             ImageURL = "Image/News/new030.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "31" , TypeID =9 , RankID =4 , NewsDescribed = "12月8日，2020年度央视网教育盛典在京召开。论坛以“云生态·话未来”新时代高质量发展为主题，聚焦教育行业，表彰先进典型，研讨教育发展新变革，把脉教育发展新方向。"  , NewsWriter = "黄佐春"  , NewsTitle = "岳喜伟：创新能力和跨学科学习的能力对成长至关重要"  , NewsSource = "央视网"  , NewsKeywords =  "央视网教育盛典,岳喜伟"   , ReleaseTime = DateTime.Parse("2020-12-29 16:19Z")   ,
                             NewsContent = c.news31   ,
                             ImageURL = "Image/News/new031.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "32" , TypeID =9 , RankID =4 , NewsDescribed = "12月8日，2020年度央视网教育盛典在京召开。论坛以“云生态·话未来”新时代高质量发展为主题，聚焦教育行业，表彰先进典型，研讨教育发展新变革，把脉教育发展新方向。"  , NewsWriter = "黄佐春"  , NewsTitle = "李旭蓉：教育的本质最终还是回归质量本身"  , NewsSource = "央视网"  , NewsKeywords =  "央视网教育盛典,李旭蓉"   , ReleaseTime = DateTime.Parse("2020-12-29 16:16Z")   ,
                             NewsContent = c.news32   ,
                             ImageURL = "Image/News/new032.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "33" , TypeID =9 , RankID =4 , NewsDescribed = "12月8日，2020年度央视网教育盛典在京召开。论坛以“云生态·话未来”新时代高质量发展为主题，聚焦教育行业，表彰先进典型，研讨教育发展新变革，把脉教育发展新方向。"  , NewsWriter = "黄佐春"  , NewsTitle = "梅海英：培养良好的学习习惯是最重要的"  , NewsSource = "央视网"  , NewsKeywords =  "央视网教育盛典,梅海英"   , ReleaseTime = DateTime.Parse("2020-12-29 16:12Z")   ,
                             NewsContent = c.news33   ,
                             ImageURL = "Image/News/new033.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "34" , TypeID =6 , RankID =4 , NewsDescribed = "为了人民群众勇于奉献是军人该有的样子。应该把这种奉献精神传承发扬。"  , NewsWriter = "刘亮"  , NewsTitle = "把奉献精神传承发扬：武警河池支队迎新战友“回家”"  , NewsSource = "央视网"  , NewsKeywords =  "武警,新战友,军人"   , ReleaseTime = DateTime.Parse("2021-01-01 12:42Z")   ,
                             NewsContent = c.news34   ,
                             ImageURL = "Image/News/new034.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "35" , TypeID =6 , RankID =4 , NewsDescribed = "通过这些活动，旨在让广大新兵体悟军人的使命感，荣誉感，切实感受到革命老区的光荣传统，坚定新战友扎根边疆、奉献老区、争当红军传人，争做最美百色兵的信心信念。"  , NewsWriter = "刘亮"  , NewsTitle = "武警百色支队：接枪 红城我们一起守护"  , NewsSource = "央视网"  , NewsKeywords =  "武警,百色,新兵"   , ReleaseTime = DateTime.Parse("2021-01-01 12:34Z")   ,
                             NewsContent = c.news35   ,
                             ImageURL = "Image/News/new035.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "36" , TypeID =6 , RankID =4 , NewsDescribed = "近日，武警桂林支队各基层中队营区内锣鼓喧天、鞭炮齐鸣，全体官兵列队欢迎新战友的到来。全体新兵在经历三个月的新训磨练后，带着新的理想和目标奔向新的岗位，翻开自己军旅生涯的崭新篇章。"  , NewsWriter = "刘亮"  , NewsTitle = "破茧成蝶 “00”后新兵踏上军旅生涯新征程！"  , NewsSource = "央视网"  , NewsKeywords =  "新兵,军旅,军营"   , ReleaseTime = DateTime.Parse("2021-01-01 12:28Z")   ,
                             NewsContent = c.news36   ,
                             ImageURL = "Image/News/new036.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "37" , TypeID =7 , RankID =4 , NewsDescribed = "来了！新年节目已安排。"  , NewsWriter = "黄佐春"  , NewsTitle = "新年看什么？节目已安排！来，总台带你“花式”跨年"  , NewsSource = "中央广播电视总台央视新闻"  , NewsKeywords =  "节目,总台"   , ReleaseTime = DateTime.Parse("2020-12-31 20:35Z")   ,
                             NewsContent = c.news37   ,
                             ImageURL = "Image/News/new037.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "38" , TypeID =7 , RankID =4 , NewsDescribed = "2021年元旦、春节将至，文化和旅游部提醒广大游客，非必要不安排出境旅游，国内旅游做好个人健康防护。"  , NewsWriter = "苏璇"  , NewsTitle = "“两节”将至，文旅部提醒：非必要不安排出境旅游"  , NewsSource = "中国新闻网"  , NewsKeywords =  "出境旅游,文旅部"   , ReleaseTime = DateTime.Parse("2020-12-30 14:57Z")   ,
                             NewsContent = c.news38   ,
                             ImageURL = "Image/News/new038.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "39" , TypeID =7 , RankID =4 , NewsDescribed = "2020年贺岁档35天（11月27日至12月31日）及春节档7天（2月11日至2月17日）“吸睛”影片排片不断。"  , NewsWriter = "汪佳莹"  , NewsTitle = "冲刺贺岁档 院线营收有望恢复"  , NewsSource = "经济参考报"  , NewsKeywords =  "院线,影片"   , ReleaseTime = DateTime.Parse("2020-12-28 10:09Z")   ,
                             NewsContent = c.news39   ,
                             ImageURL = "Image/News/new039.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "40" , TypeID =8 , RankID =4 , NewsDescribed = "中国驻埃及大使廖力强31日代表中国国家卫生健康委员会和埃及卫生与人口部副部长穆罕默德·哈桑尼共同签署《中埃关于新冠病毒疫苗合作意向书》。"  , NewsWriter = "赵晋"  , NewsTitle = "中国与埃及签署关于新冠病毒疫苗合作意向书"  , NewsSource = "新华社"  , NewsKeywords =  "新冠,埃及,病毒疫苗"   , ReleaseTime = DateTime.Parse("2021-01-01 18:28Z")   ,
                             NewsContent = c.news40   ,
                             ImageURL = "Image/News/new040.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "41" , TypeID =8 , RankID =4 , NewsDescribed = "据俄罗斯卫星网1日报道，俄罗斯国家航天集团总裁德米特里·罗戈津表示，国际空间站俄罗斯服务舱上的裂痕，可能是由微型陨石或技术原因造成。"  , NewsWriter = "程祥"  , NewsTitle = "国际空间站裂痕由微型陨石造成？俄航天集团这么说"  , NewsSource = "中国新闻网"  , NewsKeywords =  "国际空间站,裂痕"   , ReleaseTime = DateTime.Parse("2021-01-01 16:04Z")   ,
                             NewsContent = c.news41   ,
                             ImageURL = "Image/News/new041.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "42" , TypeID =8 , RankID =4 , NewsDescribed = "美国威斯康星州一家医疗机构的一名工作人员故意毁坏了500多剂莫德纳新冠疫苗，其作案动机不明，现已被解雇。"  , NewsWriter = "钱景童"  , NewsTitle = "美医疗机构员工故意毁坏500剂新冠疫苗 动机不明"  , NewsSource = "海外网"  , NewsKeywords =  "新冠,医疗机构,故意毁坏"   , ReleaseTime = DateTime.Parse("2020-12-31 17:23Z")   ,
                             NewsContent = c.news42   ,
                             ImageURL = "Image/News/new042.jpg"  , ReadingNum = 545696  },
                new NewsDb { NewsId = "43" , TypeID =1 , RankID =1 , NewsDescribed = "承诺如山，初心如磐。尽管这一年世纪疫情与百年变局交织，给本就艰苦卓绝的脱贫攻坚工作增加了难度，但如期打赢脱贫攻坚战，容不得半点懈怠和拖延。"  ,  NewsWriter = "康彦龙"  , NewsTitle = "回眸2020｜郑重承诺"  ,NewsSource = "央视网"  , NewsKeywords =  "人民领袖,习近平"   , ReleaseTime = DateTime.Parse("2021-01-03 21:20Z")   ,
                             NewsContent = c.news43   ,
                             ImageURL = "Image/News/new043.jpg"  , ReadingNum = 65456967  },
                new NewsDb { NewsId = "44" , TypeID =1 , RankID =1 , NewsDescribed = "随着国产新冠病毒疫苗附条件上市，上海、北京、山东等多个省份加快启动大规模接种。怎么预约、谁能尽快打？哪些禁忌症不能接种？有不良反应怎么办？针对公众关心的问题，有关部门作出权威回应。"  , NewsWriter = "钱景童"  , NewsTitle = "疫苗接种八大关切，权威回应来了！"  , NewsSource = "新华网"  , NewsKeywords =  "疫苗接种"   , ReleaseTime = DateTime.Parse("2021-01-05 04:08Z")   ,
                             NewsContent = c.news44   ,
                             ImageURL = "Image/News/new044.jpg"  , ReadingNum = 7954515  },
                new NewsDb { NewsId = "45" , TypeID =8 , RankID =1 , NewsDescribed = "据外交部官网消息，1月4日，外交部发言人华春莹主持例行记者会。针对纽交所摘牌三家中国电信企业，华春莹指出，中方坚决反对美国政府将经贸问题政治化，滥用国家力量、泛化国家安全概念，无端打压中国企业"  , NewsWriter = "钱景童"  , NewsTitle = "纽交所摘牌三家中国电信企业，外交部：将经贸问题政治化"  , NewsSource = "中国新闻网"  , NewsKeywords =  "外交部,华春莹,电信企业"   , ReleaseTime = DateTime.Parse("2021-01-05 05:02Z")   ,
                             NewsContent = c.news45   ,
                             ImageURL = "Image/News/new045.jpg"  , ReadingNum = 78541219  },

             };
            NewsDb.ForEach(p => context.NewsDb.Add(p));
            context.SaveChanges();


            var CommentDb = new List<CommentDb>
             {
                new CommentDb { CommentID =1 , NewsId = "1" , UserID =1 , CommentContent = "做好防疫准备"  , CommentTime = DateTime.Parse("2007-8-1") },
                new CommentDb { CommentID =2 , NewsId = "1" , UserID =2 , CommentContent = "考生加油",       CommentTime = DateTime.Parse("2077-2-11") },
             };
            CommentDb.ForEach(p => context.CommentDb.Add(p));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}