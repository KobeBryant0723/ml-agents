#if UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_STANDALONE_LINUX
// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/unity_to_external.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace MLAgents.CommunicatorObjects {
  internal static partial class UnityToExternalProto
  {
    static readonly string __ServiceName = "communicator_objects.UnityToExternalProto";

    static readonly grpc::Marshaller<global::MLAgents.CommunicatorObjects.UnityMessageProto> __Marshaller_communicator_objects_UnityMessageProto = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MLAgents.CommunicatorObjects.UnityMessageProto.Parser.ParseFrom);

    static readonly grpc::Method<global::MLAgents.CommunicatorObjects.UnityMessageProto, global::MLAgents.CommunicatorObjects.UnityMessageProto> __Method_Exchange = new grpc::Method<global::MLAgents.CommunicatorObjects.UnityMessageProto, global::MLAgents.CommunicatorObjects.UnityMessageProto>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Exchange",
        __Marshaller_communicator_objects_UnityMessageProto,
        __Marshaller_communicator_objects_UnityMessageProto);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::MLAgents.CommunicatorObjects.UnityToExternalReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UnityToExternalProto</summary>
    [grpc::BindServiceMethod(typeof(UnityToExternalProto), "BindService")]
    public abstract partial class UnityToExternalProtoBase
    {
      /// <summary>
      /// Sends the academy parameters
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::MLAgents.CommunicatorObjects.UnityMessageProto> Exchange(global::MLAgents.CommunicatorObjects.UnityMessageProto request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for UnityToExternalProto</summary>
    public partial class UnityToExternalProtoClient : grpc::ClientBase<UnityToExternalProtoClient>
    {
      /// <summary>Creates a new client for UnityToExternalProto</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UnityToExternalProtoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UnityToExternalProto that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UnityToExternalProtoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UnityToExternalProtoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UnityToExternalProtoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends the academy parameters
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::MLAgents.CommunicatorObjects.UnityMessageProto Exchange(global::MLAgents.CommunicatorObjects.UnityMessageProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Exchange(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends the academy parameters
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::MLAgents.CommunicatorObjects.UnityMessageProto Exchange(global::MLAgents.CommunicatorObjects.UnityMessageProto request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Exchange, null, options, request);
      }
      /// <summary>
      /// Sends the academy parameters
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::MLAgents.CommunicatorObjects.UnityMessageProto> ExchangeAsync(global::MLAgents.CommunicatorObjects.UnityMessageProto request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExchangeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends the academy parameters
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::MLAgents.CommunicatorObjects.UnityMessageProto> ExchangeAsync(global::MLAgents.CommunicatorObjects.UnityMessageProto request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Exchange, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UnityToExternalProtoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UnityToExternalProtoClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(UnityToExternalProtoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Exchange, serviceImpl.Exchange).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, UnityToExternalProtoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Exchange, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MLAgents.CommunicatorObjects.UnityMessageProto, global::MLAgents.CommunicatorObjects.UnityMessageProto>(serviceImpl.Exchange));
    }

  }
}
#endregion
#endif
