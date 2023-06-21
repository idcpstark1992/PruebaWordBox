using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIDataItem : MonoBehaviour
{
    private SDetailsData                    DetailedData;
    private string                          ImageURL;
    private Button                          BtnGetDataDetails;
    [SerializeField] private RawImage       PrintImage;
    [SerializeField] private TextMeshProUGUI            PrintName;

    private void Start()
    {
        BtnGetDataDetails = GetComponent<UnityEngine.UI.Button>();
        BtnGetDataDetails.onClick.AddListener(OnButtonPressed);
    }
    public void InitData(SDetailsData _data, float _delay)
    {
        DetailedData = _data;
        ImageURL            = _data.ImgURl;
        PrintName.text      = _data.PersonName;
        SetImage();
        LeanTween.scale(gameObject, Vector3.one, _delay).setEaseInCirc();
    }
    private async void SetImage()
    {
        PrintImage.texture = await GetUrlImages.DownloadImage(ImageURL);
    }
    private void OnButtonPressed()
    {
        EventsDictionary.UI_PRINT_DETAILS?.Invoke(DetailedData);
    }
}
