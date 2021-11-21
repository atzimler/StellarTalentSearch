#! /bin/bash

if [ ! -f /certs/privkey.pem -o ! -f /certs/fullchain.pem ]; then
  yes "" | /usr/bin/openssl req -nodes -x509 -keyout /certs/privkey.pem -out /certs/fullchain.pem -subj '/CN=talent.stellar/'
fi

/usr/sbin/apachectl start
dotnet StellarTalentSearch.dll
