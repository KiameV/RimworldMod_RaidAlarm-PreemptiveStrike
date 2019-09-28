﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace PreemptiveStrike.UI
{
    [StaticConstructorOnStartup]
    static class UIConstants
    {
        public static readonly float MainLabelHeight = 30f;
        public static readonly float TinyLabelHeight = 17f;
        public static readonly float MainLabelIntend = 0f;
        public static readonly float TinyLabelIntend = -1f;

        public static readonly float BulletinWidth = 400f;
        public static readonly float BulletinHeight = MainLabelHeight + MainLabelIntend + TinyLabelHeight * 3 + TinyLabelIntend * 2;
        public static readonly float BulletinIntend = 5f;

        public static readonly float BulletinIconIntend = 15f;
        public static readonly float BulletinIconSize = BulletinHeight - BulletinIconIntend * 2;

        public static readonly float DefualtWindowPin2RightIntend = 35f;
        public static readonly float DefaultWindowWidth = BulletinWidth + 50f;
        public static readonly float TitleHeight = 30f;
        public static readonly float TitleIntend = 20f;

        static UIConstants()
        {
            Log.Message("height: " + BulletinHeight);
        }
    }
}