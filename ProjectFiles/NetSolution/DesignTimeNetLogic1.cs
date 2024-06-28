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

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void GenerateMyAlarms()
    {
        //1 recupero cartella allarmi
       var alarmsFolder = Project.Current.Get<Folder>("Alarms");
        //2 creo my Alarms
        var myAlarmsFolder = InformationModel.Make<Folder>("myAlarmsFolder");
        //3 aggiungo cartella creta a cartella allarmi
        alarmsFolder.Add(myAlarmsFolder);
        //4 gereo 100 allarmi e li inserisco nella cartella my Alarms
        for (int i=0; 1<100; i++)
       {
        var dalarm = InformationModel.Make<DigitalAlarm>("dalarm_" + i);
        myAlarmsFolder.Add(DigitalAlarm);
       }
    }
}
