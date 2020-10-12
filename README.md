# EmiTagCheck
Software for checking EmiTag before start

12.10.2020
- Ved søk på brikkenr starter søk ved trykk på enter
- Lagt inn funksjon for søk etter startnr. Bruk startnr-felt og trykk enter
- Alle meldinger som sendes til LiveRes meldingstjeneste blir lagt inn i log-fil
- Dersom man legger inn ugyldig nummer ved startnr- og brikkesøk (feks tekst), så får man en advarsel og søk blir ikke utført
- Lagt inn et valg hvor man kan slå av og på varsellyd ved "Ukjent brikkenr"
- Knapp for lesing av ECU og MTR blinker når lesing er aktiv.

04.10.2020
- Lagt inn funksjon for søk i arrangementer i LiveRes database. Skriv inn løps-id og søk opp arrangement.
- Fikset feil med feil medling i log-bilde. Navn på forrige løper ble listet selv om det var ukjent brikke
- Lagt inn funksjon som sender melding til LiveRes om at brikke er sjekket (https://api.freidig.idrett.no/messageapi.php?method=setecardchecked&comp=10006&dbid=340)
