﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetSsh {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetSsh.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The classic authentication method is considered unsafe because your credentials with be stored inside the project folder (under Properties\launchsettings.json. Please, switch to another authentication method or be very careful not to upload the code to avoid revealing it..
        /// </summary>
        internal static string ClassicAuthWarning {
            get {
                return ResourceManager.GetString("ClassicAuthWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating profile &apos;{0}&apos;.
        /// </summary>
        internal static string CreatingProfile {
            get {
                return ResourceManager.GetString("CreatingProfile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please, provide the information about the profile.
        ///* NOTICE: You can press [ENTER] to keep each current value.
        ///.
        /// </summary>
        internal static string InformationPrompt {
            get {
                return ResourceManager.GetString("InformationPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating profile &apos;{0}&apos;.
        /// </summary>
        internal static string UpdatingProfile {
            get {
                return ResourceManager.GetString("UpdatingProfile", resourceCulture);
            }
        }
    }
}
