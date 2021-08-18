using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public class Invoker 
{
    public Dictionary<string, IComandKontragents> comandsKontragents = new Dictionary<string, IComandKontragents>();


    public Invoker()
    {
        Initialize_ComponentsInvoker();
    }    

    private void Initialize_ComponentsInvoker()
    {
        
        List<Type> tipeInvoker = this.GetType().Assembly.GetTypes().Where(t => t.GetInterface("IComandKontragents") != null).ToList();

        foreach (var item in tipeInvoker)
        {
            comandsKontragents.Add(item.Name, System.Activator.CreateInstance(item) as IComandKontragents);
        }

    }
}
