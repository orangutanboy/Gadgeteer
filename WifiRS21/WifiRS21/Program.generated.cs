﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Gadgeteer Designer.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gadgeteer;
using GTM = Gadgeteer.Modules;

namespace WifiRS21
{
    public partial class Program : Gadgeteer.Program
    {
        // GTM.Module definitions
        Gadgeteer.Modules.GHIElectronics.Button button;
        Gadgeteer.Modules.GHIElectronics.Display_T35 display_T35;
        Gadgeteer.Modules.GHIElectronics.WiFi_RS21 wifi_RS21;

        public static void Main()
        {
            //Important to initialize the Mainboard first
            Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();			

            Program program = new Program();
            program.InitializeModules();
            program.ProgramStarted();
            program.Run(); // Starts Dispatcher
        }

        private void InitializeModules()
        {   
            // Initialize GTM.Modules and event handlers here.		
            wifi_RS21 = new GTM.GHIElectronics.WiFi_RS21(6);
		
            button = new GTM.GHIElectronics.Button(9);
		
            display_T35 = new GTM.GHIElectronics.Display_T35(14, 13, 12, 10);

        }
    }
}
