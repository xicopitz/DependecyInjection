[![.NET](https://github.com/xicopitz/DependecyInjection/actions/workflows/dotnet.yml/badge.svg)](https://github.com/xicopitz/DependecyInjection/actions/workflows/dotnet.yml)

# Dependecy Injection Example

**Project structure**
 - 01.FrontEnd
	 -  UI + API
 - 02.Business
	 - Bridge to Services - nice to call multiple services and return a single object.
 - 04.Data
	 - Service / Provider
	 - Service / Provider

# DI (Dependecy Injection)

 - Everything is defined on the entrypoint project **(Quid.DP.WebApi)**.
 - Can be reusable where needed
 - Types of DI:
	 - **Singleton:** It creates the instance for the first time and reuses the same object in the all calls.
	 - **Scoped:** It is equivalent to a singleton in the current scope. For example, in MVC it creates one instance for each HTTP request, but it uses the same instance in the other calls within the same web request.
	 - **Transient:** Lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.

## UML diagram

Workflow:

[![](https://mermaid.ink/img/pako:eNpljsEKwjAMhl8l5KToXqDIwDEPnhSmJ7tDXDMtbq20nVPUd7fixIM5hZ_v-5M7VlYxCqwb21dHcgFgk0sDcea77RImMF8vS5glSQrZKOu8Nuz9-ENk7zxJH3wVkFOgPXl-QL6rSdSUqCGBgt1FVwwrw-W_mDV2D0Wwjg5RXgxyrZufuOltiVNs2bWkVfz2_q6RGI7cskQRV0XuJFGaZ-S6czzNC6VjKcayxvMUqQu2uJkKRXAdf6Fc08FRO1DPF6zFV7Q)](https://mermaid.live/edit#pako:eNpljsEKwjAMhl8l5KToXqDIwDEPnhSmJ7tDXDMtbq20nVPUd7fixIM5hZ_v-5M7VlYxCqwb21dHcgFgk0sDcea77RImMF8vS5glSQrZKOu8Nuz9-ENk7zxJH3wVkFOgPXl-QL6rSdSUqCGBgt1FVwwrw-W_mDV2D0Wwjg5RXgxyrZufuOltiVNs2bWkVfz2_q6RGI7cskQRV0XuJFGaZ-S6czzNC6VjKcayxvMUqQu2uJkKRXAdf6Fc08FRO1DPF6zFV7Q)
