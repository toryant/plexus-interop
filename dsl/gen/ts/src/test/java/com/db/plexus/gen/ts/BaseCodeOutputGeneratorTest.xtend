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
package com.db.plexus.gen.ts

import static org.junit.Assert.*;
import org.eclipse.xtext.naming.IQualifiedNameConverter
import org.eclipse.xtext.resource.IResourceServiceProvider
import com.google.inject.Inject
import org.eclipse.emf.ecore.resource.Resource

class BaseCodeOutputGeneratorTest {

    @Inject IResourceServiceProvider.Registry rspr
    @Inject IQualifiedNameConverter converter

    def void printExportedObjects(Resource resource) {
        val resServiceProvider = rspr.getResourceServiceProvider(resource.URI)
        val manager = resServiceProvider.getResourceDescriptionManager()
        val description = manager.getResourceDescription(resource)
        for(eod : description.exportedObjects) {
            println(converter.toString(eod.qualifiedName))
        }
    }

    def assertEqualsIgnoreWhiteSpaces(String s1, String s2) {
        assertEquals("Equals ignoring whitespaces",
        s1.replaceAll("\\s", ""),
        s2.replaceAll("\\s", ""));
    }

    def fullExpectedContent() '''
import { MethodInvocationContext, Completion, ClientConnectRequest, StreamingInvocationClient, GenericClientApi, InvocationRequestInfo, InvocationClient, GenericRequest } from "@plexus-interop/client";
import { ProvidedMethodReference, ServiceDiscoveryRequest, ServiceDiscoveryResponse, MethodDiscoveryRequest, MethodDiscoveryResponse, GenericClientApiBuilder, ValueHandler } from "@plexus-interop/client";
import { TransportConnection, UniqueId } from "@plexus-interop/transport-common";
import { Arrays, Observer, ConversionObserver } from "@plexus-interop/common";

import * as plexus from "./plexus-messages";

/**
 *  Proxy interface of ExampleService service, to be consumed by Client API
 */
export abstract class ExampleServiceProxy {

    public abstract pointToPoint(request: plexus.com.plexus.model.IRequest): Promise<plexus.com.plexus.model.IResponse>;

    public abstract serverStreaming(request: plexus.com.plexus.model.IRequest, responseObserver: Observer<plexus.com.plexus.model.IResponse>): Promise<InvocationClient>;

    public abstract clientToServer(responseObserver: Observer<plexus.com.plexus.model.IResponse>): Promise<StreamingInvocationClient<plexus.com.plexus.model.IRequest>>;

    public abstract bidiStreaming(responseObserver: Observer<plexus.com.plexus.model.IResponse>): Promise<StreamingInvocationClient<plexus.com.plexus.model.IRequest>>;

}

/**
 *  Internal Proxy implementation for ExampleService service
 */
export class ExampleServiceProxyImpl implements ExampleServiceProxy {

    constructor(private readonly genericClient: GenericClientApi) { }

    public pointToPoint(request: plexus.com.plexus.model.IRequest): Promise<plexus.com.plexus.model.IResponse> {
        const requestToBinaryConverter = (from: plexus.com.plexus.model.IRequest) => Arrays.toArrayBuffer(plexus.com.plexus.model.Request.encode(from).finish());
        const responseFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Response.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Response.toObject(decoded);
        };
        const invocationInfo: InvocationRequestInfo = {
            methodId: "PointToPoint",
            serviceId: "com.plexus.services.ExampleService"
        };
        return new Promise((resolve, reject) => {
            this.genericClient.sendRawUnaryRequest(invocationInfo, requestToBinaryConverter(request), {
                value: (responsePayload: ArrayBuffer) => {
                    resolve(responseFromBinaryConverter(responsePayload));
                },
                error: (e) => {
                    reject(e);
                }
            });
        });
    }

    public serverStreaming(request: plexus.com.plexus.model.IRequest, responseObserver: Observer<plexus.com.plexus.model.IResponse>): Promise<InvocationClient> {
        const requestToBinaryConverter = (from: plexus.com.plexus.model.IRequest) => Arrays.toArrayBuffer(plexus.com.plexus.model.Request.encode(from).finish());
        const responseFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Response.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Response.toObject(decoded);
        };
        const invocationInfo: InvocationRequestInfo = {
            methodId: "ServerStreaming",
            serviceId: "com.plexus.services.ExampleService"
        };
        return this.genericClient.sendRawServerStreamingRequest(
            invocationInfo,
            requestToBinaryConverter(request),
            new ConversionObserver<plexus.com.plexus.model.IResponse, ArrayBuffer>(responseObserver, responseFromBinaryConverter));
    }

    public clientToServer(responseObserver: Observer<plexus.com.plexus.model.IResponse>): Promise<StreamingInvocationClient<plexus.com.plexus.model.IRequest>> {
        const requestToBinaryConverter = (from: plexus.com.plexus.model.IRequest) => Arrays.toArrayBuffer(plexus.com.plexus.model.Request.encode(from).finish());
        const responseFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Response.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Response.toObject(decoded);
        };
        const invocationInfo: InvocationRequestInfo = {
            methodId: "ClientToServer",
            serviceId: "com.plexus.services.ExampleService"
        };
        return this.genericClient.sendRawBidirectionalStreamingRequest(
            invocationInfo,
            new ConversionObserver<plexus.com.plexus.model.IResponse, ArrayBuffer>(responseObserver, responseFromBinaryConverter))
            .then(baseClient =>  {
                return {
                    next: (request: plexus.com.plexus.model.IRequest) => baseClient.next(requestToBinaryConverter(request)),
                    error: baseClient.error.bind(baseClient),
                    complete: baseClient.complete.bind(baseClient),
                    cancel: baseClient.cancel.bind(baseClient)
                };
            });
    }

    public bidiStreaming(responseObserver: Observer<plexus.com.plexus.model.IResponse>): Promise<StreamingInvocationClient<plexus.com.plexus.model.IRequest>> {
        const requestToBinaryConverter = (from: plexus.com.plexus.model.IRequest) => Arrays.toArrayBuffer(plexus.com.plexus.model.Request.encode(from).finish());
        const responseFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Response.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Response.toObject(decoded);
        };
        const invocationInfo: InvocationRequestInfo = {
            methodId: "BidiStreaming",
            serviceId: "com.plexus.services.ExampleService"
        };
        return this.genericClient.sendRawBidirectionalStreamingRequest(
            invocationInfo,
            new ConversionObserver<plexus.com.plexus.model.IResponse, ArrayBuffer>(responseObserver, responseFromBinaryConverter))
            .then(baseClient =>  {
                return {
                    next: (request: plexus.com.plexus.model.IRequest) => baseClient.next(requestToBinaryConverter(request)),
                    error: baseClient.error.bind(baseClient),
                    complete: baseClient.complete.bind(baseClient),
                    cancel: baseClient.cancel.bind(baseClient)
                };
            });
    }

}

/**
 * Main client API
 *
 */
export abstract class ComponentAClient {

    public abstract getExampleServiceProxy(): ExampleServiceProxy;

    public abstract sendUnaryRequest(invocationInfo: GenericRequest, request: any, responseHandler: ValueHandler<any>, requestMarshaller: any, responseType: any): Promise<InvocationClient>;

    public abstract sendRawUnaryRequest(invocationInfo: GenericRequest, request: ArrayBuffer, responseHandler: ValueHandler<ArrayBuffer>): Promise<InvocationClient>;

    public abstract sendServerStreamingRequest(invocationInfo: GenericRequest, request: any, responseObserver: Observer<any>, requestType: any, responseType: any): Promise<InvocationClient>;

    public abstract sendRawServerStreamingRequest(
        invocationInfo: InvocationRequestInfo,
        request: ArrayBuffer,
        responseObserver: Observer<ArrayBuffer>): Promise<InvocationClient>;

    public abstract sendBidirectionalStreamingRequest(invocationInfo: GenericRequest, responseObserver: Observer<any>, requestType: any, responseType: any): Promise<StreamingInvocationClient<any>>;

    public abstract sendRawBidirectionalStreamingRequest(invocationInfo: GenericRequest, responseObserver: Observer<ArrayBuffer>): Promise<StreamingInvocationClient<ArrayBuffer>>;

    public abstract discoverService(discoveryRequest: ServiceDiscoveryRequest): Promise<ServiceDiscoveryResponse>;

    public abstract discoverMethod(discoveryRequest: MethodDiscoveryRequest): Promise<MethodDiscoveryResponse>;

    public abstract disconnect(completion?: Completion): Promise<void>;

}

/**
 * Client's API internal implementation
 *
 */
class ComponentAClientImpl implements ComponentAClient {

    public constructor(
        private readonly genericClient: GenericClientApi,
        private readonly exampleServiceProxy: ExampleServiceProxy
    ) { }

    public getExampleServiceProxy(): ExampleServiceProxy {
        return this.exampleServiceProxy;
    }

    public sendUnaryRequest(invocationInfo: GenericRequest, request: any, responseHandler: ValueHandler<any>, requestType: any, responseType: any): Promise<InvocationClient> {
        return this.genericClient.sendUnaryRequest(invocationInfo, request, responseHandler, requestType, responseType);
    }

    public sendRawUnaryRequest(invocationInfo: GenericRequest, request: ArrayBuffer, responseHandler: ValueHandler<ArrayBuffer>): Promise<InvocationClient> {
        return this.genericClient.sendRawUnaryRequest(invocationInfo, request, responseHandler);
    }

    public sendServerStreamingRequest(invocationInfo: GenericRequest, request: any, responseObserver: Observer<any>, requestType: any, responseType: any): Promise<InvocationClient> {
        return this.genericClient.sendServerStreamingRequest(invocationInfo, request, responseObserver, requestType, responseType);
    }

    public sendRawServerStreamingRequest(
        invocationInfo: GenericRequest,
        request: ArrayBuffer,
        responseObserver: Observer<ArrayBuffer>): Promise<InvocationClient> {
        return this.genericClient.sendRawServerStreamingRequest(invocationInfo, request, responseObserver);
    }

    public sendBidirectionalStreamingRequest(invocationInfo: GenericRequest, responseObserver: Observer<any>, requestType: any, responseType: any): Promise<StreamingInvocationClient<any>> {
        return this.genericClient.sendBidirectionalStreamingRequest(invocationInfo, responseObserver, requestType, responseType);
    }

    public sendRawBidirectionalStreamingRequest(methodReference: ProvidedMethodReference, responseObserver: Observer<ArrayBuffer>): Promise<StreamingInvocationClient<ArrayBuffer>> {
        return this.genericClient.sendRawBidirectionalStreamingRequest(methodReference, responseObserver);
    }

    public discoverService(discoveryRequest: ServiceDiscoveryRequest): Promise<ServiceDiscoveryResponse> {
        return this.genericClient.discoverService(discoveryRequest);
    }

    public discoverMethod(discoveryRequest: MethodDiscoveryRequest): Promise<MethodDiscoveryResponse> {
        return this.genericClient.discoverMethod(discoveryRequest);
    }

    public disconnect(completion?: Completion): Promise<void> {
        return this.genericClient.disconnect(completion);
    }

}

/**
 * Client invocation handler for ExampleService, to be implemented by Client
 *
 */
export abstract class ExampleServiceInvocationHandler {

    public abstract onPointToPoint(invocationContext: MethodInvocationContext, request: plexus.com.plexus.model.IRequest): Promise<plexus.com.plexus.model.IResponse>;

    public abstract onServerStreaming(invocationContext: MethodInvocationContext, request: plexus.com.plexus.model.IRequest, hostClient: StreamingInvocationClient<plexus.com.plexus.model.IResponse>): void;

    public abstract onClientToServer(invocationContext: MethodInvocationContext, hostClient: StreamingInvocationClient<plexus.com.plexus.model.IResponse>): Observer<plexus.com.plexus.model.IRequest>;

    public abstract onBidiStreaming(invocationContext: MethodInvocationContext, hostClient: StreamingInvocationClient<plexus.com.plexus.model.IResponse>): Observer<plexus.com.plexus.model.IRequest>;

}

/**
 * Internal invocation handler delegate for ExampleService
 *
 */
class ExampleServiceInvocationHandlerInternal {

    public constructor(private readonly clientHandler: ExampleServiceInvocationHandler) {}

    public onPointToPoint(invocationContext: MethodInvocationContext, request: ArrayBuffer): Promise<ArrayBuffer> {
        const responseToBinaryConverter = (from: plexus.com.plexus.model.IResponse) => Arrays.toArrayBuffer(plexus.com.plexus.model.Response.encode(from).finish());
        const requestFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Request.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Request.toObject(decoded);
        };
        return this.clientHandler
            .onPointToPoint(invocationContext, requestFromBinaryConverter(request))
            .then(response => responseToBinaryConverter(response));
    }

    public onServerStreaming(invocationContext: MethodInvocationContext, request: ArrayBuffer, hostClient: StreamingInvocationClient<ArrayBuffer>): void {
        const responseToBinaryConverter = (from: plexus.com.plexus.model.IResponse) => Arrays.toArrayBuffer(plexus.com.plexus.model.Response.encode(from).finish());
        const requestFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Request.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Request.toObject(decoded);
        };
        this.clientHandler
            .onServerStreaming(invocationContext, requestFromBinaryConverter(request), {
                next: (response) => hostClient.next(responseToBinaryConverter(response)),
                complete: hostClient.complete.bind(hostClient),
                error: hostClient.error.bind(hostClient),
                cancel: hostClient.cancel.bind(hostClient)
            });
    }

    public onClientToServer(invocationContext: MethodInvocationContext, hostClient: StreamingInvocationClient<ArrayBuffer>): Observer<ArrayBuffer> {
        const responseToBinaryConverter = (from: plexus.com.plexus.model.IResponse) => Arrays.toArrayBuffer(plexus.com.plexus.model.Response.encode(from).finish());
        const requestFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Request.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Request.toObject(decoded);
        };
        const baseObserver = this.clientHandler
            .onClientToServer(invocationContext, {
                next: (response) => hostClient.next(responseToBinaryConverter(response)),
                complete: hostClient.complete.bind(hostClient),
                error: hostClient.error.bind(hostClient),
                cancel: hostClient.cancel.bind(hostClient)
            });
        return {
            next: (value) => baseObserver.next(requestFromBinaryConverter(value)),
            complete: baseObserver.complete.bind(baseObserver),
            error: baseObserver.error.bind(baseObserver)
        };
    }

    public onBidiStreaming(invocationContext: MethodInvocationContext, hostClient: StreamingInvocationClient<ArrayBuffer>): Observer<ArrayBuffer> {
        const responseToBinaryConverter = (from: plexus.com.plexus.model.IResponse) => Arrays.toArrayBuffer(plexus.com.plexus.model.Response.encode(from).finish());
        const requestFromBinaryConverter = (from: ArrayBuffer) => {
            const decoded = plexus.com.plexus.model.Request.decode(new Uint8Array(from));
            return plexus.com.plexus.model.Request.toObject(decoded);
        };
        const baseObserver = this.clientHandler
            .onBidiStreaming(invocationContext, {
                next: (response) => hostClient.next(responseToBinaryConverter(response)),
                complete: hostClient.complete.bind(hostClient),
                error: hostClient.error.bind(hostClient),
                cancel: hostClient.cancel.bind(hostClient)
            });
        return {
            next: (value) => baseObserver.next(requestFromBinaryConverter(value)),
            complete: baseObserver.complete.bind(baseObserver),
            error: baseObserver.error.bind(baseObserver)
        };
    }
}

/**
 * Client API builder
 *
 */
export class ComponentAClientBuilder {

    private clientDetails: ClientConnectRequest = {
        applicationId: "com.plexus.components.ComponentA",
        applicationInstanceId: UniqueId.generateNew()
    };
    private transportConnectionProvider: () => Promise<TransportConnection>;

    private exampleServiceHandler: ExampleServiceInvocationHandlerInternal;

    public withClientDetails(clientId: ClientConnectRequest): ComponentAClientBuilder {
        this.clientDetails = clientId;
        return this;
    }

    public withAppInstanceId(appInstanceId: UniqueId): ComponentAClientBuilder {
        this.clientDetails.applicationInstanceId = appInstanceId;
        return this;
    }

    public withAppId(appId: string): ComponentAClientBuilder {
        this.clientDetails.applicationId = appId;
        return this;
    }

    public withExampleServiceInvocationsHandler(invocationsHandler: ExampleServiceInvocationHandler): ComponentAClientBuilder {
        this.exampleServiceHandler = new ExampleServiceInvocationHandlerInternal(invocationsHandler);
        return this;
    }

    public withTransportConnectionProvider(provider: () => Promise<TransportConnection>): ComponentAClientBuilder {
        this.transportConnectionProvider = provider;
        return this;
    }

    public connect(): Promise<ComponentAClient> {
        return new GenericClientApiBuilder()
            .withTransportConnectionProvider(this.transportConnectionProvider)
            .withClientDetails(this.clientDetails)
            .withUnaryInvocationHandler({
                serviceInfo: {
                    serviceId: "com.plexus.services.ExampleService"
                },
                handler: {
                    methodId: "PointToPoint",
                    handle: this.exampleServiceHandler.onPointToPoint.bind(this.exampleServiceHandler)
                }
            })
            .withServerStreamingInvocationHandler({
                serviceInfo: {
                    serviceId: "com.plexus.services.ExampleService"
                },
                handler: {
                    methodId: "ServerStreaming",
                    handle: this.exampleServiceHandler.onServerStreaming.bind(this.exampleServiceHandler)
                }
            })
            .withBidiStreamingInvocationHandler({
                serviceInfo: {
                    serviceId: "com.plexus.services.ExampleService"
                },
                handler: {
                    methodId: "ClientToServer",
                    handle: this.exampleServiceHandler.onClientToServer.bind(this.exampleServiceHandler)
                }
            })
            .withBidiStreamingInvocationHandler({
                serviceInfo: {
                    serviceId: "com.plexus.services.ExampleService"
                },
                handler: {
                    methodId: "BidiStreaming",
                    handle: this.exampleServiceHandler.onBidiStreaming.bind(this.exampleServiceHandler)
                }
            })
            .connect()
            .then(genericClient => new ComponentAClientImpl(
                genericClient,
                new ExampleServiceProxyImpl(genericClient)
            ));
    }
}

    '''
}