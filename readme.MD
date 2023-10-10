# Concept

## Abstract classes and method in one controller file

Im not sure if its possible to generate multiple files based on some "context"
but one file should be enough. There is already a splitting for some context but one file can probably be pretty large

## Implement abstract class and methods

The above abstract classes and methods can be implemented in the same split as the abstract generation and should probably call another layer like via Mediatr to abstract API and Application layer. Also CQRS is probably a good pick in our distributed architecture model.

## openapi-generator tests
- It does not support some of the schemas defined in our yaml
- It cant create some models and does not complete the generation

## swagger-codegen
- Similar reasons as openapi-generator

## Stub that is downloaded in order to test how they did generation
- build.sh does not work, not sure when the generation is triggered here