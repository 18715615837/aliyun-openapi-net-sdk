/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class CreateOrderResponseUnmarshaller
    {
        public static CreateOrderResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOrderResponse createOrderResponse = new CreateOrderResponse();

			createOrderResponse.HttpResponse = context.HttpResponse;
			createOrderResponse.RequestId = context.StringValue("CreateOrder.RequestId");
			createOrderResponse.Success = context.BooleanValue("CreateOrder.Success");
			createOrderResponse.ErrorMessage = context.StringValue("CreateOrder.ErrorMessage");
			createOrderResponse.ErrorCode = context.StringValue("CreateOrder.ErrorCode");

			List<string> createOrderResponse_createOrderResult = new List<string>();
			for (int i = 0; i < context.Length("CreateOrder.CreateOrderResult.Length"); i++) {
				createOrderResponse_createOrderResult.Add(context.StringValue("CreateOrder.CreateOrderResult["+ i +"]"));
			}
			createOrderResponse.CreateOrderResult = createOrderResponse_createOrderResult;
        
			return createOrderResponse;
        }
    }
}
