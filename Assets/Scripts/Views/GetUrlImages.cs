using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;

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
