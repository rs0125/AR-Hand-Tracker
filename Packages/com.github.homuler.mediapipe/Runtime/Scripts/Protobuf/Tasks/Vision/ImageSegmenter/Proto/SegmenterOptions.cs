// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/tasks/cc/vision/image_segmenter/proto/segmenter_options.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe.Tasks.Vision.ImageSegmenter.Proto {

  /// <summary>Holder for reflection information generated from mediapipe/tasks/cc/vision/image_segmenter/proto/segmenter_options.proto</summary>
  public static partial class SegmenterOptionsReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/tasks/cc/vision/image_segmenter/proto/segmenter_options.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SegmenterOptionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkdtZWRpYXBpcGUvdGFza3MvY2MvdmlzaW9uL2ltYWdlX3NlZ21lbnRlci9w",
            "cm90by9zZWdtZW50ZXJfb3B0aW9ucy5wcm90bxIsbWVkaWFwaXBlLnRhc2tz",
            "LnZpc2lvbi5pbWFnZV9zZWdtZW50ZXIucHJvdG8i1AIKEFNlZ21lbnRlck9w",
            "dGlvbnMSYgoLb3V0cHV0X3R5cGUYASABKA4ySS5tZWRpYXBpcGUudGFza3Mu",
            "dmlzaW9uLmltYWdlX3NlZ21lbnRlci5wcm90by5TZWdtZW50ZXJPcHRpb25z",
            "Lk91dHB1dFR5cGVCAhgBEmMKCmFjdGl2YXRpb24YAiABKA4ySS5tZWRpYXBp",
            "cGUudGFza3MudmlzaW9uLmltYWdlX3NlZ21lbnRlci5wcm90by5TZWdtZW50",
            "ZXJPcHRpb25zLkFjdGl2YXRpb246BE5PTkUiRQoKT3V0cHV0VHlwZRIPCgtV",
            "TlNQRUNJRklFRBAAEhEKDUNBVEVHT1JZX01BU0sQARITCg9DT05GSURFTkNF",
            "X01BU0sQAiIwCgpBY3RpdmF0aW9uEggKBE5PTkUQABILCgdTSUdNT0lEEAES",
            "CwoHU09GVE1BWBACQk8KNmNvbS5nb29nbGUubWVkaWFwaXBlLnRhc2tzLnZp",
            "c2lvbi5pbWFnZXNlZ21lbnRlci5wcm90b0IVU2VnbWVudGVyT3B0aW9uc1By",
            "b3Rv"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions), global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Parser, new[]{ "OutputType", "Activation" }, null, new[]{ typeof(global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType), typeof(global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Shared options used by image segmentation tasks.
  /// </summary>
  public sealed partial class SegmenterOptions : pb::IMessage<SegmenterOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SegmenterOptions> _parser = new pb::MessageParser<SegmenterOptions>(() => new SegmenterOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SegmenterOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SegmenterOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SegmenterOptions(SegmenterOptions other) : this() {
      _hasBits0 = other._hasBits0;
      outputType_ = other.outputType_;
      activation_ = other.activation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SegmenterOptions Clone() {
      return new SegmenterOptions(this);
    }

    /// <summary>Field number for the "output_type" field.</summary>
    public const int OutputTypeFieldNumber = 1;
    private readonly static global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType OutputTypeDefaultValue = global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType.Unspecified;

    private global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType outputType_;
    /// <summary>
    /// Optional output mask type.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType OutputType {
      get { if ((_hasBits0 & 1) != 0) { return outputType_; } else { return OutputTypeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        outputType_ = value;
      }
    }
    /// <summary>Gets whether the "output_type" field is set</summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOutputType {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "output_type" field</summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOutputType() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "activation" field.</summary>
    public const int ActivationFieldNumber = 2;
    private readonly static global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation ActivationDefaultValue = global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation.None;

    private global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation activation_;
    /// <summary>
    /// Activation function to apply to input tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation Activation {
      get { if ((_hasBits0 & 2) != 0) { return activation_; } else { return ActivationDefaultValue; } }
      set {
        _hasBits0 |= 2;
        activation_ = value;
      }
    }
    /// <summary>Gets whether the "activation" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasActivation {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "activation" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearActivation() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SegmenterOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SegmenterOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OutputType != other.OutputType) return false;
      if (Activation != other.Activation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasOutputType) hash ^= OutputType.GetHashCode();
      if (HasActivation) hash ^= Activation.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasOutputType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OutputType);
      }
      if (HasActivation) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Activation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasOutputType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OutputType);
      }
      if (HasActivation) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Activation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasOutputType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OutputType);
      }
      if (HasActivation) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Activation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SegmenterOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasOutputType) {
        OutputType = other.OutputType;
      }
      if (other.HasActivation) {
        Activation = other.Activation;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            OutputType = (global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType) input.ReadEnum();
            break;
          }
          case 16: {
            Activation = (global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            OutputType = (global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.OutputType) input.ReadEnum();
            break;
          }
          case 16: {
            Activation = (global::Mediapipe.Tasks.Vision.ImageSegmenter.Proto.SegmenterOptions.Types.Activation) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SegmenterOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Optional output mask type.
      /// </summary>
      public enum OutputType {
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Gives a single output mask where each pixel represents the class which
        /// the pixel in the original image was predicted to belong to.
        /// </summary>
        [pbr::OriginalName("CATEGORY_MASK")] CategoryMask = 1,
        /// <summary>
        /// Gives a list of output masks where, for each mask, each pixel represents
        /// the prediction confidence, usually in the [0, 1] range.
        /// </summary>
        [pbr::OriginalName("CONFIDENCE_MASK")] ConfidenceMask = 2,
      }

      /// <summary>
      /// Supported activation functions for filtering.
      /// </summary>
      public enum Activation {
        [pbr::OriginalName("NONE")] None = 0,
        /// <summary>
        /// Assumes 1-channel input tensor.
        /// </summary>
        [pbr::OriginalName("SIGMOID")] Sigmoid = 1,
        /// <summary>
        /// Assumes multi-channel input tensor.
        /// </summary>
        [pbr::OriginalName("SOFTMAX")] Softmax = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code