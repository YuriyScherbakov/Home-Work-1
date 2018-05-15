using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
    {
    public class KeyWordsCreator
        {
        static IList<KeyWord> keyWords;
        public static IList<KeyWord> GetKeyWords ()
            {
            return keyWords;
            }
        static KeyWordsCreator ()
            {
            keyWords = new List<KeyWord> {
                new KeyWord()
                {
                    Id = 1,
                    Word = "Мышка"

                },
                new KeyWord()
                {
                    Id = 2,
                    Word = "Алиса"

                },
                new KeyWord()
                {
                    Id = 3,
                    Word = "Перчатки"

                },
                new KeyWord()
                {
                    Id = 4,
                    Word = "Смех"

                },
                new KeyWord()
                {
                    Id = 5,
                    Word = "Морж"

                },
                new KeyWord()
                {
                    Id = 6,
                    Word = "Пруд"

                }, new KeyWord()
                {
                    Id = 7,
                    Word = "Дронт"

                }
                };

            }
        }
    }
