/**
 * Copyright 2017-2018 Plexus Interop Deutsche Bank AG
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
/*
 * generated by Xtext 2.12.0
 */
package com.db.plexus.interop.dsl

import com.db.plexus.interop.dsl.protobuf.ProtoLangConfig
import com.db.plexus.interop.dsl.protobuf.ProtoLangStandaloneSetup
import com.db.plexus.interop.dsl.protobuf.ProtobufPackage
import com.google.inject.Injector
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EPackage
import static com.db.plexus.interop.dsl.GlobalLangConfigHolder.*;
/**
 * Initialization support for running Xtext languages without Equinox extension registry.
 */
class InteropLangStandaloneSetup extends InteropLangStandaloneSetupGenerated {
	
	private Injector protoLangInjector
	private Injector interopLangInjector

	def Injector getInteropLangInjector() { 
		return interopLangInjector	
	}
	
	def Injector getProtoLangInjector() {
		return protoLangInjector
	}
	
	def void addBaseURI(URI baseURI) {
		protoLangConfig.addBaseURI(baseURI)
		interopLangConfig.addBaseURI(baseURI)
	}
	
	def void removeBaseURI(URI baseURI) {
		protoLangConfig.removeBaseURI(baseURI)
		interopLangConfig.removeBaseURI(baseURI)		
	}
							
	override createInjectorAndDoEMFRegistration() {
		protoLangInjector = new ProtoLangStandaloneSetup().createInjectorAndDoEMFRegistration()
		protoLangConfig = protoLangInjector.getInstance(typeof(ProtoLangConfig))
		interopLangInjector = createInjector();
		interopLangConfig = interopLangInjector.getInstance(typeof(ProtoLangConfig))
		for (uri: protoLangConfig.baseURIs) {
			interopLangConfig.addBaseURI(uri)
		}		
		register(interopLangInjector);
		return interopLangInjector;
	}
		
	override register(Injector injector) {
		if (!EPackage.Registry.INSTANCE.containsKey(ProtobufPackage.eNS_URI)) {
			EPackage.Registry.INSTANCE.put(ProtobufPackage.eNS_URI, ProtobufPackage.eINSTANCE);
		}		
		if (!EPackage.Registry.INSTANCE.containsKey(DslPackage.eNS_URI)) {
			EPackage.Registry.INSTANCE.put(DslPackage.eNS_URI, DslPackage.eINSTANCE);
		}
		super.register(injector)
	}
}