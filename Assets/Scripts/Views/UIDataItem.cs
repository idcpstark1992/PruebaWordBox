using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.Networking;
using System.Threading.Tasks;

public class UIDataItem : MonoBehaviour
{
    private string ImageURL;
    private UnityEngine.UI.Button BtnGetDataDetails;
    [SerializeField] private UnityEngine.UI.RawImage    PrintImage;
    [SerializeField] private TextMeshProUGUI            PrintName;

    private void Start()
    {
        BtnGetDataDetails = GetComponent<UnityEngine.UI.Button>();
        BtnGetDataDetails.onClick.AddListener(OnButtonPressed);
    }
    public void InitData(SDetailsData _data, float _delay)
    {
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

    }
}

public static class GetUrlImages
{

    public static async Task<Texture2D> DownloadImage(string _url)
    {
        using (UnityWebRequest www = UnityWebRequestTexture.GetTexture(_url))
        {
            var operation = www.SendWebRequest();
            while (!operation.isDone)
                await Task.Yield();

            if (www.result == UnityWebRequest.Result.Success)
            {
                Texture2D texture = DownloadHandlerTexture.GetContent(www);
                return texture;
            }
            else
            {
                Debug.LogError("Failed to download image: " + www.error);
                return null;
            }
        }
    }
}
