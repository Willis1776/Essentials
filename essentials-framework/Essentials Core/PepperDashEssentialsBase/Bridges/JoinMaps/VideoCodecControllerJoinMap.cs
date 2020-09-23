﻿using System;
using PepperDash.Essentials.Core;

namespace PepperDash_Essentials_Core.Bridges.JoinMaps
{
    public class VideoCodecControllerJoinMap : JoinMapBaseAdvanced
    {
        #region Status

        [JoinName("IsOnline")] public JoinDataComplete IsOnline =
            new JoinDataComplete(new JoinData {JoinNumber = 1, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Device is Online",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        #endregion

        [JoinName("CallDirection")] public JoinDataComplete CallDirection =
            new JoinDataComplete(new JoinData {JoinNumber = 22, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Current Call Direction",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("CameraLayout")] public JoinDataComplete CameraLayout =
            new JoinDataComplete(new JoinData {JoinNumber = 142, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Layout Toggle",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraModeAuto")] public JoinDataComplete CameraModeAuto =
            new JoinDataComplete(new JoinData {JoinNumber = 131, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Mode Auto",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraModeManual")] public JoinDataComplete CameraModeManual =
            new JoinDataComplete(new JoinData {JoinNumber = 132, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Mode Manual",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraModeOff")] public JoinDataComplete CameraModeOff =
            new JoinDataComplete(new JoinData {JoinNumber = 133, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Mode Off",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraNumberSelect")] public JoinDataComplete CameraNumberSelect =
            new JoinDataComplete(new JoinData {JoinNumber = 60, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Number Select/FB",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Analog
                });

        [JoinName("CameraPanLeft")] public JoinDataComplete CameraPanLeft =
            new JoinDataComplete(new JoinData {JoinNumber = 113, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Pan Left",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraPanRight")] public JoinDataComplete CameraPanRight =
            new JoinDataComplete(new JoinData {JoinNumber = 114, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Pan Right",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraPresetSelect")] public JoinDataComplete CameraPresetSelect =
            new JoinDataComplete(new JoinData {JoinNumber = 121, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Preset Select",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Analog
                });

        [JoinName("CameraPresetNames")] public JoinDataComplete CameraPresetNames =
            new JoinDataComplete(new JoinData {JoinNumber = 121, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Preset Names - XSIG, max of 15",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("CameraSelfView")] public JoinDataComplete CameraSelfView =
            new JoinDataComplete(new JoinData {JoinNumber = 141, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Self View Toggle/FB",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraSupportsAutoMode")] public JoinDataComplete CameraSupportsAutoMode =
            new JoinDataComplete(new JoinData {JoinNumber = 143, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Supports Auto Mode FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraSupportsOffMode")] public JoinDataComplete CameraSupportsOffMode =
            new JoinDataComplete(new JoinData {JoinNumber = 144, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Supports Off Mode FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraTiltDown")] public JoinDataComplete CameraTiltDown =
            new JoinDataComplete(new JoinData {JoinNumber = 112, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Tilt Down",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraTiltUp")] public JoinDataComplete CameraTiltUp =
            new JoinDataComplete(new JoinData {JoinNumber = 111, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Tilt Up",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraZoomIn")] public JoinDataComplete CameraZoomIn =
            new JoinDataComplete(new JoinData {JoinNumber = 115, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Zoom In",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CameraZoomOut")] public JoinDataComplete CameraZoomOut =
            new JoinDataComplete(new JoinData {JoinNumber = 116, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Camera Zoom Out",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CurrentCallName")] public JoinDataComplete CurrentCallData =
            new JoinDataComplete(new JoinData {JoinNumber = 2, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Current Call Data - XSIG",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("CurrentDialString")] public JoinDataComplete CurrentDialString =
            new JoinDataComplete(new JoinData {JoinNumber = 1, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Current Dial String",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("DirectoryHasChanged")] public JoinDataComplete DirectoryHasChanged =
            new JoinDataComplete(new JoinData {JoinNumber = 103, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory has changed FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryDialSelectedLine")] public JoinDataComplete DirectoryDialSelectedLine =
            new JoinDataComplete(new JoinData {JoinNumber = 106, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Dial selected directory line",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryEntries")] public JoinDataComplete DirectoryEntries =
            new JoinDataComplete(new JoinData {JoinNumber = 101, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Entries - XSig, 255 entries",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("DirectoryEntryIsContact")] public JoinDataComplete DirectoryEntryIsContact =
            new JoinDataComplete(new JoinData {JoinNumber = 101, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Selected Entry Is Contact FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryEntrySelectedName")] public JoinDataComplete DirectoryEntrySelectedName =
            new JoinDataComplete(new JoinData {JoinNumber = 356, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Selected Directory Entry Name",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("DirectoryEntrySelectedNumber")] public JoinDataComplete DirectoryEntrySelectedNumber =
            new JoinDataComplete(new JoinData {JoinNumber = 357, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Selected Directory Entry Number",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("DirectoryFolderBack")] public JoinDataComplete DirectoryFolderBack =
            new JoinDataComplete(new JoinData {JoinNumber = 105, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Go back one directory level",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryIsRoot")] public JoinDataComplete DirectoryIsRoot =
            new JoinDataComplete(new JoinData {JoinNumber = 102, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory is on Root FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryLineSelected")] public JoinDataComplete DirectoryLineSelected =
            new JoinDataComplete(new JoinData {JoinNumber = 101, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Line Selected FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryRoot")] public JoinDataComplete DirectoryRoot =
            new JoinDataComplete(new JoinData {JoinNumber = 104, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Go to Directory Root",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectoryRowCount")] public JoinDataComplete DirectoryRowCount =
            new JoinDataComplete(new JoinData {JoinNumber = 101, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Row Count FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Analog
                });

        [JoinName("DirectorySearchBusy")] public JoinDataComplete DirectorySearchBusy =
            new JoinDataComplete(new JoinData {JoinNumber = 100, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Search Busy FB",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("DirectorySearchString")] public JoinDataComplete DirectorySearchString =
            new JoinDataComplete(new JoinData {JoinNumber = 100, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Search String",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("DirectorySelectRow")] public JoinDataComplete DirectorySelectRow =
            new JoinDataComplete(new JoinData {JoinNumber = 101, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Directory Select Row",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Analog
                });

        [JoinName("DirectorySelectedFolderName")] public JoinDataComplete DirectorySelectedFolderName =
            new JoinDataComplete(new JoinData {JoinNumber = 358, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Selected Directory Folder Name",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("0")] public JoinDataComplete Dtmf0 =
            new JoinDataComplete(new JoinData {JoinNumber = 20, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 0",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("1")] public JoinDataComplete Dtmf1 =
            new JoinDataComplete(new JoinData {JoinNumber = 11, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 1",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("2")] public JoinDataComplete Dtmf2 =
            new JoinDataComplete(new JoinData {JoinNumber = 12, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 2",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("3")] public JoinDataComplete Dtmf3 =
            new JoinDataComplete(new JoinData {JoinNumber = 13, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 3",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("4")] public JoinDataComplete Dtmf4 =
            new JoinDataComplete(new JoinData {JoinNumber = 14, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 4",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("5")] public JoinDataComplete Dtmf5 =
            new JoinDataComplete(new JoinData {JoinNumber = 15, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 5",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("6")] public JoinDataComplete Dtmf6 =
            new JoinDataComplete(new JoinData {JoinNumber = 16, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 6",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("7")] public JoinDataComplete Dtmf7 =
            new JoinDataComplete(new JoinData {JoinNumber = 17, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 7",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("8")] public JoinDataComplete Dtmf8 =
            new JoinDataComplete(new JoinData {JoinNumber = 18, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 8",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("9")] public JoinDataComplete Dtmf9 =
            new JoinDataComplete(new JoinData {JoinNumber = 19, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF 9",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("#")] public JoinDataComplete DtmfPound =
            new JoinDataComplete(new JoinData {JoinNumber = 22, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF #",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("*")] public JoinDataComplete DtmfStar =
            new JoinDataComplete(new JoinData {JoinNumber = 21, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "DTMF *",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("EndCall")] public JoinDataComplete EndCall =
            new JoinDataComplete(new JoinData {JoinNumber = 24, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Hang Up",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("HookState")] public JoinDataComplete HookState =
            new JoinDataComplete(new JoinData {JoinNumber = 31, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Current Hook State",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("IncomingAnswer")] public JoinDataComplete IncomingAnswer =
            new JoinDataComplete(new JoinData {JoinNumber = 51, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Answer Incoming Call",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("IncomingCall")] public JoinDataComplete IncomingCall =
            new JoinDataComplete(new JoinData {JoinNumber = 50, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Incoming Call",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("IncomingCallName")] public JoinDataComplete IncomingCallName =
            new JoinDataComplete(new JoinData {JoinNumber = 51, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Incoming Call Name",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("IncomingCallNumber")] public JoinDataComplete IncomingCallNumber =
            new JoinDataComplete(new JoinData {JoinNumber = 52, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Incoming Call Number",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("IncomingReject")] public JoinDataComplete IncomingReject =
            new JoinDataComplete(new JoinData {JoinNumber = 52, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Reject Incoming Call",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("SpeedDialStart")] public JoinDataComplete SpeedDialStart =
            new JoinDataComplete(new JoinData {JoinNumber = 41, JoinSpan = 4},
                new JoinMetadata
                {
                    Description = "Speed Dial",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("Schedule")] public JoinDataComplete Schedule =
            new JoinDataComplete(new JoinData {JoinNumber = 102, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Schedule Data - XSIG",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("DialMeeting")] public JoinDataComplete DialMeeting = new JoinDataComplete(new JoinData{JoinNumber=161, JoinSpan = 1},
            new JoinMetadata
            {
                Description = "Join first joinable meeting",
                JoinCapabilities = eJoinCapabilities.FromSIMPL,
                JoinType = eJoinType.Digital
            });

        [JoinName("UpdateMeetings")] public JoinDataComplete UpdateMeetings =
            new JoinDataComplete(new JoinData {JoinNumber = 162, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Update Meetings",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("Meeting Count Fb")] public JoinDataComplete MeetingCount =
            new JoinDataComplete(new JoinData {JoinNumber = 161, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Meeting Count",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Analog
                });


        [JoinName("CameraLayoutStringFb")]
        public JoinDataComplete CameraLayoutStringFb =
            new JoinDataComplete(new JoinData { JoinNumber = 141, JoinSpan = 1 },
            new JoinMetadata
            {
                Description = "Current Layout Fb",
                JoinCapabilities = eJoinCapabilities.ToSIMPL,
                JoinType = eJoinType.Analog
            });

        
        

        [JoinName("ManualDial")] public JoinDataComplete ManualDial =
            new JoinDataComplete(new JoinData {JoinNumber = 71, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Dial manual string",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("SourceShareStart")] public JoinDataComplete SourceShareStart =
            new JoinDataComplete(new JoinData {JoinNumber = 201, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "Start Sharing & Feedback",
                    JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("SourceShareEnd")]
        public JoinDataComplete SourceShareEnd =
            new JoinDataComplete(new JoinData { JoinNumber = 202, JoinSpan = 1 },
            new JoinMetadata
            {
                Description = "Stop Sharing & Feedback",
                JoinCapabilities = eJoinCapabilities.ToFromSIMPL,
                JoinType = eJoinType.Digital
            });

        [JoinName("AutoShareWhileInCall")] public JoinDataComplete SourceShareAutoStart =
            new JoinDataComplete(new JoinData {JoinNumber = 203, JoinSpan = 1},
                new JoinMetadata
                {
                    Description = "When high, will autostart sharing when a call is joined",
                    JoinCapabilities = eJoinCapabilities.FromSIMPL,
                    JoinType = eJoinType.Digital
                });

        [JoinName("CurrentSource")] public JoinDataComplete CurrentSource = new JoinDataComplete(new JoinData{JoinNumber = 201, JoinSpan = 1},
            new JoinMetadata
            {
                Description = "Current Source",
                JoinCapabilities = eJoinCapabilities.ToSIMPL,
                JoinType = eJoinType.Serial
            });

        [JoinName("CurrentParticipants")] public JoinDataComplete CurrentParticipants =
            new JoinDataComplete(new JoinData{JoinNumber = 151, JoinSpan = 1},
                new JoinMetadata()
                {
                    Description = "Current Participants XSig",
                    JoinCapabilities = eJoinCapabilities.ToSIMPL,
                    JoinType = eJoinType.Serial
                });

        [JoinName("ParticipantCount")] public JoinDataComplete ParticipantCount = new JoinDataComplete(new JoinData{JoinNumber = 151, JoinSpan = 1},
            new JoinMetadata
            {
                Description = "Current Participant Count",
                JoinCapabilities = eJoinCapabilities.ToSIMPL,
                JoinType = eJoinType.Analog
            });

        public VideoCodecControllerJoinMap(uint joinStart) : base(joinStart, typeof (VideoCodecControllerJoinMap))
        {
        }

        public VideoCodecControllerJoinMap(uint joinStart, Type type) : base(joinStart, type)
        {
        }
    }
}