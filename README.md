Initial notes - I took this as a learning project given the circumstances.

TODO:
- Document decision on going with .NET 5.0 -> I wanted to hone my skills a bit further
- Creating automatically a self signed certificate in the container.
- Add authentication, research what would be an easy way to add auth as an independent slice
- Add database to as docker compose backend.
- Add Makefile to bring the whole system up in a quick way. 

To document:
- Setting up the development docker environment -> talent.stellar hosts
- Starting the container environment

References:
---
- Quickstart on the MSSQL docker container with docker compose: https://docs.docker.com/samples/aspnet-mssql-compose/
- Providing environment variables for docker-compose from outside of the .yml file: https://docs.docker.com/compose/env-file/
- Generating self-signed SSL certificate for Apache on Linux: https://www.linux.com/training-tutorials/creating-self-signed-ssl-certificates-apache-linux/
- 