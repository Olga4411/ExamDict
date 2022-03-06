using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamDict
{
    internal class Book
    {
        //список записей книги
        private List<Dict> dicts ;
        public Book()
        {
            dicts = new List<Dict>();
        }

        // добавление нового словаря
        public void AddWord( string word)
       {
            dicts.Add(new Dict(word));
        }

       

        // метод поиска записи по слову

        public Dict FindDictByWord(string word)
        {
            foreach (Dict dict in dicts)
            {
                if (dict.Word == word)
                    return dict;
            }
            return null;
        }

        //public Dict RemoveDictByWord(string word)
        //{
        //    Dict dict = FindDictByWord(word);
        //    if (dict !=null)
        //    {
        //        dicts.Remove(dict);
        //    }
        // }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Dict dict in dicts)
            {
                sb.Append(dict.ToString());
            }
            return sb.ToString();
        }

        public bool SaveToFile(string fname)
        {
            //1 Метод сохранения книги в файл
            //принимает имя файла для сохранения
            // возвращает true если все успешно, иначе false 
            try
            {
                //код записи строки s
                StreamWriter sw = new StreamWriter(fname);
                sw.Write(ToString());
                sw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

       

    }
}
