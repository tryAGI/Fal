#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Fal
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Estimate cost<br/>
        /// Estimates what requests would cost before you run them.<br/>
        /// **Request-based estimates** (`items`): send each request's endpoint and<br/>
        /// input, and get back what it would cost if it succeeds. Each endpoint's own<br/>
        /// estimate reads the input to predict what the request uses (images, seconds,<br/>
        /// characters, ...), and the same pricing that bills the request prices it.<br/>
        /// Amounts are decimal strings in USD **before percentage discounts**; your<br/>
        /// account's discount is applied at billing. An estimate is advisory, not a price<br/>
        /// lock, and estimating is never billed.<br/>
        /// - Up to 20 items per call, one request each<br/>
        /// - Items are priced on their own: one that can't be priced reports why in its<br/>
        ///   `error` and never fails the others<br/>
        /// - `status` is `partial` when something can't be predicted from the input<br/>
        ///   (see `warnings`); `rated_amount` then sums only what can<br/>
        /// - Endpoints without request-based pricing yet return `pricing_not_configured`<br/>
        ///   or `estimate_not_registered`<br/>
        /// **Deprecated:** `estimate_type` with `historical_api_price` (calls ×<br/>
        /// historical cost per call) or `unit_price` (units × one unit price). They keep<br/>
        /// working for now; use `items` instead.<br/>
        /// **Authentication:** Required. Users must provide a valid API key.<br/>
        /// See [fal.ai pricing](https://fal.ai/pricing) for more details.<br/>
        ///     <br/>
        /// **Required permissions:** none. Any authenticated caller can use this API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AnyOf<global::Fal.EstimatePricingResponseVariant1, global::Fal.EstimatePricingResponseVariant2>> EstimatePricingAsync(

            global::Fal.AnyOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2, global::Fal.EstimatePricingRequestVariant3> request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate cost<br/>
        /// Estimates what requests would cost before you run them.<br/>
        /// **Request-based estimates** (`items`): send each request's endpoint and<br/>
        /// input, and get back what it would cost if it succeeds. Each endpoint's own<br/>
        /// estimate reads the input to predict what the request uses (images, seconds,<br/>
        /// characters, ...), and the same pricing that bills the request prices it.<br/>
        /// Amounts are decimal strings in USD **before percentage discounts**; your<br/>
        /// account's discount is applied at billing. An estimate is advisory, not a price<br/>
        /// lock, and estimating is never billed.<br/>
        /// - Up to 20 items per call, one request each<br/>
        /// - Items are priced on their own: one that can't be priced reports why in its<br/>
        ///   `error` and never fails the others<br/>
        /// - `status` is `partial` when something can't be predicted from the input<br/>
        ///   (see `warnings`); `rated_amount` then sums only what can<br/>
        /// - Endpoints without request-based pricing yet return `pricing_not_configured`<br/>
        ///   or `estimate_not_registered`<br/>
        /// **Deprecated:** `estimate_type` with `historical_api_price` (calls ×<br/>
        /// historical cost per call) or `unit_price` (units × one unit price). They keep<br/>
        /// working for now; use `items` instead.<br/>
        /// **Authentication:** Required. Users must provide a valid API key.<br/>
        /// See [fal.ai pricing](https://fal.ai/pricing) for more details.<br/>
        ///     <br/>
        /// **Required permissions:** none. Any authenticated caller can use this API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.AnyOf<global::Fal.EstimatePricingResponseVariant1, global::Fal.EstimatePricingResponseVariant2>>> EstimatePricingAsResponseAsync(

            global::Fal.AnyOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2, global::Fal.EstimatePricingRequestVariant3> request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate cost<br/>
        /// Estimates what requests would cost before you run them.<br/>
        /// **Request-based estimates** (`items`): send each request's endpoint and<br/>
        /// input, and get back what it would cost if it succeeds. Each endpoint's own<br/>
        /// estimate reads the input to predict what the request uses (images, seconds,<br/>
        /// characters, ...), and the same pricing that bills the request prices it.<br/>
        /// Amounts are decimal strings in USD **before percentage discounts**; your<br/>
        /// account's discount is applied at billing. An estimate is advisory, not a price<br/>
        /// lock, and estimating is never billed.<br/>
        /// - Up to 20 items per call, one request each<br/>
        /// - Items are priced on their own: one that can't be priced reports why in its<br/>
        ///   `error` and never fails the others<br/>
        /// - `status` is `partial` when something can't be predicted from the input<br/>
        ///   (see `warnings`); `rated_amount` then sums only what can<br/>
        /// - Endpoints without request-based pricing yet return `pricing_not_configured`<br/>
        ///   or `estimate_not_registered`<br/>
        /// **Deprecated:** `estimate_type` with `historical_api_price` (calls ×<br/>
        /// historical cost per call) or `unit_price` (units × one unit price). They keep<br/>
        /// working for now; use `items` instead.<br/>
        /// **Authentication:** Required. Users must provide a valid API key.<br/>
        /// See [fal.ai pricing](https://fal.ai/pricing) for more details.<br/>
        ///     <br/>
        /// **Required permissions:** none. Any authenticated caller can use this API.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AnyOf<global::Fal.EstimatePricingResponseVariant1, global::Fal.EstimatePricingResponseVariant2>> EstimatePricingAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}