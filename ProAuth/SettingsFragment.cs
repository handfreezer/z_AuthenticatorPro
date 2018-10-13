﻿using Android.OS;
using Android.Preferences;
using Android.Support.V7.Preferences;

namespace ProAuth
{
    public class SettingsFragment : PreferenceFragmentCompat
    {
        public override void OnCreatePreferences(Bundle savedInstanceState, string rootKey)
        {
            AddPreferencesFromResource(Resource.Xml.settings);
        }
    }
}