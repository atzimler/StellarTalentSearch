FROM debian:buster

RUN apt-get update
RUN apt-get install -y wget

# Install Microsoft Trusted Keys
RUN wget \
    https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb \
    -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN rm packages-microsoft-prod.deb

RUN apt-get update
RUN apt-get install -y apt-transport-https
RUN apt-get install -y aspnetcore-runtime-5.0
RUN apt-get install -y dotnet-runtime-5.0

# Install apache
RUN apt-get install -y apache2
RUN a2enmod ssl
RUN a2enmod proxy
RUN a2enmod proxy_http
RUN a2enmod headers

COPY Hosting/site.conf /etc/apache2/sites-available/site.conf
RUN a2ensite site
RUN echo ServerName talent.stellar >> /etc/apache2/apache2.conf

COPY Hosting/docker-entrypoint.sh /docker-entrypoint.sh
RUN chmod 755 docker-entrypoint.sh

RUN mkdir /certs

RUN mkdir /app
WORKDIR /app


EXPOSE 443
ENTRYPOINT ["/docker-entrypoint.sh"]
