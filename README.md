# UDAP.SCOPEs Prototype

## Overview

This project is related to defining a queryable API to help map OAuth profiles to specific OAuth scopes as it relates to HL7 UDAP. Ultimately this project should be configurable to use multiple type of databases (SQLite, MySQL, SQL Server, Postgres, etc)

## Projects

### scopes.api

The project that provides the API for developers to query to find out what scopes a profile supports. This pulls from the same database as the UI.

### scopes.ui

The UI project that allows creation of profiles and scopes and enables the mapping between the two. This adds to the same database that the api pulls from.

### scopes.database

A early project that will hande database creation and mgmt via EF core.

## Additional Information

See each projects directory for a specific readme for each project.