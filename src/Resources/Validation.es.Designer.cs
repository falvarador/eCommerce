﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.WebApi.Resource {
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
    public class Validation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Validation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("eCommerce.WebApi.Resources.Validation", typeof(Validation).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El monto total a ministrar es diferente a la sumatoria de los montos detalles..
        /// </summary>
        public static string DifferentAmounts {
            get {
                return ResourceManager.GetString("DifferentAmounts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El valor del parámetro {0} es menor al parámetro {1}..
        /// </summary>
        public static string ParameterGreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("ParameterGreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El valor del parámetro {0} es mayor al parámetro {1}..
        /// </summary>
        public static string ParameterLessThanOrEqualTo {
            get {
                return ResourceManager.GetString("ParameterLessThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El parámetro {0} no puede ser mayor a {1} caracter(es)..
        /// </summary>
        public static string ParameterMaximumLength {
            get {
                return ResourceManager.GetString("ParameterMaximumLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El parámetro {0} no puede estar vacío..
        /// </summary>
        public static string ParameterNotEmpty {
            get {
                return ResourceManager.GetString("ParameterNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El parámetro {0} no admite valores nulos..
        /// </summary>
        public static string ParameterNotNull {
            get {
                return ResourceManager.GetString("ParameterNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Por favor solo use: {0}..
        /// </summary>
        public static string ParameterOnlyValues {
            get {
                return ResourceManager.GetString("ParameterOnlyValues", resourceCulture);
            }
        }
    }
}