using UnityEngine;
using UnityEngine.UI;

public class DeleteKontragentCommand : MonoBehaviour, IComandKontragents
{
    protected Kontragent access = Core.Singleton.dict["Kontragent"] as Kontragent;
    public void Execute(int id)
    {
        Remove_kontragent(id);
        access.Show_data();

    }

    private void Remove_kontragent(int id)
    {
        Destroy(access.kontragents[id].myTrans);
        access.kontragents.RemoveAt(id);
        Reinit_oll_id();
    }

    private void Reinit_oll_id()
    {
        for (int i = 0; i < access.kontragents.Count; i++)
        {
            access.kontragents[i].myTrans.transform.GetChild(0).GetComponent<Text>().text = i.ToString();
        }
    }
}
