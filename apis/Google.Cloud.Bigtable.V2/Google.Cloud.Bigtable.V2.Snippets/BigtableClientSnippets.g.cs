// Copyright 2017, Google LLC All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.V2;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedBigtableClientSnippets
    {
        /// <summary>Snippet for ReadRows</summary>
        public async Task ReadRows()
        {
            // Snippet: ReadRows(ReadRowsRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument
            ReadRowsRequest request = new ReadRowsRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request, returning a streaming response
            BigtableClient.ReadRowsStream streamingResponse = bigtableClient.ReadRows(request);

            // Read streaming responses from server until complete
            IAsyncEnumerator<ReadRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                ReadRowsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for SampleRowKeys</summary>
        public async Task SampleRowKeys()
        {
            // Snippet: SampleRowKeys(SampleRowKeysRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument
            SampleRowKeysRequest request = new SampleRowKeysRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request, returning a streaming response
            BigtableClient.SampleRowKeysStream streamingResponse = bigtableClient.SampleRowKeys(request);

            // Read streaming responses from server until complete
            IAsyncEnumerator<SampleRowKeysResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                SampleRowKeysResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowAsync()
        {
            // Snippet: MutateRowAsync(TableName,ByteString,IEnumerable<Mutation>,CallSettings)
            // Additional: MutateRowAsync(TableName,ByteString,IEnumerable<Mutation>,CancellationToken)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            MutateRowResponse response = await bigtableClient.MutateRowAsync(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow()
        {
            // Snippet: MutateRow(TableName,ByteString,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(tableName, rowKey, mutations);
            // End snippet
        }

        /// <summary>Snippet for MutateRowAsync</summary>
        public async Task MutateRowAsync_RequestObject()
        {
            // Snippet: MutateRowAsync(MutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8(""),
                Mutations = { },
            };
            // Make the request
            MutateRowResponse response = await bigtableClient.MutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRow</summary>
        public void MutateRow_RequestObject()
        {
            // Snippet: MutateRow(MutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8(""),
                Mutations = { },
            };
            // Make the request
            MutateRowResponse response = bigtableClient.MutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for MutateRows</summary>
        public async Task MutateRows()
        {
            // Snippet: MutateRows(MutateRowsRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument
            MutateRowsRequest request = new MutateRowsRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Entries = { },
            };
            // Make the request, returning a streaming response
            BigtableClient.MutateRowsStream streamingResponse = bigtableClient.MutateRows(request);

            // Read streaming responses from server until complete
            IAsyncEnumerator<MutateRowsResponse> responseStream = streamingResponse.ResponseStream;
            while (await responseStream.MoveNext())
            {
                MutateRowsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowAsync()
        {
            // Snippet: CheckAndMutateRowAsync(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Additional: CheckAndMutateRowAsync(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CancellationToken)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("");
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            // Make the request
            CheckAndMutateRowResponse response = await bigtableClient.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow()
        {
            // Snippet: CheckAndMutateRow(TableName,ByteString,RowFilter,IEnumerable<Mutation>,IEnumerable<Mutation>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("");
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRowAsync</summary>
        public async Task CheckAndMutateRowAsync_RequestObject()
        {
            // Snippet: CheckAndMutateRowAsync(CheckAndMutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            CheckAndMutateRowResponse response = await bigtableClient.CheckAndMutateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckAndMutateRow</summary>
        public void CheckAndMutateRow_RequestObject()
        {
            // Snippet: CheckAndMutateRow(CheckAndMutateRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8(""),
            };
            // Make the request
            CheckAndMutateRowResponse response = bigtableClient.CheckAndMutateRow(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowAsync()
        {
            // Snippet: ReadModifyWriteRowAsync(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Additional: ReadModifyWriteRowAsync(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,CancellationToken)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableClient.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow()
        {
            // Snippet: ReadModifyWriteRow(TableName,ByteString,IEnumerable<ReadModifyWriteRule>,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(tableName, rowKey, rules);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRowAsync</summary>
        public async Task ReadModifyWriteRowAsync_RequestObject()
        {
            // Snippet: ReadModifyWriteRowAsync(ReadModifyWriteRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = await BigtableClient.CreateAsync();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8(""),
                Rules = { },
            };
            // Make the request
            ReadModifyWriteRowResponse response = await bigtableClient.ReadModifyWriteRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadModifyWriteRow</summary>
        public void ReadModifyWriteRow_RequestObject()
        {
            // Snippet: ReadModifyWriteRow(ReadModifyWriteRowRequest,CallSettings)
            // Create client
            BigtableClient bigtableClient = BigtableClient.Create();
            // Initialize request argument(s)
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8(""),
                Rules = { },
            };
            // Make the request
            ReadModifyWriteRowResponse response = bigtableClient.ReadModifyWriteRow(request);
            // End snippet
        }

    }
}
