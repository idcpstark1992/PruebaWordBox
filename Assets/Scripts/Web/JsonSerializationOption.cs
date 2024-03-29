using Newtonsoft.Json;
using System;
using UnityEngine;

public class JsonSerializationOption : ISerializationOption
{
    public string ContentType => "application/json";

    public T Deserialize<T>(string text)
    {
        try
        {
            return JsonConvert.DeserializeObject<T>(text);
        }
        catch (Exception ex)
        {
            Debug.LogError($"Could not parse response {text}. {ex.Message}");
            return default;
        }
    }
}


