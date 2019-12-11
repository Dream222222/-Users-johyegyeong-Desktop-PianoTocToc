﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ToryUX.TagClasses
{
	[RequireComponent(typeof(Graphic))]
    public class CamLeaderboardUITodaySolidColorObject : MonoBehaviour
	{
        public Color Color
        {
            get
            {
                if (graphic == null)
                {
                    graphic = GetComponent<Graphic>();
                }
                return graphic.color;
            }
            set
            {
                if (graphic == null)
                {
                    graphic = GetComponent<Graphic>();
                }
                graphic.color = value;
            }
        }
        private Graphic graphic;
	}
}