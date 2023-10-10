# API Generation

### Dummy spec client via service call

curl -X POST \
  https://generator3.swagger.io/api/generate \
  -H 'content-type: application/json' \
  -d '{
  "specURL" : "https://raw.githubusercontent.com/OAI/OpenAPI-Specification/master/examples/v3.0/petstore.yaml",
  "lang" : "java",
  "type" : "CLIENT",
  "codegenVersion" : "V3"
}' --output output/api.zip

### Dummy spec via cli

java -jar modules/swagger-codegen-cli/swagger-codegen-cli-3.0.3.jar generate \
  -i https://raw.githubusercontent.com/OAI/OpenAPI-Specification/master/examples/v3.0/petstore.yaml \
  -l aspnetcore \
  -o output/aspnet

### Real spec via cli (does not work)

git clone https://github.com/swagger-api/swagger-codegen

cd swagger-codegen

Set generator jar file (can be downloaded from https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.3/swagger-codegen-cli-3.0.3.jar)

java -jar modules/swagger-codegen-cli/swagger-codegen-cli-3.0.3.jar generate \
  -i https://app.swaggerhub.com/apiproxy/registry/Plattform_i40/AssetAdministrationShellRepositoryServiceSpecification/V3.0.1_SSP-001 \
  -l aspnetcore \
  -o output/aspnet