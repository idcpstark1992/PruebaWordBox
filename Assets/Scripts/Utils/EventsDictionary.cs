
public static class EventsDictionary 
{
    public delegate void DELEGATE_GET<T>(T _ARGS);
    public static DELEGATE_GET<string>      HTTP_GET_ALL_DATA;
    public static DELEGATE_GET<PersonData>  ON_GET_DATA;
    public static DELEGATE_GET<PersonData>  UI_PRINT_PERSONS_DATA;
}
