public class HTTP_QUERY_Get_Persons 
{
    private string ResultsAmount;
    public HTTP_QUERY_Get_Persons (string _amount)
    {
        ResultsAmount = _amount;
    }
    public async void Request()
    {
        PersonData m_Persons = await WebServices.GET<PersonData>(ResultsAmount);
        EventsDictionary.ON_GET_DATA?.Invoke(m_Persons);
    }
}
