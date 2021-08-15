using UnityEngine;

public class AddNewKontragentCommand : MonoBehaviour, IComandKontragents 
{
    Kontragent access = Core.Singleton.dict["Kontragent"] as Kontragent;
    
    public void Execute()
    {
        access.kontragents.Add(new Kontragent.Client());

        GameObject Bufer = Instantiate(GameObject.Find("ObjectKontragent"));
        Bufer.transform.SetParent(GameObject.Find("ContantKontragents").transform);
        Bufer.transform.localScale = new Vector3(1, 1, 1);
        access.Show_data();
    }
}
