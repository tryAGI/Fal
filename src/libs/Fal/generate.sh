#!/usr/bin/env bash
set -euo pipefail

readonly openapi_url="https://api.fal.ai/v1/openapi.json"

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

# Fix auth scheme: Fal uses 'Authorization: Key <api_key>' but the spec defines it as
# apiKey-in-header which AutoSDK can't generate a constructor for. Use HTTP bearer scheme
# (generates proper constructor) and override to Key scheme in FalClient.Authorization.cs.
jq '.components.securitySchemes = {
  "apiKey": {"type": "http", "scheme": "bearer"}
} | .security = [{"apiKey": []}]' openapi.json > openapi.tmp.json && mv openapi.tmp.json openapi.json

autosdk generate openapi.json \
  --namespace Fal \
  --clientClassName FalClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations
