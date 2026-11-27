
#nullable enable

namespace Fal
{
    /// <summary>
    /// Machine-readable reason.
    /// </summary>
    public enum EstimatePricingResponseVariant1ItemErrorType
    {
        /// <summary>
        ///
        /// </summary>
        EndpointNotFound,
        /// <summary>
        ///
        /// </summary>
        EstimateNotRegistered,
        /// <summary>
        ///
        /// </summary>
        EstimatorError,
        /// <summary>
        ///
        /// </summary>
        InvalidInput,
        /// <summary>
        ///
        /// </summary>
        PricingNotConfigured,
        /// <summary>
        ///
        /// </summary>
        PricingUnloadable,
        /// <summary>
        ///
        /// </summary>
        QuantityUnavailable,
        /// <summary>
        ///
        /// </summary>
        SchemaMismatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseVariant1ItemErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1ItemErrorType value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1ItemErrorType.EndpointNotFound => "endpoint_not_found",
                EstimatePricingResponseVariant1ItemErrorType.EstimateNotRegistered => "estimate_not_registered",
                EstimatePricingResponseVariant1ItemErrorType.EstimatorError => "estimator_error",
                EstimatePricingResponseVariant1ItemErrorType.InvalidInput => "invalid_input",
                EstimatePricingResponseVariant1ItemErrorType.PricingNotConfigured => "pricing_not_configured",
                EstimatePricingResponseVariant1ItemErrorType.PricingUnloadable => "pricing_unloadable",
                EstimatePricingResponseVariant1ItemErrorType.QuantityUnavailable => "quantity_unavailable",
                EstimatePricingResponseVariant1ItemErrorType.SchemaMismatch => "schema_mismatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1ItemErrorType? ToEnum(string value)
        {
            return value switch
            {
                "endpoint_not_found" => EstimatePricingResponseVariant1ItemErrorType.EndpointNotFound,
                "estimate_not_registered" => EstimatePricingResponseVariant1ItemErrorType.EstimateNotRegistered,
                "estimator_error" => EstimatePricingResponseVariant1ItemErrorType.EstimatorError,
                "invalid_input" => EstimatePricingResponseVariant1ItemErrorType.InvalidInput,
                "pricing_not_configured" => EstimatePricingResponseVariant1ItemErrorType.PricingNotConfigured,
                "pricing_unloadable" => EstimatePricingResponseVariant1ItemErrorType.PricingUnloadable,
                "quantity_unavailable" => EstimatePricingResponseVariant1ItemErrorType.QuantityUnavailable,
                "schema_mismatch" => EstimatePricingResponseVariant1ItemErrorType.SchemaMismatch,
                _ => null,
            };
        }
    }
}