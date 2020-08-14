// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using System;
using UnityEngine;
using UnityEngine.Android;

namespace Microsoft.Azure.SpatialAnchors.Unity.Examples
{
    public class SensorPermissionHelper
    {
        /// <summary>
        /// iOS only: Whether the "Access WiFi Information" entitlement should be injected.
        /// If available, the MAC address of the connected Wi-Fi access point can be used
        /// to help find nearby anchors.
        /// </summary>
        /// <remarks>
        /// This requires a paid Apple Developer account.
        /// </remarks>
        public static readonly bool HaveAccessWifiInformationEntitlement = false;

        const string androidWifiAccessPermission = "android.permission.ACCESS_WIFI_STATE";
        const string androidWifiChangePermission = "android.permission.CHANGE_WIFI_STATE";
        const string androidBluetoothPermission = "android.permission.BLUETOOTH";
        const string androidBluetoothAdminPermission = "android.permission.BLUETOOTH_ADMIN";

        public static void RequestSensorPermissions()
        {
        }

        public static bool HasGeoLocationPermission()
        {
            return true;
        }

        public static bool HasWifiPermission()
        {
            return true;
        }

        public static bool HasBluetoothPermission()
        {
            return true;
        }

        private static void RequestPermissionIfNotGiven(string permission)
        {
        }

        private static bool IsBluetoothEnabled()
        {
            return false;
        }

        private static bool IsWiFiEnabled()
        {
            return false;
        }
    }
}
