﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace AudioClient
{
    public interface ISpyControl
    {
        int ObjectTypeID { get; }
        int ObjectID { get; }
        bool IsEnabled { get;}
        bool Talking { get; }
        bool Listening { get; }
        bool Recording { get; }
        bool ForcedRecording { get; }
        bool CanTalk { get; }
        bool CanListen { get; }
        bool CanRecord { get; }
        bool CanEnable { get; }
        bool CanGrab { get; }
        bool HasFiles { get; }
        string ObjectName { get; }

        void Disable(bool stopSource=true);
        void Enable();
        string RecordSwitch(bool record);
        void Talk(IWin32Window f = null);
        void Listen();
        string SaveFrame(Bitmap bmp = null);

        void Alarm(object sender, EventArgs e);
        void Apply();
        void ReloadSchedule();

        int Order { get; set; }

    }
}
