 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

//Общее хранилище данных. 
[Serializable]
public class Core 
{
    public Dictionary<string, IComponentsCore> dict = new Dictionary<string, IComponentsCore>();

    public static Core Singleton{get; set;}
    public Core() 
    {
        Initialize_ComponentsCore();  
        Singleton = this; 
    }

    // Важный метод! Нужен для инициализации компонентов. Использую патерн наблюдатель...Суть в том что при добавлении новых сущностей нам не надо их вписывать сюда.
    // просто подключаем новую сущность к интерфесу IComponentsCore (реализуем интерфейс) и после этого в Сore в dict появится эта сущность с его названием! 
    private void Initialize_ComponentsCore()
    {
        List<Type> tipeIComponentsCore = this.GetType().Assembly.GetTypes().Where(t => t.GetInterface("IComponentsCore") != null).ToList();

        foreach (var item in tipeIComponentsCore)
        {
            dict.Add(item.Name, System.Activator.CreateInstance(item) as IComponentsCore);
        }
    }

    

    

    //словарь номенклатуры ключ это название воды, значение это цена закупки воды
    private Dictionary<string, int> nomenklatura = new Dictionary<string, int>();

    //список маршрутных листов
    private List<Transform> routeListPrefabs = new List<Transform>();

    //список водителей
    private List<string> driverList = new List<string>();

    //тип данных статистики внутри хранится вся информация о дне
    private Statistics statistics;

}
