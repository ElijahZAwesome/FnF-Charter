using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public static class SongLoader
{
    public static Song LoadFromJson(string path)
    {
        var json = File.ReadAllText(path);
        var jobj = JObject.Parse(json);

        if (jobj["song"] == null)
            throw new NotSupportedException(
                "This file aint a FnF song lol dumbass idiot go get a job you hopeless piece of shit");

        return jobj["song"].ToObject<Song>();
    }
}