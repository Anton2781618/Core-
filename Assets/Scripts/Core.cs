using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//модель данных всего
public class Core : MonoBehaviour
{
    public class Price
    {   string waterName;
        int retailPrice;
    }
    public class Kontragent
    {
        string adress;
        string name;
        string Telephone;

        Dictionary<string, Price> prise = new Dictionary<string, Price>();
    }

    public List<Kontragent> kontragents = new List<Kontragent>();

    
}
