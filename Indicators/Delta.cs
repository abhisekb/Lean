/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
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

using System;
using MathNet.Numerics.Distributions;
using Python.Runtime;
using QuantConnect.Data;

namespace QuantConnect.Indicators
{
    /// <summary>
    /// Option Delta indicator that calculate the delta of an option
    /// </summary>
    /// <remarks>sensitivity of option price relative to $1 of underlying change</remarks>
    public class Delta : OptionGreeksIndicatorBase
    {
        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="name">The name of this indicator</param>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYieldModel">Dividend yield model</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(string name, Symbol option, IRiskFreeInterestRateModel riskFreeRateModel, IDividendYieldModel dividendYieldModel,
                OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : base(name, option, riskFreeRateModel, dividendYieldModel, optionModel: optionModel, ivModel: ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYieldModel">Dividend yield model</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(Symbol option, IRiskFreeInterestRateModel riskFreeRateModel, IDividendYieldModel dividendYieldModel,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : this($"Delta({optionModel})", option, riskFreeRateModel, dividendYieldModel, optionModel, ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="name">The name of this indicator</param>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYieldModel">Dividend yield model</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(string name, Symbol option, PyObject riskFreeRateModel, PyObject dividendYieldModel,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : base(name, option, riskFreeRateModel, dividendYieldModel, optionModel: optionModel, ivModel: ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYieldModel">Dividend yield model</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(Symbol option, PyObject riskFreeRateModel, PyObject dividendYieldModel,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : this($"Delta({optionModel})", option, riskFreeRateModel, dividendYieldModel, optionModel, ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="name">The name of this indicator</param>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYield">Dividend yield, as a constant</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(string name, Symbol option, IRiskFreeInterestRateModel riskFreeRateModel, decimal dividendYield = 0.0m,
                OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : base(name, option, riskFreeRateModel, dividendYield, optionModel: optionModel, ivModel: ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYield">Dividend yield, as a constant</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(Symbol option, IRiskFreeInterestRateModel riskFreeRateModel, decimal dividendYield = 0.0m,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : this($"Delta({optionModel})", option, riskFreeRateModel, dividendYield, optionModel, ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="name">The name of this indicator</param>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYield">Dividend yield, as a constant</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(string name, Symbol option, PyObject riskFreeRateModel, decimal dividendYield = 0.0m,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : base(name, option, riskFreeRateModel, dividendYield, optionModel: optionModel, ivModel: ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRateModel">Risk-free rate model</param>
        /// <param name="dividendYield">Dividend yield, as a constant</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(Symbol option, PyObject riskFreeRateModel, decimal dividendYield = 0.0m,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : this($"Delta({optionModel})", option, riskFreeRateModel, dividendYield, optionModel, ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="option">The option to be tracked</param>am>
        /// <param name="riskFreeRate">Risk-free rate, as a constant</param>
        /// <param name="dividendYield">Dividend yield, as a constant</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(string name, Symbol option, decimal riskFreeRate = 0.05m, decimal dividendYield = 0.0m, 
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : base(name, option, riskFreeRate, dividendYield, optionModel: optionModel, ivModel: ivModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Delta class
        /// </summary>
        /// <param name="option">The option to be tracked</param>
        /// <param name="riskFreeRate">Risk-free rate, as a constant</param>
        /// <param name="dividendYield">Dividend yield, as a constant</param>
        /// <param name="optionModel">The option pricing model used to estimate Delta</param>
        /// <param name="ivModel">The option pricing model used to estimate IV</param>
        public Delta(Symbol option, decimal riskFreeRate = 0.05m, decimal dividendYield = 0.0m,
            OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes, OptionPricingModelType? ivModel = null)
            : this($"Delta({optionModel})", option, riskFreeRate, dividendYield, optionModel, ivModel)
        {
        }

        // Calculate the theoretical option price
        private decimal TheoreticalDelta(decimal timeToExpiration, OptionPricingModelType optionModel = OptionPricingModelType.BlackScholes)
        {
            var math = OptionGreekIndicatorsHelper.DecimalMath;
                
            switch (optionModel)
            {
                case OptionPricingModelType.BinomialCoxRossRubinstein:
                    var upFactor = math(Math.Exp, ImpliedVolatility * math(Math.Sqrt, timeToExpiration / OptionGreekIndicatorsHelper.Steps));
                    if (upFactor == 1)
                    {
                        // provide a small step to estimate delta
                        upFactor = 1.00001m;
                    }

                    var sU = UnderlyingPrice * upFactor;
                    var sD = UnderlyingPrice / upFactor;

                    var fU = OptionGreekIndicatorsHelper.CRRTheoreticalPrice(
                        ImpliedVolatility, sU, Strike, timeToExpiration, RiskFreeRate, DividendYield, Right);
                    var fD = OptionGreekIndicatorsHelper.CRRTheoreticalPrice(
                        ImpliedVolatility, sD, Strike, timeToExpiration, RiskFreeRate, DividendYield, Right);

                    return (fU - fD) / (sU - sD);

                case OptionPricingModelType.BlackScholes:
                default:
                    var norm = new Normal();
                    var d1 = OptionGreekIndicatorsHelper.CalculateD1(UnderlyingPrice, Strike, timeToExpiration, RiskFreeRate, DividendYield, ImpliedVolatility);

                    decimal wholeShareDelta;
                    if (Right == OptionRight.Call)
                    {
                        wholeShareDelta = math(norm.CumulativeDistribution, d1);
                    }
                    else
                    {
                        wholeShareDelta = -math(norm.CumulativeDistribution, -d1);
                    }

                    return wholeShareDelta * math(Math.Exp, -DividendYield * timeToExpiration);
            }
        }

        // Calculate the Delta of the option
        protected override decimal CalculateGreek(DateTime time)
        {
            var timeToExpiration = Convert.ToDecimal((Expiry - time).TotalDays) / 365m;

            return TheoreticalDelta(timeToExpiration, _optionModel);
        }
    }
}
