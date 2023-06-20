public class HTTP_QUERY_Get_Persons 
{
    public async void Request()
    {
        PersonData m_Persons = await WebServices.GET<PersonData>("10");
        EventsDictionary.ON_GET_DATA?.Invoke(m_Persons);
    }
}
