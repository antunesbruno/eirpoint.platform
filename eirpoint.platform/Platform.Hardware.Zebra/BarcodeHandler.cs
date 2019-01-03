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
using Symbol.XamarinEMDK;

namespace Platform.Hardware.Zebra
{
    public class BarcodeHandler : EMDKManager.IEMDKListener
    {
        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnClosed()
        {
            throw new NotImplementedException();
        }

        public void OnOpened(EMDKManager p0)
        {
            throw new NotImplementedException();
        }

        public void SetEmdkResults()
        {
            EMDKResults results = EMDKManager.GetEMDKManager(Android.App.Application.Context, this);

            if (results.StatusCode != EMDKResults.STATUS_CODE.Success)
            {
                //ScannerStatus = "Status: EMDKManager object creation failed ...";
            }
            else
            {
                //ScannerStatus = "Status: EMDKManager object creation succeeded ...";
            }
        }
    }
}