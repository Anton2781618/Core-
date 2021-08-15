using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//класс контрагента.
[Serializable]
public class Kontragent : IComponentsCore
{
    public class Client
	{
        public string Adress { get; set; }
        public string name { get; set; }
        public string Telephone { get; set; }
	}

    //список контрагентов 
    public List<Client> kontragents = new List<Client>();

	//список воды у контрагента ключ это название воды, значение это цена розничная воды
	private Dictionary<string, int> Price = new Dictionary<string, int>();

	// метод просто для проверки 
	public void Show_data()
    {
		Debug.Log("Контрагентов " + kontragents.Count + " шт");
    }
}
