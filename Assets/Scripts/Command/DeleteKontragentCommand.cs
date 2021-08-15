using UnityEngine;

public class DeleteKontragentCommand : IComandKontragents
{
    Kontragent access = Core.Singleton.dict["Kontragent"] as Kontragent;
    public void Execute()
    {
        access.kontragents.RemoveAt(0);
        access.Show_data();
    }
}
