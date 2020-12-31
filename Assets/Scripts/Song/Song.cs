using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public struct Song
{
    [JsonProperty("song")] public string Name;
    [JsonProperty("notes")] public List<Section> Sections;
    [JsonProperty("bpm")] public int Bpm;
    // Not used in game
    [JsonProperty("sections")] public int SectionCount => Sections.Count;
    [JsonProperty("needsVoices")] public bool HasVoiceTrack;
    [JsonProperty("player1")] public string PlayerCharacter;
    [JsonProperty("player2")] public string EnemyCharacter;
    // Not used in game this is stupid lol
    [JsonProperty("sectionLengths")] public int[] SectionNoteCounts
    {
        get
        {
            var sectionLengths = new int[SectionCount];
            for (var i = 0; i < sectionLengths.Length; i++) 
                sectionLengths[i] = Sections[i].Notes.Count;
            return sectionLengths;
        }
    }

    [JsonProperty("speed")] public int NoteSpeed;
}