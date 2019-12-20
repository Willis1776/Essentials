﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

using PepperDash.Essentials.Core;


namespace PepperDash.Essentials.AppServer
{
    public class SIMPLAtcJoinMap : JoinMapBase
    {
        public const string EndCall = "EndCall";
        public const string IncomingAnswer = "IncomingAnswer";
        public const string IncomingReject = "IncomingReject";
        public const string SpeedDialStart = "SpeedDialStart";
        public const string CurrentDialString = "CurrentDialString";
        public const string CurrentCallNumber = "CurrentCallNumber";
        public const string CurrentCallName = "CurrentCallName";
        public const string HookState = "HookState";
        public const string CallDirection = "CallDirection";
        public const string Dtmf0 = "0";
        public const string Dtmf1 = "1";
        public const string Dtmf2 = "2";
        public const string Dtmf3 = "3";
        public const string Dtmf4 = "4";
        public const string Dtmf5 = "5";
        public const string Dtmf6 = "6";
        public const string Dtmf7 = "7";
        public const string Dtmf8 = "8";
        public const string Dtmf9 = "9";
        public const string DtmfStar = "*";
        public const string DtmfPound = "#";
    

        public SIMPLAtcJoinMap()
        {
            Joins.Add(EndCall, new JoinMetadata() { JoinNumber = 21, Label = "Hang Up", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(IncomingAnswer, new JoinMetadata() { JoinNumber = 51, Label = "Answer Incoming Call", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(IncomingReject, new JoinMetadata() { JoinNumber = 52, Label = "Reject Incoming Call", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(SpeedDialStart, new JoinMetadata() { JoinNumber = 41, Label = "Speed Dial", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 4, JoinType = eJoinType.Digital });
            Joins.Add(CurrentDialString, new JoinMetadata() { JoinNumber = 1, Label = "Current Dial String", JoinCapabilities = eJoinCapabilities.ToFromSIMPL, JoinSpan = 1, JoinType = eJoinType.Serial });
            Joins.Add(CurrentCallNumber, new JoinMetadata() { JoinNumber = 11, Label = "Current Call Number", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinSpan = 1, JoinType = eJoinType.Serial });
            Joins.Add(CurrentCallName, new JoinMetadata() { JoinNumber = 12, Label = "Current Call Name", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinSpan = 1, JoinType = eJoinType.Serial });
            Joins.Add(HookState, new JoinMetadata() { JoinNumber = 21, Label = "Current Hook State", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinSpan = 1, JoinType = eJoinType.Serial });
            Joins.Add(CallDirection, new JoinMetadata() { JoinNumber = 21, Label = "Current Call Direction", JoinCapabilities = eJoinCapabilities.FromSIMPL, JoinSpan = 1, JoinType = eJoinType.Serial });
            Joins.Add(Dtmf1, new JoinMetadata() { JoinNumber = 1, Label = "DTMF 1", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf2, new JoinMetadata() { JoinNumber = 2, Label = "DTMF 2", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf3, new JoinMetadata() { JoinNumber = 3, Label = "DTMF 3", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf4, new JoinMetadata() { JoinNumber = 4, Label = "DTMF 4", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf5, new JoinMetadata() { JoinNumber = 5, Label = "DTMF 5", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf6, new JoinMetadata() { JoinNumber = 6, Label = "DTMF 6", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf7, new JoinMetadata() { JoinNumber = 7, Label = "DTMF 7", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf8, new JoinMetadata() { JoinNumber = 8, Label = "DTMF 8", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf9, new JoinMetadata() { JoinNumber = 9, Label = "DTMF 9", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(Dtmf0, new JoinMetadata() { JoinNumber = 10, Label = "DTMF 0", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(DtmfStar, new JoinMetadata() { JoinNumber = 11, Label = "DTMF *", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });
            Joins.Add(DtmfPound, new JoinMetadata() { JoinNumber = 12, Label = "DTMF #", JoinCapabilities = eJoinCapabilities.ToSIMPL, JoinSpan = 1, JoinType = eJoinType.Digital });

        }

        public override void OffsetJoinNumbers(uint joinStart)
        {
            var joinOffset = joinStart - 1;

            foreach (var join in Joins)
            {
                join.Value.JoinNumber = join.Value.JoinNumber + joinOffset;
            }

            PrintJoinMapInfo();
        }
    }
}