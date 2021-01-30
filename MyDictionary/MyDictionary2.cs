using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary2<TKEY,TVALUE> //GÖNDERDİĞİMİZ TÜRE GÖRE GENERİC TİPTE BİR DİCTİONARY OLUŞTURUYORUZ.
    {
        TKEY[] keys; //T TÜRÜNDE KEY VE VALUE ARRAY TANIMLIYORUZ.
        TVALUE[] values;

        public MyDictionary2()
        {
            keys = new TKEY[0]; // CONSTRUCTOR'DA ARRAYLERİMİZDE KAÇ ELEMANLI OLACAĞINI BELİRLİYORUZ.
            values = new TVALUE[0];
        }
        public void Add(TKEY key , TVALUE value) //ADD METOTUMUZDAN T TÜRÜNDE KEY VE VALUE ALIYORUZ KULLANICIDAN
        {
            TKEY[] tempKeys = keys; //T TÜRÜNDE DAHA ÖNCEDEN OLUŞTURDUĞUMUZ BİR ARRAY VAR İSE ONUN İÇİNDEKİ BİLGİLERİN 
            TVALUE[] tempValue = values; //ADRESİNİ TUTACAK BİR TEMP ARRAY OLUŞTURUYORUZ VE ONLARIN ADRESLERİNİ EŞLİYORUZ.

            keys = new TKEY[keys.Length + 1]; //KEY VEYA VALUE'NİN ELEMAN SAYISINDAN BİR FAZLASI KADARINI TEKRAR ARRAY OLUŞTURUYORUZ.
            values = new TVALUE[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++) // DÖNGÜ İLE TEMP'E AKTARDIĞIMIZ BİLGİLERİ TEKRARDAN YENİ OLUŞTURDUĞUMUZ DİZİYE AKTARIYORUZ.
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key; //KULLANICIDAN ALDIĞIMIZ KEY VE VALUE'Yİ ARRAY'İMİZİN EN SON İNDEXİNE YERLEŞTİRİYORUZ.
            values[values.Length - 1] = value;
        }
        public TKEY[] Keys 
        {
            get { return keys; }
        }

        public TVALUE[] Values
        {
            get { return values; }
        }
    }
}
