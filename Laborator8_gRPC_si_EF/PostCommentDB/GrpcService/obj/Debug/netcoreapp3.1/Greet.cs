// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService {

  /// <summary>Holder for reflection information generated from Protos/greet.proto</summary>
  public static partial class GreetReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/greet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GreetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZ3JlZXQucHJvdG8iCgoIRW1wdHlNc2ciFQoHUG9zdEludBIK",
            "CgJpZBgBIAEoBSJvCglQb3N0TW9kZWwSDgoGcG9zdElkGAEgASgFEhMKC2Rl",
            "c2NyaXB0aW9uGAIgASgJEg4KBmRvbWFpbhgDIAEoCRIMCgRkYXRlGAQgASgJ",
            "Eh8KCGNvbW1lbnRzGAUgASgLMg0uQ29tbWVudHNMaXN0Ii4KDENvbW1lbnRz",
            "TGlzdBIeCgdjb21lbnRzGAEgAygLMg0uQ29tbWVudE1vZGVsIiYKCVBvc3Rz",
            "TGlzdBIZCgVwb3N0cxgBIAMoCzIKLlBvc3RNb2RlbCJdCgxDb21tZW50TW9k",
            "ZWwSEQoJQ29tbWVudElkGAEgASgFEgwKBFRleHQYAiABKAkSEgoKUG9zdFBv",
            "c3RJZBgDIAEoBRIYCgRQb3N0GAQgASgLMgouUG9zdE1vZGVsIiAKDlBvc3RS",
            "ZXBsYXlCb29sEg4KBnJlc3VsdBgBIAEoCDLCAQoFUG9zdEcSJgoHQWRkUG9z",
            "dBIKLlBvc3RNb2RlbBoPLlBvc3RSZXBsYXlCb29sEiQKC0dldEFsbFBvc3Rz",
            "EgkuRW1wdHlNc2caCi5Qb3N0c0xpc3QSJAoKVXBkYXRlUG9zdBIKLlBvc3RN",
            "b2RlbBoKLlBvc3RNb2RlbBIgCgpEZWxldGVQb3N0EgguUG9zdEludBoILlBv",
            "c3RJbnQSIwoLR2V0UG9zdEJ5SWQSCC5Qb3N0SW50GgouUG9zdE1vZGVsQg6q",
            "AgtHcnBjU2VydmljZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.EmptyMsg), global::GrpcService.EmptyMsg.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.PostInt), global::GrpcService.PostInt.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.PostModel), global::GrpcService.PostModel.Parser, new[]{ "PostId", "Description", "Domain", "Date", "Comments" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.CommentsList), global::GrpcService.CommentsList.Parser, new[]{ "Coments" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.PostsList), global::GrpcService.PostsList.Parser, new[]{ "Posts" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.CommentModel), global::GrpcService.CommentModel.Parser, new[]{ "CommentId", "Text", "PostPostId", "Post" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.PostReplayBool), global::GrpcService.PostReplayBool.Parser, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EmptyMsg : pb::IMessage<EmptyMsg> {
    private static readonly pb::MessageParser<EmptyMsg> _parser = new pb::MessageParser<EmptyMsg>(() => new EmptyMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmptyMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmptyMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmptyMsg(EmptyMsg other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmptyMsg Clone() {
      return new EmptyMsg(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmptyMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmptyMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmptyMsg other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  public sealed partial class PostInt : pb::IMessage<PostInt> {
    private static readonly pb::MessageParser<PostInt> _parser = new pb::MessageParser<PostInt>(() => new PostInt());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostInt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostInt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostInt(PostInt other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostInt Clone() {
      return new PostInt(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostInt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostInt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostInt other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PostModel : pb::IMessage<PostModel> {
    private static readonly pb::MessageParser<PostModel> _parser = new pb::MessageParser<PostModel>(() => new PostModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel(PostModel other) : this() {
      postId_ = other.postId_;
      description_ = other.description_;
      domain_ = other.domain_;
      date_ = other.date_;
      comments_ = other.comments_ != null ? other.comments_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostModel Clone() {
      return new PostModel(this);
    }

    /// <summary>Field number for the "postId" field.</summary>
    public const int PostIdFieldNumber = 1;
    private int postId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostId {
      get { return postId_; }
      set {
        postId_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 3;
    private string domain_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Domain {
      get { return domain_; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 4;
    private string date_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "comments" field.</summary>
    public const int CommentsFieldNumber = 5;
    private global::GrpcService.CommentsList comments_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcService.CommentsList Comments {
      get { return comments_; }
      set {
        comments_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PostId != other.PostId) return false;
      if (Description != other.Description) return false;
      if (Domain != other.Domain) return false;
      if (Date != other.Date) return false;
      if (!object.Equals(Comments, other.Comments)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PostId != 0) hash ^= PostId.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      if (comments_ != null) hash ^= Comments.GetHashCode();
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
      if (PostId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PostId);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Domain);
      }
      if (Date.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Date);
      }
      if (comments_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Comments);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PostId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostId);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
      }
      if (comments_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Comments);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostModel other) {
      if (other == null) {
        return;
      }
      if (other.PostId != 0) {
        PostId = other.PostId;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      if (other.comments_ != null) {
        if (comments_ == null) {
          Comments = new global::GrpcService.CommentsList();
        }
        Comments.MergeFrom(other.Comments);
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
          case 8: {
            PostId = input.ReadInt32();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Domain = input.ReadString();
            break;
          }
          case 34: {
            Date = input.ReadString();
            break;
          }
          case 42: {
            if (comments_ == null) {
              Comments = new global::GrpcService.CommentsList();
            }
            input.ReadMessage(Comments);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CommentsList : pb::IMessage<CommentsList> {
    private static readonly pb::MessageParser<CommentsList> _parser = new pb::MessageParser<CommentsList>(() => new CommentsList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommentsList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentsList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentsList(CommentsList other) : this() {
      coments_ = other.coments_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentsList Clone() {
      return new CommentsList(this);
    }

    /// <summary>Field number for the "coments" field.</summary>
    public const int ComentsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcService.CommentModel> _repeated_coments_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcService.CommentModel.Parser);
    private readonly pbc::RepeatedField<global::GrpcService.CommentModel> coments_ = new pbc::RepeatedField<global::GrpcService.CommentModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcService.CommentModel> Coments {
      get { return coments_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommentsList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommentsList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!coments_.Equals(other.coments_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= coments_.GetHashCode();
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
      coments_.WriteTo(output, _repeated_coments_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += coments_.CalculateSize(_repeated_coments_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommentsList other) {
      if (other == null) {
        return;
      }
      coments_.Add(other.coments_);
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
            coments_.AddEntriesFrom(input, _repeated_coments_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PostsList : pb::IMessage<PostsList> {
    private static readonly pb::MessageParser<PostsList> _parser = new pb::MessageParser<PostsList>(() => new PostsList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostsList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostsList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostsList(PostsList other) : this() {
      posts_ = other.posts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostsList Clone() {
      return new PostsList(this);
    }

    /// <summary>Field number for the "posts" field.</summary>
    public const int PostsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::GrpcService.PostModel> _repeated_posts_codec
        = pb::FieldCodec.ForMessage(10, global::GrpcService.PostModel.Parser);
    private readonly pbc::RepeatedField<global::GrpcService.PostModel> posts_ = new pbc::RepeatedField<global::GrpcService.PostModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcService.PostModel> Posts {
      get { return posts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostsList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostsList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!posts_.Equals(other.posts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= posts_.GetHashCode();
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
      posts_.WriteTo(output, _repeated_posts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += posts_.CalculateSize(_repeated_posts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostsList other) {
      if (other == null) {
        return;
      }
      posts_.Add(other.posts_);
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
            posts_.AddEntriesFrom(input, _repeated_posts_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CommentModel : pb::IMessage<CommentModel> {
    private static readonly pb::MessageParser<CommentModel> _parser = new pb::MessageParser<CommentModel>(() => new CommentModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommentModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentModel(CommentModel other) : this() {
      commentId_ = other.commentId_;
      text_ = other.text_;
      postPostId_ = other.postPostId_;
      post_ = other.post_ != null ? other.post_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommentModel Clone() {
      return new CommentModel(this);
    }

    /// <summary>Field number for the "CommentId" field.</summary>
    public const int CommentIdFieldNumber = 1;
    private int commentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CommentId {
      get { return commentId_; }
      set {
        commentId_ = value;
      }
    }

    /// <summary>Field number for the "Text" field.</summary>
    public const int TextFieldNumber = 2;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PostPostId" field.</summary>
    public const int PostPostIdFieldNumber = 3;
    private int postPostId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PostPostId {
      get { return postPostId_; }
      set {
        postPostId_ = value;
      }
    }

    /// <summary>Field number for the "Post" field.</summary>
    public const int PostFieldNumber = 4;
    private global::GrpcService.PostModel post_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcService.PostModel Post {
      get { return post_; }
      set {
        post_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommentModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommentModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CommentId != other.CommentId) return false;
      if (Text != other.Text) return false;
      if (PostPostId != other.PostPostId) return false;
      if (!object.Equals(Post, other.Post)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CommentId != 0) hash ^= CommentId.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (PostPostId != 0) hash ^= PostPostId.GetHashCode();
      if (post_ != null) hash ^= Post.GetHashCode();
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
      if (CommentId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CommentId);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Text);
      }
      if (PostPostId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PostPostId);
      }
      if (post_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Post);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CommentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CommentId);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (PostPostId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostPostId);
      }
      if (post_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Post);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommentModel other) {
      if (other == null) {
        return;
      }
      if (other.CommentId != 0) {
        CommentId = other.CommentId;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.PostPostId != 0) {
        PostPostId = other.PostPostId;
      }
      if (other.post_ != null) {
        if (post_ == null) {
          Post = new global::GrpcService.PostModel();
        }
        Post.MergeFrom(other.Post);
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
          case 8: {
            CommentId = input.ReadInt32();
            break;
          }
          case 18: {
            Text = input.ReadString();
            break;
          }
          case 24: {
            PostPostId = input.ReadInt32();
            break;
          }
          case 34: {
            if (post_ == null) {
              Post = new global::GrpcService.PostModel();
            }
            input.ReadMessage(Post);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message containing the greetings.
  /// </summary>
  public sealed partial class PostReplayBool : pb::IMessage<PostReplayBool> {
    private static readonly pb::MessageParser<PostReplayBool> _parser = new pb::MessageParser<PostReplayBool>(() => new PostReplayBool());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostReplayBool> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.GreetReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostReplayBool() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostReplayBool(PostReplayBool other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostReplayBool Clone() {
      return new PostReplayBool(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private bool result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostReplayBool);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostReplayBool other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != false) hash ^= Result.GetHashCode();
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
      if (Result != false) {
        output.WriteRawTag(8);
        output.WriteBool(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostReplayBool other) {
      if (other == null) {
        return;
      }
      if (other.Result != false) {
        Result = other.Result;
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
          case 8: {
            Result = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
