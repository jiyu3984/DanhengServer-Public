// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClockParkPlayStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ClockParkPlayStatus.proto</summary>
  public static partial class ClockParkPlayStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for ClockParkPlayStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClockParkPlayStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDbG9ja1BhcmtQbGF5U3RhdHVzLnByb3RvKpUBChNDbG9ja1BhcmtQbGF5",
            "U3RhdHVzEhgKFENMT0NLX1BBUktfUExBWV9OT05FEAASIAocQ0xPQ0tfUEFS",
            "S19QTEFZX05PUk1BTF9ERUFUSBABEh8KG0NMT0NLX1BBUktfUExBWV9OT1JN",
            "QUxfUEFTUxACEiEKHUNMT0NLX1BBUktfUExBWV9GSU5JU0hfU0NSSVBUEAVC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.ClockParkPlayStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ClockParkPlayStatus {
    [pbr::OriginalName("CLOCK_PARK_PLAY_NONE")] ClockParkPlayNone = 0,
    [pbr::OriginalName("CLOCK_PARK_PLAY_NORMAL_DEATH")] ClockParkPlayNormalDeath = 1,
    [pbr::OriginalName("CLOCK_PARK_PLAY_NORMAL_PASS")] ClockParkPlayNormalPass = 2,
    [pbr::OriginalName("CLOCK_PARK_PLAY_FINISH_SCRIPT")] ClockParkPlayFinishScript = 5,
  }

  #endregion

}

#endregion Designer generated code