using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "RoomNodeType_", menuName = "Scriptable Objects/Dungeon/ Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header
    [Header("Only flag  the RoomNodeTypes that should be visible in the editor")]
    #endregion Header
    public bool diplayInNodeGraphEditor = true;
    #region Header
    [Header("Only type should be a Corridor")]
    #endregion Header
    public bool isCorridor;
    #region Header
    [Header("Only type should be a CorridorNS")]
    #endregion Header 
    public bool isCorridorNS;
    #region Header
    [Header("Only type should be a CorridorEW")]
    #endregion Header
    public bool isCorridorEW;
    #region Header
    [Header("Only type should be an entrance")]
    #endregion Header
    public bool isEntrance;
    #region Header
    [Header("Only type should be a Boos Room")]
    #endregion
    public bool isBossRoom;
    #region Header
    [Header("Only type should be a None")]
    #endregion Header
    public bool isNone;

    #region
#if UNITY_EDITOR

    private void OnValidate()
    {
        HelperUtilites.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif
    #endregion
}
