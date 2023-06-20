using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventsDictionary 
{
    public delegate void DELEGATE_GET<T>(T _ARGS);
    public static DELEGATE_GET<PersonData> ON_GET_DATA;
}
