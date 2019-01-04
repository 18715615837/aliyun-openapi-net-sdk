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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeMetaListResponseUnmarshaller
    {
        public static DescribeMetaListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMetaListResponse describeMetaListResponse = new DescribeMetaListResponse();

			describeMetaListResponse.HttpResponse = context.HttpResponse;
			describeMetaListResponse.RequestId = context.StringValue("DescribeMetaList.RequestId");
			describeMetaListResponse.DBInstanceName = context.StringValue("DescribeMetaList.DBInstanceName");
			describeMetaListResponse.PageNumber = context.IntegerValue("DescribeMetaList.PageNumber");
			describeMetaListResponse.PageRecordCount = context.IntegerValue("DescribeMetaList.PageRecordCount");
			describeMetaListResponse.TotalRecordCount = context.IntegerValue("DescribeMetaList.TotalRecordCount");
			describeMetaListResponse.TotalPageCount = context.IntegerValue("DescribeMetaList.TotalPageCount");

			List<DescribeMetaListResponse.DescribeMetaList_Meta> describeMetaListResponse_items = new List<DescribeMetaListResponse.DescribeMetaList_Meta>();
			for (int i = 0; i < context.Length("DescribeMetaList.Items.Length"); i++) {
				DescribeMetaListResponse.DescribeMetaList_Meta meta = new DescribeMetaListResponse.DescribeMetaList_Meta();
				meta.Database = context.StringValue("DescribeMetaList.Items["+ i +"].Database");
				meta.Tables = context.StringValue("DescribeMetaList.Items["+ i +"].Tables");
				meta.Size = context.StringValue("DescribeMetaList.Items["+ i +"].Size");

				describeMetaListResponse_items.Add(meta);
			}
			describeMetaListResponse.Items = describeMetaListResponse_items;
        
			return describeMetaListResponse;
        }
    }
}