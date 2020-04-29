// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class PostG
  {
    static readonly string __ServiceName = "PostG";

    static readonly grpc::Marshaller<global::GrpcService.PostModel> __Marshaller_PostModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostReplayBool> __Marshaller_PostReplayBool = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostReplayBool.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.EmptyMsg> __Marshaller_EmptyMsg = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.EmptyMsg.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostsList> __Marshaller_PostsList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostsList.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.PostInt> __Marshaller_PostInt = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.PostInt.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostReplayBool> __Method_AddPost = new grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostReplayBool>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_PostModel,
        __Marshaller_PostReplayBool);

    static readonly grpc::Method<global::GrpcService.EmptyMsg, global::GrpcService.PostsList> __Method_GetAllPosts = new grpc::Method<global::GrpcService.EmptyMsg, global::GrpcService.PostsList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_EmptyMsg,
        __Marshaller_PostsList);

    static readonly grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostModel> __Method_UpdatePost = new grpc::Method<global::GrpcService.PostModel, global::GrpcService.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_PostModel,
        __Marshaller_PostModel);

    static readonly grpc::Method<global::GrpcService.PostInt, global::GrpcService.PostInt> __Method_DeletePost = new grpc::Method<global::GrpcService.PostInt, global::GrpcService.PostInt>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_PostInt,
        __Marshaller_PostInt);

    static readonly grpc::Method<global::GrpcService.PostInt, global::GrpcService.PostModel> __Method_GetPostById = new grpc::Method<global::GrpcService.PostInt, global::GrpcService.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_PostInt,
        __Marshaller_PostModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PostG</summary>
    [grpc::BindServiceMethod(typeof(PostG), "BindService")]
    public abstract partial class PostGBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostReplayBool> AddPost(global::GrpcService.PostModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostsList> GetAllPosts(global::GrpcService.EmptyMsg request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostModel> UpdatePost(global::GrpcService.PostModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostInt> DeletePost(global::GrpcService.PostInt request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.PostModel> GetPostById(global::GrpcService.PostInt request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PostGBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddPost, serviceImpl.AddPost)
          .AddMethod(__Method_GetAllPosts, serviceImpl.GetAllPosts)
          .AddMethod(__Method_UpdatePost, serviceImpl.UpdatePost)
          .AddMethod(__Method_DeletePost, serviceImpl.DeletePost)
          .AddMethod(__Method_GetPostById, serviceImpl.GetPostById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PostGBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddPost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostModel, global::GrpcService.PostReplayBool>(serviceImpl.AddPost));
      serviceBinder.AddMethod(__Method_GetAllPosts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.EmptyMsg, global::GrpcService.PostsList>(serviceImpl.GetAllPosts));
      serviceBinder.AddMethod(__Method_UpdatePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostModel, global::GrpcService.PostModel>(serviceImpl.UpdatePost));
      serviceBinder.AddMethod(__Method_DeletePost, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostInt, global::GrpcService.PostInt>(serviceImpl.DeletePost));
      serviceBinder.AddMethod(__Method_GetPostById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.PostInt, global::GrpcService.PostModel>(serviceImpl.GetPostById));
    }

  }
}
#endregion
