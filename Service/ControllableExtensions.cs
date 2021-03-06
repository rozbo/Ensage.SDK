// <copyright file="ControllableExtensions.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Service
{
    using System.Reflection;

    

    using PlaySharp.Toolkit.Helper;
    using NLog;

    public static class ControllableExtensions
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public static void TryActivate(this object target)
        {
            var activatable = target as IActivatable;
            if (activatable != null && !activatable.IsActive)
            {
                Log.Debug($"Activate Service {target}");
                activatable.Activate();
            }
        }

        public static void TryDeactivate(this object target)
        {
            var deactivatable = target as IDeactivatable;
            if (deactivatable != null)
            {
                Log.Debug($"Deactivate Service {target}");
                deactivatable.Deactivate();
            }
        }
    }
}