using System;
using Android.OS;
using Test1SCes.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(PlatformServiceAndroid)) ]
namespace Test1SCes.Droid
{
    public class PlatformServiceAndroid : IPlatformService
    {
        public PlatformServiceAndroid()
        {
        }

        public string getDeviceName()
        {
            String manufacturer = Build.Manufacturer;
            String model = Build.Model;
            return manufacturer + model;
        }

        public string GetModel()
        {
            return getDeviceName();
        }
    }
}
