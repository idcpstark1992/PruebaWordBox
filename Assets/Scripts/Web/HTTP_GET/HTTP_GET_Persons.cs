using UnityEngine;

public class HTTP_GET_Persons : MonoBehaviour
{
    private void OnEnable()
    {
        EventsDictionary.HTTP_GET_ALL_DATA  += SendWebRequest;
        EventsDictionary.ON_GET_DATA        += OnWebRequest;
    }
    private void OnDisable()
    {
        EventsDictionary.ON_GET_DATA        -= OnWebRequest;
        EventsDictionary.HTTP_GET_ALL_DATA  -= SendWebRequest;
    }
    public void SendWebRequest(string _resultsAmount)
    {
        HTTP_QUERY_Get_Persons m_Query = new(_resultsAmount);
        m_Query.Request();
    }
    private void OnWebRequest(PersonData _data)
    {
        EventsDictionary.UI_PRINT_PERSONS_DATA?.Invoke(_data);
    }
}
