﻿#region

using System;
using Tabster.Core.Plugins;

#endregion

namespace Songsterr
{
    public class SongsterrPlugin : ITabsterPlugin
    {
        #region Implementation of ITabsterPlugin

        public string Author
        {
            get { return "Nate Shoffner"; }
        }

        public string Copyright
        {
            get { return "Copyright © Nate Shoffner 2014"; }
        }

        public string Description
        {
            get { return "Supports songsterr.com tab searching and downloading."; }
        }

        public string DisplayName
        {
            get { return "Songsterr"; }
        }

        public Version Version
        {
            get { return new Version("1.0"); }
        }

        public Uri Website
        {
            get { return new Uri("http://nateshoffner.com"); }
        }

        public void Activate()
        {
            // not implemented
        }

        public void Deactivate()
        {
            // not implemented
        }

        public Type[] Types
        {
            get { return new[] {typeof (SongsterrSearch), typeof (SongsterrParser)}; }
        }

        #endregion
    }
}