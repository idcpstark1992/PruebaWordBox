using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public static  class WebServices 
{
    private static string MainURL = "https://randomuser.me/api/?results=";
    public static async Task<ResultType> GET<ResultType>(string _urlEndPoint=default)
    {
        try
        {
            WWWForm form = new();
            ISerializationOption _serializationOption = new JsonSerializationOption();
            string m_url = string.Concat(MainURL, _urlEndPoint);

            using var w = UnityWebRequest.Get(m_url);
            var operation = w.SendWebRequest();

            while (!operation.isDone)
                await Task.Yield();

            if (w.result != UnityWebRequest.Result.Success)
                Debug.LogError($"Failed: {w.error}");

            return _serializationOption.Deserialize<ResultType>(w.downloadHandler.text);
        }
        catch (Exception ex)
        {
            Debug.LogError($"{nameof(GET)} failed: {ex.Message}");
            return default;
        }
    }
}
