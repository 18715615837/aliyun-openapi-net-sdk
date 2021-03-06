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
    public class ListOrdersResponseUnmarshaller
    {
        public static ListOrdersResponse Unmarshall(UnmarshallerContext context)
        {
			ListOrdersResponse listOrdersResponse = new ListOrdersResponse();

			listOrdersResponse.HttpResponse = context.HttpResponse;
			listOrdersResponse.RequestId = context.StringValue("ListOrders.RequestId");
			listOrdersResponse.Success = context.BooleanValue("ListOrders.Success");
			listOrdersResponse.ErrorMessage = context.StringValue("ListOrders.ErrorMessage");
			listOrdersResponse.ErrorCode = context.StringValue("ListOrders.ErrorCode");
			listOrdersResponse.TotalCount = context.LongValue("ListOrders.TotalCount");

			List<ListOrdersResponse.ListOrders_Order> listOrdersResponse_orders = new List<ListOrdersResponse.ListOrders_Order>();
			for (int i = 0; i < context.Length("ListOrders.Orders.Length"); i++) {
				ListOrdersResponse.ListOrders_Order order = new ListOrdersResponse.ListOrders_Order();
				order.OrderId = context.LongValue("ListOrders.Orders["+ i +"].OrderId");
				order.Comment = context.StringValue("ListOrders.Orders["+ i +"].Comment");
				order.Committer = context.StringValue("ListOrders.Orders["+ i +"].Committer");
				order.CommitterId = context.LongValue("ListOrders.Orders["+ i +"].CommitterId");
				order.CreateTime = context.StringValue("ListOrders.Orders["+ i +"].CreateTime");
				order.LastModifyTime = context.StringValue("ListOrders.Orders["+ i +"].LastModifyTime");
				order.PluginType = context.StringValue("ListOrders.Orders["+ i +"].PluginType");
				order.StatusCode = context.StringValue("ListOrders.Orders["+ i +"].StatusCode");
				order.StatusDesc = context.StringValue("ListOrders.Orders["+ i +"].StatusDesc");

				listOrdersResponse_orders.Add(order);
			}
			listOrdersResponse.Orders = listOrdersResponse_orders;
        
			return listOrdersResponse;
        }
    }
}
