using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] valueEn = new string[5];
        private string[] valueUkr = new string[5];
        public Dictionary()
        {
            key[0] = "книга"; valueEn[0] = "book"; valueUkr[0] = "книга";
            key[1] = "ручка"; valueEn[1] = "pen"; valueUkr[1] = "ручка";
            key[2] = "солнце"; valueEn[2] = "sun"; valueUkr[2] = "сонце";
            key[3] = "яблоко"; valueEn[3] = "apple"; valueUkr[3] = "яблуко";
            key[4] = "стол"; valueEn[4] = "table"; valueUkr[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    //if (key[i] == index || valueEn[i] == index || valueUkr[i] == index)
                    if (key[i] == index)
                        return key[i] + " - " + valueEn[i] +" - " + valueUkr[i];
                    else if (valueEn[i] == index)
                        return valueEn[i] + " - " + valueUkr[i] + " - " + key[i];
                    else if (valueUkr[i] == index)
                        return valueUkr[i] + " - " + key[i] + " - " + valueEn[i];


                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + valueEn[index] + " - " + valueUkr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
