﻿#region License Header

/*
* QUANTLER.COM - Quant Fund Development Platform
* Quantler Core Trading Engine. Copyright 2018 Quantler B.V.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

#endregion License Header

using Quantler.Securities;
using System.Composition;

namespace Quantler.Data.Market.Filter
{
    /// <summary>
    /// Basic checks (default implementation)
    /// </summary>
    [Export(typeof(DataFilter))]
    public class DefaultFilter : DataFilter
    {
        #region Public Methods

        /// <summary>
        /// Lowest amount of checks for data
        /// </summary>
        /// <param name="security"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Accept(Security security, DataPoint data) =>
            //We accept all data (if it is valid off course) and the markets are opened
            security.Exchange.IsOpen && (data.DataType != DataType.Tick || (data is Tick tick && tick.IsValid));


        #endregion Public Methods
    }
}