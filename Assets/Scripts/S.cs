using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class S : MonoBehaviour
{
    Core core = new Core();

    public void seri()
    {
        core.kontragents.Add(new Core.Kontragent());

        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("Core.dat", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, core);
        }
        core = null;
    }

    public void desiri()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream("Core.dat", FileMode.OpenOrCreate))
        {
            core = (Core)formatter.Deserialize(fs);
        }

    }
}
