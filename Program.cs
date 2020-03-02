/************************************************************************************************************ 
 * OZEKI CAMERA SDK
 * http://www.camera-sdk.com/
 * 
 * Example project
 * Title: PTZ camera motion control
 * Description: This example demonstrates how you can move and zoom with the camera.
 * The moving can happen manually, preset positions or automatic scanning.
 *  
 * Documentation:
 * http://www.camera-sdk.com/p_19-onvif.html
 * 
 * License:
 * This example can be freely used, distributed and modified according to the
 * license agreement at the following webpage: http://camera-sdk.com/p_241-license.html 
 * *********************************************************************************************************/
using System;
using System.Windows.Forms;

namespace Camview
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ozeki.Common.LicenseManager.Instance.SetLicense("OZSDK-IBS032CAM-200204-FE6FF385", "TUNDOjAsTVBMOjAsRzcyOTpmYWxzZSxNU0xDOjAsTUZDOjAsTVdQQzowLE1JUEM6MzIsVVA6MjAyMS4wMi4wNCxQOjIxOTkuMDEuMDF8czJDRHg1c1FiZjV1NmJ4UUFyK2FtTnBENjJDTEtmY2pZQnVLaUplVDJtU01QcUk4S2FCbnA5SVV6YWRlZWFzMzM3dW9aTjNjNU9FUW03ZDhCNFhHWVE9PQ==");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
