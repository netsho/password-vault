
# Password Vault
![Static Badge](https://img.shields.io/badge/In_development-blue)


![App Screenshot](https://via.placeholder.com/468x300?text=App+Screenshot+Here)<p align="center">
[Overview](#overview) |
[Technologies](#technologies) |
[Installation](#installation) |
[Configuration](#configuration) |
[Documentation](#documentation) |
[License](#license)
</p>

## Overview

Password Vault is a secure desktop password manager developed in C# allowing users to store and manage their passwords in an encrypted format. It uses PostgreSQL as the database for secure storage using SSL connection and Hashicorp Vault for encryption key management.

### Purpose

This project was developed to explore C#, cryptographic libraries and HashiCorp Vault. The goal was to create a secure password manager that demonstrates the use of strong encryption techniques and integrates with PostgreSQL for secure password storage using an SSL connection. Additionnaly, the implementation of HashiCorp Vault provides a robust key management system, enhancing the overall security of the application.

This project is intended to serve as both a learning resource and a practical password management solution for personal use.





## Technologies

Ensure you have the following components installed before running the application :

* [.NET](https://example.com): Version 7.0
* [PostgreSQL](https://example.com): Version 2.34
* [HashiCorp Vault](https://example.com): Version 1234
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

Go to pwdvault directory

```bash
  cd pwdvault
```

Start the application

```bash
  dotnet run
```
## Configuration

### PostgreSQL Configuration
To use SSL connection with PostgreSQL, update the `Host` and `database` in `App.config` : 

```
<connectionStrings>
	<add name="ConnectionDb" connectionString="Host=hostname;database=mydatabase;" providerName="Npgsql"/>
</connectionStrings>
```
### Vault Configuration

To use HashiCorp Vault, update the `Vault Address` in `tt.config`

```
tt
```

### SSL Certificates and Vault Secret ID

A JSON file serves as a storage for the user's SSL Certificates and Vault Secret ID, allowing for convenient access during repetitive logins :

```
%LOCALAPPDATA/PasswordVault/LoginData.json
```

### Logs

Logs are written for all application sessions and deleted within 1 month :

```
%LOCALAPPDATA/PasswordVault/Logs
```

## Documentation

[Documentation](https://github.com/netsho/password-vault/wiki)


## License

This project is licensed under the [GNU GPLv3 License](https://choosealicense.com/licenses/gpl-3.0/).

