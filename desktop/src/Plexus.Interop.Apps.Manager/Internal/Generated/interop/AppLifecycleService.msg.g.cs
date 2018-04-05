/**
 * Copyright 2017 Plexus Interop Deutsche Bank AG
 * SPDX-License-Identifier: Apache-2.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: interop/app_lifecycle_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Apps.Internal.Generated {

  /// <summary>Holder for reflection information generated from interop/app_lifecycle_service.proto</summary>
  internal static partial class AppLifecycleServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/app_lifecycle_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppLifecycleServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNpbnRlcm9wL2FwcF9saWZlY3ljbGVfc2VydmljZS5wcm90bxIHaW50ZXJv",
            "cBoXaW50ZXJvcC91bmlxdWVfaWQucHJvdG8aHWludGVyb3AvYXBwX2xhdW5j",
            "aF9tb2RlLnByb3RvGhVpbnRlcm9wL29wdGlvbnMucHJvdG8idAoRUmVzb2x2",
            "ZUFwcFJlcXVlc3QSDgoGYXBwX2lkGAEgASgJEjAKEGFwcF9yZXNvbHZlX21v",
            "ZGUYAiABKA4yFi5pbnRlcm9wLkFwcExhdW5jaE1vZGU6HZLbBBlpbnRlcm9w",
            "LlJlc29sdmVBcHBSZXF1ZXN0IrABChJSZXNvbHZlQXBwUmVzcG9uc2USKgoP",
            "YXBwX2luc3RhbmNlX2lkGAEgASgLMhEuaW50ZXJvcC5VbmlxdWVJZBIsChFh",
            "cHBfY29ubmVjdGlvbl9pZBgCIAEoCzIRLmludGVyb3AuVW5pcXVlSWQSIAoY",
            "aXNfbmV3X2luc3RhbmNlX2xhdW5jaGVkGAMgASgIOh6S2wQaaW50ZXJvcC5S",
            "ZXNvbHZlQXBwUmVzcG9uc2UyfQoTQXBwTGlmZWN5Y2xlU2VydmljZRJFCgpS",
            "ZXNvbHZlQXBwEhouaW50ZXJvcC5SZXNvbHZlQXBwUmVxdWVzdBobLmludGVy",
            "b3AuUmVzb2x2ZUFwcFJlc3BvbnNlGh+S2wQbaW50ZXJvcC5BcHBMaWZlY3lj",
            "bGVTZXJ2aWNlQimqAiZQbGV4dXMuSW50ZXJvcC5BcHBzLkludGVybmFsLkdl",
            "bmVyYXRlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Apps.Internal.Generated.UniqueIdReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchModeReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest), global::Plexus.Interop.Apps.Internal.Generated.ResolveAppRequest.Parser, new[]{ "AppId", "AppResolveMode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse), global::Plexus.Interop.Apps.Internal.Generated.ResolveAppResponse.Parser, new[]{ "AppInstanceId", "AppConnectionId", "IsNewInstanceLaunched" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ResolveAppRequest : pb::IMessage<ResolveAppRequest> {
    private static readonly pb::MessageParser<ResolveAppRequest> _parser = new pb::MessageParser<ResolveAppRequest>(() => new ResolveAppRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResolveAppRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppRequest(ResolveAppRequest other) : this() {
      appId_ = other.appId_;
      appResolveMode_ = other.appResolveMode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppRequest Clone() {
      return new ResolveAppRequest(this);
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 1;
    private string appId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppId {
      get { return appId_; }
      set {
        appId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "app_resolve_mode" field.</summary>
    public const int AppResolveModeFieldNumber = 2;
    private global::Plexus.Interop.Apps.Internal.Generated.AppLaunchMode appResolveMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.AppLaunchMode AppResolveMode {
      get { return appResolveMode_; }
      set {
        appResolveMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolveAppRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResolveAppRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppId != other.AppId) return false;
      if (AppResolveMode != other.AppResolveMode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AppId.Length != 0) hash ^= AppId.GetHashCode();
      if (AppResolveMode != 0) hash ^= AppResolveMode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AppId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppId);
      }
      if (AppResolveMode != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) AppResolveMode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AppId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppId);
      }
      if (AppResolveMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AppResolveMode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResolveAppRequest other) {
      if (other == null) {
        return;
      }
      if (other.AppId.Length != 0) {
        AppId = other.AppId;
      }
      if (other.AppResolveMode != 0) {
        AppResolveMode = other.AppResolveMode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AppId = input.ReadString();
            break;
          }
          case 16: {
            appResolveMode_ = (global::Plexus.Interop.Apps.Internal.Generated.AppLaunchMode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ResolveAppResponse : pb::IMessage<ResolveAppResponse> {
    private static readonly pb::MessageParser<ResolveAppResponse> _parser = new pb::MessageParser<ResolveAppResponse>(() => new ResolveAppResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResolveAppResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLifecycleServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppResponse(ResolveAppResponse other) : this() {
      AppInstanceId = other.appInstanceId_ != null ? other.AppInstanceId.Clone() : null;
      AppConnectionId = other.appConnectionId_ != null ? other.AppConnectionId.Clone() : null;
      isNewInstanceLaunched_ = other.isNewInstanceLaunched_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResolveAppResponse Clone() {
      return new ResolveAppResponse(this);
    }

    /// <summary>Field number for the "app_instance_id" field.</summary>
    public const int AppInstanceIdFieldNumber = 1;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appInstanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppInstanceId {
      get { return appInstanceId_; }
      set {
        appInstanceId_ = value;
      }
    }

    /// <summary>Field number for the "app_connection_id" field.</summary>
    public const int AppConnectionIdFieldNumber = 2;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appConnectionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppConnectionId {
      get { return appConnectionId_; }
      set {
        appConnectionId_ = value;
      }
    }

    /// <summary>Field number for the "is_new_instance_launched" field.</summary>
    public const int IsNewInstanceLaunchedFieldNumber = 3;
    private bool isNewInstanceLaunched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsNewInstanceLaunched {
      get { return isNewInstanceLaunched_; }
      set {
        isNewInstanceLaunched_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResolveAppResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResolveAppResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AppInstanceId, other.AppInstanceId)) return false;
      if (!object.Equals(AppConnectionId, other.AppConnectionId)) return false;
      if (IsNewInstanceLaunched != other.IsNewInstanceLaunched) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (appInstanceId_ != null) hash ^= AppInstanceId.GetHashCode();
      if (appConnectionId_ != null) hash ^= AppConnectionId.GetHashCode();
      if (IsNewInstanceLaunched != false) hash ^= IsNewInstanceLaunched.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (appInstanceId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AppInstanceId);
      }
      if (appConnectionId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppConnectionId);
      }
      if (IsNewInstanceLaunched != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsNewInstanceLaunched);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (appInstanceId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppInstanceId);
      }
      if (appConnectionId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppConnectionId);
      }
      if (IsNewInstanceLaunched != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResolveAppResponse other) {
      if (other == null) {
        return;
      }
      if (other.appInstanceId_ != null) {
        if (appInstanceId_ == null) {
          appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppInstanceId.MergeFrom(other.AppInstanceId);
      }
      if (other.appConnectionId_ != null) {
        if (appConnectionId_ == null) {
          appConnectionId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppConnectionId.MergeFrom(other.AppConnectionId);
      }
      if (other.IsNewInstanceLaunched != false) {
        IsNewInstanceLaunched = other.IsNewInstanceLaunched;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (appInstanceId_ == null) {
              appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appInstanceId_);
            break;
          }
          case 18: {
            if (appConnectionId_ == null) {
              appConnectionId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appConnectionId_);
            break;
          }
          case 24: {
            IsNewInstanceLaunched = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code