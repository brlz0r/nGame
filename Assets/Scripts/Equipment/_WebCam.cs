using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "WebCam")]
public class _WebCam : ScriptableObject
{
    [SerializeField] string Name;
    [SerializeField] string Price;
    [SerializeField] string Rating;
    [SerializeField] bool Purchased;
    [SerializeField] bool Selected;
    [SerializeField] Sprite Icon;
}
