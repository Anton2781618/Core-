using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//класс контрагента.
[Serializable]
public class Kontragent : IComponentsCore
{
    public class Client : MonoBehaviour
	{
        public Client(GameObject myTrans)
        {
            this.myTrans = myTrans;
        }

        public GameObject myTrans;
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
	}

    //список контрагентов 
    public List<Client> kontragents = new List<Client>();

	//список воды у контрагента ключ это название воды, значение это цена розничная воды
	private Dictionary<string, int> Price = new Dictionary<string, int>();

	// метод просто для проверки 
	public void Show_data()
    {
		// Debug.Log("Контрагентов " + kontragents.Count + " шт" + " Id " + kontragents[kontragents.Count].Id);
       
    }
}
