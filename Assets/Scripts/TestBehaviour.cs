﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
}

public class TestBehaviour : MonoBehaviour
{
	[PotionSelector]
	public string potionName;

	public void Start()
	{
		// PotionDB.Instance pra acessar o "banco de dados" de pocoes
		// Imprimir o quanto aquela potion recupera
	}
}
