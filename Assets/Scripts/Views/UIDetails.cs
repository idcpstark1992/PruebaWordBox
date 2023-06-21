using UnityEngine;
using TMPro;
public class UIDetails : MonoBehaviour
{
    private string ImageURL;
    [SerializeField] private UnityEngine.UI.RawImage PrintImage;
    [SerializeField] private TextMeshProUGUI PrintEmail;
    [SerializeField] private TextMeshProUGUI PrintName;
    [SerializeField] private TextMeshProUGUI PrintGender;
    [SerializeField] private TextMeshProUGUI PrintAge;
    [SerializeField] private TextMeshProUGUI PrintCity;
    public void InitData(SDetailsData _data)
    {
        LeanTween.scale(gameObject, Vector3.one, .3f).setEaseInCirc();
        ImageURL = _data.ImgURl;
        PrintEmail.text = _data.Email;
        PrintName.text = _data.PersonName;
        PrintGender.text = _data.Gender;
        PrintAge.text = _data.Age;
        PrintCity.text = _data.City;
    }

}
