using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIDetails : MonoBehaviour
{
    private string ImageURL;
    [SerializeField] private RectTransform   MainHolder;
    [SerializeField] private RawImage        PrintImage;
    [SerializeField] private Button          BtnClose;
    [SerializeField] private TextMeshProUGUI PrintEmail;
    [SerializeField] private TextMeshProUGUI PrintName;
    [SerializeField] private TextMeshProUGUI PrintGender;
    [SerializeField] private TextMeshProUGUI PrintAge;
    [SerializeField] private TextMeshProUGUI PrintCity;

    private void OnEnable()
    {
        EventsDictionary.UI_PRINT_DETAILS += InitData;
    }
    private void OnDisable()
    {
        EventsDictionary.UI_PRINT_DETAILS -= InitData;
    }
    
    private void Start()=> BtnClose = GetComponent<Button>();
    public void InitData(SDetailsData _data)
    {
        ImageURL = _data.LargeImageURL;
        PrintEmail.text = _data.Email;
        PrintName.text = _data.PersonName;
        PrintGender.text = _data.Gender;
        PrintAge.text = _data.Age;
        PrintCity.text = _data.City;
        GetLargeImage();
        LeanTween.scale(MainHolder, Vector3.one, .3f).setEaseInCirc();
    }
    private async void GetLargeImage()=> PrintImage.texture = await GetUrlImages.DownloadImage(ImageURL);

    public void OnButtonPressed()
    {
        LeanTween.scale(MainHolder, Vector3.zero, .3f).setEaseOutCirc();
    }
}
