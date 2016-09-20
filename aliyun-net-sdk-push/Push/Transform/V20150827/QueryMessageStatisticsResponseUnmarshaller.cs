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
using Aliyun.Acs.Push.Model.V20150827;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20150827
{
    public class QueryMessageStatisticsResponseUnmarshaller
    {
        public static QueryMessageStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryMessageStatisticsResponse queryMessageStatisticsResponse = new QueryMessageStatisticsResponse();

			queryMessageStatisticsResponse.HttpResponse = context.HttpResponse;
			queryMessageStatisticsResponse.RequestId = context.StringValue("QueryMessageStatistics.RequestId");

			List<QueryMessageStatisticsResponse.PushMessageStatisticsInfo> pushMessageStatisticsInfos = new List<QueryMessageStatisticsResponse.PushMessageStatisticsInfo>();
			for (int i = 0; i < context.Length("QueryMessageStatistics.PushMessageStatisticsInfos.Length"); i++) {
				QueryMessageStatisticsResponse.PushMessageStatisticsInfo pushMessageStatisticsInfo = new QueryMessageStatisticsResponse.PushMessageStatisticsInfo();
				pushMessageStatisticsInfo.Date = context.StringValue("QueryMessageStatistics.PushMessageStatisticsInfos["+ i +"].Date");
				pushMessageStatisticsInfo.Sent = context.IntegerValue("QueryMessageStatistics.PushMessageStatisticsInfos["+ i +"].Sent");
				pushMessageStatisticsInfo.Received = context.IntegerValue("QueryMessageStatistics.PushMessageStatisticsInfos["+ i +"].Received");

				pushMessageStatisticsInfos.Add(pushMessageStatisticsInfo);
			}
			queryMessageStatisticsResponse.PushMessageStatisticsInfos = pushMessageStatisticsInfos;
        
			return queryMessageStatisticsResponse;
        }
    }
}