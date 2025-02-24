﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.SignCheck.Verification.Jar {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class JarResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal JarResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.SignCheck.Verification.Jar.JarResources", typeof(JarResources).Assembly);
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
        ///   Looks up a localized string similar to Digest mismatch for {0}. Manifest digest: &apos;{1}&apos;, computed digest: &apos;{2}&apos;..
        /// </summary>
        internal static string ManifestEntryDigestMismatch {
            get {
                return ResourceManager.GetString("ManifestEntryDigestMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature file entry for {0} ({1}) not found in manifest file..
        /// </summary>
        internal static string MissingManifestEntry {
            get {
                return ResourceManager.GetString("MissingManifestEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing signature block file ({0} or {1})..
        /// </summary>
        internal static string MissingSignatureBlockFile {
            get {
                return ResourceManager.GetString("MissingSignatureBlockFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing signature (META-INF/*.SF) or manifest file (META-INF/MANIFEST.MF)..
        /// </summary>
        internal static string MissingSignatureOrManifestFile {
            get {
                return ResourceManager.GetString("MissingSignatureOrManifestFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Digest mismatch for {0} in {1}. Computed digest: &apos;{2}&apos;, expected digest &apos;{3}&apos;...
        /// </summary>
        internal static string SignatureFileEntryDigestMismatch {
            get {
                return ResourceManager.GetString("SignatureFileEntryDigestMismatch", resourceCulture);
            }
        }
    }
}
