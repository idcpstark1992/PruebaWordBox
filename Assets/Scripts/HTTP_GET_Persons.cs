using UnityEngine;

public class HTTP_GET_Persons : MonoBehaviour
{
    private void Awake()
    {
        EventsDictionary.ON_GET_DATA += OnWebRequest;
        SendWebRequest();
    }
    private void OnDisable()
    {
        EventsDictionary.ON_GET_DATA -= OnWebRequest;
    }
    public void SendWebRequest()
    {
        HTTP_QUERY_Get_Persons m_Query = new();
        m_Query.Request();
    }
    private void OnWebRequest(PersonData _data)
    {
        for (int i = 0; i < _data.results.Count; i++)
        {
            Debug.Log(_data.results[i].Nat);
        }
    }
}
