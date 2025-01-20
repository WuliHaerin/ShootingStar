/*
LevelTitle.cs
Version 1.0

Sets the Title of the Level
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class LevelTitle : MonoBehaviour {

	void Awake()
	{
		int LevelNum = LevelData.getCurrentLevelNum();
		GetComponent<TMP_Text>().text = "关卡 " + LevelNum.ToString();
	}

}
