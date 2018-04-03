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
// 	source: interop\native_app_launcher.interop
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code
namespace Plexus.Interop.Apps.Internal.Generated {
	
	using System;
	using global::Plexus;
	using global::Plexus.Channels;
	using global::Plexus.Interop;
	using global::System.Threading.Tasks;
					
					
	internal partial interface INativeAppLauncherClient: IClient {
	}
	
	internal sealed partial class NativeAppLauncherClient: ClientBase, INativeAppLauncherClient {
		
		public const string Id = "interop.NativeAppLauncher";
		
		private static ClientOptions CreateClientOptions(NativeAppLauncherClient.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null) {
			ClientOptionsBuilder builder = new ClientOptionsBuilder().WithApplicationId(Id).WithDefaultConfiguration();
			serviceBinder.Bind(builder);
			if (setup != null) {
				builder = setup(builder);
			}
			return builder.Build();
		}
		
		public NativeAppLauncherClient(
			NativeAppLauncherClient.IAppLauncherServiceImpl appLauncherService,
			Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null
		)
		:this(new NativeAppLauncherClient.ServiceBinder(
			appLauncherService
		), setup) { }
		
		public NativeAppLauncherClient(NativeAppLauncherClient.ServiceBinder serviceBinder, Func<ClientOptionsBuilder, ClientOptionsBuilder> setup = null): base(CreateClientOptions(serviceBinder, setup)) 
		{
		}
	
		public sealed partial class ServiceBinder {
			
			public ServiceBinder(
				NativeAppLauncherClient.IAppLauncherServiceImpl appLauncherService
			) {
				_appLauncherServiceBinder = new NativeAppLauncherClient.AppLauncherServiceBinder(appLauncherService);
			}
			
			private AppLauncherServiceBinder _appLauncherServiceBinder;
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				builder = _appLauncherServiceBinder.Bind(builder);
				return builder;
			}
		}
	
		public partial interface IAppLauncherServiceImpl:
			global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.ILaunchImpl
		{ }
		
		private sealed partial class AppLauncherServiceBinder {
			
			
			private readonly IAppLauncherServiceImpl _impl;
			
			public AppLauncherServiceBinder(IAppLauncherServiceImpl impl) {
				_impl = impl;
			}
			
			public ClientOptionsBuilder Bind(ClientOptionsBuilder builder) {
				return builder.WithProvidedService(global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.Id, Bind);
			}
			
			private ProvidedServiceDefinition.Builder Bind(ProvidedServiceDefinition.Builder builder) {
				builder = builder.WithUnaryMethod<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse>(global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.LaunchMethodId, _impl.Launch);
				return builder; 							
			}
		}
		
		public sealed partial class AppLauncherServiceImpl: IAppLauncherServiceImpl
		{
			private readonly UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> _launchHandler;
			
			public AppLauncherServiceImpl(
				UnaryMethodHandler<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest, global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> launchHandler
			) {
				_launchHandler = launchHandler;
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> Launch(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest request, MethodCallContext context) {
				return _launchHandler(request, context);
			}
		}					
		
		public sealed partial class AppLauncherServiceImpl<T>: IAppLauncherServiceImpl
			where T:
			global::Plexus.Interop.Apps.Internal.Generated.AppLauncherService.ILaunchImpl
		{
			private readonly T _impl;
			
			public AppLauncherServiceImpl(T impl) {
				_impl = impl;
			}
			
			public Task<global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse> Launch(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest request, MethodCallContext context) {
				return _impl.Launch(request, context);
			}
		}
		
	}
}
#endregion Designer generated code
