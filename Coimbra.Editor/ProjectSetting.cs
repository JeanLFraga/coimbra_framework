﻿using System.Diagnostics.CodeAnalysis;
using UnityEditor;
using UnityEditor.SettingsManagement;

namespace Coimbra.Editor
{
    internal sealed class ProjectSetting<T> : UserSetting<T>
    {
        [SuppressMessage("ReSharper", "RedundantArgumentDefaultValue")]
        internal ProjectSetting(string key, T value)
            : base(CoimbraSettingsProviderRegister.Settings, CoimbraSettingsProviderRegister.ProjectSettingsName, key, value, SettingsScope.Project) { }
    }
}