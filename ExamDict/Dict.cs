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
        private Dictionary<string, string> translates;
        public Dict (string word)
        {
            Word = word;
            translates = new Dictionary<string, string>();
        }

      //  методы работы с записью
      // Метод добавления слова
         public void AddWord(string attribute,string translate)
        {
            translates[attribute] = translate;
        }
        // удаление по ключу
        public string RemoveWordWithAtribute(string attribute)
        {
            if (translates.ContainsKey(attribute))
            {
                string res = translates[attribute];
                translates.Remove(attribute);
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

            foreach(var pair in translates)
            {
                sb.Append(pair.Key + ':' + pair.Value+"\n");
            }
            sb.Append(")\n");
            return sb.ToString();
        }
    }
}
