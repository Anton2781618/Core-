using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//класс контрагента.
[Serializable]
public class Kontragent : IComponentsCore
{
    
        string Adress {get; set;}
        string name{ get; set;}
        string Telephone { get; set;}

        //список воды у контрагента ключ это название воды, значение это цена розничная воды
        Dictionary<string, int> Price = new Dictionary<string, int>();
}
