﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEACruncher.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MEACruncher.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon MeaCruncher {
            get {
                object obj = ResourceManager.GetObject("MeaCruncher", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to meadata.
        /// </summary>
        internal static string MeaDataDbName {
            get {
                return ResourceManager.GetString("MeaDataDbName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 3.9.
        /// </summary>
        internal static string MeaDataDbVersion {
            get {
                return ResourceManager.GetString("MeaDataDbVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- ********** DATABASE STRUCTURE ********** 
        /// 
        ///
        ////*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
        ////*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
        ////*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
        ////*!40101 SET NAMES utf8 */;
        ////*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
        ////*!40103 SET TIME_ZONE=&apos;+00:00&apos; */;
        ////*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
        ////*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MeaDataSql {
            get {
                return ResourceManager.GetString("MeaDataSql", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server=localhost;Port=3306;CharSet=utf8;User id=root;Pwd=mysqlShundra8820;.
        /// </summary>
        internal static string MySqlConnectionString {
            get {
                return ResourceManager.GetString("MySqlConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap NeuronBackground {
            get {
                object obj = ResourceManager.GetObject("NeuronBackground", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap redoSmall {
            get {
                object obj = ResourceManager.GetObject("redoSmall", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap undoSmall {
            get {
                object obj = ResourceManager.GetObject("undoSmall", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
