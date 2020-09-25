﻿using AuroraEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XNode
{
	[CreateNodeMenu("BinaryOps/LEquality/FloatInt")]
	public class LEqualFloatInt : LEqualityOperation
	{
		[Input] public new float x;
		[Input] public new int y;
		[Output] public new bool result;
	}
}
