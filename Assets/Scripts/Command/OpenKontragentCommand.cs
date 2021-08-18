using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenKontragentCommand : IComandKontragents
{
    protected Kontragent access = Core.Singleton.dict["Kontragent"] as Kontragent;
    
    public void Execute(int id)
    {
        Open_card_Kontragent(id);
    }

    private void Open_card_Kontragent(int id)
    {
        GameObject.Find("Text_Id_card").transform.GetComponent<Text>().text = id.ToString();
    }
}
