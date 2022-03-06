using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDict
{
    class Dict
    {
        public string Word { get; set; }
        //словарь приватный
        // ключ- язык, значение value-значение слова
        public Dictionary<string, string> English_Russian;
        public Dict (string word)
        {
            Word = word;
            English_Russian = new Dictionary<string, string>();
        }

      //  методы работы с записью
      // Метод добавления слова
         public void AddWord(string attribute,string translate)
        {
            English_Russian[attribute] = translate;
        }
        // удаление по ключу
        public string RemoveWordWithAtribute(string attribute)
        {
            if (English_Russian.ContainsKey(attribute))
            {
                string res = English_Russian[attribute];
                English_Russian.Remove(attribute);
                return res;
            }
            return null;
        }

        // ToString
        // словарь в виде строки

        public override string ToString()
        {
            // return Word+':'+translates.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append($"{Word}\n");

            foreach(var pair in English_Russian)
            {
                sb.Append(pair.Key + ':' + pair.Value+"\n");
            }
            //sb.Insert(sb.Length - 1, "");
            sb.Append(")\n");
            return sb.ToString();
        }
    }
}
