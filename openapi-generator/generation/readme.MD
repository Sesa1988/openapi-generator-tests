## Installation

## CLI
npm install @openapitools/openapi-generator-cli -g

## JDE
https://www.oracle.com/de/java/technologies/downloads/#jdk21-mac

## API generation
#### It does not work because some definitions are not supported currently

npx @openapitools/openapi-generator-cli generate -i spec.yaml -g aspnetcore -o /api/ --additional-properties=aspnetCoreVersion=6.0,buildTarget=library,classModifier=abstract,generateBody=false,isLibrary=true,modelClassModifier=partial,operationModifier=abstract

## API generation with test data (does also not work for different reasons)

npx @openapitools/openapi-generator-cli generate -i dummy.yaml -g aspnetcore -o /api/ --additional-properties=aspnetCoreVersion=6.0,buildTarget=library,classModifier=abstract,generateBody=false,isLibrary=true,modelClassModifier=partial,operationModifier=abstract