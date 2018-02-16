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
// 	Generated by the Plexus Interop compiler.  DO NOT EDIT!
// 	source: interop\samples\GreetingServer.interop
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Samples.GreetingServer.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
					
	internal partial interface IGreetingServer: IClient {
	}
	
	internal sealed partial class GreetingServer: ClientBase, IGreetingServer {
		
		public const string Id = "interop.samples.GreetingServer";
		
		private static ClientOptions CreateClientOptions(GreetingServer.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null) {
			ClientOptionsBuilder builder = new ClientOptionsBuilder().WithApplicationId(Id).WithDefaultConfiguration();
			serviceBinder.Bind(builder);
			if (setup != null) {
				builder = setup(builder);
			}
			return builder.Build();
		}
		
		public GreetingServer(
			GreetingServer.IGreetingServiceImpl greetingService,
			Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null
		)
		:this(new GreetingServer.ServiceBinder(
			greetingService
		), setup) { }
		
		public GreetingServer(GreetingServer.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null): base(CreateClientOptions(serviceBinder, setup)) 
		{
		}
	
		public sealed partial class ServiceBinder {
			
			public ServiceBinder(
				GreetingServer.IGreetingServiceImpl greetingService
			) {
				_greetingServiceBinder = new GreetingServer.GreetingServiceBinder(greetingService);
			}
			
			private GreetingServiceBinder _greetingServiceBinder;
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				builder = _greetingServiceBinder.Bind(builder);
				return builder;
			}
		}
	
		public partial interface IGreetingServiceImpl:
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IUnaryImpl,
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IServerStreamingImpl,
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IClientStreamingImpl,
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IDuplexStreamingImpl
		{ }
		
		private sealed partial class GreetingServiceBinder {
			
			
			private readonly IGreetingServiceImpl _impl;
			
			public GreetingServiceBinder(IGreetingServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest, global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse>(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.UnaryMethodId, _impl.Unary);
				builder = builder.WithServerStreamingMethod<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest, global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse>(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.ServerStreamingMethodId, _impl.ServerStreaming);
				builder = builder.WithClientStreamingMethod<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest, global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse>(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.ClientStreamingMethodId, _impl.ClientStreaming);
				builder = builder.WithDuplexStreamingMethod<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest, global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse>(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.DuplexStreamingMethodId, _impl.DuplexStreaming);
				return builder; 							
			}
		}
		
		public sealed partial class GreetingServiceImpl<T>: IGreetingServiceImpl
			where T:
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IUnaryImpl,
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IServerStreamingImpl,
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IClientStreamingImpl,
			global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingService.IDuplexStreamingImpl
		{
			private readonly T _impl;
			
			public GreetingServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse> Unary(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest request, MethodCallContext context) {
				return _impl.Unary(request, context);
			}
			
			public Task ServerStreaming(global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest request, IWritableChannel<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse> responseStream, MethodCallContext context) {
				return _impl.ServerStreaming(request, responseStream, context);
			}
			
			public Task<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse> ClientStreaming(IReadableChannel<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest> requestStream, MethodCallContext context) {
				return _impl.ClientStreaming(requestStream, context);
			}
			
			public Task DuplexStreaming(IReadableChannel<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingRequest> requestStream, IWritableChannel<global::Plexus.Interop.Samples.GreetingServer.Generated.GreetingResponse> responseStream, MethodCallContext context) {
				return _impl.DuplexStreaming(requestStream, responseStream, context);
			}
		}
		
	}
}
#endregion Designer generated code
