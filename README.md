# Day 1: Modern .NET DI Patterns

## 🎯 Goal
Migrate from legacy "new is glue" instantiation to Modern .NET 10 Dependency Injection.

## 📝 The Challenge
**Scenario:** "The Logger Swap"
1. **Define Contract:** Create an `ILoggerService` interface.
2. **Implement:** Create `ConsoleLogger` (writes to screen) and `FileLogger` (writes to disk).
3. **Compose:** Use `Host.CreateApplicationBuilder` to register services.
4. **Execute:** Inject the logger into an `OrderProcessor` service to simulate business logic.
5. **Verify:** Demonstrate that switching from Console to File logging requires changing *only one line* in `Program.cs`.

## 🧠 Key Concepts Demonstrated
- **Inversion of Control (IoC):** High-level modules (OrderProcessor) depend on abstractions (ILogger), not details.
- **Service Lifetimes:**
  - **Transient:** Created every time.
  - **Singleton:** Created once, lives forever.
