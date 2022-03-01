using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDict
{
    //класс Слова
   internal class Word
    {
        public string Language { get; set; }// название языка // Имя абонента
        public string EN_RU_Word { get; set; }// слово на русском // номер абонента
        //слово на английском
        Dictionary<string, string> translations;
        // ключ -название языка
        //значение-слово на этом языке
        
        public Word(string language, string en_ru_word)
        {
            Language = language;
            EN_RU_Word = en_ru_word;
        }

        static 
    }


}
