using UnityEngine;

public class UIPrintPersonsData : MonoBehaviour
{
    [SerializeField] private int ResultsAmount;
    [SerializeField] private UIDataItem     PrefabPrintDataItem;
    [SerializeField] private RectTransform  ImagesHolder;
    [SerializeField] private UnityEngine.UI.Button BtnGetallData;

    private void Start()
    {
        BtnGetallData.onClick.AddListener(OnGetAllData);
    }
    private void OnEnable()     => EventsDictionary.UI_PRINT_PERSONS_DATA += OnDataArrived;
    private void OnDisable()    => EventsDictionary.UI_PRINT_PERSONS_DATA -= OnDataArrived;

    private void OnDataArrived(PersonData _data)
    {
        float m_Delay = 0f;
        for (int i = 0; i < _data.results.Count; i++)
        {
            m_Delay += .05f;
            UIDataItem m_toPrint = Instantiate(PrefabPrintDataItem, ImagesHolder);
            SDetailsData m_Structure = new()
            {
                LargeImageURL = _data.results[i].picture.Large,
                ImgURl = _data.results[i].picture.Medium,
                Age         = _data.results[i].Phone,
                City        = _data.results[i].Location.City,
                Email       = _data.results[i].Email,
                Gender      = _data.results[i].Gender,
                PersonName  = string.Concat(_data.results[i].Name.First, " , ", _data.results[i].Name.Last),
                Number      = _data.results[i].Cell
            };
            m_toPrint.InitData(m_Structure, m_Delay);
        }
        
    }

    public void OnGetAllData()
    {
        EventsDictionary.HTTP_GET_ALL_DATA?.Invoke(ResultsAmount.ToString());
    }
}
