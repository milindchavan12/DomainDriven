# Domain Driven Design

## Important Topics:
- [Clean Architecture](https://github.com/milindchavan12/DomainDriven/tree/master/CleanArchitecture)

## Ubiquitous Language
Ubiquitous languages aims to build a common and business oritented language. 
- Shared by all parties between the project 

    Primary goals : avoiding Common misunderstandings and bad assumptions.
- Vocabulary of domain specific terms
   
    Nouns, verbs, adjectives, idimatic expressions and even adverbs

![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/Ubiquitous.png)

## Bounded Context:
Bounded context is the Delimited space where each element in the Ubiquitous language is well-defined meaning.
Main adavantages of Bounded Context :
- Remove ambiguity and duplications
- Simply design of Software modules.
- Integration of external components.

### Context Map
Context Map is the diagram that provides comprehensive view of the system being designed.

### Event Storming:
Event Storming is exploring a business domain starting from observable domain events. It works like:
- Identifying relavant domain events.
- Find what cause the event
- Look at the model surface as a timeline.

## Domain Model Supporting Architecture:

![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/DomainModelArchitecture.png)

### Value Objects
The Value Object has very specific characteristics:
- It is used to Measure, quantifies, or describes a thing in the domain.
- Identiity is basded on composition of values.
- Immutable.


### Domain Services:
- Implement the Domain logic tha belongs to multiple entities.
- Coordinate the activity of aggregates and repositories with the purpose of implementing the business action.

Action in **Domain Services** come from *Requirments* and approved by *Domain Experts*.

### Aggregates 
Aggregate consists of one or more Entities and ValueObjects which change together. Aggregate must have **Aggregate Root**, which is parent object of all members of Aggregate.
Data changes to Aggregate must follow A.C.I.D rule, which is : Automic, Consistant, Isolated and Durable.

In the Domain Driven Design book Eric Evans states, "An aggregate is a cluster of associated objects that we treat as a unit for the purpose of data changes."
