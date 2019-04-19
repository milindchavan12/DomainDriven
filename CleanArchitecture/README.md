# Clean Architecture
Clean Architecture is the Architecure designed for the inhabitant of the Architecture and not for Architect or the Machine.

## Domain-Centric Architecture
> The first concern about the architect is to make sure that the house usable, it is not to ensure that the house id made of bricks - *Uncle Bob*

Types of Domain-Centric Architecture
### 1. Alistair Cockburn's Hexagonal Architecture
It is an layered Architecture with Application (Domain) in the ceter of the Architecture.
![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/Hexagonal.png)

### 2. Onion Architecture
It is also an layered Architecture with Domain model in the ceter of the Architecture.
![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/Onion.png)

### 3. Clean Architecture
![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/Clean.png)


## CQRS Architecture
In basic CQRS Architecture, seperates the Command stack and Query stack starting at application layer for :
- Query must be optimised for reading data.
- Command must be optimised for writting data.

![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/cqrs.png)

There are 3 types of CQRS architectures:
- Single Database CQRS
- Two database CQRS
- Event Sourcing CQRS

### Synchronisation of data
![alt text](https://github.com/milindchavan12/DomainDriven/blob/master/assets/CQRSTwoDatabase.png)
----

## Streaming Architecure
> The architecture should stream the intend of the system - Uncle Bob

The way we should use the *functional cohesion* to organise our folder, classes in the application:
- Presentation layer by agreegate root entity of each screen or webpage.
- Application Layer by agreegate root entity of use case.
- Domain Layer by agreegate root og each domain entity.
- Persistence Layer by agreegate root entity of database table.
- Infrastructural Layer by System Components and 3rd Party depenecies.

