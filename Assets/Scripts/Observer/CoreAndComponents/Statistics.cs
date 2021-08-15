using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//класс хранения данных для отчетов статистики
[Serializable]
public class Statistics : IComponentsCore
{
    //выручка
    int revenue;
    // прибыль
    int profit;
    //словарь зарплат сотрудников        
    Dictionary<string, int> peoplesSalaries = new Dictionary<string, int>();
    
    public void Show_data()
    {
        throw new NotImplementedException();
    }
}
