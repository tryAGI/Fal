#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.fal.ai/v1/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://api.fal.ai/v1/openapi.json -o openapi.json

# Auth: --security-scheme overrides the spec's apiKey/adminApiKey auth with HTTP bearer.
# Fal uses 'Authorization: Key <api_key>' — FalClient.Authorization.cs rewrites Bearer → Key.
autosdk generate openapi.json \
  --namespace Fal \
  --clientClassName FalClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
