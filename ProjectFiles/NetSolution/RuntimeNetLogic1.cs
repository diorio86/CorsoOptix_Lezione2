#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.System;
using FTOptix.NetLogic;
using FTOptix.SerialPort;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.CommunicationDriver;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.DataLogger;
using FTOptix.Recipe;
using FTOptix.OPCUAServer;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{  
    public override void Start()
    {
        log.info("app started");   
    }

    public override void Stop()
    {
        log.info("app stopped");     
    }
}
