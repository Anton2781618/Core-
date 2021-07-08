using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Общее хранилище данных. 
[Serializable]
public class Core 
{

    //класс контрагента.
    [Serializable]
    public class Kontragent
    {
        string Adress {get; set;}
        string name{ get; set;}
        string Telephone { get; set;}

        //список воды у контрагента ключ это название воды, значение это цена розничная воды
        Dictionary<string, int> Price = new Dictionary<string, int>();
    }

    //класс хранения данных для отчетов статистики
    [Serializable]
    public class Statistics
    {
        //выручка
        int revenue;
        // прибыль
        int profit;
        //словарь зарплат сотрудников        
        Dictionary<string, int> peoplesSalaries = new Dictionary<string, int>();
    }

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
