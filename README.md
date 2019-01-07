# Domain Driven Design
### Clean Architecture
Clean Architecture is the Architecure designed for the inhabitant of the Architecture and not for Architect or the Machine.

## Domain-Centric Architecture
> The first concern about the architect is to make sure that the house usable, it is not to ensure that the house id made of bricks - *Uncle Bob*

Types of Domain-Centric Architecture
### 1. Alistair Cockburn's Hexagonal Architecture
It is an layered Architecture with Application (Domain) in the ceter of the Architecture.
![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/Hexagonal.png)

### 2. Onion Architecture
It is an layered Architecture with Application (Domain) in the ceter of the Architecture.
![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/Onion.png)

Domain Models, CQRS, and Event Sourcing

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
- Integration od external components.

### Context Map
Context Map is the diagram that provides comprehensive view of the system being designed.

### Event Storming:
Event Storming is emploring a business domain starting from observable domain events. It works like:
- Identifying relavant domain events.
- Find what cause the event
- Look at the model surface as a timeline.

