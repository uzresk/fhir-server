﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Azure {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Microsoft.Health.Fhir.Azure.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string AnonymizationConfigurationNotFound {
            get {
                return ResourceManager.GetString("AnonymizationConfigurationNotFound", resourceCulture);
            }
        }
        
        internal static string AnonymizationConfigurationTooLarge {
            get {
                return ResourceManager.GetString("AnonymizationConfigurationTooLarge", resourceCulture);
            }
        }
        
        internal static string AnonymizationContainerNotFound {
            get {
                return ResourceManager.GetString("AnonymizationContainerNotFound", resourceCulture);
            }
        }
        
        internal static string CannotGetAccessToken {
            get {
                return ResourceManager.GetString("CannotGetAccessToken", resourceCulture);
            }
        }

        internal static string CannotGetAcrAccessToken
        {
            get
            {
                return ResourceManager.GetString("CannotGetAcrAccessToken", resourceCulture);
            }
        }

        internal static string CannotGetAuthorizedClient {
            get {
                return ResourceManager.GetString("CannotGetAuthorizedClient", resourceCulture);
            }
        }

        internal static string ContainerRegistryNotAuthorized
        {
            get
            {
                return ResourceManager.GetString("ContainerRegistryNotAuthorized", resourceCulture);
            }
        }

        internal static string ContainerRegistryNotFound
        {
            get
            {
                return ResourceManager.GetString("ContainerRegistryNotFound", resourceCulture);
            }
        }

        internal static string DestinationClientNotConnected {
            get {
                return ResourceManager.GetString("DestinationClientNotConnected", resourceCulture);
            }
        }
        
        internal static string InvalidConnectionSettings {
            get {
                return ResourceManager.GetString("InvalidConnectionSettings", resourceCulture);
            }
        }
        
        internal static string InvalidStorageUri {
            get {
                return ResourceManager.GetString("InvalidStorageUri", resourceCulture);
            }
        }

    }
}
