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

using Jil;

namespace Quantler.DataFeeds.HitBtcPublic.Models.v2
{
    /// <summary>
    ///
    /// </summary>
    public class OrderBookParamsModel
    {
        #region Public Properties

        [JilDirective("ask")]
        public QuoteModel[] Ask { get; set; }

        [JilDirective("bid")]
        public QuoteModel[] Bid { get; set; }

        [JilDirective("sequence")]
        public long Sequence { get; set; }

        [JilDirective("symbol")]
        public string Symbol { get; set; }

        #endregion Public Properties
    }
}