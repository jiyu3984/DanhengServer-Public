// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StatType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StatType.proto</summary>
  public static partial class StatTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for StatType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StatTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5TdGF0VHlwZS5wcm90bypfCghTdGF0VHlwZRISCg5TVEFUX1RZUEVfTk9O",
            "RRAAEhEKDVNUQVRfVFlQRV9BUlQQARIVChFTVEFUX1RZUEVfQ1VMVFVSRRAC",
            "EhUKEVNUQVRfVFlQRV9QT1BVTEFSEANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.StatType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum StatType {
    [pbr::OriginalName("STAT_TYPE_NONE")] None = 0,
    [pbr::OriginalName("STAT_TYPE_ART")] Art = 1,
    [pbr::OriginalName("STAT_TYPE_CULTURE")] Culture = 2,
    [pbr::OriginalName("STAT_TYPE_POPULAR")] Popular = 3,
  }

  #endregion

}

#endregion Designer generated code
