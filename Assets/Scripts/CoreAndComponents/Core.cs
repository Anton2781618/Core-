 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Общее хранилище данных. 
[Serializable]
public class Core 
{
    

    //список контрагентов 
    public List<Kontragent> kontragents = new List<Kontragent>();

    //словарь номенклатуры ключ это название воды, значение это цена закупки воды
    public Dictionary<string, int> nomenklatura = new Dictionary<string, int>();

    //список маршрутных листов
    public List<Transform> routeListPrefabs = new List<Transform>();

    //список водителей
    public List<string> driverList = new List<string>();

    //тип данных статистики внутри хранится вся информация о дне
    public Statistics statistics;

}
