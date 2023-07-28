
# Password Vault
![Static Badge](https://img.shields.io/badge/In_development-blue) 
![Static Badge](https://custom-icon-badges.demolab.com/badge/-password_vault-green?logo=lock_icon)
![GitHub release (with filter)](https://img.shields.io/github/v/release/netsho/password-vault?color=blue)
![GitHub](https://img.shields.io/github/license/netsho/password-vault)

![App Screenshot](https://via.placeholder.com/468x300?text=App+Screenshot+Here)<p align="center">
[Overview](#overview) |
[Features](#features) |
[Technologies](#technologies) |
[Installation](#installation) |
[Configuration](#configuration) |
[Documentation](#documentation) |
[License](#license)
</p>

## Overview

Password Vault is a secure desktop password manager developed in C# that allows users to store and manage their passwords in an encrypted format. It uses PostgreSQL as the database for secure storage using an SSL connection and Hashicorp Vault for encryption key management.

### Purpose

This project was developed to explore C#, cryptographic libraries, and the HashiCorp Vault. The goal was to create a secure password manager that demonstrates the use of strong encryption techniques and integrates with PostgreSQL for secure password storage using an SSL connection. Additionally, the implementation of HashiCorp Vault provides a robust key management system, enhancing the overall security of the application.

This project is intended to serve as both a learning resource and a practical password management solution for personal use.

## Features

- Strong password encryption: 
    - Argon2id for hashing the account's password and key encryption derivation for each app password
    - AES256 for app password encryption
- PostgreSQL with an SSL connection for encrypted password storage
- Password generation functionality
- Multi-factor authentication (MFA): username/password and SSL certificates
- Hashicorp Vault for encryption key management

## Technologies

Ensure you have the following components installed before running the application:

* [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/7.0): Version 7.0
* [PostgreSQL](https://www.postgresql.org/download/): Version 14.8+
* [HashiCorp Vault](https://developer.hashicorp.com/vault/downloads): Version 1.14.0
## Installation

Clone the project

```bash
  git clone https://github.com/netsho/password-vault.git
```

Go to the project directory

```bash
  cd password-vault
```

Build the project

```bash
  dotnet build
```

Go to the pwdvault directory

```bash
  cd pwdvault
```

Start the application

```bash
  dotnet run
```

Sign Up when the application has started to create the scheme in database (only the first time).

## Configuration

### PostgreSQL Configuration
To use SSL connection with PostgreSQL, update the `host`, `database` and `username` in `App.config`: 

```
<connectionStrings>
	<add name="ConnectionDb" connectionString="Host=hostname;database=mydatabase;username=db_username;ssl mode=verifyfull;" providerName="Npgsql"/>
</connectionStrings>
```
### Vault Configuration 
The authentication to HashiCorp Vault is made using AppRole, and the secret engine used to store encryption keys is KV-2 (Key/Value version 2).
To use HashiCorp Vault, update the `VaultServerUri`, `RoleID` of the AppRole, and `SecretPath` of the KV2 secret engine  in `App.config`

```
<appSettings>
	<add key="VaultServerUri" value="ServerAddress:Port"/>
	<add key="RoleID" value="RoleId"/>
	<add key="SecretPath" value="Path_Of_KV2_Engine"/>
</appSettings>
```

### SSL Certificates and Vault Secret ID

A JSON file serves as storage for the user's SSL Certificates and Vault Secret ID, allowing for convenient access during repetitive logins:

```
%LOCALAPPDATA/PasswordVault/LoginData.json
```

### Logs

Logs are written for all application sessions and deleted within 1 month:

```
%LOCALAPPDATA/PasswordVault/Logs
```

## Documentation

For detailed documentation of the other possible configurations of the application, like using database connections without SSL certificates, please visit the [Wiki](https://github.com/netsho/password-vault/wiki).


## License

This project is licensed under the [GNU GPLv3 License](https://choosealicense.com/licenses/gpl-3.0/).

## Links

1. [PostgreSQL on .NET - Npgsql](https://www.npgsql.org/efcore/index.html)
2. [Vault on .NET - VaultSharp](https://rajanadar.github.io/VaultSharp/)
