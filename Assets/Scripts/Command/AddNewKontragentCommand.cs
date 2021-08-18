using UnityEngine;
using UnityEngine.UI;

public class AddNewKontragentCommand : MonoBehaviour, IComandKontragents
{
    protected Kontragent access = Core.Singleton.dict["Kontragent"] as Kontragent;

    public void Execute(int id)
    {
        Add_new_Kontragent();
        access.Show_data();
    }

    void Add_new_Kontragent()
    {
        
        GameObject Bufer = Instantiate(GameObject.Find("ObjectKontragent"));

        Bufer.transform.SetParent(GameObject.Find("ContantKontragents").transform);
        Bufer.transform.localScale = new Vector3(1, 1, 1);

        Bufer.transform.GetChild(0).GetComponent<Text>().text = access.kontragents.Count.ToString();
        access.kontragents.Add(new Kontragent.Client(Bufer));

        
    }
}
