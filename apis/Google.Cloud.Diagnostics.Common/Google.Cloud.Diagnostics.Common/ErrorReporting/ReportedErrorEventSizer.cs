﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.ErrorReporting.V1Beta1;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// An <see cref="ISizer{T}"/> for <see cref="ReportedErrorEvent"/>s.
    /// </summary>
    internal sealed class ReportedErrorEventSizer : ISizer<ReportedErrorEvent>
    {
        /// <summary>The single log entry sizer instance.</summary>
        internal static readonly ReportedErrorEventSizer Instance = new ReportedErrorEventSizer();

        private ReportedErrorEventSizer() { }

        /// <inheritdoc />
        public int GetSize(ReportedErrorEvent item) => item.CalculateSize();
    }
}