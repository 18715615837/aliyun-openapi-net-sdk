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
using Aliyun.Acs.aliyuncvc.Model.V20190919;

namespace Aliyun.Acs.aliyuncvc.Transform.V20190919
{
    public class CreateUserEvaluationsResponseUnmarshaller
    {
        public static CreateUserEvaluationsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateUserEvaluationsResponse createUserEvaluationsResponse = new CreateUserEvaluationsResponse();

			createUserEvaluationsResponse.HttpResponse = context.HttpResponse;
			createUserEvaluationsResponse.RequestId = context.StringValue("CreateUserEvaluations.RequestId");
			createUserEvaluationsResponse.Success = context.BooleanValue("CreateUserEvaluations.Success");
			createUserEvaluationsResponse.ErrorCode = context.StringValue("CreateUserEvaluations.ErrorCode");
			createUserEvaluationsResponse.Message = context.StringValue("CreateUserEvaluations.Message");
        
			return createUserEvaluationsResponse;
        }
    }
}
