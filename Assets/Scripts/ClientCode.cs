﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// точка входа, класс управления программой.  
// так же тут место для хранения префабов
public class ClientCode : MonoBehaviour
{     
    private Core core = new Core();

    private FacadeKontragents facadeKontragents = new FacadeKontragents();   

    public void Add_New_Kontragent()
    {
        facadeKontragents.invoker.comandsKontragents["AddNewKontragentCommand"].Execute();
    }

    public void Delete_Kontragent()
    {
        facadeKontragents.invoker.comandsKontragents["DeleteKontragentCommand"].Execute();
    }
}
