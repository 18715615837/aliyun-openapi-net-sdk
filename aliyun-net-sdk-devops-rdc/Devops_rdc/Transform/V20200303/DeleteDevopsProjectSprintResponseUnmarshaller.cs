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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class DeleteDevopsProjectSprintResponseUnmarshaller
    {
        public static DeleteDevopsProjectSprintResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteDevopsProjectSprintResponse deleteDevopsProjectSprintResponse = new DeleteDevopsProjectSprintResponse();

			deleteDevopsProjectSprintResponse.HttpResponse = _ctx.HttpResponse;
			deleteDevopsProjectSprintResponse.Successful = _ctx.BooleanValue("DeleteDevopsProjectSprint.Successful");
			deleteDevopsProjectSprintResponse.ErrorCode = _ctx.StringValue("DeleteDevopsProjectSprint.ErrorCode");
			deleteDevopsProjectSprintResponse.ErrorMsg = _ctx.StringValue("DeleteDevopsProjectSprint.ErrorMsg");
			deleteDevopsProjectSprintResponse.RequestId = _ctx.StringValue("DeleteDevopsProjectSprint.RequestId");
			deleteDevopsProjectSprintResponse._Object = _ctx.BooleanValue("DeleteDevopsProjectSprint.Object");
        
			return deleteDevopsProjectSprintResponse;
        }
    }
}
