﻿using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using WyndhamBookingSystem.Views;

namespace WyndhamBookingSystem
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Helvetica-Neue-Roman.otf", "HelveticaNeueRoman");
                    fonts.AddFont("FluentSystemIcons-Regular.ttf", "FluentSystemIcons");
                })
                .ConfigureLifecycleEvents(events =>
                {
#if ANDROID
                    events.AddAndroid(android => android.OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));

                    static void MakeStatusBarTranslucent(Android.App.Activity activity)
                    {
                        activity.Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);
                        activity.Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
                        activity.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
                    }
#endif
                });



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
