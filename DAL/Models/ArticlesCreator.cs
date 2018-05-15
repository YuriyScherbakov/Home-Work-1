﻿using System;
using System.Collections.Generic;

namespace DAL.Models
    {
    public class ArticlesCreator
        {
        static IList<Article> articles;
        public static IList<Article> GetArticles ()
            {
            return articles;
            }
        static ArticlesCreator ()
            {
            articles = new List<Article> () {
                new Article () {
                    Id =1, Name="5 мест, которые вы обязаны посетить в Париже", PublicationDate=DateTime.Parse("2/10/2017"),
                    Text ="От этих печальных размышлений ее отвлек сильный плеск воды." +
                          " Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде так громко," +
                          " что сперва она было подумала, что это морж, а то и бегемот, и даже чуточку" +
                          " испугалась, но потом вспомнила, какая она сейчас маленькая, успокоилась " +
                          "(«Он меня и не заметит», – подумала она), подплыла поближе и увидела, что это " +
                          "всего-навсего #мышка, которая, очевидно, тоже нечаянно попала в этот плачевный " +
                          "пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью? Может, она мне чем-нибудь" +
                          " поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что тут такого, сегодня и не то бывало!" +
                          " Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь! От этих печальных размышлений ее отвлек" +
                          " сильный плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде так громко, что сперва" +
                          " она было подумала, что это морж, а то и бегемот, и даже чуточку испугалась, но потом вспомнила, какая она" +
                          " сейчас маленькая, успокоилась («Он меня и не заметит», – подумала она), подплыла поближе и увидела, что это " +
                          "всего-навсего #мышка, которая, очевидно, тоже нечаянно попала в этот плачевный пруд и тоже пыталась выбраться " +
                          "на твердую почву. «Заговорить, что ли, с этой Мышью? Может, она мне чем-нибудь поможет? – подумала Алиса. – А" +
                          " уж говорить-то она, наверное, умеет – что тут такого, сегодня и не то бывало! Заговорю с ней – попытка не" +
                          " пытка». И она заговорила: – О Мышь!"

                },
                new Article () {
                    Id =2, Name="5 эффективных каналов рекламы интернет-магазинов", PublicationDate=DateTime.Parse("2/10/2017"),
                    Text ="Прежде всего он, как он выразился, «разметил инстанцию», – то есть нарисовал на земле круг (не очень" +
                          " ровный, но «точность тут не обязательна», сказал Дронт). Далее он расставил всех присутствующих но этому " +
                          "кругу (строго как попало). А потом… Вы, наверное, думаете: скомандовал «раз-два-три – марш!». Ничего подобного!" +
                          " Все начали бегать когда кому захотелось, и бежали кто куда хотел, и останавливались когда кто пожелает." +
                          " От этих печальных размышлений ее отвлек сильный плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и " +
                          "зашлепал по воде так громко, что сперва она было подумала, что это морж, а то и бегемот, и даже чуточку" +
                          " испугалась, но потом вспомнила, какая она сейчас маленькая, успокоилась («Он меня и не заметит», – подумала " +
                          "она), подплыла поближе и увидела, что это всего-навсего мышка, которая, очевидно, тоже нечаянно попала в этот " +
                          "плачевный пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью? Может, она мне " +
                          "чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что тут такого, сегодня и не" +
                          " то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!"
                },
                new Article () {
                    Id =3, Name="10 лучших городов для путешествия с детьми", PublicationDate=DateTime.Parse("2/10/2017"),
                    Text ="– А что такое это – Кросс по Инстанциям? – спросила Алиса. Не то чтобы ее это очень заинтересовало – просто " +
                          "она, по своей доброте, не могла не выручить Дронта: он явно ждал, что его засыплют вопросами, а все" +
                          " присутствующие тупо молчали… От этих печальных размышлений ее отвлек сильный плеск воды. Кто-то бултыхнулся" +
                          " в пруд неподалеку от нее и зашлепал по воде так громко, что сперва она было подумала, что это морж, а то и" +
                          " бегемот, и даже чуточку испугалась, но потом вспомнила, какая она сейчас маленькая, успокоилась («Он меня и" +
                          " не заметит», – подумала она), подплыла поближе и увидела, что это всего-навсего мышка, которая, очевидно, " +
                          "тоже нечаянно попала в этот плачевный пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли," +
                          " с этой Мышью? Может, она мне чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – " +
                          "что тут такого, сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!"
                },
                new Article () {
                    Id =4, Name="10 способов сделать рабочий день приятнее", PublicationDate=DateTime.Parse("2/10/2017"),
                    Text ="Как вы догадываетесь, во время этой церемонии Алису ужасно разбирал смех, но у всех остальных был такой " +
                          "торжественный и серьезный вид, что она сдержалась. Что полагается ответить на такие речи, она не знала, и" +
                          " потому просто поклонилась и приняла от Дронта наперсток, изо всех сил стараясь сохранить серьезное выражение " +
                          "лица. От этих печальных размышлений ее отвлек сильный плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее " +
                          "и зашлепал по воде так громко, что сперва она было подумала, что это морж, а то и бегемот, и даже чуточку" +
                          " испугалась, но потом вспомнила, какая она сейчас маленькая, успокоилась («Он меня и не заметит», – подумала " +
                          "она), подплыла поближе и увидела, что это всего-навсего мышка, которая, очевидно, тоже нечаянно попала в этот " +
                          "плачевный пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью? Может, она мне " +
                          "чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что тут такого, сегодня и не" +
                          " то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!"
                },
                new Article () {
                    Id =5, Name="11 преимуществ стеклянной мебели", PublicationDate=DateTime.Parse("2/10/2017"),
                    Text ="Теперь все с чистой совестью принялись за сладкое. Тут не обошлось без писка, визга и мелких происшествий; " +
                          "некоторые птицы покрупней жаловались, что не успели даже толком распробовать, а кое-кто из мелюзги второпях" +
                          " поперхнулся, их пришлось похлопать по спинке. Наконец и с угощением было покончено. Все опять уселись вокруг" +
                          " Мыши и стали ее просить рассказать еще что-нибудь. От этих печальных размышлений ее отвлек сильный плеск воды." +
                          " Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде так громко, что сперва она было подумала, что " +
                          "это морж, а то и бегемот, и даже чуточку испугалась, но потом вспомнила, какая она сейчас маленькая, " +
                          "успокоилась («Он меня и не заметит», – подумала она), подплыла поближе и увидела, что это всего-навсего мышка," +
                          " которая, очевидно, тоже нечаянно попала в этот плачевный пруд и тоже пыталась выбраться на твердую почву. " +
                          "«Заговорить, что ли, с этой Мышью? Может, она мне чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она," +
                          " наверное, умеет – что тут такого, сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она" +
                          " заговорила: – О Мышь!"
                },
                new Article () {
                    Id =6, Name="Анализ сайтов конкурентов", PublicationDate=DateTime.Parse("2/10/2017"),
                         Text ="Словом, очень скоро все под разными предлогами" +
                               " разлетелись кто куда, и Алиса осталась в одиночестве. «И зачем я только вспомнила про Диночку, –" +
                               " грустно подумала она. – Никому-то она тут не нравится, а ведь она такая хорошая кошечка, лучше ее нет" +
                               " на свете! Диночка ты моя дорогая, неужели я тебя вообще больше никогда не увижу!» От этих печальных " +
                               "размышлений ее отвлек сильный плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде" +
                               " так громко, что сперва она было подумала, что это морж, а то и бегемот, и даже чуточку испугалась, но " +
                               "потом вспомнила, какая она сейчас маленькая, успокоилась («Он меня и не заметит», – подумала она), " +
                               "подплыла поближе и увидела, что это всего-навсего мышка, которая, очевидно, тоже нечаянно попала в этот" +
                               " плачевный пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью? Может," +
                               " она мне чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что тут такого," +
                               " сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!",
                  },
                new Article () {
                    Id =7, Name="Борщ с фасолью. Pецепт приготовления", PublicationDate=DateTime.Parse("2/10/2017"),
                          Text ="Алиса сразу сообразила, что он ищет веер и бальные перчатки и, как девочка очень добрая, немедленно " +
                                "тоже принялась за поиски. Но ни веера, ни перчаток нигде не было видно, да, пожалуй, и искать их было " +
                                "бесполезно: все вокруг совершенно переменилось с тех пор, как Алиса купалась в слезах, и все громадное" +
                                " подземелье, где стоял стеклянный столик и была заветная дверца, исчезло без следа, словно его никогда и" +
                                " не было. Кролик вскоре заметил Алису, вертевшуюся поблизости, и сердито окликнул ее."
                },
                new Article () {
                    Id =8, Name="В чём заключается популярность натяжных потолков?", PublicationDate=DateTime.Parse("2/10/2017"),
                           Text ="Но она и без того была в незавидном положении: ей было тесно, неудобно, и, главное, не было никакой " +
                                 "надежды выбраться на волю. Не мудрено, что Алиса на минутку повесила нос. От этих печальных размышлений" +
                                 " ее отвлек сильный плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде так" +
                                 " громко, что сперва она было подумала, что это морж, а то и бегемот, и даже чуточку испугалась, но " +
                                 "потом вспомнила, какая она сейчас маленькая, успокоилась («Он меня и не заметит», – подумала она), " +
                                 "подплыла поближе и увидела, что это всего-навсего мышка, которая, очевидно, тоже нечаянно попала в " +
                                 "этот плачевный пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью?" +
                                 " Может, она мне чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что " +
                                 "тут такого, сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!"
                },
                new Article () {
                    Id =9, Name="Виды стиральных порошков для работы стиральной машины", PublicationDate=DateTime.Parse("2/10/2017"),
                            Text ="Она продолжала все в том же духе, изображая то одного, то другого собеседника, и беседа уже неплохо" +
                                  " налаживалась, как вдруг со двора до нее донесся чей-то крик. Алиса замолчала и прислушалась. От этих" +
                                  " печальных размышлений ее отвлек сильный плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и" +
                                  " зашлепал по воде так громко, что сперва она было подумала, что это морж, а то и бегемот, и даже" +
                                  " чуточку испугалась, но потом вспомнила, какая она сейчас маленькая, успокоилась («Он меня и не " +
                                  "заметит», – подумала она), подплыла поближе и увидела, что это всего-навсего мышка, которая, очевидно, " +
                                  "тоже нечаянно попала в этот плачевный пруд и тоже пыталась выбраться на твердую почву. «Заговорить," +
                                  " что ли, с этой Мышью? Может, она мне чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она," +
                                  " наверное, умеет – что тут такого, сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она" +
                                  " заговорила: – О Мышь!",
               },
                new Article () {
                    Id =10, Name="Вреден ли автозагар?", PublicationDate=DateTime.Parse("2/10/2017"),
                    Text ="И тут Алиса с удивлением заметила, что камешки на полу все превратились в печенье, и ее осенила блестящая" +
                          " мысль. «Если я съем хоть одну штучку, – подумала она, – я, наверное, сразу или вырасту, или наоборот. Но " +
                          "ведь расти-то мне дальше уже некуда, – значит, будет наоборот. Попробую!» Она сначала попробовала, а потом " +
                          "просто проглотила печеньице. И пришла в восторг – особенно когда заметила, что сразу начала уменьшаться!"
                },
                new Article () {
                    Id =11, Name="Выгоды удалённого бухгалтерского обслуживания", PublicationDate=DateTime.Parse("2/10/2017"),
                              Text ="Колоссальнейший лохматый щенок смотрел на нее сверху вниз большущими круглыми глазами, нерешительно" +
                                    " пытаясь потрогать ее лапкой (вернее, лапищей). От этих печальных размышлений ее отвлек сильный " +
                                    "плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде так громко, что сперва " +
                                    "она было подумала, что это морж, а то и бегемот, и даже чуточку испугалась, но потом вспомнила, " +
                                    "какая она сейчас маленькая, успокоилась («Он меня и не заметит», – подумала она), подплыла поближе " +
                                    "и увидела, что это всего-навсего мышка, которая, очевидно, тоже нечаянно попала в этот плачевный " +
                                    "пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью? Может, она мне " +
                                    "чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что тут такого, " +
                                    "сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!"
                },
                new Article () {
                    Id =12, Name="В чём секрет семейного благополучия?", PublicationDate=DateTime.Parse("2/10/2017"),
                               Text ="Алиса глядела во все глаза, но внизу ничего не было видно, кроме бесконечно длинной шеи, " +
                                     "вздымавшейся, словно мачта, над целым морем зелени. От этих печальных размышлений ее отвлек сильный" +
                                     " плеск воды. Кто-то бултыхнулся в пруд неподалеку от нее и зашлепал по воде так громко, что сперва" +
                                     " она было подумала, что это морж, а то и бегемот, и даже чуточку испугалась, но потом вспомнила," +
                                     " какая она сейчас маленькая, успокоилась («Он меня и не заметит», – подумала она), подплыла поближе" +
                                     " и увидела, что это всего-навсего мышка, которая, очевидно, тоже нечаянно попала в этот плачевный " +
                                     "пруд и тоже пыталась выбраться на твердую почву. «Заговорить, что ли, с этой Мышью? Может, она мне " +
                                     "чем-нибудь поможет? – подумала Алиса. – А уж говорить-то она, наверное, умеет – что тут такого, " +
                                     "сегодня и не то бывало! Заговорю с ней – попытка не пытка». И она заговорила: – О Мышь!"
                }
                };

            }
        }
    }