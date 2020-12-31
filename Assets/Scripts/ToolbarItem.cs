using System;
using System.Collections.Generic;
using System.Linq;
using SubjectNerd.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Serializable]
public struct OptionData
{
    public string Label;
    public UnityEvent Event;
}

[RequireComponent(typeof(TMP_Dropdown))]
public class ToolbarItem : MonoBehaviour
{
    [SerializeField] 
    public string ToolbarTitle;
    [SerializeField]
    private TMP_Text CaptionLabel;
    [SerializeField, Reorderable]
    public OptionData[] Options;

    private TMP_Dropdown _dropdown;

    private void Awake()
    {
        _dropdown = GetComponent<TMP_Dropdown>();

        _dropdown.ClearOptions();
        if (Options != null)
            _dropdown.AddOptions(Options.ToList().Select(t => t.Label).ToList());

        _dropdown.onValueChanged.AddListener(v => Options[v].Event.Invoke());
        _dropdown.value = -1;

        CaptionLabel.text = ToolbarTitle;
    }

    private void OnValidate()
    {
        CaptionLabel.text = ToolbarTitle;
        _dropdown = GetComponent<TMP_Dropdown>();
        _dropdown.ClearOptions();
        if (Options != null)
            _dropdown.AddOptions(Options.ToList().Select(t => t.Label).ToList());
    }
}