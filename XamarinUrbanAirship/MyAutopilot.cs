using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UrbanAirship;
using Android.Support.V4.Content;

namespace XamarinUrbanAirship
{
    [Register("com.bitscry.xamarinurbanairship.MyAutopilot")]
    public class MyAutopilot : Autopilot
    {
        public override void OnAirshipReady(UAirship airship)
        {
            // perform any post takeOff airship customizations
            airship.PushManager.PushEnabled = true;
            airship.PushManager.UserNotificationsEnabled = true;
        }

        public override AirshipConfigOptions CreateAirshipConfigOptions(Context context)
        {
            AirshipConfigOptions options = new AirshipConfigOptions.Builder()
                 .SetInProduction(!BuildConfig.Debug)
                 .SetDevelopmentAppKey("Your Development App Key")
                 .SetDevelopmentAppSecret("Your Development App Secret")
                 .SetProductionAppKey("Your Production App Key")
                 .SetProductionAppSecret("Your Production App Secret")
                 .SetGcmSender("Your GCM Sender ID")
                .Build();

            return options;
        }
    }
}