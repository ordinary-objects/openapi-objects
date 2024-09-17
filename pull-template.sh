#!/bin/bash

# Function to generate a random directory name
function generate_random_dirname() {
  echo "$(date +%s | sha256sum | base64 | head -c 10)"
}

# Clone the GitHub repository into a temporary directory
TEMP_DIR=$(generate_random_dirname)
git clone https://github.com/OpenAPITools/openapi-generator "$TEMP_DIR"

# Copy the desired path to the current directory
SRC_PATH="$TEMP_DIR/modules/openapi-generator/src/main/resources/csharp"
cp -r "$SRC_PATH" ./csharp

# Clean up - remove the temporary directory
rm -rf "$TEMP_DIR"

mv csharp template
