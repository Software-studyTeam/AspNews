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
                new TypeDb { TypeID =1 , TypeName = "社会" },
                new TypeDb { TypeID =2 , TypeName = "法治" },
                new TypeDb { TypeID =3 , TypeName = "科技" },
                new TypeDb { TypeID =4 , TypeName = "生活" },
                new TypeDb { TypeID =5 , TypeName = "人物" },
                new TypeDb { TypeID =6 , TypeName = "军事" },
                new TypeDb { TypeID =7 , TypeName = "娱乐" },
                new TypeDb { TypeID =8 , TypeName = "国际" },
                new TypeDb { TypeID =9 , TypeName = "教育" },
             };
            TypeDb.ForEach(p => context.TypeDb.Add(p));
            context.SaveChanges();

            var NewsDb = new List<NewsDb>
             {
                new NewsDb { NewsId = "1" ,  TypeID =9 , RankID =3 , NewsDescribed = "26日起，2021年全国硕士研究生招生考试将举行，本次考试报考人数达到377万人，创历史新高。在疫情防控的大背景下，各地就本次考试的防疫措施进行了部署。同时，教育部也强调，坚决维护研招考试公平公正，并公布考试违规违法行为举报电话。"  , NewsWriter = "邢斯馨"   , NewsTitle = "2021考研开考：377万人报名 各地强调考场防疫"  , NewsSource = "中国新闻网"   , NewsKeywords = "考试报名,考场纪律"   , ReleaseTime = DateTime.Parse("2020-12-26")   , 
                             NewsContent = "无"   , ImageURL = "Image/News/new001.jpg"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "2" ,  TypeID =9 , RankID =4 , NewsDescribed = "记者25日获悉，教育部今天召开视频调度会议，研究部署今冬明春教育系统疫情防控工作提出，今冬明春是疫情防控的关键时期，教育系统要科学精准做好寒假期间疫情防控工作，确保春季学期高校错峰开学，妥善安排留校师生学习和生活。"      , NewsWriter = "邢斯馨"  , NewsTitle = "教育部要求确保春季学期高校错峰开学" , NewsSource = "新华社“新华视点”微博"  , NewsKeywords = "错峰,开学,教育部"  , ReleaseTime = DateTime.Parse("2020-12-25")  , 
                             NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News2"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "3" ,  TypeID =2 , RankID =4 , NewsDescribed = "广东海警局近日联合多地海关缉私部门成功打掉5个长期活跃在广东海域的走私成品油团伙。初步查证涉案柴油约16万吨，案值约8亿元，涉嫌偷逃税款约4亿元。"  , NewsWriter = "谢博韬"   , NewsTitle = "中国海警破获特大涉嫌走私成品油案 案值约8亿元"  , NewsSource = "新华网"   , NewsKeywords = "中国海警,走私,成品油"  , ReleaseTime = DateTime.Parse("2020-12-26")   , 
                             NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News3"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "4" ,  TypeID =2 , RankID =3 , NewsDescribed = "骗取、贪污土地开发补偿款高达5亿余元；安排其父亲、妻子、兄弟及亲信入选村“两委”，把持基层政权达30多年；无恶不作，实施抢劫致1人死亡"      , NewsWriter = "谢博韬"  , NewsTitle = "一涉黑案件挖出腐败及“保护伞”93人" , NewsSource = "法治日报"  , NewsKeywords = "保护伞,涉黑,办案"  , ReleaseTime = DateTime.Parse("2020-12-26")  ,
                             NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News4"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "5" ,  TypeID =3 , RankID =4 , NewsDescribed = "我国科学家领衔的一支国际研究团队在探月领域再出新成果。该团队在月球撞击坑智能识别和年代标定方面取得突破性进展，新识别月球上近11万个撞击坑，并有超过18000个撞击坑被标定了地质年代。"  , NewsWriter = "谢博韬"   , NewsTitle = "中外科学家合作新识别月球上近11万个撞击坑"  , NewsSource = "新华网"   , NewsKeywords = "撞击坑,月球探测,中外合作"   , ReleaseTime = DateTime.Parse("2020-12-26")   ,
                             NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News5"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "6" ,  TypeID =3 , RankID =3 , NewsDescribed = "中国药科大学洪浩团队经多年研究发现，一种名为TGR5的受体与抑郁行为相关，这为研发新型抗抑郁药物提供了新思路。相关成果近日发表在国际神经精神领域学术期刊《生物精神病学》上。"   , NewsWriter = "谢博韬"  , NewsTitle = "中国药科大学一科研团队发现治疗抑郁症的新靶标" , NewsSource = "新华网"  , NewsKeywords = "抗抑郁作用,药科大学,靶标"  , ReleaseTime = DateTime.Parse("2020-12-26")  ,
                             NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News6"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "7" ,  TypeID =4 , RankID =4 , NewsDescribed = "目前，强化控制血糖的观念已“深入人心”，越来越多的人开始关注如何降低高血糖。然而，随着血糖的达标，也增加了低血糖风险，以下4类人要尤为注意。"  , NewsWriter = "谢博韬"   , NewsTitle = "都在说控制血糖 这四类人群最该防低血糖"  , NewsSource = "人民网"   , NewsKeywords = "低血糖,血脂紊乱,氮质血症"   , ReleaseTime = DateTime.Parse("2020-12-26")   ,
                             NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News7"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "8" ,  TypeID =4 , RankID =3 , NewsDescribed = "前不久，媒体报道称，广东佛山一名女童在奶奶不注意的情况下，误服了放在桌上的降压药，后因未及时送医，孩子在误服药两个多小时后经抢救无效不幸离世。"      , NewsWriter = "谢博韬"  , NewsTitle = "药不能吃错 误服药危害五花八门" , NewsSource = "人民网"  , NewsKeywords = "误服,泡腾片,家庭药箱"  , ReleaseTime = DateTime.Parse("2020-12-26")  , 
                             NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News8"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "9" ,  TypeID =5 , RankID =4 , NewsDescribed = "王俭， 43岁，中共党员，从一名普通民警成长为派出所副所长、所长，一步一个脚印走过了19个春秋，现在也进入了不惑之年。"  , NewsWriter = "戴萌萌"   , NewsTitle = "邛崃公安的“工匠”人"  , NewsSource = "央视网 "   , NewsKeywords = "奉献,工匠,精神"   , ReleaseTime = DateTime.Parse("2020-12-25")   , 
                             NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News9"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "10" , TypeID =5 , RankID =4 , NewsDescribed = "再次见到刘海婷和许国娟，她们依旧戴着口罩，面对患者，冲在一线。只是，她们脱下了防护服，回到各自的工作岗位，从“头版”回归平淡。"      , NewsWriter = "谢博韬"  , NewsTitle = "援鄂护士：曾经“上过头版”，归来仍冲一线" , NewsSource = "新华每日电讯"  , NewsKeywords = "奉献,牺牲,抗疫"  , ReleaseTime = DateTime.Parse("2020-12-25")  ,
                             NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News10"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "11" , TypeID =6 , RankID =4 , NewsDescribed = "南部战区海军某训练基地靶场，空气中弥漫着一股浓浓硝烟味，新兵自动步枪射击考核紧张进行中。"  , NewsWriter = "汪佳莹 "   , NewsTitle = "这批新兵赶上了“模块化组训”"  , NewsSource = "解放军报"   , NewsKeywords = "新兵,训练,模块化"   , ReleaseTime = DateTime.Parse("2020-12-24")   ,
                             NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News11"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "12" , TypeID =6 , RankID =4 , NewsDescribed = "12月22日，中国与俄罗斯两国空军位亚太地区组织实施第二次联合空中战略巡航。"    , NewsWriter = "谢博韬 "  , NewsTitle = "中俄两军组织实施第二次联合空中战略巡航" , NewsSource = "解放军报"  , NewsKeywords = "巡航,演习"  , ReleaseTime = DateTime.Parse("2020-12-23")  , 
                             NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News12"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "13" , TypeID =7 , RankID =1 , NewsDescribed = "做好防疫准备"  , NewsWriter = "2007-8-1"   , NewsTitle = "2007-8-1"  , NewsSource = "2007-8-1"   , NewsKeywords = "2007-8-1"   , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News13"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "14" , TypeID =7 , RankID =2 , NewsDescribed = "考生加油"      , NewsWriter = "2077-2-30"  , NewsTitle = "2077-2-30" , NewsSource = "2077-2-30"  , NewsKeywords = "2077-2-30"  , ReleaseTime = DateTime.Parse("2007-2-10")  , NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News14"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "15" , TypeID =8 , RankID =1 , NewsDescribed = "做好防疫准备"  , NewsWriter = "2007-8-1"   , NewsTitle = "2007-8-1"  , NewsSource = "2007-8-1"   , NewsKeywords = "2007-8-1"   , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News15"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "16" , TypeID =8 , RankID =2 , NewsDescribed = "考生加油"      , NewsWriter = "2077-2-30"  , NewsTitle = "2077-2-30" , NewsSource = "2077-2-30"  , NewsKeywords = "2077-2-30"  , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News16"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "17" , TypeID =1 , RankID =1 , NewsDescribed = "做好防疫准备"  , NewsWriter = "2007-8-1"   , NewsTitle = "2007-8-1"  , NewsSource = "2007-8-1"   , NewsKeywords = "2007-8-1"   , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News17"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "18" , TypeID =1 , RankID =2 , NewsDescribed = "考生加油"      , NewsWriter = "2077-2-30"  , NewsTitle = "2077-2-30" , NewsSource = "2077-2-30"  , NewsKeywords = "2077-2-30"  , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News18"  , ReadingNum = 100000  },
                new NewsDb { NewsId = "19" , TypeID =1 , RankID =1 , NewsDescribed = "做好防疫准备"  , NewsWriter = "2007-8-1"   , NewsTitle = "2007-8-1"  , NewsSource = "2007-8-1"   , NewsKeywords = "2007-8-1"   , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"   , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News19"   , ReadingNum = 100000  },
                new NewsDb { NewsId = "20" , TypeID =1 , RankID =2 , NewsDescribed = "考生加油"      , NewsWriter = "2077-2-30"  , NewsTitle = "2077-2-30" , NewsSource = "2077-2-30"  , NewsKeywords = "2077-2-30"  , ReleaseTime = DateTime.Parse("2007-8-1")   , NewsContent = "无"  , ImageURL = "E:\\AspNews\\AspNews\\Image\\NewsImage\\News20"  , ReadingNum = 100000  },

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