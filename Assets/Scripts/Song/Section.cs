using System.Collections.Generic;
using Newtonsoft.Json;

public struct Section
{
    [JsonProperty("mustHitSection")] public bool PlayerTurn;
    [JsonProperty("typeOfSection")] public SectionType Type;
    [JsonProperty("lengthInSteps")] public int LengthInBeats;
    [JsonProperty("sectionNotes")] public List<int[]> Notes;
}