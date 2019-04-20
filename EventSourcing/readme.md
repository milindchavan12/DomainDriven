# Event Sourcing

Event Sourcing states that all changes made ot the application state during entire lifetime of the application are stored as sequence of events.

## Fact of Event Sourcing.
- Event is something that is happened in the past.
- Events are expressions of Ubiquitous language.
- Have a persistent store of events.
- Append only, no-delete.
- Replay of event from beginning or known point.

## Event Store : Type of Subscriptions
- Volatile
- Catch-Up
- Persistent
