# EmiTagCheck
Software for checking EmiTag before start

04.10.2020
- Lagt inn funksjon for søk i arrangementer i LiveRes database. Skriv inn løps-id og søk opp arrangement.
- Fikset feil med feil medling i log-bilde. Navn på forrige løper ble listet selv om det var ukjent brikke
- Lagt inn funksjon som sender melding til LiveRes om at brikke er sjekket (https://api.freidig.idrett.no/messageapi.php?method=setecardchecked&comp=10006&dbid=340)
